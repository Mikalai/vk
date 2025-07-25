using System;
using System.Collections.Generic;
using System.CommandLine;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Vk.Generator
{
    public class Program
    {
        public static async Task<int> Main(string[] args)
        {
            var outputOption = new Option<string>(
                aliases: new[] { "-o", "--out" },
                description: "The folder into which code is generated. Defaults to the application directory.",
                getDefaultValue: () => AppContext.BaseDirectory
            );

            var rootCommand = new RootCommand("Vulkan code generator")
            {
                outputOption
            };

            rootCommand.SetHandler((string outputPath) =>
            {
                Configuration.CodeOutputPath = outputPath;

                if (File.Exists(outputPath))
                {
                    Console.Error.WriteLine("The given path is a file, not a folder.");
                    Environment.Exit(1);
                }
                else if (!Directory.Exists(outputPath))
                {
                    Directory.CreateDirectory(outputPath);
                }

                using var fs = File.OpenRead(Path.Combine(AppContext.BaseDirectory, "vk.xml"));
                VulkanSpecification vs = VulkanSpecification.LoadFromXmlStream(fs);

                TypeNameMappings tnm = new TypeNameMappings();
                foreach (var typedef in vs.Typedefs.ToArray())
                {
                    if (typedef.Requires != null)
                    {
                        tnm.AddMapping(typedef.Requires, typedef.Name);
                    }
                    else
                    {
                        tnm.AddMapping(typedef.Name, "uint");
                    }
                }

                HashSet<string> definedBaseTypes = new HashSet<string>
                {
                    "VkBool32"
                };

                if (Configuration.MapBaseTypes)
                {
                    foreach (var baseType in vs.BaseTypes)
                    {
                        if (!definedBaseTypes.Contains(baseType.Key))
                        {
                            tnm.AddMapping(baseType.Key, baseType.Value);
                        }
                    }
                }

                CodeGenerator.GenerateCodeFiles(vs, tnm, Configuration.CodeOutputPath);
            }, outputOption);

            return await rootCommand.InvokeAsync(args);
        }
    }
}
