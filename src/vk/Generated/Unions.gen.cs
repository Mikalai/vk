// This file is generated.

using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct VkClearColorValue
    {
        [FieldOffset(0)]
        public float float32_0;
        [FieldOffset(4)]
        public float float32_1;
        [FieldOffset(8)]
        public float float32_2;
        [FieldOffset(12)]
        public float float32_3;
        [FieldOffset(0)]
        public int int32_0;
        [FieldOffset(4)]
        public int int32_1;
        [FieldOffset(8)]
        public int int32_2;
        [FieldOffset(12)]
        public int int32_3;
        [FieldOffset(0)]
        public uint uint32_0;
        [FieldOffset(4)]
        public uint uint32_1;
        [FieldOffset(8)]
        public uint uint32_2;
        [FieldOffset(12)]
        public uint uint32_3;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct VkClearValue
    {
        [FieldOffset(0)]
        public VkClearColorValue color;
        [FieldOffset(0)]
        public VkClearDepthStencilValue depthStencil;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct VkClusterAccelerationStructureOpInputNV
    {
        [FieldOffset(0)]
        public VkClusterAccelerationStructureClustersBottomLevelInputNV* pClustersBottomLevel;
        [FieldOffset(0)]
        public VkClusterAccelerationStructureTriangleClusterInputNV* pTriangleClusters;
        [FieldOffset(0)]
        public VkClusterAccelerationStructureMoveObjectsInputNV* pMoveObjects;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct VkPerformanceCounterResultKHR
    {
        [FieldOffset(0)]
        public int int32;
        [FieldOffset(0)]
        public long int64;
        [FieldOffset(0)]
        public uint uint32;
        [FieldOffset(0)]
        public ulong uint64;
        [FieldOffset(0)]
        public float float32;
        [FieldOffset(0)]
        public double float64;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct VkPerformanceValueDataINTEL
    {
        [FieldOffset(0)]
        public uint value32;
        [FieldOffset(0)]
        public ulong value64;
        [FieldOffset(0)]
        public float valueFloat;
        [FieldOffset(0)]
        public VkBool32 valueBool;
        [FieldOffset(0)]
        public byte* valueString;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct VkPipelineExecutableStatisticValueKHR
    {
        [FieldOffset(0)]
        public VkBool32 b32;
        [FieldOffset(0)]
        public long i64;
        [FieldOffset(0)]
        public ulong u64;
        [FieldOffset(0)]
        public double f64;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct VkDeviceOrHostAddressKHR
    {
        [FieldOffset(0)]
        public ulong deviceAddress;
        [FieldOffset(0)]
        public void* hostAddress;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct VkDeviceOrHostAddressConstKHR
    {
        [FieldOffset(0)]
        public ulong deviceAddress;
        [FieldOffset(0)]
        public void* hostAddress;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct VkDeviceOrHostAddressConstAMDX
    {
        [FieldOffset(0)]
        public ulong deviceAddress;
        [FieldOffset(0)]
        public void* hostAddress;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct VkAccelerationStructureGeometryDataKHR
    {
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryTrianglesDataKHR triangles;
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryAabbsDataKHR aabbs;
        [FieldOffset(0)]
        public VkAccelerationStructureGeometryInstancesDataKHR instances;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct VkIndirectExecutionSetInfoEXT
    {
        [FieldOffset(0)]
        public VkIndirectExecutionSetPipelineInfoEXT* pPipelineInfo;
        [FieldOffset(0)]
        public VkIndirectExecutionSetShaderInfoEXT* pShaderInfo;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct VkIndirectCommandsTokenDataEXT
    {
        [FieldOffset(0)]
        public VkIndirectCommandsPushConstantTokenEXT* pPushConstant;
        [FieldOffset(0)]
        public VkIndirectCommandsVertexBufferTokenEXT* pVertexBuffer;
        [FieldOffset(0)]
        public VkIndirectCommandsIndexBufferTokenEXT* pIndexBuffer;
        [FieldOffset(0)]
        public VkIndirectCommandsExecutionSetTokenEXT* pExecutionSet;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct VkDescriptorDataEXT
    {
        [FieldOffset(0)]
        public VkSampler* pSampler;
        [FieldOffset(0)]
        public VkDescriptorImageInfo* pCombinedImageSampler;
        [FieldOffset(0)]
        public VkDescriptorImageInfo* pInputAttachmentImage;
        [FieldOffset(0)]
        public VkDescriptorImageInfo* pSampledImage;
        [FieldOffset(0)]
        public VkDescriptorImageInfo* pStorageImage;
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* pUniformTexelBuffer;
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* pStorageTexelBuffer;
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* pUniformBuffer;
        [FieldOffset(0)]
        public VkDescriptorAddressInfoEXT* pStorageBuffer;
        [FieldOffset(0)]
        public ulong accelerationStructure;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct VkAccelerationStructureMotionInstanceDataNV
    {
        [FieldOffset(0)]
        public VkAccelerationStructureInstanceKHR staticInstance;
        [FieldOffset(0)]
        public VkAccelerationStructureMatrixMotionInstanceNV matrixMotionInstance;
        [FieldOffset(0)]
        public VkAccelerationStructureSRTMotionInstanceNV srtMotionInstance;
    }
}
