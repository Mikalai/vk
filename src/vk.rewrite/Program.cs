using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Collections.Generic;
using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Vk.Rewrite
{
    public class Program
    {
        private static TypeReference s_calliRewriteRef;
        private static MethodReference s_stringToHGlobalUtf8Ref;
        private static MethodDefinition s_freeHGlobalRef;
        private static TypeReference s_stringHandleRef;

        public static async Task<int> Main(string[] args)
        {
            var vkDllOption = new Option<string>(
                "--vkdll",
                "The location of vk.dll to rewrite."
            )
            {
                IsRequired = true
            };

            var outputOption = new Option<string>(
                "--out",
                "The output location of the rewritten DLL. If not specified, the DLL is rewritten in-place."
            );

            var rootCommand = new RootCommand("Rewrites Vulkan DLL for special method handling")
            {
                vkDllOption,
                outputOption
            };

            rootCommand.SetHandler((string vkDllPath, string outputPath) =>
            {
                RunRewrite(vkDllPath, outputPath);
            }, vkDllOption, outputOption);

            return await rootCommand.InvokeAsync(args);
        }

        private static void RunRewrite(string vkDllPath, string outputPath)
        {
            bool copiedToTemp = false;

            if (string.IsNullOrEmpty(outputPath))
            {
                outputPath = vkDllPath;
                string copyPath = Path.GetTempFileName();
                File.Copy(vkDllPath, copyPath, overwrite: true);
                vkDllPath = copyPath;
                copiedToTemp = true;
            }

            try
            {
                Rewrite(vkDllPath, outputPath);
            }
            finally
            {
                if (copiedToTemp)
                {
                    File.Delete(vkDllPath);
                }
            }
        }

        private static void Rewrite(string vkDllPath, string outputPath)
        {
            using AssemblyDefinition vkDll = AssemblyDefinition.ReadAssembly(vkDllPath);
            LoadRefs(vkDll);
            ModuleDefinition mainModule = vkDll.Modules[0];

            s_stringHandleRef = mainModule.GetType("Vulkan.StringHandle");
            TypeDefinition bindingHelpers = mainModule.GetType("Vulkan.BindingsHelpers");
            s_stringToHGlobalUtf8Ref = bindingHelpers.Methods.Single(md => md.Name == "StringToHGlobalUtf8");
            s_freeHGlobalRef = bindingHelpers.Methods.Single(md => md.Name == "FreeHGlobal");

            foreach (var type in mainModule.Types)
            {
                ProcessType(type);
            }
            vkDll.Write(outputPath);
        }

        private static void LoadRefs(AssemblyDefinition vkDll)
        {
            s_calliRewriteRef = vkDll.MainModule.GetType("Vulkan.Generator.CalliRewriteAttribute");
        }

        private static void ProcessType(TypeDefinition type)
        {
            foreach (var method in type.Methods)
            {
                ProcessMethod(method);
            }
        }

        private static void ProcessMethod(MethodDefinition method)
        {
            if (method.CustomAttributes.Any(ca => ca.AttributeType == s_calliRewriteRef))
            {
                var processor = method.Body.GetILProcessor();
                RewriteMethod(method);
                method.CustomAttributes.Remove(method.CustomAttributes.Single(ca => ca.AttributeType == s_calliRewriteRef));
            }
        }

        private static void RewriteMethod(MethodDefinition method)
        {
            var il = method.Body.GetILProcessor();
            il.Body.Instructions.Clear();

            List<VariableDefinition> stringParams = new List<VariableDefinition>();
            for (int i = 0; i < method.Parameters.Count; i++)
            {
                EmitLoadArgument(il, i, method.Parameters);
                TypeReference parameterType = method.Parameters[i].ParameterType;
                if (parameterType.FullName == "System.String")
                {
                    VariableDefinition variableDef = new VariableDefinition(s_stringHandleRef);
                    method.Body.Variables.Add(variableDef);
                    il.Emit(OpCodes.Call, s_stringToHGlobalUtf8Ref);
                    il.Emit(OpCodes.Stloc, variableDef);
                    il.Emit(OpCodes.Ldloc, variableDef);
                    stringParams.Add(variableDef);
                }
                else if (parameterType.IsByReference)
                {
                    VariableDefinition byRefVariable = new VariableDefinition(new PinnedType(parameterType));
                    method.Body.Variables.Add(byRefVariable);
                    il.Emit(OpCodes.Stloc, byRefVariable);
                    il.Emit(OpCodes.Ldloc, byRefVariable);
                    il.Emit(OpCodes.Conv_I);
                }
            }

            string functionPtrName = method.Name + "_ptr";
            var field = method.DeclaringType.Fields.SingleOrDefault(fd => fd.Name == functionPtrName);
            if (field == null)
            {
                throw new InvalidOperationException("Can't find function pointer field for " + method.Name);
            }
            il.Emit(OpCodes.Ldsfld, field);

            CallSite callSite = new CallSite(method.ReturnType)
            {
                CallingConvention = MethodCallingConvention.StdCall
            };
            foreach (ParameterDefinition pd in method.Parameters)
            {
                TypeReference parameterType;
                if (pd.ParameterType.IsByReference)
                {
                    parameterType = new PointerType(pd.ParameterType.GetElementType());
                }
                else if (pd.ParameterType.FullName == "System.String")
                {
                    parameterType = s_stringHandleRef;
                }
                else
                {
                    parameterType = pd.ParameterType;
                }
                ParameterDefinition calliPD = new ParameterDefinition(pd.Name, pd.Attributes, parameterType);

                callSite.Parameters.Add(calliPD);
            }
            il.Emit(OpCodes.Calli, callSite);

            foreach (var stringVar in stringParams)
            {
                il.Emit(OpCodes.Ldloc, stringVar);
                il.Emit(OpCodes.Call, s_freeHGlobalRef);
            }

            il.Emit(OpCodes.Ret);

            if (method.Body.Variables.Count > 0)
            {
                method.Body.InitLocals = true;
            }
        }

        private static void EmitLoadArgument(ILProcessor il, int i, Collection<ParameterDefinition> parameters)
        {
            switch (i)
            {
                case 0: il.Emit(OpCodes.Ldarg_0); break;
                case 1: il.Emit(OpCodes.Ldarg_1); break;
                case 2: il.Emit(OpCodes.Ldarg_2); break;
                case 3: il.Emit(OpCodes.Ldarg_3); break;
                default: il.Emit(OpCodes.Ldarg, i); break;
            }
        }
    }
}
