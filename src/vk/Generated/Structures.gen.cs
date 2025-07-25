// This file is generated.

using System;

namespace Vulkan
{
    public unsafe partial struct VkBaseOutStructure
    {
        public VkStructureType sType;
        public VkBaseOutStructure* pNext;
    }

    public unsafe partial struct VkBaseInStructure
    {
        public VkStructureType sType;
        public VkBaseInStructure* pNext;
    }

    public unsafe partial struct VkOffset2D
    {
        public int x;
        public int y;
    }

    public unsafe partial struct VkOffset3D
    {
        public int x;
        public int y;
        public int z;
    }

    public unsafe partial struct VkExtent2D
    {
        public uint width;
        public uint height;
    }

    public unsafe partial struct VkExtent3D
    {
        public uint width;
        public uint height;
        public uint depth;
    }

    public unsafe partial struct VkViewport
    {
        public float x;
        public float y;
        public float width;
        public float height;
        public float minDepth;
        public float maxDepth;
    }

    public unsafe partial struct VkRect2D
    {
        public VkOffset2D offset;
        public VkExtent2D extent;
    }

    public unsafe partial struct VkClearRect
    {
        public VkRect2D rect;
        public uint baseArrayLayer;
        public uint layerCount;
    }

    public unsafe partial struct VkComponentMapping
    {
        public VkComponentSwizzle r;
        public VkComponentSwizzle g;
        public VkComponentSwizzle b;
        public VkComponentSwizzle a;
    }

    public unsafe partial struct VkPhysicalDeviceProperties
    {
        public uint apiVersion;
        public uint driverVersion;
        public uint vendorID;
        public uint deviceID;
        public VkPhysicalDeviceType deviceType;
        public fixed byte deviceName[(int)VulkanNative.MaxPhysicalDeviceNameSize];
        public fixed byte pipelineCacheUUID[(int)VulkanNative.UuidSize];
        public VkPhysicalDeviceLimits limits;
        public VkPhysicalDeviceSparseProperties sparseProperties;
    }

    public unsafe partial struct VkExtensionProperties
    {
        public fixed byte extensionName[(int)VulkanNative.MaxExtensionNameSize];
        public uint specVersion;
    }

    public unsafe partial struct VkLayerProperties
    {
        public fixed byte layerName[(int)VulkanNative.MaxExtensionNameSize];
        public uint specVersion;
        public uint implementationVersion;
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
    }

    public unsafe partial struct VkApplicationInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pApplicationName;
        public uint applicationVersion;
        public byte* pEngineName;
        public uint engineVersion;
        public uint apiVersion;
        public static VkApplicationInfo New()
        {
            VkApplicationInfo ret = new VkApplicationInfo();
            ret.sType = VkStructureType.ApplicationInfo;
            return ret;
        }
    }

    public unsafe partial struct VkAllocationCallbacks
    {
        public void* pUserData;
        public IntPtr pfnAllocation;
        public IntPtr pfnReallocation;
        public IntPtr pfnFree;
        public IntPtr pfnInternalAllocation;
        public IntPtr pfnInternalFree;
    }

    public unsafe partial struct VkDeviceQueueCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceQueueCreateFlags flags;
        public uint queueFamilyIndex;
        public uint queueCount;
        public float* pQueuePriorities;
        public static VkDeviceQueueCreateInfo New()
        {
            VkDeviceQueueCreateInfo ret = new VkDeviceQueueCreateInfo();
            ret.sType = VkStructureType.DeviceQueueCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint queueCreateInfoCount;
        public VkDeviceQueueCreateInfo* pQueueCreateInfos;
        public uint enabledLayerCount;
        public byte** ppEnabledLayerNames;
        public uint enabledExtensionCount;
        public byte** ppEnabledExtensionNames;
        public VkPhysicalDeviceFeatures* pEnabledFeatures;
        public static VkDeviceCreateInfo New()
        {
            VkDeviceCreateInfo ret = new VkDeviceCreateInfo();
            ret.sType = VkStructureType.DeviceCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkInstanceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkInstanceCreateFlags flags;
        public VkApplicationInfo* pApplicationInfo;
        public uint enabledLayerCount;
        public byte** ppEnabledLayerNames;
        public uint enabledExtensionCount;
        public byte** ppEnabledExtensionNames;
        public static VkInstanceCreateInfo New()
        {
            VkInstanceCreateInfo ret = new VkInstanceCreateInfo();
            ret.sType = VkStructureType.InstanceCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkQueueFamilyProperties
    {
        public VkQueueFlags queueFlags;
        public uint queueCount;
        public uint timestampValidBits;
        public VkExtent3D minImageTransferGranularity;
    }

    public unsafe partial struct VkPhysicalDeviceMemoryProperties
    {
        public uint memoryTypeCount;
        public VkMemoryType memoryTypes_0;
        public VkMemoryType memoryTypes_1;
        public VkMemoryType memoryTypes_2;
        public VkMemoryType memoryTypes_3;
        public VkMemoryType memoryTypes_4;
        public VkMemoryType memoryTypes_5;
        public VkMemoryType memoryTypes_6;
        public VkMemoryType memoryTypes_7;
        public VkMemoryType memoryTypes_8;
        public VkMemoryType memoryTypes_9;
        public VkMemoryType memoryTypes_10;
        public VkMemoryType memoryTypes_11;
        public VkMemoryType memoryTypes_12;
        public VkMemoryType memoryTypes_13;
        public VkMemoryType memoryTypes_14;
        public VkMemoryType memoryTypes_15;
        public VkMemoryType memoryTypes_16;
        public VkMemoryType memoryTypes_17;
        public VkMemoryType memoryTypes_18;
        public VkMemoryType memoryTypes_19;
        public VkMemoryType memoryTypes_20;
        public VkMemoryType memoryTypes_21;
        public VkMemoryType memoryTypes_22;
        public VkMemoryType memoryTypes_23;
        public VkMemoryType memoryTypes_24;
        public VkMemoryType memoryTypes_25;
        public VkMemoryType memoryTypes_26;
        public VkMemoryType memoryTypes_27;
        public VkMemoryType memoryTypes_28;
        public VkMemoryType memoryTypes_29;
        public VkMemoryType memoryTypes_30;
        public VkMemoryType memoryTypes_31;
        public uint memoryHeapCount;
        public VkMemoryHeap memoryHeaps_0;
        public VkMemoryHeap memoryHeaps_1;
        public VkMemoryHeap memoryHeaps_2;
        public VkMemoryHeap memoryHeaps_3;
        public VkMemoryHeap memoryHeaps_4;
        public VkMemoryHeap memoryHeaps_5;
        public VkMemoryHeap memoryHeaps_6;
        public VkMemoryHeap memoryHeaps_7;
        public VkMemoryHeap memoryHeaps_8;
        public VkMemoryHeap memoryHeaps_9;
        public VkMemoryHeap memoryHeaps_10;
        public VkMemoryHeap memoryHeaps_11;
        public VkMemoryHeap memoryHeaps_12;
        public VkMemoryHeap memoryHeaps_13;
        public VkMemoryHeap memoryHeaps_14;
        public VkMemoryHeap memoryHeaps_15;
    }

    public unsafe partial struct VkMemoryAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong allocationSize;
        public uint memoryTypeIndex;
        public static VkMemoryAllocateInfo New()
        {
            VkMemoryAllocateInfo ret = new VkMemoryAllocateInfo();
            ret.sType = VkStructureType.MemoryAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryRequirements
    {
        public ulong size;
        public ulong alignment;
        public uint memoryTypeBits;
    }

    public unsafe partial struct VkSparseImageFormatProperties
    {
        public VkImageAspectFlags aspectMask;
        public VkExtent3D imageGranularity;
        public VkSparseImageFormatFlags flags;
    }

    public unsafe partial struct VkSparseImageMemoryRequirements
    {
        public VkSparseImageFormatProperties formatProperties;
        public uint imageMipTailFirstLod;
        public ulong imageMipTailSize;
        public ulong imageMipTailOffset;
        public ulong imageMipTailStride;
    }

    public unsafe partial struct VkMemoryType
    {
        public VkMemoryPropertyFlags propertyFlags;
        public uint heapIndex;
    }

    public unsafe partial struct VkMemoryHeap
    {
        public ulong size;
        public VkMemoryHeapFlags flags;
    }

    public unsafe partial struct VkMappedMemoryRange
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public ulong offset;
        public ulong size;
        public static VkMappedMemoryRange New()
        {
            VkMappedMemoryRange ret = new VkMappedMemoryRange();
            ret.sType = VkStructureType.MappedMemoryRange;
            return ret;
        }
    }

    public unsafe partial struct VkFormatProperties
    {
        public VkFormatFeatureFlags linearTilingFeatures;
        public VkFormatFeatureFlags optimalTilingFeatures;
        public VkFormatFeatureFlags bufferFeatures;
    }

    public unsafe partial struct VkImageFormatProperties
    {
        public VkExtent3D maxExtent;
        public uint maxMipLevels;
        public uint maxArrayLayers;
        public VkSampleCountFlags sampleCounts;
        public ulong maxResourceSize;
    }

    public unsafe partial struct VkDescriptorBufferInfo
    {
        public VkBuffer buffer;
        public ulong offset;
        public ulong range;
    }

    public unsafe partial struct VkDescriptorImageInfo
    {
        public VkSampler sampler;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
    }

    public unsafe partial struct VkWriteDescriptorSet
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSet dstSet;
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public VkDescriptorType descriptorType;
        public VkDescriptorImageInfo* pImageInfo;
        public VkDescriptorBufferInfo* pBufferInfo;
        public VkBufferView* pTexelBufferView;
        public static VkWriteDescriptorSet New()
        {
            VkWriteDescriptorSet ret = new VkWriteDescriptorSet();
            ret.sType = VkStructureType.WriteDescriptorSet;
            return ret;
        }
    }

    public unsafe partial struct VkCopyDescriptorSet
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSet srcSet;
        public uint srcBinding;
        public uint srcArrayElement;
        public VkDescriptorSet dstSet;
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public static VkCopyDescriptorSet New()
        {
            VkCopyDescriptorSet ret = new VkCopyDescriptorSet();
            ret.sType = VkStructureType.CopyDescriptorSet;
            return ret;
        }
    }

    public unsafe partial struct VkBufferUsageFlags2CreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint usage;
        public static VkBufferUsageFlags2CreateInfo New()
        {
            VkBufferUsageFlags2CreateInfo ret = new VkBufferUsageFlags2CreateInfo();
            ret.sType = VkStructureType.BufferUsage2CreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBufferUsageFlags2CreateInfoKHR
    {
    }

    public unsafe partial struct VkBufferCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCreateFlags flags;
        public ulong size;
        public VkBufferUsageFlags usage;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public static VkBufferCreateInfo New()
        {
            VkBufferCreateInfo ret = new VkBufferCreateInfo();
            ret.sType = VkStructureType.BufferCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBufferViewCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkBuffer buffer;
        public VkFormat format;
        public ulong offset;
        public ulong range;
        public static VkBufferViewCreateInfo New()
        {
            VkBufferViewCreateInfo ret = new VkBufferViewCreateInfo();
            ret.sType = VkStructureType.BufferViewCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkImageSubresource
    {
        public VkImageAspectFlags aspectMask;
        public uint mipLevel;
        public uint arrayLayer;
    }

    public unsafe partial struct VkImageSubresourceLayers
    {
        public VkImageAspectFlags aspectMask;
        public uint mipLevel;
        public uint baseArrayLayer;
        public uint layerCount;
    }

    public unsafe partial struct VkImageSubresourceRange
    {
        public VkImageAspectFlags aspectMask;
        public uint baseMipLevel;
        public uint levelCount;
        public uint baseArrayLayer;
        public uint layerCount;
    }

    public unsafe partial struct VkMemoryBarrier
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccessFlags srcAccessMask;
        public VkAccessFlags dstAccessMask;
        public static VkMemoryBarrier New()
        {
            VkMemoryBarrier ret = new VkMemoryBarrier();
            ret.sType = VkStructureType.MemoryBarrier;
            return ret;
        }
    }

    public unsafe partial struct VkBufferMemoryBarrier
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccessFlags srcAccessMask;
        public VkAccessFlags dstAccessMask;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        public static VkBufferMemoryBarrier New()
        {
            VkBufferMemoryBarrier ret = new VkBufferMemoryBarrier();
            ret.sType = VkStructureType.BufferMemoryBarrier;
            return ret;
        }
    }

    public unsafe partial struct VkImageMemoryBarrier
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccessFlags srcAccessMask;
        public VkAccessFlags dstAccessMask;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkImage image;
        public VkImageSubresourceRange subresourceRange;
        public static VkImageMemoryBarrier New()
        {
            VkImageMemoryBarrier ret = new VkImageMemoryBarrier();
            ret.sType = VkStructureType.ImageMemoryBarrier;
            return ret;
        }
    }

    public unsafe partial struct VkImageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateFlags flags;
        public VkImageType imageType;
        public VkFormat format;
        public VkExtent3D extent;
        public uint mipLevels;
        public uint arrayLayers;
        public VkSampleCountFlags samples;
        public VkImageTiling tiling;
        public VkImageUsageFlags usage;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public VkImageLayout initialLayout;
        public static VkImageCreateInfo New()
        {
            VkImageCreateInfo ret = new VkImageCreateInfo();
            ret.sType = VkStructureType.ImageCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSubresourceLayout
    {
        public ulong offset;
        public ulong size;
        public ulong rowPitch;
        public ulong arrayPitch;
        public ulong depthPitch;
    }

    public unsafe partial struct VkImageViewCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageViewCreateFlags flags;
        public VkImage image;
        public VkImageViewType viewType;
        public VkFormat format;
        public VkComponentMapping components;
        public VkImageSubresourceRange subresourceRange;
        public static VkImageViewCreateInfo New()
        {
            VkImageViewCreateInfo ret = new VkImageViewCreateInfo();
            ret.sType = VkStructureType.ImageViewCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBufferCopy
    {
        public ulong srcOffset;
        public ulong dstOffset;
        public ulong size;
    }

    public unsafe partial struct VkSparseMemoryBind
    {
        public ulong resourceOffset;
        public ulong size;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public VkSparseMemoryBindFlags flags;
    }

    public unsafe partial struct VkSparseImageMemoryBind
    {
        public VkImageSubresource subresource;
        public VkOffset3D offset;
        public VkExtent3D extent;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public VkSparseMemoryBindFlags flags;
    }

    public unsafe partial struct VkSparseBufferMemoryBindInfo
    {
        public VkBuffer buffer;
        public uint bindCount;
        public VkSparseMemoryBind* pBinds;
    }

    public unsafe partial struct VkSparseImageOpaqueMemoryBindInfo
    {
        public VkImage image;
        public uint bindCount;
        public VkSparseMemoryBind* pBinds;
    }

    public unsafe partial struct VkSparseImageMemoryBindInfo
    {
        public VkImage image;
        public uint bindCount;
        public VkSparseImageMemoryBind* pBinds;
    }

    public unsafe partial struct VkBindSparseInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreCount;
        public VkSemaphore* pWaitSemaphores;
        public uint bufferBindCount;
        public VkSparseBufferMemoryBindInfo* pBufferBinds;
        public uint imageOpaqueBindCount;
        public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;
        public uint imageBindCount;
        public VkSparseImageMemoryBindInfo* pImageBinds;
        public uint signalSemaphoreCount;
        public VkSemaphore* pSignalSemaphores;
        public static VkBindSparseInfo New()
        {
            VkBindSparseInfo ret = new VkBindSparseInfo();
            ret.sType = VkStructureType.BindSparseInfo;
            return ret;
        }
    }

    public unsafe partial struct VkImageCopy
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
    }

    public unsafe partial struct VkImageBlit
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffsets_0;
        public VkOffset3D srcOffsets_1;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffsets_0;
        public VkOffset3D dstOffsets_1;
    }

    public unsafe partial struct VkBufferImageCopy
    {
        public ulong bufferOffset;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
    }

    public unsafe partial struct VkCopyMemoryIndirectCommandNV
    {
        public ulong srcAddress;
        public ulong dstAddress;
        public ulong size;
    }

    public unsafe partial struct VkCopyMemoryToImageIndirectCommandNV
    {
        public ulong srcAddress;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
    }

    public unsafe partial struct VkImageResolve
    {
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
    }

    public unsafe partial struct VkShaderModuleCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public UIntPtr codeSize;
        public uint* pCode;
        public static VkShaderModuleCreateInfo New()
        {
            VkShaderModuleCreateInfo ret = new VkShaderModuleCreateInfo();
            ret.sType = VkStructureType.ShaderModuleCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetLayoutBinding
    {
        public uint binding;
        public VkDescriptorType descriptorType;
        public uint descriptorCount;
        public VkShaderStageFlags stageFlags;
        public VkSampler* pImmutableSamplers;
    }

    public unsafe partial struct VkDescriptorSetLayoutCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSetLayoutCreateFlags flags;
        public uint bindingCount;
        public VkDescriptorSetLayoutBinding* pBindings;
        public static VkDescriptorSetLayoutCreateInfo New()
        {
            VkDescriptorSetLayoutCreateInfo ret = new VkDescriptorSetLayoutCreateInfo();
            ret.sType = VkStructureType.DescriptorSetLayoutCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorPoolSize
    {
        public VkDescriptorType type;
        public uint descriptorCount;
    }

    public unsafe partial struct VkDescriptorPoolCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorPoolCreateFlags flags;
        public uint maxSets;
        public uint poolSizeCount;
        public VkDescriptorPoolSize* pPoolSizes;
        public static VkDescriptorPoolCreateInfo New()
        {
            VkDescriptorPoolCreateInfo ret = new VkDescriptorPoolCreateInfo();
            ret.sType = VkStructureType.DescriptorPoolCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorPool descriptorPool;
        public uint descriptorSetCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public static VkDescriptorSetAllocateInfo New()
        {
            VkDescriptorSetAllocateInfo ret = new VkDescriptorSetAllocateInfo();
            ret.sType = VkStructureType.DescriptorSetAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSpecializationMapEntry
    {
        public uint constantID;
        public uint offset;
        public UIntPtr size;
    }

    public unsafe partial struct VkSpecializationInfo
    {
        public uint mapEntryCount;
        public VkSpecializationMapEntry* pMapEntries;
        public UIntPtr dataSize;
        public void* pData;
    }

    public unsafe partial struct VkPipelineShaderStageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineShaderStageCreateFlags flags;
        public VkShaderStageFlags stage;
        public VkShaderModule module;
        public byte* pName;
        public VkSpecializationInfo* pSpecializationInfo;
        public static VkPipelineShaderStageCreateInfo New()
        {
            VkPipelineShaderStageCreateInfo ret = new VkPipelineShaderStageCreateInfo();
            ret.sType = VkStructureType.PipelineShaderStageCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkComputePipelineCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlags flags;
        public VkPipelineShaderStageCreateInfo stage;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public static VkComputePipelineCreateInfo New()
        {
            VkComputePipelineCreateInfo ret = new VkComputePipelineCreateInfo();
            ret.sType = VkStructureType.ComputePipelineCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkComputePipelineIndirectBufferInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong deviceAddress;
        public ulong size;
        public ulong pipelineDeviceAddressCaptureReplay;
        public static VkComputePipelineIndirectBufferInfoNV New()
        {
            VkComputePipelineIndirectBufferInfoNV ret = new VkComputePipelineIndirectBufferInfoNV();
            ret.sType = VkStructureType.ComputePipelineIndirectBufferInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCreateFlags2CreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public static VkPipelineCreateFlags2CreateInfo New()
        {
            VkPipelineCreateFlags2CreateInfo ret = new VkPipelineCreateFlags2CreateInfo();
            ret.sType = VkStructureType.PipelineCreate2CreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCreateFlags2CreateInfoKHR
    {
    }

    public unsafe partial struct VkVertexInputBindingDescription
    {
        public uint binding;
        public uint stride;
        public VkVertexInputRate inputRate;
    }

    public unsafe partial struct VkVertexInputAttributeDescription
    {
        public uint location;
        public uint binding;
        public VkFormat format;
        public uint offset;
    }

    public unsafe partial struct VkPipelineVertexInputStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint vertexBindingDescriptionCount;
        public VkVertexInputBindingDescription* pVertexBindingDescriptions;
        public uint vertexAttributeDescriptionCount;
        public VkVertexInputAttributeDescription* pVertexAttributeDescriptions;
        public static VkPipelineVertexInputStateCreateInfo New()
        {
            VkPipelineVertexInputStateCreateInfo ret = new VkPipelineVertexInputStateCreateInfo();
            ret.sType = VkStructureType.PipelineVertexInputStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineInputAssemblyStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkPrimitiveTopology topology;
        public VkBool32 primitiveRestartEnable;
        public static VkPipelineInputAssemblyStateCreateInfo New()
        {
            VkPipelineInputAssemblyStateCreateInfo ret = new VkPipelineInputAssemblyStateCreateInfo();
            ret.sType = VkStructureType.PipelineInputAssemblyStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineTessellationStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint patchControlPoints;
        public static VkPipelineTessellationStateCreateInfo New()
        {
            VkPipelineTessellationStateCreateInfo ret = new VkPipelineTessellationStateCreateInfo();
            ret.sType = VkStructureType.PipelineTessellationStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineViewportStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint viewportCount;
        public VkViewport* pViewports;
        public uint scissorCount;
        public VkRect2D* pScissors;
        public static VkPipelineViewportStateCreateInfo New()
        {
            VkPipelineViewportStateCreateInfo ret = new VkPipelineViewportStateCreateInfo();
            ret.sType = VkStructureType.PipelineViewportStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkBool32 depthClampEnable;
        public VkBool32 rasterizerDiscardEnable;
        public VkPolygonMode polygonMode;
        public VkCullModeFlags cullMode;
        public VkFrontFace frontFace;
        public VkBool32 depthBiasEnable;
        public float depthBiasConstantFactor;
        public float depthBiasClamp;
        public float depthBiasSlopeFactor;
        public float lineWidth;
        public static VkPipelineRasterizationStateCreateInfo New()
        {
            VkPipelineRasterizationStateCreateInfo ret = new VkPipelineRasterizationStateCreateInfo();
            ret.sType = VkStructureType.PipelineRasterizationStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineMultisampleStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkSampleCountFlags rasterizationSamples;
        public VkBool32 sampleShadingEnable;
        public float minSampleShading;
        public uint* pSampleMask;
        public VkBool32 alphaToCoverageEnable;
        public VkBool32 alphaToOneEnable;
        public static VkPipelineMultisampleStateCreateInfo New()
        {
            VkPipelineMultisampleStateCreateInfo ret = new VkPipelineMultisampleStateCreateInfo();
            ret.sType = VkStructureType.PipelineMultisampleStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineColorBlendAttachmentState
    {
        public VkBool32 blendEnable;
        public VkBlendFactor srcColorBlendFactor;
        public VkBlendFactor dstColorBlendFactor;
        public VkBlendOp colorBlendOp;
        public VkBlendFactor srcAlphaBlendFactor;
        public VkBlendFactor dstAlphaBlendFactor;
        public VkBlendOp alphaBlendOp;
        public VkColorComponentFlags colorWriteMask;
    }

    public unsafe partial struct VkPipelineColorBlendStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineColorBlendStateCreateFlags flags;
        public VkBool32 logicOpEnable;
        public VkLogicOp logicOp;
        public uint attachmentCount;
        public VkPipelineColorBlendAttachmentState* pAttachments;
        public float blendConstants_0;
        public float blendConstants_1;
        public float blendConstants_2;
        public float blendConstants_3;
        public static VkPipelineColorBlendStateCreateInfo New()
        {
            VkPipelineColorBlendStateCreateInfo ret = new VkPipelineColorBlendStateCreateInfo();
            ret.sType = VkStructureType.PipelineColorBlendStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineDynamicStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint dynamicStateCount;
        public VkDynamicState* pDynamicStates;
        public static VkPipelineDynamicStateCreateInfo New()
        {
            VkPipelineDynamicStateCreateInfo ret = new VkPipelineDynamicStateCreateInfo();
            ret.sType = VkStructureType.PipelineDynamicStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkStencilOpState
    {
        public VkStencilOp failOp;
        public VkStencilOp passOp;
        public VkStencilOp depthFailOp;
        public VkCompareOp compareOp;
        public uint compareMask;
        public uint writeMask;
        public uint reference;
    }

    public unsafe partial struct VkPipelineDepthStencilStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineDepthStencilStateCreateFlags flags;
        public VkBool32 depthTestEnable;
        public VkBool32 depthWriteEnable;
        public VkCompareOp depthCompareOp;
        public VkBool32 depthBoundsTestEnable;
        public VkBool32 stencilTestEnable;
        public VkStencilOpState front;
        public VkStencilOpState back;
        public float minDepthBounds;
        public float maxDepthBounds;
        public static VkPipelineDepthStencilStateCreateInfo New()
        {
            VkPipelineDepthStencilStateCreateInfo ret = new VkPipelineDepthStencilStateCreateInfo();
            ret.sType = VkStructureType.PipelineDepthStencilStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkGraphicsPipelineCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlags flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
        public VkPipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
        public VkPipelineTessellationStateCreateInfo* pTessellationState;
        public VkPipelineViewportStateCreateInfo* pViewportState;
        public VkPipelineRasterizationStateCreateInfo* pRasterizationState;
        public VkPipelineMultisampleStateCreateInfo* pMultisampleState;
        public VkPipelineDepthStencilStateCreateInfo* pDepthStencilState;
        public VkPipelineColorBlendStateCreateInfo* pColorBlendState;
        public VkPipelineDynamicStateCreateInfo* pDynamicState;
        public VkPipelineLayout layout;
        public VkRenderPass renderPass;
        public uint subpass;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public static VkGraphicsPipelineCreateInfo New()
        {
            VkGraphicsPipelineCreateInfo ret = new VkGraphicsPipelineCreateInfo();
            ret.sType = VkStructureType.GraphicsPipelineCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCacheCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCacheCreateFlags flags;
        public UIntPtr initialDataSize;
        public void* pInitialData;
        public static VkPipelineCacheCreateInfo New()
        {
            VkPipelineCacheCreateInfo ret = new VkPipelineCacheCreateInfo();
            ret.sType = VkStructureType.PipelineCacheCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCacheHeaderVersionOne
    {
        public uint headerSize;
        public VkPipelineCacheHeaderVersion headerVersion;
        public uint vendorID;
        public uint deviceID;
        public fixed byte pipelineCacheUUID[(int)VulkanNative.UuidSize];
    }

    public unsafe partial struct VkPipelineCacheStageValidationIndexEntry
    {
        public ulong codeSize;
        public ulong codeOffset;
    }

    public unsafe partial struct VkPipelineCacheSafetyCriticalIndexEntry
    {
        public fixed byte pipelineIdentifier[(int)VulkanNative.UuidSize];
        public ulong pipelineMemorySize;
        public ulong jsonSize;
        public ulong jsonOffset;
        public uint stageIndexCount;
        public uint stageIndexStride;
        public ulong stageIndexOffset;
    }

    public unsafe partial struct VkPipelineCacheHeaderVersionSafetyCriticalOne
    {
        public VkPipelineCacheHeaderVersionOne headerVersionOne;
        public VkPipelineCacheValidationVersion validationVersion;
        public uint implementationData;
        public uint pipelineIndexCount;
        public uint pipelineIndexStride;
        public ulong pipelineIndexOffset;
    }

    public unsafe partial struct VkPushConstantRange
    {
        public VkShaderStageFlags stageFlags;
        public uint offset;
        public uint size;
    }

    public unsafe partial struct VkPipelineBinaryCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineBinaryKeysAndDataKHR* pKeysAndDataInfo;
        public VkPipeline pipeline;
        public VkPipelineCreateInfoKHR* pPipelineCreateInfo;
        public static VkPipelineBinaryCreateInfoKHR New()
        {
            VkPipelineBinaryCreateInfoKHR ret = new VkPipelineBinaryCreateInfoKHR();
            ret.sType = VkStructureType.PipelineBinaryCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineBinaryHandlesInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint pipelineBinaryCount;
        public VkPipelineBinaryKHR* pPipelineBinaries;
        public static VkPipelineBinaryHandlesInfoKHR New()
        {
            VkPipelineBinaryHandlesInfoKHR ret = new VkPipelineBinaryHandlesInfoKHR();
            ret.sType = VkStructureType.PipelineBinaryHandlesInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineBinaryDataKHR
    {
        public UIntPtr dataSize;
        public void* pData;
    }

    public unsafe partial struct VkPipelineBinaryKeysAndDataKHR
    {
        public uint binaryCount;
        public VkPipelineBinaryKeyKHR* pPipelineBinaryKeys;
        public VkPipelineBinaryDataKHR* pPipelineBinaryData;
    }

    public unsafe partial struct VkPipelineBinaryKeyKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint keySize;
        public fixed byte key[(int)VulkanNative.MaxPipelineBinaryKeySizeKHR];
        public static VkPipelineBinaryKeyKHR New()
        {
            VkPipelineBinaryKeyKHR ret = new VkPipelineBinaryKeyKHR();
            ret.sType = VkStructureType.PipelineBinaryKeyKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineBinaryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint binaryCount;
        public VkPipelineBinaryKHR* pPipelineBinaries;
        public static VkPipelineBinaryInfoKHR New()
        {
            VkPipelineBinaryInfoKHR ret = new VkPipelineBinaryInfoKHR();
            ret.sType = VkStructureType.PipelineBinaryInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkReleaseCapturedPipelineDataInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipeline pipeline;
        public static VkReleaseCapturedPipelineDataInfoKHR New()
        {
            VkReleaseCapturedPipelineDataInfoKHR ret = new VkReleaseCapturedPipelineDataInfoKHR();
            ret.sType = VkStructureType.ReleaseCapturedPipelineDataInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineBinaryDataInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineBinaryKHR pipelineBinary;
        public static VkPipelineBinaryDataInfoKHR New()
        {
            VkPipelineBinaryDataInfoKHR ret = new VkPipelineBinaryDataInfoKHR();
            ret.sType = VkStructureType.PipelineBinaryDataInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public static VkPipelineCreateInfoKHR New()
        {
            VkPipelineCreateInfoKHR ret = new VkPipelineCreateInfoKHR();
            ret.sType = VkStructureType.PipelineCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineLayoutCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineLayoutCreateFlags flags;
        public uint setLayoutCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public uint pushConstantRangeCount;
        public VkPushConstantRange* pPushConstantRanges;
        public static VkPipelineLayoutCreateInfo New()
        {
            VkPipelineLayoutCreateInfo ret = new VkPipelineLayoutCreateInfo();
            ret.sType = VkStructureType.PipelineLayoutCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSamplerCreateFlags flags;
        public VkFilter magFilter;
        public VkFilter minFilter;
        public VkSamplerMipmapMode mipmapMode;
        public VkSamplerAddressMode addressModeU;
        public VkSamplerAddressMode addressModeV;
        public VkSamplerAddressMode addressModeW;
        public float mipLodBias;
        public VkBool32 anisotropyEnable;
        public float maxAnisotropy;
        public VkBool32 compareEnable;
        public VkCompareOp compareOp;
        public float minLod;
        public float maxLod;
        public VkBorderColor borderColor;
        public VkBool32 unnormalizedCoordinates;
        public static VkSamplerCreateInfo New()
        {
            VkSamplerCreateInfo ret = new VkSamplerCreateInfo();
            ret.sType = VkStructureType.SamplerCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCommandPoolCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandPoolCreateFlags flags;
        public uint queueFamilyIndex;
        public static VkCommandPoolCreateInfo New()
        {
            VkCommandPoolCreateInfo ret = new VkCommandPoolCreateInfo();
            ret.sType = VkStructureType.CommandPoolCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandPool commandPool;
        public VkCommandBufferLevel level;
        public uint commandBufferCount;
        public static VkCommandBufferAllocateInfo New()
        {
            VkCommandBufferAllocateInfo ret = new VkCommandBufferAllocateInfo();
            ret.sType = VkStructureType.CommandBufferAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferInheritanceInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPass renderPass;
        public uint subpass;
        public VkFramebuffer framebuffer;
        public VkBool32 occlusionQueryEnable;
        public VkQueryControlFlags queryFlags;
        public VkQueryPipelineStatisticFlags pipelineStatistics;
        public static VkCommandBufferInheritanceInfo New()
        {
            VkCommandBufferInheritanceInfo ret = new VkCommandBufferInheritanceInfo();
            ret.sType = VkStructureType.CommandBufferInheritanceInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandBufferUsageFlags flags;
        public VkCommandBufferInheritanceInfo* pInheritanceInfo;
        public static VkCommandBufferBeginInfo New()
        {
            VkCommandBufferBeginInfo ret = new VkCommandBufferBeginInfo();
            ret.sType = VkStructureType.CommandBufferBeginInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPass renderPass;
        public VkFramebuffer framebuffer;
        public VkRect2D renderArea;
        public uint clearValueCount;
        public VkClearValue* pClearValues;
        public static VkRenderPassBeginInfo New()
        {
            VkRenderPassBeginInfo ret = new VkRenderPassBeginInfo();
            ret.sType = VkStructureType.RenderPassBeginInfo;
            return ret;
        }
    }

    public unsafe partial struct VkClearDepthStencilValue
    {
        public float depth;
        public uint stencil;
    }

    public unsafe partial struct VkClearAttachment
    {
        public VkImageAspectFlags aspectMask;
        public uint colorAttachment;
        public VkClearValue clearValue;
    }

    public unsafe partial struct VkAttachmentDescription
    {
        public VkAttachmentDescriptionFlags flags;
        public VkFormat format;
        public VkSampleCountFlags samples;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkAttachmentLoadOp stencilLoadOp;
        public VkAttachmentStoreOp stencilStoreOp;
        public VkImageLayout initialLayout;
        public VkImageLayout finalLayout;
    }

    public unsafe partial struct VkAttachmentReference
    {
        public uint attachment;
        public VkImageLayout layout;
    }

    public unsafe partial struct VkSubpassDescription
    {
        public VkSubpassDescriptionFlags flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint inputAttachmentCount;
        public VkAttachmentReference* pInputAttachments;
        public uint colorAttachmentCount;
        public VkAttachmentReference* pColorAttachments;
        public VkAttachmentReference* pResolveAttachments;
        public VkAttachmentReference* pDepthStencilAttachment;
        public uint preserveAttachmentCount;
        public uint* pPreserveAttachments;
    }

    public unsafe partial struct VkSubpassDependency
    {
        public uint srcSubpass;
        public uint dstSubpass;
        public VkPipelineStageFlags srcStageMask;
        public VkPipelineStageFlags dstStageMask;
        public VkAccessFlags srcAccessMask;
        public VkAccessFlags dstAccessMask;
        public VkDependencyFlags dependencyFlags;
    }

    public unsafe partial struct VkRenderPassCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassCreateFlags flags;
        public uint attachmentCount;
        public VkAttachmentDescription* pAttachments;
        public uint subpassCount;
        public VkSubpassDescription* pSubpasses;
        public uint dependencyCount;
        public VkSubpassDependency* pDependencies;
        public static VkRenderPassCreateInfo New()
        {
            VkRenderPassCreateInfo ret = new VkRenderPassCreateInfo();
            ret.sType = VkStructureType.RenderPassCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkEventCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkEventCreateFlags flags;
        public static VkEventCreateInfo New()
        {
            VkEventCreateInfo ret = new VkEventCreateInfo();
            ret.sType = VkStructureType.EventCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkFenceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFenceCreateFlags flags;
        public static VkFenceCreateInfo New()
        {
            VkFenceCreateInfo ret = new VkFenceCreateInfo();
            ret.sType = VkStructureType.FenceCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFeatures
    {
        public VkBool32 robustBufferAccess;
        public VkBool32 fullDrawIndexUint32;
        public VkBool32 imageCubeArray;
        public VkBool32 independentBlend;
        public VkBool32 geometryShader;
        public VkBool32 tessellationShader;
        public VkBool32 sampleRateShading;
        public VkBool32 dualSrcBlend;
        public VkBool32 logicOp;
        public VkBool32 multiDrawIndirect;
        public VkBool32 drawIndirectFirstInstance;
        public VkBool32 depthClamp;
        public VkBool32 depthBiasClamp;
        public VkBool32 fillModeNonSolid;
        public VkBool32 depthBounds;
        public VkBool32 wideLines;
        public VkBool32 largePoints;
        public VkBool32 alphaToOne;
        public VkBool32 multiViewport;
        public VkBool32 samplerAnisotropy;
        public VkBool32 textureCompressionETC2;
        public VkBool32 textureCompressionASTC_LDR;
        public VkBool32 textureCompressionBC;
        public VkBool32 occlusionQueryPrecise;
        public VkBool32 pipelineStatisticsQuery;
        public VkBool32 vertexPipelineStoresAndAtomics;
        public VkBool32 fragmentStoresAndAtomics;
        public VkBool32 shaderTessellationAndGeometryPointSize;
        public VkBool32 shaderImageGatherExtended;
        public VkBool32 shaderStorageImageExtendedFormats;
        public VkBool32 shaderStorageImageMultisample;
        public VkBool32 shaderStorageImageReadWithoutFormat;
        public VkBool32 shaderStorageImageWriteWithoutFormat;
        public VkBool32 shaderUniformBufferArrayDynamicIndexing;
        public VkBool32 shaderSampledImageArrayDynamicIndexing;
        public VkBool32 shaderStorageBufferArrayDynamicIndexing;
        public VkBool32 shaderStorageImageArrayDynamicIndexing;
        public VkBool32 shaderClipDistance;
        public VkBool32 shaderCullDistance;
        public VkBool32 shaderFloat64;
        public VkBool32 shaderInt64;
        public VkBool32 shaderInt16;
        public VkBool32 shaderResourceResidency;
        public VkBool32 shaderResourceMinLod;
        public VkBool32 sparseBinding;
        public VkBool32 sparseResidencyBuffer;
        public VkBool32 sparseResidencyImage2D;
        public VkBool32 sparseResidencyImage3D;
        public VkBool32 sparseResidency2Samples;
        public VkBool32 sparseResidency4Samples;
        public VkBool32 sparseResidency8Samples;
        public VkBool32 sparseResidency16Samples;
        public VkBool32 sparseResidencyAliased;
        public VkBool32 variableMultisampleRate;
        public VkBool32 inheritedQueries;
    }

    public unsafe partial struct VkPhysicalDeviceSparseProperties
    {
        public VkBool32 residencyStandard2DBlockShape;
        public VkBool32 residencyStandard2DMultisampleBlockShape;
        public VkBool32 residencyStandard3DBlockShape;
        public VkBool32 residencyAlignedMipSize;
        public VkBool32 residencyNonResidentStrict;
    }

    public unsafe partial struct VkPhysicalDeviceLimits
    {
        public uint maxImageDimension1D;
        public uint maxImageDimension2D;
        public uint maxImageDimension3D;
        public uint maxImageDimensionCube;
        public uint maxImageArrayLayers;
        public uint maxTexelBufferElements;
        public uint maxUniformBufferRange;
        public uint maxStorageBufferRange;
        public uint maxPushConstantsSize;
        public uint maxMemoryAllocationCount;
        public uint maxSamplerAllocationCount;
        public ulong bufferImageGranularity;
        public ulong sparseAddressSpaceSize;
        public uint maxBoundDescriptorSets;
        public uint maxPerStageDescriptorSamplers;
        public uint maxPerStageDescriptorUniformBuffers;
        public uint maxPerStageDescriptorStorageBuffers;
        public uint maxPerStageDescriptorSampledImages;
        public uint maxPerStageDescriptorStorageImages;
        public uint maxPerStageDescriptorInputAttachments;
        public uint maxPerStageResources;
        public uint maxDescriptorSetSamplers;
        public uint maxDescriptorSetUniformBuffers;
        public uint maxDescriptorSetUniformBuffersDynamic;
        public uint maxDescriptorSetStorageBuffers;
        public uint maxDescriptorSetStorageBuffersDynamic;
        public uint maxDescriptorSetSampledImages;
        public uint maxDescriptorSetStorageImages;
        public uint maxDescriptorSetInputAttachments;
        public uint maxVertexInputAttributes;
        public uint maxVertexInputBindings;
        public uint maxVertexInputAttributeOffset;
        public uint maxVertexInputBindingStride;
        public uint maxVertexOutputComponents;
        public uint maxTessellationGenerationLevel;
        public uint maxTessellationPatchSize;
        public uint maxTessellationControlPerVertexInputComponents;
        public uint maxTessellationControlPerVertexOutputComponents;
        public uint maxTessellationControlPerPatchOutputComponents;
        public uint maxTessellationControlTotalOutputComponents;
        public uint maxTessellationEvaluationInputComponents;
        public uint maxTessellationEvaluationOutputComponents;
        public uint maxGeometryShaderInvocations;
        public uint maxGeometryInputComponents;
        public uint maxGeometryOutputComponents;
        public uint maxGeometryOutputVertices;
        public uint maxGeometryTotalOutputComponents;
        public uint maxFragmentInputComponents;
        public uint maxFragmentOutputAttachments;
        public uint maxFragmentDualSrcAttachments;
        public uint maxFragmentCombinedOutputResources;
        public uint maxComputeSharedMemorySize;
        public uint maxComputeWorkGroupCount_0;
        public uint maxComputeWorkGroupCount_1;
        public uint maxComputeWorkGroupCount_2;
        public uint maxComputeWorkGroupInvocations;
        public uint maxComputeWorkGroupSize_0;
        public uint maxComputeWorkGroupSize_1;
        public uint maxComputeWorkGroupSize_2;
        public uint subPixelPrecisionBits;
        public uint subTexelPrecisionBits;
        public uint mipmapPrecisionBits;
        public uint maxDrawIndexedIndexValue;
        public uint maxDrawIndirectCount;
        public float maxSamplerLodBias;
        public float maxSamplerAnisotropy;
        public uint maxViewports;
        public uint maxViewportDimensions_0;
        public uint maxViewportDimensions_1;
        public float viewportBoundsRange_0;
        public float viewportBoundsRange_1;
        public uint viewportSubPixelBits;
        public UIntPtr minMemoryMapAlignment;
        public ulong minTexelBufferOffsetAlignment;
        public ulong minUniformBufferOffsetAlignment;
        public ulong minStorageBufferOffsetAlignment;
        public int minTexelOffset;
        public uint maxTexelOffset;
        public int minTexelGatherOffset;
        public uint maxTexelGatherOffset;
        public float minInterpolationOffset;
        public float maxInterpolationOffset;
        public uint subPixelInterpolationOffsetBits;
        public uint maxFramebufferWidth;
        public uint maxFramebufferHeight;
        public uint maxFramebufferLayers;
        public VkSampleCountFlags framebufferColorSampleCounts;
        public VkSampleCountFlags framebufferDepthSampleCounts;
        public VkSampleCountFlags framebufferStencilSampleCounts;
        public VkSampleCountFlags framebufferNoAttachmentsSampleCounts;
        public uint maxColorAttachments;
        public VkSampleCountFlags sampledImageColorSampleCounts;
        public VkSampleCountFlags sampledImageIntegerSampleCounts;
        public VkSampleCountFlags sampledImageDepthSampleCounts;
        public VkSampleCountFlags sampledImageStencilSampleCounts;
        public VkSampleCountFlags storageImageSampleCounts;
        public uint maxSampleMaskWords;
        public VkBool32 timestampComputeAndGraphics;
        public float timestampPeriod;
        public uint maxClipDistances;
        public uint maxCullDistances;
        public uint maxCombinedClipAndCullDistances;
        public uint discreteQueuePriorities;
        public float pointSizeRange_0;
        public float pointSizeRange_1;
        public float lineWidthRange_0;
        public float lineWidthRange_1;
        public float pointSizeGranularity;
        public float lineWidthGranularity;
        public VkBool32 strictLines;
        public VkBool32 standardSampleLocations;
        public ulong optimalBufferCopyOffsetAlignment;
        public ulong optimalBufferCopyRowPitchAlignment;
        public ulong nonCoherentAtomSize;
    }

    public unsafe partial struct VkSemaphoreCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public static VkSemaphoreCreateInfo New()
        {
            VkSemaphoreCreateInfo ret = new VkSemaphoreCreateInfo();
            ret.sType = VkStructureType.SemaphoreCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkQueryPoolCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueryPoolCreateFlags flags;
        public VkQueryType queryType;
        public uint queryCount;
        public VkQueryPipelineStatisticFlags pipelineStatistics;
        public static VkQueryPoolCreateInfo New()
        {
            VkQueryPoolCreateInfo ret = new VkQueryPoolCreateInfo();
            ret.sType = VkStructureType.QueryPoolCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkFramebufferCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFramebufferCreateFlags flags;
        public VkRenderPass renderPass;
        public uint attachmentCount;
        public VkImageView* pAttachments;
        public uint width;
        public uint height;
        public uint layers;
        public static VkFramebufferCreateInfo New()
        {
            VkFramebufferCreateInfo ret = new VkFramebufferCreateInfo();
            ret.sType = VkStructureType.FramebufferCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDrawIndirectCommand
    {
        public uint vertexCount;
        public uint instanceCount;
        public uint firstVertex;
        public uint firstInstance;
    }

    public unsafe partial struct VkDrawIndexedIndirectCommand
    {
        public uint indexCount;
        public uint instanceCount;
        public uint firstIndex;
        public int vertexOffset;
        public uint firstInstance;
    }

    public unsafe partial struct VkDispatchIndirectCommand
    {
        public uint x;
        public uint y;
        public uint z;
    }

    public unsafe partial struct VkMultiDrawInfoEXT
    {
        public uint firstVertex;
        public uint vertexCount;
    }

    public unsafe partial struct VkMultiDrawIndexedInfoEXT
    {
        public uint firstIndex;
        public uint indexCount;
        public int vertexOffset;
    }

    public unsafe partial struct VkSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreCount;
        public VkSemaphore* pWaitSemaphores;
        public VkPipelineStageFlags* pWaitDstStageMask;
        public uint commandBufferCount;
        public VkCommandBuffer* pCommandBuffers;
        public uint signalSemaphoreCount;
        public VkSemaphore* pSignalSemaphores;
        public static VkSubmitInfo New()
        {
            VkSubmitInfo ret = new VkSubmitInfo();
            ret.sType = VkStructureType.SubmitInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPropertiesKHR
    {
        public VkDisplayKHR display;
        public byte* displayName;
        public VkExtent2D physicalDimensions;
        public VkExtent2D physicalResolution;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkBool32 planeReorderPossible;
        public VkBool32 persistentContent;
    }

    public unsafe partial struct VkDisplayPlanePropertiesKHR
    {
        public VkDisplayKHR currentDisplay;
        public uint currentStackIndex;
    }

    public unsafe partial struct VkDisplayModeParametersKHR
    {
        public VkExtent2D visibleRegion;
        public uint refreshRate;
    }

    public unsafe partial struct VkDisplayModePropertiesKHR
    {
        public VkDisplayModeKHR displayMode;
        public VkDisplayModeParametersKHR parameters;
    }

    public unsafe partial struct VkDisplayModeCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkDisplayModeParametersKHR parameters;
        public static VkDisplayModeCreateInfoKHR New()
        {
            VkDisplayModeCreateInfoKHR ret = new VkDisplayModeCreateInfoKHR();
            ret.sType = VkStructureType.DisplayModeCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPlaneCapabilitiesKHR
    {
        public VkDisplayPlaneAlphaFlagsKHR supportedAlpha;
        public VkOffset2D minSrcPosition;
        public VkOffset2D maxSrcPosition;
        public VkExtent2D minSrcExtent;
        public VkExtent2D maxSrcExtent;
        public VkOffset2D minDstPosition;
        public VkOffset2D maxDstPosition;
        public VkExtent2D minDstExtent;
        public VkExtent2D maxDstExtent;
    }

    public unsafe partial struct VkDisplaySurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkDisplayModeKHR displayMode;
        public uint planeIndex;
        public uint planeStackIndex;
        public VkSurfaceTransformFlagsKHR transform;
        public float globalAlpha;
        public VkDisplayPlaneAlphaFlagsKHR alphaMode;
        public VkExtent2D imageExtent;
        public static VkDisplaySurfaceCreateInfoKHR New()
        {
            VkDisplaySurfaceCreateInfoKHR ret = new VkDisplaySurfaceCreateInfoKHR();
            ret.sType = VkStructureType.DisplaySurfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplaySurfaceStereoCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplaySurfaceStereoTypeNV stereoType;
        public static VkDisplaySurfaceStereoCreateInfoNV New()
        {
            VkDisplaySurfaceStereoCreateInfoNV ret = new VkDisplaySurfaceStereoCreateInfoNV();
            ret.sType = VkStructureType.DisplaySurfaceStereoCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPresentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRect2D srcRect;
        public VkRect2D dstRect;
        public VkBool32 persistent;
        public static VkDisplayPresentInfoKHR New()
        {
            VkDisplayPresentInfoKHR ret = new VkDisplayPresentInfoKHR();
            ret.sType = VkStructureType.DisplayPresentInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceCapabilitiesKHR
    {
        public uint minImageCount;
        public uint maxImageCount;
        public VkExtent2D currentExtent;
        public VkExtent2D minImageExtent;
        public VkExtent2D maxImageExtent;
        public uint maxImageArrayLayers;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkSurfaceTransformFlagsKHR currentTransform;
        public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
        public VkImageUsageFlags supportedUsageFlags;
    }

    public unsafe partial struct VkAndroidSurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Android.ANativeWindow* window;
        public static VkAndroidSurfaceCreateInfoKHR New()
        {
            VkAndroidSurfaceCreateInfoKHR ret = new VkAndroidSurfaceCreateInfoKHR();
            ret.sType = VkStructureType.AndroidSurfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkViSurfaceCreateInfoNN
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public void* window;
        public static VkViSurfaceCreateInfoNN New()
        {
            VkViSurfaceCreateInfoNN ret = new VkViSurfaceCreateInfoNN();
            ret.sType = VkStructureType.ViSurfaceCreateInfoNn;
            return ret;
        }
    }

    public unsafe partial struct VkWaylandSurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Wayland.wl_display* display;
        public Wayland.wl_surface* surface;
        public static VkWaylandSurfaceCreateInfoKHR New()
        {
            VkWaylandSurfaceCreateInfoKHR ret = new VkWaylandSurfaceCreateInfoKHR();
            ret.sType = VkStructureType.WaylandSurfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkWin32SurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Win32.HINSTANCE hinstance;
        public Win32.HWND hwnd;
        public static VkWin32SurfaceCreateInfoKHR New()
        {
            VkWin32SurfaceCreateInfoKHR ret = new VkWin32SurfaceCreateInfoKHR();
            ret.sType = VkStructureType.Win32SurfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkXlibSurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Xlib.Display* dpy;
        public Xlib.Window window;
        public static VkXlibSurfaceCreateInfoKHR New()
        {
            VkXlibSurfaceCreateInfoKHR ret = new VkXlibSurfaceCreateInfoKHR();
            ret.sType = VkStructureType.XlibSurfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkXcbSurfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Xcb.xcb_connection_t* connection;
        public Xcb.xcb_window_t window;
        public static VkXcbSurfaceCreateInfoKHR New()
        {
            VkXcbSurfaceCreateInfoKHR ret = new VkXcbSurfaceCreateInfoKHR();
            ret.sType = VkStructureType.XcbSurfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDirectFBSurfaceCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public DirectFB.IDirectFB* dfb;
        public DirectFB.IDirectFBSurface* surface;
        public static VkDirectFBSurfaceCreateInfoEXT New()
        {
            VkDirectFBSurfaceCreateInfoEXT ret = new VkDirectFBSurfaceCreateInfoEXT();
            ret.sType = VkStructureType.DirectfbSurfaceCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImagePipeSurfaceCreateInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint imagePipeHandle;
        public static VkImagePipeSurfaceCreateInfoFUCHSIA New()
        {
            VkImagePipeSurfaceCreateInfoFUCHSIA ret = new VkImagePipeSurfaceCreateInfoFUCHSIA();
            ret.sType = VkStructureType.ImagepipeSurfaceCreateInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkStreamDescriptorSurfaceCreateInfoGGP
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Ggp.StreamDescriptor streamDescriptor;
        public static VkStreamDescriptorSurfaceCreateInfoGGP New()
        {
            VkStreamDescriptorSurfaceCreateInfoGGP ret = new VkStreamDescriptorSurfaceCreateInfoGGP();
            ret.sType = VkStructureType.StreamDescriptorSurfaceCreateInfoGgp;
            return ret;
        }
    }

    public unsafe partial struct VkScreenSurfaceCreateInfoQNX
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Qnx.ScreenContext* context;
        public Qnx.ScreenWindow* window;
        public static VkScreenSurfaceCreateInfoQNX New()
        {
            VkScreenSurfaceCreateInfoQNX ret = new VkScreenSurfaceCreateInfoQNX();
            ret.sType = VkStructureType.ScreenSurfaceCreateInfoQnx;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceFormatKHR
    {
        public VkFormat format;
        public VkColorSpaceKHR colorSpace;
    }

    public unsafe partial struct VkSwapchainCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainCreateFlagsKHR flags;
        public VkSurfaceKHR surface;
        public uint minImageCount;
        public VkFormat imageFormat;
        public VkColorSpaceKHR imageColorSpace;
        public VkExtent2D imageExtent;
        public uint imageArrayLayers;
        public VkImageUsageFlags imageUsage;
        public VkSharingMode imageSharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public VkSurfaceTransformFlagsKHR preTransform;
        public VkCompositeAlphaFlagsKHR compositeAlpha;
        public VkPresentModeKHR presentMode;
        public VkBool32 clipped;
        public VkSwapchainKHR oldSwapchain;
        public static VkSwapchainCreateInfoKHR New()
        {
            VkSwapchainCreateInfoKHR ret = new VkSwapchainCreateInfoKHR();
            ret.sType = VkStructureType.SwapchainCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPresentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreCount;
        public VkSemaphore* pWaitSemaphores;
        public uint swapchainCount;
        public VkSwapchainKHR* pSwapchains;
        public uint* pImageIndices;
        public VkResult* pResults;
        public static VkPresentInfoKHR New()
        {
            VkPresentInfoKHR ret = new VkPresentInfoKHR();
            ret.sType = VkStructureType.PresentInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDebugReportCallbackCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugReportFlagsEXT flags;
        public IntPtr pfnCallback;
        public void* pUserData;
        public static VkDebugReportCallbackCreateInfoEXT New()
        {
            VkDebugReportCallbackCreateInfoEXT ret = new VkDebugReportCallbackCreateInfoEXT();
            ret.sType = VkStructureType.DebugReportCallbackCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkValidationFlagsEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint disabledValidationCheckCount;
        public VkValidationCheckEXT* pDisabledValidationChecks;
        public static VkValidationFlagsEXT New()
        {
            VkValidationFlagsEXT ret = new VkValidationFlagsEXT();
            ret.sType = VkStructureType.ValidationEXT;
            return ret;
        }
    }

    public unsafe partial struct VkValidationFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint enabledValidationFeatureCount;
        public VkValidationFeatureEnableEXT* pEnabledValidationFeatures;
        public uint disabledValidationFeatureCount;
        public VkValidationFeatureDisableEXT* pDisabledValidationFeatures;
        public static VkValidationFeaturesEXT New()
        {
            VkValidationFeaturesEXT ret = new VkValidationFeaturesEXT();
            ret.sType = VkStructureType.ValidationFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkLayerSettingsCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint settingCount;
        public VkLayerSettingEXT* pSettings;
        public static VkLayerSettingsCreateInfoEXT New()
        {
            VkLayerSettingsCreateInfoEXT ret = new VkLayerSettingsCreateInfoEXT();
            ret.sType = VkStructureType.LayerSettingsCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkLayerSettingEXT
    {
        public byte* pLayerName;
        public byte* pSettingName;
        public VkLayerSettingTypeEXT type;
        public uint valueCount;
        public void* pValues;
    }

    public unsafe partial struct VkApplicationParametersEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint vendorID;
        public uint deviceID;
        public uint key;
        public ulong value;
        public static VkApplicationParametersEXT New()
        {
            VkApplicationParametersEXT ret = new VkApplicationParametersEXT();
            ret.sType = VkStructureType.ApplicationParametersEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationStateRasterizationOrderAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRasterizationOrderAMD rasterizationOrder;
        public static VkPipelineRasterizationStateRasterizationOrderAMD New()
        {
            VkPipelineRasterizationStateRasterizationOrderAMD ret = new VkPipelineRasterizationStateRasterizationOrderAMD();
            ret.sType = VkStructureType.PipelineRasterizationStateRasterizationOrderAMD;
            return ret;
        }
    }

    public unsafe partial struct VkDebugMarkerObjectNameInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugReportObjectTypeEXT objectType;
        public ulong @object;
        public byte* pObjectName;
        public static VkDebugMarkerObjectNameInfoEXT New()
        {
            VkDebugMarkerObjectNameInfoEXT ret = new VkDebugMarkerObjectNameInfoEXT();
            ret.sType = VkStructureType.DebugMarkerObjectNameInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugMarkerObjectTagInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugReportObjectTypeEXT objectType;
        public ulong @object;
        public ulong tagName;
        public UIntPtr tagSize;
        public void* pTag;
        public static VkDebugMarkerObjectTagInfoEXT New()
        {
            VkDebugMarkerObjectTagInfoEXT ret = new VkDebugMarkerObjectTagInfoEXT();
            ret.sType = VkStructureType.DebugMarkerObjectTagInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugMarkerMarkerInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pMarkerName;
        public float color_0;
        public float color_1;
        public float color_2;
        public float color_3;
        public static VkDebugMarkerMarkerInfoEXT New()
        {
            VkDebugMarkerMarkerInfoEXT ret = new VkDebugMarkerMarkerInfoEXT();
            ret.sType = VkStructureType.DebugMarkerMarkerInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDedicatedAllocationImageCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dedicatedAllocation;
        public static VkDedicatedAllocationImageCreateInfoNV New()
        {
            VkDedicatedAllocationImageCreateInfoNV ret = new VkDedicatedAllocationImageCreateInfoNV();
            ret.sType = VkStructureType.DedicatedAllocationImageCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkDedicatedAllocationBufferCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dedicatedAllocation;
        public static VkDedicatedAllocationBufferCreateInfoNV New()
        {
            VkDedicatedAllocationBufferCreateInfoNV ret = new VkDedicatedAllocationBufferCreateInfoNV();
            ret.sType = VkStructureType.DedicatedAllocationBufferCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkDedicatedAllocationMemoryAllocateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkBuffer buffer;
        public static VkDedicatedAllocationMemoryAllocateInfoNV New()
        {
            VkDedicatedAllocationMemoryAllocateInfoNV ret = new VkDedicatedAllocationMemoryAllocateInfoNV();
            ret.sType = VkStructureType.DedicatedAllocationMemoryAllocateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkExternalImageFormatPropertiesNV
    {
        public VkImageFormatProperties imageFormatProperties;
        public VkExternalMemoryFeatureFlagsNV externalMemoryFeatures;
        public VkExternalMemoryHandleTypeFlagsNV exportFromImportedHandleTypes;
        public VkExternalMemoryHandleTypeFlagsNV compatibleHandleTypes;
    }

    public unsafe partial struct VkExternalMemoryImageCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagsNV handleTypes;
        public static VkExternalMemoryImageCreateInfoNV New()
        {
            VkExternalMemoryImageCreateInfoNV ret = new VkExternalMemoryImageCreateInfoNV();
            ret.sType = VkStructureType.ExternalMemoryImageCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkExportMemoryAllocateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagsNV handleTypes;
        public static VkExportMemoryAllocateInfoNV New()
        {
            VkExportMemoryAllocateInfoNV ret = new VkExportMemoryAllocateInfoNV();
            ret.sType = VkStructureType.ExportMemoryAllocateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkImportMemoryWin32HandleInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlagsNV handleType;
        public Win32.HANDLE handle;
        public static VkImportMemoryWin32HandleInfoNV New()
        {
            VkImportMemoryWin32HandleInfoNV ret = new VkImportMemoryWin32HandleInfoNV();
            ret.sType = VkStructureType.ImportMemoryWin32HandleInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkExportMemoryWin32HandleInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public Win32.SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public static VkExportMemoryWin32HandleInfoNV New()
        {
            VkExportMemoryWin32HandleInfoNV ret = new VkExportMemoryWin32HandleInfoNV();
            ret.sType = VkStructureType.ExportMemoryWin32HandleInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkExportMemorySciBufInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public Nvidia.NvSciBufAttrList pAttributes;
        public static VkExportMemorySciBufInfoNV New()
        {
            VkExportMemorySciBufInfoNV ret = new VkExportMemorySciBufInfoNV();
            ret.sType = VkStructureType.ExportMemorySciBufInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkImportMemorySciBufInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public Nvidia.NvSciBufObj handle;
        public static VkImportMemorySciBufInfoNV New()
        {
            VkImportMemorySciBufInfoNV ret = new VkImportMemorySciBufInfoNV();
            ret.sType = VkStructureType.ImportMemorySciBufInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryGetSciBufInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkMemoryGetSciBufInfoNV New()
        {
            VkMemoryGetSciBufInfoNV ret = new VkMemoryGetSciBufInfoNV();
            ret.sType = VkStructureType.MemoryGetSciBufInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkMemorySciBufPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
        public static VkMemorySciBufPropertiesNV New()
        {
            VkMemorySciBufPropertiesNV ret = new VkMemorySciBufPropertiesNV();
            ret.sType = VkStructureType.MemorySciBufPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalMemorySciBufFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 sciBufImport;
        public VkBool32 sciBufExport;
        public static VkPhysicalDeviceExternalMemorySciBufFeaturesNV New()
        {
            VkPhysicalDeviceExternalMemorySciBufFeaturesNV ret = new VkPhysicalDeviceExternalMemorySciBufFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceExternalMemorySciBufFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalSciBufFeaturesNV
    {
    }

    public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint acquireCount;
        public VkDeviceMemory* pAcquireSyncs;
        public ulong* pAcquireKeys;
        public uint* pAcquireTimeoutMilliseconds;
        public uint releaseCount;
        public VkDeviceMemory* pReleaseSyncs;
        public ulong* pReleaseKeys;
        public static VkWin32KeyedMutexAcquireReleaseInfoNV New()
        {
            VkWin32KeyedMutexAcquireReleaseInfoNV ret = new VkWin32KeyedMutexAcquireReleaseInfoNV();
            ret.sType = VkStructureType.Win32KeyedMutexAcquireReleaseInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 deviceGeneratedCommands;
        public static VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV New()
        {
            VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV ret = new VkPhysicalDeviceDeviceGeneratedCommandsFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 deviceGeneratedCompute;
        public VkBool32 deviceGeneratedComputePipelines;
        public VkBool32 deviceGeneratedComputeCaptureReplay;
        public static VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV New()
        {
            VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV ret = new VkPhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsComputeFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkDevicePrivateDataCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint privateDataSlotRequestCount;
        public static VkDevicePrivateDataCreateInfo New()
        {
            VkDevicePrivateDataCreateInfo ret = new VkDevicePrivateDataCreateInfo();
            ret.sType = VkStructureType.DevicePrivateDataCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDevicePrivateDataCreateInfoEXT
    {
    }

    public unsafe partial struct VkPrivateDataSlotCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public static VkPrivateDataSlotCreateInfo New()
        {
            VkPrivateDataSlotCreateInfo ret = new VkPrivateDataSlotCreateInfo();
            ret.sType = VkStructureType.PrivateDataSlotCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPrivateDataSlotCreateInfoEXT
    {
    }

    public unsafe partial struct VkPhysicalDevicePrivateDataFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 privateData;
        public static VkPhysicalDevicePrivateDataFeatures New()
        {
            VkPhysicalDevicePrivateDataFeatures ret = new VkPhysicalDevicePrivateDataFeatures();
            ret.sType = VkStructureType.PhysicalDevicePrivateDataFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePrivateDataFeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxGraphicsShaderGroupCount;
        public uint maxIndirectSequenceCount;
        public uint maxIndirectCommandsTokenCount;
        public uint maxIndirectCommandsStreamCount;
        public uint maxIndirectCommandsTokenOffset;
        public uint maxIndirectCommandsStreamStride;
        public uint minSequencesCountBufferOffsetAlignment;
        public uint minSequencesIndexBufferOffsetAlignment;
        public uint minIndirectCommandsBufferOffsetAlignment;
        public static VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV New()
        {
            VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV ret = new VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceClusterAccelerationStructureFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 clusterAccelerationStructure;
        public static VkPhysicalDeviceClusterAccelerationStructureFeaturesNV New()
        {
            VkPhysicalDeviceClusterAccelerationStructureFeaturesNV ret = new VkPhysicalDeviceClusterAccelerationStructureFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceClusterAccelerationStructureFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceClusterAccelerationStructurePropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxVerticesPerCluster;
        public uint maxTrianglesPerCluster;
        public uint clusterScratchByteAlignment;
        public uint clusterByteAlignment;
        public uint clusterTemplateByteAlignment;
        public uint clusterBottomLevelByteAlignment;
        public uint clusterTemplateBoundsByteAlignment;
        public uint maxClusterGeometryIndex;
        public static VkPhysicalDeviceClusterAccelerationStructurePropertiesNV New()
        {
            VkPhysicalDeviceClusterAccelerationStructurePropertiesNV ret = new VkPhysicalDeviceClusterAccelerationStructurePropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceClusterAccelerationStructurePropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkStridedDeviceAddressNV
    {
        public ulong startAddress;
        public ulong strideInBytes;
    }

    public unsafe partial struct VkRayTracingPipelineClusterAccelerationStructureCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 allowClusterAccelerationStructure;
        public static VkRayTracingPipelineClusterAccelerationStructureCreateInfoNV New()
        {
            VkRayTracingPipelineClusterAccelerationStructureCreateInfoNV ret = new VkRayTracingPipelineClusterAccelerationStructureCreateInfoNV();
            ret.sType = VkStructureType.RayTracingPipelineClusterAccelerationStructureCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV
    {
        public uint geometryIndex;
        public uint reserved;
        public uint geometryFlags;
    }

    public unsafe partial struct VkClusterAccelerationStructureMoveObjectsInfoNV
    {
        public ulong srcAccelerationStructure;
    }

    public unsafe partial struct VkClusterAccelerationStructureBuildClustersBottomLevelInfoNV
    {
        public uint clusterReferencesCount;
        public uint clusterReferencesStride;
        public ulong clusterReferences;
    }

    public unsafe partial struct VkClusterAccelerationStructureBuildTriangleClusterInfoNV
    {
        public uint clusterID;
        public VkClusterAccelerationStructureClusterFlagsNV clusterFlags;
        public uint triangleCount;
        public uint vertexCount;
        public uint positionTruncateBitCount;
        public uint indexType;
        public uint opacityMicromapIndexType;
        public VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV baseGeometryIndexAndGeometryFlags;
        public ushort indexBufferStride;
        public ushort vertexBufferStride;
        public ushort geometryIndexAndFlagsBufferStride;
        public ushort opacityMicromapIndexBufferStride;
        public ulong indexBuffer;
        public ulong vertexBuffer;
        public ulong geometryIndexAndFlagsBuffer;
        public ulong opacityMicromapArray;
        public ulong opacityMicromapIndexBuffer;
    }

    public unsafe partial struct VkClusterAccelerationStructureBuildTriangleClusterTemplateInfoNV
    {
        public uint clusterID;
        public VkClusterAccelerationStructureClusterFlagsNV clusterFlags;
        public uint triangleCount;
        public uint vertexCount;
        public uint positionTruncateBitCount;
        public uint indexType;
        public uint opacityMicromapIndexType;
        public VkClusterAccelerationStructureGeometryIndexAndGeometryFlagsNV baseGeometryIndexAndGeometryFlags;
        public ushort indexBufferStride;
        public ushort vertexBufferStride;
        public ushort geometryIndexAndFlagsBufferStride;
        public ushort opacityMicromapIndexBufferStride;
        public ulong indexBuffer;
        public ulong vertexBuffer;
        public ulong geometryIndexAndFlagsBuffer;
        public ulong opacityMicromapArray;
        public ulong opacityMicromapIndexBuffer;
        public ulong instantiationBoundingBoxLimit;
    }

    public unsafe partial struct VkClusterAccelerationStructureInstantiateClusterInfoNV
    {
        public uint clusterIdOffset;
        public uint geometryIndexOffset;
        public uint reserved;
        public ulong clusterTemplateAddress;
        public VkStridedDeviceAddressNV vertexBuffer;
    }

    public unsafe partial struct VkClusterAccelerationStructureClustersBottomLevelInputNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxTotalClusterCount;
        public uint maxClusterCountPerAccelerationStructure;
        public static VkClusterAccelerationStructureClustersBottomLevelInputNV New()
        {
            VkClusterAccelerationStructureClustersBottomLevelInputNV ret = new VkClusterAccelerationStructureClustersBottomLevelInputNV();
            ret.sType = VkStructureType.ClusterAccelerationStructureClustersBottomLevelInputNV;
            return ret;
        }
    }

    public unsafe partial struct VkClusterAccelerationStructureTriangleClusterInputNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat vertexFormat;
        public uint maxGeometryIndexValue;
        public uint maxClusterUniqueGeometryCount;
        public uint maxClusterTriangleCount;
        public uint maxClusterVertexCount;
        public uint maxTotalTriangleCount;
        public uint maxTotalVertexCount;
        public uint minPositionTruncateBitCount;
        public static VkClusterAccelerationStructureTriangleClusterInputNV New()
        {
            VkClusterAccelerationStructureTriangleClusterInputNV ret = new VkClusterAccelerationStructureTriangleClusterInputNV();
            ret.sType = VkStructureType.ClusterAccelerationStructureTriangleClusterInputNV;
            return ret;
        }
    }

    public unsafe partial struct VkClusterAccelerationStructureMoveObjectsInputNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkClusterAccelerationStructureTypeNV type;
        public VkBool32 noMoveOverlap;
        public ulong maxMovedBytes;
        public static VkClusterAccelerationStructureMoveObjectsInputNV New()
        {
            VkClusterAccelerationStructureMoveObjectsInputNV ret = new VkClusterAccelerationStructureMoveObjectsInputNV();
            ret.sType = VkStructureType.ClusterAccelerationStructureMoveObjectsInputNV;
            return ret;
        }
    }

    public unsafe partial struct VkClusterAccelerationStructureInputInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxAccelerationStructureCount;
        public VkBuildAccelerationStructureFlagsKHR flags;
        public VkClusterAccelerationStructureOpTypeNV opType;
        public VkClusterAccelerationStructureOpModeNV opMode;
        public VkClusterAccelerationStructureOpInputNV opInput;
        public static VkClusterAccelerationStructureInputInfoNV New()
        {
            VkClusterAccelerationStructureInputInfoNV ret = new VkClusterAccelerationStructureInputInfoNV();
            ret.sType = VkStructureType.ClusterAccelerationStructureInputInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkClusterAccelerationStructureCommandsInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkClusterAccelerationStructureInputInfoNV input;
        public ulong dstImplicitData;
        public ulong scratchData;
        public VkStridedDeviceAddressRegionKHR dstAddressesArray;
        public VkStridedDeviceAddressRegionKHR dstSizesArray;
        public VkStridedDeviceAddressRegionKHR srcInfosArray;
        public ulong srcInfosCount;
        public VkClusterAccelerationStructureAddressResolutionFlagsNV addressResolutionFlags;
        public static VkClusterAccelerationStructureCommandsInfoNV New()
        {
            VkClusterAccelerationStructureCommandsInfoNV ret = new VkClusterAccelerationStructureCommandsInfoNV();
            ret.sType = VkStructureType.ClusterAccelerationStructureCommandsInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultiDrawPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxMultiDrawCount;
        public static VkPhysicalDeviceMultiDrawPropertiesEXT New()
        {
            VkPhysicalDeviceMultiDrawPropertiesEXT ret = new VkPhysicalDeviceMultiDrawPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceMultiDrawPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkGraphicsShaderGroupCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public VkPipelineVertexInputStateCreateInfo* pVertexInputState;
        public VkPipelineTessellationStateCreateInfo* pTessellationState;
        public static VkGraphicsShaderGroupCreateInfoNV New()
        {
            VkGraphicsShaderGroupCreateInfoNV ret = new VkGraphicsShaderGroupCreateInfoNV();
            ret.sType = VkStructureType.GraphicsShaderGroupCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkGraphicsPipelineShaderGroupsCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint groupCount;
        public VkGraphicsShaderGroupCreateInfoNV* pGroups;
        public uint pipelineCount;
        public VkPipeline* pPipelines;
        public static VkGraphicsPipelineShaderGroupsCreateInfoNV New()
        {
            VkGraphicsPipelineShaderGroupsCreateInfoNV ret = new VkGraphicsPipelineShaderGroupsCreateInfoNV();
            ret.sType = VkStructureType.GraphicsPipelineShaderGroupsCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkBindShaderGroupIndirectCommandNV
    {
        public uint groupIndex;
    }

    public unsafe partial struct VkBindIndexBufferIndirectCommandNV
    {
        public ulong bufferAddress;
        public uint size;
        public VkIndexType indexType;
    }

    public unsafe partial struct VkBindVertexBufferIndirectCommandNV
    {
        public ulong bufferAddress;
        public uint size;
        public uint stride;
    }

    public unsafe partial struct VkSetStateFlagsIndirectCommandNV
    {
        public uint data;
    }

    public unsafe partial struct VkIndirectCommandsStreamNV
    {
        public VkBuffer buffer;
        public ulong offset;
    }

    public unsafe partial struct VkIndirectCommandsLayoutTokenNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndirectCommandsTokenTypeNV tokenType;
        public uint stream;
        public uint offset;
        public uint vertexBindingUnit;
        public VkBool32 vertexDynamicStride;
        public VkPipelineLayout pushconstantPipelineLayout;
        public VkShaderStageFlags pushconstantShaderStageFlags;
        public uint pushconstantOffset;
        public uint pushconstantSize;
        public VkIndirectStateFlagsNV indirectStateFlags;
        public uint indexTypeCount;
        public VkIndexType* pIndexTypes;
        public uint* pIndexTypeValues;
        public static VkIndirectCommandsLayoutTokenNV New()
        {
            VkIndirectCommandsLayoutTokenNV ret = new VkIndirectCommandsLayoutTokenNV();
            ret.sType = VkStructureType.IndirectCommandsLayoutTokenNV;
            return ret;
        }
    }

    public unsafe partial struct VkIndirectCommandsLayoutCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndirectCommandsLayoutUsageFlagsNV flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint tokenCount;
        public VkIndirectCommandsLayoutTokenNV* pTokens;
        public uint streamCount;
        public uint* pStreamStrides;
        public static VkIndirectCommandsLayoutCreateInfoNV New()
        {
            VkIndirectCommandsLayoutCreateInfoNV ret = new VkIndirectCommandsLayoutCreateInfoNV();
            ret.sType = VkStructureType.IndirectCommandsLayoutCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkGeneratedCommandsInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipeline pipeline;
        public VkIndirectCommandsLayoutNV indirectCommandsLayout;
        public uint streamCount;
        public VkIndirectCommandsStreamNV* pStreams;
        public uint sequencesCount;
        public VkBuffer preprocessBuffer;
        public ulong preprocessOffset;
        public ulong preprocessSize;
        public VkBuffer sequencesCountBuffer;
        public ulong sequencesCountOffset;
        public VkBuffer sequencesIndexBuffer;
        public ulong sequencesIndexOffset;
        public static VkGeneratedCommandsInfoNV New()
        {
            VkGeneratedCommandsInfoNV ret = new VkGeneratedCommandsInfoNV();
            ret.sType = VkStructureType.GeneratedCommandsInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkGeneratedCommandsMemoryRequirementsInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipeline pipeline;
        public VkIndirectCommandsLayoutNV indirectCommandsLayout;
        public uint maxSequencesCount;
        public static VkGeneratedCommandsMemoryRequirementsInfoNV New()
        {
            VkGeneratedCommandsMemoryRequirementsInfoNV ret = new VkGeneratedCommandsMemoryRequirementsInfoNV();
            ret.sType = VkStructureType.GeneratedCommandsMemoryRequirementsInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineIndirectDeviceAddressInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipeline pipeline;
        public static VkPipelineIndirectDeviceAddressInfoNV New()
        {
            VkPipelineIndirectDeviceAddressInfoNV ret = new VkPipelineIndirectDeviceAddressInfoNV();
            ret.sType = VkStructureType.PipelineIndirectDeviceAddressInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkBindPipelineIndirectCommandNV
    {
        public ulong pipelineAddress;
    }

    public unsafe partial struct VkPhysicalDeviceFeatures2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceFeatures features;
        public static VkPhysicalDeviceFeatures2 New()
        {
            VkPhysicalDeviceFeatures2 ret = new VkPhysicalDeviceFeatures2();
            ret.sType = VkStructureType.PhysicalDeviceFeatures2;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFeatures2KHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceProperties properties;
        public static VkPhysicalDeviceProperties2 New()
        {
            VkPhysicalDeviceProperties2 ret = new VkPhysicalDeviceProperties2();
            ret.sType = VkStructureType.PhysicalDeviceProperties2;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceProperties2KHR
    {
    }

    public unsafe partial struct VkFormatProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormatProperties formatProperties;
        public static VkFormatProperties2 New()
        {
            VkFormatProperties2 ret = new VkFormatProperties2();
            ret.sType = VkStructureType.FormatProperties2;
            return ret;
        }
    }

    public unsafe partial struct VkFormatProperties2KHR
    {
    }

    public unsafe partial struct VkImageFormatProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageFormatProperties imageFormatProperties;
        public static VkImageFormatProperties2 New()
        {
            VkImageFormatProperties2 ret = new VkImageFormatProperties2();
            ret.sType = VkStructureType.ImageFormatProperties2;
            return ret;
        }
    }

    public unsafe partial struct VkImageFormatProperties2KHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceImageFormatInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkImageType type;
        public VkImageTiling tiling;
        public VkImageUsageFlags usage;
        public VkImageCreateFlags flags;
        public static VkPhysicalDeviceImageFormatInfo2 New()
        {
            VkPhysicalDeviceImageFormatInfo2 ret = new VkPhysicalDeviceImageFormatInfo2();
            ret.sType = VkStructureType.PhysicalDeviceImageFormatInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageFormatInfo2KHR
    {
    }

    public unsafe partial struct VkQueueFamilyProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueueFamilyProperties queueFamilyProperties;
        public static VkQueueFamilyProperties2 New()
        {
            VkQueueFamilyProperties2 ret = new VkQueueFamilyProperties2();
            ret.sType = VkStructureType.QueueFamilyProperties2;
            return ret;
        }
    }

    public unsafe partial struct VkQueueFamilyProperties2KHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceMemoryProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceMemoryProperties memoryProperties;
        public static VkPhysicalDeviceMemoryProperties2 New()
        {
            VkPhysicalDeviceMemoryProperties2 ret = new VkPhysicalDeviceMemoryProperties2();
            ret.sType = VkStructureType.PhysicalDeviceMemoryProperties2;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMemoryProperties2KHR
    {
    }

    public unsafe partial struct VkSparseImageFormatProperties2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSparseImageFormatProperties properties;
        public static VkSparseImageFormatProperties2 New()
        {
            VkSparseImageFormatProperties2 ret = new VkSparseImageFormatProperties2();
            ret.sType = VkStructureType.SparseImageFormatProperties2;
            return ret;
        }
    }

    public unsafe partial struct VkSparseImageFormatProperties2KHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceSparseImageFormatInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkImageType type;
        public VkSampleCountFlags samples;
        public VkImageUsageFlags usage;
        public VkImageTiling tiling;
        public static VkPhysicalDeviceSparseImageFormatInfo2 New()
        {
            VkPhysicalDeviceSparseImageFormatInfo2 ret = new VkPhysicalDeviceSparseImageFormatInfo2();
            ret.sType = VkStructureType.PhysicalDeviceSparseImageFormatInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSparseImageFormatInfo2KHR
    {
    }

    public unsafe partial struct VkPhysicalDevicePushDescriptorProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPushDescriptors;
        public static VkPhysicalDevicePushDescriptorProperties New()
        {
            VkPhysicalDevicePushDescriptorProperties ret = new VkPhysicalDevicePushDescriptorProperties();
            ret.sType = VkStructureType.PhysicalDevicePushDescriptorProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePushDescriptorPropertiesKHR
    {
    }

    public unsafe partial struct VkConformanceVersion
    {
        public byte major;
        public byte minor;
        public byte subminor;
        public byte patch;
    }

    public unsafe partial struct VkConformanceVersionKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceDriverProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDriverId driverID;
        public fixed byte driverName[(int)VulkanNative.MaxDriverNameSize];
        public fixed byte driverInfo[(int)VulkanNative.MaxDriverInfoSize];
        public VkConformanceVersion conformanceVersion;
        public static VkPhysicalDeviceDriverProperties New()
        {
            VkPhysicalDeviceDriverProperties ret = new VkPhysicalDeviceDriverProperties();
            ret.sType = VkStructureType.PhysicalDeviceDriverProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDriverPropertiesKHR
    {
    }

    public unsafe partial struct VkPresentRegionsKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentRegionKHR* pRegions;
        public static VkPresentRegionsKHR New()
        {
            VkPresentRegionsKHR ret = new VkPresentRegionsKHR();
            ret.sType = VkStructureType.PresentRegionsKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPresentRegionKHR
    {
        public uint rectangleCount;
        public VkRectLayerKHR* pRectangles;
    }

    public unsafe partial struct VkRectLayerKHR
    {
        public VkOffset2D offset;
        public VkExtent2D extent;
        public uint layer;
    }

    public unsafe partial struct VkPhysicalDeviceVariablePointersFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 variablePointersStorageBuffer;
        public VkBool32 variablePointers;
        public static VkPhysicalDeviceVariablePointersFeatures New()
        {
            VkPhysicalDeviceVariablePointersFeatures ret = new VkPhysicalDeviceVariablePointersFeatures();
            ret.sType = VkStructureType.PhysicalDeviceVariablePointersFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVariablePointersFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceVariablePointerFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceVariablePointerFeatures
    {
    }

    public unsafe partial struct VkExternalMemoryProperties
    {
        public VkExternalMemoryFeatureFlags externalMemoryFeatures;
        public VkExternalMemoryHandleTypeFlags exportFromImportedHandleTypes;
        public VkExternalMemoryHandleTypeFlags compatibleHandleTypes;
    }

    public unsafe partial struct VkExternalMemoryPropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceExternalImageFormatInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkPhysicalDeviceExternalImageFormatInfo New()
        {
            VkPhysicalDeviceExternalImageFormatInfo ret = new VkPhysicalDeviceExternalImageFormatInfo();
            ret.sType = VkStructureType.PhysicalDeviceExternalImageFormatInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalImageFormatInfoKHR
    {
    }

    public unsafe partial struct VkExternalImageFormatProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryProperties externalMemoryProperties;
        public static VkExternalImageFormatProperties New()
        {
            VkExternalImageFormatProperties ret = new VkExternalImageFormatProperties();
            ret.sType = VkStructureType.ExternalImageFormatProperties;
            return ret;
        }
    }

    public unsafe partial struct VkExternalImageFormatPropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceExternalBufferInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCreateFlags flags;
        public VkBufferUsageFlags usage;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkPhysicalDeviceExternalBufferInfo New()
        {
            VkPhysicalDeviceExternalBufferInfo ret = new VkPhysicalDeviceExternalBufferInfo();
            ret.sType = VkStructureType.PhysicalDeviceExternalBufferInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalBufferInfoKHR
    {
    }

    public unsafe partial struct VkExternalBufferProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryProperties externalMemoryProperties;
        public static VkExternalBufferProperties New()
        {
            VkExternalBufferProperties ret = new VkExternalBufferProperties();
            ret.sType = VkStructureType.ExternalBufferProperties;
            return ret;
        }
    }

    public unsafe partial struct VkExternalBufferPropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceIDProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte deviceUUID[(int)VulkanNative.UuidSize];
        public fixed byte driverUUID[(int)VulkanNative.UuidSize];
        public fixed byte deviceLUID[(int)VulkanNative.LuidSize];
        public uint deviceNodeMask;
        public VkBool32 deviceLUIDValid;
        public static VkPhysicalDeviceIDProperties New()
        {
            VkPhysicalDeviceIDProperties ret = new VkPhysicalDeviceIDProperties();
            ret.sType = VkStructureType.PhysicalDeviceIdProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceIDPropertiesKHR
    {
    }

    public unsafe partial struct VkExternalMemoryImageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleTypes;
        public static VkExternalMemoryImageCreateInfo New()
        {
            VkExternalMemoryImageCreateInfo ret = new VkExternalMemoryImageCreateInfo();
            ret.sType = VkStructureType.ExternalMemoryImageCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkExternalMemoryImageCreateInfoKHR
    {
    }

    public unsafe partial struct VkExternalMemoryBufferCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleTypes;
        public static VkExternalMemoryBufferCreateInfo New()
        {
            VkExternalMemoryBufferCreateInfo ret = new VkExternalMemoryBufferCreateInfo();
            ret.sType = VkStructureType.ExternalMemoryBufferCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkExternalMemoryBufferCreateInfoKHR
    {
    }

    public unsafe partial struct VkExportMemoryAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleTypes;
        public static VkExportMemoryAllocateInfo New()
        {
            VkExportMemoryAllocateInfo ret = new VkExportMemoryAllocateInfo();
            ret.sType = VkStructureType.ExportMemoryAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkExportMemoryAllocateInfoKHR
    {
    }

    public unsafe partial struct VkImportMemoryWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public Win32.HANDLE handle;
        public IntPtr name;
        public static VkImportMemoryWin32HandleInfoKHR New()
        {
            VkImportMemoryWin32HandleInfoKHR ret = new VkImportMemoryWin32HandleInfoKHR();
            ret.sType = VkStructureType.ImportMemoryWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkExportMemoryWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public Win32.SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public IntPtr name;
        public static VkExportMemoryWin32HandleInfoKHR New()
        {
            VkExportMemoryWin32HandleInfoKHR ret = new VkExportMemoryWin32HandleInfoKHR();
            ret.sType = VkStructureType.ExportMemoryWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkImportMemoryZirconHandleInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public uint handle;
        public static VkImportMemoryZirconHandleInfoFUCHSIA New()
        {
            VkImportMemoryZirconHandleInfoFUCHSIA ret = new VkImportMemoryZirconHandleInfoFUCHSIA();
            ret.sType = VkStructureType.ImportMemoryZirconHandleInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryZirconHandlePropertiesFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
        public static VkMemoryZirconHandlePropertiesFUCHSIA New()
        {
            VkMemoryZirconHandlePropertiesFUCHSIA ret = new VkMemoryZirconHandlePropertiesFUCHSIA();
            ret.sType = VkStructureType.MemoryZirconHandlePropertiesFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryGetZirconHandleInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkMemoryGetZirconHandleInfoFUCHSIA New()
        {
            VkMemoryGetZirconHandleInfoFUCHSIA ret = new VkMemoryGetZirconHandleInfoFUCHSIA();
            ret.sType = VkStructureType.MemoryGetZirconHandleInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryWin32HandlePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
        public static VkMemoryWin32HandlePropertiesKHR New()
        {
            VkMemoryWin32HandlePropertiesKHR ret = new VkMemoryWin32HandlePropertiesKHR();
            ret.sType = VkStructureType.MemoryWin32HandlePropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryGetWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkMemoryGetWin32HandleInfoKHR New()
        {
            VkMemoryGetWin32HandleInfoKHR ret = new VkMemoryGetWin32HandleInfoKHR();
            ret.sType = VkStructureType.MemoryGetWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkImportMemoryFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public int fd;
        public static VkImportMemoryFdInfoKHR New()
        {
            VkImportMemoryFdInfoKHR ret = new VkImportMemoryFdInfoKHR();
            ret.sType = VkStructureType.ImportMemoryFdInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryFdPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
        public static VkMemoryFdPropertiesKHR New()
        {
            VkMemoryFdPropertiesKHR ret = new VkMemoryFdPropertiesKHR();
            ret.sType = VkStructureType.MemoryFdPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryGetFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkMemoryGetFdInfoKHR New()
        {
            VkMemoryGetFdInfoKHR ret = new VkMemoryGetFdInfoKHR();
            ret.sType = VkStructureType.MemoryGetFdInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkWin32KeyedMutexAcquireReleaseInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint acquireCount;
        public VkDeviceMemory* pAcquireSyncs;
        public ulong* pAcquireKeys;
        public uint* pAcquireTimeouts;
        public uint releaseCount;
        public VkDeviceMemory* pReleaseSyncs;
        public ulong* pReleaseKeys;
        public static VkWin32KeyedMutexAcquireReleaseInfoKHR New()
        {
            VkWin32KeyedMutexAcquireReleaseInfoKHR ret = new VkWin32KeyedMutexAcquireReleaseInfoKHR();
            ret.sType = VkStructureType.Win32KeyedMutexAcquireReleaseInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkImportMemoryMetalHandleInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public void* handle;
        public static VkImportMemoryMetalHandleInfoEXT New()
        {
            VkImportMemoryMetalHandleInfoEXT ret = new VkImportMemoryMetalHandleInfoEXT();
            ret.sType = VkStructureType.ImportMemoryMetalHandleInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryMetalHandlePropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
        public static VkMemoryMetalHandlePropertiesEXT New()
        {
            VkMemoryMetalHandlePropertiesEXT ret = new VkMemoryMetalHandlePropertiesEXT();
            ret.sType = VkStructureType.MemoryMetalHandlePropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryGetMetalHandleInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkMemoryGetMetalHandleInfoEXT New()
        {
            VkMemoryGetMetalHandleInfoEXT ret = new VkMemoryGetMetalHandleInfoEXT();
            ret.sType = VkStructureType.MemoryGetMetalHandleInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalSemaphoreInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public static VkPhysicalDeviceExternalSemaphoreInfo New()
        {
            VkPhysicalDeviceExternalSemaphoreInfo ret = new VkPhysicalDeviceExternalSemaphoreInfo();
            ret.sType = VkStructureType.PhysicalDeviceExternalSemaphoreInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalSemaphoreInfoKHR
    {
    }

    public unsafe partial struct VkExternalSemaphoreProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalSemaphoreHandleTypeFlags exportFromImportedHandleTypes;
        public VkExternalSemaphoreHandleTypeFlags compatibleHandleTypes;
        public VkExternalSemaphoreFeatureFlags externalSemaphoreFeatures;
        public static VkExternalSemaphoreProperties New()
        {
            VkExternalSemaphoreProperties ret = new VkExternalSemaphoreProperties();
            ret.sType = VkStructureType.ExternalSemaphoreProperties;
            return ret;
        }
    }

    public unsafe partial struct VkExternalSemaphorePropertiesKHR
    {
    }

    public unsafe partial struct VkExportSemaphoreCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalSemaphoreHandleTypeFlags handleTypes;
        public static VkExportSemaphoreCreateInfo New()
        {
            VkExportSemaphoreCreateInfo ret = new VkExportSemaphoreCreateInfo();
            ret.sType = VkStructureType.ExportSemaphoreCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkExportSemaphoreCreateInfoKHR
    {
    }

    public unsafe partial struct VkImportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlags flags;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public Win32.HANDLE handle;
        public IntPtr name;
        public static VkImportSemaphoreWin32HandleInfoKHR New()
        {
            VkImportSemaphoreWin32HandleInfoKHR ret = new VkImportSemaphoreWin32HandleInfoKHR();
            ret.sType = VkStructureType.ImportSemaphoreWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkExportSemaphoreWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public Win32.SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public IntPtr name;
        public static VkExportSemaphoreWin32HandleInfoKHR New()
        {
            VkExportSemaphoreWin32HandleInfoKHR ret = new VkExportSemaphoreWin32HandleInfoKHR();
            ret.sType = VkStructureType.ExportSemaphoreWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkD3D12FenceSubmitInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreValuesCount;
        public ulong* pWaitSemaphoreValues;
        public uint signalSemaphoreValuesCount;
        public ulong* pSignalSemaphoreValues;
        public static VkD3D12FenceSubmitInfoKHR New()
        {
            VkD3D12FenceSubmitInfoKHR ret = new VkD3D12FenceSubmitInfoKHR();
            ret.sType = VkStructureType.D3d12FenceSubmitInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreGetWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public static VkSemaphoreGetWin32HandleInfoKHR New()
        {
            VkSemaphoreGetWin32HandleInfoKHR ret = new VkSemaphoreGetWin32HandleInfoKHR();
            ret.sType = VkStructureType.SemaphoreGetWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkImportSemaphoreFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlags flags;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public int fd;
        public static VkImportSemaphoreFdInfoKHR New()
        {
            VkImportSemaphoreFdInfoKHR ret = new VkImportSemaphoreFdInfoKHR();
            ret.sType = VkStructureType.ImportSemaphoreFdInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreGetFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public static VkSemaphoreGetFdInfoKHR New()
        {
            VkSemaphoreGetFdInfoKHR ret = new VkSemaphoreGetFdInfoKHR();
            ret.sType = VkStructureType.SemaphoreGetFdInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkImportSemaphoreZirconHandleInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkSemaphoreImportFlags flags;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public uint zirconHandle;
        public static VkImportSemaphoreZirconHandleInfoFUCHSIA New()
        {
            VkImportSemaphoreZirconHandleInfoFUCHSIA ret = new VkImportSemaphoreZirconHandleInfoFUCHSIA();
            ret.sType = VkStructureType.ImportSemaphoreZirconHandleInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreGetZirconHandleInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public static VkSemaphoreGetZirconHandleInfoFUCHSIA New()
        {
            VkSemaphoreGetZirconHandleInfoFUCHSIA ret = new VkSemaphoreGetZirconHandleInfoFUCHSIA();
            ret.sType = VkStructureType.SemaphoreGetZirconHandleInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalFenceInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalFenceHandleTypeFlags handleType;
        public static VkPhysicalDeviceExternalFenceInfo New()
        {
            VkPhysicalDeviceExternalFenceInfo ret = new VkPhysicalDeviceExternalFenceInfo();
            ret.sType = VkStructureType.PhysicalDeviceExternalFenceInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalFenceInfoKHR
    {
    }

    public unsafe partial struct VkExternalFenceProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalFenceHandleTypeFlags exportFromImportedHandleTypes;
        public VkExternalFenceHandleTypeFlags compatibleHandleTypes;
        public VkExternalFenceFeatureFlags externalFenceFeatures;
        public static VkExternalFenceProperties New()
        {
            VkExternalFenceProperties ret = new VkExternalFenceProperties();
            ret.sType = VkStructureType.ExternalFenceProperties;
            return ret;
        }
    }

    public unsafe partial struct VkExternalFencePropertiesKHR
    {
    }

    public unsafe partial struct VkExportFenceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalFenceHandleTypeFlags handleTypes;
        public static VkExportFenceCreateInfo New()
        {
            VkExportFenceCreateInfo ret = new VkExportFenceCreateInfo();
            ret.sType = VkStructureType.ExportFenceCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkExportFenceCreateInfoKHR
    {
    }

    public unsafe partial struct VkImportFenceWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkFenceImportFlags flags;
        public VkExternalFenceHandleTypeFlags handleType;
        public Win32.HANDLE handle;
        public IntPtr name;
        public static VkImportFenceWin32HandleInfoKHR New()
        {
            VkImportFenceWin32HandleInfoKHR ret = new VkImportFenceWin32HandleInfoKHR();
            ret.sType = VkStructureType.ImportFenceWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkExportFenceWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public Win32.SECURITY_ATTRIBUTES* pAttributes;
        public uint dwAccess;
        public IntPtr name;
        public static VkExportFenceWin32HandleInfoKHR New()
        {
            VkExportFenceWin32HandleInfoKHR ret = new VkExportFenceWin32HandleInfoKHR();
            ret.sType = VkStructureType.ExportFenceWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkFenceGetWin32HandleInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlags handleType;
        public static VkFenceGetWin32HandleInfoKHR New()
        {
            VkFenceGetWin32HandleInfoKHR ret = new VkFenceGetWin32HandleInfoKHR();
            ret.sType = VkStructureType.FenceGetWin32HandleInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkImportFenceFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkFenceImportFlags flags;
        public VkExternalFenceHandleTypeFlags handleType;
        public int fd;
        public static VkImportFenceFdInfoKHR New()
        {
            VkImportFenceFdInfoKHR ret = new VkImportFenceFdInfoKHR();
            ret.sType = VkStructureType.ImportFenceFdInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkFenceGetFdInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlags handleType;
        public static VkFenceGetFdInfoKHR New()
        {
            VkFenceGetFdInfoKHR ret = new VkFenceGetFdInfoKHR();
            ret.sType = VkStructureType.FenceGetFdInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkExportFenceSciSyncInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public Nvidia.NvSciSyncAttrList pAttributes;
        public static VkExportFenceSciSyncInfoNV New()
        {
            VkExportFenceSciSyncInfoNV ret = new VkExportFenceSciSyncInfoNV();
            ret.sType = VkStructureType.ExportFenceSciSyncInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkImportFenceSciSyncInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlags handleType;
        public void* handle;
        public static VkImportFenceSciSyncInfoNV New()
        {
            VkImportFenceSciSyncInfoNV ret = new VkImportFenceSciSyncInfoNV();
            ret.sType = VkStructureType.ImportFenceSciSyncInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkFenceGetSciSyncInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFence fence;
        public VkExternalFenceHandleTypeFlags handleType;
        public static VkFenceGetSciSyncInfoNV New()
        {
            VkFenceGetSciSyncInfoNV ret = new VkFenceGetSciSyncInfoNV();
            ret.sType = VkStructureType.FenceGetSciSyncInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkExportSemaphoreSciSyncInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public Nvidia.NvSciSyncAttrList pAttributes;
        public static VkExportSemaphoreSciSyncInfoNV New()
        {
            VkExportSemaphoreSciSyncInfoNV ret = new VkExportSemaphoreSciSyncInfoNV();
            ret.sType = VkStructureType.ExportSemaphoreSciSyncInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkImportSemaphoreSciSyncInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public void* handle;
        public static VkImportSemaphoreSciSyncInfoNV New()
        {
            VkImportSemaphoreSciSyncInfoNV ret = new VkImportSemaphoreSciSyncInfoNV();
            ret.sType = VkStructureType.ImportSemaphoreSciSyncInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreGetSciSyncInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkExternalSemaphoreHandleTypeFlags handleType;
        public static VkSemaphoreGetSciSyncInfoNV New()
        {
            VkSemaphoreGetSciSyncInfoNV ret = new VkSemaphoreGetSciSyncInfoNV();
            ret.sType = VkStructureType.SemaphoreGetSciSyncInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkSciSyncAttributesInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSciSyncClientTypeNV clientType;
        public VkSciSyncPrimitiveTypeNV primitiveType;
        public static VkSciSyncAttributesInfoNV New()
        {
            VkSciSyncAttributesInfoNV ret = new VkSciSyncAttributesInfoNV();
            ret.sType = VkStructureType.SciSyncAttributesInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalSciSyncFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 sciSyncFence;
        public VkBool32 sciSyncSemaphore;
        public VkBool32 sciSyncImport;
        public VkBool32 sciSyncExport;
        public static VkPhysicalDeviceExternalSciSyncFeaturesNV New()
        {
            VkPhysicalDeviceExternalSciSyncFeaturesNV ret = new VkPhysicalDeviceExternalSciSyncFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceExternalSciSyncFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalSciSync2FeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 sciSyncFence;
        public VkBool32 sciSyncSemaphore2;
        public VkBool32 sciSyncImport;
        public VkBool32 sciSyncExport;
        public static VkPhysicalDeviceExternalSciSync2FeaturesNV New()
        {
            VkPhysicalDeviceExternalSciSync2FeaturesNV ret = new VkPhysicalDeviceExternalSciSync2FeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceExternalSciSync2FeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreSciSyncPoolCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public Nvidia.NvSciSyncObj handle;
        public static VkSemaphoreSciSyncPoolCreateInfoNV New()
        {
            VkSemaphoreSciSyncPoolCreateInfoNV ret = new VkSemaphoreSciSyncPoolCreateInfoNV();
            ret.sType = VkStructureType.SemaphoreSciSyncPoolCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreSciSyncCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphoreSciSyncPoolNV semaphorePool;
        public Nvidia.NvSciSyncFence* pFence;
        public static VkSemaphoreSciSyncCreateInfoNV New()
        {
            VkSemaphoreSciSyncCreateInfoNV ret = new VkSemaphoreSciSyncCreateInfoNV();
            ret.sType = VkStructureType.SemaphoreSciSyncCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceSemaphoreSciSyncPoolReservationCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint semaphoreSciSyncPoolRequestCount;
        public static VkDeviceSemaphoreSciSyncPoolReservationCreateInfoNV New()
        {
            VkDeviceSemaphoreSciSyncPoolReservationCreateInfoNV ret = new VkDeviceSemaphoreSciSyncPoolReservationCreateInfoNV();
            ret.sType = VkStructureType.DeviceSemaphoreSciSyncPoolReservationCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultiviewFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 multiview;
        public VkBool32 multiviewGeometryShader;
        public VkBool32 multiviewTessellationShader;
        public static VkPhysicalDeviceMultiviewFeatures New()
        {
            VkPhysicalDeviceMultiviewFeatures ret = new VkPhysicalDeviceMultiviewFeatures();
            ret.sType = VkStructureType.PhysicalDeviceMultiviewFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultiviewFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceMultiviewProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxMultiviewViewCount;
        public uint maxMultiviewInstanceIndex;
        public static VkPhysicalDeviceMultiviewProperties New()
        {
            VkPhysicalDeviceMultiviewProperties ret = new VkPhysicalDeviceMultiviewProperties();
            ret.sType = VkStructureType.PhysicalDeviceMultiviewProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultiviewPropertiesKHR
    {
    }

    public unsafe partial struct VkRenderPassMultiviewCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint subpassCount;
        public uint* pViewMasks;
        public uint dependencyCount;
        public int* pViewOffsets;
        public uint correlationMaskCount;
        public uint* pCorrelationMasks;
        public static VkRenderPassMultiviewCreateInfo New()
        {
            VkRenderPassMultiviewCreateInfo ret = new VkRenderPassMultiviewCreateInfo();
            ret.sType = VkStructureType.RenderPassMultiviewCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassMultiviewCreateInfoKHR
    {
    }

    public unsafe partial struct VkSurfaceCapabilities2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minImageCount;
        public uint maxImageCount;
        public VkExtent2D currentExtent;
        public VkExtent2D minImageExtent;
        public VkExtent2D maxImageExtent;
        public uint maxImageArrayLayers;
        public VkSurfaceTransformFlagsKHR supportedTransforms;
        public VkSurfaceTransformFlagsKHR currentTransform;
        public VkCompositeAlphaFlagsKHR supportedCompositeAlpha;
        public VkImageUsageFlags supportedUsageFlags;
        public VkSurfaceCounterFlagsEXT supportedSurfaceCounters;
        public static VkSurfaceCapabilities2EXT New()
        {
            VkSurfaceCapabilities2EXT ret = new VkSurfaceCapabilities2EXT();
            ret.sType = VkStructureType.SurfaceCapabilities2EXT;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPowerInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPowerStateEXT powerState;
        public static VkDisplayPowerInfoEXT New()
        {
            VkDisplayPowerInfoEXT ret = new VkDisplayPowerInfoEXT();
            ret.sType = VkStructureType.DisplayPowerInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceEventInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceEventTypeEXT deviceEvent;
        public static VkDeviceEventInfoEXT New()
        {
            VkDeviceEventInfoEXT ret = new VkDeviceEventInfoEXT();
            ret.sType = VkStructureType.DeviceEventInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayEventInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayEventTypeEXT displayEvent;
        public static VkDisplayEventInfoEXT New()
        {
            VkDisplayEventInfoEXT ret = new VkDisplayEventInfoEXT();
            ret.sType = VkStructureType.DisplayEventInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSwapchainCounterCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceCounterFlagsEXT surfaceCounters;
        public static VkSwapchainCounterCreateInfoEXT New()
        {
            VkSwapchainCounterCreateInfoEXT ret = new VkSwapchainCounterCreateInfoEXT();
            ret.sType = VkStructureType.SwapchainCounterCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceGroupProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint physicalDeviceCount;
        public VkPhysicalDevice physicalDevices_0;
        public VkPhysicalDevice physicalDevices_1;
        public VkPhysicalDevice physicalDevices_2;
        public VkPhysicalDevice physicalDevices_3;
        public VkPhysicalDevice physicalDevices_4;
        public VkPhysicalDevice physicalDevices_5;
        public VkPhysicalDevice physicalDevices_6;
        public VkPhysicalDevice physicalDevices_7;
        public VkPhysicalDevice physicalDevices_8;
        public VkPhysicalDevice physicalDevices_9;
        public VkPhysicalDevice physicalDevices_10;
        public VkPhysicalDevice physicalDevices_11;
        public VkPhysicalDevice physicalDevices_12;
        public VkPhysicalDevice physicalDevices_13;
        public VkPhysicalDevice physicalDevices_14;
        public VkPhysicalDevice physicalDevices_15;
        public VkPhysicalDevice physicalDevices_16;
        public VkPhysicalDevice physicalDevices_17;
        public VkPhysicalDevice physicalDevices_18;
        public VkPhysicalDevice physicalDevices_19;
        public VkPhysicalDevice physicalDevices_20;
        public VkPhysicalDevice physicalDevices_21;
        public VkPhysicalDevice physicalDevices_22;
        public VkPhysicalDevice physicalDevices_23;
        public VkPhysicalDevice physicalDevices_24;
        public VkPhysicalDevice physicalDevices_25;
        public VkPhysicalDevice physicalDevices_26;
        public VkPhysicalDevice physicalDevices_27;
        public VkPhysicalDevice physicalDevices_28;
        public VkPhysicalDevice physicalDevices_29;
        public VkPhysicalDevice physicalDevices_30;
        public VkPhysicalDevice physicalDevices_31;
        public VkBool32 subsetAllocation;
        public static VkPhysicalDeviceGroupProperties New()
        {
            VkPhysicalDeviceGroupProperties ret = new VkPhysicalDeviceGroupProperties();
            ret.sType = VkStructureType.PhysicalDeviceGroupProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceGroupPropertiesKHR
    {
    }

    public unsafe partial struct VkMemoryAllocateFlagsInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryAllocateFlags flags;
        public uint deviceMask;
        public static VkMemoryAllocateFlagsInfo New()
        {
            VkMemoryAllocateFlagsInfo ret = new VkMemoryAllocateFlagsInfo();
            ret.sType = VkStructureType.MemoryAllocateFlags;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryAllocateFlagsInfoKHR
    {
    }

    public unsafe partial struct VkBindBufferMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public static VkBindBufferMemoryInfo New()
        {
            VkBindBufferMemoryInfo ret = new VkBindBufferMemoryInfo();
            ret.sType = VkStructureType.BindBufferMemoryInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBindBufferMemoryInfoKHR
    {
    }

    public unsafe partial struct VkBindBufferMemoryDeviceGroupInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        public static VkBindBufferMemoryDeviceGroupInfo New()
        {
            VkBindBufferMemoryDeviceGroupInfo ret = new VkBindBufferMemoryDeviceGroupInfo();
            ret.sType = VkStructureType.BindBufferMemoryDeviceGroupInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBindBufferMemoryDeviceGroupInfoKHR
    {
    }

    public unsafe partial struct VkBindImageMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public static VkBindImageMemoryInfo New()
        {
            VkBindImageMemoryInfo ret = new VkBindImageMemoryInfo();
            ret.sType = VkStructureType.BindImageMemoryInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBindImageMemoryInfoKHR
    {
    }

    public unsafe partial struct VkBindImageMemoryDeviceGroupInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        public uint splitInstanceBindRegionCount;
        public VkRect2D* pSplitInstanceBindRegions;
        public static VkBindImageMemoryDeviceGroupInfo New()
        {
            VkBindImageMemoryDeviceGroupInfo ret = new VkBindImageMemoryDeviceGroupInfo();
            ret.sType = VkStructureType.BindImageMemoryDeviceGroupInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBindImageMemoryDeviceGroupInfoKHR
    {
    }

    public unsafe partial struct VkDeviceGroupRenderPassBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceMask;
        public uint deviceRenderAreaCount;
        public VkRect2D* pDeviceRenderAreas;
        public static VkDeviceGroupRenderPassBeginInfo New()
        {
            VkDeviceGroupRenderPassBeginInfo ret = new VkDeviceGroupRenderPassBeginInfo();
            ret.sType = VkStructureType.DeviceGroupRenderPassBeginInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupRenderPassBeginInfoKHR
    {
    }

    public unsafe partial struct VkDeviceGroupCommandBufferBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceMask;
        public static VkDeviceGroupCommandBufferBeginInfo New()
        {
            VkDeviceGroupCommandBufferBeginInfo ret = new VkDeviceGroupCommandBufferBeginInfo();
            ret.sType = VkStructureType.DeviceGroupCommandBufferBeginInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupCommandBufferBeginInfoKHR
    {
    }

    public unsafe partial struct VkDeviceGroupSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreCount;
        public uint* pWaitSemaphoreDeviceIndices;
        public uint commandBufferCount;
        public uint* pCommandBufferDeviceMasks;
        public uint signalSemaphoreCount;
        public uint* pSignalSemaphoreDeviceIndices;
        public static VkDeviceGroupSubmitInfo New()
        {
            VkDeviceGroupSubmitInfo ret = new VkDeviceGroupSubmitInfo();
            ret.sType = VkStructureType.DeviceGroupSubmitInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupSubmitInfoKHR
    {
    }

    public unsafe partial struct VkDeviceGroupBindSparseInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint resourceDeviceIndex;
        public uint memoryDeviceIndex;
        public static VkDeviceGroupBindSparseInfo New()
        {
            VkDeviceGroupBindSparseInfo ret = new VkDeviceGroupBindSparseInfo();
            ret.sType = VkStructureType.DeviceGroupBindSparseInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupBindSparseInfoKHR
    {
    }

    public unsafe partial struct VkDeviceGroupPresentCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed uint presentMask[(int)VulkanNative.MaxDeviceGroupSize];
        public VkDeviceGroupPresentModeFlagsKHR modes;
        public static VkDeviceGroupPresentCapabilitiesKHR New()
        {
            VkDeviceGroupPresentCapabilitiesKHR ret = new VkDeviceGroupPresentCapabilitiesKHR();
            ret.sType = VkStructureType.DeviceGroupPresentCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkImageSwapchainCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public static VkImageSwapchainCreateInfoKHR New()
        {
            VkImageSwapchainCreateInfoKHR ret = new VkImageSwapchainCreateInfoKHR();
            ret.sType = VkStructureType.ImageSwapchainCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkBindImageMemorySwapchainInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public uint imageIndex;
        public static VkBindImageMemorySwapchainInfoKHR New()
        {
            VkBindImageMemorySwapchainInfoKHR ret = new VkBindImageMemorySwapchainInfoKHR();
            ret.sType = VkStructureType.BindImageMemorySwapchainInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAcquireNextImageInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public ulong timeout;
        public VkSemaphore semaphore;
        public VkFence fence;
        public uint deviceMask;
        public static VkAcquireNextImageInfoKHR New()
        {
            VkAcquireNextImageInfoKHR ret = new VkAcquireNextImageInfoKHR();
            ret.sType = VkStructureType.AcquireNextImageInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupPresentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public uint* pDeviceMasks;
        public VkDeviceGroupPresentModeFlagsKHR mode;
        public static VkDeviceGroupPresentInfoKHR New()
        {
            VkDeviceGroupPresentInfoKHR ret = new VkDeviceGroupPresentInfoKHR();
            ret.sType = VkStructureType.DeviceGroupPresentInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupDeviceCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint physicalDeviceCount;
        public VkPhysicalDevice* pPhysicalDevices;
        public static VkDeviceGroupDeviceCreateInfo New()
        {
            VkDeviceGroupDeviceCreateInfo ret = new VkDeviceGroupDeviceCreateInfo();
            ret.sType = VkStructureType.DeviceGroupDeviceCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceGroupDeviceCreateInfoKHR
    {
    }

    public unsafe partial struct VkDeviceGroupSwapchainCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceGroupPresentModeFlagsKHR modes;
        public static VkDeviceGroupSwapchainCreateInfoKHR New()
        {
            VkDeviceGroupSwapchainCreateInfoKHR ret = new VkDeviceGroupSwapchainCreateInfoKHR();
            ret.sType = VkStructureType.DeviceGroupSwapchainCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorUpdateTemplateEntry
    {
        public uint dstBinding;
        public uint dstArrayElement;
        public uint descriptorCount;
        public VkDescriptorType descriptorType;
        public UIntPtr offset;
        public UIntPtr stride;
    }

    public unsafe partial struct VkDescriptorUpdateTemplateEntryKHR
    {
    }

    public unsafe partial struct VkDescriptorUpdateTemplateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint descriptorUpdateEntryCount;
        public VkDescriptorUpdateTemplateEntry* pDescriptorUpdateEntries;
        public VkDescriptorUpdateTemplateType templateType;
        public VkDescriptorSetLayout descriptorSetLayout;
        public VkPipelineBindPoint pipelineBindPoint;
        public VkPipelineLayout pipelineLayout;
        public uint set;
        public static VkDescriptorUpdateTemplateCreateInfo New()
        {
            VkDescriptorUpdateTemplateCreateInfo ret = new VkDescriptorUpdateTemplateCreateInfo();
            ret.sType = VkStructureType.DescriptorUpdateTemplateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorUpdateTemplateCreateInfoKHR
    {
    }

    public unsafe partial struct VkXYColorEXT
    {
        public float x;
        public float y;
    }

    public unsafe partial struct VkPhysicalDevicePresentIdFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 presentId;
        public static VkPhysicalDevicePresentIdFeaturesKHR New()
        {
            VkPhysicalDevicePresentIdFeaturesKHR ret = new VkPhysicalDevicePresentIdFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDevicePresentIdFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPresentIdKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public ulong* pPresentIds;
        public static VkPresentIdKHR New()
        {
            VkPresentIdKHR ret = new VkPresentIdKHR();
            ret.sType = VkStructureType.PresentIdKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePresentId2FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 presentId2;
        public static VkPhysicalDevicePresentId2FeaturesKHR New()
        {
            VkPhysicalDevicePresentId2FeaturesKHR ret = new VkPhysicalDevicePresentId2FeaturesKHR();
            ret.sType = VkStructureType.PhysicalDevicePresentId2FeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPresentId2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public ulong* pPresentIds;
        public static VkPresentId2KHR New()
        {
            VkPresentId2KHR ret = new VkPresentId2KHR();
            ret.sType = VkStructureType.PresentId2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkPresentWait2InfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong presentId;
        public ulong timeout;
        public static VkPresentWait2InfoKHR New()
        {
            VkPresentWait2InfoKHR ret = new VkPresentWait2InfoKHR();
            ret.sType = VkStructureType.PresentWait2InfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePresentWaitFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 presentWait;
        public static VkPhysicalDevicePresentWaitFeaturesKHR New()
        {
            VkPhysicalDevicePresentWaitFeaturesKHR ret = new VkPhysicalDevicePresentWaitFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDevicePresentWaitFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePresentWait2FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 presentWait2;
        public static VkPhysicalDevicePresentWait2FeaturesKHR New()
        {
            VkPhysicalDevicePresentWait2FeaturesKHR ret = new VkPhysicalDevicePresentWait2FeaturesKHR();
            ret.sType = VkStructureType.PhysicalDevicePresentWait2FeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkHdrMetadataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkXYColorEXT displayPrimaryRed;
        public VkXYColorEXT displayPrimaryGreen;
        public VkXYColorEXT displayPrimaryBlue;
        public VkXYColorEXT whitePoint;
        public float maxLuminance;
        public float minLuminance;
        public float maxContentLightLevel;
        public float maxFrameAverageLightLevel;
        public static VkHdrMetadataEXT New()
        {
            VkHdrMetadataEXT ret = new VkHdrMetadataEXT();
            ret.sType = VkStructureType.HdrMetadataEXT;
            return ret;
        }
    }

    public unsafe partial struct VkHdrVividDynamicMetadataHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public UIntPtr dynamicMetadataSize;
        public void* pDynamicMetadata;
        public static VkHdrVividDynamicMetadataHUAWEI New()
        {
            VkHdrVividDynamicMetadataHUAWEI ret = new VkHdrVividDynamicMetadataHUAWEI();
            ret.sType = VkStructureType.HdrVividDynamicMetadataHuawei;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayNativeHdrSurfaceCapabilitiesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 localDimmingSupport;
        public static VkDisplayNativeHdrSurfaceCapabilitiesAMD New()
        {
            VkDisplayNativeHdrSurfaceCapabilitiesAMD ret = new VkDisplayNativeHdrSurfaceCapabilitiesAMD();
            ret.sType = VkStructureType.DisplayNativeHdrSurfaceCapabilitiesAMD;
            return ret;
        }
    }

    public unsafe partial struct VkSwapchainDisplayNativeHdrCreateInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 localDimmingEnable;
        public static VkSwapchainDisplayNativeHdrCreateInfoAMD New()
        {
            VkSwapchainDisplayNativeHdrCreateInfoAMD ret = new VkSwapchainDisplayNativeHdrCreateInfoAMD();
            ret.sType = VkStructureType.SwapchainDisplayNativeHdrCreateInfoAMD;
            return ret;
        }
    }

    public unsafe partial struct VkRefreshCycleDurationGOOGLE
    {
        public ulong refreshDuration;
    }

    public unsafe partial struct VkPastPresentationTimingGOOGLE
    {
        public uint presentID;
        public ulong desiredPresentTime;
        public ulong actualPresentTime;
        public ulong earliestPresentTime;
        public ulong presentMargin;
    }

    public unsafe partial struct VkPresentTimesInfoGOOGLE
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentTimeGOOGLE* pTimes;
        public static VkPresentTimesInfoGOOGLE New()
        {
            VkPresentTimesInfoGOOGLE ret = new VkPresentTimesInfoGOOGLE();
            ret.sType = VkStructureType.PresentTimesInfoGoogle;
            return ret;
        }
    }

    public unsafe partial struct VkPresentTimeGOOGLE
    {
        public uint presentID;
        public ulong desiredPresentTime;
    }

    public unsafe partial struct VkIOSSurfaceCreateInfoMVK
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public void* pView;
        public static VkIOSSurfaceCreateInfoMVK New()
        {
            VkIOSSurfaceCreateInfoMVK ret = new VkIOSSurfaceCreateInfoMVK();
            ret.sType = VkStructureType.IosSurfaceCreateInfoMvk;
            return ret;
        }
    }

    public unsafe partial struct VkMacOSSurfaceCreateInfoMVK
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public void* pView;
        public static VkMacOSSurfaceCreateInfoMVK New()
        {
            VkMacOSSurfaceCreateInfoMVK ret = new VkMacOSSurfaceCreateInfoMVK();
            ret.sType = VkStructureType.MacosSurfaceCreateInfoMvk;
            return ret;
        }
    }

    public unsafe partial struct VkMetalSurfaceCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public Metal.CAMetalLayer* pLayer;
        public static VkMetalSurfaceCreateInfoEXT New()
        {
            VkMetalSurfaceCreateInfoEXT ret = new VkMetalSurfaceCreateInfoEXT();
            ret.sType = VkStructureType.MetalSurfaceCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkViewportWScalingNV
    {
        public float xcoeff;
        public float ycoeff;
    }

    public unsafe partial struct VkPipelineViewportWScalingStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 viewportWScalingEnable;
        public uint viewportCount;
        public VkViewportWScalingNV* pViewportWScalings;
        public static VkPipelineViewportWScalingStateCreateInfoNV New()
        {
            VkPipelineViewportWScalingStateCreateInfoNV ret = new VkPipelineViewportWScalingStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineViewportWScalingStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkViewportSwizzleNV
    {
        public VkViewportCoordinateSwizzleNV x;
        public VkViewportCoordinateSwizzleNV y;
        public VkViewportCoordinateSwizzleNV z;
        public VkViewportCoordinateSwizzleNV w;
    }

    public unsafe partial struct VkPipelineViewportSwizzleStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint viewportCount;
        public VkViewportSwizzleNV* pViewportSwizzles;
        public static VkPipelineViewportSwizzleStateCreateInfoNV New()
        {
            VkPipelineViewportSwizzleStateCreateInfoNV ret = new VkPipelineViewportSwizzleStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineViewportSwizzleStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDiscardRectanglePropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxDiscardRectangles;
        public static VkPhysicalDeviceDiscardRectanglePropertiesEXT New()
        {
            VkPhysicalDeviceDiscardRectanglePropertiesEXT ret = new VkPhysicalDeviceDiscardRectanglePropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDiscardRectanglePropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineDiscardRectangleStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkDiscardRectangleModeEXT discardRectangleMode;
        public uint discardRectangleCount;
        public VkRect2D* pDiscardRectangles;
        public static VkPipelineDiscardRectangleStateCreateInfoEXT New()
        {
            VkPipelineDiscardRectangleStateCreateInfoEXT ret = new VkPipelineDiscardRectangleStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineDiscardRectangleStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 perViewPositionAllComponents;
        public static VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX New()
        {
            VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX ret = new VkPhysicalDeviceMultiviewPerViewAttributesPropertiesNVX();
            ret.sType = VkStructureType.PhysicalDeviceMultiviewPerViewAttributesPropertiesNVX;
            return ret;
        }
    }

    public unsafe partial struct VkInputAttachmentAspectReference
    {
        public uint subpass;
        public uint inputAttachmentIndex;
        public VkImageAspectFlags aspectMask;
    }

    public unsafe partial struct VkInputAttachmentAspectReferenceKHR
    {
    }

    public unsafe partial struct VkRenderPassInputAttachmentAspectCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint aspectReferenceCount;
        public VkInputAttachmentAspectReference* pAspectReferences;
        public static VkRenderPassInputAttachmentAspectCreateInfo New()
        {
            VkRenderPassInputAttachmentAspectCreateInfo ret = new VkRenderPassInputAttachmentAspectCreateInfo();
            ret.sType = VkStructureType.RenderPassInputAttachmentAspectCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassInputAttachmentAspectCreateInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceSurfaceInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceKHR surface;
        public static VkPhysicalDeviceSurfaceInfo2KHR New()
        {
            VkPhysicalDeviceSurfaceInfo2KHR ret = new VkPhysicalDeviceSurfaceInfo2KHR();
            ret.sType = VkStructureType.PhysicalDeviceSurfaceInfo2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceCapabilities2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceCapabilitiesKHR surfaceCapabilities;
        public static VkSurfaceCapabilities2KHR New()
        {
            VkSurfaceCapabilities2KHR ret = new VkSurfaceCapabilities2KHR();
            ret.sType = VkStructureType.SurfaceCapabilities2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceFormat2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceFormatKHR surfaceFormat;
        public static VkSurfaceFormat2KHR New()
        {
            VkSurfaceFormat2KHR ret = new VkSurfaceFormat2KHR();
            ret.sType = VkStructureType.SurfaceFormat2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayProperties2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPropertiesKHR displayProperties;
        public static VkDisplayProperties2KHR New()
        {
            VkDisplayProperties2KHR ret = new VkDisplayProperties2KHR();
            ret.sType = VkStructureType.DisplayProperties2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPlaneProperties2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPlanePropertiesKHR displayPlaneProperties;
        public static VkDisplayPlaneProperties2KHR New()
        {
            VkDisplayPlaneProperties2KHR ret = new VkDisplayPlaneProperties2KHR();
            ret.sType = VkStructureType.DisplayPlaneProperties2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayModeProperties2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayModePropertiesKHR displayModeProperties;
        public static VkDisplayModeProperties2KHR New()
        {
            VkDisplayModeProperties2KHR ret = new VkDisplayModeProperties2KHR();
            ret.sType = VkStructureType.DisplayModeProperties2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayModeStereoPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hdmi3DSupported;
        public static VkDisplayModeStereoPropertiesNV New()
        {
            VkDisplayModeStereoPropertiesNV ret = new VkDisplayModeStereoPropertiesNV();
            ret.sType = VkStructureType.DisplayModeStereoPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPlaneInfo2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayModeKHR mode;
        public uint planeIndex;
        public static VkDisplayPlaneInfo2KHR New()
        {
            VkDisplayPlaneInfo2KHR ret = new VkDisplayPlaneInfo2KHR();
            ret.sType = VkStructureType.DisplayPlaneInfo2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkDisplayPlaneCapabilities2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDisplayPlaneCapabilitiesKHR capabilities;
        public static VkDisplayPlaneCapabilities2KHR New()
        {
            VkDisplayPlaneCapabilities2KHR ret = new VkDisplayPlaneCapabilities2KHR();
            ret.sType = VkStructureType.DisplayPlaneCapabilities2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkSharedPresentSurfaceCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlags sharedPresentSupportedUsageFlags;
        public static VkSharedPresentSurfaceCapabilitiesKHR New()
        {
            VkSharedPresentSurfaceCapabilitiesKHR ret = new VkSharedPresentSurfaceCapabilitiesKHR();
            ret.sType = VkStructureType.SharedPresentSurfaceCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevice16BitStorageFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 storageBuffer16BitAccess;
        public VkBool32 uniformAndStorageBuffer16BitAccess;
        public VkBool32 storagePushConstant16;
        public VkBool32 storageInputOutput16;
        public static VkPhysicalDevice16BitStorageFeatures New()
        {
            VkPhysicalDevice16BitStorageFeatures ret = new VkPhysicalDevice16BitStorageFeatures();
            ret.sType = VkStructureType.PhysicalDevice16bitStorageFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevice16BitStorageFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceSubgroupProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint subgroupSize;
        public VkShaderStageFlags supportedStages;
        public VkSubgroupFeatureFlags supportedOperations;
        public VkBool32 quadOperationsInAllStages;
        public static VkPhysicalDeviceSubgroupProperties New()
        {
            VkPhysicalDeviceSubgroupProperties ret = new VkPhysicalDeviceSubgroupProperties();
            ret.sType = VkStructureType.PhysicalDeviceSubgroupProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderSubgroupExtendedTypes;
        public static VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures New()
        {
            VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures ret = new VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures();
            ret.sType = VkStructureType.PhysicalDeviceShaderSubgroupExtendedTypesFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderSubgroupExtendedTypesFeaturesKHR
    {
    }

    public unsafe partial struct VkBufferMemoryRequirementsInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public static VkBufferMemoryRequirementsInfo2 New()
        {
            VkBufferMemoryRequirementsInfo2 ret = new VkBufferMemoryRequirementsInfo2();
            ret.sType = VkStructureType.BufferMemoryRequirementsInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkBufferMemoryRequirementsInfo2KHR
    {
    }

    public unsafe partial struct VkDeviceBufferMemoryRequirements
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCreateInfo* pCreateInfo;
        public static VkDeviceBufferMemoryRequirements New()
        {
            VkDeviceBufferMemoryRequirements ret = new VkDeviceBufferMemoryRequirements();
            ret.sType = VkStructureType.DeviceBufferMemoryRequirements;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceBufferMemoryRequirementsKHR
    {
    }

    public unsafe partial struct VkImageMemoryRequirementsInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public static VkImageMemoryRequirementsInfo2 New()
        {
            VkImageMemoryRequirementsInfo2 ret = new VkImageMemoryRequirementsInfo2();
            ret.sType = VkStructureType.ImageMemoryRequirementsInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkImageMemoryRequirementsInfo2KHR
    {
    }

    public unsafe partial struct VkImageSparseMemoryRequirementsInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public static VkImageSparseMemoryRequirementsInfo2 New()
        {
            VkImageSparseMemoryRequirementsInfo2 ret = new VkImageSparseMemoryRequirementsInfo2();
            ret.sType = VkStructureType.ImageSparseMemoryRequirementsInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkImageSparseMemoryRequirementsInfo2KHR
    {
    }

    public unsafe partial struct VkDeviceImageMemoryRequirements
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateInfo* pCreateInfo;
        public VkImageAspectFlags planeAspect;
        public static VkDeviceImageMemoryRequirements New()
        {
            VkDeviceImageMemoryRequirements ret = new VkDeviceImageMemoryRequirements();
            ret.sType = VkStructureType.DeviceImageMemoryRequirements;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceImageMemoryRequirementsKHR
    {
    }

    public unsafe partial struct VkMemoryRequirements2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryRequirements memoryRequirements;
        public static VkMemoryRequirements2 New()
        {
            VkMemoryRequirements2 ret = new VkMemoryRequirements2();
            ret.sType = VkStructureType.MemoryRequirements2;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryRequirements2KHR
    {
    }

    public unsafe partial struct VkSparseImageMemoryRequirements2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSparseImageMemoryRequirements memoryRequirements;
        public static VkSparseImageMemoryRequirements2 New()
        {
            VkSparseImageMemoryRequirements2 ret = new VkSparseImageMemoryRequirements2();
            ret.sType = VkStructureType.SparseImageMemoryRequirements2;
            return ret;
        }
    }

    public unsafe partial struct VkSparseImageMemoryRequirements2KHR
    {
    }

    public unsafe partial struct VkPhysicalDevicePointClippingProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPointClippingBehavior pointClippingBehavior;
        public static VkPhysicalDevicePointClippingProperties New()
        {
            VkPhysicalDevicePointClippingProperties ret = new VkPhysicalDevicePointClippingProperties();
            ret.sType = VkStructureType.PhysicalDevicePointClippingProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePointClippingPropertiesKHR
    {
    }

    public unsafe partial struct VkMemoryDedicatedRequirements
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 prefersDedicatedAllocation;
        public VkBool32 requiresDedicatedAllocation;
        public static VkMemoryDedicatedRequirements New()
        {
            VkMemoryDedicatedRequirements ret = new VkMemoryDedicatedRequirements();
            ret.sType = VkStructureType.MemoryDedicatedRequirements;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryDedicatedRequirementsKHR
    {
    }

    public unsafe partial struct VkMemoryDedicatedAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkBuffer buffer;
        public static VkMemoryDedicatedAllocateInfo New()
        {
            VkMemoryDedicatedAllocateInfo ret = new VkMemoryDedicatedAllocateInfo();
            ret.sType = VkStructureType.MemoryDedicatedAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryDedicatedAllocateInfoKHR
    {
    }

    public unsafe partial struct VkImageViewUsageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlags usage;
        public static VkImageViewUsageCreateInfo New()
        {
            VkImageViewUsageCreateInfo ret = new VkImageViewUsageCreateInfo();
            ret.sType = VkStructureType.ImageViewUsageCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkImageViewSlicedCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint sliceOffset;
        public uint sliceCount;
        public static VkImageViewSlicedCreateInfoEXT New()
        {
            VkImageViewSlicedCreateInfoEXT ret = new VkImageViewSlicedCreateInfoEXT();
            ret.sType = VkStructureType.ImageViewSlicedCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageViewUsageCreateInfoKHR
    {
    }

    public unsafe partial struct VkPipelineTessellationDomainOriginStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTessellationDomainOrigin domainOrigin;
        public static VkPipelineTessellationDomainOriginStateCreateInfo New()
        {
            VkPipelineTessellationDomainOriginStateCreateInfo ret = new VkPipelineTessellationDomainOriginStateCreateInfo();
            ret.sType = VkStructureType.PipelineTessellationDomainOriginStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineTessellationDomainOriginStateCreateInfoKHR
    {
    }

    public unsafe partial struct VkSamplerYcbcrConversionInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSamplerYcbcrConversion conversion;
        public static VkSamplerYcbcrConversionInfo New()
        {
            VkSamplerYcbcrConversionInfo ret = new VkSamplerYcbcrConversionInfo();
            ret.sType = VkStructureType.SamplerYcbcrConversionInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerYcbcrConversionInfoKHR
    {
    }

    public unsafe partial struct VkSamplerYcbcrConversionCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkSamplerYcbcrModelConversion ycbcrModel;
        public VkSamplerYcbcrRange ycbcrRange;
        public VkComponentMapping components;
        public VkChromaLocation xChromaOffset;
        public VkChromaLocation yChromaOffset;
        public VkFilter chromaFilter;
        public VkBool32 forceExplicitReconstruction;
        public static VkSamplerYcbcrConversionCreateInfo New()
        {
            VkSamplerYcbcrConversionCreateInfo ret = new VkSamplerYcbcrConversionCreateInfo();
            ret.sType = VkStructureType.SamplerYcbcrConversionCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerYcbcrConversionCreateInfoKHR
    {
    }

    public unsafe partial struct VkBindImagePlaneMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageAspectFlags planeAspect;
        public static VkBindImagePlaneMemoryInfo New()
        {
            VkBindImagePlaneMemoryInfo ret = new VkBindImagePlaneMemoryInfo();
            ret.sType = VkStructureType.BindImagePlaneMemoryInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBindImagePlaneMemoryInfoKHR
    {
    }

    public unsafe partial struct VkImagePlaneMemoryRequirementsInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageAspectFlags planeAspect;
        public static VkImagePlaneMemoryRequirementsInfo New()
        {
            VkImagePlaneMemoryRequirementsInfo ret = new VkImagePlaneMemoryRequirementsInfo();
            ret.sType = VkStructureType.ImagePlaneMemoryRequirementsInfo;
            return ret;
        }
    }

    public unsafe partial struct VkImagePlaneMemoryRequirementsInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceSamplerYcbcrConversionFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 samplerYcbcrConversion;
        public static VkPhysicalDeviceSamplerYcbcrConversionFeatures New()
        {
            VkPhysicalDeviceSamplerYcbcrConversionFeatures ret = new VkPhysicalDeviceSamplerYcbcrConversionFeatures();
            ret.sType = VkStructureType.PhysicalDeviceSamplerYcbcrConversionFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSamplerYcbcrConversionFeaturesKHR
    {
    }

    public unsafe partial struct VkSamplerYcbcrConversionImageFormatProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint combinedImageSamplerDescriptorCount;
        public static VkSamplerYcbcrConversionImageFormatProperties New()
        {
            VkSamplerYcbcrConversionImageFormatProperties ret = new VkSamplerYcbcrConversionImageFormatProperties();
            ret.sType = VkStructureType.SamplerYcbcrConversionImageFormatProperties;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerYcbcrConversionImageFormatPropertiesKHR
    {
    }

    public unsafe partial struct VkTextureLODGatherFormatPropertiesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 supportsTextureGatherLODBiasAMD;
        public static VkTextureLODGatherFormatPropertiesAMD New()
        {
            VkTextureLODGatherFormatPropertiesAMD ret = new VkTextureLODGatherFormatPropertiesAMD();
            ret.sType = VkStructureType.TextureLodGatherFormatPropertiesAMD;
            return ret;
        }
    }

    public unsafe partial struct VkConditionalRenderingBeginInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public ulong offset;
        public VkConditionalRenderingFlagsEXT flags;
        public static VkConditionalRenderingBeginInfoEXT New()
        {
            VkConditionalRenderingBeginInfoEXT ret = new VkConditionalRenderingBeginInfoEXT();
            ret.sType = VkStructureType.ConditionalRenderingBeginInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkProtectedSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 protectedSubmit;
        public static VkProtectedSubmitInfo New()
        {
            VkProtectedSubmitInfo ret = new VkProtectedSubmitInfo();
            ret.sType = VkStructureType.ProtectedSubmitInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceProtectedMemoryFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 protectedMemory;
        public static VkPhysicalDeviceProtectedMemoryFeatures New()
        {
            VkPhysicalDeviceProtectedMemoryFeatures ret = new VkPhysicalDeviceProtectedMemoryFeatures();
            ret.sType = VkStructureType.PhysicalDeviceProtectedMemoryFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceProtectedMemoryProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 protectedNoFault;
        public static VkPhysicalDeviceProtectedMemoryProperties New()
        {
            VkPhysicalDeviceProtectedMemoryProperties ret = new VkPhysicalDeviceProtectedMemoryProperties();
            ret.sType = VkStructureType.PhysicalDeviceProtectedMemoryProperties;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceQueueInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceQueueCreateFlags flags;
        public uint queueFamilyIndex;
        public uint queueIndex;
        public static VkDeviceQueueInfo2 New()
        {
            VkDeviceQueueInfo2 ret = new VkDeviceQueueInfo2();
            ret.sType = VkStructureType.DeviceQueueInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCoverageToColorStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkBool32 coverageToColorEnable;
        public uint coverageToColorLocation;
        public static VkPipelineCoverageToColorStateCreateInfoNV New()
        {
            VkPipelineCoverageToColorStateCreateInfoNV ret = new VkPipelineCoverageToColorStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineCoverageToColorStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSamplerFilterMinmaxProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 filterMinmaxSingleComponentFormats;
        public VkBool32 filterMinmaxImageComponentMapping;
        public static VkPhysicalDeviceSamplerFilterMinmaxProperties New()
        {
            VkPhysicalDeviceSamplerFilterMinmaxProperties ret = new VkPhysicalDeviceSamplerFilterMinmaxProperties();
            ret.sType = VkStructureType.PhysicalDeviceSamplerFilterMinmaxProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSamplerFilterMinmaxPropertiesEXT
    {
    }

    public unsafe partial struct VkSampleLocationEXT
    {
        public float x;
        public float y;
    }

    public unsafe partial struct VkSampleLocationsInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlags sampleLocationsPerPixel;
        public VkExtent2D sampleLocationGridSize;
        public uint sampleLocationsCount;
        public VkSampleLocationEXT* pSampleLocations;
        public static VkSampleLocationsInfoEXT New()
        {
            VkSampleLocationsInfoEXT ret = new VkSampleLocationsInfoEXT();
            ret.sType = VkStructureType.SampleLocationsInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkAttachmentSampleLocationsEXT
    {
        public uint attachmentIndex;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }

    public unsafe partial struct VkSubpassSampleLocationsEXT
    {
        public uint subpassIndex;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
    }

    public unsafe partial struct VkRenderPassSampleLocationsBeginInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentInitialSampleLocationsCount;
        public VkAttachmentSampleLocationsEXT* pAttachmentInitialSampleLocations;
        public uint postSubpassSampleLocationsCount;
        public VkSubpassSampleLocationsEXT* pPostSubpassSampleLocations;
        public static VkRenderPassSampleLocationsBeginInfoEXT New()
        {
            VkRenderPassSampleLocationsBeginInfoEXT ret = new VkRenderPassSampleLocationsBeginInfoEXT();
            ret.sType = VkStructureType.RenderPassSampleLocationsBeginInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineSampleLocationsStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 sampleLocationsEnable;
        public VkSampleLocationsInfoEXT sampleLocationsInfo;
        public static VkPipelineSampleLocationsStateCreateInfoEXT New()
        {
            VkPipelineSampleLocationsStateCreateInfoEXT ret = new VkPipelineSampleLocationsStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineSampleLocationsStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSampleLocationsPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlags sampleLocationSampleCounts;
        public VkExtent2D maxSampleLocationGridSize;
        public float sampleLocationCoordinateRange_0;
        public float sampleLocationCoordinateRange_1;
        public uint sampleLocationSubPixelBits;
        public VkBool32 variableSampleLocations;
        public static VkPhysicalDeviceSampleLocationsPropertiesEXT New()
        {
            VkPhysicalDeviceSampleLocationsPropertiesEXT ret = new VkPhysicalDeviceSampleLocationsPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceSampleLocationsPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMultisamplePropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D maxSampleLocationGridSize;
        public static VkMultisamplePropertiesEXT New()
        {
            VkMultisamplePropertiesEXT ret = new VkMultisamplePropertiesEXT();
            ret.sType = VkStructureType.MultisamplePropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerReductionModeCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSamplerReductionMode reductionMode;
        public static VkSamplerReductionModeCreateInfo New()
        {
            VkSamplerReductionModeCreateInfo ret = new VkSamplerReductionModeCreateInfo();
            ret.sType = VkStructureType.SamplerReductionModeCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerReductionModeCreateInfoEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 advancedBlendCoherentOperations;
        public static VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT New()
        {
            VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT ret = new VkPhysicalDeviceBlendOperationAdvancedFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceBlendOperationAdvancedFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultiDrawFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 multiDraw;
        public static VkPhysicalDeviceMultiDrawFeaturesEXT New()
        {
            VkPhysicalDeviceMultiDrawFeaturesEXT ret = new VkPhysicalDeviceMultiDrawFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceMultiDrawFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint advancedBlendMaxColorAttachments;
        public VkBool32 advancedBlendIndependentBlend;
        public VkBool32 advancedBlendNonPremultipliedSrcColor;
        public VkBool32 advancedBlendNonPremultipliedDstColor;
        public VkBool32 advancedBlendCorrelatedOverlap;
        public VkBool32 advancedBlendAllOperations;
        public static VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT New()
        {
            VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT ret = new VkPhysicalDeviceBlendOperationAdvancedPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceBlendOperationAdvancedPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineColorBlendAdvancedStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 srcPremultiplied;
        public VkBool32 dstPremultiplied;
        public VkBlendOverlapEXT blendOverlap;
        public static VkPipelineColorBlendAdvancedStateCreateInfoEXT New()
        {
            VkPipelineColorBlendAdvancedStateCreateInfoEXT ret = new VkPipelineColorBlendAdvancedStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineColorBlendAdvancedStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceInlineUniformBlockFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 inlineUniformBlock;
        public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
        public static VkPhysicalDeviceInlineUniformBlockFeatures New()
        {
            VkPhysicalDeviceInlineUniformBlockFeatures ret = new VkPhysicalDeviceInlineUniformBlockFeatures();
            ret.sType = VkStructureType.PhysicalDeviceInlineUniformBlockFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceInlineUniformBlockFeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceInlineUniformBlockProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxInlineUniformBlockSize;
        public uint maxPerStageDescriptorInlineUniformBlocks;
        public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        public uint maxDescriptorSetInlineUniformBlocks;
        public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
        public static VkPhysicalDeviceInlineUniformBlockProperties New()
        {
            VkPhysicalDeviceInlineUniformBlockProperties ret = new VkPhysicalDeviceInlineUniformBlockProperties();
            ret.sType = VkStructureType.PhysicalDeviceInlineUniformBlockProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceInlineUniformBlockPropertiesEXT
    {
    }

    public unsafe partial struct VkWriteDescriptorSetInlineUniformBlock
    {
        public VkStructureType sType;
        public void* pNext;
        public uint dataSize;
        public void* pData;
        public static VkWriteDescriptorSetInlineUniformBlock New()
        {
            VkWriteDescriptorSetInlineUniformBlock ret = new VkWriteDescriptorSetInlineUniformBlock();
            ret.sType = VkStructureType.WriteDescriptorSetInlineUniformBlock;
            return ret;
        }
    }

    public unsafe partial struct VkWriteDescriptorSetInlineUniformBlockEXT
    {
    }

    public unsafe partial struct VkDescriptorPoolInlineUniformBlockCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxInlineUniformBlockBindings;
        public static VkDescriptorPoolInlineUniformBlockCreateInfo New()
        {
            VkDescriptorPoolInlineUniformBlockCreateInfo ret = new VkDescriptorPoolInlineUniformBlockCreateInfo();
            ret.sType = VkStructureType.DescriptorPoolInlineUniformBlockCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorPoolInlineUniformBlockCreateInfoEXT
    {
    }

    public unsafe partial struct VkPipelineCoverageModulationStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkCoverageModulationModeNV coverageModulationMode;
        public VkBool32 coverageModulationTableEnable;
        public uint coverageModulationTableCount;
        public float* pCoverageModulationTable;
        public static VkPipelineCoverageModulationStateCreateInfoNV New()
        {
            VkPipelineCoverageModulationStateCreateInfoNV ret = new VkPipelineCoverageModulationStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineCoverageModulationStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkImageFormatListCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint viewFormatCount;
        public VkFormat* pViewFormats;
        public static VkImageFormatListCreateInfo New()
        {
            VkImageFormatListCreateInfo ret = new VkImageFormatListCreateInfo();
            ret.sType = VkStructureType.ImageFormatListCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkImageFormatListCreateInfoKHR
    {
    }

    public unsafe partial struct VkValidationCacheCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public UIntPtr initialDataSize;
        public void* pInitialData;
        public static VkValidationCacheCreateInfoEXT New()
        {
            VkValidationCacheCreateInfoEXT ret = new VkValidationCacheCreateInfoEXT();
            ret.sType = VkStructureType.ValidationCacheCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkShaderModuleValidationCacheCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkValidationCacheEXT validationCache;
        public static VkShaderModuleValidationCacheCreateInfoEXT New()
        {
            VkShaderModuleValidationCacheCreateInfoEXT ret = new VkShaderModuleValidationCacheCreateInfoEXT();
            ret.sType = VkStructureType.ShaderModuleValidationCacheCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance3Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPerSetDescriptors;
        public ulong maxMemoryAllocationSize;
        public static VkPhysicalDeviceMaintenance3Properties New()
        {
            VkPhysicalDeviceMaintenance3Properties ret = new VkPhysicalDeviceMaintenance3Properties();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance3Properties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance3PropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance4Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 maintenance4;
        public static VkPhysicalDeviceMaintenance4Features New()
        {
            VkPhysicalDeviceMaintenance4Features ret = new VkPhysicalDeviceMaintenance4Features();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance4Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance4FeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance4Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong maxBufferSize;
        public static VkPhysicalDeviceMaintenance4Properties New()
        {
            VkPhysicalDeviceMaintenance4Properties ret = new VkPhysicalDeviceMaintenance4Properties();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance4Properties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance4PropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance5Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 maintenance5;
        public static VkPhysicalDeviceMaintenance5Features New()
        {
            VkPhysicalDeviceMaintenance5Features ret = new VkPhysicalDeviceMaintenance5Features();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance5Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance5FeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance5Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 earlyFragmentMultisampleCoverageAfterSampleCounting;
        public VkBool32 earlyFragmentSampleMaskTestBeforeSampleCounting;
        public VkBool32 depthStencilSwizzleOneSupport;
        public VkBool32 polygonModePointSize;
        public VkBool32 nonStrictSinglePixelWideLinesUseParallelogram;
        public VkBool32 nonStrictWideLinesUseParallelogram;
        public static VkPhysicalDeviceMaintenance5Properties New()
        {
            VkPhysicalDeviceMaintenance5Properties ret = new VkPhysicalDeviceMaintenance5Properties();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance5Properties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance5PropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance6Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 maintenance6;
        public static VkPhysicalDeviceMaintenance6Features New()
        {
            VkPhysicalDeviceMaintenance6Features ret = new VkPhysicalDeviceMaintenance6Features();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance6Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance6FeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance6Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 blockTexelViewCompatibleMultipleLayers;
        public uint maxCombinedImageSamplerDescriptorCount;
        public VkBool32 fragmentShadingRateClampCombinerInputs;
        public static VkPhysicalDeviceMaintenance6Properties New()
        {
            VkPhysicalDeviceMaintenance6Properties ret = new VkPhysicalDeviceMaintenance6Properties();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance6Properties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance6PropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance7FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 maintenance7;
        public static VkPhysicalDeviceMaintenance7FeaturesKHR New()
        {
            VkPhysicalDeviceMaintenance7FeaturesKHR ret = new VkPhysicalDeviceMaintenance7FeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance7FeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance7PropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 robustFragmentShadingRateAttachmentAccess;
        public VkBool32 separateDepthStencilAttachmentAccess;
        public uint maxDescriptorSetTotalUniformBuffersDynamic;
        public uint maxDescriptorSetTotalStorageBuffersDynamic;
        public uint maxDescriptorSetTotalBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindTotalUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindTotalStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindTotalBuffersDynamic;
        public static VkPhysicalDeviceMaintenance7PropertiesKHR New()
        {
            VkPhysicalDeviceMaintenance7PropertiesKHR ret = new VkPhysicalDeviceMaintenance7PropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance7PropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceLayeredApiPropertiesListKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint layeredApiCount;
        public VkPhysicalDeviceLayeredApiPropertiesKHR* pLayeredApis;
        public static VkPhysicalDeviceLayeredApiPropertiesListKHR New()
        {
            VkPhysicalDeviceLayeredApiPropertiesListKHR ret = new VkPhysicalDeviceLayeredApiPropertiesListKHR();
            ret.sType = VkStructureType.PhysicalDeviceLayeredApiPropertiesListKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceLayeredApiPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint vendorID;
        public uint deviceID;
        public VkPhysicalDeviceLayeredApiKHR layeredAPI;
        public fixed byte deviceName[(int)VulkanNative.MaxPhysicalDeviceNameSize];
        public static VkPhysicalDeviceLayeredApiPropertiesKHR New()
        {
            VkPhysicalDeviceLayeredApiPropertiesKHR ret = new VkPhysicalDeviceLayeredApiPropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceLayeredApiPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceLayeredApiVulkanPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPhysicalDeviceProperties2 properties;
        public static VkPhysicalDeviceLayeredApiVulkanPropertiesKHR New()
        {
            VkPhysicalDeviceLayeredApiVulkanPropertiesKHR ret = new VkPhysicalDeviceLayeredApiVulkanPropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceLayeredApiVulkanPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance8FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 maintenance8;
        public static VkPhysicalDeviceMaintenance8FeaturesKHR New()
        {
            VkPhysicalDeviceMaintenance8FeaturesKHR ret = new VkPhysicalDeviceMaintenance8FeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance8FeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance9FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 maintenance9;
        public static VkPhysicalDeviceMaintenance9FeaturesKHR New()
        {
            VkPhysicalDeviceMaintenance9FeaturesKHR ret = new VkPhysicalDeviceMaintenance9FeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance9FeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMaintenance9PropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 image2DViewOf3DSparse;
        public VkDefaultVertexAttributeValueKHR defaultVertexAttributeValue;
        public static VkPhysicalDeviceMaintenance9PropertiesKHR New()
        {
            VkPhysicalDeviceMaintenance9PropertiesKHR ret = new VkPhysicalDeviceMaintenance9PropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceMaintenance9PropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkQueueFamilyOwnershipTransferPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint optimalImageTransferToQueueFamilies;
        public static VkQueueFamilyOwnershipTransferPropertiesKHR New()
        {
            VkQueueFamilyOwnershipTransferPropertiesKHR ret = new VkQueueFamilyOwnershipTransferPropertiesKHR();
            ret.sType = VkStructureType.QueueFamilyOwnershipTransferPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkRenderingAreaInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkFormat* pColorAttachmentFormats;
        public VkFormat depthAttachmentFormat;
        public VkFormat stencilAttachmentFormat;
        public static VkRenderingAreaInfo New()
        {
            VkRenderingAreaInfo ret = new VkRenderingAreaInfo();
            ret.sType = VkStructureType.RenderingAreaInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderingAreaInfoKHR
    {
    }

    public unsafe partial struct VkDescriptorSetLayoutSupport
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 supported;
        public static VkDescriptorSetLayoutSupport New()
        {
            VkDescriptorSetLayoutSupport ret = new VkDescriptorSetLayoutSupport();
            ret.sType = VkStructureType.DescriptorSetLayoutSupport;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetLayoutSupportKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderDrawParametersFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderDrawParameters;
        public static VkPhysicalDeviceShaderDrawParametersFeatures New()
        {
            VkPhysicalDeviceShaderDrawParametersFeatures ret = new VkPhysicalDeviceShaderDrawParametersFeatures();
            ret.sType = VkStructureType.PhysicalDeviceShaderDrawParametersFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderDrawParameterFeatures
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderFloat16Int8Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderFloat16;
        public VkBool32 shaderInt8;
        public static VkPhysicalDeviceShaderFloat16Int8Features New()
        {
            VkPhysicalDeviceShaderFloat16Int8Features ret = new VkPhysicalDeviceShaderFloat16Int8Features();
            ret.sType = VkStructureType.PhysicalDeviceShaderFloat16Int8Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderFloat16Int8FeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceFloat16Int8FeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceFloatControlsProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public VkShaderFloatControlsIndependence roundingModeIndependence;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
        public VkBool32 shaderDenormPreserveFloat16;
        public VkBool32 shaderDenormPreserveFloat32;
        public VkBool32 shaderDenormPreserveFloat64;
        public VkBool32 shaderDenormFlushToZeroFloat16;
        public VkBool32 shaderDenormFlushToZeroFloat32;
        public VkBool32 shaderDenormFlushToZeroFloat64;
        public VkBool32 shaderRoundingModeRTEFloat16;
        public VkBool32 shaderRoundingModeRTEFloat32;
        public VkBool32 shaderRoundingModeRTEFloat64;
        public VkBool32 shaderRoundingModeRTZFloat16;
        public VkBool32 shaderRoundingModeRTZFloat32;
        public VkBool32 shaderRoundingModeRTZFloat64;
        public static VkPhysicalDeviceFloatControlsProperties New()
        {
            VkPhysicalDeviceFloatControlsProperties ret = new VkPhysicalDeviceFloatControlsProperties();
            ret.sType = VkStructureType.PhysicalDeviceFloatControlsProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFloatControlsPropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceHostQueryResetFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hostQueryReset;
        public static VkPhysicalDeviceHostQueryResetFeatures New()
        {
            VkPhysicalDeviceHostQueryResetFeatures ret = new VkPhysicalDeviceHostQueryResetFeatures();
            ret.sType = VkStructureType.PhysicalDeviceHostQueryResetFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceHostQueryResetFeaturesEXT
    {
    }

    public unsafe partial struct VkNativeBufferUsage2ANDROID
    {
        public ulong consumer;
        public ulong producer;
    }

    public unsafe partial struct VkNativeBufferANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public void* handle;
        public int stride;
        public int format;
        public int usage;
        public VkNativeBufferUsage2ANDROID usage2;
        public static VkNativeBufferANDROID New()
        {
            VkNativeBufferANDROID ret = new VkNativeBufferANDROID();
            ret.sType = VkStructureType.NativeBufferAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkSwapchainImageCreateInfoANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainImageUsageFlagsANDROID usage;
        public static VkSwapchainImageCreateInfoANDROID New()
        {
            VkSwapchainImageCreateInfoANDROID ret = new VkSwapchainImageCreateInfoANDROID();
            ret.sType = VkStructureType.SwapchainImageCreateInfoAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePresentationPropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 sharedImage;
        public static VkPhysicalDevicePresentationPropertiesANDROID New()
        {
            VkPhysicalDevicePresentationPropertiesANDROID ret = new VkPhysicalDevicePresentationPropertiesANDROID();
            ret.sType = VkStructureType.PhysicalDevicePresentationPropertiesAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkShaderResourceUsageAMD
    {
        public uint numUsedVgprs;
        public uint numUsedSgprs;
        public uint ldsSizePerLocalWorkGroup;
        public UIntPtr ldsUsageSizeInBytes;
        public UIntPtr scratchMemUsageInBytes;
    }

    public unsafe partial struct VkShaderStatisticsInfoAMD
    {
        public VkShaderStageFlags shaderStageMask;
        public VkShaderResourceUsageAMD resourceUsage;
        public uint numPhysicalVgprs;
        public uint numPhysicalSgprs;
        public uint numAvailableVgprs;
        public uint numAvailableSgprs;
        public uint computeWorkGroupSize_0;
        public uint computeWorkGroupSize_1;
        public uint computeWorkGroupSize_2;
    }

    public unsafe partial struct VkDeviceQueueGlobalPriorityCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueueGlobalPriority globalPriority;
        public static VkDeviceQueueGlobalPriorityCreateInfo New()
        {
            VkDeviceQueueGlobalPriorityCreateInfo ret = new VkDeviceQueueGlobalPriorityCreateInfo();
            ret.sType = VkStructureType.DeviceQueueGlobalPriorityCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceQueueGlobalPriorityCreateInfoKHR
    {
    }

    public unsafe partial struct VkDeviceQueueGlobalPriorityCreateInfoEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceGlobalPriorityQueryFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 globalPriorityQuery;
        public static VkPhysicalDeviceGlobalPriorityQueryFeatures New()
        {
            VkPhysicalDeviceGlobalPriorityQueryFeatures ret = new VkPhysicalDeviceGlobalPriorityQueryFeatures();
            ret.sType = VkStructureType.PhysicalDeviceGlobalPriorityQueryFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceGlobalPriorityQueryFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceGlobalPriorityQueryFeaturesEXT
    {
    }

    public unsafe partial struct VkQueueFamilyGlobalPriorityProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint priorityCount;
        public VkQueueGlobalPriority priorities_0;
        public VkQueueGlobalPriority priorities_1;
        public VkQueueGlobalPriority priorities_2;
        public VkQueueGlobalPriority priorities_3;
        public VkQueueGlobalPriority priorities_4;
        public VkQueueGlobalPriority priorities_5;
        public VkQueueGlobalPriority priorities_6;
        public VkQueueGlobalPriority priorities_7;
        public VkQueueGlobalPriority priorities_8;
        public VkQueueGlobalPriority priorities_9;
        public VkQueueGlobalPriority priorities_10;
        public VkQueueGlobalPriority priorities_11;
        public VkQueueGlobalPriority priorities_12;
        public VkQueueGlobalPriority priorities_13;
        public VkQueueGlobalPriority priorities_14;
        public VkQueueGlobalPriority priorities_15;
        public static VkQueueFamilyGlobalPriorityProperties New()
        {
            VkQueueFamilyGlobalPriorityProperties ret = new VkQueueFamilyGlobalPriorityProperties();
            ret.sType = VkStructureType.QueueFamilyGlobalPriorityProperties;
            return ret;
        }
    }

    public unsafe partial struct VkQueueFamilyGlobalPriorityPropertiesKHR
    {
    }

    public unsafe partial struct VkQueueFamilyGlobalPriorityPropertiesEXT
    {
    }

    public unsafe partial struct VkDebugUtilsObjectNameInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkObjectType objectType;
        public ulong objectHandle;
        public byte* pObjectName;
        public static VkDebugUtilsObjectNameInfoEXT New()
        {
            VkDebugUtilsObjectNameInfoEXT ret = new VkDebugUtilsObjectNameInfoEXT();
            ret.sType = VkStructureType.DebugUtilsObjectNameInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugUtilsObjectTagInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkObjectType objectType;
        public ulong objectHandle;
        public ulong tagName;
        public UIntPtr tagSize;
        public void* pTag;
        public static VkDebugUtilsObjectTagInfoEXT New()
        {
            VkDebugUtilsObjectTagInfoEXT ret = new VkDebugUtilsObjectTagInfoEXT();
            ret.sType = VkStructureType.DebugUtilsObjectTagInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugUtilsLabelEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pLabelName;
        public float color_0;
        public float color_1;
        public float color_2;
        public float color_3;
        public static VkDebugUtilsLabelEXT New()
        {
            VkDebugUtilsLabelEXT ret = new VkDebugUtilsLabelEXT();
            ret.sType = VkStructureType.DebugUtilsLabelEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugUtilsMessengerCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkDebugUtilsMessageSeverityFlagsEXT messageSeverity;
        public VkDebugUtilsMessageTypeFlagsEXT messageType;
        public IntPtr pfnUserCallback;
        public void* pUserData;
        public static VkDebugUtilsMessengerCreateInfoEXT New()
        {
            VkDebugUtilsMessengerCreateInfoEXT ret = new VkDebugUtilsMessengerCreateInfoEXT();
            ret.sType = VkStructureType.DebugUtilsMessengerCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDebugUtilsMessengerCallbackDataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public byte* pMessageIdName;
        public int messageIdNumber;
        public byte* pMessage;
        public uint queueLabelCount;
        public VkDebugUtilsLabelEXT* pQueueLabels;
        public uint cmdBufLabelCount;
        public VkDebugUtilsLabelEXT* pCmdBufLabels;
        public uint objectCount;
        public VkDebugUtilsObjectNameInfoEXT* pObjects;
        public static VkDebugUtilsMessengerCallbackDataEXT New()
        {
            VkDebugUtilsMessengerCallbackDataEXT ret = new VkDebugUtilsMessengerCallbackDataEXT();
            ret.sType = VkStructureType.DebugUtilsMessengerCallbackDataEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDeviceMemoryReportFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 deviceMemoryReport;
        public static VkPhysicalDeviceDeviceMemoryReportFeaturesEXT New()
        {
            VkPhysicalDeviceDeviceMemoryReportFeaturesEXT ret = new VkPhysicalDeviceDeviceMemoryReportFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDeviceMemoryReportFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceDeviceMemoryReportCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public IntPtr pfnUserCallback;
        public void* pUserData;
        public static VkDeviceDeviceMemoryReportCreateInfoEXT New()
        {
            VkDeviceDeviceMemoryReportCreateInfoEXT ret = new VkDeviceDeviceMemoryReportCreateInfoEXT();
            ret.sType = VkStructureType.DeviceDeviceMemoryReportCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceMemoryReportCallbackDataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkDeviceMemoryReportEventTypeEXT type;
        public ulong memoryObjectId;
        public ulong size;
        public VkObjectType objectType;
        public ulong objectHandle;
        public uint heapIndex;
        public static VkDeviceMemoryReportCallbackDataEXT New()
        {
            VkDeviceMemoryReportCallbackDataEXT ret = new VkDeviceMemoryReportCallbackDataEXT();
            ret.sType = VkStructureType.DeviceMemoryReportCallbackDataEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImportMemoryHostPointerInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleType;
        public void* pHostPointer;
        public static VkImportMemoryHostPointerInfoEXT New()
        {
            VkImportMemoryHostPointerInfoEXT ret = new VkImportMemoryHostPointerInfoEXT();
            ret.sType = VkStructureType.ImportMemoryHostPointerInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryHostPointerPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
        public static VkMemoryHostPointerPropertiesEXT New()
        {
            VkMemoryHostPointerPropertiesEXT ret = new VkMemoryHostPointerPropertiesEXT();
            ret.sType = VkStructureType.MemoryHostPointerPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalMemoryHostPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong minImportedHostPointerAlignment;
        public static VkPhysicalDeviceExternalMemoryHostPropertiesEXT New()
        {
            VkPhysicalDeviceExternalMemoryHostPropertiesEXT ret = new VkPhysicalDeviceExternalMemoryHostPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceExternalMemoryHostPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceConservativeRasterizationPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public float primitiveOverestimationSize;
        public float maxExtraPrimitiveOverestimationSize;
        public float extraPrimitiveOverestimationSizeGranularity;
        public VkBool32 primitiveUnderestimation;
        public VkBool32 conservativePointAndLineRasterization;
        public VkBool32 degenerateTrianglesRasterized;
        public VkBool32 degenerateLinesRasterized;
        public VkBool32 fullyCoveredFragmentShaderInputVariable;
        public VkBool32 conservativeRasterizationPostDepthCoverage;
        public static VkPhysicalDeviceConservativeRasterizationPropertiesEXT New()
        {
            VkPhysicalDeviceConservativeRasterizationPropertiesEXT ret = new VkPhysicalDeviceConservativeRasterizationPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceConservativeRasterizationPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkCalibratedTimestampInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTimeDomainKHR timeDomain;
        public static VkCalibratedTimestampInfoKHR New()
        {
            VkCalibratedTimestampInfoKHR ret = new VkCalibratedTimestampInfoKHR();
            ret.sType = VkStructureType.CalibratedTimestampInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkCalibratedTimestampInfoEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderEngineCount;
        public uint shaderArraysPerEngineCount;
        public uint computeUnitsPerShaderArray;
        public uint simdPerComputeUnit;
        public uint wavefrontsPerSimd;
        public uint wavefrontSize;
        public uint sgprsPerSimd;
        public uint minSgprAllocation;
        public uint maxSgprAllocation;
        public uint sgprAllocationGranularity;
        public uint vgprsPerSimd;
        public uint minVgprAllocation;
        public uint maxVgprAllocation;
        public uint vgprAllocationGranularity;
        public static VkPhysicalDeviceShaderCorePropertiesAMD New()
        {
            VkPhysicalDeviceShaderCorePropertiesAMD ret = new VkPhysicalDeviceShaderCorePropertiesAMD();
            ret.sType = VkStructureType.PhysicalDeviceShaderCorePropertiesAMD;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderCoreProperties2AMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderCorePropertiesFlagsAMD shaderCoreFeatures;
        public uint activeComputeUnitCount;
        public static VkPhysicalDeviceShaderCoreProperties2AMD New()
        {
            VkPhysicalDeviceShaderCoreProperties2AMD ret = new VkPhysicalDeviceShaderCoreProperties2AMD();
            ret.sType = VkStructureType.PhysicalDeviceShaderCoreProperties2AMD;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationConservativeStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkConservativeRasterizationModeEXT conservativeRasterizationMode;
        public float extraPrimitiveOverestimationSize;
        public static VkPipelineRasterizationConservativeStateCreateInfoEXT New()
        {
            VkPipelineRasterizationConservativeStateCreateInfoEXT ret = new VkPipelineRasterizationConservativeStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineRasterizationConservativeStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
        public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
        public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
        public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
        public VkBool32 shaderSampledImageArrayNonUniformIndexing;
        public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
        public VkBool32 shaderStorageImageArrayNonUniformIndexing;
        public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
        public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
        public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
        public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
        public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
        public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
        public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
        public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
        public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
        public VkBool32 descriptorBindingUpdateUnusedWhilePending;
        public VkBool32 descriptorBindingPartiallyBound;
        public VkBool32 descriptorBindingVariableDescriptorCount;
        public VkBool32 runtimeDescriptorArray;
        public static VkPhysicalDeviceDescriptorIndexingFeatures New()
        {
            VkPhysicalDeviceDescriptorIndexingFeatures ret = new VkPhysicalDeviceDescriptorIndexingFeatures();
            ret.sType = VkStructureType.PhysicalDeviceDescriptorIndexingFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingFeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxUpdateAfterBindDescriptorsInAllPools;
        public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
        public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
        public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
        public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
        public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
        public VkBool32 robustBufferAccessUpdateAfterBind;
        public VkBool32 quadDivergentImplicitLod;
        public uint maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint maxPerStageUpdateAfterBindResources;
        public uint maxDescriptorSetUpdateAfterBindSamplers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindSampledImages;
        public uint maxDescriptorSetUpdateAfterBindStorageImages;
        public uint maxDescriptorSetUpdateAfterBindInputAttachments;
        public static VkPhysicalDeviceDescriptorIndexingProperties New()
        {
            VkPhysicalDeviceDescriptorIndexingProperties ret = new VkPhysicalDeviceDescriptorIndexingProperties();
            ret.sType = VkStructureType.PhysicalDeviceDescriptorIndexingProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorIndexingPropertiesEXT
    {
    }

    public unsafe partial struct VkDescriptorSetLayoutBindingFlagsCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint bindingCount;
        public VkDescriptorBindingFlags* pBindingFlags;
        public static VkDescriptorSetLayoutBindingFlagsCreateInfo New()
        {
            VkDescriptorSetLayoutBindingFlagsCreateInfo ret = new VkDescriptorSetLayoutBindingFlagsCreateInfo();
            ret.sType = VkStructureType.DescriptorSetLayoutBindingCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetLayoutBindingFlagsCreateInfoEXT
    {
    }

    public unsafe partial struct VkDescriptorSetVariableDescriptorCountAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint descriptorSetCount;
        public uint* pDescriptorCounts;
        public static VkDescriptorSetVariableDescriptorCountAllocateInfo New()
        {
            VkDescriptorSetVariableDescriptorCountAllocateInfo ret = new VkDescriptorSetVariableDescriptorCountAllocateInfo();
            ret.sType = VkStructureType.DescriptorSetVariableDescriptorCountAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetVariableDescriptorCountAllocateInfoEXT
    {
    }

    public unsafe partial struct VkDescriptorSetVariableDescriptorCountLayoutSupport
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxVariableDescriptorCount;
        public static VkDescriptorSetVariableDescriptorCountLayoutSupport New()
        {
            VkDescriptorSetVariableDescriptorCountLayoutSupport ret = new VkDescriptorSetVariableDescriptorCountLayoutSupport();
            ret.sType = VkStructureType.DescriptorSetVariableDescriptorCountLayoutSupport;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetVariableDescriptorCountLayoutSupportEXT
    {
    }

    public unsafe partial struct VkAttachmentDescription2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAttachmentDescriptionFlags flags;
        public VkFormat format;
        public VkSampleCountFlags samples;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkAttachmentLoadOp stencilLoadOp;
        public VkAttachmentStoreOp stencilStoreOp;
        public VkImageLayout initialLayout;
        public VkImageLayout finalLayout;
        public static VkAttachmentDescription2 New()
        {
            VkAttachmentDescription2 ret = new VkAttachmentDescription2();
            ret.sType = VkStructureType.AttachmentDescription2;
            return ret;
        }
    }

    public unsafe partial struct VkAttachmentDescription2KHR
    {
    }

    public unsafe partial struct VkAttachmentReference2
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachment;
        public VkImageLayout layout;
        public VkImageAspectFlags aspectMask;
        public static VkAttachmentReference2 New()
        {
            VkAttachmentReference2 ret = new VkAttachmentReference2();
            ret.sType = VkStructureType.AttachmentReference2;
            return ret;
        }
    }

    public unsafe partial struct VkAttachmentReference2KHR
    {
    }

    public unsafe partial struct VkSubpassDescription2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubpassDescriptionFlags flags;
        public VkPipelineBindPoint pipelineBindPoint;
        public uint viewMask;
        public uint inputAttachmentCount;
        public VkAttachmentReference2* pInputAttachments;
        public uint colorAttachmentCount;
        public VkAttachmentReference2* pColorAttachments;
        public VkAttachmentReference2* pResolveAttachments;
        public VkAttachmentReference2* pDepthStencilAttachment;
        public uint preserveAttachmentCount;
        public uint* pPreserveAttachments;
        public static VkSubpassDescription2 New()
        {
            VkSubpassDescription2 ret = new VkSubpassDescription2();
            ret.sType = VkStructureType.SubpassDescription2;
            return ret;
        }
    }

    public unsafe partial struct VkSubpassDescription2KHR
    {
    }

    public unsafe partial struct VkSubpassDependency2
    {
        public VkStructureType sType;
        public void* pNext;
        public uint srcSubpass;
        public uint dstSubpass;
        public VkPipelineStageFlags srcStageMask;
        public VkPipelineStageFlags dstStageMask;
        public VkAccessFlags srcAccessMask;
        public VkAccessFlags dstAccessMask;
        public VkDependencyFlags dependencyFlags;
        public int viewOffset;
        public static VkSubpassDependency2 New()
        {
            VkSubpassDependency2 ret = new VkSubpassDependency2();
            ret.sType = VkStructureType.SubpassDependency2;
            return ret;
        }
    }

    public unsafe partial struct VkSubpassDependency2KHR
    {
    }

    public unsafe partial struct VkRenderPassCreateInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassCreateFlags flags;
        public uint attachmentCount;
        public VkAttachmentDescription2* pAttachments;
        public uint subpassCount;
        public VkSubpassDescription2* pSubpasses;
        public uint dependencyCount;
        public VkSubpassDependency2* pDependencies;
        public uint correlatedViewMaskCount;
        public uint* pCorrelatedViewMasks;
        public static VkRenderPassCreateInfo2 New()
        {
            VkRenderPassCreateInfo2 ret = new VkRenderPassCreateInfo2();
            ret.sType = VkStructureType.RenderPassCreateInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassCreateInfo2KHR
    {
    }

    public unsafe partial struct VkSubpassBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubpassContents contents;
        public static VkSubpassBeginInfo New()
        {
            VkSubpassBeginInfo ret = new VkSubpassBeginInfo();
            ret.sType = VkStructureType.SubpassBeginInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSubpassBeginInfoKHR
    {
    }

    public unsafe partial struct VkSubpassEndInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public static VkSubpassEndInfo New()
        {
            VkSubpassEndInfo ret = new VkSubpassEndInfo();
            ret.sType = VkStructureType.SubpassEndInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSubpassEndInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 timelineSemaphore;
        public static VkPhysicalDeviceTimelineSemaphoreFeatures New()
        {
            VkPhysicalDeviceTimelineSemaphoreFeatures ret = new VkPhysicalDeviceTimelineSemaphoreFeatures();
            ret.sType = VkStructureType.PhysicalDeviceTimelineSemaphoreFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceTimelineSemaphoreProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong maxTimelineSemaphoreValueDifference;
        public static VkPhysicalDeviceTimelineSemaphoreProperties New()
        {
            VkPhysicalDeviceTimelineSemaphoreProperties ret = new VkPhysicalDeviceTimelineSemaphoreProperties();
            ret.sType = VkStructureType.PhysicalDeviceTimelineSemaphoreProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTimelineSemaphorePropertiesKHR
    {
    }

    public unsafe partial struct VkSemaphoreTypeCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphoreType semaphoreType;
        public ulong initialValue;
        public static VkSemaphoreTypeCreateInfo New()
        {
            VkSemaphoreTypeCreateInfo ret = new VkSemaphoreTypeCreateInfo();
            ret.sType = VkStructureType.SemaphoreTypeCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreTypeCreateInfoKHR
    {
    }

    public unsafe partial struct VkTimelineSemaphoreSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint waitSemaphoreValueCount;
        public ulong* pWaitSemaphoreValues;
        public uint signalSemaphoreValueCount;
        public ulong* pSignalSemaphoreValues;
        public static VkTimelineSemaphoreSubmitInfo New()
        {
            VkTimelineSemaphoreSubmitInfo ret = new VkTimelineSemaphoreSubmitInfo();
            ret.sType = VkStructureType.TimelineSemaphoreSubmitInfo;
            return ret;
        }
    }

    public unsafe partial struct VkTimelineSemaphoreSubmitInfoKHR
    {
    }

    public unsafe partial struct VkSemaphoreWaitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphoreWaitFlags flags;
        public uint semaphoreCount;
        public VkSemaphore* pSemaphores;
        public ulong* pValues;
        public static VkSemaphoreWaitInfo New()
        {
            VkSemaphoreWaitInfo ret = new VkSemaphoreWaitInfo();
            ret.sType = VkStructureType.SemaphoreWaitInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreWaitInfoKHR
    {
    }

    public unsafe partial struct VkSemaphoreSignalInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public ulong value;
        public static VkSemaphoreSignalInfo New()
        {
            VkSemaphoreSignalInfo ret = new VkSemaphoreSignalInfo();
            ret.sType = VkStructureType.SemaphoreSignalInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreSignalInfoKHR
    {
    }

    public unsafe partial struct VkVertexInputBindingDivisorDescription
    {
        public uint binding;
        public uint divisor;
    }

    public unsafe partial struct VkVertexInputBindingDivisorDescriptionKHR
    {
    }

    public unsafe partial struct VkVertexInputBindingDivisorDescriptionEXT
    {
    }

    public unsafe partial struct VkPipelineVertexInputDivisorStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint vertexBindingDivisorCount;
        public VkVertexInputBindingDivisorDescription* pVertexBindingDivisors;
        public static VkPipelineVertexInputDivisorStateCreateInfo New()
        {
            VkPipelineVertexInputDivisorStateCreateInfo ret = new VkPipelineVertexInputDivisorStateCreateInfo();
            ret.sType = VkStructureType.PipelineVertexInputDivisorStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineVertexInputDivisorStateCreateInfoKHR
    {
    }

    public unsafe partial struct VkPipelineVertexInputDivisorStateCreateInfoEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxVertexAttribDivisor;
        public static VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT New()
        {
            VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT ret = new VkPhysicalDeviceVertexAttributeDivisorPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceVertexAttributeDivisorPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxVertexAttribDivisor;
        public VkBool32 supportsNonZeroFirstInstance;
        public static VkPhysicalDeviceVertexAttributeDivisorProperties New()
        {
            VkPhysicalDeviceVertexAttributeDivisorProperties ret = new VkPhysicalDeviceVertexAttributeDivisorProperties();
            ret.sType = VkStructureType.PhysicalDeviceVertexAttributeDivisorProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorPropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDevicePCIBusInfoPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint pciDomain;
        public uint pciBus;
        public uint pciDevice;
        public uint pciFunction;
        public static VkPhysicalDevicePCIBusInfoPropertiesEXT New()
        {
            VkPhysicalDevicePCIBusInfoPropertiesEXT ret = new VkPhysicalDevicePCIBusInfoPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDevicePciBusInfoPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImportAndroidHardwareBufferInfoANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public Android.AHardwareBuffer* buffer;
        public static VkImportAndroidHardwareBufferInfoANDROID New()
        {
            VkImportAndroidHardwareBufferInfoANDROID ret = new VkImportAndroidHardwareBufferInfoANDROID();
            ret.sType = VkStructureType.ImportAndroidHardwareBufferInfoAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkAndroidHardwareBufferUsageANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong androidHardwareBufferUsage;
        public static VkAndroidHardwareBufferUsageANDROID New()
        {
            VkAndroidHardwareBufferUsageANDROID ret = new VkAndroidHardwareBufferUsageANDROID();
            ret.sType = VkStructureType.AndroidHardwareBufferUsageAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkAndroidHardwareBufferPropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong allocationSize;
        public uint memoryTypeBits;
        public static VkAndroidHardwareBufferPropertiesANDROID New()
        {
            VkAndroidHardwareBufferPropertiesANDROID ret = new VkAndroidHardwareBufferPropertiesANDROID();
            ret.sType = VkStructureType.AndroidHardwareBufferPropertiesAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryGetAndroidHardwareBufferInfoANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public static VkMemoryGetAndroidHardwareBufferInfoANDROID New()
        {
            VkMemoryGetAndroidHardwareBufferInfoANDROID ret = new VkMemoryGetAndroidHardwareBufferInfoANDROID();
            ret.sType = VkStructureType.MemoryGetAndroidHardwareBufferInfoAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkAndroidHardwareBufferFormatPropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public ulong externalFormat;
        public VkFormatFeatureFlags formatFeatures;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
        public static VkAndroidHardwareBufferFormatPropertiesANDROID New()
        {
            VkAndroidHardwareBufferFormatPropertiesANDROID ret = new VkAndroidHardwareBufferFormatPropertiesANDROID();
            ret.sType = VkStructureType.AndroidHardwareBufferFormatPropertiesAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferInheritanceConditionalRenderingInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 conditionalRenderingEnable;
        public static VkCommandBufferInheritanceConditionalRenderingInfoEXT New()
        {
            VkCommandBufferInheritanceConditionalRenderingInfoEXT ret = new VkCommandBufferInheritanceConditionalRenderingInfoEXT();
            ret.sType = VkStructureType.CommandBufferInheritanceConditionalRenderingInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkExternalFormatANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong externalFormat;
        public static VkExternalFormatANDROID New()
        {
            VkExternalFormatANDROID ret = new VkExternalFormatANDROID();
            ret.sType = VkStructureType.ExternalFormatAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevice8BitStorageFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 storageBuffer8BitAccess;
        public VkBool32 uniformAndStorageBuffer8BitAccess;
        public VkBool32 storagePushConstant8;
        public static VkPhysicalDevice8BitStorageFeatures New()
        {
            VkPhysicalDevice8BitStorageFeatures ret = new VkPhysicalDevice8BitStorageFeatures();
            ret.sType = VkStructureType.PhysicalDevice8bitStorageFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevice8BitStorageFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceConditionalRenderingFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 conditionalRendering;
        public VkBool32 inheritedConditionalRendering;
        public static VkPhysicalDeviceConditionalRenderingFeaturesEXT New()
        {
            VkPhysicalDeviceConditionalRenderingFeaturesEXT ret = new VkPhysicalDeviceConditionalRenderingFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceConditionalRenderingFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkanMemoryModelFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 vulkanMemoryModel;
        public VkBool32 vulkanMemoryModelDeviceScope;
        public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
        public static VkPhysicalDeviceVulkanMemoryModelFeatures New()
        {
            VkPhysicalDeviceVulkanMemoryModelFeatures ret = new VkPhysicalDeviceVulkanMemoryModelFeatures();
            ret.sType = VkStructureType.PhysicalDeviceVulkanMemoryModelFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkanMemoryModelFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderAtomicInt64Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderBufferInt64Atomics;
        public VkBool32 shaderSharedInt64Atomics;
        public static VkPhysicalDeviceShaderAtomicInt64Features New()
        {
            VkPhysicalDeviceShaderAtomicInt64Features ret = new VkPhysicalDeviceShaderAtomicInt64Features();
            ret.sType = VkStructureType.PhysicalDeviceShaderAtomicInt64Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderAtomicInt64FeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderBufferFloat32Atomics;
        public VkBool32 shaderBufferFloat32AtomicAdd;
        public VkBool32 shaderBufferFloat64Atomics;
        public VkBool32 shaderBufferFloat64AtomicAdd;
        public VkBool32 shaderSharedFloat32Atomics;
        public VkBool32 shaderSharedFloat32AtomicAdd;
        public VkBool32 shaderSharedFloat64Atomics;
        public VkBool32 shaderSharedFloat64AtomicAdd;
        public VkBool32 shaderImageFloat32Atomics;
        public VkBool32 shaderImageFloat32AtomicAdd;
        public VkBool32 sparseImageFloat32Atomics;
        public VkBool32 sparseImageFloat32AtomicAdd;
        public static VkPhysicalDeviceShaderAtomicFloatFeaturesEXT New()
        {
            VkPhysicalDeviceShaderAtomicFloatFeaturesEXT ret = new VkPhysicalDeviceShaderAtomicFloatFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderAtomicFloatFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderBufferFloat16Atomics;
        public VkBool32 shaderBufferFloat16AtomicAdd;
        public VkBool32 shaderBufferFloat16AtomicMinMax;
        public VkBool32 shaderBufferFloat32AtomicMinMax;
        public VkBool32 shaderBufferFloat64AtomicMinMax;
        public VkBool32 shaderSharedFloat16Atomics;
        public VkBool32 shaderSharedFloat16AtomicAdd;
        public VkBool32 shaderSharedFloat16AtomicMinMax;
        public VkBool32 shaderSharedFloat32AtomicMinMax;
        public VkBool32 shaderSharedFloat64AtomicMinMax;
        public VkBool32 shaderImageFloat32AtomicMinMax;
        public VkBool32 sparseImageFloat32AtomicMinMax;
        public static VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT New()
        {
            VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT ret = new VkPhysicalDeviceShaderAtomicFloat2FeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderAtomicFloat2FeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 vertexAttributeInstanceRateDivisor;
        public VkBool32 vertexAttributeInstanceRateZeroDivisor;
        public static VkPhysicalDeviceVertexAttributeDivisorFeatures New()
        {
            VkPhysicalDeviceVertexAttributeDivisorFeatures ret = new VkPhysicalDeviceVertexAttributeDivisorFeatures();
            ret.sType = VkStructureType.PhysicalDeviceVertexAttributeDivisorFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
    {
    }

    public unsafe partial struct VkQueueFamilyCheckpointPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags checkpointExecutionStageMask;
        public static VkQueueFamilyCheckpointPropertiesNV New()
        {
            VkQueueFamilyCheckpointPropertiesNV ret = new VkQueueFamilyCheckpointPropertiesNV();
            ret.sType = VkStructureType.QueueFamilyCheckpointPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkCheckpointDataNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineStageFlags stage;
        public void* pCheckpointMarker;
        public static VkCheckpointDataNV New()
        {
            VkCheckpointDataNV ret = new VkCheckpointDataNV();
            ret.sType = VkStructureType.CheckpointDataNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDepthStencilResolveProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkResolveModeFlags supportedDepthResolveModes;
        public VkResolveModeFlags supportedStencilResolveModes;
        public VkBool32 independentResolveNone;
        public VkBool32 independentResolve;
        public static VkPhysicalDeviceDepthStencilResolveProperties New()
        {
            VkPhysicalDeviceDepthStencilResolveProperties ret = new VkPhysicalDeviceDepthStencilResolveProperties();
            ret.sType = VkStructureType.PhysicalDeviceDepthStencilResolveProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDepthStencilResolvePropertiesKHR
    {
    }

    public unsafe partial struct VkSubpassDescriptionDepthStencilResolve
    {
        public VkStructureType sType;
        public void* pNext;
        public VkResolveModeFlags depthResolveMode;
        public VkResolveModeFlags stencilResolveMode;
        public VkAttachmentReference2* pDepthStencilResolveAttachment;
        public static VkSubpassDescriptionDepthStencilResolve New()
        {
            VkSubpassDescriptionDepthStencilResolve ret = new VkSubpassDescriptionDepthStencilResolve();
            ret.sType = VkStructureType.SubpassDescriptionDepthStencilResolve;
            return ret;
        }
    }

    public unsafe partial struct VkSubpassDescriptionDepthStencilResolveKHR
    {
    }

    public unsafe partial struct VkImageViewASTCDecodeModeEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat decodeMode;
        public static VkImageViewASTCDecodeModeEXT New()
        {
            VkImageViewASTCDecodeModeEXT ret = new VkImageViewASTCDecodeModeEXT();
            ret.sType = VkStructureType.ImageViewAstcDecodeModeEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceASTCDecodeFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 decodeModeSharedExponent;
        public static VkPhysicalDeviceASTCDecodeFeaturesEXT New()
        {
            VkPhysicalDeviceASTCDecodeFeaturesEXT ret = new VkPhysicalDeviceASTCDecodeFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceAstcDecodeFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTransformFeedbackFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 transformFeedback;
        public VkBool32 geometryStreams;
        public static VkPhysicalDeviceTransformFeedbackFeaturesEXT New()
        {
            VkPhysicalDeviceTransformFeedbackFeaturesEXT ret = new VkPhysicalDeviceTransformFeedbackFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceTransformFeedbackFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxTransformFeedbackStreams;
        public uint maxTransformFeedbackBuffers;
        public ulong maxTransformFeedbackBufferSize;
        public uint maxTransformFeedbackStreamDataSize;
        public uint maxTransformFeedbackBufferDataSize;
        public uint maxTransformFeedbackBufferDataStride;
        public VkBool32 transformFeedbackQueries;
        public VkBool32 transformFeedbackStreamsLinesTriangles;
        public VkBool32 transformFeedbackRasterizationStreamSelect;
        public VkBool32 transformFeedbackDraw;
        public static VkPhysicalDeviceTransformFeedbackPropertiesEXT New()
        {
            VkPhysicalDeviceTransformFeedbackPropertiesEXT ret = new VkPhysicalDeviceTransformFeedbackPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceTransformFeedbackPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationStateStreamCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public uint rasterizationStream;
        public static VkPipelineRasterizationStateStreamCreateInfoEXT New()
        {
            VkPipelineRasterizationStateStreamCreateInfoEXT ret = new VkPipelineRasterizationStateStreamCreateInfoEXT();
            ret.sType = VkStructureType.PipelineRasterizationStateStreamCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 representativeFragmentTest;
        public static VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV New()
        {
            VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV ret = new VkPhysicalDeviceRepresentativeFragmentTestFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceRepresentativeFragmentTestFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRepresentativeFragmentTestStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 representativeFragmentTestEnable;
        public static VkPipelineRepresentativeFragmentTestStateCreateInfoNV New()
        {
            VkPipelineRepresentativeFragmentTestStateCreateInfoNV ret = new VkPipelineRepresentativeFragmentTestStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineRepresentativeFragmentTestStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExclusiveScissorFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 exclusiveScissor;
        public static VkPhysicalDeviceExclusiveScissorFeaturesNV New()
        {
            VkPhysicalDeviceExclusiveScissorFeaturesNV ret = new VkPhysicalDeviceExclusiveScissorFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceExclusiveScissorFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineViewportExclusiveScissorStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint exclusiveScissorCount;
        public VkRect2D* pExclusiveScissors;
        public static VkPipelineViewportExclusiveScissorStateCreateInfoNV New()
        {
            VkPipelineViewportExclusiveScissorStateCreateInfoNV ret = new VkPipelineViewportExclusiveScissorStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineViewportExclusiveScissorStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCornerSampledImageFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 cornerSampledImage;
        public static VkPhysicalDeviceCornerSampledImageFeaturesNV New()
        {
            VkPhysicalDeviceCornerSampledImageFeaturesNV ret = new VkPhysicalDeviceCornerSampledImageFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceCornerSampledImageFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceComputeShaderDerivativesFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 computeDerivativeGroupQuads;
        public VkBool32 computeDerivativeGroupLinear;
        public static VkPhysicalDeviceComputeShaderDerivativesFeaturesKHR New()
        {
            VkPhysicalDeviceComputeShaderDerivativesFeaturesKHR ret = new VkPhysicalDeviceComputeShaderDerivativesFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceComputeShaderDerivativesFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceComputeShaderDerivativesFeaturesNV
    {
    }

    public unsafe partial struct VkPhysicalDeviceComputeShaderDerivativesPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 meshAndTaskShaderDerivatives;
        public static VkPhysicalDeviceComputeShaderDerivativesPropertiesKHR New()
        {
            VkPhysicalDeviceComputeShaderDerivativesPropertiesKHR ret = new VkPhysicalDeviceComputeShaderDerivativesPropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceComputeShaderDerivativesPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesNV
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderImageFootprintFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 imageFootprint;
        public static VkPhysicalDeviceShaderImageFootprintFeaturesNV New()
        {
            VkPhysicalDeviceShaderImageFootprintFeaturesNV ret = new VkPhysicalDeviceShaderImageFootprintFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceShaderImageFootprintFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dedicatedAllocationImageAliasing;
        public static VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV New()
        {
            VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV ret = new VkPhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceDedicatedAllocationImageAliasingFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCopyMemoryIndirectFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 indirectCopy;
        public static VkPhysicalDeviceCopyMemoryIndirectFeaturesNV New()
        {
            VkPhysicalDeviceCopyMemoryIndirectFeaturesNV ret = new VkPhysicalDeviceCopyMemoryIndirectFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceCopyMemoryIndirectFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCopyMemoryIndirectPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueueFlags supportedQueues;
        public static VkPhysicalDeviceCopyMemoryIndirectPropertiesNV New()
        {
            VkPhysicalDeviceCopyMemoryIndirectPropertiesNV ret = new VkPhysicalDeviceCopyMemoryIndirectPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceCopyMemoryIndirectPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMemoryDecompressionFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 memoryDecompression;
        public static VkPhysicalDeviceMemoryDecompressionFeaturesNV New()
        {
            VkPhysicalDeviceMemoryDecompressionFeaturesNV ret = new VkPhysicalDeviceMemoryDecompressionFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceMemoryDecompressionFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMemoryDecompressionPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint decompressionMethods;
        public ulong maxDecompressionIndirectCount;
        public static VkPhysicalDeviceMemoryDecompressionPropertiesNV New()
        {
            VkPhysicalDeviceMemoryDecompressionPropertiesNV ret = new VkPhysicalDeviceMemoryDecompressionPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceMemoryDecompressionPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkShadingRatePaletteNV
    {
        public uint shadingRatePaletteEntryCount;
        public VkShadingRatePaletteEntryNV* pShadingRatePaletteEntries;
    }

    public unsafe partial struct VkPipelineViewportShadingRateImageStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shadingRateImageEnable;
        public uint viewportCount;
        public VkShadingRatePaletteNV* pShadingRatePalettes;
        public static VkPipelineViewportShadingRateImageStateCreateInfoNV New()
        {
            VkPipelineViewportShadingRateImageStateCreateInfoNV ret = new VkPipelineViewportShadingRateImageStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineViewportShadingRateImageStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShadingRateImageFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shadingRateImage;
        public VkBool32 shadingRateCoarseSampleOrder;
        public static VkPhysicalDeviceShadingRateImageFeaturesNV New()
        {
            VkPhysicalDeviceShadingRateImageFeaturesNV ret = new VkPhysicalDeviceShadingRateImageFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceShadingRateImageFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShadingRateImagePropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D shadingRateTexelSize;
        public uint shadingRatePaletteSize;
        public uint shadingRateMaxCoarseSamples;
        public static VkPhysicalDeviceShadingRateImagePropertiesNV New()
        {
            VkPhysicalDeviceShadingRateImagePropertiesNV ret = new VkPhysicalDeviceShadingRateImagePropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceShadingRateImagePropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceInvocationMaskFeaturesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 invocationMask;
        public static VkPhysicalDeviceInvocationMaskFeaturesHUAWEI New()
        {
            VkPhysicalDeviceInvocationMaskFeaturesHUAWEI ret = new VkPhysicalDeviceInvocationMaskFeaturesHUAWEI();
            ret.sType = VkStructureType.PhysicalDeviceInvocationMaskFeaturesHuawei;
            return ret;
        }
    }

    public unsafe partial struct VkCoarseSampleLocationNV
    {
        public uint pixelX;
        public uint pixelY;
        public uint sample;
    }

    public unsafe partial struct VkCoarseSampleOrderCustomNV
    {
        public VkShadingRatePaletteEntryNV shadingRate;
        public uint sampleCount;
        public uint sampleLocationCount;
        public VkCoarseSampleLocationNV* pSampleLocations;
    }

    public unsafe partial struct VkPipelineViewportCoarseSampleOrderStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCoarseSampleOrderTypeNV sampleOrderType;
        public uint customSampleOrderCount;
        public VkCoarseSampleOrderCustomNV* pCustomSampleOrders;
        public static VkPipelineViewportCoarseSampleOrderStateCreateInfoNV New()
        {
            VkPipelineViewportCoarseSampleOrderStateCreateInfoNV ret = new VkPipelineViewportCoarseSampleOrderStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineViewportCoarseSampleOrderStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMeshShaderFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 taskShader;
        public VkBool32 meshShader;
        public static VkPhysicalDeviceMeshShaderFeaturesNV New()
        {
            VkPhysicalDeviceMeshShaderFeaturesNV ret = new VkPhysicalDeviceMeshShaderFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceMeshShaderFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxDrawMeshTasksCount;
        public uint maxTaskWorkGroupInvocations;
        public uint maxTaskWorkGroupSize_0;
        public uint maxTaskWorkGroupSize_1;
        public uint maxTaskWorkGroupSize_2;
        public uint maxTaskTotalMemorySize;
        public uint maxTaskOutputCount;
        public uint maxMeshWorkGroupInvocations;
        public uint maxMeshWorkGroupSize_0;
        public uint maxMeshWorkGroupSize_1;
        public uint maxMeshWorkGroupSize_2;
        public uint maxMeshTotalMemorySize;
        public uint maxMeshOutputVertices;
        public uint maxMeshOutputPrimitives;
        public uint maxMeshMultiviewViewCount;
        public uint meshOutputPerVertexGranularity;
        public uint meshOutputPerPrimitiveGranularity;
        public static VkPhysicalDeviceMeshShaderPropertiesNV New()
        {
            VkPhysicalDeviceMeshShaderPropertiesNV ret = new VkPhysicalDeviceMeshShaderPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceMeshShaderPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkDrawMeshTasksIndirectCommandNV
    {
        public uint taskCount;
        public uint firstTask;
    }

    public unsafe partial struct VkPhysicalDeviceMeshShaderFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 taskShader;
        public VkBool32 meshShader;
        public VkBool32 multiviewMeshShader;
        public VkBool32 primitiveFragmentShadingRateMeshShader;
        public VkBool32 meshShaderQueries;
        public static VkPhysicalDeviceMeshShaderFeaturesEXT New()
        {
            VkPhysicalDeviceMeshShaderFeaturesEXT ret = new VkPhysicalDeviceMeshShaderFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceMeshShaderFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMeshShaderPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxTaskWorkGroupTotalCount;
        public uint maxTaskWorkGroupCount_0;
        public uint maxTaskWorkGroupCount_1;
        public uint maxTaskWorkGroupCount_2;
        public uint maxTaskWorkGroupInvocations;
        public uint maxTaskWorkGroupSize_0;
        public uint maxTaskWorkGroupSize_1;
        public uint maxTaskWorkGroupSize_2;
        public uint maxTaskPayloadSize;
        public uint maxTaskSharedMemorySize;
        public uint maxTaskPayloadAndSharedMemorySize;
        public uint maxMeshWorkGroupTotalCount;
        public uint maxMeshWorkGroupCount_0;
        public uint maxMeshWorkGroupCount_1;
        public uint maxMeshWorkGroupCount_2;
        public uint maxMeshWorkGroupInvocations;
        public uint maxMeshWorkGroupSize_0;
        public uint maxMeshWorkGroupSize_1;
        public uint maxMeshWorkGroupSize_2;
        public uint maxMeshSharedMemorySize;
        public uint maxMeshPayloadAndSharedMemorySize;
        public uint maxMeshOutputMemorySize;
        public uint maxMeshPayloadAndOutputMemorySize;
        public uint maxMeshOutputComponents;
        public uint maxMeshOutputVertices;
        public uint maxMeshOutputPrimitives;
        public uint maxMeshOutputLayers;
        public uint maxMeshMultiviewViewCount;
        public uint meshOutputPerVertexGranularity;
        public uint meshOutputPerPrimitiveGranularity;
        public uint maxPreferredTaskWorkGroupInvocations;
        public uint maxPreferredMeshWorkGroupInvocations;
        public VkBool32 prefersLocalInvocationVertexOutput;
        public VkBool32 prefersLocalInvocationPrimitiveOutput;
        public VkBool32 prefersCompactVertexOutput;
        public VkBool32 prefersCompactPrimitiveOutput;
        public static VkPhysicalDeviceMeshShaderPropertiesEXT New()
        {
            VkPhysicalDeviceMeshShaderPropertiesEXT ret = new VkPhysicalDeviceMeshShaderPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceMeshShaderPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDrawMeshTasksIndirectCommandEXT
    {
        public uint groupCountX;
        public uint groupCountY;
        public uint groupCountZ;
    }

    public unsafe partial struct VkRayTracingShaderGroupCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRayTracingShaderGroupTypeKHR type;
        public uint generalShader;
        public uint closestHitShader;
        public uint anyHitShader;
        public uint intersectionShader;
        public static VkRayTracingShaderGroupCreateInfoNV New()
        {
            VkRayTracingShaderGroupCreateInfoNV ret = new VkRayTracingShaderGroupCreateInfoNV();
            ret.sType = VkStructureType.RayTracingShaderGroupCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkRayTracingShaderGroupCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRayTracingShaderGroupTypeKHR type;
        public uint generalShader;
        public uint closestHitShader;
        public uint anyHitShader;
        public uint intersectionShader;
        public void* pShaderGroupCaptureReplayHandle;
        public static VkRayTracingShaderGroupCreateInfoKHR New()
        {
            VkRayTracingShaderGroupCreateInfoKHR ret = new VkRayTracingShaderGroupCreateInfoKHR();
            ret.sType = VkStructureType.RayTracingShaderGroupCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkRayTracingPipelineCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlags flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public uint groupCount;
        public VkRayTracingShaderGroupCreateInfoNV* pGroups;
        public uint maxRecursionDepth;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public static VkRayTracingPipelineCreateInfoNV New()
        {
            VkRayTracingPipelineCreateInfoNV ret = new VkRayTracingPipelineCreateInfoNV();
            ret.sType = VkStructureType.RayTracingPipelineCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkRayTracingPipelineCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlags flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public uint groupCount;
        public VkRayTracingShaderGroupCreateInfoKHR* pGroups;
        public uint maxPipelineRayRecursionDepth;
        public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
        public VkRayTracingPipelineInterfaceCreateInfoKHR* pLibraryInterface;
        public VkPipelineDynamicStateCreateInfo* pDynamicState;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public static VkRayTracingPipelineCreateInfoKHR New()
        {
            VkRayTracingPipelineCreateInfoKHR ret = new VkRayTracingPipelineCreateInfoKHR();
            ret.sType = VkStructureType.RayTracingPipelineCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkGeometryTrianglesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer vertexData;
        public ulong vertexOffset;
        public uint vertexCount;
        public ulong vertexStride;
        public VkFormat vertexFormat;
        public VkBuffer indexData;
        public ulong indexOffset;
        public uint indexCount;
        public VkIndexType indexType;
        public VkBuffer transformData;
        public ulong transformOffset;
        public static VkGeometryTrianglesNV New()
        {
            VkGeometryTrianglesNV ret = new VkGeometryTrianglesNV();
            ret.sType = VkStructureType.GeometryTrianglesNV;
            return ret;
        }
    }

    public unsafe partial struct VkGeometryAABBNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer aabbData;
        public uint numAABBs;
        public uint stride;
        public ulong offset;
        public static VkGeometryAABBNV New()
        {
            VkGeometryAABBNV ret = new VkGeometryAABBNV();
            ret.sType = VkStructureType.GeometryAabbNV;
            return ret;
        }
    }

    public unsafe partial struct VkGeometryDataNV
    {
        public VkGeometryTrianglesNV triangles;
        public VkGeometryAABBNV aabbs;
    }

    public unsafe partial struct VkGeometryNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkGeometryTypeKHR geometryType;
        public VkGeometryDataNV geometry;
        public VkGeometryFlagsKHR flags;
        public static VkGeometryNV New()
        {
            VkGeometryNV ret = new VkGeometryNV();
            ret.sType = VkStructureType.GeometryNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureTypeNV type;
        public uint flags;
        public uint instanceCount;
        public uint geometryCount;
        public VkGeometryNV* pGeometries;
        public static VkAccelerationStructureInfoNV New()
        {
            VkAccelerationStructureInfoNV ret = new VkAccelerationStructureInfoNV();
            ret.sType = VkStructureType.AccelerationStructureInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong compactedSize;
        public VkAccelerationStructureInfoNV info;
        public static VkAccelerationStructureCreateInfoNV New()
        {
            VkAccelerationStructureCreateInfoNV ret = new VkAccelerationStructureCreateInfoNV();
            ret.sType = VkStructureType.AccelerationStructureCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkBindAccelerationStructureMemoryInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureNV accelerationStructure;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public uint deviceIndexCount;
        public uint* pDeviceIndices;
        public static VkBindAccelerationStructureMemoryInfoNV New()
        {
            VkBindAccelerationStructureMemoryInfoNV ret = new VkBindAccelerationStructureMemoryInfoNV();
            ret.sType = VkStructureType.BindAccelerationStructureMemoryInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkWriteDescriptorSetAccelerationStructureKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint accelerationStructureCount;
        public VkAccelerationStructureKHR* pAccelerationStructures;
        public static VkWriteDescriptorSetAccelerationStructureKHR New()
        {
            VkWriteDescriptorSetAccelerationStructureKHR ret = new VkWriteDescriptorSetAccelerationStructureKHR();
            ret.sType = VkStructureType.WriteDescriptorSetAccelerationStructureKHR;
            return ret;
        }
    }

    public unsafe partial struct VkWriteDescriptorSetAccelerationStructureNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint accelerationStructureCount;
        public VkAccelerationStructureNV* pAccelerationStructures;
        public static VkWriteDescriptorSetAccelerationStructureNV New()
        {
            VkWriteDescriptorSetAccelerationStructureNV ret = new VkWriteDescriptorSetAccelerationStructureNV();
            ret.sType = VkStructureType.WriteDescriptorSetAccelerationStructureNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureMemoryRequirementsInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureMemoryRequirementsTypeNV type;
        public VkAccelerationStructureNV accelerationStructure;
        public static VkAccelerationStructureMemoryRequirementsInfoNV New()
        {
            VkAccelerationStructureMemoryRequirementsInfoNV ret = new VkAccelerationStructureMemoryRequirementsInfoNV();
            ret.sType = VkStructureType.AccelerationStructureMemoryRequirementsInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 accelerationStructure;
        public VkBool32 accelerationStructureCaptureReplay;
        public VkBool32 accelerationStructureIndirectBuild;
        public VkBool32 accelerationStructureHostCommands;
        public VkBool32 descriptorBindingAccelerationStructureUpdateAfterBind;
        public static VkPhysicalDeviceAccelerationStructureFeaturesKHR New()
        {
            VkPhysicalDeviceAccelerationStructureFeaturesKHR ret = new VkPhysicalDeviceAccelerationStructureFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceAccelerationStructureFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingPipelineFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rayTracingPipeline;
        public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplay;
        public VkBool32 rayTracingPipelineShaderGroupHandleCaptureReplayMixed;
        public VkBool32 rayTracingPipelineTraceRaysIndirect;
        public VkBool32 rayTraversalPrimitiveCulling;
        public static VkPhysicalDeviceRayTracingPipelineFeaturesKHR New()
        {
            VkPhysicalDeviceRayTracingPipelineFeaturesKHR ret = new VkPhysicalDeviceRayTracingPipelineFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingPipelineFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayQueryFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rayQuery;
        public static VkPhysicalDeviceRayQueryFeaturesKHR New()
        {
            VkPhysicalDeviceRayQueryFeaturesKHR ret = new VkPhysicalDeviceRayQueryFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceRayQueryFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceAccelerationStructurePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong maxGeometryCount;
        public ulong maxInstanceCount;
        public ulong maxPrimitiveCount;
        public uint maxPerStageDescriptorAccelerationStructures;
        public uint maxPerStageDescriptorUpdateAfterBindAccelerationStructures;
        public uint maxDescriptorSetAccelerationStructures;
        public uint maxDescriptorSetUpdateAfterBindAccelerationStructures;
        public uint minAccelerationStructureScratchOffsetAlignment;
        public static VkPhysicalDeviceAccelerationStructurePropertiesKHR New()
        {
            VkPhysicalDeviceAccelerationStructurePropertiesKHR ret = new VkPhysicalDeviceAccelerationStructurePropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceAccelerationStructurePropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingPipelinePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderGroupHandleSize;
        public uint maxRayRecursionDepth;
        public uint maxShaderGroupStride;
        public uint shaderGroupBaseAlignment;
        public uint shaderGroupHandleCaptureReplaySize;
        public uint maxRayDispatchInvocationCount;
        public uint shaderGroupHandleAlignment;
        public uint maxRayHitAttributeSize;
        public static VkPhysicalDeviceRayTracingPipelinePropertiesKHR New()
        {
            VkPhysicalDeviceRayTracingPipelinePropertiesKHR ret = new VkPhysicalDeviceRayTracingPipelinePropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingPipelinePropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderGroupHandleSize;
        public uint maxRecursionDepth;
        public uint maxShaderGroupStride;
        public uint shaderGroupBaseAlignment;
        public ulong maxGeometryCount;
        public ulong maxInstanceCount;
        public ulong maxTriangleCount;
        public uint maxDescriptorSetAccelerationStructures;
        public static VkPhysicalDeviceRayTracingPropertiesNV New()
        {
            VkPhysicalDeviceRayTracingPropertiesNV ret = new VkPhysicalDeviceRayTracingPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkStridedDeviceAddressRegionKHR
    {
        public ulong deviceAddress;
        public ulong stride;
        public ulong size;
    }

    public unsafe partial struct VkTraceRaysIndirectCommandKHR
    {
        public uint width;
        public uint height;
        public uint depth;
    }

    public unsafe partial struct VkTraceRaysIndirectCommand2KHR
    {
        public ulong raygenShaderRecordAddress;
        public ulong raygenShaderRecordSize;
        public ulong missShaderBindingTableAddress;
        public ulong missShaderBindingTableSize;
        public ulong missShaderBindingTableStride;
        public ulong hitShaderBindingTableAddress;
        public ulong hitShaderBindingTableSize;
        public ulong hitShaderBindingTableStride;
        public ulong callableShaderBindingTableAddress;
        public ulong callableShaderBindingTableSize;
        public ulong callableShaderBindingTableStride;
        public uint width;
        public uint height;
        public uint depth;
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rayTracingMaintenance1;
        public VkBool32 rayTracingPipelineTraceRaysIndirect2;
        public static VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR New()
        {
            VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR ret = new VkPhysicalDeviceRayTracingMaintenance1FeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingMaintenance1FeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDrmFormatModifierPropertiesListEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public VkDrmFormatModifierPropertiesEXT* pDrmFormatModifierProperties;
        public static VkDrmFormatModifierPropertiesListEXT New()
        {
            VkDrmFormatModifierPropertiesListEXT ret = new VkDrmFormatModifierPropertiesListEXT();
            ret.sType = VkStructureType.DrmFormatModifierPropertiesListEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDrmFormatModifierPropertiesEXT
    {
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkFormatFeatureFlags drmFormatModifierTilingFeatures;
    }

    public unsafe partial struct VkPhysicalDeviceImageDrmFormatModifierInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public static VkPhysicalDeviceImageDrmFormatModifierInfoEXT New()
        {
            VkPhysicalDeviceImageDrmFormatModifierInfoEXT ret = new VkPhysicalDeviceImageDrmFormatModifierInfoEXT();
            ret.sType = VkStructureType.PhysicalDeviceImageDrmFormatModifierInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageDrmFormatModifierListCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public ulong* pDrmFormatModifiers;
        public static VkImageDrmFormatModifierListCreateInfoEXT New()
        {
            VkImageDrmFormatModifierListCreateInfoEXT ret = new VkImageDrmFormatModifierListCreateInfoEXT();
            ret.sType = VkStructureType.ImageDrmFormatModifierListCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageDrmFormatModifierExplicitCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkSubresourceLayout* pPlaneLayouts;
        public static VkImageDrmFormatModifierExplicitCreateInfoEXT New()
        {
            VkImageDrmFormatModifierExplicitCreateInfoEXT ret = new VkImageDrmFormatModifierExplicitCreateInfoEXT();
            ret.sType = VkStructureType.ImageDrmFormatModifierExplicitCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageDrmFormatModifierPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public static VkImageDrmFormatModifierPropertiesEXT New()
        {
            VkImageDrmFormatModifierPropertiesEXT ret = new VkImageDrmFormatModifierPropertiesEXT();
            ret.sType = VkStructureType.ImageDrmFormatModifierPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageStencilUsageCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlags stencilUsage;
        public static VkImageStencilUsageCreateInfo New()
        {
            VkImageStencilUsageCreateInfo ret = new VkImageStencilUsageCreateInfo();
            ret.sType = VkStructureType.ImageStencilUsageCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkImageStencilUsageCreateInfoEXT
    {
    }

    public unsafe partial struct VkDeviceMemoryOverallocationCreateInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryOverallocationBehaviorAMD overallocationBehavior;
        public static VkDeviceMemoryOverallocationCreateInfoAMD New()
        {
            VkDeviceMemoryOverallocationCreateInfoAMD ret = new VkDeviceMemoryOverallocationCreateInfoAMD();
            ret.sType = VkStructureType.DeviceMemoryOverallocationCreateInfoAMD;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentDensityMap;
        public VkBool32 fragmentDensityMapDynamic;
        public VkBool32 fragmentDensityMapNonSubsampledImages;
        public static VkPhysicalDeviceFragmentDensityMapFeaturesEXT New()
        {
            VkPhysicalDeviceFragmentDensityMapFeaturesEXT ret = new VkPhysicalDeviceFragmentDensityMapFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFragmentDensityMapFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMap2FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentDensityMapDeferred;
        public static VkPhysicalDeviceFragmentDensityMap2FeaturesEXT New()
        {
            VkPhysicalDeviceFragmentDensityMap2FeaturesEXT ret = new VkPhysicalDeviceFragmentDensityMap2FeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFragmentDensityMap2FeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapOffsetFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentDensityMapOffset;
        public static VkPhysicalDeviceFragmentDensityMapOffsetFeaturesEXT New()
        {
            VkPhysicalDeviceFragmentDensityMapOffsetFeaturesEXT ret = new VkPhysicalDeviceFragmentDensityMapOffsetFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFragmentDensityMapOffsetFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapOffsetFeaturesQCOM
    {
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D minFragmentDensityTexelSize;
        public VkExtent2D maxFragmentDensityTexelSize;
        public VkBool32 fragmentDensityInvocations;
        public static VkPhysicalDeviceFragmentDensityMapPropertiesEXT New()
        {
            VkPhysicalDeviceFragmentDensityMapPropertiesEXT ret = new VkPhysicalDeviceFragmentDensityMapPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFragmentDensityMapPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMap2PropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 subsampledLoads;
        public VkBool32 subsampledCoarseReconstructionEarlyAccess;
        public uint maxSubsampledArrayLayers;
        public uint maxDescriptorSetSubsampledSamplers;
        public static VkPhysicalDeviceFragmentDensityMap2PropertiesEXT New()
        {
            VkPhysicalDeviceFragmentDensityMap2PropertiesEXT ret = new VkPhysicalDeviceFragmentDensityMap2PropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFragmentDensityMap2PropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D fragmentDensityOffsetGranularity;
        public static VkPhysicalDeviceFragmentDensityMapOffsetPropertiesEXT New()
        {
            VkPhysicalDeviceFragmentDensityMapOffsetPropertiesEXT ret = new VkPhysicalDeviceFragmentDensityMapOffsetPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFragmentDensityMapOffsetPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapOffsetPropertiesQCOM
    {
    }

    public unsafe partial struct VkRenderPassFragmentDensityMapCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAttachmentReference fragmentDensityMapAttachment;
        public static VkRenderPassFragmentDensityMapCreateInfoEXT New()
        {
            VkRenderPassFragmentDensityMapCreateInfoEXT ret = new VkRenderPassFragmentDensityMapCreateInfoEXT();
            ret.sType = VkStructureType.RenderPassFragmentDensityMapCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassFragmentDensityMapOffsetEndInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint fragmentDensityOffsetCount;
        public VkOffset2D* pFragmentDensityOffsets;
        public static VkRenderPassFragmentDensityMapOffsetEndInfoEXT New()
        {
            VkRenderPassFragmentDensityMapOffsetEndInfoEXT ret = new VkRenderPassFragmentDensityMapOffsetEndInfoEXT();
            ret.sType = VkStructureType.RenderPassFragmentDensityMapOffsetEndInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSubpassFragmentDensityMapOffsetEndInfoQCOM
    {
    }

    public unsafe partial struct VkPhysicalDeviceScalarBlockLayoutFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 scalarBlockLayout;
        public static VkPhysicalDeviceScalarBlockLayoutFeatures New()
        {
            VkPhysicalDeviceScalarBlockLayoutFeatures ret = new VkPhysicalDeviceScalarBlockLayoutFeatures();
            ret.sType = VkStructureType.PhysicalDeviceScalarBlockLayoutFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceScalarBlockLayoutFeaturesEXT
    {
    }

    public unsafe partial struct VkSurfaceProtectedCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 supportsProtected;
        public static VkSurfaceProtectedCapabilitiesKHR New()
        {
            VkSurfaceProtectedCapabilitiesKHR ret = new VkSurfaceProtectedCapabilitiesKHR();
            ret.sType = VkStructureType.SurfaceProtectedCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceUniformBufferStandardLayoutFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 uniformBufferStandardLayout;
        public static VkPhysicalDeviceUniformBufferStandardLayoutFeatures New()
        {
            VkPhysicalDeviceUniformBufferStandardLayoutFeatures ret = new VkPhysicalDeviceUniformBufferStandardLayoutFeatures();
            ret.sType = VkStructureType.PhysicalDeviceUniformBufferStandardLayoutFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceUniformBufferStandardLayoutFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceDepthClipEnableFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 depthClipEnable;
        public static VkPhysicalDeviceDepthClipEnableFeaturesEXT New()
        {
            VkPhysicalDeviceDepthClipEnableFeaturesEXT ret = new VkPhysicalDeviceDepthClipEnableFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDepthClipEnableFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationDepthClipStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkBool32 depthClipEnable;
        public static VkPipelineRasterizationDepthClipStateCreateInfoEXT New()
        {
            VkPipelineRasterizationDepthClipStateCreateInfoEXT ret = new VkPipelineRasterizationDepthClipStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineRasterizationDepthClipStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMemoryBudgetPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed ulong heapBudget[(int)VulkanNative.MaxMemoryHeaps];
        public fixed ulong heapUsage[(int)VulkanNative.MaxMemoryHeaps];
        public static VkPhysicalDeviceMemoryBudgetPropertiesEXT New()
        {
            VkPhysicalDeviceMemoryBudgetPropertiesEXT ret = new VkPhysicalDeviceMemoryBudgetPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceMemoryBudgetPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMemoryPriorityFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 memoryPriority;
        public static VkPhysicalDeviceMemoryPriorityFeaturesEXT New()
        {
            VkPhysicalDeviceMemoryPriorityFeaturesEXT ret = new VkPhysicalDeviceMemoryPriorityFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceMemoryPriorityFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryPriorityAllocateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public float priority;
        public static VkMemoryPriorityAllocateInfoEXT New()
        {
            VkMemoryPriorityAllocateInfoEXT ret = new VkMemoryPriorityAllocateInfoEXT();
            ret.sType = VkStructureType.MemoryPriorityAllocateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pageableDeviceLocalMemory;
        public static VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT New()
        {
            VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT ret = new VkPhysicalDevicePageableDeviceLocalMemoryFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDevicePageableDeviceLocalMemoryFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 bufferDeviceAddress;
        public VkBool32 bufferDeviceAddressCaptureReplay;
        public VkBool32 bufferDeviceAddressMultiDevice;
        public static VkPhysicalDeviceBufferDeviceAddressFeatures New()
        {
            VkPhysicalDeviceBufferDeviceAddressFeatures ret = new VkPhysicalDeviceBufferDeviceAddressFeatures();
            ret.sType = VkStructureType.PhysicalDeviceBufferDeviceAddressFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceBufferDeviceAddressFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 bufferDeviceAddress;
        public VkBool32 bufferDeviceAddressCaptureReplay;
        public VkBool32 bufferDeviceAddressMultiDevice;
        public static VkPhysicalDeviceBufferDeviceAddressFeaturesEXT New()
        {
            VkPhysicalDeviceBufferDeviceAddressFeaturesEXT ret = new VkPhysicalDeviceBufferDeviceAddressFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceBufferDeviceAddressFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceBufferAddressFeaturesEXT
    {
    }

    public unsafe partial struct VkBufferDeviceAddressInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public static VkBufferDeviceAddressInfo New()
        {
            VkBufferDeviceAddressInfo ret = new VkBufferDeviceAddressInfo();
            ret.sType = VkStructureType.BufferDeviceAddressInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBufferDeviceAddressInfoKHR
    {
    }

    public unsafe partial struct VkBufferDeviceAddressInfoEXT
    {
    }

    public unsafe partial struct VkBufferOpaqueCaptureAddressCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong opaqueCaptureAddress;
        public static VkBufferOpaqueCaptureAddressCreateInfo New()
        {
            VkBufferOpaqueCaptureAddressCreateInfo ret = new VkBufferOpaqueCaptureAddressCreateInfo();
            ret.sType = VkStructureType.BufferOpaqueCaptureAddressCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBufferOpaqueCaptureAddressCreateInfoKHR
    {
    }

    public unsafe partial struct VkBufferDeviceAddressCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong deviceAddress;
        public static VkBufferDeviceAddressCreateInfoEXT New()
        {
            VkBufferDeviceAddressCreateInfoEXT ret = new VkBufferDeviceAddressCreateInfoEXT();
            ret.sType = VkStructureType.BufferDeviceAddressCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageViewImageFormatInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageViewType imageViewType;
        public static VkPhysicalDeviceImageViewImageFormatInfoEXT New()
        {
            VkPhysicalDeviceImageViewImageFormatInfoEXT ret = new VkPhysicalDeviceImageViewImageFormatInfoEXT();
            ret.sType = VkStructureType.PhysicalDeviceImageViewImageFormatInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkFilterCubicImageViewImageFormatPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 filterCubic;
        public VkBool32 filterCubicMinmax;
        public static VkFilterCubicImageViewImageFormatPropertiesEXT New()
        {
            VkFilterCubicImageViewImageFormatPropertiesEXT ret = new VkFilterCubicImageViewImageFormatPropertiesEXT();
            ret.sType = VkStructureType.FilterCubicImageViewImageFormatPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImagelessFramebufferFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 imagelessFramebuffer;
        public static VkPhysicalDeviceImagelessFramebufferFeatures New()
        {
            VkPhysicalDeviceImagelessFramebufferFeatures ret = new VkPhysicalDeviceImagelessFramebufferFeatures();
            ret.sType = VkStructureType.PhysicalDeviceImagelessFramebufferFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImagelessFramebufferFeaturesKHR
    {
    }

    public unsafe partial struct VkFramebufferAttachmentsCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentImageInfoCount;
        public VkFramebufferAttachmentImageInfo* pAttachmentImageInfos;
        public static VkFramebufferAttachmentsCreateInfo New()
        {
            VkFramebufferAttachmentsCreateInfo ret = new VkFramebufferAttachmentsCreateInfo();
            ret.sType = VkStructureType.FramebufferAttachmentsCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkFramebufferAttachmentsCreateInfoKHR
    {
    }

    public unsafe partial struct VkFramebufferAttachmentImageInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateFlags flags;
        public VkImageUsageFlags usage;
        public uint width;
        public uint height;
        public uint layerCount;
        public uint viewFormatCount;
        public VkFormat* pViewFormats;
        public static VkFramebufferAttachmentImageInfo New()
        {
            VkFramebufferAttachmentImageInfo ret = new VkFramebufferAttachmentImageInfo();
            ret.sType = VkStructureType.FramebufferAttachmentImageInfo;
            return ret;
        }
    }

    public unsafe partial struct VkFramebufferAttachmentImageInfoKHR
    {
    }

    public unsafe partial struct VkRenderPassAttachmentBeginInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentCount;
        public VkImageView* pAttachments;
        public static VkRenderPassAttachmentBeginInfo New()
        {
            VkRenderPassAttachmentBeginInfo ret = new VkRenderPassAttachmentBeginInfo();
            ret.sType = VkStructureType.RenderPassAttachmentBeginInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassAttachmentBeginInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceTextureCompressionASTCHDRFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 textureCompressionASTC_HDR;
        public static VkPhysicalDeviceTextureCompressionASTCHDRFeatures New()
        {
            VkPhysicalDeviceTextureCompressionASTCHDRFeatures ret = new VkPhysicalDeviceTextureCompressionASTCHDRFeatures();
            ret.sType = VkStructureType.PhysicalDeviceTextureCompressionAstcHdrFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTextureCompressionASTCHDRFeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 cooperativeMatrix;
        public VkBool32 cooperativeMatrixRobustBufferAccess;
        public static VkPhysicalDeviceCooperativeMatrixFeaturesNV New()
        {
            VkPhysicalDeviceCooperativeMatrixFeaturesNV ret = new VkPhysicalDeviceCooperativeMatrixFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceCooperativeMatrixFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags cooperativeMatrixSupportedStages;
        public static VkPhysicalDeviceCooperativeMatrixPropertiesNV New()
        {
            VkPhysicalDeviceCooperativeMatrixPropertiesNV ret = new VkPhysicalDeviceCooperativeMatrixPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceCooperativeMatrixPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkCooperativeMatrixPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint MSize;
        public uint NSize;
        public uint KSize;
        public VkComponentTypeNV AType;
        public VkComponentTypeNV BType;
        public VkComponentTypeNV CType;
        public VkComponentTypeNV DType;
        public VkScopeNV scope;
        public static VkCooperativeMatrixPropertiesNV New()
        {
            VkCooperativeMatrixPropertiesNV ret = new VkCooperativeMatrixPropertiesNV();
            ret.sType = VkStructureType.CooperativeMatrixPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceYcbcrImageArraysFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 ycbcrImageArrays;
        public static VkPhysicalDeviceYcbcrImageArraysFeaturesEXT New()
        {
            VkPhysicalDeviceYcbcrImageArraysFeaturesEXT ret = new VkPhysicalDeviceYcbcrImageArraysFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceYcbcrImageArraysFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageViewHandleInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public VkDescriptorType descriptorType;
        public VkSampler sampler;
        public static VkImageViewHandleInfoNVX New()
        {
            VkImageViewHandleInfoNVX ret = new VkImageViewHandleInfoNVX();
            ret.sType = VkStructureType.ImageViewHandleInfoNVX;
            return ret;
        }
    }

    public unsafe partial struct VkImageViewAddressPropertiesNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong deviceAddress;
        public ulong size;
        public static VkImageViewAddressPropertiesNVX New()
        {
            VkImageViewAddressPropertiesNVX ret = new VkImageViewAddressPropertiesNVX();
            ret.sType = VkStructureType.ImageViewAddressPropertiesNVX;
            return ret;
        }
    }

    public unsafe partial struct VkPresentFrameTokenGGP
    {
        public VkStructureType sType;
        public void* pNext;
        public Ggp.FrameToken frameToken;
        public static VkPresentFrameTokenGGP New()
        {
            VkPresentFrameTokenGGP ret = new VkPresentFrameTokenGGP();
            ret.sType = VkStructureType.PresentFrameTokenGgp;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCreationFeedback
    {
        public VkPipelineCreationFeedbackFlags flags;
        public ulong duration;
    }

    public unsafe partial struct VkPipelineCreationFeedbackEXT
    {
    }

    public unsafe partial struct VkPipelineCreationFeedbackCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreationFeedback* pPipelineCreationFeedback;
        public uint pipelineStageCreationFeedbackCount;
        public VkPipelineCreationFeedback* pPipelineStageCreationFeedbacks;
        public static VkPipelineCreationFeedbackCreateInfo New()
        {
            VkPipelineCreationFeedbackCreateInfo ret = new VkPipelineCreationFeedbackCreateInfo();
            ret.sType = VkStructureType.PipelineCreationFeedbackCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCreationFeedbackCreateInfoEXT
    {
    }

    public unsafe partial struct VkSurfaceFullScreenExclusiveInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFullScreenExclusiveEXT fullScreenExclusive;
        public static VkSurfaceFullScreenExclusiveInfoEXT New()
        {
            VkSurfaceFullScreenExclusiveInfoEXT ret = new VkSurfaceFullScreenExclusiveInfoEXT();
            ret.sType = VkStructureType.SurfaceFullScreenExclusiveInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceFullScreenExclusiveWin32InfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public Win32.HMONITOR hmonitor;
        public static VkSurfaceFullScreenExclusiveWin32InfoEXT New()
        {
            VkSurfaceFullScreenExclusiveWin32InfoEXT ret = new VkSurfaceFullScreenExclusiveWin32InfoEXT();
            ret.sType = VkStructureType.SurfaceFullScreenExclusiveWin32InfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceCapabilitiesFullScreenExclusiveEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fullScreenExclusiveSupported;
        public static VkSurfaceCapabilitiesFullScreenExclusiveEXT New()
        {
            VkSurfaceCapabilitiesFullScreenExclusiveEXT ret = new VkSurfaceCapabilitiesFullScreenExclusiveEXT();
            ret.sType = VkStructureType.SurfaceCapabilitiesFullScreenExclusiveEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePresentBarrierFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 presentBarrier;
        public static VkPhysicalDevicePresentBarrierFeaturesNV New()
        {
            VkPhysicalDevicePresentBarrierFeaturesNV ret = new VkPhysicalDevicePresentBarrierFeaturesNV();
            ret.sType = VkStructureType.PhysicalDevicePresentBarrierFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceCapabilitiesPresentBarrierNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 presentBarrierSupported;
        public static VkSurfaceCapabilitiesPresentBarrierNV New()
        {
            VkSurfaceCapabilitiesPresentBarrierNV ret = new VkSurfaceCapabilitiesPresentBarrierNV();
            ret.sType = VkStructureType.SurfaceCapabilitiesPresentBarrierNV;
            return ret;
        }
    }

    public unsafe partial struct VkSwapchainPresentBarrierCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 presentBarrierEnable;
        public static VkSwapchainPresentBarrierCreateInfoNV New()
        {
            VkSwapchainPresentBarrierCreateInfoNV ret = new VkSwapchainPresentBarrierCreateInfoNV();
            ret.sType = VkStructureType.SwapchainPresentBarrierCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePerformanceQueryFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 performanceCounterQueryPools;
        public VkBool32 performanceCounterMultipleQueryPools;
        public static VkPhysicalDevicePerformanceQueryFeaturesKHR New()
        {
            VkPhysicalDevicePerformanceQueryFeaturesKHR ret = new VkPhysicalDevicePerformanceQueryFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDevicePerformanceQueryFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePerformanceQueryPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 allowCommandBufferQueryCopies;
        public static VkPhysicalDevicePerformanceQueryPropertiesKHR New()
        {
            VkPhysicalDevicePerformanceQueryPropertiesKHR ret = new VkPhysicalDevicePerformanceQueryPropertiesKHR();
            ret.sType = VkStructureType.PhysicalDevicePerformanceQueryPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceCounterKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceCounterUnitKHR unit;
        public VkPerformanceCounterScopeKHR scope;
        public VkPerformanceCounterStorageKHR storage;
        public fixed byte uuid[(int)VulkanNative.UuidSize];
        public static VkPerformanceCounterKHR New()
        {
            VkPerformanceCounterKHR ret = new VkPerformanceCounterKHR();
            ret.sType = VkStructureType.PerformanceCounterKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceCounterDescriptionKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceCounterDescriptionFlagsKHR flags;
        public fixed byte name[(int)VulkanNative.MaxDescriptionSize];
        public fixed byte category[(int)VulkanNative.MaxDescriptionSize];
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public static VkPerformanceCounterDescriptionKHR New()
        {
            VkPerformanceCounterDescriptionKHR ret = new VkPerformanceCounterDescriptionKHR();
            ret.sType = VkStructureType.PerformanceCounterDescriptionKHR;
            return ret;
        }
    }

    public unsafe partial struct VkQueryPoolPerformanceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint queueFamilyIndex;
        public uint counterIndexCount;
        public uint* pCounterIndices;
        public static VkQueryPoolPerformanceCreateInfoKHR New()
        {
            VkQueryPoolPerformanceCreateInfoKHR ret = new VkQueryPoolPerformanceCreateInfoKHR();
            ret.sType = VkStructureType.QueryPoolPerformanceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAcquireProfilingLockInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAcquireProfilingLockFlagsKHR flags;
        public ulong timeout;
        public static VkAcquireProfilingLockInfoKHR New()
        {
            VkAcquireProfilingLockInfoKHR ret = new VkAcquireProfilingLockInfoKHR();
            ret.sType = VkStructureType.AcquireProfilingLockInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceQuerySubmitInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint counterPassIndex;
        public static VkPerformanceQuerySubmitInfoKHR New()
        {
            VkPerformanceQuerySubmitInfoKHR ret = new VkPerformanceQuerySubmitInfoKHR();
            ret.sType = VkStructureType.PerformanceQuerySubmitInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceQueryReservationInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPerformanceQueriesPerPool;
        public static VkPerformanceQueryReservationInfoKHR New()
        {
            VkPerformanceQueryReservationInfoKHR ret = new VkPerformanceQueryReservationInfoKHR();
            ret.sType = VkStructureType.PerformanceQueryReservationInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkHeadlessSurfaceCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public static VkHeadlessSurfaceCreateInfoEXT New()
        {
            VkHeadlessSurfaceCreateInfoEXT ret = new VkHeadlessSurfaceCreateInfoEXT();
            ret.sType = VkStructureType.HeadlessSurfaceCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCoverageReductionModeFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 coverageReductionMode;
        public static VkPhysicalDeviceCoverageReductionModeFeaturesNV New()
        {
            VkPhysicalDeviceCoverageReductionModeFeaturesNV ret = new VkPhysicalDeviceCoverageReductionModeFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceCoverageReductionModeFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCoverageReductionStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkCoverageReductionModeNV coverageReductionMode;
        public static VkPipelineCoverageReductionStateCreateInfoNV New()
        {
            VkPipelineCoverageReductionStateCreateInfoNV ret = new VkPipelineCoverageReductionStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineCoverageReductionStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkFramebufferMixedSamplesCombinationNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCoverageReductionModeNV coverageReductionMode;
        public VkSampleCountFlags rasterizationSamples;
        public VkSampleCountFlags depthStencilSamples;
        public VkSampleCountFlags colorSamples;
        public static VkFramebufferMixedSamplesCombinationNV New()
        {
            VkFramebufferMixedSamplesCombinationNV ret = new VkFramebufferMixedSamplesCombinationNV();
            ret.sType = VkStructureType.FramebufferMixedSamplesCombinationNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderIntegerFunctions2;
        public static VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL New()
        {
            VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL ret = new VkPhysicalDeviceShaderIntegerFunctions2FeaturesINTEL();
            ret.sType = VkStructureType.PhysicalDeviceShaderIntegerFunctions2FeaturesIntel;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceValueINTEL
    {
        public VkPerformanceValueTypeINTEL type;
        public VkPerformanceValueDataINTEL data;
    }

    public unsafe partial struct VkInitializePerformanceApiInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pUserData;
        public static VkInitializePerformanceApiInfoINTEL New()
        {
            VkInitializePerformanceApiInfoINTEL ret = new VkInitializePerformanceApiInfoINTEL();
            ret.sType = VkStructureType.InitializePerformanceApiInfoIntel;
            return ret;
        }
    }

    public unsafe partial struct VkQueryPoolPerformanceQueryCreateInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueryPoolSamplingModeINTEL performanceCountersSampling;
        public static VkQueryPoolPerformanceQueryCreateInfoINTEL New()
        {
            VkQueryPoolPerformanceQueryCreateInfoINTEL ret = new VkQueryPoolPerformanceQueryCreateInfoINTEL();
            ret.sType = VkStructureType.QueryPoolPerformanceQueryCreateInfoIntel;
            return ret;
        }
    }

    public unsafe partial struct VkQueryPoolCreateInfoINTEL
    {
    }

    public unsafe partial struct VkPerformanceMarkerInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong marker;
        public static VkPerformanceMarkerInfoINTEL New()
        {
            VkPerformanceMarkerInfoINTEL ret = new VkPerformanceMarkerInfoINTEL();
            ret.sType = VkStructureType.PerformanceMarkerInfoIntel;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceStreamMarkerInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public uint marker;
        public static VkPerformanceStreamMarkerInfoINTEL New()
        {
            VkPerformanceStreamMarkerInfoINTEL ret = new VkPerformanceStreamMarkerInfoINTEL();
            ret.sType = VkStructureType.PerformanceStreamMarkerInfoIntel;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceOverrideInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceOverrideTypeINTEL type;
        public VkBool32 enable;
        public ulong parameter;
        public static VkPerformanceOverrideInfoINTEL New()
        {
            VkPerformanceOverrideInfoINTEL ret = new VkPerformanceOverrideInfoINTEL();
            ret.sType = VkStructureType.PerformanceOverrideInfoIntel;
            return ret;
        }
    }

    public unsafe partial struct VkPerformanceConfigurationAcquireInfoINTEL
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPerformanceConfigurationTypeINTEL type;
        public static VkPerformanceConfigurationAcquireInfoINTEL New()
        {
            VkPerformanceConfigurationAcquireInfoINTEL ret = new VkPerformanceConfigurationAcquireInfoINTEL();
            ret.sType = VkStructureType.PerformanceConfigurationAcquireInfoIntel;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderClockFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderSubgroupClock;
        public VkBool32 shaderDeviceClock;
        public static VkPhysicalDeviceShaderClockFeaturesKHR New()
        {
            VkPhysicalDeviceShaderClockFeaturesKHR ret = new VkPhysicalDeviceShaderClockFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceShaderClockFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceIndexTypeUint8Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 indexTypeUint8;
        public static VkPhysicalDeviceIndexTypeUint8Features New()
        {
            VkPhysicalDeviceIndexTypeUint8Features ret = new VkPhysicalDeviceIndexTypeUint8Features();
            ret.sType = VkStructureType.PhysicalDeviceIndexTypeUint8Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceIndexTypeUint8FeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceIndexTypeUint8FeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderSMBuiltinsPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderSMCount;
        public uint shaderWarpsPerSM;
        public static VkPhysicalDeviceShaderSMBuiltinsPropertiesNV New()
        {
            VkPhysicalDeviceShaderSMBuiltinsPropertiesNV ret = new VkPhysicalDeviceShaderSMBuiltinsPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceShaderSmBuiltinsPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderSMBuiltinsFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderSMBuiltins;
        public static VkPhysicalDeviceShaderSMBuiltinsFeaturesNV New()
        {
            VkPhysicalDeviceShaderSMBuiltinsFeaturesNV ret = new VkPhysicalDeviceShaderSMBuiltinsFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceShaderSmBuiltinsFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentShaderSampleInterlock;
        public VkBool32 fragmentShaderPixelInterlock;
        public VkBool32 fragmentShaderShadingRateInterlock;
        public static VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT New()
        {
            VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT ret = new VkPhysicalDeviceFragmentShaderInterlockFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShaderInterlockFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 separateDepthStencilLayouts;
        public static VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures New()
        {
            VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures ret = new VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures();
            ret.sType = VkStructureType.PhysicalDeviceSeparateDepthStencilLayoutsFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSeparateDepthStencilLayoutsFeaturesKHR
    {
    }

    public unsafe partial struct VkAttachmentReferenceStencilLayout
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageLayout stencilLayout;
        public static VkAttachmentReferenceStencilLayout New()
        {
            VkAttachmentReferenceStencilLayout ret = new VkAttachmentReferenceStencilLayout();
            ret.sType = VkStructureType.AttachmentReferenceStencilLayout;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 primitiveTopologyListRestart;
        public VkBool32 primitiveTopologyPatchListRestart;
        public static VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT New()
        {
            VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT ret = new VkPhysicalDevicePrimitiveTopologyListRestartFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDevicePrimitiveTopologyListRestartFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkAttachmentReferenceStencilLayoutKHR
    {
    }

    public unsafe partial struct VkAttachmentDescriptionStencilLayout
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageLayout stencilInitialLayout;
        public VkImageLayout stencilFinalLayout;
        public static VkAttachmentDescriptionStencilLayout New()
        {
            VkAttachmentDescriptionStencilLayout ret = new VkAttachmentDescriptionStencilLayout();
            ret.sType = VkStructureType.AttachmentDescriptionStencilLayout;
            return ret;
        }
    }

    public unsafe partial struct VkAttachmentDescriptionStencilLayoutKHR
    {
    }

    public unsafe partial struct VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineExecutableInfo;
        public static VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR New()
        {
            VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR ret = new VkPhysicalDevicePipelineExecutablePropertiesFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDevicePipelineExecutablePropertiesFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipeline pipeline;
        public static VkPipelineInfoKHR New()
        {
            VkPipelineInfoKHR ret = new VkPipelineInfoKHR();
            ret.sType = VkStructureType.PipelineInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineInfoEXT
    {
    }

    public unsafe partial struct VkPipelineExecutablePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags stages;
        public fixed byte name[(int)VulkanNative.MaxDescriptionSize];
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public uint subgroupSize;
        public static VkPipelineExecutablePropertiesKHR New()
        {
            VkPipelineExecutablePropertiesKHR ret = new VkPipelineExecutablePropertiesKHR();
            ret.sType = VkStructureType.PipelineExecutablePropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineExecutableInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipeline pipeline;
        public uint executableIndex;
        public static VkPipelineExecutableInfoKHR New()
        {
            VkPipelineExecutableInfoKHR ret = new VkPipelineExecutableInfoKHR();
            ret.sType = VkStructureType.PipelineExecutableInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineExecutableStatisticKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte name[(int)VulkanNative.MaxDescriptionSize];
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public VkPipelineExecutableStatisticFormatKHR format;
        public VkPipelineExecutableStatisticValueKHR value;
        public static VkPipelineExecutableStatisticKHR New()
        {
            VkPipelineExecutableStatisticKHR ret = new VkPipelineExecutableStatisticKHR();
            ret.sType = VkStructureType.PipelineExecutableStatisticKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineExecutableInternalRepresentationKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte name[(int)VulkanNative.MaxDescriptionSize];
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public VkBool32 isText;
        public UIntPtr dataSize;
        public void* pData;
        public static VkPipelineExecutableInternalRepresentationKHR New()
        {
            VkPipelineExecutableInternalRepresentationKHR ret = new VkPipelineExecutableInternalRepresentationKHR();
            ret.sType = VkStructureType.PipelineExecutableInternalRepresentationKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderDemoteToHelperInvocation;
        public static VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures New()
        {
            VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures ret = new VkPhysicalDeviceShaderDemoteToHelperInvocationFeatures();
            ret.sType = VkStructureType.PhysicalDeviceShaderDemoteToHelperInvocationFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderDemoteToHelperInvocationFeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 texelBufferAlignment;
        public static VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT New()
        {
            VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT ret = new VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceTexelBufferAlignmentFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong storageTexelBufferOffsetAlignmentBytes;
        public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
        public ulong uniformTexelBufferOffsetAlignmentBytes;
        public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
        public static VkPhysicalDeviceTexelBufferAlignmentProperties New()
        {
            VkPhysicalDeviceTexelBufferAlignmentProperties ret = new VkPhysicalDeviceTexelBufferAlignmentProperties();
            ret.sType = VkStructureType.PhysicalDeviceTexelBufferAlignmentProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentPropertiesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 subgroupSizeControl;
        public VkBool32 computeFullSubgroups;
        public static VkPhysicalDeviceSubgroupSizeControlFeatures New()
        {
            VkPhysicalDeviceSubgroupSizeControlFeatures ret = new VkPhysicalDeviceSubgroupSizeControlFeatures();
            ret.sType = VkStructureType.PhysicalDeviceSubgroupSizeControlFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minSubgroupSize;
        public uint maxSubgroupSize;
        public uint maxComputeWorkgroupSubgroups;
        public VkShaderStageFlags requiredSubgroupSizeStages;
        public static VkPhysicalDeviceSubgroupSizeControlProperties New()
        {
            VkPhysicalDeviceSubgroupSizeControlProperties ret = new VkPhysicalDeviceSubgroupSizeControlProperties();
            ret.sType = VkStructureType.PhysicalDeviceSubgroupSizeControlProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSubgroupSizeControlPropertiesEXT
    {
    }

    public unsafe partial struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint requiredSubgroupSize;
        public static VkPipelineShaderStageRequiredSubgroupSizeCreateInfo New()
        {
            VkPipelineShaderStageRequiredSubgroupSizeCreateInfo ret = new VkPipelineShaderStageRequiredSubgroupSizeCreateInfo();
            ret.sType = VkStructureType.PipelineShaderStageRequiredSubgroupSizeCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineShaderStageRequiredSubgroupSizeCreateInfoEXT
    {
    }

    public unsafe partial struct VkShaderRequiredSubgroupSizeCreateInfoEXT
    {
    }

    public unsafe partial struct VkSubpassShadingPipelineCreateInfoHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPass renderPass;
        public uint subpass;
        public static VkSubpassShadingPipelineCreateInfoHUAWEI New()
        {
            VkSubpassShadingPipelineCreateInfoHUAWEI ret = new VkSubpassShadingPipelineCreateInfoHUAWEI();
            ret.sType = VkStructureType.SubpassShadingPipelineCreateInfoHuawei;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSubpassShadingPropertiesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxSubpassShadingWorkgroupSizeAspectRatio;
        public static VkPhysicalDeviceSubpassShadingPropertiesHUAWEI New()
        {
            VkPhysicalDeviceSubpassShadingPropertiesHUAWEI ret = new VkPhysicalDeviceSubpassShadingPropertiesHUAWEI();
            ret.sType = VkStructureType.PhysicalDeviceSubpassShadingPropertiesHuawei;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxWorkGroupCount_0;
        public uint maxWorkGroupCount_1;
        public uint maxWorkGroupCount_2;
        public uint maxWorkGroupSize_0;
        public uint maxWorkGroupSize_1;
        public uint maxWorkGroupSize_2;
        public uint maxOutputClusterCount;
        public ulong indirectBufferOffsetAlignment;
        public static VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI New()
        {
            VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI ret = new VkPhysicalDeviceClusterCullingShaderPropertiesHUAWEI();
            ret.sType = VkStructureType.PhysicalDeviceClusterCullingShaderPropertiesHuawei;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryOpaqueCaptureAddressAllocateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong opaqueCaptureAddress;
        public static VkMemoryOpaqueCaptureAddressAllocateInfo New()
        {
            VkMemoryOpaqueCaptureAddressAllocateInfo ret = new VkMemoryOpaqueCaptureAddressAllocateInfo();
            ret.sType = VkStructureType.MemoryOpaqueCaptureAddressAllocateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryOpaqueCaptureAddressAllocateInfoKHR
    {
    }

    public unsafe partial struct VkDeviceMemoryOpaqueCaptureAddressInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public static VkDeviceMemoryOpaqueCaptureAddressInfo New()
        {
            VkDeviceMemoryOpaqueCaptureAddressInfo ret = new VkDeviceMemoryOpaqueCaptureAddressInfo();
            ret.sType = VkStructureType.DeviceMemoryOpaqueCaptureAddressInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceMemoryOpaqueCaptureAddressInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceLineRasterizationFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rectangularLines;
        public VkBool32 bresenhamLines;
        public VkBool32 smoothLines;
        public VkBool32 stippledRectangularLines;
        public VkBool32 stippledBresenhamLines;
        public VkBool32 stippledSmoothLines;
        public static VkPhysicalDeviceLineRasterizationFeatures New()
        {
            VkPhysicalDeviceLineRasterizationFeatures ret = new VkPhysicalDeviceLineRasterizationFeatures();
            ret.sType = VkStructureType.PhysicalDeviceLineRasterizationFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceLineRasterizationFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceLineRasterizationFeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceLineRasterizationProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint lineSubPixelPrecisionBits;
        public static VkPhysicalDeviceLineRasterizationProperties New()
        {
            VkPhysicalDeviceLineRasterizationProperties ret = new VkPhysicalDeviceLineRasterizationProperties();
            ret.sType = VkStructureType.PhysicalDeviceLineRasterizationProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceLineRasterizationPropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceLineRasterizationPropertiesEXT
    {
    }

    public unsafe partial struct VkPipelineRasterizationLineStateCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkLineRasterizationMode lineRasterizationMode;
        public VkBool32 stippledLineEnable;
        public uint lineStippleFactor;
        public ushort lineStipplePattern;
        public static VkPipelineRasterizationLineStateCreateInfo New()
        {
            VkPipelineRasterizationLineStateCreateInfo ret = new VkPipelineRasterizationLineStateCreateInfo();
            ret.sType = VkStructureType.PipelineRasterizationLineStateCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationLineStateCreateInfoKHR
    {
    }

    public unsafe partial struct VkPipelineRasterizationLineStateCreateInfoEXT
    {
    }

    public unsafe partial struct VkPhysicalDevicePipelineCreationCacheControlFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineCreationCacheControl;
        public static VkPhysicalDevicePipelineCreationCacheControlFeatures New()
        {
            VkPhysicalDevicePipelineCreationCacheControlFeatures ret = new VkPhysicalDevicePipelineCreationCacheControlFeatures();
            ret.sType = VkStructureType.PhysicalDevicePipelineCreationCacheControlFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePipelineCreationCacheControlFeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceVulkan11Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 storageBuffer16BitAccess;
        public VkBool32 uniformAndStorageBuffer16BitAccess;
        public VkBool32 storagePushConstant16;
        public VkBool32 storageInputOutput16;
        public VkBool32 multiview;
        public VkBool32 multiviewGeometryShader;
        public VkBool32 multiviewTessellationShader;
        public VkBool32 variablePointersStorageBuffer;
        public VkBool32 variablePointers;
        public VkBool32 protectedMemory;
        public VkBool32 samplerYcbcrConversion;
        public VkBool32 shaderDrawParameters;
        public static VkPhysicalDeviceVulkan11Features New()
        {
            VkPhysicalDeviceVulkan11Features ret = new VkPhysicalDeviceVulkan11Features();
            ret.sType = VkStructureType.PhysicalDeviceVulkan11Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkan11Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte deviceUUID[(int)VulkanNative.UuidSize];
        public fixed byte driverUUID[(int)VulkanNative.UuidSize];
        public fixed byte deviceLUID[(int)VulkanNative.LuidSize];
        public uint deviceNodeMask;
        public VkBool32 deviceLUIDValid;
        public uint subgroupSize;
        public VkShaderStageFlags subgroupSupportedStages;
        public VkSubgroupFeatureFlags subgroupSupportedOperations;
        public VkBool32 subgroupQuadOperationsInAllStages;
        public VkPointClippingBehavior pointClippingBehavior;
        public uint maxMultiviewViewCount;
        public uint maxMultiviewInstanceIndex;
        public VkBool32 protectedNoFault;
        public uint maxPerSetDescriptors;
        public ulong maxMemoryAllocationSize;
        public static VkPhysicalDeviceVulkan11Properties New()
        {
            VkPhysicalDeviceVulkan11Properties ret = new VkPhysicalDeviceVulkan11Properties();
            ret.sType = VkStructureType.PhysicalDeviceVulkan11Properties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkan12Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 samplerMirrorClampToEdge;
        public VkBool32 drawIndirectCount;
        public VkBool32 storageBuffer8BitAccess;
        public VkBool32 uniformAndStorageBuffer8BitAccess;
        public VkBool32 storagePushConstant8;
        public VkBool32 shaderBufferInt64Atomics;
        public VkBool32 shaderSharedInt64Atomics;
        public VkBool32 shaderFloat16;
        public VkBool32 shaderInt8;
        public VkBool32 descriptorIndexing;
        public VkBool32 shaderInputAttachmentArrayDynamicIndexing;
        public VkBool32 shaderUniformTexelBufferArrayDynamicIndexing;
        public VkBool32 shaderStorageTexelBufferArrayDynamicIndexing;
        public VkBool32 shaderUniformBufferArrayNonUniformIndexing;
        public VkBool32 shaderSampledImageArrayNonUniformIndexing;
        public VkBool32 shaderStorageBufferArrayNonUniformIndexing;
        public VkBool32 shaderStorageImageArrayNonUniformIndexing;
        public VkBool32 shaderInputAttachmentArrayNonUniformIndexing;
        public VkBool32 shaderUniformTexelBufferArrayNonUniformIndexing;
        public VkBool32 shaderStorageTexelBufferArrayNonUniformIndexing;
        public VkBool32 descriptorBindingUniformBufferUpdateAfterBind;
        public VkBool32 descriptorBindingSampledImageUpdateAfterBind;
        public VkBool32 descriptorBindingStorageImageUpdateAfterBind;
        public VkBool32 descriptorBindingStorageBufferUpdateAfterBind;
        public VkBool32 descriptorBindingUniformTexelBufferUpdateAfterBind;
        public VkBool32 descriptorBindingStorageTexelBufferUpdateAfterBind;
        public VkBool32 descriptorBindingUpdateUnusedWhilePending;
        public VkBool32 descriptorBindingPartiallyBound;
        public VkBool32 descriptorBindingVariableDescriptorCount;
        public VkBool32 runtimeDescriptorArray;
        public VkBool32 samplerFilterMinmax;
        public VkBool32 scalarBlockLayout;
        public VkBool32 imagelessFramebuffer;
        public VkBool32 uniformBufferStandardLayout;
        public VkBool32 shaderSubgroupExtendedTypes;
        public VkBool32 separateDepthStencilLayouts;
        public VkBool32 hostQueryReset;
        public VkBool32 timelineSemaphore;
        public VkBool32 bufferDeviceAddress;
        public VkBool32 bufferDeviceAddressCaptureReplay;
        public VkBool32 bufferDeviceAddressMultiDevice;
        public VkBool32 vulkanMemoryModel;
        public VkBool32 vulkanMemoryModelDeviceScope;
        public VkBool32 vulkanMemoryModelAvailabilityVisibilityChains;
        public VkBool32 shaderOutputViewportIndex;
        public VkBool32 shaderOutputLayer;
        public VkBool32 subgroupBroadcastDynamicId;
        public static VkPhysicalDeviceVulkan12Features New()
        {
            VkPhysicalDeviceVulkan12Features ret = new VkPhysicalDeviceVulkan12Features();
            ret.sType = VkStructureType.PhysicalDeviceVulkan12Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkan12Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDriverId driverID;
        public fixed byte driverName[(int)VulkanNative.MaxDriverNameSize];
        public fixed byte driverInfo[(int)VulkanNative.MaxDriverInfoSize];
        public VkConformanceVersion conformanceVersion;
        public VkShaderFloatControlsIndependence denormBehaviorIndependence;
        public VkShaderFloatControlsIndependence roundingModeIndependence;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat16;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat32;
        public VkBool32 shaderSignedZeroInfNanPreserveFloat64;
        public VkBool32 shaderDenormPreserveFloat16;
        public VkBool32 shaderDenormPreserveFloat32;
        public VkBool32 shaderDenormPreserveFloat64;
        public VkBool32 shaderDenormFlushToZeroFloat16;
        public VkBool32 shaderDenormFlushToZeroFloat32;
        public VkBool32 shaderDenormFlushToZeroFloat64;
        public VkBool32 shaderRoundingModeRTEFloat16;
        public VkBool32 shaderRoundingModeRTEFloat32;
        public VkBool32 shaderRoundingModeRTEFloat64;
        public VkBool32 shaderRoundingModeRTZFloat16;
        public VkBool32 shaderRoundingModeRTZFloat32;
        public VkBool32 shaderRoundingModeRTZFloat64;
        public uint maxUpdateAfterBindDescriptorsInAllPools;
        public VkBool32 shaderUniformBufferArrayNonUniformIndexingNative;
        public VkBool32 shaderSampledImageArrayNonUniformIndexingNative;
        public VkBool32 shaderStorageBufferArrayNonUniformIndexingNative;
        public VkBool32 shaderStorageImageArrayNonUniformIndexingNative;
        public VkBool32 shaderInputAttachmentArrayNonUniformIndexingNative;
        public VkBool32 robustBufferAccessUpdateAfterBind;
        public VkBool32 quadDivergentImplicitLod;
        public uint maxPerStageDescriptorUpdateAfterBindSamplers;
        public uint maxPerStageDescriptorUpdateAfterBindUniformBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindStorageBuffers;
        public uint maxPerStageDescriptorUpdateAfterBindSampledImages;
        public uint maxPerStageDescriptorUpdateAfterBindStorageImages;
        public uint maxPerStageDescriptorUpdateAfterBindInputAttachments;
        public uint maxPerStageUpdateAfterBindResources;
        public uint maxDescriptorSetUpdateAfterBindSamplers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffers;
        public uint maxDescriptorSetUpdateAfterBindUniformBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffers;
        public uint maxDescriptorSetUpdateAfterBindStorageBuffersDynamic;
        public uint maxDescriptorSetUpdateAfterBindSampledImages;
        public uint maxDescriptorSetUpdateAfterBindStorageImages;
        public uint maxDescriptorSetUpdateAfterBindInputAttachments;
        public VkResolveModeFlags supportedDepthResolveModes;
        public VkResolveModeFlags supportedStencilResolveModes;
        public VkBool32 independentResolveNone;
        public VkBool32 independentResolve;
        public VkBool32 filterMinmaxSingleComponentFormats;
        public VkBool32 filterMinmaxImageComponentMapping;
        public ulong maxTimelineSemaphoreValueDifference;
        public VkSampleCountFlags framebufferIntegerColorSampleCounts;
        public static VkPhysicalDeviceVulkan12Properties New()
        {
            VkPhysicalDeviceVulkan12Properties ret = new VkPhysicalDeviceVulkan12Properties();
            ret.sType = VkStructureType.PhysicalDeviceVulkan12Properties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkan13Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 robustImageAccess;
        public VkBool32 inlineUniformBlock;
        public VkBool32 descriptorBindingInlineUniformBlockUpdateAfterBind;
        public VkBool32 pipelineCreationCacheControl;
        public VkBool32 privateData;
        public VkBool32 shaderDemoteToHelperInvocation;
        public VkBool32 shaderTerminateInvocation;
        public VkBool32 subgroupSizeControl;
        public VkBool32 computeFullSubgroups;
        public VkBool32 synchronization2;
        public VkBool32 textureCompressionASTC_HDR;
        public VkBool32 shaderZeroInitializeWorkgroupMemory;
        public VkBool32 dynamicRendering;
        public VkBool32 shaderIntegerDotProduct;
        public VkBool32 maintenance4;
        public static VkPhysicalDeviceVulkan13Features New()
        {
            VkPhysicalDeviceVulkan13Features ret = new VkPhysicalDeviceVulkan13Features();
            ret.sType = VkStructureType.PhysicalDeviceVulkan13Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkan13Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minSubgroupSize;
        public uint maxSubgroupSize;
        public uint maxComputeWorkgroupSubgroups;
        public VkShaderStageFlags requiredSubgroupSizeStages;
        public uint maxInlineUniformBlockSize;
        public uint maxPerStageDescriptorInlineUniformBlocks;
        public uint maxPerStageDescriptorUpdateAfterBindInlineUniformBlocks;
        public uint maxDescriptorSetInlineUniformBlocks;
        public uint maxDescriptorSetUpdateAfterBindInlineUniformBlocks;
        public uint maxInlineUniformTotalSize;
        public VkBool32 integerDotProduct8BitUnsignedAccelerated;
        public VkBool32 integerDotProduct8BitSignedAccelerated;
        public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
        public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
        public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
        public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
        public VkBool32 integerDotProduct16BitUnsignedAccelerated;
        public VkBool32 integerDotProduct16BitSignedAccelerated;
        public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
        public VkBool32 integerDotProduct32BitUnsignedAccelerated;
        public VkBool32 integerDotProduct32BitSignedAccelerated;
        public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
        public VkBool32 integerDotProduct64BitUnsignedAccelerated;
        public VkBool32 integerDotProduct64BitSignedAccelerated;
        public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
        public ulong storageTexelBufferOffsetAlignmentBytes;
        public VkBool32 storageTexelBufferOffsetSingleTexelAlignment;
        public ulong uniformTexelBufferOffsetAlignmentBytes;
        public VkBool32 uniformTexelBufferOffsetSingleTexelAlignment;
        public ulong maxBufferSize;
        public static VkPhysicalDeviceVulkan13Properties New()
        {
            VkPhysicalDeviceVulkan13Properties ret = new VkPhysicalDeviceVulkan13Properties();
            ret.sType = VkStructureType.PhysicalDeviceVulkan13Properties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkan14Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 globalPriorityQuery;
        public VkBool32 shaderSubgroupRotate;
        public VkBool32 shaderSubgroupRotateClustered;
        public VkBool32 shaderFloatControls2;
        public VkBool32 shaderExpectAssume;
        public VkBool32 rectangularLines;
        public VkBool32 bresenhamLines;
        public VkBool32 smoothLines;
        public VkBool32 stippledRectangularLines;
        public VkBool32 stippledBresenhamLines;
        public VkBool32 stippledSmoothLines;
        public VkBool32 vertexAttributeInstanceRateDivisor;
        public VkBool32 vertexAttributeInstanceRateZeroDivisor;
        public VkBool32 indexTypeUint8;
        public VkBool32 dynamicRenderingLocalRead;
        public VkBool32 maintenance5;
        public VkBool32 maintenance6;
        public VkBool32 pipelineProtectedAccess;
        public VkBool32 pipelineRobustness;
        public VkBool32 hostImageCopy;
        public VkBool32 pushDescriptor;
        public static VkPhysicalDeviceVulkan14Features New()
        {
            VkPhysicalDeviceVulkan14Features ret = new VkPhysicalDeviceVulkan14Features();
            ret.sType = VkStructureType.PhysicalDeviceVulkan14Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkan14Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint lineSubPixelPrecisionBits;
        public uint maxVertexAttribDivisor;
        public VkBool32 supportsNonZeroFirstInstance;
        public uint maxPushDescriptors;
        public VkBool32 dynamicRenderingLocalReadDepthStencilAttachments;
        public VkBool32 dynamicRenderingLocalReadMultisampledAttachments;
        public VkBool32 earlyFragmentMultisampleCoverageAfterSampleCounting;
        public VkBool32 earlyFragmentSampleMaskTestBeforeSampleCounting;
        public VkBool32 depthStencilSwizzleOneSupport;
        public VkBool32 polygonModePointSize;
        public VkBool32 nonStrictSinglePixelWideLinesUseParallelogram;
        public VkBool32 nonStrictWideLinesUseParallelogram;
        public VkBool32 blockTexelViewCompatibleMultipleLayers;
        public uint maxCombinedImageSamplerDescriptorCount;
        public VkBool32 fragmentShadingRateClampCombinerInputs;
        public VkPipelineRobustnessBufferBehavior defaultRobustnessStorageBuffers;
        public VkPipelineRobustnessBufferBehavior defaultRobustnessUniformBuffers;
        public VkPipelineRobustnessBufferBehavior defaultRobustnessVertexInputs;
        public VkPipelineRobustnessImageBehavior defaultRobustnessImages;
        public uint copySrcLayoutCount;
        public VkImageLayout* pCopySrcLayouts;
        public uint copyDstLayoutCount;
        public VkImageLayout* pCopyDstLayouts;
        public fixed byte optimalTilingLayoutUUID[(int)VulkanNative.UuidSize];
        public VkBool32 identicalMemoryTypeRequirements;
        public static VkPhysicalDeviceVulkan14Properties New()
        {
            VkPhysicalDeviceVulkan14Properties ret = new VkPhysicalDeviceVulkan14Properties();
            ret.sType = VkStructureType.PhysicalDeviceVulkan14Properties;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineCompilerControlCreateInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCompilerControlFlagsAMD compilerControlFlags;
        public static VkPipelineCompilerControlCreateInfoAMD New()
        {
            VkPipelineCompilerControlCreateInfoAMD ret = new VkPipelineCompilerControlCreateInfoAMD();
            ret.sType = VkStructureType.PipelineCompilerControlCreateInfoAMD;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCoherentMemoryFeaturesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 deviceCoherentMemory;
        public static VkPhysicalDeviceCoherentMemoryFeaturesAMD New()
        {
            VkPhysicalDeviceCoherentMemoryFeaturesAMD ret = new VkPhysicalDeviceCoherentMemoryFeaturesAMD();
            ret.sType = VkStructureType.PhysicalDeviceCoherentMemoryFeaturesAMD;
            return ret;
        }
    }

    public unsafe partial struct VkFaultData
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFaultLevel faultLevel;
        public VkFaultType faultType;
        public static VkFaultData New()
        {
            VkFaultData ret = new VkFaultData();
            ret.sType = VkStructureType.FaultData;
            return ret;
        }
    }

    public unsafe partial struct VkFaultCallbackInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint faultCount;
        public VkFaultData* pFaults;
        public IntPtr pfnFaultCallback;
        public static VkFaultCallbackInfo New()
        {
            VkFaultCallbackInfo ret = new VkFaultCallbackInfo();
            ret.sType = VkStructureType.FaultCallbackInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceToolProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte name[(int)VulkanNative.MaxExtensionNameSize];
        public fixed byte version[(int)VulkanNative.MaxExtensionNameSize];
        public VkToolPurposeFlags purposes;
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public fixed byte layer[(int)VulkanNative.MaxExtensionNameSize];
        public static VkPhysicalDeviceToolProperties New()
        {
            VkPhysicalDeviceToolProperties ret = new VkPhysicalDeviceToolProperties();
            ret.sType = VkStructureType.PhysicalDeviceToolProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceToolPropertiesEXT
    {
    }

    public unsafe partial struct VkSamplerCustomBorderColorCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkClearColorValue customBorderColor;
        public VkFormat format;
        public static VkSamplerCustomBorderColorCreateInfoEXT New()
        {
            VkSamplerCustomBorderColorCreateInfoEXT ret = new VkSamplerCustomBorderColorCreateInfoEXT();
            ret.sType = VkStructureType.SamplerCustomBorderColorCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCustomBorderColorPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxCustomBorderColorSamplers;
        public static VkPhysicalDeviceCustomBorderColorPropertiesEXT New()
        {
            VkPhysicalDeviceCustomBorderColorPropertiesEXT ret = new VkPhysicalDeviceCustomBorderColorPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceCustomBorderColorPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCustomBorderColorFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 customBorderColors;
        public VkBool32 customBorderColorWithoutFormat;
        public static VkPhysicalDeviceCustomBorderColorFeaturesEXT New()
        {
            VkPhysicalDeviceCustomBorderColorFeaturesEXT ret = new VkPhysicalDeviceCustomBorderColorFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceCustomBorderColorFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerBorderColorComponentMappingCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkComponentMapping components;
        public VkBool32 srgb;
        public static VkSamplerBorderColorComponentMappingCreateInfoEXT New()
        {
            VkSamplerBorderColorComponentMappingCreateInfoEXT ret = new VkSamplerBorderColorComponentMappingCreateInfoEXT();
            ret.sType = VkStructureType.SamplerBorderColorComponentMappingCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 borderColorSwizzle;
        public VkBool32 borderColorSwizzleFromImage;
        public static VkPhysicalDeviceBorderColorSwizzleFeaturesEXT New()
        {
            VkPhysicalDeviceBorderColorSwizzleFeaturesEXT ret = new VkPhysicalDeviceBorderColorSwizzleFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceBorderColorSwizzleFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureGeometryTrianglesDataKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat vertexFormat;
        public VkDeviceOrHostAddressConstKHR vertexData;
        public ulong vertexStride;
        public uint maxVertex;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexData;
        public VkDeviceOrHostAddressConstKHR transformData;
        public static VkAccelerationStructureGeometryTrianglesDataKHR New()
        {
            VkAccelerationStructureGeometryTrianglesDataKHR ret = new VkAccelerationStructureGeometryTrianglesDataKHR();
            ret.sType = VkStructureType.AccelerationStructureGeometryTrianglesDataKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureGeometryAabbsDataKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR data;
        public ulong stride;
        public static VkAccelerationStructureGeometryAabbsDataKHR New()
        {
            VkAccelerationStructureGeometryAabbsDataKHR ret = new VkAccelerationStructureGeometryAabbsDataKHR();
            ret.sType = VkStructureType.AccelerationStructureGeometryAabbsDataKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureGeometryInstancesDataKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 arrayOfPointers;
        public VkDeviceOrHostAddressConstKHR data;
        public static VkAccelerationStructureGeometryInstancesDataKHR New()
        {
            VkAccelerationStructureGeometryInstancesDataKHR ret = new VkAccelerationStructureGeometryInstancesDataKHR();
            ret.sType = VkStructureType.AccelerationStructureGeometryInstancesDataKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureGeometryLinearSweptSpheresDataNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat vertexFormat;
        public VkDeviceOrHostAddressConstKHR vertexData;
        public ulong vertexStride;
        public VkFormat radiusFormat;
        public VkDeviceOrHostAddressConstKHR radiusData;
        public ulong radiusStride;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexData;
        public ulong indexStride;
        public VkRayTracingLssIndexingModeNV indexingMode;
        public VkRayTracingLssPrimitiveEndCapsModeNV endCapsMode;
        public static VkAccelerationStructureGeometryLinearSweptSpheresDataNV New()
        {
            VkAccelerationStructureGeometryLinearSweptSpheresDataNV ret = new VkAccelerationStructureGeometryLinearSweptSpheresDataNV();
            ret.sType = VkStructureType.AccelerationStructureGeometryLinearSweptSpheresDataNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureGeometrySpheresDataNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat vertexFormat;
        public VkDeviceOrHostAddressConstKHR vertexData;
        public ulong vertexStride;
        public VkFormat radiusFormat;
        public VkDeviceOrHostAddressConstKHR radiusData;
        public ulong radiusStride;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexData;
        public ulong indexStride;
        public static VkAccelerationStructureGeometrySpheresDataNV New()
        {
            VkAccelerationStructureGeometrySpheresDataNV ret = new VkAccelerationStructureGeometrySpheresDataNV();
            ret.sType = VkStructureType.AccelerationStructureGeometrySpheresDataNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureGeometryKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkGeometryTypeKHR geometryType;
        public VkAccelerationStructureGeometryDataKHR geometry;
        public VkGeometryFlagsKHR flags;
        public static VkAccelerationStructureGeometryKHR New()
        {
            VkAccelerationStructureGeometryKHR ret = new VkAccelerationStructureGeometryKHR();
            ret.sType = VkStructureType.AccelerationStructureGeometryKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureBuildGeometryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureTypeKHR type;
        public VkBuildAccelerationStructureFlagsKHR flags;
        public VkBuildAccelerationStructureModeKHR mode;
        public VkAccelerationStructureKHR srcAccelerationStructure;
        public VkAccelerationStructureKHR dstAccelerationStructure;
        public uint geometryCount;
        public VkAccelerationStructureGeometryKHR* pGeometries;
        public VkAccelerationStructureGeometryKHR** ppGeometries;
        public VkDeviceOrHostAddressKHR scratchData;
        public static VkAccelerationStructureBuildGeometryInfoKHR New()
        {
            VkAccelerationStructureBuildGeometryInfoKHR ret = new VkAccelerationStructureBuildGeometryInfoKHR();
            ret.sType = VkStructureType.AccelerationStructureBuildGeometryInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureBuildRangeInfoKHR
    {
        public uint primitiveCount;
        public uint primitiveOffset;
        public uint firstVertex;
        public uint transformOffset;
    }

    public unsafe partial struct VkAccelerationStructureCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureCreateFlagsKHR createFlags;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        public VkAccelerationStructureTypeKHR type;
        public ulong deviceAddress;
        public static VkAccelerationStructureCreateInfoKHR New()
        {
            VkAccelerationStructureCreateInfoKHR ret = new VkAccelerationStructureCreateInfoKHR();
            ret.sType = VkStructureType.AccelerationStructureCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAabbPositionsKHR
    {
        public float minX;
        public float minY;
        public float minZ;
        public float maxX;
        public float maxY;
        public float maxZ;
    }

    public unsafe partial struct VkAabbPositionsNV
    {
    }

    public unsafe partial struct VkTransformMatrixKHR
    {
        public float matrix_0;
        public float matrix_1;
        public float matrix_2;
    }

    public unsafe partial struct VkTransformMatrixNV
    {
    }

    public unsafe partial struct VkAccelerationStructureInstanceKHR
    {
        public VkTransformMatrixKHR transform;
        public uint instanceCustomIndex;
        public uint mask;
        public uint instanceShaderBindingTableRecordOffset;
        public VkGeometryInstanceFlagsKHR flags;
        public ulong accelerationStructureReference;
    }

    public unsafe partial struct VkAccelerationStructureInstanceNV
    {
    }

    public unsafe partial struct VkAccelerationStructureDeviceAddressInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR accelerationStructure;
        public static VkAccelerationStructureDeviceAddressInfoKHR New()
        {
            VkAccelerationStructureDeviceAddressInfoKHR ret = new VkAccelerationStructureDeviceAddressInfoKHR();
            ret.sType = VkStructureType.AccelerationStructureDeviceAddressInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureVersionInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pVersionData;
        public static VkAccelerationStructureVersionInfoKHR New()
        {
            VkAccelerationStructureVersionInfoKHR ret = new VkAccelerationStructureVersionInfoKHR();
            ret.sType = VkStructureType.AccelerationStructureVersionInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkCopyAccelerationStructureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR src;
        public VkAccelerationStructureKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
        public static VkCopyAccelerationStructureInfoKHR New()
        {
            VkCopyAccelerationStructureInfoKHR ret = new VkCopyAccelerationStructureInfoKHR();
            ret.sType = VkStructureType.CopyAccelerationStructureInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkCopyAccelerationStructureToMemoryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR src;
        public VkDeviceOrHostAddressKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
        public static VkCopyAccelerationStructureToMemoryInfoKHR New()
        {
            VkCopyAccelerationStructureToMemoryInfoKHR ret = new VkCopyAccelerationStructureToMemoryInfoKHR();
            ret.sType = VkStructureType.CopyAccelerationStructureToMemoryInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkCopyMemoryToAccelerationStructureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR src;
        public VkAccelerationStructureKHR dst;
        public VkCopyAccelerationStructureModeKHR mode;
        public static VkCopyMemoryToAccelerationStructureInfoKHR New()
        {
            VkCopyMemoryToAccelerationStructureInfoKHR ret = new VkCopyMemoryToAccelerationStructureInfoKHR();
            ret.sType = VkStructureType.CopyMemoryToAccelerationStructureInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkRayTracingPipelineInterfaceCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPipelineRayPayloadSize;
        public uint maxPipelineRayHitAttributeSize;
        public static VkRayTracingPipelineInterfaceCreateInfoKHR New()
        {
            VkRayTracingPipelineInterfaceCreateInfoKHR ret = new VkRayTracingPipelineInterfaceCreateInfoKHR();
            ret.sType = VkStructureType.RayTracingPipelineInterfaceCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineLibraryCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint libraryCount;
        public VkPipeline* pLibraries;
        public static VkPipelineLibraryCreateInfoKHR New()
        {
            VkPipelineLibraryCreateInfoKHR ret = new VkPipelineLibraryCreateInfoKHR();
            ret.sType = VkStructureType.PipelineLibraryCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkRefreshObjectKHR
    {
        public VkObjectType objectType;
        public ulong objectHandle;
        public VkRefreshObjectFlagsKHR flags;
    }

    public unsafe partial struct VkRefreshObjectListKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint objectCount;
        public VkRefreshObjectKHR* pObjects;
        public static VkRefreshObjectListKHR New()
        {
            VkRefreshObjectListKHR ret = new VkRefreshObjectListKHR();
            ret.sType = VkStructureType.RefreshObjectListKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExtendedDynamicStateFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 extendedDynamicState;
        public static VkPhysicalDeviceExtendedDynamicStateFeaturesEXT New()
        {
            VkPhysicalDeviceExtendedDynamicStateFeaturesEXT ret = new VkPhysicalDeviceExtendedDynamicStateFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceExtendedDynamicStateFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExtendedDynamicState2FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 extendedDynamicState2;
        public VkBool32 extendedDynamicState2LogicOp;
        public VkBool32 extendedDynamicState2PatchControlPoints;
        public static VkPhysicalDeviceExtendedDynamicState2FeaturesEXT New()
        {
            VkPhysicalDeviceExtendedDynamicState2FeaturesEXT ret = new VkPhysicalDeviceExtendedDynamicState2FeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceExtendedDynamicState2FeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 extendedDynamicState3TessellationDomainOrigin;
        public VkBool32 extendedDynamicState3DepthClampEnable;
        public VkBool32 extendedDynamicState3PolygonMode;
        public VkBool32 extendedDynamicState3RasterizationSamples;
        public VkBool32 extendedDynamicState3SampleMask;
        public VkBool32 extendedDynamicState3AlphaToCoverageEnable;
        public VkBool32 extendedDynamicState3AlphaToOneEnable;
        public VkBool32 extendedDynamicState3LogicOpEnable;
        public VkBool32 extendedDynamicState3ColorBlendEnable;
        public VkBool32 extendedDynamicState3ColorBlendEquation;
        public VkBool32 extendedDynamicState3ColorWriteMask;
        public VkBool32 extendedDynamicState3RasterizationStream;
        public VkBool32 extendedDynamicState3ConservativeRasterizationMode;
        public VkBool32 extendedDynamicState3ExtraPrimitiveOverestimationSize;
        public VkBool32 extendedDynamicState3DepthClipEnable;
        public VkBool32 extendedDynamicState3SampleLocationsEnable;
        public VkBool32 extendedDynamicState3ColorBlendAdvanced;
        public VkBool32 extendedDynamicState3ProvokingVertexMode;
        public VkBool32 extendedDynamicState3LineRasterizationMode;
        public VkBool32 extendedDynamicState3LineStippleEnable;
        public VkBool32 extendedDynamicState3DepthClipNegativeOneToOne;
        public VkBool32 extendedDynamicState3ViewportWScalingEnable;
        public VkBool32 extendedDynamicState3ViewportSwizzle;
        public VkBool32 extendedDynamicState3CoverageToColorEnable;
        public VkBool32 extendedDynamicState3CoverageToColorLocation;
        public VkBool32 extendedDynamicState3CoverageModulationMode;
        public VkBool32 extendedDynamicState3CoverageModulationTableEnable;
        public VkBool32 extendedDynamicState3CoverageModulationTable;
        public VkBool32 extendedDynamicState3CoverageReductionMode;
        public VkBool32 extendedDynamicState3RepresentativeFragmentTestEnable;
        public VkBool32 extendedDynamicState3ShadingRateImageEnable;
        public static VkPhysicalDeviceExtendedDynamicState3FeaturesEXT New()
        {
            VkPhysicalDeviceExtendedDynamicState3FeaturesEXT ret = new VkPhysicalDeviceExtendedDynamicState3FeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceExtendedDynamicState3FeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExtendedDynamicState3PropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dynamicPrimitiveTopologyUnrestricted;
        public static VkPhysicalDeviceExtendedDynamicState3PropertiesEXT New()
        {
            VkPhysicalDeviceExtendedDynamicState3PropertiesEXT ret = new VkPhysicalDeviceExtendedDynamicState3PropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceExtendedDynamicState3PropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkColorBlendEquationEXT
    {
        public VkBlendFactor srcColorBlendFactor;
        public VkBlendFactor dstColorBlendFactor;
        public VkBlendOp colorBlendOp;
        public VkBlendFactor srcAlphaBlendFactor;
        public VkBlendFactor dstAlphaBlendFactor;
        public VkBlendOp alphaBlendOp;
    }

    public unsafe partial struct VkColorBlendAdvancedEXT
    {
        public VkBlendOp advancedBlendOp;
        public VkBool32 srcPremultiplied;
        public VkBool32 dstPremultiplied;
        public VkBlendOverlapEXT blendOverlap;
        public VkBool32 clampResults;
    }

    public unsafe partial struct VkRenderPassTransformBeginInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceTransformFlagsKHR transform;
        public static VkRenderPassTransformBeginInfoQCOM New()
        {
            VkRenderPassTransformBeginInfoQCOM ret = new VkRenderPassTransformBeginInfoQCOM();
            ret.sType = VkStructureType.RenderPassTransformBeginInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkCopyCommandTransformInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceTransformFlagsKHR transform;
        public static VkCopyCommandTransformInfoQCOM New()
        {
            VkCopyCommandTransformInfoQCOM ret = new VkCopyCommandTransformInfoQCOM();
            ret.sType = VkStructureType.CopyCommandTransformInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferInheritanceRenderPassTransformInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSurfaceTransformFlagsKHR transform;
        public VkRect2D renderArea;
        public static VkCommandBufferInheritanceRenderPassTransformInfoQCOM New()
        {
            VkCommandBufferInheritanceRenderPassTransformInfoQCOM ret = new VkCommandBufferInheritanceRenderPassTransformInfoQCOM();
            ret.sType = VkStructureType.CommandBufferInheritanceRenderPassTransformInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePartitionedAccelerationStructureFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 partitionedAccelerationStructure;
        public static VkPhysicalDevicePartitionedAccelerationStructureFeaturesNV New()
        {
            VkPhysicalDevicePartitionedAccelerationStructureFeaturesNV ret = new VkPhysicalDevicePartitionedAccelerationStructureFeaturesNV();
            ret.sType = VkStructureType.PhysicalDevicePartitionedAccelerationStructureFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxPartitionCount;
        public static VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV New()
        {
            VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV ret = new VkPhysicalDevicePartitionedAccelerationStructurePropertiesNV();
            ret.sType = VkStructureType.PhysicalDevicePartitionedAccelerationStructurePropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkBuildPartitionedAccelerationStructureIndirectCommandNV
    {
        public VkPartitionedAccelerationStructureOpTypeNV opType;
        public uint argCount;
        public VkStridedDeviceAddressNV argData;
    }

    public unsafe partial struct VkPartitionedAccelerationStructureFlagsNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 enablePartitionTranslation;
        public static VkPartitionedAccelerationStructureFlagsNV New()
        {
            VkPartitionedAccelerationStructureFlagsNV ret = new VkPartitionedAccelerationStructureFlagsNV();
            ret.sType = VkStructureType.PartitionedAccelerationStructureNV;
            return ret;
        }
    }

    public unsafe partial struct VkPartitionedAccelerationStructureWriteInstanceDataNV
    {
        public VkTransformMatrixKHR transform;
        public float explicitAABB_0;
        public float explicitAABB_1;
        public float explicitAABB_2;
        public float explicitAABB_3;
        public float explicitAABB_4;
        public float explicitAABB_5;
        public uint instanceID;
        public uint instanceMask;
        public uint instanceContributionToHitGroupIndex;
        public VkPartitionedAccelerationStructureInstanceFlagsNV instanceFlags;
        public uint instanceIndex;
        public uint partitionIndex;
        public ulong accelerationStructure;
    }

    public unsafe partial struct VkPartitionedAccelerationStructureUpdateInstanceDataNV
    {
        public uint instanceIndex;
        public uint instanceContributionToHitGroupIndex;
        public ulong accelerationStructure;
    }

    public unsafe partial struct VkPartitionedAccelerationStructureWritePartitionTranslationDataNV
    {
        public uint partitionIndex;
        public float partitionTranslation_0;
        public float partitionTranslation_1;
        public float partitionTranslation_2;
    }

    public unsafe partial struct VkWriteDescriptorSetPartitionedAccelerationStructureNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint accelerationStructureCount;
        public ulong* pAccelerationStructures;
        public static VkWriteDescriptorSetPartitionedAccelerationStructureNV New()
        {
            VkWriteDescriptorSetPartitionedAccelerationStructureNV ret = new VkWriteDescriptorSetPartitionedAccelerationStructureNV();
            ret.sType = VkStructureType.WriteDescriptorSetPartitionedAccelerationStructureNV;
            return ret;
        }
    }

    public unsafe partial struct VkPartitionedAccelerationStructureInstancesInputNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuildAccelerationStructureFlagsKHR flags;
        public uint instanceCount;
        public uint maxInstancePerPartitionCount;
        public uint partitionCount;
        public uint maxInstanceInGlobalPartitionCount;
        public static VkPartitionedAccelerationStructureInstancesInputNV New()
        {
            VkPartitionedAccelerationStructureInstancesInputNV ret = new VkPartitionedAccelerationStructureInstancesInputNV();
            ret.sType = VkStructureType.PartitionedAccelerationStructureInstancesInputNV;
            return ret;
        }
    }

    public unsafe partial struct VkBuildPartitionedAccelerationStructureInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPartitionedAccelerationStructureInstancesInputNV input;
        public ulong srcAccelerationStructureData;
        public ulong dstAccelerationStructureData;
        public ulong scratchData;
        public ulong srcInfos;
        public ulong srcInfosCount;
        public static VkBuildPartitionedAccelerationStructureInfoNV New()
        {
            VkBuildPartitionedAccelerationStructureInfoNV ret = new VkBuildPartitionedAccelerationStructureInfoNV();
            ret.sType = VkStructureType.BuildPartitionedAccelerationStructureInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDiagnosticsConfigFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 diagnosticsConfig;
        public static VkPhysicalDeviceDiagnosticsConfigFeaturesNV New()
        {
            VkPhysicalDeviceDiagnosticsConfigFeaturesNV ret = new VkPhysicalDeviceDiagnosticsConfigFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceDiagnosticsConfigFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceDiagnosticsConfigCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceDiagnosticsConfigFlagsNV flags;
        public static VkDeviceDiagnosticsConfigCreateInfoNV New()
        {
            VkDeviceDiagnosticsConfigCreateInfoNV ret = new VkDeviceDiagnosticsConfigCreateInfoNV();
            ret.sType = VkStructureType.DeviceDiagnosticsConfigCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineOfflineCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte pipelineIdentifier[(int)VulkanNative.UuidSize];
        public VkPipelineMatchControl matchControl;
        public ulong poolEntrySize;
        public static VkPipelineOfflineCreateInfo New()
        {
            VkPipelineOfflineCreateInfo ret = new VkPipelineOfflineCreateInfo();
            ret.sType = VkStructureType.PipelineOfflineCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderZeroInitializeWorkgroupMemory;
        public static VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures New()
        {
            VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures ret = new VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeatures();
            ret.sType = VkStructureType.PhysicalDeviceZeroInitializeWorkgroupMemoryFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceZeroInitializeWorkgroupMemoryFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderSubgroupUniformControlFlow;
        public static VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR New()
        {
            VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR ret = new VkPhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceShaderSubgroupUniformControlFlowFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRobustness2FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 robustBufferAccess2;
        public VkBool32 robustImageAccess2;
        public VkBool32 nullDescriptor;
        public static VkPhysicalDeviceRobustness2FeaturesKHR New()
        {
            VkPhysicalDeviceRobustness2FeaturesKHR ret = new VkPhysicalDeviceRobustness2FeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceRobustness2FeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRobustness2FeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceRobustness2PropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong robustStorageBufferAccessSizeAlignment;
        public ulong robustUniformBufferAccessSizeAlignment;
        public static VkPhysicalDeviceRobustness2PropertiesKHR New()
        {
            VkPhysicalDeviceRobustness2PropertiesKHR ret = new VkPhysicalDeviceRobustness2PropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceRobustness2PropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRobustness2PropertiesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceImageRobustnessFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 robustImageAccess;
        public static VkPhysicalDeviceImageRobustnessFeatures New()
        {
            VkPhysicalDeviceImageRobustnessFeatures ret = new VkPhysicalDeviceImageRobustnessFeatures();
            ret.sType = VkStructureType.PhysicalDeviceImageRobustnessFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageRobustnessFeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 workgroupMemoryExplicitLayout;
        public VkBool32 workgroupMemoryExplicitLayoutScalarBlockLayout;
        public VkBool32 workgroupMemoryExplicitLayout8BitAccess;
        public VkBool32 workgroupMemoryExplicitLayout16BitAccess;
        public static VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR New()
        {
            VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR ret = new VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePortabilitySubsetFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 constantAlphaColorBlendFactors;
        public VkBool32 events;
        public VkBool32 imageViewFormatReinterpretation;
        public VkBool32 imageViewFormatSwizzle;
        public VkBool32 imageView2DOn3DImage;
        public VkBool32 multisampleArrayImage;
        public VkBool32 mutableComparisonSamplers;
        public VkBool32 pointPolygons;
        public VkBool32 samplerMipLodBias;
        public VkBool32 separateStencilMaskRef;
        public VkBool32 shaderSampleRateInterpolationFunctions;
        public VkBool32 tessellationIsolines;
        public VkBool32 tessellationPointMode;
        public VkBool32 triangleFans;
        public VkBool32 vertexAttributeAccessBeyondStride;
        public static VkPhysicalDevicePortabilitySubsetFeaturesKHR New()
        {
            VkPhysicalDevicePortabilitySubsetFeaturesKHR ret = new VkPhysicalDevicePortabilitySubsetFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDevicePortabilitySubsetFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePortabilitySubsetPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minVertexInputBindingStrideAlignment;
        public static VkPhysicalDevicePortabilitySubsetPropertiesKHR New()
        {
            VkPhysicalDevicePortabilitySubsetPropertiesKHR ret = new VkPhysicalDevicePortabilitySubsetPropertiesKHR();
            ret.sType = VkStructureType.PhysicalDevicePortabilitySubsetPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevice4444FormatsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 formatA4R4G4B4;
        public VkBool32 formatA4B4G4R4;
        public static VkPhysicalDevice4444FormatsFeaturesEXT New()
        {
            VkPhysicalDevice4444FormatsFeaturesEXT ret = new VkPhysicalDevice4444FormatsFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDevice4444FormatsFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSubpassShadingFeaturesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 subpassShading;
        public static VkPhysicalDeviceSubpassShadingFeaturesHUAWEI New()
        {
            VkPhysicalDeviceSubpassShadingFeaturesHUAWEI ret = new VkPhysicalDeviceSubpassShadingFeaturesHUAWEI();
            ret.sType = VkStructureType.PhysicalDeviceSubpassShadingFeaturesHuawei;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 clustercullingShader;
        public VkBool32 multiviewClusterCullingShader;
        public static VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI New()
        {
            VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI ret = new VkPhysicalDeviceClusterCullingShaderFeaturesHUAWEI();
            ret.sType = VkStructureType.PhysicalDeviceClusterCullingShaderFeaturesHuawei;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 clusterShadingRate;
        public static VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI New()
        {
            VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI ret = new VkPhysicalDeviceClusterCullingShaderVrsFeaturesHUAWEI();
            ret.sType = VkStructureType.PhysicalDeviceClusterCullingShaderVrsFeaturesHuawei;
            return ret;
        }
    }

    public unsafe partial struct VkBufferCopy2
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong srcOffset;
        public ulong dstOffset;
        public ulong size;
        public static VkBufferCopy2 New()
        {
            VkBufferCopy2 ret = new VkBufferCopy2();
            ret.sType = VkStructureType.BufferCopy2;
            return ret;
        }
    }

    public unsafe partial struct VkBufferCopy2KHR
    {
    }

    public unsafe partial struct VkImageCopy2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
        public static VkImageCopy2 New()
        {
            VkImageCopy2 ret = new VkImageCopy2();
            ret.sType = VkStructureType.ImageCopy2;
            return ret;
        }
    }

    public unsafe partial struct VkImageCopy2KHR
    {
    }

    public unsafe partial struct VkImageBlit2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffsets_0;
        public VkOffset3D srcOffsets_1;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffsets_0;
        public VkOffset3D dstOffsets_1;
        public static VkImageBlit2 New()
        {
            VkImageBlit2 ret = new VkImageBlit2();
            ret.sType = VkStructureType.ImageBlit2;
            return ret;
        }
    }

    public unsafe partial struct VkImageBlit2KHR
    {
    }

    public unsafe partial struct VkBufferImageCopy2
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong bufferOffset;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
        public static VkBufferImageCopy2 New()
        {
            VkBufferImageCopy2 ret = new VkBufferImageCopy2();
            ret.sType = VkStructureType.BufferImageCopy2;
            return ret;
        }
    }

    public unsafe partial struct VkBufferImageCopy2KHR
    {
    }

    public unsafe partial struct VkImageResolve2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresourceLayers srcSubresource;
        public VkOffset3D srcOffset;
        public VkImageSubresourceLayers dstSubresource;
        public VkOffset3D dstOffset;
        public VkExtent3D extent;
        public static VkImageResolve2 New()
        {
            VkImageResolve2 ret = new VkImageResolve2();
            ret.sType = VkStructureType.ImageResolve2;
            return ret;
        }
    }

    public unsafe partial struct VkImageResolve2KHR
    {
    }

    public unsafe partial struct VkCopyBufferInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer srcBuffer;
        public VkBuffer dstBuffer;
        public uint regionCount;
        public VkBufferCopy2* pRegions;
        public static VkCopyBufferInfo2 New()
        {
            VkCopyBufferInfo2 ret = new VkCopyBufferInfo2();
            ret.sType = VkStructureType.CopyBufferInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkCopyBufferInfo2KHR
    {
    }

    public unsafe partial struct VkCopyImageInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageCopy2* pRegions;
        public static VkCopyImageInfo2 New()
        {
            VkCopyImageInfo2 ret = new VkCopyImageInfo2();
            ret.sType = VkStructureType.CopyImageInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkCopyImageInfo2KHR
    {
    }

    public unsafe partial struct VkBlitImageInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageBlit2* pRegions;
        public VkFilter filter;
        public static VkBlitImageInfo2 New()
        {
            VkBlitImageInfo2 ret = new VkBlitImageInfo2();
            ret.sType = VkStructureType.BlitImageInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkBlitImageInfo2KHR
    {
    }

    public unsafe partial struct VkCopyBufferToImageInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer srcBuffer;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkBufferImageCopy2* pRegions;
        public static VkCopyBufferToImageInfo2 New()
        {
            VkCopyBufferToImageInfo2 ret = new VkCopyBufferToImageInfo2();
            ret.sType = VkStructureType.CopyBufferToImageInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkCopyBufferToImageInfo2KHR
    {
    }

    public unsafe partial struct VkCopyImageToBufferInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkBuffer dstBuffer;
        public uint regionCount;
        public VkBufferImageCopy2* pRegions;
        public static VkCopyImageToBufferInfo2 New()
        {
            VkCopyImageToBufferInfo2 ret = new VkCopyImageToBufferInfo2();
            ret.sType = VkStructureType.CopyImageToBufferInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkCopyImageToBufferInfo2KHR
    {
    }

    public unsafe partial struct VkResolveImageInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageResolve2* pRegions;
        public static VkResolveImageInfo2 New()
        {
            VkResolveImageInfo2 ret = new VkResolveImageInfo2();
            ret.sType = VkStructureType.ResolveImageInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkResolveImageInfo2KHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderImageInt64Atomics;
        public VkBool32 sparseImageInt64Atomics;
        public static VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT New()
        {
            VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT ret = new VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderImageAtomicInt64FeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkFragmentShadingRateAttachmentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAttachmentReference2* pFragmentShadingRateAttachment;
        public VkExtent2D shadingRateAttachmentTexelSize;
        public static VkFragmentShadingRateAttachmentInfoKHR New()
        {
            VkFragmentShadingRateAttachmentInfoKHR ret = new VkFragmentShadingRateAttachmentInfoKHR();
            ret.sType = VkStructureType.FragmentShadingRateAttachmentInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineFragmentShadingRateStateCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D fragmentSize;
        public VkFragmentShadingRateCombinerOpKHR combinerOps_0;
        public VkFragmentShadingRateCombinerOpKHR combinerOps_1;
        public static VkPipelineFragmentShadingRateStateCreateInfoKHR New()
        {
            VkPipelineFragmentShadingRateStateCreateInfoKHR ret = new VkPipelineFragmentShadingRateStateCreateInfoKHR();
            ret.sType = VkStructureType.PipelineFragmentShadingRateStateCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShadingRateFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineFragmentShadingRate;
        public VkBool32 primitiveFragmentShadingRate;
        public VkBool32 attachmentFragmentShadingRate;
        public static VkPhysicalDeviceFragmentShadingRateFeaturesKHR New()
        {
            VkPhysicalDeviceFragmentShadingRateFeaturesKHR ret = new VkPhysicalDeviceFragmentShadingRateFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShadingRateFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShadingRatePropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D minFragmentShadingRateAttachmentTexelSize;
        public VkExtent2D maxFragmentShadingRateAttachmentTexelSize;
        public uint maxFragmentShadingRateAttachmentTexelSizeAspectRatio;
        public VkBool32 primitiveFragmentShadingRateWithMultipleViewports;
        public VkBool32 layeredShadingRateAttachments;
        public VkBool32 fragmentShadingRateNonTrivialCombinerOps;
        public VkExtent2D maxFragmentSize;
        public uint maxFragmentSizeAspectRatio;
        public uint maxFragmentShadingRateCoverageSamples;
        public VkSampleCountFlags maxFragmentShadingRateRasterizationSamples;
        public VkBool32 fragmentShadingRateWithShaderDepthStencilWrites;
        public VkBool32 fragmentShadingRateWithSampleMask;
        public VkBool32 fragmentShadingRateWithShaderSampleMask;
        public VkBool32 fragmentShadingRateWithConservativeRasterization;
        public VkBool32 fragmentShadingRateWithFragmentShaderInterlock;
        public VkBool32 fragmentShadingRateWithCustomSampleLocations;
        public VkBool32 fragmentShadingRateStrictMultiplyCombiner;
        public static VkPhysicalDeviceFragmentShadingRatePropertiesKHR New()
        {
            VkPhysicalDeviceFragmentShadingRatePropertiesKHR ret = new VkPhysicalDeviceFragmentShadingRatePropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShadingRatePropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShadingRateKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlags sampleCounts;
        public VkExtent2D fragmentSize;
        public static VkPhysicalDeviceFragmentShadingRateKHR New()
        {
            VkPhysicalDeviceFragmentShadingRateKHR ret = new VkPhysicalDeviceFragmentShadingRateKHR();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShadingRateKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderTerminateInvocationFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderTerminateInvocation;
        public static VkPhysicalDeviceShaderTerminateInvocationFeatures New()
        {
            VkPhysicalDeviceShaderTerminateInvocationFeatures ret = new VkPhysicalDeviceShaderTerminateInvocationFeatures();
            ret.sType = VkStructureType.PhysicalDeviceShaderTerminateInvocationFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderTerminateInvocationFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentShadingRateEnums;
        public VkBool32 supersampleFragmentShadingRates;
        public VkBool32 noInvocationFragmentShadingRates;
        public static VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV New()
        {
            VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV ret = new VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShadingRateEnumsFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampleCountFlags maxFragmentShadingRateInvocationCount;
        public static VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV New()
        {
            VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV ret = new VkPhysicalDeviceFragmentShadingRateEnumsPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShadingRateEnumsPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineFragmentShadingRateEnumStateCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFragmentShadingRateTypeNV shadingRateType;
        public VkFragmentShadingRateNV shadingRate;
        public VkFragmentShadingRateCombinerOpKHR combinerOps_0;
        public VkFragmentShadingRateCombinerOpKHR combinerOps_1;
        public static VkPipelineFragmentShadingRateEnumStateCreateInfoNV New()
        {
            VkPipelineFragmentShadingRateEnumStateCreateInfoNV ret = new VkPipelineFragmentShadingRateEnumStateCreateInfoNV();
            ret.sType = VkStructureType.PipelineFragmentShadingRateEnumStateCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureBuildSizesInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong accelerationStructureSize;
        public ulong updateScratchSize;
        public ulong buildScratchSize;
        public static VkAccelerationStructureBuildSizesInfoKHR New()
        {
            VkAccelerationStructureBuildSizesInfoKHR ret = new VkAccelerationStructureBuildSizesInfoKHR();
            ret.sType = VkStructureType.AccelerationStructureBuildSizesInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImage2DViewOf3DFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 image2DViewOf3D;
        public VkBool32 sampler2DViewOf3D;
        public static VkPhysicalDeviceImage2DViewOf3DFeaturesEXT New()
        {
            VkPhysicalDeviceImage2DViewOf3DFeaturesEXT ret = new VkPhysicalDeviceImage2DViewOf3DFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceImage2dViewOf3dFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 imageSlicedViewOf3D;
        public static VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT New()
        {
            VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT ret = new VkPhysicalDeviceImageSlicedViewOf3DFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceImageSlicedViewOf3dFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 attachmentFeedbackLoopDynamicState;
        public static VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT New()
        {
            VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT ret = new VkPhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceAttachmentFeedbackLoopDynamicStateFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 legacyVertexAttributes;
        public static VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT New()
        {
            VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT ret = new VkPhysicalDeviceLegacyVertexAttributesFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceLegacyVertexAttributesFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 nativeUnalignedPerformance;
        public static VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT New()
        {
            VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT ret = new VkPhysicalDeviceLegacyVertexAttributesPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceLegacyVertexAttributesPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 mutableDescriptorType;
        public static VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT New()
        {
            VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT ret = new VkPhysicalDeviceMutableDescriptorTypeFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceMutableDescriptorTypeFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMutableDescriptorTypeFeaturesVALVE
    {
    }

    public unsafe partial struct VkMutableDescriptorTypeListEXT
    {
        public uint descriptorTypeCount;
        public VkDescriptorType* pDescriptorTypes;
    }

    public unsafe partial struct VkMutableDescriptorTypeListVALVE
    {
    }

    public unsafe partial struct VkMutableDescriptorTypeCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint mutableDescriptorTypeListCount;
        public VkMutableDescriptorTypeListEXT* pMutableDescriptorTypeLists;
        public static VkMutableDescriptorTypeCreateInfoEXT New()
        {
            VkMutableDescriptorTypeCreateInfoEXT ret = new VkMutableDescriptorTypeCreateInfoEXT();
            ret.sType = VkStructureType.MutableDescriptorTypeCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMutableDescriptorTypeCreateInfoVALVE
    {
    }

    public unsafe partial struct VkPhysicalDeviceDepthClipControlFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 depthClipControl;
        public static VkPhysicalDeviceDepthClipControlFeaturesEXT New()
        {
            VkPhysicalDeviceDepthClipControlFeaturesEXT ret = new VkPhysicalDeviceDepthClipControlFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDepthClipControlFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 zeroInitializeDeviceMemory;
        public static VkPhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT New()
        {
            VkPhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT ret = new VkPhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceZeroInitializeDeviceMemoryFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 deviceGeneratedCommands;
        public VkBool32 dynamicGeneratedPipelineLayout;
        public static VkPhysicalDeviceDeviceGeneratedCommandsFeaturesEXT New()
        {
            VkPhysicalDeviceDeviceGeneratedCommandsFeaturesEXT ret = new VkPhysicalDeviceDeviceGeneratedCommandsFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxIndirectPipelineCount;
        public uint maxIndirectShaderObjectCount;
        public uint maxIndirectSequenceCount;
        public uint maxIndirectCommandsTokenCount;
        public uint maxIndirectCommandsTokenOffset;
        public uint maxIndirectCommandsIndirectStride;
        public VkIndirectCommandsInputModeFlagsEXT supportedIndirectCommandsInputModes;
        public VkShaderStageFlags supportedIndirectCommandsShaderStages;
        public VkShaderStageFlags supportedIndirectCommandsShaderStagesPipelineBinding;
        public VkShaderStageFlags supportedIndirectCommandsShaderStagesShaderBinding;
        public VkBool32 deviceGeneratedCommandsTransformFeedback;
        public VkBool32 deviceGeneratedCommandsMultiDrawIndirectCount;
        public static VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT New()
        {
            VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT ret = new VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkGeneratedCommandsPipelineInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipeline pipeline;
        public static VkGeneratedCommandsPipelineInfoEXT New()
        {
            VkGeneratedCommandsPipelineInfoEXT ret = new VkGeneratedCommandsPipelineInfoEXT();
            ret.sType = VkStructureType.GeneratedCommandsPipelineInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkGeneratedCommandsShaderInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderCount;
        public VkShaderEXT* pShaders;
        public static VkGeneratedCommandsShaderInfoEXT New()
        {
            VkGeneratedCommandsShaderInfoEXT ret = new VkGeneratedCommandsShaderInfoEXT();
            ret.sType = VkStructureType.GeneratedCommandsShaderInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkGeneratedCommandsMemoryRequirementsInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndirectExecutionSetEXT indirectExecutionSet;
        public VkIndirectCommandsLayoutEXT indirectCommandsLayout;
        public uint maxSequenceCount;
        public uint maxDrawCount;
        public static VkGeneratedCommandsMemoryRequirementsInfoEXT New()
        {
            VkGeneratedCommandsMemoryRequirementsInfoEXT ret = new VkGeneratedCommandsMemoryRequirementsInfoEXT();
            ret.sType = VkStructureType.GeneratedCommandsMemoryRequirementsInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkIndirectExecutionSetPipelineInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipeline initialPipeline;
        public uint maxPipelineCount;
        public static VkIndirectExecutionSetPipelineInfoEXT New()
        {
            VkIndirectExecutionSetPipelineInfoEXT ret = new VkIndirectExecutionSetPipelineInfoEXT();
            ret.sType = VkStructureType.IndirectExecutionSetPipelineInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkIndirectExecutionSetShaderLayoutInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint setLayoutCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public static VkIndirectExecutionSetShaderLayoutInfoEXT New()
        {
            VkIndirectExecutionSetShaderLayoutInfoEXT ret = new VkIndirectExecutionSetShaderLayoutInfoEXT();
            ret.sType = VkStructureType.IndirectExecutionSetShaderLayoutInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkIndirectExecutionSetShaderInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderCount;
        public VkShaderEXT* pInitialShaders;
        public VkIndirectExecutionSetShaderLayoutInfoEXT* pSetLayoutInfos;
        public uint maxShaderCount;
        public uint pushConstantRangeCount;
        public VkPushConstantRange* pPushConstantRanges;
        public static VkIndirectExecutionSetShaderInfoEXT New()
        {
            VkIndirectExecutionSetShaderInfoEXT ret = new VkIndirectExecutionSetShaderInfoEXT();
            ret.sType = VkStructureType.IndirectExecutionSetShaderInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkIndirectExecutionSetCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndirectExecutionSetInfoTypeEXT type;
        public VkIndirectExecutionSetInfoEXT info;
        public static VkIndirectExecutionSetCreateInfoEXT New()
        {
            VkIndirectExecutionSetCreateInfoEXT ret = new VkIndirectExecutionSetCreateInfoEXT();
            ret.sType = VkStructureType.IndirectExecutionSetCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkGeneratedCommandsInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags shaderStages;
        public VkIndirectExecutionSetEXT indirectExecutionSet;
        public VkIndirectCommandsLayoutEXT indirectCommandsLayout;
        public ulong indirectAddress;
        public ulong indirectAddressSize;
        public ulong preprocessAddress;
        public ulong preprocessSize;
        public uint maxSequenceCount;
        public ulong sequenceCountAddress;
        public uint maxDrawCount;
        public static VkGeneratedCommandsInfoEXT New()
        {
            VkGeneratedCommandsInfoEXT ret = new VkGeneratedCommandsInfoEXT();
            ret.sType = VkStructureType.GeneratedCommandsInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkWriteIndirectExecutionSetPipelineEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint index;
        public VkPipeline pipeline;
        public static VkWriteIndirectExecutionSetPipelineEXT New()
        {
            VkWriteIndirectExecutionSetPipelineEXT ret = new VkWriteIndirectExecutionSetPipelineEXT();
            ret.sType = VkStructureType.WriteIndirectExecutionSetPipelineEXT;
            return ret;
        }
    }

    public unsafe partial struct VkWriteIndirectExecutionSetShaderEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint index;
        public VkShaderEXT shader;
        public static VkWriteIndirectExecutionSetShaderEXT New()
        {
            VkWriteIndirectExecutionSetShaderEXT ret = new VkWriteIndirectExecutionSetShaderEXT();
            ret.sType = VkStructureType.WriteIndirectExecutionSetShaderEXT;
            return ret;
        }
    }

    public unsafe partial struct VkIndirectCommandsLayoutCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndirectCommandsLayoutUsageFlagsEXT flags;
        public VkShaderStageFlags shaderStages;
        public uint indirectStride;
        public VkPipelineLayout pipelineLayout;
        public uint tokenCount;
        public VkIndirectCommandsLayoutTokenEXT* pTokens;
        public static VkIndirectCommandsLayoutCreateInfoEXT New()
        {
            VkIndirectCommandsLayoutCreateInfoEXT ret = new VkIndirectCommandsLayoutCreateInfoEXT();
            ret.sType = VkStructureType.IndirectCommandsLayoutCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkIndirectCommandsLayoutTokenEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndirectCommandsTokenTypeEXT type;
        public VkIndirectCommandsTokenDataEXT data;
        public uint offset;
        public static VkIndirectCommandsLayoutTokenEXT New()
        {
            VkIndirectCommandsLayoutTokenEXT ret = new VkIndirectCommandsLayoutTokenEXT();
            ret.sType = VkStructureType.IndirectCommandsLayoutTokenEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDrawIndirectCountIndirectCommandEXT
    {
        public ulong bufferAddress;
        public uint stride;
        public uint commandCount;
    }

    public unsafe partial struct VkIndirectCommandsVertexBufferTokenEXT
    {
        public uint vertexBindingUnit;
    }

    public unsafe partial struct VkBindVertexBufferIndirectCommandEXT
    {
        public ulong bufferAddress;
        public uint size;
        public uint stride;
    }

    public unsafe partial struct VkIndirectCommandsIndexBufferTokenEXT
    {
        public VkIndirectCommandsInputModeFlagsEXT mode;
    }

    public unsafe partial struct VkBindIndexBufferIndirectCommandEXT
    {
        public ulong bufferAddress;
        public uint size;
        public VkIndexType indexType;
    }

    public unsafe partial struct VkIndirectCommandsPushConstantTokenEXT
    {
        public VkPushConstantRange updateRange;
    }

    public unsafe partial struct VkIndirectCommandsExecutionSetTokenEXT
    {
        public VkIndirectExecutionSetInfoTypeEXT type;
        public VkShaderStageFlags shaderStages;
    }

    public unsafe partial struct VkPipelineViewportDepthClipControlCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 negativeOneToOne;
        public static VkPipelineViewportDepthClipControlCreateInfoEXT New()
        {
            VkPipelineViewportDepthClipControlCreateInfoEXT ret = new VkPipelineViewportDepthClipControlCreateInfoEXT();
            ret.sType = VkStructureType.PipelineViewportDepthClipControlCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDepthClampControlFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 depthClampControl;
        public static VkPhysicalDeviceDepthClampControlFeaturesEXT New()
        {
            VkPhysicalDeviceDepthClampControlFeaturesEXT ret = new VkPhysicalDeviceDepthClampControlFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDepthClampControlFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineViewportDepthClampControlCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDepthClampModeEXT depthClampMode;
        public VkDepthClampRangeEXT* pDepthClampRange;
        public static VkPipelineViewportDepthClampControlCreateInfoEXT New()
        {
            VkPipelineViewportDepthClampControlCreateInfoEXT ret = new VkPipelineViewportDepthClampControlCreateInfoEXT();
            ret.sType = VkStructureType.PipelineViewportDepthClampControlCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 vertexInputDynamicState;
        public static VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT New()
        {
            VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT ret = new VkPhysicalDeviceVertexInputDynamicStateFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceVertexInputDynamicStateFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalMemoryRDMAFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 externalMemoryRDMA;
        public static VkPhysicalDeviceExternalMemoryRDMAFeaturesNV New()
        {
            VkPhysicalDeviceExternalMemoryRDMAFeaturesNV ret = new VkPhysicalDeviceExternalMemoryRDMAFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceExternalMemoryRdmaFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderRelaxedExtendedInstruction;
        public static VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR New()
        {
            VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR ret = new VkPhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceShaderRelaxedExtendedInstructionFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVertexInputBindingDescription2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint binding;
        public uint stride;
        public VkVertexInputRate inputRate;
        public uint divisor;
        public static VkVertexInputBindingDescription2EXT New()
        {
            VkVertexInputBindingDescription2EXT ret = new VkVertexInputBindingDescription2EXT();
            ret.sType = VkStructureType.VertexInputBindingDescription2EXT;
            return ret;
        }
    }

    public unsafe partial struct VkVertexInputAttributeDescription2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint location;
        public uint binding;
        public VkFormat format;
        public uint offset;
        public static VkVertexInputAttributeDescription2EXT New()
        {
            VkVertexInputAttributeDescription2EXT ret = new VkVertexInputAttributeDescription2EXT();
            ret.sType = VkStructureType.VertexInputAttributeDescription2EXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceColorWriteEnableFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 colorWriteEnable;
        public static VkPhysicalDeviceColorWriteEnableFeaturesEXT New()
        {
            VkPhysicalDeviceColorWriteEnableFeaturesEXT ret = new VkPhysicalDeviceColorWriteEnableFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceColorWriteEnableFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineColorWriteCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint attachmentCount;
        public VkBool32* pColorWriteEnables;
        public static VkPipelineColorWriteCreateInfoEXT New()
        {
            VkPipelineColorWriteCreateInfoEXT ret = new VkPipelineColorWriteCreateInfoEXT();
            ret.sType = VkStructureType.PipelineColorWriteCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryBarrier2
    {
        public VkStructureType sType;
        public void* pNext;
        public uint srcStageMask;
        public uint srcAccessMask;
        public uint dstStageMask;
        public uint dstAccessMask;
        public static VkMemoryBarrier2 New()
        {
            VkMemoryBarrier2 ret = new VkMemoryBarrier2();
            ret.sType = VkStructureType.MemoryBarrier2;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryBarrier2KHR
    {
    }

    public unsafe partial struct VkImageMemoryBarrier2
    {
        public VkStructureType sType;
        public void* pNext;
        public uint srcStageMask;
        public uint srcAccessMask;
        public uint dstStageMask;
        public uint dstAccessMask;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkImage image;
        public VkImageSubresourceRange subresourceRange;
        public static VkImageMemoryBarrier2 New()
        {
            VkImageMemoryBarrier2 ret = new VkImageMemoryBarrier2();
            ret.sType = VkStructureType.ImageMemoryBarrier2;
            return ret;
        }
    }

    public unsafe partial struct VkImageMemoryBarrier2KHR
    {
    }

    public unsafe partial struct VkBufferMemoryBarrier2
    {
        public VkStructureType sType;
        public void* pNext;
        public uint srcStageMask;
        public uint srcAccessMask;
        public uint dstStageMask;
        public uint dstAccessMask;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        public static VkBufferMemoryBarrier2 New()
        {
            VkBufferMemoryBarrier2 ret = new VkBufferMemoryBarrier2();
            ret.sType = VkStructureType.BufferMemoryBarrier2;
            return ret;
        }
    }

    public unsafe partial struct VkBufferMemoryBarrier2KHR
    {
    }

    public unsafe partial struct VkMemoryBarrierAccessFlags3KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint srcAccessMask3;
        public uint dstAccessMask3;
        public static VkMemoryBarrierAccessFlags3KHR New()
        {
            VkMemoryBarrierAccessFlags3KHR ret = new VkMemoryBarrierAccessFlags3KHR();
            ret.sType = VkStructureType.MemoryBarrierAccess3KHR;
            return ret;
        }
    }

    public unsafe partial struct VkDependencyInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDependencyFlags dependencyFlags;
        public uint memoryBarrierCount;
        public VkMemoryBarrier2* pMemoryBarriers;
        public uint bufferMemoryBarrierCount;
        public VkBufferMemoryBarrier2* pBufferMemoryBarriers;
        public uint imageMemoryBarrierCount;
        public VkImageMemoryBarrier2* pImageMemoryBarriers;
        public static VkDependencyInfo New()
        {
            VkDependencyInfo ret = new VkDependencyInfo();
            ret.sType = VkStructureType.DependencyInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDependencyInfoKHR
    {
    }

    public unsafe partial struct VkSemaphoreSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public ulong value;
        public uint stageMask;
        public uint deviceIndex;
        public static VkSemaphoreSubmitInfo New()
        {
            VkSemaphoreSubmitInfo ret = new VkSemaphoreSubmitInfo();
            ret.sType = VkStructureType.SemaphoreSubmitInfo;
            return ret;
        }
    }

    public unsafe partial struct VkSemaphoreSubmitInfoKHR
    {
    }

    public unsafe partial struct VkCommandBufferSubmitInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCommandBuffer commandBuffer;
        public uint deviceMask;
        public static VkCommandBufferSubmitInfo New()
        {
            VkCommandBufferSubmitInfo ret = new VkCommandBufferSubmitInfo();
            ret.sType = VkStructureType.CommandBufferSubmitInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferSubmitInfoKHR
    {
    }

    public unsafe partial struct VkSubmitInfo2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubmitFlags flags;
        public uint waitSemaphoreInfoCount;
        public VkSemaphoreSubmitInfo* pWaitSemaphoreInfos;
        public uint commandBufferInfoCount;
        public VkCommandBufferSubmitInfo* pCommandBufferInfos;
        public uint signalSemaphoreInfoCount;
        public VkSemaphoreSubmitInfo* pSignalSemaphoreInfos;
        public static VkSubmitInfo2 New()
        {
            VkSubmitInfo2 ret = new VkSubmitInfo2();
            ret.sType = VkStructureType.SubmitInfo2;
            return ret;
        }
    }

    public unsafe partial struct VkSubmitInfo2KHR
    {
    }

    public unsafe partial struct VkQueueFamilyCheckpointProperties2NV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint checkpointExecutionStageMask;
        public static VkQueueFamilyCheckpointProperties2NV New()
        {
            VkQueueFamilyCheckpointProperties2NV ret = new VkQueueFamilyCheckpointProperties2NV();
            ret.sType = VkStructureType.QueueFamilyCheckpointProperties2NV;
            return ret;
        }
    }

    public unsafe partial struct VkCheckpointData2NV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stage;
        public void* pCheckpointMarker;
        public static VkCheckpointData2NV New()
        {
            VkCheckpointData2NV ret = new VkCheckpointData2NV();
            ret.sType = VkStructureType.CheckpointData2NV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSynchronization2Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 synchronization2;
        public static VkPhysicalDeviceSynchronization2Features New()
        {
            VkPhysicalDeviceSynchronization2Features ret = new VkPhysicalDeviceSynchronization2Features();
            ret.sType = VkStructureType.PhysicalDeviceSynchronization2Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSynchronization2FeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceUnifiedImageLayoutsFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 unifiedImageLayouts;
        public VkBool32 unifiedImageLayoutsVideo;
        public static VkPhysicalDeviceUnifiedImageLayoutsFeaturesKHR New()
        {
            VkPhysicalDeviceUnifiedImageLayoutsFeaturesKHR ret = new VkPhysicalDeviceUnifiedImageLayoutsFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceUnifiedImageLayoutsFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceHostImageCopyFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hostImageCopy;
        public static VkPhysicalDeviceHostImageCopyFeatures New()
        {
            VkPhysicalDeviceHostImageCopyFeatures ret = new VkPhysicalDeviceHostImageCopyFeatures();
            ret.sType = VkStructureType.PhysicalDeviceHostImageCopyFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceHostImageCopyFeaturesEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceHostImageCopyProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public uint copySrcLayoutCount;
        public VkImageLayout* pCopySrcLayouts;
        public uint copyDstLayoutCount;
        public VkImageLayout* pCopyDstLayouts;
        public fixed byte optimalTilingLayoutUUID[(int)VulkanNative.UuidSize];
        public VkBool32 identicalMemoryTypeRequirements;
        public static VkPhysicalDeviceHostImageCopyProperties New()
        {
            VkPhysicalDeviceHostImageCopyProperties ret = new VkPhysicalDeviceHostImageCopyProperties();
            ret.sType = VkStructureType.PhysicalDeviceHostImageCopyProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceHostImageCopyPropertiesEXT
    {
    }

    public unsafe partial struct VkMemoryToImageCopy
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pHostPointer;
        public uint memoryRowLength;
        public uint memoryImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
        public static VkMemoryToImageCopy New()
        {
            VkMemoryToImageCopy ret = new VkMemoryToImageCopy();
            ret.sType = VkStructureType.MemoryToImageCopy;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryToImageCopyEXT
    {
    }

    public unsafe partial struct VkImageToMemoryCopy
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pHostPointer;
        public uint memoryRowLength;
        public uint memoryImageHeight;
        public VkImageSubresourceLayers imageSubresource;
        public VkOffset3D imageOffset;
        public VkExtent3D imageExtent;
        public static VkImageToMemoryCopy New()
        {
            VkImageToMemoryCopy ret = new VkImageToMemoryCopy();
            ret.sType = VkStructureType.ImageToMemoryCopy;
            return ret;
        }
    }

    public unsafe partial struct VkImageToMemoryCopyEXT
    {
    }

    public unsafe partial struct VkCopyMemoryToImageInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkHostImageCopyFlags flags;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkMemoryToImageCopy* pRegions;
        public static VkCopyMemoryToImageInfo New()
        {
            VkCopyMemoryToImageInfo ret = new VkCopyMemoryToImageInfo();
            ret.sType = VkStructureType.CopyMemoryToImageInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCopyMemoryToImageInfoEXT
    {
    }

    public unsafe partial struct VkCopyImageToMemoryInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkHostImageCopyFlags flags;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public uint regionCount;
        public VkImageToMemoryCopy* pRegions;
        public static VkCopyImageToMemoryInfo New()
        {
            VkCopyImageToMemoryInfo ret = new VkCopyImageToMemoryInfo();
            ret.sType = VkStructureType.CopyImageToMemoryInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCopyImageToMemoryInfoEXT
    {
    }

    public unsafe partial struct VkCopyImageToImageInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkHostImageCopyFlags flags;
        public VkImage srcImage;
        public VkImageLayout srcImageLayout;
        public VkImage dstImage;
        public VkImageLayout dstImageLayout;
        public uint regionCount;
        public VkImageCopy2* pRegions;
        public static VkCopyImageToImageInfo New()
        {
            VkCopyImageToImageInfo ret = new VkCopyImageToImageInfo();
            ret.sType = VkStructureType.CopyImageToImageInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCopyImageToImageInfoEXT
    {
    }

    public unsafe partial struct VkHostImageLayoutTransitionInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkImageLayout oldLayout;
        public VkImageLayout newLayout;
        public VkImageSubresourceRange subresourceRange;
        public static VkHostImageLayoutTransitionInfo New()
        {
            VkHostImageLayoutTransitionInfo ret = new VkHostImageLayoutTransitionInfo();
            ret.sType = VkStructureType.HostImageLayoutTransitionInfo;
            return ret;
        }
    }

    public unsafe partial struct VkHostImageLayoutTransitionInfoEXT
    {
    }

    public unsafe partial struct VkSubresourceHostMemcpySize
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong size;
        public static VkSubresourceHostMemcpySize New()
        {
            VkSubresourceHostMemcpySize ret = new VkSubresourceHostMemcpySize();
            ret.sType = VkStructureType.SubresourceHostMemcpySize;
            return ret;
        }
    }

    public unsafe partial struct VkSubresourceHostMemcpySizeEXT
    {
    }

    public unsafe partial struct VkHostImageCopyDevicePerformanceQuery
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 optimalDeviceAccess;
        public VkBool32 identicalMemoryLayout;
        public static VkHostImageCopyDevicePerformanceQuery New()
        {
            VkHostImageCopyDevicePerformanceQuery ret = new VkHostImageCopyDevicePerformanceQuery();
            ret.sType = VkStructureType.HostImageCopyDevicePerformanceQuery;
            return ret;
        }
    }

    public unsafe partial struct VkHostImageCopyDevicePerformanceQueryEXT
    {
    }

    public unsafe partial struct VkPhysicalDeviceVulkanSC10Properties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 deviceNoDynamicHostAllocations;
        public VkBool32 deviceDestroyFreesMemory;
        public VkBool32 commandPoolMultipleCommandBuffersRecording;
        public VkBool32 commandPoolResetCommandBuffer;
        public VkBool32 commandBufferSimultaneousUse;
        public VkBool32 secondaryCommandBufferNullOrImagelessFramebuffer;
        public VkBool32 recycleDescriptorSetMemory;
        public VkBool32 recyclePipelineMemory;
        public uint maxRenderPassSubpasses;
        public uint maxRenderPassDependencies;
        public uint maxSubpassInputAttachments;
        public uint maxSubpassPreserveAttachments;
        public uint maxFramebufferAttachments;
        public uint maxDescriptorSetLayoutBindings;
        public uint maxQueryFaultCount;
        public uint maxCallbackFaultCount;
        public uint maxCommandPoolCommandBuffers;
        public ulong maxCommandBufferSize;
        public static VkPhysicalDeviceVulkanSC10Properties New()
        {
            VkPhysicalDeviceVulkanSC10Properties ret = new VkPhysicalDeviceVulkanSC10Properties();
            ret.sType = VkStructureType.PhysicalDeviceVulkanSc10Properties;
            return ret;
        }
    }

    public unsafe partial struct VkPipelinePoolSize
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong poolEntrySize;
        public uint poolEntryCount;
        public static VkPipelinePoolSize New()
        {
            VkPipelinePoolSize ret = new VkPipelinePoolSize();
            ret.sType = VkStructureType.PipelinePoolSize;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceObjectReservationCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint pipelineCacheCreateInfoCount;
        public VkPipelineCacheCreateInfo* pPipelineCacheCreateInfos;
        public uint pipelinePoolSizeCount;
        public VkPipelinePoolSize* pPipelinePoolSizes;
        public uint semaphoreRequestCount;
        public uint commandBufferRequestCount;
        public uint fenceRequestCount;
        public uint deviceMemoryRequestCount;
        public uint bufferRequestCount;
        public uint imageRequestCount;
        public uint eventRequestCount;
        public uint queryPoolRequestCount;
        public uint bufferViewRequestCount;
        public uint imageViewRequestCount;
        public uint layeredImageViewRequestCount;
        public uint pipelineCacheRequestCount;
        public uint pipelineLayoutRequestCount;
        public uint renderPassRequestCount;
        public uint graphicsPipelineRequestCount;
        public uint computePipelineRequestCount;
        public uint descriptorSetLayoutRequestCount;
        public uint samplerRequestCount;
        public uint descriptorPoolRequestCount;
        public uint descriptorSetRequestCount;
        public uint framebufferRequestCount;
        public uint commandPoolRequestCount;
        public uint samplerYcbcrConversionRequestCount;
        public uint surfaceRequestCount;
        public uint swapchainRequestCount;
        public uint displayModeRequestCount;
        public uint subpassDescriptionRequestCount;
        public uint attachmentDescriptionRequestCount;
        public uint descriptorSetLayoutBindingRequestCount;
        public uint descriptorSetLayoutBindingLimit;
        public uint maxImageViewMipLevels;
        public uint maxImageViewArrayLayers;
        public uint maxLayeredImageViewMipLevels;
        public uint maxOcclusionQueriesPerPool;
        public uint maxPipelineStatisticsQueriesPerPool;
        public uint maxTimestampQueriesPerPool;
        public uint maxImmutableSamplersPerDescriptorSetLayout;
        public static VkDeviceObjectReservationCreateInfo New()
        {
            VkDeviceObjectReservationCreateInfo ret = new VkDeviceObjectReservationCreateInfo();
            ret.sType = VkStructureType.DeviceObjectReservationCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCommandPoolMemoryReservationCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong commandPoolReservedSize;
        public uint commandPoolMaxCommandBuffers;
        public static VkCommandPoolMemoryReservationCreateInfo New()
        {
            VkCommandPoolMemoryReservationCreateInfo ret = new VkCommandPoolMemoryReservationCreateInfo();
            ret.sType = VkStructureType.CommandPoolMemoryReservationCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCommandPoolMemoryConsumption
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong commandPoolAllocated;
        public ulong commandPoolReservedSize;
        public ulong commandBufferAllocated;
        public static VkCommandPoolMemoryConsumption New()
        {
            VkCommandPoolMemoryConsumption ret = new VkCommandPoolMemoryConsumption();
            ret.sType = VkStructureType.CommandPoolMemoryConsumption;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVulkanSC10Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderAtomicInstructions;
        public static VkPhysicalDeviceVulkanSC10Features New()
        {
            VkPhysicalDeviceVulkanSC10Features ret = new VkPhysicalDeviceVulkanSC10Features();
            ret.sType = VkStructureType.PhysicalDeviceVulkanSc10Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 primitivesGeneratedQuery;
        public VkBool32 primitivesGeneratedQueryWithRasterizerDiscard;
        public VkBool32 primitivesGeneratedQueryWithNonZeroStreams;
        public static VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT New()
        {
            VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT ret = new VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDevicePrimitivesGeneratedQueryFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceLegacyDitheringFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 legacyDithering;
        public static VkPhysicalDeviceLegacyDitheringFeaturesEXT New()
        {
            VkPhysicalDeviceLegacyDitheringFeaturesEXT ret = new VkPhysicalDeviceLegacyDitheringFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceLegacyDitheringFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 multisampledRenderToSingleSampled;
        public static VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT New()
        {
            VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT ret = new VkPhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceMultisampledRenderToSingleSampledFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceCapabilitiesPresentId2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 presentId2Supported;
        public static VkSurfaceCapabilitiesPresentId2KHR New()
        {
            VkSurfaceCapabilitiesPresentId2KHR ret = new VkSurfaceCapabilitiesPresentId2KHR();
            ret.sType = VkStructureType.SurfaceCapabilitiesPresentId2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceCapabilitiesPresentWait2KHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 presentWait2Supported;
        public static VkSurfaceCapabilitiesPresentWait2KHR New()
        {
            VkSurfaceCapabilitiesPresentWait2KHR ret = new VkSurfaceCapabilitiesPresentWait2KHR();
            ret.sType = VkStructureType.SurfaceCapabilitiesPresentWait2KHR;
            return ret;
        }
    }

    public unsafe partial struct VkSubpassResolvePerformanceQueryEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 optimal;
        public static VkSubpassResolvePerformanceQueryEXT New()
        {
            VkSubpassResolvePerformanceQueryEXT ret = new VkSubpassResolvePerformanceQueryEXT();
            ret.sType = VkStructureType.SubpassResolvePerformanceQueryEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMultisampledRenderToSingleSampledInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 multisampledRenderToSingleSampledEnable;
        public VkSampleCountFlags rasterizationSamples;
        public static VkMultisampledRenderToSingleSampledInfoEXT New()
        {
            VkMultisampledRenderToSingleSampledInfoEXT ret = new VkMultisampledRenderToSingleSampledInfoEXT();
            ret.sType = VkStructureType.MultisampledRenderToSingleSampledInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePipelineProtectedAccessFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineProtectedAccess;
        public static VkPhysicalDevicePipelineProtectedAccessFeatures New()
        {
            VkPhysicalDevicePipelineProtectedAccessFeatures ret = new VkPhysicalDevicePipelineProtectedAccessFeatures();
            ret.sType = VkStructureType.PhysicalDevicePipelineProtectedAccessFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePipelineProtectedAccessFeaturesEXT
    {
    }

    public unsafe partial struct VkQueueFamilyVideoPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoCodecOperationFlagsKHR videoCodecOperations;
        public static VkQueueFamilyVideoPropertiesKHR New()
        {
            VkQueueFamilyVideoPropertiesKHR ret = new VkQueueFamilyVideoPropertiesKHR();
            ret.sType = VkStructureType.QueueFamilyVideoPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkQueueFamilyQueryResultStatusPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 queryResultStatusSupport;
        public static VkQueueFamilyQueryResultStatusPropertiesKHR New()
        {
            VkQueueFamilyQueryResultStatusPropertiesKHR ret = new VkQueueFamilyQueryResultStatusPropertiesKHR();
            ret.sType = VkStructureType.QueueFamilyQueryResultStatusPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoProfileListInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint profileCount;
        public VkVideoProfileInfoKHR* pProfiles;
        public static VkVideoProfileListInfoKHR New()
        {
            VkVideoProfileListInfoKHR ret = new VkVideoProfileListInfoKHR();
            ret.sType = VkStructureType.VideoProfileListInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVideoFormatInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageUsageFlags imageUsage;
        public static VkPhysicalDeviceVideoFormatInfoKHR New()
        {
            VkPhysicalDeviceVideoFormatInfoKHR ret = new VkPhysicalDeviceVideoFormatInfoKHR();
            ret.sType = VkStructureType.PhysicalDeviceVideoFormatInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoFormatPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public VkComponentMapping componentMapping;
        public VkImageCreateFlags imageCreateFlags;
        public VkImageType imageType;
        public VkImageTiling imageTiling;
        public VkImageUsageFlags imageUsageFlags;
        public static VkVideoFormatPropertiesKHR New()
        {
            VkVideoFormatPropertiesKHR ret = new VkVideoFormatPropertiesKHR();
            ret.sType = VkStructureType.VideoFormatPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeQuantizationMapCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D maxQuantizationMapExtent;
        public static VkVideoEncodeQuantizationMapCapabilitiesKHR New()
        {
            VkVideoEncodeQuantizationMapCapabilitiesKHR ret = new VkVideoEncodeQuantizationMapCapabilitiesKHR();
            ret.sType = VkStructureType.VideoEncodeQuantizationMapCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264QuantizationMapCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int minQpDelta;
        public int maxQpDelta;
        public static VkVideoEncodeH264QuantizationMapCapabilitiesKHR New()
        {
            VkVideoEncodeH264QuantizationMapCapabilitiesKHR ret = new VkVideoEncodeH264QuantizationMapCapabilitiesKHR();
            ret.sType = VkStructureType.VideoEncodeH264QuantizationMapCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265QuantizationMapCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int minQpDelta;
        public int maxQpDelta;
        public static VkVideoEncodeH265QuantizationMapCapabilitiesKHR New()
        {
            VkVideoEncodeH265QuantizationMapCapabilitiesKHR ret = new VkVideoEncodeH265QuantizationMapCapabilitiesKHR();
            ret.sType = VkStructureType.VideoEncodeH265QuantizationMapCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeAV1QuantizationMapCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int minQIndexDelta;
        public int maxQIndexDelta;
        public static VkVideoEncodeAV1QuantizationMapCapabilitiesKHR New()
        {
            VkVideoEncodeAV1QuantizationMapCapabilitiesKHR ret = new VkVideoEncodeAV1QuantizationMapCapabilitiesKHR();
            ret.sType = VkStructureType.VideoEncodeAv1QuantizationMapCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoFormatQuantizationMapPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D quantizationMapTexelSize;
        public static VkVideoFormatQuantizationMapPropertiesKHR New()
        {
            VkVideoFormatQuantizationMapPropertiesKHR ret = new VkVideoFormatQuantizationMapPropertiesKHR();
            ret.sType = VkStructureType.VideoFormatQuantizationMapPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoFormatH265QuantizationMapPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH265CtbSizeFlagsKHR compatibleCtbSizes;
        public static VkVideoFormatH265QuantizationMapPropertiesKHR New()
        {
            VkVideoFormatH265QuantizationMapPropertiesKHR ret = new VkVideoFormatH265QuantizationMapPropertiesKHR();
            ret.sType = VkStructureType.VideoFormatH265QuantizationMapPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoFormatAV1QuantizationMapPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeAV1SuperblockSizeFlagsKHR compatibleSuperblockSizes;
        public static VkVideoFormatAV1QuantizationMapPropertiesKHR New()
        {
            VkVideoFormatAV1QuantizationMapPropertiesKHR ret = new VkVideoFormatAV1QuantizationMapPropertiesKHR();
            ret.sType = VkStructureType.VideoFormatAv1QuantizationMapPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoCodecOperationFlagsKHR videoCodecOperation;
        public VkVideoChromaSubsamplingFlagsKHR chromaSubsampling;
        public VkVideoComponentBitDepthFlagsKHR lumaBitDepth;
        public VkVideoComponentBitDepthFlagsKHR chromaBitDepth;
        public static VkVideoProfileInfoKHR New()
        {
            VkVideoProfileInfoKHR ret = new VkVideoProfileInfoKHR();
            ret.sType = VkStructureType.VideoProfileInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoCapabilityFlagsKHR flags;
        public ulong minBitstreamBufferOffsetAlignment;
        public ulong minBitstreamBufferSizeAlignment;
        public VkExtent2D pictureAccessGranularity;
        public VkExtent2D minCodedExtent;
        public VkExtent2D maxCodedExtent;
        public uint maxDpbSlots;
        public uint maxActiveReferencePictures;
        public VkExtensionProperties stdHeaderVersion;
        public static VkVideoCapabilitiesKHR New()
        {
            VkVideoCapabilitiesKHR ret = new VkVideoCapabilitiesKHR();
            ret.sType = VkStructureType.VideoCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoSessionMemoryRequirementsKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryBindIndex;
        public VkMemoryRequirements memoryRequirements;
        public static VkVideoSessionMemoryRequirementsKHR New()
        {
            VkVideoSessionMemoryRequirementsKHR ret = new VkVideoSessionMemoryRequirementsKHR();
            ret.sType = VkStructureType.VideoSessionMemoryRequirementsKHR;
            return ret;
        }
    }

    public unsafe partial struct VkBindVideoSessionMemoryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryBindIndex;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public ulong memorySize;
        public static VkBindVideoSessionMemoryInfoKHR New()
        {
            VkBindVideoSessionMemoryInfoKHR ret = new VkBindVideoSessionMemoryInfoKHR();
            ret.sType = VkStructureType.BindVideoSessionMemoryInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoPictureResourceInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOffset2D codedOffset;
        public VkExtent2D codedExtent;
        public uint baseArrayLayer;
        public VkImageView imageViewBinding;
        public static VkVideoPictureResourceInfoKHR New()
        {
            VkVideoPictureResourceInfoKHR ret = new VkVideoPictureResourceInfoKHR();
            ret.sType = VkStructureType.VideoPictureResourceInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoReferenceSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int slotIndex;
        public VkVideoPictureResourceInfoKHR* pPictureResource;
        public static VkVideoReferenceSlotInfoKHR New()
        {
            VkVideoReferenceSlotInfoKHR ret = new VkVideoReferenceSlotInfoKHR();
            ret.sType = VkStructureType.VideoReferenceSlotInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoDecodeCapabilityFlagsKHR flags;
        public static VkVideoDecodeCapabilitiesKHR New()
        {
            VkVideoDecodeCapabilitiesKHR ret = new VkVideoDecodeCapabilitiesKHR();
            ret.sType = VkStructureType.VideoDecodeCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeUsageInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoDecodeUsageFlagsKHR videoUsageHints;
        public static VkVideoDecodeUsageInfoKHR New()
        {
            VkVideoDecodeUsageInfoKHR ret = new VkVideoDecodeUsageInfoKHR();
            ret.sType = VkStructureType.VideoDecodeUsageInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkBuffer srcBuffer;
        public ulong srcBufferOffset;
        public ulong srcBufferRange;
        public VkVideoPictureResourceInfoKHR dstPictureResource;
        public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
        public uint referenceSlotCount;
        public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
        public static VkVideoDecodeInfoKHR New()
        {
            VkVideoDecodeInfoKHR ret = new VkVideoDecodeInfoKHR();
            ret.sType = VkStructureType.VideoDecodeInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVideoMaintenance1FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 videoMaintenance1;
        public static VkPhysicalDeviceVideoMaintenance1FeaturesKHR New()
        {
            VkPhysicalDeviceVideoMaintenance1FeaturesKHR ret = new VkPhysicalDeviceVideoMaintenance1FeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceVideoMaintenance1FeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVideoMaintenance2FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 videoMaintenance2;
        public static VkPhysicalDeviceVideoMaintenance2FeaturesKHR New()
        {
            VkPhysicalDeviceVideoMaintenance2FeaturesKHR ret = new VkPhysicalDeviceVideoMaintenance2FeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceVideoMaintenance2FeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoInlineQueryInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueryPool queryPool;
        public uint firstQuery;
        public uint queryCount;
        public static VkVideoInlineQueryInfoKHR New()
        {
            VkVideoInlineQueryInfoKHR ret = new VkVideoInlineQueryInfoKHR();
            ret.sType = VkStructureType.VideoInlineQueryInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH264ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int stdProfileIdc;
        public VkVideoDecodeH264PictureLayoutFlagsKHR pictureLayout;
        public static VkVideoDecodeH264ProfileInfoKHR New()
        {
            VkVideoDecodeH264ProfileInfoKHR ret = new VkVideoDecodeH264ProfileInfoKHR();
            ret.sType = VkStructureType.VideoDecodeH264ProfileInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH264CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int maxLevelIdc;
        public VkOffset2D fieldOffsetGranularity;
        public static VkVideoDecodeH264CapabilitiesKHR New()
        {
            VkVideoDecodeH264CapabilitiesKHR ret = new VkVideoDecodeH264CapabilitiesKHR();
            ret.sType = VkStructureType.VideoDecodeH264CapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH264SessionParametersAddInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stdSPSCount;
        public IntPtr* pStdSPSs;
        public uint stdPPSCount;
        public IntPtr* pStdPPSs;
        public static VkVideoDecodeH264SessionParametersAddInfoKHR New()
        {
            VkVideoDecodeH264SessionParametersAddInfoKHR ret = new VkVideoDecodeH264SessionParametersAddInfoKHR();
            ret.sType = VkStructureType.VideoDecodeH264SessionParametersAddInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH264SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoDecodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
        public static VkVideoDecodeH264SessionParametersCreateInfoKHR New()
        {
            VkVideoDecodeH264SessionParametersCreateInfoKHR ret = new VkVideoDecodeH264SessionParametersCreateInfoKHR();
            ret.sType = VkStructureType.VideoDecodeH264SessionParametersCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH264InlineSessionParametersInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdSPS;
        public IntPtr* pStdPPS;
        public static VkVideoDecodeH264InlineSessionParametersInfoKHR New()
        {
            VkVideoDecodeH264InlineSessionParametersInfoKHR ret = new VkVideoDecodeH264InlineSessionParametersInfoKHR();
            ret.sType = VkStructureType.VideoDecodeH264InlineSessionParametersInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH264PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdPictureInfo;
        public uint sliceCount;
        public uint* pSliceOffsets;
        public static VkVideoDecodeH264PictureInfoKHR New()
        {
            VkVideoDecodeH264PictureInfoKHR ret = new VkVideoDecodeH264PictureInfoKHR();
            ret.sType = VkStructureType.VideoDecodeH264PictureInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH264DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdReferenceInfo;
        public static VkVideoDecodeH264DpbSlotInfoKHR New()
        {
            VkVideoDecodeH264DpbSlotInfoKHR ret = new VkVideoDecodeH264DpbSlotInfoKHR();
            ret.sType = VkStructureType.VideoDecodeH264DpbSlotInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH265ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int stdProfileIdc;
        public static VkVideoDecodeH265ProfileInfoKHR New()
        {
            VkVideoDecodeH265ProfileInfoKHR ret = new VkVideoDecodeH265ProfileInfoKHR();
            ret.sType = VkStructureType.VideoDecodeH265ProfileInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH265CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int maxLevelIdc;
        public static VkVideoDecodeH265CapabilitiesKHR New()
        {
            VkVideoDecodeH265CapabilitiesKHR ret = new VkVideoDecodeH265CapabilitiesKHR();
            ret.sType = VkStructureType.VideoDecodeH265CapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH265SessionParametersAddInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stdVPSCount;
        public IntPtr* pStdVPSs;
        public uint stdSPSCount;
        public IntPtr* pStdSPSs;
        public uint stdPPSCount;
        public IntPtr* pStdPPSs;
        public static VkVideoDecodeH265SessionParametersAddInfoKHR New()
        {
            VkVideoDecodeH265SessionParametersAddInfoKHR ret = new VkVideoDecodeH265SessionParametersAddInfoKHR();
            ret.sType = VkStructureType.VideoDecodeH265SessionParametersAddInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH265SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxStdVPSCount;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoDecodeH265SessionParametersAddInfoKHR* pParametersAddInfo;
        public static VkVideoDecodeH265SessionParametersCreateInfoKHR New()
        {
            VkVideoDecodeH265SessionParametersCreateInfoKHR ret = new VkVideoDecodeH265SessionParametersCreateInfoKHR();
            ret.sType = VkStructureType.VideoDecodeH265SessionParametersCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH265InlineSessionParametersInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdVPS;
        public IntPtr* pStdSPS;
        public IntPtr* pStdPPS;
        public static VkVideoDecodeH265InlineSessionParametersInfoKHR New()
        {
            VkVideoDecodeH265InlineSessionParametersInfoKHR ret = new VkVideoDecodeH265InlineSessionParametersInfoKHR();
            ret.sType = VkStructureType.VideoDecodeH265InlineSessionParametersInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH265PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdPictureInfo;
        public uint sliceSegmentCount;
        public uint* pSliceSegmentOffsets;
        public static VkVideoDecodeH265PictureInfoKHR New()
        {
            VkVideoDecodeH265PictureInfoKHR ret = new VkVideoDecodeH265PictureInfoKHR();
            ret.sType = VkStructureType.VideoDecodeH265PictureInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeH265DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdReferenceInfo;
        public static VkVideoDecodeH265DpbSlotInfoKHR New()
        {
            VkVideoDecodeH265DpbSlotInfoKHR ret = new VkVideoDecodeH265DpbSlotInfoKHR();
            ret.sType = VkStructureType.VideoDecodeH265DpbSlotInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVideoDecodeVP9FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 videoDecodeVP9;
        public static VkPhysicalDeviceVideoDecodeVP9FeaturesKHR New()
        {
            VkPhysicalDeviceVideoDecodeVP9FeaturesKHR ret = new VkPhysicalDeviceVideoDecodeVP9FeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceVideoDecodeVp9FeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeVP9ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int stdProfile;
        public static VkVideoDecodeVP9ProfileInfoKHR New()
        {
            VkVideoDecodeVP9ProfileInfoKHR ret = new VkVideoDecodeVP9ProfileInfoKHR();
            ret.sType = VkStructureType.VideoDecodeVp9ProfileInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeVP9CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int maxLevel;
        public static VkVideoDecodeVP9CapabilitiesKHR New()
        {
            VkVideoDecodeVP9CapabilitiesKHR ret = new VkVideoDecodeVP9CapabilitiesKHR();
            ret.sType = VkStructureType.VideoDecodeVp9CapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeVP9PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdPictureInfo;
        public fixed int referenceNameSlotIndices[(int)VulkanNative.MaxVideoVp9ReferencesPerFrameKHR];
        public uint uncompressedHeaderOffset;
        public uint compressedHeaderOffset;
        public uint tilesOffset;
        public static VkVideoDecodeVP9PictureInfoKHR New()
        {
            VkVideoDecodeVP9PictureInfoKHR ret = new VkVideoDecodeVP9PictureInfoKHR();
            ret.sType = VkStructureType.VideoDecodeVp9PictureInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeAV1ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr stdProfile;
        public VkBool32 filmGrainSupport;
        public static VkVideoDecodeAV1ProfileInfoKHR New()
        {
            VkVideoDecodeAV1ProfileInfoKHR ret = new VkVideoDecodeAV1ProfileInfoKHR();
            ret.sType = VkStructureType.VideoDecodeAv1ProfileInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeAV1CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int maxLevel;
        public static VkVideoDecodeAV1CapabilitiesKHR New()
        {
            VkVideoDecodeAV1CapabilitiesKHR ret = new VkVideoDecodeAV1CapabilitiesKHR();
            ret.sType = VkStructureType.VideoDecodeAv1CapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeAV1SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdSequenceHeader;
        public static VkVideoDecodeAV1SessionParametersCreateInfoKHR New()
        {
            VkVideoDecodeAV1SessionParametersCreateInfoKHR ret = new VkVideoDecodeAV1SessionParametersCreateInfoKHR();
            ret.sType = VkStructureType.VideoDecodeAv1SessionParametersCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeAV1InlineSessionParametersInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdSequenceHeader;
        public static VkVideoDecodeAV1InlineSessionParametersInfoKHR New()
        {
            VkVideoDecodeAV1InlineSessionParametersInfoKHR ret = new VkVideoDecodeAV1InlineSessionParametersInfoKHR();
            ret.sType = VkStructureType.VideoDecodeAv1InlineSessionParametersInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeAV1PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdPictureInfo;
        public fixed int referenceNameSlotIndices[(int)VulkanNative.MaxVideoAv1ReferencesPerFrameKHR];
        public uint frameHeaderOffset;
        public uint tileCount;
        public uint* pTileOffsets;
        public uint* pTileSizes;
        public static VkVideoDecodeAV1PictureInfoKHR New()
        {
            VkVideoDecodeAV1PictureInfoKHR ret = new VkVideoDecodeAV1PictureInfoKHR();
            ret.sType = VkStructureType.VideoDecodeAv1PictureInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoDecodeAV1DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdReferenceInfo;
        public static VkVideoDecodeAV1DpbSlotInfoKHR New()
        {
            VkVideoDecodeAV1DpbSlotInfoKHR ret = new VkVideoDecodeAV1DpbSlotInfoKHR();
            ret.sType = VkStructureType.VideoDecodeAv1DpbSlotInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoSessionCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint queueFamilyIndex;
        public VkVideoSessionCreateFlagsKHR flags;
        public VkVideoProfileInfoKHR* pVideoProfile;
        public VkFormat pictureFormat;
        public VkExtent2D maxCodedExtent;
        public VkFormat referencePictureFormat;
        public uint maxDpbSlots;
        public uint maxActiveReferencePictures;
        public VkExtensionProperties* pStdHeaderVersion;
        public static VkVideoSessionCreateInfoKHR New()
        {
            VkVideoSessionCreateInfoKHR ret = new VkVideoSessionCreateInfoKHR();
            ret.sType = VkStructureType.VideoSessionCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoSessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoSessionParametersCreateFlagsKHR flags;
        public VkVideoSessionParametersKHR videoSessionParametersTemplate;
        public VkVideoSessionKHR videoSession;
        public static VkVideoSessionParametersCreateInfoKHR New()
        {
            VkVideoSessionParametersCreateInfoKHR ret = new VkVideoSessionParametersCreateInfoKHR();
            ret.sType = VkStructureType.VideoSessionParametersCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoSessionParametersUpdateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint updateSequenceCount;
        public static VkVideoSessionParametersUpdateInfoKHR New()
        {
            VkVideoSessionParametersUpdateInfoKHR ret = new VkVideoSessionParametersUpdateInfoKHR();
            ret.sType = VkStructureType.VideoSessionParametersUpdateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeSessionParametersGetInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoSessionParametersKHR videoSessionParameters;
        public static VkVideoEncodeSessionParametersGetInfoKHR New()
        {
            VkVideoEncodeSessionParametersGetInfoKHR ret = new VkVideoEncodeSessionParametersGetInfoKHR();
            ret.sType = VkStructureType.VideoEncodeSessionParametersGetInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeSessionParametersFeedbackInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hasOverrides;
        public static VkVideoEncodeSessionParametersFeedbackInfoKHR New()
        {
            VkVideoEncodeSessionParametersFeedbackInfoKHR ret = new VkVideoEncodeSessionParametersFeedbackInfoKHR();
            ret.sType = VkStructureType.VideoEncodeSessionParametersFeedbackInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoBeginCodingInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkVideoSessionKHR videoSession;
        public VkVideoSessionParametersKHR videoSessionParameters;
        public uint referenceSlotCount;
        public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
        public static VkVideoBeginCodingInfoKHR New()
        {
            VkVideoBeginCodingInfoKHR ret = new VkVideoBeginCodingInfoKHR();
            ret.sType = VkStructureType.VideoBeginCodingInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEndCodingInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public static VkVideoEndCodingInfoKHR New()
        {
            VkVideoEndCodingInfoKHR ret = new VkVideoEndCodingInfoKHR();
            ret.sType = VkStructureType.VideoEndCodingInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoCodingControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoCodingControlFlagsKHR flags;
        public static VkVideoCodingControlInfoKHR New()
        {
            VkVideoCodingControlInfoKHR ret = new VkVideoCodingControlInfoKHR();
            ret.sType = VkStructureType.VideoCodingControlInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeUsageInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeUsageFlagsKHR videoUsageHints;
        public VkVideoEncodeContentFlagsKHR videoContentHints;
        public VkVideoEncodeTuningModeKHR tuningMode;
        public static VkVideoEncodeUsageInfoKHR New()
        {
            VkVideoEncodeUsageInfoKHR ret = new VkVideoEncodeUsageInfoKHR();
            ret.sType = VkStructureType.VideoEncodeUsageInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeFlagsKHR flags;
        public VkBuffer dstBuffer;
        public ulong dstBufferOffset;
        public ulong dstBufferRange;
        public VkVideoPictureResourceInfoKHR srcPictureResource;
        public VkVideoReferenceSlotInfoKHR* pSetupReferenceSlot;
        public uint referenceSlotCount;
        public VkVideoReferenceSlotInfoKHR* pReferenceSlots;
        public uint precedingExternallyEncodedBytes;
        public static VkVideoEncodeInfoKHR New()
        {
            VkVideoEncodeInfoKHR ret = new VkVideoEncodeInfoKHR();
            ret.sType = VkStructureType.VideoEncodeInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeQuantizationMapInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView quantizationMap;
        public VkExtent2D quantizationMapExtent;
        public static VkVideoEncodeQuantizationMapInfoKHR New()
        {
            VkVideoEncodeQuantizationMapInfoKHR ret = new VkVideoEncodeQuantizationMapInfoKHR();
            ret.sType = VkStructureType.VideoEncodeQuantizationMapInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeQuantizationMapSessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D quantizationMapTexelSize;
        public static VkVideoEncodeQuantizationMapSessionParametersCreateInfoKHR New()
        {
            VkVideoEncodeQuantizationMapSessionParametersCreateInfoKHR ret = new VkVideoEncodeQuantizationMapSessionParametersCreateInfoKHR();
            ret.sType = VkStructureType.VideoEncodeQuantizationMapSessionParametersCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVideoEncodeQuantizationMapFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 videoEncodeQuantizationMap;
        public static VkPhysicalDeviceVideoEncodeQuantizationMapFeaturesKHR New()
        {
            VkPhysicalDeviceVideoEncodeQuantizationMapFeaturesKHR ret = new VkPhysicalDeviceVideoEncodeQuantizationMapFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceVideoEncodeQuantizationMapFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkQueryPoolVideoEncodeFeedbackCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeFeedbackFlagsKHR encodeFeedbackFlags;
        public static VkQueryPoolVideoEncodeFeedbackCreateInfoKHR New()
        {
            VkQueryPoolVideoEncodeFeedbackCreateInfoKHR ret = new VkQueryPoolVideoEncodeFeedbackCreateInfoKHR();
            ret.sType = VkStructureType.QueryPoolVideoEncodeFeedbackCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeQualityLevelInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint qualityLevel;
        public static VkVideoEncodeQualityLevelInfoKHR New()
        {
            VkVideoEncodeQualityLevelInfoKHR ret = new VkVideoEncodeQualityLevelInfoKHR();
            ret.sType = VkStructureType.VideoEncodeQualityLevelInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoProfileInfoKHR* pVideoProfile;
        public uint qualityLevel;
        public static VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR New()
        {
            VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR ret = new VkPhysicalDeviceVideoEncodeQualityLevelInfoKHR();
            ret.sType = VkStructureType.PhysicalDeviceVideoEncodeQualityLevelInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeQualityLevelPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeRateControlModeFlagsKHR preferredRateControlMode;
        public uint preferredRateControlLayerCount;
        public static VkVideoEncodeQualityLevelPropertiesKHR New()
        {
            VkVideoEncodeQualityLevelPropertiesKHR ret = new VkVideoEncodeQualityLevelPropertiesKHR();
            ret.sType = VkStructureType.VideoEncodeQualityLevelPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeRateControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkVideoEncodeRateControlModeFlagsKHR rateControlMode;
        public uint layerCount;
        public VkVideoEncodeRateControlLayerInfoKHR* pLayers;
        public uint virtualBufferSizeInMs;
        public uint initialVirtualBufferSizeInMs;
        public static VkVideoEncodeRateControlInfoKHR New()
        {
            VkVideoEncodeRateControlInfoKHR ret = new VkVideoEncodeRateControlInfoKHR();
            ret.sType = VkStructureType.VideoEncodeRateControlInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeRateControlLayerInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong averageBitrate;
        public ulong maxBitrate;
        public uint frameRateNumerator;
        public uint frameRateDenominator;
        public static VkVideoEncodeRateControlLayerInfoKHR New()
        {
            VkVideoEncodeRateControlLayerInfoKHR ret = new VkVideoEncodeRateControlLayerInfoKHR();
            ret.sType = VkStructureType.VideoEncodeRateControlLayerInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeCapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeCapabilityFlagsKHR flags;
        public VkVideoEncodeRateControlModeFlagsKHR rateControlModes;
        public uint maxRateControlLayers;
        public ulong maxBitrate;
        public uint maxQualityLevels;
        public VkExtent2D encodeInputPictureGranularity;
        public VkVideoEncodeFeedbackFlagsKHR supportedEncodeFeedbackFlags;
        public static VkVideoEncodeCapabilitiesKHR New()
        {
            VkVideoEncodeCapabilitiesKHR ret = new VkVideoEncodeCapabilitiesKHR();
            ret.sType = VkStructureType.VideoEncodeCapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH264CapabilityFlagsKHR flags;
        public int maxLevelIdc;
        public uint maxSliceCount;
        public uint maxPPictureL0ReferenceCount;
        public uint maxBPictureL0ReferenceCount;
        public uint maxL1ReferenceCount;
        public uint maxTemporalLayerCount;
        public VkBool32 expectDyadicTemporalLayerPattern;
        public int minQp;
        public int maxQp;
        public VkBool32 prefersGopRemainingFrames;
        public VkBool32 requiresGopRemainingFrames;
        public VkVideoEncodeH264StdFlagsKHR stdSyntaxFlags;
        public static VkVideoEncodeH264CapabilitiesKHR New()
        {
            VkVideoEncodeH264CapabilitiesKHR ret = new VkVideoEncodeH264CapabilitiesKHR();
            ret.sType = VkStructureType.VideoEncodeH264CapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264QualityLevelPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH264RateControlFlagsKHR preferredRateControlFlags;
        public uint preferredGopFrameCount;
        public uint preferredIdrPeriod;
        public uint preferredConsecutiveBFrameCount;
        public uint preferredTemporalLayerCount;
        public VkVideoEncodeH264QpKHR preferredConstantQp;
        public uint preferredMaxL0ReferenceCount;
        public uint preferredMaxL1ReferenceCount;
        public VkBool32 preferredStdEntropyCodingModeFlag;
        public static VkVideoEncodeH264QualityLevelPropertiesKHR New()
        {
            VkVideoEncodeH264QualityLevelPropertiesKHR ret = new VkVideoEncodeH264QualityLevelPropertiesKHR();
            ret.sType = VkStructureType.VideoEncodeH264QualityLevelPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264SessionCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useMaxLevelIdc;
        public int maxLevelIdc;
        public static VkVideoEncodeH264SessionCreateInfoKHR New()
        {
            VkVideoEncodeH264SessionCreateInfoKHR ret = new VkVideoEncodeH264SessionCreateInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH264SessionCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264SessionParametersAddInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stdSPSCount;
        public IntPtr* pStdSPSs;
        public uint stdPPSCount;
        public IntPtr* pStdPPSs;
        public static VkVideoEncodeH264SessionParametersAddInfoKHR New()
        {
            VkVideoEncodeH264SessionParametersAddInfoKHR ret = new VkVideoEncodeH264SessionParametersAddInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH264SessionParametersAddInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoEncodeH264SessionParametersAddInfoKHR* pParametersAddInfo;
        public static VkVideoEncodeH264SessionParametersCreateInfoKHR New()
        {
            VkVideoEncodeH264SessionParametersCreateInfoKHR ret = new VkVideoEncodeH264SessionParametersCreateInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH264SessionParametersCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264SessionParametersGetInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 writeStdSPS;
        public VkBool32 writeStdPPS;
        public uint stdSPSId;
        public uint stdPPSId;
        public static VkVideoEncodeH264SessionParametersGetInfoKHR New()
        {
            VkVideoEncodeH264SessionParametersGetInfoKHR ret = new VkVideoEncodeH264SessionParametersGetInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH264SessionParametersGetInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264SessionParametersFeedbackInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hasStdSPSOverrides;
        public VkBool32 hasStdPPSOverrides;
        public static VkVideoEncodeH264SessionParametersFeedbackInfoKHR New()
        {
            VkVideoEncodeH264SessionParametersFeedbackInfoKHR ret = new VkVideoEncodeH264SessionParametersFeedbackInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH264SessionParametersFeedbackInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdReferenceInfo;
        public static VkVideoEncodeH264DpbSlotInfoKHR New()
        {
            VkVideoEncodeH264DpbSlotInfoKHR ret = new VkVideoEncodeH264DpbSlotInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH264DpbSlotInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint naluSliceEntryCount;
        public VkVideoEncodeH264NaluSliceInfoKHR* pNaluSliceEntries;
        public IntPtr* pStdPictureInfo;
        public VkBool32 generatePrefixNalu;
        public static VkVideoEncodeH264PictureInfoKHR New()
        {
            VkVideoEncodeH264PictureInfoKHR ret = new VkVideoEncodeH264PictureInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH264PictureInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int stdProfileIdc;
        public static VkVideoEncodeH264ProfileInfoKHR New()
        {
            VkVideoEncodeH264ProfileInfoKHR ret = new VkVideoEncodeH264ProfileInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH264ProfileInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264NaluSliceInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int constantQp;
        public IntPtr* pStdSliceHeader;
        public static VkVideoEncodeH264NaluSliceInfoKHR New()
        {
            VkVideoEncodeH264NaluSliceInfoKHR ret = new VkVideoEncodeH264NaluSliceInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH264NaluSliceInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264RateControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH264RateControlFlagsKHR flags;
        public uint gopFrameCount;
        public uint idrPeriod;
        public uint consecutiveBFrameCount;
        public uint temporalLayerCount;
        public static VkVideoEncodeH264RateControlInfoKHR New()
        {
            VkVideoEncodeH264RateControlInfoKHR ret = new VkVideoEncodeH264RateControlInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH264RateControlInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264QpKHR
    {
        public int qpI;
        public int qpP;
        public int qpB;
    }

    public unsafe partial struct VkVideoEncodeH264FrameSizeKHR
    {
        public uint frameISize;
        public uint framePSize;
        public uint frameBSize;
    }

    public unsafe partial struct VkVideoEncodeH264GopRemainingFrameInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useGopRemainingFrames;
        public uint gopRemainingI;
        public uint gopRemainingP;
        public uint gopRemainingB;
        public static VkVideoEncodeH264GopRemainingFrameInfoKHR New()
        {
            VkVideoEncodeH264GopRemainingFrameInfoKHR ret = new VkVideoEncodeH264GopRemainingFrameInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH264GopRemainingFrameInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH264RateControlLayerInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useMinQp;
        public VkVideoEncodeH264QpKHR minQp;
        public VkBool32 useMaxQp;
        public VkVideoEncodeH264QpKHR maxQp;
        public VkBool32 useMaxFrameSize;
        public VkVideoEncodeH264FrameSizeKHR maxFrameSize;
        public static VkVideoEncodeH264RateControlLayerInfoKHR New()
        {
            VkVideoEncodeH264RateControlLayerInfoKHR ret = new VkVideoEncodeH264RateControlLayerInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH264RateControlLayerInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH265CapabilityFlagsKHR flags;
        public int maxLevelIdc;
        public uint maxSliceSegmentCount;
        public VkExtent2D maxTiles;
        public VkVideoEncodeH265CtbSizeFlagsKHR ctbSizes;
        public VkVideoEncodeH265TransformBlockSizeFlagsKHR transformBlockSizes;
        public uint maxPPictureL0ReferenceCount;
        public uint maxBPictureL0ReferenceCount;
        public uint maxL1ReferenceCount;
        public uint maxSubLayerCount;
        public VkBool32 expectDyadicTemporalSubLayerPattern;
        public int minQp;
        public int maxQp;
        public VkBool32 prefersGopRemainingFrames;
        public VkBool32 requiresGopRemainingFrames;
        public VkVideoEncodeH265StdFlagsKHR stdSyntaxFlags;
        public static VkVideoEncodeH265CapabilitiesKHR New()
        {
            VkVideoEncodeH265CapabilitiesKHR ret = new VkVideoEncodeH265CapabilitiesKHR();
            ret.sType = VkStructureType.VideoEncodeH265CapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265QualityLevelPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH265RateControlFlagsKHR preferredRateControlFlags;
        public uint preferredGopFrameCount;
        public uint preferredIdrPeriod;
        public uint preferredConsecutiveBFrameCount;
        public uint preferredSubLayerCount;
        public VkVideoEncodeH265QpKHR preferredConstantQp;
        public uint preferredMaxL0ReferenceCount;
        public uint preferredMaxL1ReferenceCount;
        public static VkVideoEncodeH265QualityLevelPropertiesKHR New()
        {
            VkVideoEncodeH265QualityLevelPropertiesKHR ret = new VkVideoEncodeH265QualityLevelPropertiesKHR();
            ret.sType = VkStructureType.VideoEncodeH265QualityLevelPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265SessionCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useMaxLevelIdc;
        public int maxLevelIdc;
        public static VkVideoEncodeH265SessionCreateInfoKHR New()
        {
            VkVideoEncodeH265SessionCreateInfoKHR ret = new VkVideoEncodeH265SessionCreateInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH265SessionCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265SessionParametersAddInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stdVPSCount;
        public IntPtr* pStdVPSs;
        public uint stdSPSCount;
        public IntPtr* pStdSPSs;
        public uint stdPPSCount;
        public IntPtr* pStdPPSs;
        public static VkVideoEncodeH265SessionParametersAddInfoKHR New()
        {
            VkVideoEncodeH265SessionParametersAddInfoKHR ret = new VkVideoEncodeH265SessionParametersAddInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH265SessionParametersAddInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxStdVPSCount;
        public uint maxStdSPSCount;
        public uint maxStdPPSCount;
        public VkVideoEncodeH265SessionParametersAddInfoKHR* pParametersAddInfo;
        public static VkVideoEncodeH265SessionParametersCreateInfoKHR New()
        {
            VkVideoEncodeH265SessionParametersCreateInfoKHR ret = new VkVideoEncodeH265SessionParametersCreateInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH265SessionParametersCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265SessionParametersGetInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 writeStdVPS;
        public VkBool32 writeStdSPS;
        public VkBool32 writeStdPPS;
        public uint stdVPSId;
        public uint stdSPSId;
        public uint stdPPSId;
        public static VkVideoEncodeH265SessionParametersGetInfoKHR New()
        {
            VkVideoEncodeH265SessionParametersGetInfoKHR ret = new VkVideoEncodeH265SessionParametersGetInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH265SessionParametersGetInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265SessionParametersFeedbackInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hasStdVPSOverrides;
        public VkBool32 hasStdSPSOverrides;
        public VkBool32 hasStdPPSOverrides;
        public static VkVideoEncodeH265SessionParametersFeedbackInfoKHR New()
        {
            VkVideoEncodeH265SessionParametersFeedbackInfoKHR ret = new VkVideoEncodeH265SessionParametersFeedbackInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH265SessionParametersFeedbackInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint naluSliceSegmentEntryCount;
        public VkVideoEncodeH265NaluSliceSegmentInfoKHR* pNaluSliceSegmentEntries;
        public IntPtr* pStdPictureInfo;
        public static VkVideoEncodeH265PictureInfoKHR New()
        {
            VkVideoEncodeH265PictureInfoKHR ret = new VkVideoEncodeH265PictureInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH265PictureInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265NaluSliceSegmentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int constantQp;
        public IntPtr* pStdSliceSegmentHeader;
        public static VkVideoEncodeH265NaluSliceSegmentInfoKHR New()
        {
            VkVideoEncodeH265NaluSliceSegmentInfoKHR ret = new VkVideoEncodeH265NaluSliceSegmentInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH265NaluSliceSegmentInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265RateControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeH265RateControlFlagsKHR flags;
        public uint gopFrameCount;
        public uint idrPeriod;
        public uint consecutiveBFrameCount;
        public uint subLayerCount;
        public static VkVideoEncodeH265RateControlInfoKHR New()
        {
            VkVideoEncodeH265RateControlInfoKHR ret = new VkVideoEncodeH265RateControlInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH265RateControlInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265QpKHR
    {
        public int qpI;
        public int qpP;
        public int qpB;
    }

    public unsafe partial struct VkVideoEncodeH265FrameSizeKHR
    {
        public uint frameISize;
        public uint framePSize;
        public uint frameBSize;
    }

    public unsafe partial struct VkVideoEncodeH265GopRemainingFrameInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useGopRemainingFrames;
        public uint gopRemainingI;
        public uint gopRemainingP;
        public uint gopRemainingB;
        public static VkVideoEncodeH265GopRemainingFrameInfoKHR New()
        {
            VkVideoEncodeH265GopRemainingFrameInfoKHR ret = new VkVideoEncodeH265GopRemainingFrameInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH265GopRemainingFrameInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265RateControlLayerInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useMinQp;
        public VkVideoEncodeH265QpKHR minQp;
        public VkBool32 useMaxQp;
        public VkVideoEncodeH265QpKHR maxQp;
        public VkBool32 useMaxFrameSize;
        public VkVideoEncodeH265FrameSizeKHR maxFrameSize;
        public static VkVideoEncodeH265RateControlLayerInfoKHR New()
        {
            VkVideoEncodeH265RateControlLayerInfoKHR ret = new VkVideoEncodeH265RateControlLayerInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH265RateControlLayerInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public int stdProfileIdc;
        public static VkVideoEncodeH265ProfileInfoKHR New()
        {
            VkVideoEncodeH265ProfileInfoKHR ret = new VkVideoEncodeH265ProfileInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH265ProfileInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeH265DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdReferenceInfo;
        public static VkVideoEncodeH265DpbSlotInfoKHR New()
        {
            VkVideoEncodeH265DpbSlotInfoKHR ret = new VkVideoEncodeH265DpbSlotInfoKHR();
            ret.sType = VkStructureType.VideoEncodeH265DpbSlotInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeAV1CapabilitiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeAV1CapabilityFlagsKHR flags;
        public int maxLevel;
        public VkExtent2D codedPictureAlignment;
        public VkExtent2D maxTiles;
        public VkExtent2D minTileSize;
        public VkExtent2D maxTileSize;
        public VkVideoEncodeAV1SuperblockSizeFlagsKHR superblockSizes;
        public uint maxSingleReferenceCount;
        public uint singleReferenceNameMask;
        public uint maxUnidirectionalCompoundReferenceCount;
        public uint maxUnidirectionalCompoundGroup1ReferenceCount;
        public uint unidirectionalCompoundReferenceNameMask;
        public uint maxBidirectionalCompoundReferenceCount;
        public uint maxBidirectionalCompoundGroup1ReferenceCount;
        public uint maxBidirectionalCompoundGroup2ReferenceCount;
        public uint bidirectionalCompoundReferenceNameMask;
        public uint maxTemporalLayerCount;
        public uint maxSpatialLayerCount;
        public uint maxOperatingPoints;
        public uint minQIndex;
        public uint maxQIndex;
        public VkBool32 prefersGopRemainingFrames;
        public VkBool32 requiresGopRemainingFrames;
        public VkVideoEncodeAV1StdFlagsKHR stdSyntaxFlags;
        public static VkVideoEncodeAV1CapabilitiesKHR New()
        {
            VkVideoEncodeAV1CapabilitiesKHR ret = new VkVideoEncodeAV1CapabilitiesKHR();
            ret.sType = VkStructureType.VideoEncodeAv1CapabilitiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeAV1QualityLevelPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeAV1RateControlFlagsKHR preferredRateControlFlags;
        public uint preferredGopFrameCount;
        public uint preferredKeyFramePeriod;
        public uint preferredConsecutiveBipredictiveFrameCount;
        public uint preferredTemporalLayerCount;
        public VkVideoEncodeAV1QIndexKHR preferredConstantQIndex;
        public uint preferredMaxSingleReferenceCount;
        public uint preferredSingleReferenceNameMask;
        public uint preferredMaxUnidirectionalCompoundReferenceCount;
        public uint preferredMaxUnidirectionalCompoundGroup1ReferenceCount;
        public uint preferredUnidirectionalCompoundReferenceNameMask;
        public uint preferredMaxBidirectionalCompoundReferenceCount;
        public uint preferredMaxBidirectionalCompoundGroup1ReferenceCount;
        public uint preferredMaxBidirectionalCompoundGroup2ReferenceCount;
        public uint preferredBidirectionalCompoundReferenceNameMask;
        public static VkVideoEncodeAV1QualityLevelPropertiesKHR New()
        {
            VkVideoEncodeAV1QualityLevelPropertiesKHR ret = new VkVideoEncodeAV1QualityLevelPropertiesKHR();
            ret.sType = VkStructureType.VideoEncodeAv1QualityLevelPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVideoEncodeAV1FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 videoEncodeAV1;
        public static VkPhysicalDeviceVideoEncodeAV1FeaturesKHR New()
        {
            VkPhysicalDeviceVideoEncodeAV1FeaturesKHR ret = new VkPhysicalDeviceVideoEncodeAV1FeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceVideoEncodeAv1FeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeAV1SessionCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useMaxLevel;
        public int maxLevel;
        public static VkVideoEncodeAV1SessionCreateInfoKHR New()
        {
            VkVideoEncodeAV1SessionCreateInfoKHR ret = new VkVideoEncodeAV1SessionCreateInfoKHR();
            ret.sType = VkStructureType.VideoEncodeAv1SessionCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeAV1SessionParametersCreateInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdSequenceHeader;
        public IntPtr* pStdDecoderModelInfo;
        public uint stdOperatingPointCount;
        public IntPtr* pStdOperatingPoints;
        public static VkVideoEncodeAV1SessionParametersCreateInfoKHR New()
        {
            VkVideoEncodeAV1SessionParametersCreateInfoKHR ret = new VkVideoEncodeAV1SessionParametersCreateInfoKHR();
            ret.sType = VkStructureType.VideoEncodeAv1SessionParametersCreateInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeAV1DpbSlotInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr* pStdReferenceInfo;
        public static VkVideoEncodeAV1DpbSlotInfoKHR New()
        {
            VkVideoEncodeAV1DpbSlotInfoKHR ret = new VkVideoEncodeAV1DpbSlotInfoKHR();
            ret.sType = VkStructureType.VideoEncodeAv1DpbSlotInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeAV1PictureInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeAV1PredictionModeKHR predictionMode;
        public VkVideoEncodeAV1RateControlGroupKHR rateControlGroup;
        public uint constantQIndex;
        public IntPtr* pStdPictureInfo;
        public fixed int referenceNameSlotIndices[(int)VulkanNative.MaxVideoAv1ReferencesPerFrameKHR];
        public VkBool32 primaryReferenceCdfOnly;
        public VkBool32 generateObuExtensionHeader;
        public static VkVideoEncodeAV1PictureInfoKHR New()
        {
            VkVideoEncodeAV1PictureInfoKHR ret = new VkVideoEncodeAV1PictureInfoKHR();
            ret.sType = VkStructureType.VideoEncodeAv1PictureInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeAV1ProfileInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public IntPtr stdProfile;
        public static VkVideoEncodeAV1ProfileInfoKHR New()
        {
            VkVideoEncodeAV1ProfileInfoKHR ret = new VkVideoEncodeAV1ProfileInfoKHR();
            ret.sType = VkStructureType.VideoEncodeAv1ProfileInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeAV1RateControlInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkVideoEncodeAV1RateControlFlagsKHR flags;
        public uint gopFrameCount;
        public uint keyFramePeriod;
        public uint consecutiveBipredictiveFrameCount;
        public uint temporalLayerCount;
        public static VkVideoEncodeAV1RateControlInfoKHR New()
        {
            VkVideoEncodeAV1RateControlInfoKHR ret = new VkVideoEncodeAV1RateControlInfoKHR();
            ret.sType = VkStructureType.VideoEncodeAv1RateControlInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeAV1QIndexKHR
    {
        public uint intraQIndex;
        public uint predictiveQIndex;
        public uint bipredictiveQIndex;
    }

    public unsafe partial struct VkVideoEncodeAV1FrameSizeKHR
    {
        public uint intraFrameSize;
        public uint predictiveFrameSize;
        public uint bipredictiveFrameSize;
    }

    public unsafe partial struct VkVideoEncodeAV1GopRemainingFrameInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useGopRemainingFrames;
        public uint gopRemainingIntra;
        public uint gopRemainingPredictive;
        public uint gopRemainingBipredictive;
        public static VkVideoEncodeAV1GopRemainingFrameInfoKHR New()
        {
            VkVideoEncodeAV1GopRemainingFrameInfoKHR ret = new VkVideoEncodeAV1GopRemainingFrameInfoKHR();
            ret.sType = VkStructureType.VideoEncodeAv1GopRemainingFrameInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkVideoEncodeAV1RateControlLayerInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 useMinQIndex;
        public VkVideoEncodeAV1QIndexKHR minQIndex;
        public VkBool32 useMaxQIndex;
        public VkVideoEncodeAV1QIndexKHR maxQIndex;
        public VkBool32 useMaxFrameSize;
        public VkVideoEncodeAV1FrameSizeKHR maxFrameSize;
        public static VkVideoEncodeAV1RateControlLayerInfoKHR New()
        {
            VkVideoEncodeAV1RateControlLayerInfoKHR ret = new VkVideoEncodeAV1RateControlLayerInfoKHR();
            ret.sType = VkStructureType.VideoEncodeAv1RateControlLayerInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceInheritedViewportScissorFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 inheritedViewportScissor2D;
        public static VkPhysicalDeviceInheritedViewportScissorFeaturesNV New()
        {
            VkPhysicalDeviceInheritedViewportScissorFeaturesNV ret = new VkPhysicalDeviceInheritedViewportScissorFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceInheritedViewportScissorFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferInheritanceViewportScissorInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 viewportScissor2D;
        public uint viewportDepthCount;
        public VkViewport* pViewportDepths;
        public static VkCommandBufferInheritanceViewportScissorInfoNV New()
        {
            VkCommandBufferInheritanceViewportScissorInfoNV ret = new VkCommandBufferInheritanceViewportScissorInfoNV();
            ret.sType = VkStructureType.CommandBufferInheritanceViewportScissorInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 ycbcr2plane444Formats;
        public static VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT New()
        {
            VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT ret = new VkPhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceYcbcr2Plane444FormatsFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceProvokingVertexFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 provokingVertexLast;
        public VkBool32 transformFeedbackPreservesProvokingVertex;
        public static VkPhysicalDeviceProvokingVertexFeaturesEXT New()
        {
            VkPhysicalDeviceProvokingVertexFeaturesEXT ret = new VkPhysicalDeviceProvokingVertexFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceProvokingVertexFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceProvokingVertexPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 provokingVertexModePerPipeline;
        public VkBool32 transformFeedbackPreservesTriangleFanProvokingVertex;
        public static VkPhysicalDeviceProvokingVertexPropertiesEXT New()
        {
            VkPhysicalDeviceProvokingVertexPropertiesEXT ret = new VkPhysicalDeviceProvokingVertexPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceProvokingVertexPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRasterizationProvokingVertexStateCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkProvokingVertexModeEXT provokingVertexMode;
        public static VkPipelineRasterizationProvokingVertexStateCreateInfoEXT New()
        {
            VkPipelineRasterizationProvokingVertexStateCreateInfoEXT ret = new VkPipelineRasterizationProvokingVertexStateCreateInfoEXT();
            ret.sType = VkStructureType.PipelineRasterizationProvokingVertexStateCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkCuModuleCreateInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public UIntPtr dataSize;
        public void* pData;
        public static VkCuModuleCreateInfoNVX New()
        {
            VkCuModuleCreateInfoNVX ret = new VkCuModuleCreateInfoNVX();
            ret.sType = VkStructureType.CuModuleCreateInfoNVX;
            return ret;
        }
    }

    public unsafe partial struct VkCuModuleTexturingModeCreateInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 use64bitTexturing;
        public static VkCuModuleTexturingModeCreateInfoNVX New()
        {
            VkCuModuleTexturingModeCreateInfoNVX ret = new VkCuModuleTexturingModeCreateInfoNVX();
            ret.sType = VkStructureType.CuModuleTexturingModeCreateInfoNVX;
            return ret;
        }
    }

    public unsafe partial struct VkCuFunctionCreateInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCuModuleNVX module;
        public byte* pName;
        public static VkCuFunctionCreateInfoNVX New()
        {
            VkCuFunctionCreateInfoNVX ret = new VkCuFunctionCreateInfoNVX();
            ret.sType = VkStructureType.CuFunctionCreateInfoNVX;
            return ret;
        }
    }

    public unsafe partial struct VkCuLaunchInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCuFunctionNVX function;
        public uint gridDimX;
        public uint gridDimY;
        public uint gridDimZ;
        public uint blockDimX;
        public uint blockDimY;
        public uint blockDimZ;
        public uint sharedMemBytes;
        public UIntPtr paramCount;
        public void* pParams;
        public UIntPtr extraCount;
        public void* pExtras;
        public static VkCuLaunchInfoNVX New()
        {
            VkCuLaunchInfoNVX ret = new VkCuLaunchInfoNVX();
            ret.sType = VkStructureType.CuLaunchInfoNVX;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorBufferFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 descriptorBuffer;
        public VkBool32 descriptorBufferCaptureReplay;
        public VkBool32 descriptorBufferImageLayoutIgnored;
        public VkBool32 descriptorBufferPushDescriptors;
        public static VkPhysicalDeviceDescriptorBufferFeaturesEXT New()
        {
            VkPhysicalDeviceDescriptorBufferFeaturesEXT ret = new VkPhysicalDeviceDescriptorBufferFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDescriptorBufferFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorBufferPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 combinedImageSamplerDescriptorSingleArray;
        public VkBool32 bufferlessPushDescriptors;
        public VkBool32 allowSamplerImageViewPostSubmitCreation;
        public ulong descriptorBufferOffsetAlignment;
        public uint maxDescriptorBufferBindings;
        public uint maxResourceDescriptorBufferBindings;
        public uint maxSamplerDescriptorBufferBindings;
        public uint maxEmbeddedImmutableSamplerBindings;
        public uint maxEmbeddedImmutableSamplers;
        public UIntPtr bufferCaptureReplayDescriptorDataSize;
        public UIntPtr imageCaptureReplayDescriptorDataSize;
        public UIntPtr imageViewCaptureReplayDescriptorDataSize;
        public UIntPtr samplerCaptureReplayDescriptorDataSize;
        public UIntPtr accelerationStructureCaptureReplayDescriptorDataSize;
        public UIntPtr samplerDescriptorSize;
        public UIntPtr combinedImageSamplerDescriptorSize;
        public UIntPtr sampledImageDescriptorSize;
        public UIntPtr storageImageDescriptorSize;
        public UIntPtr uniformTexelBufferDescriptorSize;
        public UIntPtr robustUniformTexelBufferDescriptorSize;
        public UIntPtr storageTexelBufferDescriptorSize;
        public UIntPtr robustStorageTexelBufferDescriptorSize;
        public UIntPtr uniformBufferDescriptorSize;
        public UIntPtr robustUniformBufferDescriptorSize;
        public UIntPtr storageBufferDescriptorSize;
        public UIntPtr robustStorageBufferDescriptorSize;
        public UIntPtr inputAttachmentDescriptorSize;
        public UIntPtr accelerationStructureDescriptorSize;
        public ulong maxSamplerDescriptorBufferRange;
        public ulong maxResourceDescriptorBufferRange;
        public ulong samplerDescriptorBufferAddressSpaceSize;
        public ulong resourceDescriptorBufferAddressSpaceSize;
        public ulong descriptorBufferAddressSpaceSize;
        public static VkPhysicalDeviceDescriptorBufferPropertiesEXT New()
        {
            VkPhysicalDeviceDescriptorBufferPropertiesEXT ret = new VkPhysicalDeviceDescriptorBufferPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDescriptorBufferPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public UIntPtr combinedImageSamplerDensityMapDescriptorSize;
        public static VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT New()
        {
            VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT ret = new VkPhysicalDeviceDescriptorBufferDensityMapPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDescriptorBufferDensityMapPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorAddressInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong address;
        public ulong range;
        public VkFormat format;
        public static VkDescriptorAddressInfoEXT New()
        {
            VkDescriptorAddressInfoEXT ret = new VkDescriptorAddressInfoEXT();
            ret.sType = VkStructureType.DescriptorAddressInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorBufferBindingInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong address;
        public VkBufferUsageFlags usage;
        public static VkDescriptorBufferBindingInfoEXT New()
        {
            VkDescriptorBufferBindingInfoEXT ret = new VkDescriptorBufferBindingInfoEXT();
            ret.sType = VkStructureType.DescriptorBufferBindingInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorBufferBindingPushDescriptorBufferHandleEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public static VkDescriptorBufferBindingPushDescriptorBufferHandleEXT New()
        {
            VkDescriptorBufferBindingPushDescriptorBufferHandleEXT ret = new VkDescriptorBufferBindingPushDescriptorBufferHandleEXT();
            ret.sType = VkStructureType.DescriptorBufferBindingPushDescriptorBufferHandleEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorGetInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorType type;
        public VkDescriptorDataEXT data;
        public static VkDescriptorGetInfoEXT New()
        {
            VkDescriptorGetInfoEXT ret = new VkDescriptorGetInfoEXT();
            ret.sType = VkStructureType.DescriptorGetInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkBufferCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBuffer buffer;
        public static VkBufferCaptureDescriptorDataInfoEXT New()
        {
            VkBufferCaptureDescriptorDataInfoEXT ret = new VkBufferCaptureDescriptorDataInfoEXT();
            ret.sType = VkStructureType.BufferCaptureDescriptorDataInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public static VkImageCaptureDescriptorDataInfoEXT New()
        {
            VkImageCaptureDescriptorDataInfoEXT ret = new VkImageCaptureDescriptorDataInfoEXT();
            ret.sType = VkStructureType.ImageCaptureDescriptorDataInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageViewCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public static VkImageViewCaptureDescriptorDataInfoEXT New()
        {
            VkImageViewCaptureDescriptorDataInfoEXT ret = new VkImageViewCaptureDescriptorDataInfoEXT();
            ret.sType = VkStructureType.ImageViewCaptureDescriptorDataInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSampler sampler;
        public static VkSamplerCaptureDescriptorDataInfoEXT New()
        {
            VkSamplerCaptureDescriptorDataInfoEXT ret = new VkSamplerCaptureDescriptorDataInfoEXT();
            ret.sType = VkStructureType.SamplerCaptureDescriptorDataInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureCaptureDescriptorDataInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAccelerationStructureKHR accelerationStructure;
        public VkAccelerationStructureNV accelerationStructureNV;
        public static VkAccelerationStructureCaptureDescriptorDataInfoEXT New()
        {
            VkAccelerationStructureCaptureDescriptorDataInfoEXT ret = new VkAccelerationStructureCaptureDescriptorDataInfoEXT();
            ret.sType = VkStructureType.AccelerationStructureCaptureDescriptorDataInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkOpaqueCaptureDescriptorDataCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public void* opaqueCaptureDescriptorData;
        public static VkOpaqueCaptureDescriptorDataCreateInfoEXT New()
        {
            VkOpaqueCaptureDescriptorDataCreateInfoEXT ret = new VkOpaqueCaptureDescriptorDataCreateInfoEXT();
            ret.sType = VkStructureType.OpaqueCaptureDescriptorDataCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderIntegerDotProductFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderIntegerDotProduct;
        public static VkPhysicalDeviceShaderIntegerDotProductFeatures New()
        {
            VkPhysicalDeviceShaderIntegerDotProductFeatures ret = new VkPhysicalDeviceShaderIntegerDotProductFeatures();
            ret.sType = VkStructureType.PhysicalDeviceShaderIntegerDotProductFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderIntegerDotProductFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderIntegerDotProductProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 integerDotProduct8BitUnsignedAccelerated;
        public VkBool32 integerDotProduct8BitSignedAccelerated;
        public VkBool32 integerDotProduct8BitMixedSignednessAccelerated;
        public VkBool32 integerDotProduct4x8BitPackedUnsignedAccelerated;
        public VkBool32 integerDotProduct4x8BitPackedSignedAccelerated;
        public VkBool32 integerDotProduct4x8BitPackedMixedSignednessAccelerated;
        public VkBool32 integerDotProduct16BitUnsignedAccelerated;
        public VkBool32 integerDotProduct16BitSignedAccelerated;
        public VkBool32 integerDotProduct16BitMixedSignednessAccelerated;
        public VkBool32 integerDotProduct32BitUnsignedAccelerated;
        public VkBool32 integerDotProduct32BitSignedAccelerated;
        public VkBool32 integerDotProduct32BitMixedSignednessAccelerated;
        public VkBool32 integerDotProduct64BitUnsignedAccelerated;
        public VkBool32 integerDotProduct64BitSignedAccelerated;
        public VkBool32 integerDotProduct64BitMixedSignednessAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating8BitSignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating16BitSignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating32BitSignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating64BitSignedAccelerated;
        public VkBool32 integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
        public static VkPhysicalDeviceShaderIntegerDotProductProperties New()
        {
            VkPhysicalDeviceShaderIntegerDotProductProperties ret = new VkPhysicalDeviceShaderIntegerDotProductProperties();
            ret.sType = VkStructureType.PhysicalDeviceShaderIntegerDotProductProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderIntegerDotProductPropertiesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceDrmPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hasPrimary;
        public VkBool32 hasRender;
        public long primaryMajor;
        public long primaryMinor;
        public long renderMajor;
        public long renderMinor;
        public static VkPhysicalDeviceDrmPropertiesEXT New()
        {
            VkPhysicalDeviceDrmPropertiesEXT ret = new VkPhysicalDeviceDrmPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDrmPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentShaderBarycentric;
        public static VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR New()
        {
            VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR ret = new VkPhysicalDeviceFragmentShaderBarycentricFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShaderBarycentricFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 triStripVertexOrderIndependentOfProvokingVertex;
        public static VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR New()
        {
            VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR ret = new VkPhysicalDeviceFragmentShaderBarycentricPropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceFragmentShaderBarycentricPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingMotionBlurFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rayTracingMotionBlur;
        public VkBool32 rayTracingMotionBlurPipelineTraceRaysIndirect;
        public static VkPhysicalDeviceRayTracingMotionBlurFeaturesNV New()
        {
            VkPhysicalDeviceRayTracingMotionBlurFeaturesNV ret = new VkPhysicalDeviceRayTracingMotionBlurFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingMotionBlurFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingValidationFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rayTracingValidation;
        public static VkPhysicalDeviceRayTracingValidationFeaturesNV New()
        {
            VkPhysicalDeviceRayTracingValidationFeaturesNV ret = new VkPhysicalDeviceRayTracingValidationFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingValidationFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 spheres;
        public VkBool32 linearSweptSpheres;
        public static VkPhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV New()
        {
            VkPhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV ret = new VkPhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingLinearSweptSpheresFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureGeometryMotionTrianglesDataNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR vertexData;
        public static VkAccelerationStructureGeometryMotionTrianglesDataNV New()
        {
            VkAccelerationStructureGeometryMotionTrianglesDataNV ret = new VkAccelerationStructureGeometryMotionTrianglesDataNV();
            ret.sType = VkStructureType.AccelerationStructureGeometryMotionTrianglesDataNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureMotionInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxInstances;
        public uint flags;
        public static VkAccelerationStructureMotionInfoNV New()
        {
            VkAccelerationStructureMotionInfoNV ret = new VkAccelerationStructureMotionInfoNV();
            ret.sType = VkStructureType.AccelerationStructureMotionInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkSRTDataNV
    {
        public float sx;
        public float a;
        public float b;
        public float pvx;
        public float sy;
        public float c;
        public float pvy;
        public float sz;
        public float pvz;
        public float qx;
        public float qy;
        public float qz;
        public float qw;
        public float tx;
        public float ty;
        public float tz;
    }

    public unsafe partial struct VkAccelerationStructureSRTMotionInstanceNV
    {
        public VkSRTDataNV transformT0;
        public VkSRTDataNV transformT1;
        public uint instanceCustomIndex;
        public uint mask;
        public uint instanceShaderBindingTableRecordOffset;
        public VkGeometryInstanceFlagsKHR flags;
        public ulong accelerationStructureReference;
    }

    public unsafe partial struct VkAccelerationStructureMatrixMotionInstanceNV
    {
        public VkTransformMatrixKHR transformT0;
        public VkTransformMatrixKHR transformT1;
        public uint instanceCustomIndex;
        public uint mask;
        public uint instanceShaderBindingTableRecordOffset;
        public VkGeometryInstanceFlagsKHR flags;
        public ulong accelerationStructureReference;
    }

    public unsafe partial struct VkAccelerationStructureMotionInstanceNV
    {
        public VkAccelerationStructureMotionInstanceTypeNV type;
        public uint flags;
        public VkAccelerationStructureMotionInstanceDataNV data;
    }

    public unsafe partial struct VkMemoryGetRemoteAddressInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkMemoryGetRemoteAddressInfoNV New()
        {
            VkMemoryGetRemoteAddressInfoNV ret = new VkMemoryGetRemoteAddressInfoNV();
            ret.sType = VkStructureType.MemoryGetRemoteAddressInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkImportMemoryBufferCollectionFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCollectionFUCHSIA collection;
        public uint index;
        public static VkImportMemoryBufferCollectionFUCHSIA New()
        {
            VkImportMemoryBufferCollectionFUCHSIA ret = new VkImportMemoryBufferCollectionFUCHSIA();
            ret.sType = VkStructureType.ImportMemoryBufferCollectionFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkBufferCollectionImageCreateInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCollectionFUCHSIA collection;
        public uint index;
        public static VkBufferCollectionImageCreateInfoFUCHSIA New()
        {
            VkBufferCollectionImageCreateInfoFUCHSIA ret = new VkBufferCollectionImageCreateInfoFUCHSIA();
            ret.sType = VkStructureType.BufferCollectionImageCreateInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkBufferCollectionBufferCreateInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCollectionFUCHSIA collection;
        public uint index;
        public static VkBufferCollectionBufferCreateInfoFUCHSIA New()
        {
            VkBufferCollectionBufferCreateInfoFUCHSIA ret = new VkBufferCollectionBufferCreateInfoFUCHSIA();
            ret.sType = VkStructureType.BufferCollectionBufferCreateInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkBufferCollectionCreateInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint collectionToken;
        public static VkBufferCollectionCreateInfoFUCHSIA New()
        {
            VkBufferCollectionCreateInfoFUCHSIA ret = new VkBufferCollectionCreateInfoFUCHSIA();
            ret.sType = VkStructureType.BufferCollectionCreateInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkBufferCollectionPropertiesFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint memoryTypeBits;
        public uint bufferCount;
        public uint createInfoIndex;
        public ulong sysmemPixelFormat;
        public VkFormatFeatureFlags formatFeatures;
        public VkSysmemColorSpaceFUCHSIA sysmemColorSpaceIndex;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
        public static VkBufferCollectionPropertiesFUCHSIA New()
        {
            VkBufferCollectionPropertiesFUCHSIA ret = new VkBufferCollectionPropertiesFUCHSIA();
            ret.sType = VkStructureType.BufferCollectionPropertiesFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkBufferConstraintsInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBufferCreateInfo createInfo;
        public VkFormatFeatureFlags requiredFormatFeatures;
        public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;
        public static VkBufferConstraintsInfoFUCHSIA New()
        {
            VkBufferConstraintsInfoFUCHSIA ret = new VkBufferConstraintsInfoFUCHSIA();
            ret.sType = VkStructureType.BufferConstraintsInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkSysmemColorSpaceFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint colorSpace;
        public static VkSysmemColorSpaceFUCHSIA New()
        {
            VkSysmemColorSpaceFUCHSIA ret = new VkSysmemColorSpaceFUCHSIA();
            ret.sType = VkStructureType.SysmemColorSpaceFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkImageFormatConstraintsInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateInfo imageCreateInfo;
        public VkFormatFeatureFlags requiredFormatFeatures;
        public uint flags;
        public ulong sysmemPixelFormat;
        public uint colorSpaceCount;
        public VkSysmemColorSpaceFUCHSIA* pColorSpaces;
        public static VkImageFormatConstraintsInfoFUCHSIA New()
        {
            VkImageFormatConstraintsInfoFUCHSIA ret = new VkImageFormatConstraintsInfoFUCHSIA();
            ret.sType = VkStructureType.ImageFormatConstraintsInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkImageConstraintsInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint formatConstraintsCount;
        public VkImageFormatConstraintsInfoFUCHSIA* pFormatConstraints;
        public VkBufferCollectionConstraintsInfoFUCHSIA bufferCollectionConstraints;
        public VkImageConstraintsInfoFlagsFUCHSIA flags;
        public static VkImageConstraintsInfoFUCHSIA New()
        {
            VkImageConstraintsInfoFUCHSIA ret = new VkImageConstraintsInfoFUCHSIA();
            ret.sType = VkStructureType.ImageConstraintsInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkBufferCollectionConstraintsInfoFUCHSIA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint minBufferCount;
        public uint maxBufferCount;
        public uint minBufferCountForCamping;
        public uint minBufferCountForDedicatedSlack;
        public uint minBufferCountForSharedSlack;
        public static VkBufferCollectionConstraintsInfoFUCHSIA New()
        {
            VkBufferCollectionConstraintsInfoFUCHSIA ret = new VkBufferCollectionConstraintsInfoFUCHSIA();
            ret.sType = VkStructureType.BufferCollectionConstraintsInfoFuchsia;
            return ret;
        }
    }

    public unsafe partial struct VkCudaModuleCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public UIntPtr dataSize;
        public void* pData;
        public static VkCudaModuleCreateInfoNV New()
        {
            VkCudaModuleCreateInfoNV ret = new VkCudaModuleCreateInfoNV();
            ret.sType = VkStructureType.CudaModuleCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkCudaFunctionCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCudaModuleNV module;
        public byte* pName;
        public static VkCudaFunctionCreateInfoNV New()
        {
            VkCudaFunctionCreateInfoNV ret = new VkCudaFunctionCreateInfoNV();
            ret.sType = VkStructureType.CudaFunctionCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkCudaLaunchInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCudaFunctionNV function;
        public uint gridDimX;
        public uint gridDimY;
        public uint gridDimZ;
        public uint blockDimX;
        public uint blockDimY;
        public uint blockDimZ;
        public uint sharedMemBytes;
        public UIntPtr paramCount;
        public void* pParams;
        public UIntPtr extraCount;
        public void* pExtras;
        public static VkCudaLaunchInfoNV New()
        {
            VkCudaLaunchInfoNV ret = new VkCudaLaunchInfoNV();
            ret.sType = VkStructureType.CudaLaunchInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 formatRgba10x6WithoutYCbCrSampler;
        public static VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT New()
        {
            VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT ret = new VkPhysicalDeviceRGBA10X6FormatsFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceRgba10x6FormatsFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkFormatProperties3
    {
        public VkStructureType sType;
        public void* pNext;
        public uint linearTilingFeatures;
        public uint optimalTilingFeatures;
        public uint bufferFeatures;
        public static VkFormatProperties3 New()
        {
            VkFormatProperties3 ret = new VkFormatProperties3();
            ret.sType = VkStructureType.FormatProperties3;
            return ret;
        }
    }

    public unsafe partial struct VkFormatProperties3KHR
    {
    }

    public unsafe partial struct VkDrmFormatModifierPropertiesList2EXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint drmFormatModifierCount;
        public VkDrmFormatModifierProperties2EXT* pDrmFormatModifierProperties;
        public static VkDrmFormatModifierPropertiesList2EXT New()
        {
            VkDrmFormatModifierPropertiesList2EXT ret = new VkDrmFormatModifierPropertiesList2EXT();
            ret.sType = VkStructureType.DrmFormatModifierPropertiesList2EXT;
            return ret;
        }
    }

    public unsafe partial struct VkDrmFormatModifierProperties2EXT
    {
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public uint drmFormatModifierTilingFeatures;
    }

    public unsafe partial struct VkAndroidHardwareBufferFormatProperties2ANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public ulong externalFormat;
        public uint formatFeatures;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
        public static VkAndroidHardwareBufferFormatProperties2ANDROID New()
        {
            VkAndroidHardwareBufferFormatProperties2ANDROID ret = new VkAndroidHardwareBufferFormatProperties2ANDROID();
            ret.sType = VkStructureType.AndroidHardwareBufferFormatProperties2Android;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRenderingCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkFormat* pColorAttachmentFormats;
        public VkFormat depthAttachmentFormat;
        public VkFormat stencilAttachmentFormat;
        public static VkPipelineRenderingCreateInfo New()
        {
            VkPipelineRenderingCreateInfo ret = new VkPipelineRenderingCreateInfo();
            ret.sType = VkStructureType.PipelineRenderingCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRenderingCreateInfoKHR
    {
    }

    public unsafe partial struct VkRenderingInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderingFlags flags;
        public VkRect2D renderArea;
        public uint layerCount;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkRenderingAttachmentInfo* pColorAttachments;
        public VkRenderingAttachmentInfo* pDepthAttachment;
        public VkRenderingAttachmentInfo* pStencilAttachment;
        public static VkRenderingInfo New()
        {
            VkRenderingInfo ret = new VkRenderingInfo();
            ret.sType = VkStructureType.RenderingInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderingInfoKHR
    {
    }

    public unsafe partial struct VkRenderingEndInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public static VkRenderingEndInfoEXT New()
        {
            VkRenderingEndInfoEXT ret = new VkRenderingEndInfoEXT();
            ret.sType = VkStructureType.RenderingEndInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkRenderingAttachmentInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
        public VkResolveModeFlags resolveMode;
        public VkImageView resolveImageView;
        public VkImageLayout resolveImageLayout;
        public VkAttachmentLoadOp loadOp;
        public VkAttachmentStoreOp storeOp;
        public VkClearValue clearValue;
        public static VkRenderingAttachmentInfo New()
        {
            VkRenderingAttachmentInfo ret = new VkRenderingAttachmentInfo();
            ret.sType = VkStructureType.RenderingAttachmentInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderingAttachmentInfoKHR
    {
    }

    public unsafe partial struct VkRenderingFragmentShadingRateAttachmentInfoKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
        public VkExtent2D shadingRateAttachmentTexelSize;
        public static VkRenderingFragmentShadingRateAttachmentInfoKHR New()
        {
            VkRenderingFragmentShadingRateAttachmentInfoKHR ret = new VkRenderingFragmentShadingRateAttachmentInfoKHR();
            ret.sType = VkStructureType.RenderingFragmentShadingRateAttachmentInfoKHR;
            return ret;
        }
    }

    public unsafe partial struct VkRenderingFragmentDensityMapAttachmentInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageView imageView;
        public VkImageLayout imageLayout;
        public static VkRenderingFragmentDensityMapAttachmentInfoEXT New()
        {
            VkRenderingFragmentDensityMapAttachmentInfoEXT ret = new VkRenderingFragmentDensityMapAttachmentInfoEXT();
            ret.sType = VkStructureType.RenderingFragmentDensityMapAttachmentInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDynamicRenderingFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dynamicRendering;
        public static VkPhysicalDeviceDynamicRenderingFeatures New()
        {
            VkPhysicalDeviceDynamicRenderingFeatures ret = new VkPhysicalDeviceDynamicRenderingFeatures();
            ret.sType = VkStructureType.PhysicalDeviceDynamicRenderingFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDynamicRenderingFeaturesKHR
    {
    }

    public unsafe partial struct VkCommandBufferInheritanceRenderingInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderingFlags flags;
        public uint viewMask;
        public uint colorAttachmentCount;
        public VkFormat* pColorAttachmentFormats;
        public VkFormat depthAttachmentFormat;
        public VkFormat stencilAttachmentFormat;
        public VkSampleCountFlags rasterizationSamples;
        public static VkCommandBufferInheritanceRenderingInfo New()
        {
            VkCommandBufferInheritanceRenderingInfo ret = new VkCommandBufferInheritanceRenderingInfo();
            ret.sType = VkStructureType.CommandBufferInheritanceRenderingInfo;
            return ret;
        }
    }

    public unsafe partial struct VkCommandBufferInheritanceRenderingInfoKHR
    {
    }

    public unsafe partial struct VkAttachmentSampleCountInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public uint colorAttachmentCount;
        public VkSampleCountFlags* pColorAttachmentSamples;
        public VkSampleCountFlags depthStencilAttachmentSamples;
        public static VkAttachmentSampleCountInfoAMD New()
        {
            VkAttachmentSampleCountInfoAMD ret = new VkAttachmentSampleCountInfoAMD();
            ret.sType = VkStructureType.AttachmentSampleCountInfoAMD;
            return ret;
        }
    }

    public unsafe partial struct VkAttachmentSampleCountInfoNV
    {
    }

    public unsafe partial struct VkMultiviewPerViewAttributesInfoNVX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 perViewAttributes;
        public VkBool32 perViewAttributesPositionXOnly;
        public static VkMultiviewPerViewAttributesInfoNVX New()
        {
            VkMultiviewPerViewAttributesInfoNVX ret = new VkMultiviewPerViewAttributesInfoNVX();
            ret.sType = VkStructureType.MultiviewPerViewAttributesInfoNVX;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageViewMinLodFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 minLod;
        public static VkPhysicalDeviceImageViewMinLodFeaturesEXT New()
        {
            VkPhysicalDeviceImageViewMinLodFeaturesEXT ret = new VkPhysicalDeviceImageViewMinLodFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceImageViewMinLodFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageViewMinLodCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public float minLod;
        public static VkImageViewMinLodCreateInfoEXT New()
        {
            VkImageViewMinLodCreateInfoEXT ret = new VkImageViewMinLodCreateInfoEXT();
            ret.sType = VkStructureType.ImageViewMinLodCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rasterizationOrderColorAttachmentAccess;
        public VkBool32 rasterizationOrderDepthAttachmentAccess;
        public VkBool32 rasterizationOrderStencilAttachmentAccess;
        public static VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT New()
        {
            VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT ret = new VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceRasterizationOrderAttachmentAccessFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRasterizationOrderAttachmentAccessFeaturesARM
    {
    }

    public unsafe partial struct VkPhysicalDeviceLinearColorAttachmentFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 linearColorAttachment;
        public static VkPhysicalDeviceLinearColorAttachmentFeaturesNV New()
        {
            VkPhysicalDeviceLinearColorAttachmentFeaturesNV ret = new VkPhysicalDeviceLinearColorAttachmentFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceLinearColorAttachmentFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 graphicsPipelineLibrary;
        public static VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT New()
        {
            VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT ret = new VkPhysicalDeviceGraphicsPipelineLibraryFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceGraphicsPipelineLibraryFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePipelineBinaryFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineBinaries;
        public static VkPhysicalDevicePipelineBinaryFeaturesKHR New()
        {
            VkPhysicalDevicePipelineBinaryFeaturesKHR ret = new VkPhysicalDevicePipelineBinaryFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDevicePipelineBinaryFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDevicePipelineBinaryInternalCacheControlKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 disableInternalCache;
        public static VkDevicePipelineBinaryInternalCacheControlKHR New()
        {
            VkDevicePipelineBinaryInternalCacheControlKHR ret = new VkDevicePipelineBinaryInternalCacheControlKHR();
            ret.sType = VkStructureType.DevicePipelineBinaryInternalCacheControlKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePipelineBinaryPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineBinaryInternalCache;
        public VkBool32 pipelineBinaryInternalCacheControl;
        public VkBool32 pipelineBinaryPrefersInternalCache;
        public VkBool32 pipelineBinaryPrecompiledInternalCache;
        public VkBool32 pipelineBinaryCompressedData;
        public static VkPhysicalDevicePipelineBinaryPropertiesKHR New()
        {
            VkPhysicalDevicePipelineBinaryPropertiesKHR ret = new VkPhysicalDevicePipelineBinaryPropertiesKHR();
            ret.sType = VkStructureType.PhysicalDevicePipelineBinaryPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 graphicsPipelineLibraryFastLinking;
        public VkBool32 graphicsPipelineLibraryIndependentInterpolationDecoration;
        public static VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT New()
        {
            VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT ret = new VkPhysicalDeviceGraphicsPipelineLibraryPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceGraphicsPipelineLibraryPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkGraphicsPipelineLibraryCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkGraphicsPipelineLibraryFlagsEXT flags;
        public static VkGraphicsPipelineLibraryCreateInfoEXT New()
        {
            VkGraphicsPipelineLibraryCreateInfoEXT ret = new VkGraphicsPipelineLibraryCreateInfoEXT();
            ret.sType = VkStructureType.GraphicsPipelineLibraryCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 descriptorSetHostMapping;
        public static VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE New()
        {
            VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE ret = new VkPhysicalDeviceDescriptorSetHostMappingFeaturesVALVE();
            ret.sType = VkStructureType.PhysicalDeviceDescriptorSetHostMappingFeaturesValve;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetBindingReferenceVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorSetLayout descriptorSetLayout;
        public uint binding;
        public static VkDescriptorSetBindingReferenceVALVE New()
        {
            VkDescriptorSetBindingReferenceVALVE ret = new VkDescriptorSetBindingReferenceVALVE();
            ret.sType = VkStructureType.DescriptorSetBindingReferenceValve;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorSetLayoutHostMappingInfoVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public UIntPtr descriptorOffset;
        public uint descriptorSize;
        public static VkDescriptorSetLayoutHostMappingInfoVALVE New()
        {
            VkDescriptorSetLayoutHostMappingInfoVALVE ret = new VkDescriptorSetLayoutHostMappingInfoVALVE();
            ret.sType = VkStructureType.DescriptorSetLayoutHostMappingInfoValve;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceNestedCommandBufferFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 nestedCommandBuffer;
        public VkBool32 nestedCommandBufferRendering;
        public VkBool32 nestedCommandBufferSimultaneousUse;
        public static VkPhysicalDeviceNestedCommandBufferFeaturesEXT New()
        {
            VkPhysicalDeviceNestedCommandBufferFeaturesEXT ret = new VkPhysicalDeviceNestedCommandBufferFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceNestedCommandBufferFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceNestedCommandBufferPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxCommandBufferNestingLevel;
        public static VkPhysicalDeviceNestedCommandBufferPropertiesEXT New()
        {
            VkPhysicalDeviceNestedCommandBufferPropertiesEXT ret = new VkPhysicalDeviceNestedCommandBufferPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceNestedCommandBufferPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderModuleIdentifier;
        public static VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT New()
        {
            VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT ret = new VkPhysicalDeviceShaderModuleIdentifierFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderModuleIdentifierFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte shaderModuleIdentifierAlgorithmUUID[(int)VulkanNative.UuidSize];
        public static VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT New()
        {
            VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT ret = new VkPhysicalDeviceShaderModuleIdentifierPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderModuleIdentifierPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineShaderStageModuleIdentifierCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint identifierSize;
        public byte* pIdentifier;
        public static VkPipelineShaderStageModuleIdentifierCreateInfoEXT New()
        {
            VkPipelineShaderStageModuleIdentifierCreateInfoEXT ret = new VkPipelineShaderStageModuleIdentifierCreateInfoEXT();
            ret.sType = VkStructureType.PipelineShaderStageModuleIdentifierCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkShaderModuleIdentifierEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint identifierSize;
        public fixed byte identifier[(int)VulkanNative.MaxShaderModuleIdentifierSizeEXT];
        public static VkShaderModuleIdentifierEXT New()
        {
            VkShaderModuleIdentifierEXT ret = new VkShaderModuleIdentifierEXT();
            ret.sType = VkStructureType.ShaderModuleIdentifierEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageCompressionControlEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCompressionFlagsEXT flags;
        public uint compressionControlPlaneCount;
        public VkImageCompressionFixedRateFlagsEXT* pFixedRateFlags;
        public static VkImageCompressionControlEXT New()
        {
            VkImageCompressionControlEXT ret = new VkImageCompressionControlEXT();
            ret.sType = VkStructureType.ImageCompressionControlEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageCompressionControlFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 imageCompressionControl;
        public static VkPhysicalDeviceImageCompressionControlFeaturesEXT New()
        {
            VkPhysicalDeviceImageCompressionControlFeaturesEXT ret = new VkPhysicalDeviceImageCompressionControlFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceImageCompressionControlFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageCompressionPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCompressionFlagsEXT imageCompressionFlags;
        public VkImageCompressionFixedRateFlagsEXT imageCompressionFixedRateFlags;
        public static VkImageCompressionPropertiesEXT New()
        {
            VkImageCompressionPropertiesEXT ret = new VkImageCompressionPropertiesEXT();
            ret.sType = VkStructureType.ImageCompressionPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 imageCompressionControlSwapchain;
        public static VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT New()
        {
            VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT ret = new VkPhysicalDeviceImageCompressionControlSwapchainFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceImageCompressionControlSwapchainFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImageSubresource2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageSubresource imageSubresource;
        public static VkImageSubresource2 New()
        {
            VkImageSubresource2 ret = new VkImageSubresource2();
            ret.sType = VkStructureType.ImageSubresource2;
            return ret;
        }
    }

    public unsafe partial struct VkImageSubresource2KHR
    {
    }

    public unsafe partial struct VkImageSubresource2EXT
    {
    }

    public unsafe partial struct VkSubresourceLayout2
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSubresourceLayout subresourceLayout;
        public static VkSubresourceLayout2 New()
        {
            VkSubresourceLayout2 ret = new VkSubresourceLayout2();
            ret.sType = VkStructureType.SubresourceLayout2;
            return ret;
        }
    }

    public unsafe partial struct VkSubresourceLayout2KHR
    {
    }

    public unsafe partial struct VkSubresourceLayout2EXT
    {
    }

    public unsafe partial struct VkRenderPassCreationControlEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 disallowMerging;
        public static VkRenderPassCreationControlEXT New()
        {
            VkRenderPassCreationControlEXT ret = new VkRenderPassCreationControlEXT();
            ret.sType = VkStructureType.RenderPassCreationControlEXT;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassCreationFeedbackInfoEXT
    {
        public uint postMergeSubpassCount;
    }

    public unsafe partial struct VkRenderPassCreationFeedbackCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassCreationFeedbackInfoEXT* pRenderPassFeedback;
        public static VkRenderPassCreationFeedbackCreateInfoEXT New()
        {
            VkRenderPassCreationFeedbackCreateInfoEXT ret = new VkRenderPassCreationFeedbackCreateInfoEXT();
            ret.sType = VkStructureType.RenderPassCreationFeedbackCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassSubpassFeedbackInfoEXT
    {
        public VkSubpassMergeStatusEXT subpassMergeStatus;
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public uint postMergeIndex;
    }

    public unsafe partial struct VkRenderPassSubpassFeedbackCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRenderPassSubpassFeedbackInfoEXT* pSubpassFeedback;
        public static VkRenderPassSubpassFeedbackCreateInfoEXT New()
        {
            VkRenderPassSubpassFeedbackCreateInfoEXT ret = new VkRenderPassSubpassFeedbackCreateInfoEXT();
            ret.sType = VkStructureType.RenderPassSubpassFeedbackCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 subpassMergeFeedback;
        public static VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT New()
        {
            VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT ret = new VkPhysicalDeviceSubpassMergeFeedbackFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceSubpassMergeFeedbackFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMicromapBuildInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMicromapTypeEXT type;
        public VkBuildMicromapFlagsEXT flags;
        public VkBuildMicromapModeEXT mode;
        public VkMicromapEXT dstMicromap;
        public uint usageCountsCount;
        public VkMicromapUsageEXT* pUsageCounts;
        public VkMicromapUsageEXT** ppUsageCounts;
        public VkDeviceOrHostAddressConstKHR data;
        public VkDeviceOrHostAddressKHR scratchData;
        public VkDeviceOrHostAddressConstKHR triangleArray;
        public ulong triangleArrayStride;
        public static VkMicromapBuildInfoEXT New()
        {
            VkMicromapBuildInfoEXT ret = new VkMicromapBuildInfoEXT();
            ret.sType = VkStructureType.MicromapBuildInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMicromapCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMicromapCreateFlagsEXT createFlags;
        public VkBuffer buffer;
        public ulong offset;
        public ulong size;
        public VkMicromapTypeEXT type;
        public ulong deviceAddress;
        public static VkMicromapCreateInfoEXT New()
        {
            VkMicromapCreateInfoEXT ret = new VkMicromapCreateInfoEXT();
            ret.sType = VkStructureType.MicromapCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMicromapVersionInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pVersionData;
        public static VkMicromapVersionInfoEXT New()
        {
            VkMicromapVersionInfoEXT ret = new VkMicromapVersionInfoEXT();
            ret.sType = VkStructureType.MicromapVersionInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkCopyMicromapInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMicromapEXT src;
        public VkMicromapEXT dst;
        public VkCopyMicromapModeEXT mode;
        public static VkCopyMicromapInfoEXT New()
        {
            VkCopyMicromapInfoEXT ret = new VkCopyMicromapInfoEXT();
            ret.sType = VkStructureType.CopyMicromapInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkCopyMicromapToMemoryInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMicromapEXT src;
        public VkDeviceOrHostAddressKHR dst;
        public VkCopyMicromapModeEXT mode;
        public static VkCopyMicromapToMemoryInfoEXT New()
        {
            VkCopyMicromapToMemoryInfoEXT ret = new VkCopyMicromapToMemoryInfoEXT();
            ret.sType = VkStructureType.CopyMicromapToMemoryInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkCopyMemoryToMicromapInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceOrHostAddressConstKHR src;
        public VkMicromapEXT dst;
        public VkCopyMicromapModeEXT mode;
        public static VkCopyMemoryToMicromapInfoEXT New()
        {
            VkCopyMemoryToMicromapInfoEXT ret = new VkCopyMemoryToMicromapInfoEXT();
            ret.sType = VkStructureType.CopyMemoryToMicromapInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMicromapBuildSizesInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong micromapSize;
        public ulong buildScratchSize;
        public VkBool32 discardable;
        public static VkMicromapBuildSizesInfoEXT New()
        {
            VkMicromapBuildSizesInfoEXT ret = new VkMicromapBuildSizesInfoEXT();
            ret.sType = VkStructureType.MicromapBuildSizesInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMicromapUsageEXT
    {
        public uint count;
        public uint subdivisionLevel;
        public uint format;
    }

    public unsafe partial struct VkMicromapTriangleEXT
    {
        public uint dataOffset;
        public ushort subdivisionLevel;
        public ushort format;
    }

    public unsafe partial struct VkPhysicalDeviceOpacityMicromapFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 micromap;
        public VkBool32 micromapCaptureReplay;
        public VkBool32 micromapHostCommands;
        public static VkPhysicalDeviceOpacityMicromapFeaturesEXT New()
        {
            VkPhysicalDeviceOpacityMicromapFeaturesEXT ret = new VkPhysicalDeviceOpacityMicromapFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceOpacityMicromapFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceOpacityMicromapPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxOpacity2StateSubdivisionLevel;
        public uint maxOpacity4StateSubdivisionLevel;
        public static VkPhysicalDeviceOpacityMicromapPropertiesEXT New()
        {
            VkPhysicalDeviceOpacityMicromapPropertiesEXT ret = new VkPhysicalDeviceOpacityMicromapPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceOpacityMicromapPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureTrianglesOpacityMicromapEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexBuffer;
        public ulong indexStride;
        public uint baseTriangle;
        public uint usageCountsCount;
        public VkMicromapUsageEXT* pUsageCounts;
        public VkMicromapUsageEXT** ppUsageCounts;
        public VkMicromapEXT micromap;
        public static VkAccelerationStructureTrianglesOpacityMicromapEXT New()
        {
            VkAccelerationStructureTrianglesOpacityMicromapEXT ret = new VkAccelerationStructureTrianglesOpacityMicromapEXT();
            ret.sType = VkStructureType.AccelerationStructureTrianglesOpacityMicromapEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDisplacementMicromapFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 displacementMicromap;
        public static VkPhysicalDeviceDisplacementMicromapFeaturesNV New()
        {
            VkPhysicalDeviceDisplacementMicromapFeaturesNV ret = new VkPhysicalDeviceDisplacementMicromapFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceDisplacementMicromapFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDisplacementMicromapPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxDisplacementMicromapSubdivisionLevel;
        public static VkPhysicalDeviceDisplacementMicromapPropertiesNV New()
        {
            VkPhysicalDeviceDisplacementMicromapPropertiesNV ret = new VkPhysicalDeviceDisplacementMicromapPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceDisplacementMicromapPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkAccelerationStructureTrianglesDisplacementMicromapNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat displacementBiasAndScaleFormat;
        public VkFormat displacementVectorFormat;
        public VkDeviceOrHostAddressConstKHR displacementBiasAndScaleBuffer;
        public ulong displacementBiasAndScaleStride;
        public VkDeviceOrHostAddressConstKHR displacementVectorBuffer;
        public ulong displacementVectorStride;
        public VkDeviceOrHostAddressConstKHR displacedMicromapPrimitiveFlags;
        public ulong displacedMicromapPrimitiveFlagsStride;
        public VkIndexType indexType;
        public VkDeviceOrHostAddressConstKHR indexBuffer;
        public ulong indexStride;
        public uint baseTriangle;
        public uint usageCountsCount;
        public VkMicromapUsageEXT* pUsageCounts;
        public VkMicromapUsageEXT** ppUsageCounts;
        public VkMicromapEXT micromap;
        public static VkAccelerationStructureTrianglesDisplacementMicromapNV New()
        {
            VkAccelerationStructureTrianglesDisplacementMicromapNV ret = new VkAccelerationStructureTrianglesDisplacementMicromapNV();
            ret.sType = VkStructureType.AccelerationStructureTrianglesDisplacementMicromapNV;
            return ret;
        }
    }

    public unsafe partial struct VkPipelinePropertiesIdentifierEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte pipelineIdentifier[(int)VulkanNative.UuidSize];
        public static VkPipelinePropertiesIdentifierEXT New()
        {
            VkPipelinePropertiesIdentifierEXT ret = new VkPipelinePropertiesIdentifierEXT();
            ret.sType = VkStructureType.PipelinePropertiesIdentifierEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePipelinePropertiesFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelinePropertiesIdentifier;
        public static VkPhysicalDevicePipelinePropertiesFeaturesEXT New()
        {
            VkPhysicalDevicePipelinePropertiesFeaturesEXT ret = new VkPhysicalDevicePipelinePropertiesFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDevicePipelinePropertiesFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderEarlyAndLateFragmentTests;
        public static VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD New()
        {
            VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD ret = new VkPhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD();
            ret.sType = VkStructureType.PhysicalDeviceShaderEarlyAndLateFragmentTestsFeaturesAMD;
            return ret;
        }
    }

    public unsafe partial struct VkExternalMemoryAcquireUnmodifiedEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 acquireUnmodifiedMemory;
        public static VkExternalMemoryAcquireUnmodifiedEXT New()
        {
            VkExternalMemoryAcquireUnmodifiedEXT ret = new VkExternalMemoryAcquireUnmodifiedEXT();
            ret.sType = VkStructureType.ExternalMemoryAcquireUnmodifiedEXT;
            return ret;
        }
    }

    public unsafe partial struct VkExportMetalObjectCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExportMetalObjectTypeFlagsEXT exportObjectType;
        public static VkExportMetalObjectCreateInfoEXT New()
        {
            VkExportMetalObjectCreateInfoEXT ret = new VkExportMetalObjectCreateInfoEXT();
            ret.sType = VkStructureType.ExportMetalObjectCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkExportMetalObjectsInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public static VkExportMetalObjectsInfoEXT New()
        {
            VkExportMetalObjectsInfoEXT ret = new VkExportMetalObjectsInfoEXT();
            ret.sType = VkStructureType.ExportMetalObjectsInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkExportMetalDeviceInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public Metal.MTLDevice mtlDevice;
        public static VkExportMetalDeviceInfoEXT New()
        {
            VkExportMetalDeviceInfoEXT ret = new VkExportMetalDeviceInfoEXT();
            ret.sType = VkStructureType.ExportMetalDeviceInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkExportMetalCommandQueueInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueue queue;
        public Metal.MTLCommandQueue mtlCommandQueue;
        public static VkExportMetalCommandQueueInfoEXT New()
        {
            VkExportMetalCommandQueueInfoEXT ret = new VkExportMetalCommandQueueInfoEXT();
            ret.sType = VkStructureType.ExportMetalCommandQueueInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkExportMetalBufferInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public Metal.MTLBuffer mtlBuffer;
        public static VkExportMetalBufferInfoEXT New()
        {
            VkExportMetalBufferInfoEXT ret = new VkExportMetalBufferInfoEXT();
            ret.sType = VkStructureType.ExportMetalBufferInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImportMetalBufferInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public Metal.MTLBuffer mtlBuffer;
        public static VkImportMetalBufferInfoEXT New()
        {
            VkImportMetalBufferInfoEXT ret = new VkImportMetalBufferInfoEXT();
            ret.sType = VkStructureType.ImportMetalBufferInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkExportMetalTextureInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public VkImageView imageView;
        public VkBufferView bufferView;
        public VkImageAspectFlags plane;
        public Metal.MTLTexture mtlTexture;
        public static VkExportMetalTextureInfoEXT New()
        {
            VkExportMetalTextureInfoEXT ret = new VkExportMetalTextureInfoEXT();
            ret.sType = VkStructureType.ExportMetalTextureInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImportMetalTextureInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageAspectFlags plane;
        public Metal.MTLTexture mtlTexture;
        public static VkImportMetalTextureInfoEXT New()
        {
            VkImportMetalTextureInfoEXT ret = new VkImportMetalTextureInfoEXT();
            ret.sType = VkStructureType.ImportMetalTextureInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkExportMetalIOSurfaceInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImage image;
        public Apple.IOSurfaceRef ioSurface;
        public static VkExportMetalIOSurfaceInfoEXT New()
        {
            VkExportMetalIOSurfaceInfoEXT ret = new VkExportMetalIOSurfaceInfoEXT();
            ret.sType = VkStructureType.ExportMetalIoSurfaceInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImportMetalIOSurfaceInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public Apple.IOSurfaceRef ioSurface;
        public static VkImportMetalIOSurfaceInfoEXT New()
        {
            VkImportMetalIOSurfaceInfoEXT ret = new VkImportMetalIOSurfaceInfoEXT();
            ret.sType = VkStructureType.ImportMetalIoSurfaceInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkExportMetalSharedEventInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore semaphore;
        public VkEvent @event;
        public Metal.MTLSharedEvent mtlSharedEvent;
        public static VkExportMetalSharedEventInfoEXT New()
        {
            VkExportMetalSharedEventInfoEXT ret = new VkExportMetalSharedEventInfoEXT();
            ret.sType = VkStructureType.ExportMetalSharedEventInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImportMetalSharedEventInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public Metal.MTLSharedEvent mtlSharedEvent;
        public static VkImportMetalSharedEventInfoEXT New()
        {
            VkImportMetalSharedEventInfoEXT ret = new VkImportMetalSharedEventInfoEXT();
            ret.sType = VkStructureType.ImportMetalSharedEventInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 nonSeamlessCubeMap;
        public static VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT New()
        {
            VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT ret = new VkPhysicalDeviceNonSeamlessCubeMapFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceNonSeamlessCubeMapFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePipelineRobustnessFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineRobustness;
        public static VkPhysicalDevicePipelineRobustnessFeatures New()
        {
            VkPhysicalDevicePipelineRobustnessFeatures ret = new VkPhysicalDevicePipelineRobustnessFeatures();
            ret.sType = VkStructureType.PhysicalDevicePipelineRobustnessFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePipelineRobustnessFeaturesEXT
    {
    }

    public unsafe partial struct VkPipelineRobustnessCreateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRobustnessBufferBehavior storageBuffers;
        public VkPipelineRobustnessBufferBehavior uniformBuffers;
        public VkPipelineRobustnessBufferBehavior vertexInputs;
        public VkPipelineRobustnessImageBehavior images;
        public static VkPipelineRobustnessCreateInfo New()
        {
            VkPipelineRobustnessCreateInfo ret = new VkPipelineRobustnessCreateInfo();
            ret.sType = VkStructureType.PipelineRobustnessCreateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineRobustnessCreateInfoEXT
    {
    }

    public unsafe partial struct VkPhysicalDevicePipelineRobustnessProperties
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineRobustnessBufferBehavior defaultRobustnessStorageBuffers;
        public VkPipelineRobustnessBufferBehavior defaultRobustnessUniformBuffers;
        public VkPipelineRobustnessBufferBehavior defaultRobustnessVertexInputs;
        public VkPipelineRobustnessImageBehavior defaultRobustnessImages;
        public static VkPhysicalDevicePipelineRobustnessProperties New()
        {
            VkPhysicalDevicePipelineRobustnessProperties ret = new VkPhysicalDevicePipelineRobustnessProperties();
            ret.sType = VkStructureType.PhysicalDevicePipelineRobustnessProperties;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePipelineRobustnessPropertiesEXT
    {
    }

    public unsafe partial struct VkImageViewSampleWeightCreateInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOffset2D filterCenter;
        public VkExtent2D filterSize;
        public uint numPhases;
        public static VkImageViewSampleWeightCreateInfoQCOM New()
        {
            VkImageViewSampleWeightCreateInfoQCOM ret = new VkImageViewSampleWeightCreateInfoQCOM();
            ret.sType = VkStructureType.ImageViewSampleWeightCreateInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageProcessingFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 textureSampleWeighted;
        public VkBool32 textureBoxFilter;
        public VkBool32 textureBlockMatch;
        public static VkPhysicalDeviceImageProcessingFeaturesQCOM New()
        {
            VkPhysicalDeviceImageProcessingFeaturesQCOM ret = new VkPhysicalDeviceImageProcessingFeaturesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceImageProcessingFeaturesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageProcessingPropertiesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxWeightFilterPhases;
        public VkExtent2D maxWeightFilterDimension;
        public VkExtent2D maxBlockMatchRegion;
        public VkExtent2D maxBoxFilterBlockSize;
        public static VkPhysicalDeviceImageProcessingPropertiesQCOM New()
        {
            VkPhysicalDeviceImageProcessingPropertiesQCOM ret = new VkPhysicalDeviceImageProcessingPropertiesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceImageProcessingPropertiesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTilePropertiesFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 tileProperties;
        public static VkPhysicalDeviceTilePropertiesFeaturesQCOM New()
        {
            VkPhysicalDeviceTilePropertiesFeaturesQCOM ret = new VkPhysicalDeviceTilePropertiesFeaturesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceTilePropertiesFeaturesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkTilePropertiesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent3D tileSize;
        public VkExtent2D apronSize;
        public VkOffset2D origin;
        public static VkTilePropertiesQCOM New()
        {
            VkTilePropertiesQCOM ret = new VkTilePropertiesQCOM();
            ret.sType = VkStructureType.TilePropertiesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkTileMemoryBindInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceMemory memory;
        public static VkTileMemoryBindInfoQCOM New()
        {
            VkTileMemoryBindInfoQCOM ret = new VkTileMemoryBindInfoQCOM();
            ret.sType = VkStructureType.TileMemoryBindInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceAmigoProfilingFeaturesSEC
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 amigoProfiling;
        public static VkPhysicalDeviceAmigoProfilingFeaturesSEC New()
        {
            VkPhysicalDeviceAmigoProfilingFeaturesSEC ret = new VkPhysicalDeviceAmigoProfilingFeaturesSEC();
            ret.sType = VkStructureType.PhysicalDeviceAmigoProfilingFeaturesSec;
            return ret;
        }
    }

    public unsafe partial struct VkAmigoProfilingSubmitInfoSEC
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong firstDrawTimestamp;
        public ulong swapBufferTimestamp;
        public static VkAmigoProfilingSubmitInfoSEC New()
        {
            VkAmigoProfilingSubmitInfoSEC ret = new VkAmigoProfilingSubmitInfoSEC();
            ret.sType = VkStructureType.AmigoProfilingSubmitInfoSec;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 attachmentFeedbackLoopLayout;
        public static VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT New()
        {
            VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT ret = new VkPhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceAttachmentFeedbackLoopLayoutFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDepthClampZeroOneFeaturesEXT
    {
    }

    public unsafe partial struct VkAttachmentFeedbackLoopInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 feedbackLoopEnable;
        public static VkAttachmentFeedbackLoopInfoEXT New()
        {
            VkAttachmentFeedbackLoopInfoEXT ret = new VkAttachmentFeedbackLoopInfoEXT();
            ret.sType = VkStructureType.AttachmentFeedbackLoopInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceAddressBindingReportFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 reportAddressBinding;
        public static VkPhysicalDeviceAddressBindingReportFeaturesEXT New()
        {
            VkPhysicalDeviceAddressBindingReportFeaturesEXT ret = new VkPhysicalDeviceAddressBindingReportFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceAddressBindingReportFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceAddressBindingCallbackDataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceAddressBindingFlagsEXT flags;
        public ulong baseAddress;
        public ulong size;
        public VkDeviceAddressBindingTypeEXT bindingType;
        public static VkDeviceAddressBindingCallbackDataEXT New()
        {
            VkDeviceAddressBindingCallbackDataEXT ret = new VkDeviceAddressBindingCallbackDataEXT();
            ret.sType = VkStructureType.DeviceAddressBindingCallbackDataEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceOpticalFlowFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 opticalFlow;
        public static VkPhysicalDeviceOpticalFlowFeaturesNV New()
        {
            VkPhysicalDeviceOpticalFlowFeaturesNV ret = new VkPhysicalDeviceOpticalFlowFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceOpticalFlowFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceOpticalFlowPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOpticalFlowGridSizeFlagsNV supportedOutputGridSizes;
        public VkOpticalFlowGridSizeFlagsNV supportedHintGridSizes;
        public VkBool32 hintSupported;
        public VkBool32 costSupported;
        public VkBool32 bidirectionalFlowSupported;
        public VkBool32 globalFlowSupported;
        public uint minWidth;
        public uint minHeight;
        public uint maxWidth;
        public uint maxHeight;
        public uint maxNumRegionsOfInterest;
        public static VkPhysicalDeviceOpticalFlowPropertiesNV New()
        {
            VkPhysicalDeviceOpticalFlowPropertiesNV ret = new VkPhysicalDeviceOpticalFlowPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceOpticalFlowPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkOpticalFlowImageFormatInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOpticalFlowUsageFlagsNV usage;
        public static VkOpticalFlowImageFormatInfoNV New()
        {
            VkOpticalFlowImageFormatInfoNV ret = new VkOpticalFlowImageFormatInfoNV();
            ret.sType = VkStructureType.OpticalFlowImageFormatInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkOpticalFlowImageFormatPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public static VkOpticalFlowImageFormatPropertiesNV New()
        {
            VkOpticalFlowImageFormatPropertiesNV ret = new VkOpticalFlowImageFormatPropertiesNV();
            ret.sType = VkStructureType.OpticalFlowImageFormatPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkOpticalFlowSessionCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint width;
        public uint height;
        public VkFormat imageFormat;
        public VkFormat flowVectorFormat;
        public VkFormat costFormat;
        public VkOpticalFlowGridSizeFlagsNV outputGridSize;
        public VkOpticalFlowGridSizeFlagsNV hintGridSize;
        public VkOpticalFlowPerformanceLevelNV performanceLevel;
        public VkOpticalFlowSessionCreateFlagsNV flags;
        public static VkOpticalFlowSessionCreateInfoNV New()
        {
            VkOpticalFlowSessionCreateInfoNV ret = new VkOpticalFlowSessionCreateInfoNV();
            ret.sType = VkStructureType.OpticalFlowSessionCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkOpticalFlowSessionCreatePrivateDataInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint id;
        public uint size;
        public void* pPrivateData;
        public static VkOpticalFlowSessionCreatePrivateDataInfoNV New()
        {
            VkOpticalFlowSessionCreatePrivateDataInfoNV ret = new VkOpticalFlowSessionCreatePrivateDataInfoNV();
            ret.sType = VkStructureType.OpticalFlowSessionCreatePrivateDataInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkOpticalFlowExecuteInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOpticalFlowExecuteFlagsNV flags;
        public uint regionCount;
        public VkRect2D* pRegions;
        public static VkOpticalFlowExecuteInfoNV New()
        {
            VkOpticalFlowExecuteInfoNV ret = new VkOpticalFlowExecuteInfoNV();
            ret.sType = VkStructureType.OpticalFlowExecuteInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFaultFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 deviceFault;
        public VkBool32 deviceFaultVendorBinary;
        public static VkPhysicalDeviceFaultFeaturesEXT New()
        {
            VkPhysicalDeviceFaultFeaturesEXT ret = new VkPhysicalDeviceFaultFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFaultFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceFaultAddressInfoEXT
    {
        public VkDeviceFaultAddressTypeEXT addressType;
        public ulong reportedAddress;
        public ulong addressPrecision;
    }

    public unsafe partial struct VkDeviceFaultVendorInfoEXT
    {
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public ulong vendorFaultCode;
        public ulong vendorFaultData;
    }

    public unsafe partial struct VkDeviceFaultCountsEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint addressInfoCount;
        public uint vendorInfoCount;
        public ulong vendorBinarySize;
        public static VkDeviceFaultCountsEXT New()
        {
            VkDeviceFaultCountsEXT ret = new VkDeviceFaultCountsEXT();
            ret.sType = VkStructureType.DeviceFaultCountsEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceFaultInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte description[(int)VulkanNative.MaxDescriptionSize];
        public VkDeviceFaultAddressInfoEXT* pAddressInfos;
        public VkDeviceFaultVendorInfoEXT* pVendorInfos;
        public void* pVendorBinaryData;
        public static VkDeviceFaultInfoEXT New()
        {
            VkDeviceFaultInfoEXT ret = new VkDeviceFaultInfoEXT();
            ret.sType = VkStructureType.DeviceFaultInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceFaultVendorBinaryHeaderVersionOneEXT
    {
        public uint headerSize;
        public VkDeviceFaultVendorBinaryHeaderVersionEXT headerVersion;
        public uint vendorID;
        public uint deviceID;
        public uint driverVersion;
        public fixed byte pipelineCacheUUID[(int)VulkanNative.UuidSize];
        public uint applicationNameOffset;
        public uint applicationVersion;
        public uint engineNameOffset;
        public uint engineVersion;
        public uint apiVersion;
    }

    public unsafe partial struct VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineLibraryGroupHandles;
        public static VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT New()
        {
            VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT ret = new VkPhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDevicePipelineLibraryGroupHandlesFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDepthBiasInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public float depthBiasConstantFactor;
        public float depthBiasClamp;
        public float depthBiasSlopeFactor;
        public static VkDepthBiasInfoEXT New()
        {
            VkDepthBiasInfoEXT ret = new VkDepthBiasInfoEXT();
            ret.sType = VkStructureType.DepthBiasInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDepthBiasRepresentationInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDepthBiasRepresentationEXT depthBiasRepresentation;
        public VkBool32 depthBiasExact;
        public static VkDepthBiasRepresentationInfoEXT New()
        {
            VkDepthBiasRepresentationInfoEXT ret = new VkDepthBiasRepresentationInfoEXT();
            ret.sType = VkStructureType.DepthBiasRepresentationInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDecompressMemoryRegionNV
    {
        public ulong srcAddress;
        public ulong dstAddress;
        public ulong compressedSize;
        public ulong decompressedSize;
        public uint decompressionMethod;
    }

    public unsafe partial struct VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong shaderCoreMask;
        public uint shaderCoreCount;
        public uint shaderWarpsPerCore;
        public static VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM New()
        {
            VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM ret = new VkPhysicalDeviceShaderCoreBuiltinsPropertiesARM();
            ret.sType = VkStructureType.PhysicalDeviceShaderCoreBuiltinsPropertiesArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderCoreBuiltins;
        public static VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM New()
        {
            VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM ret = new VkPhysicalDeviceShaderCoreBuiltinsFeaturesARM();
            ret.sType = VkStructureType.PhysicalDeviceShaderCoreBuiltinsFeaturesArm;
            return ret;
        }
    }

    public unsafe partial struct VkFrameBoundaryEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFrameBoundaryFlagsEXT flags;
        public ulong frameID;
        public uint imageCount;
        public VkImage* pImages;
        public uint bufferCount;
        public VkBuffer* pBuffers;
        public ulong tagName;
        public UIntPtr tagSize;
        public void* pTag;
        public static VkFrameBoundaryEXT New()
        {
            VkFrameBoundaryEXT ret = new VkFrameBoundaryEXT();
            ret.sType = VkStructureType.FrameBoundaryEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFrameBoundaryFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 frameBoundary;
        public static VkPhysicalDeviceFrameBoundaryFeaturesEXT New()
        {
            VkPhysicalDeviceFrameBoundaryFeaturesEXT ret = new VkPhysicalDeviceFrameBoundaryFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceFrameBoundaryFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dynamicRenderingUnusedAttachments;
        public static VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT New()
        {
            VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT ret = new VkPhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDynamicRenderingUnusedAttachmentsFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSurfacePresentModeEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPresentModeKHR presentMode;
        public static VkSurfacePresentModeEXT New()
        {
            VkSurfacePresentModeEXT ret = new VkSurfacePresentModeEXT();
            ret.sType = VkStructureType.SurfacePresentModeEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSurfacePresentScalingCapabilitiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPresentScalingFlagsEXT supportedPresentScaling;
        public VkPresentGravityFlagsEXT supportedPresentGravityX;
        public VkPresentGravityFlagsEXT supportedPresentGravityY;
        public VkExtent2D minScaledImageExtent;
        public VkExtent2D maxScaledImageExtent;
        public static VkSurfacePresentScalingCapabilitiesEXT New()
        {
            VkSurfacePresentScalingCapabilitiesEXT ret = new VkSurfacePresentScalingCapabilitiesEXT();
            ret.sType = VkStructureType.SurfacePresentScalingCapabilitiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSurfacePresentModeCompatibilityEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint presentModeCount;
        public VkPresentModeKHR* pPresentModes;
        public static VkSurfacePresentModeCompatibilityEXT New()
        {
            VkSurfacePresentModeCompatibilityEXT ret = new VkSurfacePresentModeCompatibilityEXT();
            ret.sType = VkStructureType.SurfacePresentModeCompatibilityEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 swapchainMaintenance1;
        public static VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT New()
        {
            VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT ret = new VkPhysicalDeviceSwapchainMaintenance1FeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceSwapchainMaintenance1FeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSwapchainPresentFenceInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkFence* pFences;
        public static VkSwapchainPresentFenceInfoEXT New()
        {
            VkSwapchainPresentFenceInfoEXT ret = new VkSwapchainPresentFenceInfoEXT();
            ret.sType = VkStructureType.SwapchainPresentFenceInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSwapchainPresentModesCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint presentModeCount;
        public VkPresentModeKHR* pPresentModes;
        public static VkSwapchainPresentModesCreateInfoEXT New()
        {
            VkSwapchainPresentModesCreateInfoEXT ret = new VkSwapchainPresentModesCreateInfoEXT();
            ret.sType = VkStructureType.SwapchainPresentModesCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSwapchainPresentModeInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint swapchainCount;
        public VkPresentModeKHR* pPresentModes;
        public static VkSwapchainPresentModeInfoEXT New()
        {
            VkSwapchainPresentModeInfoEXT ret = new VkSwapchainPresentModeInfoEXT();
            ret.sType = VkStructureType.SwapchainPresentModeInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkSwapchainPresentScalingCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPresentScalingFlagsEXT scalingBehavior;
        public VkPresentGravityFlagsEXT presentGravityX;
        public VkPresentGravityFlagsEXT presentGravityY;
        public static VkSwapchainPresentScalingCreateInfoEXT New()
        {
            VkSwapchainPresentScalingCreateInfoEXT ret = new VkSwapchainPresentScalingCreateInfoEXT();
            ret.sType = VkStructureType.SwapchainPresentScalingCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkReleaseSwapchainImagesInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSwapchainKHR swapchain;
        public uint imageIndexCount;
        public uint* pImageIndices;
        public static VkReleaseSwapchainImagesInfoEXT New()
        {
            VkReleaseSwapchainImagesInfoEXT ret = new VkReleaseSwapchainImagesInfoEXT();
            ret.sType = VkStructureType.ReleaseSwapchainImagesInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDepthBiasControlFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 depthBiasControl;
        public VkBool32 leastRepresentableValueForceUnormRepresentation;
        public VkBool32 floatRepresentation;
        public VkBool32 depthBiasExact;
        public static VkPhysicalDeviceDepthBiasControlFeaturesEXT New()
        {
            VkPhysicalDeviceDepthBiasControlFeaturesEXT ret = new VkPhysicalDeviceDepthBiasControlFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceDepthBiasControlFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingInvocationReorderFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rayTracingInvocationReorder;
        public static VkPhysicalDeviceRayTracingInvocationReorderFeaturesNV New()
        {
            VkPhysicalDeviceRayTracingInvocationReorderFeaturesNV ret = new VkPhysicalDeviceRayTracingInvocationReorderFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingInvocationReorderFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRayTracingInvocationReorderModeNV rayTracingInvocationReorderReorderingHint;
        public static VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV New()
        {
            VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV ret = new VkPhysicalDeviceRayTracingInvocationReorderPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingInvocationReorderPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 extendedSparseAddressSpace;
        public static VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV New()
        {
            VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV ret = new VkPhysicalDeviceExtendedSparseAddressSpaceFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceExtendedSparseAddressSpaceFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong extendedSparseAddressSpaceSize;
        public VkImageUsageFlags extendedSparseImageUsageFlags;
        public VkBufferUsageFlags extendedSparseBufferUsageFlags;
        public static VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV New()
        {
            VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV ret = new VkPhysicalDeviceExtendedSparseAddressSpacePropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceExtendedSparseAddressSpacePropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkDirectDriverLoadingInfoLUNARG
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public IntPtr pfnGetInstanceProcAddr;
        public static VkDirectDriverLoadingInfoLUNARG New()
        {
            VkDirectDriverLoadingInfoLUNARG ret = new VkDirectDriverLoadingInfoLUNARG();
            ret.sType = VkStructureType.DirectDriverLoadingInfoLunarg;
            return ret;
        }
    }

    public unsafe partial struct VkDirectDriverLoadingListLUNARG
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDirectDriverLoadingModeLUNARG mode;
        public uint driverCount;
        public VkDirectDriverLoadingInfoLUNARG* pDrivers;
        public static VkDirectDriverLoadingListLUNARG New()
        {
            VkDirectDriverLoadingListLUNARG ret = new VkDirectDriverLoadingListLUNARG();
            ret.sType = VkStructureType.DirectDriverLoadingListLunarg;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 multiviewPerViewViewports;
        public static VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM New()
        {
            VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM ret = new VkPhysicalDeviceMultiviewPerViewViewportsFeaturesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceMultiviewPerViewViewportsFeaturesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 rayTracingPositionFetch;
        public static VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR New()
        {
            VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR ret = new VkPhysicalDeviceRayTracingPositionFetchFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceRayTracingPositionFetchFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceImageSubresourceInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkImageCreateInfo* pCreateInfo;
        public VkImageSubresource2* pSubresource;
        public static VkDeviceImageSubresourceInfo New()
        {
            VkDeviceImageSubresourceInfo ret = new VkDeviceImageSubresourceInfo();
            ret.sType = VkStructureType.DeviceImageSubresourceInfo;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceImageSubresourceInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderCorePropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint pixelRate;
        public uint texelRate;
        public uint fmaRate;
        public static VkPhysicalDeviceShaderCorePropertiesARM New()
        {
            VkPhysicalDeviceShaderCorePropertiesARM ret = new VkPhysicalDeviceShaderCorePropertiesARM();
            ret.sType = VkStructureType.PhysicalDeviceShaderCorePropertiesArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 multiviewPerViewRenderAreas;
        public static VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM New()
        {
            VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM ret = new VkPhysicalDeviceMultiviewPerViewRenderAreasFeaturesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceMultiviewPerViewRenderAreasFeaturesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint perViewRenderAreaCount;
        public VkRect2D* pPerViewRenderAreas;
        public static VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM New()
        {
            VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM ret = new VkMultiviewPerViewRenderAreasRenderPassBeginInfoQCOM();
            ret.sType = VkStructureType.MultiviewPerViewRenderAreasRenderPassBeginInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkQueryLowLatencySupportNV
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pQueriedLowLatencyData;
        public static VkQueryLowLatencySupportNV New()
        {
            VkQueryLowLatencySupportNV ret = new VkQueryLowLatencySupportNV();
            ret.sType = VkStructureType.QueryLowLatencySupportNV;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryMapInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryMapFlags flags;
        public VkDeviceMemory memory;
        public ulong offset;
        public ulong size;
        public static VkMemoryMapInfo New()
        {
            VkMemoryMapInfo ret = new VkMemoryMapInfo();
            ret.sType = VkStructureType.MemoryMapInfo;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryMapInfoKHR
    {
    }

    public unsafe partial struct VkMemoryUnmapInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkMemoryUnmapFlags flags;
        public VkDeviceMemory memory;
        public static VkMemoryUnmapInfo New()
        {
            VkMemoryUnmapInfo ret = new VkMemoryUnmapInfo();
            ret.sType = VkStructureType.MemoryUnmapInfo;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryUnmapInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderObjectFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderObject;
        public static VkPhysicalDeviceShaderObjectFeaturesEXT New()
        {
            VkPhysicalDeviceShaderObjectFeaturesEXT ret = new VkPhysicalDeviceShaderObjectFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderObjectFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderObjectPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public fixed byte shaderBinaryUUID[(int)VulkanNative.UuidSize];
        public uint shaderBinaryVersion;
        public static VkPhysicalDeviceShaderObjectPropertiesEXT New()
        {
            VkPhysicalDeviceShaderObjectPropertiesEXT ret = new VkPhysicalDeviceShaderObjectPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderObjectPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkShaderCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderCreateFlagsEXT flags;
        public VkShaderStageFlags stage;
        public VkShaderStageFlags nextStage;
        public VkShaderCodeTypeEXT codeType;
        public UIntPtr codeSize;
        public void* pCode;
        public byte* pName;
        public uint setLayoutCount;
        public VkDescriptorSetLayout* pSetLayouts;
        public uint pushConstantRangeCount;
        public VkPushConstantRange* pPushConstantRanges;
        public VkSpecializationInfo* pSpecializationInfo;
        public static VkShaderCreateInfoEXT New()
        {
            VkShaderCreateInfoEXT ret = new VkShaderCreateInfoEXT();
            ret.sType = VkStructureType.ShaderCreateInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderTileImageFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderTileImageColorReadAccess;
        public VkBool32 shaderTileImageDepthReadAccess;
        public VkBool32 shaderTileImageStencilReadAccess;
        public static VkPhysicalDeviceShaderTileImageFeaturesEXT New()
        {
            VkPhysicalDeviceShaderTileImageFeaturesEXT ret = new VkPhysicalDeviceShaderTileImageFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderTileImageFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderTileImagePropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderTileImageCoherentReadAccelerated;
        public VkBool32 shaderTileImageReadSampleFromPixelRateInvocation;
        public VkBool32 shaderTileImageReadFromHelperInvocation;
        public static VkPhysicalDeviceShaderTileImagePropertiesEXT New()
        {
            VkPhysicalDeviceShaderTileImagePropertiesEXT ret = new VkPhysicalDeviceShaderTileImagePropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderTileImagePropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkImportScreenBufferInfoQNX
    {
        public VkStructureType sType;
        public void* pNext;
        public Qnx.ScreenBuffer* buffer;
        public static VkImportScreenBufferInfoQNX New()
        {
            VkImportScreenBufferInfoQNX ret = new VkImportScreenBufferInfoQNX();
            ret.sType = VkStructureType.ImportScreenBufferInfoQnx;
            return ret;
        }
    }

    public unsafe partial struct VkScreenBufferPropertiesQNX
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong allocationSize;
        public uint memoryTypeBits;
        public static VkScreenBufferPropertiesQNX New()
        {
            VkScreenBufferPropertiesQNX ret = new VkScreenBufferPropertiesQNX();
            ret.sType = VkStructureType.ScreenBufferPropertiesQnx;
            return ret;
        }
    }

    public unsafe partial struct VkScreenBufferFormatPropertiesQNX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat format;
        public ulong externalFormat;
        public ulong screenUsage;
        public VkFormatFeatureFlags formatFeatures;
        public VkComponentMapping samplerYcbcrConversionComponents;
        public VkSamplerYcbcrModelConversion suggestedYcbcrModel;
        public VkSamplerYcbcrRange suggestedYcbcrRange;
        public VkChromaLocation suggestedXChromaOffset;
        public VkChromaLocation suggestedYChromaOffset;
        public static VkScreenBufferFormatPropertiesQNX New()
        {
            VkScreenBufferFormatPropertiesQNX ret = new VkScreenBufferFormatPropertiesQNX();
            ret.sType = VkStructureType.ScreenBufferFormatPropertiesQnx;
            return ret;
        }
    }

    public unsafe partial struct VkExternalFormatQNX
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong externalFormat;
        public static VkExternalFormatQNX New()
        {
            VkExternalFormatQNX ret = new VkExternalFormatQNX();
            ret.sType = VkStructureType.ExternalFormatQnx;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 screenBufferImport;
        public static VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX New()
        {
            VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX ret = new VkPhysicalDeviceExternalMemoryScreenBufferFeaturesQNX();
            ret.sType = VkStructureType.PhysicalDeviceExternalMemoryScreenBufferFeaturesQnx;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 cooperativeMatrix;
        public VkBool32 cooperativeMatrixRobustBufferAccess;
        public static VkPhysicalDeviceCooperativeMatrixFeaturesKHR New()
        {
            VkPhysicalDeviceCooperativeMatrixFeaturesKHR ret = new VkPhysicalDeviceCooperativeMatrixFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceCooperativeMatrixFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkCooperativeMatrixPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public uint MSize;
        public uint NSize;
        public uint KSize;
        public VkComponentTypeKHR AType;
        public VkComponentTypeKHR BType;
        public VkComponentTypeKHR CType;
        public VkComponentTypeKHR ResultType;
        public VkBool32 saturatingAccumulation;
        public VkScopeKHR scope;
        public static VkCooperativeMatrixPropertiesKHR New()
        {
            VkCooperativeMatrixPropertiesKHR ret = new VkCooperativeMatrixPropertiesKHR();
            ret.sType = VkStructureType.CooperativeMatrixPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCooperativeMatrixPropertiesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags cooperativeMatrixSupportedStages;
        public static VkPhysicalDeviceCooperativeMatrixPropertiesKHR New()
        {
            VkPhysicalDeviceCooperativeMatrixPropertiesKHR ret = new VkPhysicalDeviceCooperativeMatrixPropertiesKHR();
            ret.sType = VkStructureType.PhysicalDeviceCooperativeMatrixPropertiesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderEnqueuePropertiesAMDX
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxExecutionGraphDepth;
        public uint maxExecutionGraphShaderOutputNodes;
        public uint maxExecutionGraphShaderPayloadSize;
        public uint maxExecutionGraphShaderPayloadCount;
        public uint executionGraphDispatchAddressAlignment;
        public uint maxExecutionGraphWorkgroupCount_0;
        public uint maxExecutionGraphWorkgroupCount_1;
        public uint maxExecutionGraphWorkgroupCount_2;
        public uint maxExecutionGraphWorkgroups;
        public static VkPhysicalDeviceShaderEnqueuePropertiesAMDX New()
        {
            VkPhysicalDeviceShaderEnqueuePropertiesAMDX ret = new VkPhysicalDeviceShaderEnqueuePropertiesAMDX();
            ret.sType = VkStructureType.PhysicalDeviceShaderEnqueuePropertiesAmdx;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderEnqueueFeaturesAMDX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderEnqueue;
        public VkBool32 shaderMeshEnqueue;
        public static VkPhysicalDeviceShaderEnqueueFeaturesAMDX New()
        {
            VkPhysicalDeviceShaderEnqueueFeaturesAMDX ret = new VkPhysicalDeviceShaderEnqueueFeaturesAMDX();
            ret.sType = VkStructureType.PhysicalDeviceShaderEnqueueFeaturesAmdx;
            return ret;
        }
    }

    public unsafe partial struct VkExecutionGraphPipelineCreateInfoAMDX
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineCreateFlags flags;
        public uint stageCount;
        public VkPipelineShaderStageCreateInfo* pStages;
        public VkPipelineLibraryCreateInfoKHR* pLibraryInfo;
        public VkPipelineLayout layout;
        public VkPipeline basePipelineHandle;
        public int basePipelineIndex;
        public static VkExecutionGraphPipelineCreateInfoAMDX New()
        {
            VkExecutionGraphPipelineCreateInfoAMDX ret = new VkExecutionGraphPipelineCreateInfoAMDX();
            ret.sType = VkStructureType.ExecutionGraphPipelineCreateInfoAmdx;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineShaderStageNodeCreateInfoAMDX
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pName;
        public uint index;
        public static VkPipelineShaderStageNodeCreateInfoAMDX New()
        {
            VkPipelineShaderStageNodeCreateInfoAMDX ret = new VkPipelineShaderStageNodeCreateInfoAMDX();
            ret.sType = VkStructureType.PipelineShaderStageNodeCreateInfoAmdx;
            return ret;
        }
    }

    public unsafe partial struct VkExecutionGraphPipelineScratchSizeAMDX
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong minSize;
        public ulong maxSize;
        public ulong sizeGranularity;
        public static VkExecutionGraphPipelineScratchSizeAMDX New()
        {
            VkExecutionGraphPipelineScratchSizeAMDX ret = new VkExecutionGraphPipelineScratchSizeAMDX();
            ret.sType = VkStructureType.ExecutionGraphPipelineScratchSizeAmdx;
            return ret;
        }
    }

    public unsafe partial struct VkDispatchGraphInfoAMDX
    {
        public uint nodeIndex;
        public uint payloadCount;
        public VkDeviceOrHostAddressConstAMDX payloads;
        public ulong payloadStride;
    }

    public unsafe partial struct VkDispatchGraphCountInfoAMDX
    {
        public uint count;
        public VkDeviceOrHostAddressConstAMDX infos;
        public ulong stride;
    }

    public unsafe partial struct VkPhysicalDeviceAntiLagFeaturesAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 antiLag;
        public static VkPhysicalDeviceAntiLagFeaturesAMD New()
        {
            VkPhysicalDeviceAntiLagFeaturesAMD ret = new VkPhysicalDeviceAntiLagFeaturesAMD();
            ret.sType = VkStructureType.PhysicalDeviceAntiLagFeaturesAMD;
            return ret;
        }
    }

    public unsafe partial struct VkAntiLagDataAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAntiLagModeAMD mode;
        public uint maxFPS;
        public VkAntiLagPresentationInfoAMD* pPresentationInfo;
        public static VkAntiLagDataAMD New()
        {
            VkAntiLagDataAMD ret = new VkAntiLagDataAMD();
            ret.sType = VkStructureType.AntiLagDataAMD;
            return ret;
        }
    }

    public unsafe partial struct VkAntiLagPresentationInfoAMD
    {
        public VkStructureType sType;
        public void* pNext;
        public VkAntiLagStageAMD stage;
        public ulong frameIndex;
        public static VkAntiLagPresentationInfoAMD New()
        {
            VkAntiLagPresentationInfoAMD ret = new VkAntiLagPresentationInfoAMD();
            ret.sType = VkStructureType.AntiLagPresentationInfoAMD;
            return ret;
        }
    }

    public unsafe partial struct VkBindMemoryStatus
    {
        public VkStructureType sType;
        public void* pNext;
        public VkResult* pResult;
        public static VkBindMemoryStatus New()
        {
            VkBindMemoryStatus ret = new VkBindMemoryStatus();
            ret.sType = VkStructureType.BindMemoryStatus;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTileMemoryHeapFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 tileMemoryHeap;
        public static VkPhysicalDeviceTileMemoryHeapFeaturesQCOM New()
        {
            VkPhysicalDeviceTileMemoryHeapFeaturesQCOM ret = new VkPhysicalDeviceTileMemoryHeapFeaturesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceTileMemoryHeapFeaturesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTileMemoryHeapPropertiesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 queueSubmitBoundary;
        public VkBool32 tileBufferTransfers;
        public static VkPhysicalDeviceTileMemoryHeapPropertiesQCOM New()
        {
            VkPhysicalDeviceTileMemoryHeapPropertiesQCOM ret = new VkPhysicalDeviceTileMemoryHeapPropertiesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceTileMemoryHeapPropertiesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkTileMemorySizeInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong size;
        public static VkTileMemorySizeInfoQCOM New()
        {
            VkTileMemorySizeInfoQCOM ret = new VkTileMemorySizeInfoQCOM();
            ret.sType = VkStructureType.TileMemorySizeInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkTileMemoryRequirementsQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong size;
        public ulong alignment;
        public static VkTileMemoryRequirementsQCOM New()
        {
            VkTileMemoryRequirementsQCOM ret = new VkTileMemoryRequirementsQCOM();
            ret.sType = VkStructureType.TileMemoryRequirementsQcom;
            return ret;
        }
    }

    public unsafe partial struct VkBindMemoryStatusKHR
    {
    }

    public unsafe partial struct VkBindDescriptorSetsInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags stageFlags;
        public VkPipelineLayout layout;
        public uint firstSet;
        public uint descriptorSetCount;
        public VkDescriptorSet* pDescriptorSets;
        public uint dynamicOffsetCount;
        public uint* pDynamicOffsets;
        public static VkBindDescriptorSetsInfo New()
        {
            VkBindDescriptorSetsInfo ret = new VkBindDescriptorSetsInfo();
            ret.sType = VkStructureType.BindDescriptorSetsInfo;
            return ret;
        }
    }

    public unsafe partial struct VkBindDescriptorSetsInfoKHR
    {
    }

    public unsafe partial struct VkPushConstantsInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkPipelineLayout layout;
        public VkShaderStageFlags stageFlags;
        public uint offset;
        public uint size;
        public void* pValues;
        public static VkPushConstantsInfo New()
        {
            VkPushConstantsInfo ret = new VkPushConstantsInfo();
            ret.sType = VkStructureType.PushConstantsInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPushConstantsInfoKHR
    {
    }

    public unsafe partial struct VkPushDescriptorSetInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags stageFlags;
        public VkPipelineLayout layout;
        public uint set;
        public uint descriptorWriteCount;
        public VkWriteDescriptorSet* pDescriptorWrites;
        public static VkPushDescriptorSetInfo New()
        {
            VkPushDescriptorSetInfo ret = new VkPushDescriptorSetInfo();
            ret.sType = VkStructureType.PushDescriptorSetInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPushDescriptorSetInfoKHR
    {
    }

    public unsafe partial struct VkPushDescriptorSetWithTemplateInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDescriptorUpdateTemplate descriptorUpdateTemplate;
        public VkPipelineLayout layout;
        public uint set;
        public void* pData;
        public static VkPushDescriptorSetWithTemplateInfo New()
        {
            VkPushDescriptorSetWithTemplateInfo ret = new VkPushDescriptorSetWithTemplateInfo();
            ret.sType = VkStructureType.PushDescriptorSetWithTemplateInfo;
            return ret;
        }
    }

    public unsafe partial struct VkPushDescriptorSetWithTemplateInfoKHR
    {
    }

    public unsafe partial struct VkSetDescriptorBufferOffsetsInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags stageFlags;
        public VkPipelineLayout layout;
        public uint firstSet;
        public uint setCount;
        public uint* pBufferIndices;
        public ulong* pOffsets;
        public static VkSetDescriptorBufferOffsetsInfoEXT New()
        {
            VkSetDescriptorBufferOffsetsInfoEXT ret = new VkSetDescriptorBufferOffsetsInfoEXT();
            ret.sType = VkStructureType.SetDescriptorBufferOffsetsInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkBindDescriptorBufferEmbeddedSamplersInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags stageFlags;
        public VkPipelineLayout layout;
        public uint set;
        public static VkBindDescriptorBufferEmbeddedSamplersInfoEXT New()
        {
            VkBindDescriptorBufferEmbeddedSamplersInfoEXT ret = new VkBindDescriptorBufferEmbeddedSamplersInfoEXT();
            ret.sType = VkStructureType.BindDescriptorBufferEmbeddedSamplersInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCubicClampFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 cubicRangeClamp;
        public static VkPhysicalDeviceCubicClampFeaturesQCOM New()
        {
            VkPhysicalDeviceCubicClampFeaturesQCOM ret = new VkPhysicalDeviceCubicClampFeaturesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceCubicClampFeaturesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceYcbcrDegammaFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 ycbcrDegamma;
        public static VkPhysicalDeviceYcbcrDegammaFeaturesQCOM New()
        {
            VkPhysicalDeviceYcbcrDegammaFeaturesQCOM ret = new VkPhysicalDeviceYcbcrDegammaFeaturesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceYcbcrDegammaFeaturesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 enableYDegamma;
        public VkBool32 enableCbCrDegamma;
        public static VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM New()
        {
            VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM ret = new VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM();
            ret.sType = VkStructureType.SamplerYcbcrConversionYcbcrDegammaCreateInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCubicWeightsFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 selectableCubicWeights;
        public static VkPhysicalDeviceCubicWeightsFeaturesQCOM New()
        {
            VkPhysicalDeviceCubicWeightsFeaturesQCOM ret = new VkPhysicalDeviceCubicWeightsFeaturesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceCubicWeightsFeaturesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerCubicWeightsCreateInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCubicFilterWeightsQCOM cubicWeights;
        public static VkSamplerCubicWeightsCreateInfoQCOM New()
        {
            VkSamplerCubicWeightsCreateInfoQCOM ret = new VkSamplerCubicWeightsCreateInfoQCOM();
            ret.sType = VkStructureType.SamplerCubicWeightsCreateInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkBlitImageCubicWeightsInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkCubicFilterWeightsQCOM cubicWeights;
        public static VkBlitImageCubicWeightsInfoQCOM New()
        {
            VkBlitImageCubicWeightsInfoQCOM ret = new VkBlitImageCubicWeightsInfoQCOM();
            ret.sType = VkStructureType.BlitImageCubicWeightsInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageProcessing2FeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 textureBlockMatch2;
        public static VkPhysicalDeviceImageProcessing2FeaturesQCOM New()
        {
            VkPhysicalDeviceImageProcessing2FeaturesQCOM ret = new VkPhysicalDeviceImageProcessing2FeaturesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceImageProcessing2FeaturesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageProcessing2PropertiesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D maxBlockMatchWindow;
        public static VkPhysicalDeviceImageProcessing2PropertiesQCOM New()
        {
            VkPhysicalDeviceImageProcessing2PropertiesQCOM ret = new VkPhysicalDeviceImageProcessing2PropertiesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceImageProcessing2PropertiesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkSamplerBlockMatchWindowCreateInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D windowExtent;
        public VkBlockMatchWindowCompareModeQCOM windowCompareMode;
        public static VkSamplerBlockMatchWindowCreateInfoQCOM New()
        {
            VkSamplerBlockMatchWindowCreateInfoQCOM ret = new VkSamplerBlockMatchWindowCreateInfoQCOM();
            ret.sType = VkStructureType.SamplerBlockMatchWindowCreateInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 descriptorPoolOverallocation;
        public static VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV New()
        {
            VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV ret = new VkPhysicalDeviceDescriptorPoolOverallocationFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceDescriptorPoolOverallocationFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceLayeredDriverPropertiesMSFT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkLayeredDriverUnderlyingApiMSFT underlyingAPI;
        public static VkPhysicalDeviceLayeredDriverPropertiesMSFT New()
        {
            VkPhysicalDeviceLayeredDriverPropertiesMSFT ret = new VkPhysicalDeviceLayeredDriverPropertiesMSFT();
            ret.sType = VkStructureType.PhysicalDeviceLayeredDriverPropertiesMsft;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePerStageDescriptorSetFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 perStageDescriptorSet;
        public VkBool32 dynamicPipelineLayout;
        public static VkPhysicalDevicePerStageDescriptorSetFeaturesNV New()
        {
            VkPhysicalDevicePerStageDescriptorSetFeaturesNV ret = new VkPhysicalDevicePerStageDescriptorSetFeaturesNV();
            ret.sType = VkStructureType.PhysicalDevicePerStageDescriptorSetFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalFormatResolveFeaturesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 externalFormatResolve;
        public static VkPhysicalDeviceExternalFormatResolveFeaturesANDROID New()
        {
            VkPhysicalDeviceExternalFormatResolveFeaturesANDROID ret = new VkPhysicalDeviceExternalFormatResolveFeaturesANDROID();
            ret.sType = VkStructureType.PhysicalDeviceExternalFormatResolveFeaturesAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalFormatResolvePropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 nullColorAttachmentWithExternalFormatResolve;
        public VkChromaLocation externalFormatResolveChromaOffsetX;
        public VkChromaLocation externalFormatResolveChromaOffsetY;
        public static VkPhysicalDeviceExternalFormatResolvePropertiesANDROID New()
        {
            VkPhysicalDeviceExternalFormatResolvePropertiesANDROID ret = new VkPhysicalDeviceExternalFormatResolvePropertiesANDROID();
            ret.sType = VkStructureType.PhysicalDeviceExternalFormatResolvePropertiesAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkAndroidHardwareBufferFormatResolvePropertiesANDROID
    {
        public VkStructureType sType;
        public void* pNext;
        public VkFormat colorAttachmentFormat;
        public static VkAndroidHardwareBufferFormatResolvePropertiesANDROID New()
        {
            VkAndroidHardwareBufferFormatResolvePropertiesANDROID ret = new VkAndroidHardwareBufferFormatResolvePropertiesANDROID();
            ret.sType = VkStructureType.AndroidHardwareBufferFormatResolvePropertiesAndroid;
            return ret;
        }
    }

    public unsafe partial struct VkLatencySleepModeInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 lowLatencyMode;
        public VkBool32 lowLatencyBoost;
        public uint minimumIntervalUs;
        public static VkLatencySleepModeInfoNV New()
        {
            VkLatencySleepModeInfoNV ret = new VkLatencySleepModeInfoNV();
            ret.sType = VkStructureType.LatencySleepModeInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkLatencySleepInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkSemaphore signalSemaphore;
        public ulong value;
        public static VkLatencySleepInfoNV New()
        {
            VkLatencySleepInfoNV ret = new VkLatencySleepInfoNV();
            ret.sType = VkStructureType.LatencySleepInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkSetLatencyMarkerInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong presentID;
        public VkLatencyMarkerNV marker;
        public static VkSetLatencyMarkerInfoNV New()
        {
            VkSetLatencyMarkerInfoNV ret = new VkSetLatencyMarkerInfoNV();
            ret.sType = VkStructureType.SetLatencyMarkerInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkGetLatencyMarkerInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint timingCount;
        public VkLatencyTimingsFrameReportNV* pTimings;
        public static VkGetLatencyMarkerInfoNV New()
        {
            VkGetLatencyMarkerInfoNV ret = new VkGetLatencyMarkerInfoNV();
            ret.sType = VkStructureType.GetLatencyMarkerInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkLatencyTimingsFrameReportNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong presentID;
        public ulong inputSampleTimeUs;
        public ulong simStartTimeUs;
        public ulong simEndTimeUs;
        public ulong renderSubmitStartTimeUs;
        public ulong renderSubmitEndTimeUs;
        public ulong presentStartTimeUs;
        public ulong presentEndTimeUs;
        public ulong driverStartTimeUs;
        public ulong driverEndTimeUs;
        public ulong osRenderQueueStartTimeUs;
        public ulong osRenderQueueEndTimeUs;
        public ulong gpuRenderStartTimeUs;
        public ulong gpuRenderEndTimeUs;
        public static VkLatencyTimingsFrameReportNV New()
        {
            VkLatencyTimingsFrameReportNV ret = new VkLatencyTimingsFrameReportNV();
            ret.sType = VkStructureType.LatencyTimingsFrameReportNV;
            return ret;
        }
    }

    public unsafe partial struct VkOutOfBandQueueTypeInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkOutOfBandQueueTypeNV queueType;
        public static VkOutOfBandQueueTypeInfoNV New()
        {
            VkOutOfBandQueueTypeInfoNV ret = new VkOutOfBandQueueTypeInfoNV();
            ret.sType = VkStructureType.OutOfBandQueueTypeInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkLatencySubmissionPresentIdNV
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong presentID;
        public static VkLatencySubmissionPresentIdNV New()
        {
            VkLatencySubmissionPresentIdNV ret = new VkLatencySubmissionPresentIdNV();
            ret.sType = VkStructureType.LatencySubmissionPresentIdNV;
            return ret;
        }
    }

    public unsafe partial struct VkSwapchainLatencyCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 latencyModeEnable;
        public static VkSwapchainLatencyCreateInfoNV New()
        {
            VkSwapchainLatencyCreateInfoNV ret = new VkSwapchainLatencyCreateInfoNV();
            ret.sType = VkStructureType.SwapchainLatencyCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkLatencySurfaceCapabilitiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint presentModeCount;
        public VkPresentModeKHR* pPresentModes;
        public static VkLatencySurfaceCapabilitiesNV New()
        {
            VkLatencySurfaceCapabilitiesNV ret = new VkLatencySurfaceCapabilitiesNV();
            ret.sType = VkStructureType.LatencySurfaceCapabilitiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCudaKernelLaunchFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 cudaKernelLaunchFeatures;
        public static VkPhysicalDeviceCudaKernelLaunchFeaturesNV New()
        {
            VkPhysicalDeviceCudaKernelLaunchFeaturesNV ret = new VkPhysicalDeviceCudaKernelLaunchFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceCudaKernelLaunchFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCudaKernelLaunchPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint computeCapabilityMinor;
        public uint computeCapabilityMajor;
        public static VkPhysicalDeviceCudaKernelLaunchPropertiesNV New()
        {
            VkPhysicalDeviceCudaKernelLaunchPropertiesNV ret = new VkPhysicalDeviceCudaKernelLaunchPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceCudaKernelLaunchPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceQueueShaderCoreControlCreateInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint shaderCoreCount;
        public static VkDeviceQueueShaderCoreControlCreateInfoARM New()
        {
            VkDeviceQueueShaderCoreControlCreateInfoARM ret = new VkDeviceQueueShaderCoreControlCreateInfoARM();
            ret.sType = VkStructureType.DeviceQueueShaderCoreControlCreateInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSchedulingControlsFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 schedulingControls;
        public static VkPhysicalDeviceSchedulingControlsFeaturesARM New()
        {
            VkPhysicalDeviceSchedulingControlsFeaturesARM ret = new VkPhysicalDeviceSchedulingControlsFeaturesARM();
            ret.sType = VkStructureType.PhysicalDeviceSchedulingControlsFeaturesArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceSchedulingControlsPropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint schedulingControlsFlags;
        public static VkPhysicalDeviceSchedulingControlsPropertiesARM New()
        {
            VkPhysicalDeviceSchedulingControlsPropertiesARM ret = new VkPhysicalDeviceSchedulingControlsPropertiesARM();
            ret.sType = VkStructureType.PhysicalDeviceSchedulingControlsPropertiesArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 relaxedLineRasterization;
        public static VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG New()
        {
            VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG ret = new VkPhysicalDeviceRelaxedLineRasterizationFeaturesIMG();
            ret.sType = VkStructureType.PhysicalDeviceRelaxedLineRasterizationFeaturesImg;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRenderPassStripedFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 renderPassStriped;
        public static VkPhysicalDeviceRenderPassStripedFeaturesARM New()
        {
            VkPhysicalDeviceRenderPassStripedFeaturesARM ret = new VkPhysicalDeviceRenderPassStripedFeaturesARM();
            ret.sType = VkStructureType.PhysicalDeviceRenderPassStripedFeaturesArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRenderPassStripedPropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExtent2D renderPassStripeGranularity;
        public uint maxRenderPassStripes;
        public static VkPhysicalDeviceRenderPassStripedPropertiesARM New()
        {
            VkPhysicalDeviceRenderPassStripedPropertiesARM ret = new VkPhysicalDeviceRenderPassStripedPropertiesARM();
            ret.sType = VkStructureType.PhysicalDeviceRenderPassStripedPropertiesArm;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassStripeInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkRect2D stripeArea;
        public static VkRenderPassStripeInfoARM New()
        {
            VkRenderPassStripeInfoARM ret = new VkRenderPassStripeInfoARM();
            ret.sType = VkStructureType.RenderPassStripeInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassStripeBeginInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stripeInfoCount;
        public VkRenderPassStripeInfoARM* pStripeInfos;
        public static VkRenderPassStripeBeginInfoARM New()
        {
            VkRenderPassStripeBeginInfoARM ret = new VkRenderPassStripeBeginInfoARM();
            ret.sType = VkStructureType.RenderPassStripeBeginInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassStripeSubmitInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint stripeSemaphoreInfoCount;
        public VkSemaphoreSubmitInfo* pStripeSemaphoreInfos;
        public static VkRenderPassStripeSubmitInfoARM New()
        {
            VkRenderPassStripeSubmitInfoARM ret = new VkRenderPassStripeSubmitInfoARM();
            ret.sType = VkStructureType.RenderPassStripeSubmitInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePipelineOpacityMicromapFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 pipelineOpacityMicromap;
        public static VkPhysicalDevicePipelineOpacityMicromapFeaturesARM New()
        {
            VkPhysicalDevicePipelineOpacityMicromapFeaturesARM ret = new VkPhysicalDevicePipelineOpacityMicromapFeaturesARM();
            ret.sType = VkStructureType.PhysicalDevicePipelineOpacityMicromapFeaturesArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderMaximalReconvergence;
        public static VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR New()
        {
            VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR ret = new VkPhysicalDeviceShaderMaximalReconvergenceFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceShaderMaximalReconvergenceFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderSubgroupRotateFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderSubgroupRotate;
        public VkBool32 shaderSubgroupRotateClustered;
        public static VkPhysicalDeviceShaderSubgroupRotateFeatures New()
        {
            VkPhysicalDeviceShaderSubgroupRotateFeatures ret = new VkPhysicalDeviceShaderSubgroupRotateFeatures();
            ret.sType = VkStructureType.PhysicalDeviceShaderSubgroupRotateFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderSubgroupRotateFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderExpectAssumeFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderExpectAssume;
        public static VkPhysicalDeviceShaderExpectAssumeFeatures New()
        {
            VkPhysicalDeviceShaderExpectAssumeFeatures ret = new VkPhysicalDeviceShaderExpectAssumeFeatures();
            ret.sType = VkStructureType.PhysicalDeviceShaderExpectAssumeFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderExpectAssumeFeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderFloatControls2Features
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderFloatControls2;
        public static VkPhysicalDeviceShaderFloatControls2Features New()
        {
            VkPhysicalDeviceShaderFloatControls2Features ret = new VkPhysicalDeviceShaderFloatControls2Features();
            ret.sType = VkStructureType.PhysicalDeviceShaderFloatControls2Features;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderFloatControls2FeaturesKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceDynamicRenderingLocalReadFeatures
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 dynamicRenderingLocalRead;
        public static VkPhysicalDeviceDynamicRenderingLocalReadFeatures New()
        {
            VkPhysicalDeviceDynamicRenderingLocalReadFeatures ret = new VkPhysicalDeviceDynamicRenderingLocalReadFeatures();
            ret.sType = VkStructureType.PhysicalDeviceDynamicRenderingLocalReadFeatures;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDynamicRenderingLocalReadFeaturesKHR
    {
    }

    public unsafe partial struct VkRenderingAttachmentLocationInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint colorAttachmentCount;
        public uint* pColorAttachmentLocations;
        public static VkRenderingAttachmentLocationInfo New()
        {
            VkRenderingAttachmentLocationInfo ret = new VkRenderingAttachmentLocationInfo();
            ret.sType = VkStructureType.RenderingAttachmentLocationInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderingAttachmentLocationInfoKHR
    {
    }

    public unsafe partial struct VkRenderingInputAttachmentIndexInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public uint colorAttachmentCount;
        public uint* pColorAttachmentInputIndices;
        public uint* pDepthInputAttachmentIndex;
        public uint* pStencilInputAttachmentIndex;
        public static VkRenderingInputAttachmentIndexInfo New()
        {
            VkRenderingInputAttachmentIndexInfo ret = new VkRenderingInputAttachmentIndexInfo();
            ret.sType = VkStructureType.RenderingInputAttachmentIndexInfo;
            return ret;
        }
    }

    public unsafe partial struct VkRenderingInputAttachmentIndexInfoKHR
    {
    }

    public unsafe partial struct VkPhysicalDeviceShaderQuadControlFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderQuadControl;
        public static VkPhysicalDeviceShaderQuadControlFeaturesKHR New()
        {
            VkPhysicalDeviceShaderQuadControlFeaturesKHR ret = new VkPhysicalDeviceShaderQuadControlFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceShaderQuadControlFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderFloat16VectorAtomics;
        public static VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV New()
        {
            VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV ret = new VkPhysicalDeviceShaderAtomicFloat16VectorFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceShaderAtomicFloat16VectorFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMapMemoryPlacedFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 memoryMapPlaced;
        public VkBool32 memoryMapRangePlaced;
        public VkBool32 memoryUnmapReserve;
        public static VkPhysicalDeviceMapMemoryPlacedFeaturesEXT New()
        {
            VkPhysicalDeviceMapMemoryPlacedFeaturesEXT ret = new VkPhysicalDeviceMapMemoryPlacedFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceMapMemoryPlacedFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceMapMemoryPlacedPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong minPlacedMemoryMapAlignment;
        public static VkPhysicalDeviceMapMemoryPlacedPropertiesEXT New()
        {
            VkPhysicalDeviceMapMemoryPlacedPropertiesEXT ret = new VkPhysicalDeviceMapMemoryPlacedPropertiesEXT();
            ret.sType = VkStructureType.PhysicalDeviceMapMemoryPlacedPropertiesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryMapPlacedInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public void* pPlacedAddress;
        public static VkMemoryMapPlacedInfoEXT New()
        {
            VkMemoryMapPlacedInfoEXT ret = new VkMemoryMapPlacedInfoEXT();
            ret.sType = VkStructureType.MemoryMapPlacedInfoEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderBfloat16FeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderBFloat16Type;
        public VkBool32 shaderBFloat16DotProduct;
        public VkBool32 shaderBFloat16CooperativeMatrix;
        public static VkPhysicalDeviceShaderBfloat16FeaturesKHR New()
        {
            VkPhysicalDeviceShaderBfloat16FeaturesKHR ret = new VkPhysicalDeviceShaderBfloat16FeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceShaderBfloat16FeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceRawAccessChainsFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderRawAccessChains;
        public static VkPhysicalDeviceRawAccessChainsFeaturesNV New()
        {
            VkPhysicalDeviceRawAccessChainsFeaturesNV ret = new VkPhysicalDeviceRawAccessChainsFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceRawAccessChainsFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCommandBufferInheritanceFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 commandBufferInheritance;
        public static VkPhysicalDeviceCommandBufferInheritanceFeaturesNV New()
        {
            VkPhysicalDeviceCommandBufferInheritanceFeaturesNV ret = new VkPhysicalDeviceCommandBufferInheritanceFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceCommandBufferInheritanceFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageAlignmentControlFeaturesMESA
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 imageAlignmentControl;
        public static VkPhysicalDeviceImageAlignmentControlFeaturesMESA New()
        {
            VkPhysicalDeviceImageAlignmentControlFeaturesMESA ret = new VkPhysicalDeviceImageAlignmentControlFeaturesMESA();
            ret.sType = VkStructureType.PhysicalDeviceImageAlignmentControlFeaturesMesa;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceImageAlignmentControlPropertiesMESA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint supportedImageAlignmentMask;
        public static VkPhysicalDeviceImageAlignmentControlPropertiesMESA New()
        {
            VkPhysicalDeviceImageAlignmentControlPropertiesMESA ret = new VkPhysicalDeviceImageAlignmentControlPropertiesMESA();
            ret.sType = VkStructureType.PhysicalDeviceImageAlignmentControlPropertiesMesa;
            return ret;
        }
    }

    public unsafe partial struct VkImageAlignmentControlCreateInfoMESA
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maximumRequestedAlignment;
        public static VkImageAlignmentControlCreateInfoMESA New()
        {
            VkImageAlignmentControlCreateInfoMESA ret = new VkImageAlignmentControlCreateInfoMESA();
            ret.sType = VkStructureType.ImageAlignmentControlCreateInfoMesa;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderReplicatedComposites;
        public static VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT New()
        {
            VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT ret = new VkPhysicalDeviceShaderReplicatedCompositesFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderReplicatedCompositesFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePresentModeFifoLatestReadyFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 presentModeFifoLatestReady;
        public static VkPhysicalDevicePresentModeFifoLatestReadyFeaturesEXT New()
        {
            VkPhysicalDevicePresentModeFifoLatestReadyFeaturesEXT ret = new VkPhysicalDevicePresentModeFifoLatestReadyFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDevicePresentModeFifoLatestReadyFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkDepthClampRangeEXT
    {
        public float minDepthClamp;
        public float maxDepthClamp;
    }

    public unsafe partial struct VkPhysicalDeviceCooperativeMatrix2FeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 cooperativeMatrixWorkgroupScope;
        public VkBool32 cooperativeMatrixFlexibleDimensions;
        public VkBool32 cooperativeMatrixReductions;
        public VkBool32 cooperativeMatrixConversions;
        public VkBool32 cooperativeMatrixPerElementOperations;
        public VkBool32 cooperativeMatrixTensorAddressing;
        public VkBool32 cooperativeMatrixBlockLoads;
        public static VkPhysicalDeviceCooperativeMatrix2FeaturesNV New()
        {
            VkPhysicalDeviceCooperativeMatrix2FeaturesNV ret = new VkPhysicalDeviceCooperativeMatrix2FeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceCooperativeMatrix2FeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCooperativeMatrix2PropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint cooperativeMatrixWorkgroupScopeMaxWorkgroupSize;
        public uint cooperativeMatrixFlexibleDimensionsMaxDimension;
        public uint cooperativeMatrixWorkgroupScopeReservedSharedMemory;
        public static VkPhysicalDeviceCooperativeMatrix2PropertiesNV New()
        {
            VkPhysicalDeviceCooperativeMatrix2PropertiesNV ret = new VkPhysicalDeviceCooperativeMatrix2PropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceCooperativeMatrix2PropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkCooperativeMatrixFlexibleDimensionsPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint MGranularity;
        public uint NGranularity;
        public uint KGranularity;
        public VkComponentTypeKHR AType;
        public VkComponentTypeKHR BType;
        public VkComponentTypeKHR CType;
        public VkComponentTypeKHR ResultType;
        public VkBool32 saturatingAccumulation;
        public VkScopeKHR scope;
        public uint workgroupInvocations;
        public static VkCooperativeMatrixFlexibleDimensionsPropertiesNV New()
        {
            VkCooperativeMatrixFlexibleDimensionsPropertiesNV ret = new VkCooperativeMatrixFlexibleDimensionsPropertiesNV();
            ret.sType = VkStructureType.CooperativeMatrixFlexibleDimensionsPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceHdrVividFeaturesHUAWEI
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 hdrVivid;
        public static VkPhysicalDeviceHdrVividFeaturesHUAWEI New()
        {
            VkPhysicalDeviceHdrVividFeaturesHUAWEI ret = new VkPhysicalDeviceHdrVividFeaturesHUAWEI();
            ret.sType = VkStructureType.PhysicalDeviceHdrVividFeaturesHuawei;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceVertexAttributeRobustnessFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 vertexAttributeRobustness;
        public static VkPhysicalDeviceVertexAttributeRobustnessFeaturesEXT New()
        {
            VkPhysicalDeviceVertexAttributeRobustnessFeaturesEXT ret = new VkPhysicalDeviceVertexAttributeRobustnessFeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceVertexAttributeRobustnessFeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDepthClampZeroOneFeaturesKHR
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 depthClampZeroOne;
        public static VkPhysicalDeviceDepthClampZeroOneFeaturesKHR New()
        {
            VkPhysicalDeviceDepthClampZeroOneFeaturesKHR ret = new VkPhysicalDeviceDepthClampZeroOneFeaturesKHR();
            ret.sType = VkStructureType.PhysicalDeviceDepthClampZeroOneFeaturesKHR;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCooperativeVectorFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 cooperativeVector;
        public VkBool32 cooperativeVectorTraining;
        public static VkPhysicalDeviceCooperativeVectorFeaturesNV New()
        {
            VkPhysicalDeviceCooperativeVectorFeaturesNV ret = new VkPhysicalDeviceCooperativeVectorFeaturesNV();
            ret.sType = VkStructureType.PhysicalDeviceCooperativeVectorFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkCooperativeVectorPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkComponentTypeKHR inputType;
        public VkComponentTypeKHR inputInterpretation;
        public VkComponentTypeKHR matrixInterpretation;
        public VkComponentTypeKHR biasInterpretation;
        public VkComponentTypeKHR resultType;
        public VkBool32 transpose;
        public static VkCooperativeVectorPropertiesNV New()
        {
            VkCooperativeVectorPropertiesNV ret = new VkCooperativeVectorPropertiesNV();
            ret.sType = VkStructureType.CooperativeVectorPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceCooperativeVectorPropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkShaderStageFlags cooperativeVectorSupportedStages;
        public VkBool32 cooperativeVectorTrainingFloat16Accumulation;
        public VkBool32 cooperativeVectorTrainingFloat32Accumulation;
        public uint maxCooperativeVectorComponents;
        public static VkPhysicalDeviceCooperativeVectorPropertiesNV New()
        {
            VkPhysicalDeviceCooperativeVectorPropertiesNV ret = new VkPhysicalDeviceCooperativeVectorPropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceCooperativeVectorPropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkConvertCooperativeVectorMatrixInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public UIntPtr srcSize;
        public VkDeviceOrHostAddressConstKHR srcData;
        public UIntPtr* pDstSize;
        public VkDeviceOrHostAddressKHR dstData;
        public VkComponentTypeKHR srcComponentType;
        public VkComponentTypeKHR dstComponentType;
        public uint numRows;
        public uint numColumns;
        public VkCooperativeVectorMatrixLayoutNV srcLayout;
        public UIntPtr srcStride;
        public VkCooperativeVectorMatrixLayoutNV dstLayout;
        public UIntPtr dstStride;
        public static VkConvertCooperativeVectorMatrixInfoNV New()
        {
            VkConvertCooperativeVectorMatrixInfoNV ret = new VkConvertCooperativeVectorMatrixInfoNV();
            ret.sType = VkStructureType.ConvertCooperativeVectorMatrixInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTileShadingFeaturesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 tileShading;
        public VkBool32 tileShadingFragmentStage;
        public VkBool32 tileShadingColorAttachments;
        public VkBool32 tileShadingDepthAttachments;
        public VkBool32 tileShadingStencilAttachments;
        public VkBool32 tileShadingInputAttachments;
        public VkBool32 tileShadingSampledAttachments;
        public VkBool32 tileShadingPerTileDraw;
        public VkBool32 tileShadingPerTileDispatch;
        public VkBool32 tileShadingDispatchTile;
        public VkBool32 tileShadingApron;
        public VkBool32 tileShadingAnisotropicApron;
        public VkBool32 tileShadingAtomicOps;
        public VkBool32 tileShadingImageProcessing;
        public static VkPhysicalDeviceTileShadingFeaturesQCOM New()
        {
            VkPhysicalDeviceTileShadingFeaturesQCOM ret = new VkPhysicalDeviceTileShadingFeaturesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceTileShadingFeaturesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTileShadingPropertiesQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxApronSize;
        public VkBool32 preferNonCoherent;
        public VkExtent2D tileGranularity;
        public VkExtent2D maxTileShadingRate;
        public static VkPhysicalDeviceTileShadingPropertiesQCOM New()
        {
            VkPhysicalDeviceTileShadingPropertiesQCOM ret = new VkPhysicalDeviceTileShadingPropertiesQCOM();
            ret.sType = VkStructureType.PhysicalDeviceTileShadingPropertiesQcom;
            return ret;
        }
    }

    public unsafe partial struct VkRenderPassTileShadingCreateInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTileShadingRenderPassFlagsQCOM flags;
        public VkExtent2D tileApronSize;
        public static VkRenderPassTileShadingCreateInfoQCOM New()
        {
            VkRenderPassTileShadingCreateInfoQCOM ret = new VkRenderPassTileShadingCreateInfoQCOM();
            ret.sType = VkStructureType.RenderPassTileShadingCreateInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPerTileBeginInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public static VkPerTileBeginInfoQCOM New()
        {
            VkPerTileBeginInfoQCOM ret = new VkPerTileBeginInfoQCOM();
            ret.sType = VkStructureType.PerTileBeginInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPerTileEndInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public static VkPerTileEndInfoQCOM New()
        {
            VkPerTileEndInfoQCOM ret = new VkPerTileEndInfoQCOM();
            ret.sType = VkStructureType.PerTileEndInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkDispatchTileInfoQCOM
    {
        public VkStructureType sType;
        public void* pNext;
        public static VkDispatchTileInfoQCOM New()
        {
            VkDispatchTileInfoQCOM ret = new VkDispatchTileInfoQCOM();
            ret.sType = VkStructureType.DispatchTileInfoQcom;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxFragmentDensityMapLayers;
        public static VkPhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE New()
        {
            VkPhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE ret = new VkPhysicalDeviceFragmentDensityMapLayeredPropertiesVALVE();
            ret.sType = VkStructureType.PhysicalDeviceFragmentDensityMapLayeredPropertiesValve;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 fragmentDensityMapLayered;
        public static VkPhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE New()
        {
            VkPhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE ret = new VkPhysicalDeviceFragmentDensityMapLayeredFeaturesVALVE();
            ret.sType = VkStructureType.PhysicalDeviceFragmentDensityMapLayeredFeaturesValve;
            return ret;
        }
    }

    public unsafe partial struct VkPipelineFragmentDensityMapLayeredCreateInfoVALVE
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxFragmentDensityMapLayers;
        public static VkPipelineFragmentDensityMapLayeredCreateInfoVALVE New()
        {
            VkPipelineFragmentDensityMapLayeredCreateInfoVALVE ret = new VkPipelineFragmentDensityMapLayeredCreateInfoVALVE();
            ret.sType = VkStructureType.PipelineFragmentDensityMapLayeredCreateInfoValve;
            return ret;
        }
    }

    public unsafe partial struct VkSetPresentConfigNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint numFramesPerBatch;
        public uint presentConfigFeedback;
        public static VkSetPresentConfigNV New()
        {
            VkSetPresentConfigNV ret = new VkSetPresentConfigNV();
            ret.sType = VkStructureType.SetPresentConfigNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDevicePresentMeteringFeaturesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 presentMetering;
        public static VkPhysicalDevicePresentMeteringFeaturesNV New()
        {
            VkPhysicalDevicePresentMeteringFeaturesNV ret = new VkPhysicalDevicePresentMeteringFeaturesNV();
            ret.sType = VkStructureType.PhysicalDevicePresentMeteringFeaturesNV;
            return ret;
        }
    }

    public unsafe partial struct VkExternalComputeQueueDeviceCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint reservedExternalQueues;
        public static VkExternalComputeQueueDeviceCreateInfoNV New()
        {
            VkExternalComputeQueueDeviceCreateInfoNV ret = new VkExternalComputeQueueDeviceCreateInfoNV();
            ret.sType = VkStructureType.ExternalComputeQueueDeviceCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkExternalComputeQueueCreateInfoNV
    {
        public VkStructureType sType;
        public void* pNext;
        public VkQueue preferredQueue;
        public static VkExternalComputeQueueCreateInfoNV New()
        {
            VkExternalComputeQueueCreateInfoNV ret = new VkExternalComputeQueueCreateInfoNV();
            ret.sType = VkStructureType.ExternalComputeQueueCreateInfoNV;
            return ret;
        }
    }

    public unsafe partial struct VkExternalComputeQueueDataParamsNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint deviceIndex;
        public static VkExternalComputeQueueDataParamsNV New()
        {
            VkExternalComputeQueueDataParamsNV ret = new VkExternalComputeQueueDataParamsNV();
            ret.sType = VkStructureType.ExternalComputeQueueDataParamsNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalComputeQueuePropertiesNV
    {
        public VkStructureType sType;
        public void* pNext;
        public uint externalDataSize;
        public uint maxExternalQueues;
        public static VkPhysicalDeviceExternalComputeQueuePropertiesNV New()
        {
            VkPhysicalDeviceExternalComputeQueuePropertiesNV ret = new VkPhysicalDeviceExternalComputeQueuePropertiesNV();
            ret.sType = VkStructureType.PhysicalDeviceExternalComputeQueuePropertiesNV;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceFormatPackFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 formatPack;
        public static VkPhysicalDeviceFormatPackFeaturesARM New()
        {
            VkPhysicalDeviceFormatPackFeaturesARM ret = new VkPhysicalDeviceFormatPackFeaturesARM();
            ret.sType = VkStructureType.PhysicalDeviceFormatPackFeaturesArm;
            return ret;
        }
    }

    public unsafe partial struct VkTensorDescriptionARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTensorTilingARM tiling;
        public VkFormat format;
        public uint dimensionCount;
        public long* pDimensions;
        public long* pStrides;
        public uint usage;
        public static VkTensorDescriptionARM New()
        {
            VkTensorDescriptionARM ret = new VkTensorDescriptionARM();
            ret.sType = VkStructureType.TensorDescriptionArm;
            return ret;
        }
    }

    public unsafe partial struct VkTensorCreateInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkTensorDescriptionARM* pDescription;
        public VkSharingMode sharingMode;
        public uint queueFamilyIndexCount;
        public uint* pQueueFamilyIndices;
        public static VkTensorCreateInfoARM New()
        {
            VkTensorCreateInfoARM ret = new VkTensorCreateInfoARM();
            ret.sType = VkStructureType.TensorCreateInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkTensorViewCreateInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkTensorARM tensor;
        public VkFormat format;
        public static VkTensorViewCreateInfoARM New()
        {
            VkTensorViewCreateInfoARM ret = new VkTensorViewCreateInfoARM();
            ret.sType = VkStructureType.TensorViewCreateInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkTensorMemoryRequirementsInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTensorARM tensor;
        public static VkTensorMemoryRequirementsInfoARM New()
        {
            VkTensorMemoryRequirementsInfoARM ret = new VkTensorMemoryRequirementsInfoARM();
            ret.sType = VkStructureType.TensorMemoryRequirementsInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkBindTensorMemoryInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTensorARM tensor;
        public VkDeviceMemory memory;
        public ulong memoryOffset;
        public static VkBindTensorMemoryInfoARM New()
        {
            VkBindTensorMemoryInfoARM ret = new VkBindTensorMemoryInfoARM();
            ret.sType = VkStructureType.BindTensorMemoryInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkWriteDescriptorSetTensorARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint tensorViewCount;
        public VkTensorViewARM* pTensorViews;
        public static VkWriteDescriptorSetTensorARM New()
        {
            VkWriteDescriptorSetTensorARM ret = new VkWriteDescriptorSetTensorARM();
            ret.sType = VkStructureType.WriteDescriptorSetTensorArm;
            return ret;
        }
    }

    public unsafe partial struct VkTensorFormatPropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint optimalTilingTensorFeatures;
        public uint linearTilingTensorFeatures;
        public static VkTensorFormatPropertiesARM New()
        {
            VkTensorFormatPropertiesARM ret = new VkTensorFormatPropertiesARM();
            ret.sType = VkStructureType.TensorFormatPropertiesArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTensorPropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxTensorDimensionCount;
        public ulong maxTensorElements;
        public ulong maxPerDimensionTensorElements;
        public long maxTensorStride;
        public ulong maxTensorSize;
        public uint maxTensorShaderAccessArrayLength;
        public uint maxTensorShaderAccessSize;
        public uint maxDescriptorSetStorageTensors;
        public uint maxPerStageDescriptorSetStorageTensors;
        public uint maxDescriptorSetUpdateAfterBindStorageTensors;
        public uint maxPerStageDescriptorUpdateAfterBindStorageTensors;
        public VkBool32 shaderStorageTensorArrayNonUniformIndexingNative;
        public VkShaderStageFlags shaderTensorSupportedStages;
        public static VkPhysicalDeviceTensorPropertiesARM New()
        {
            VkPhysicalDeviceTensorPropertiesARM ret = new VkPhysicalDeviceTensorPropertiesARM();
            ret.sType = VkStructureType.PhysicalDeviceTensorPropertiesArm;
            return ret;
        }
    }

    public unsafe partial struct VkTensorMemoryBarrierARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint srcStageMask;
        public uint srcAccessMask;
        public uint dstStageMask;
        public uint dstAccessMask;
        public uint srcQueueFamilyIndex;
        public uint dstQueueFamilyIndex;
        public VkTensorARM tensor;
        public static VkTensorMemoryBarrierARM New()
        {
            VkTensorMemoryBarrierARM ret = new VkTensorMemoryBarrierARM();
            ret.sType = VkStructureType.TensorMemoryBarrierArm;
            return ret;
        }
    }

    public unsafe partial struct VkTensorDependencyInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint tensorMemoryBarrierCount;
        public VkTensorMemoryBarrierARM* pTensorMemoryBarriers;
        public static VkTensorDependencyInfoARM New()
        {
            VkTensorDependencyInfoARM ret = new VkTensorDependencyInfoARM();
            ret.sType = VkStructureType.TensorDependencyInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceTensorFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 tensorNonPacked;
        public VkBool32 shaderTensorAccess;
        public VkBool32 shaderStorageTensorArrayDynamicIndexing;
        public VkBool32 shaderStorageTensorArrayNonUniformIndexing;
        public VkBool32 descriptorBindingStorageTensorUpdateAfterBind;
        public VkBool32 tensors;
        public static VkPhysicalDeviceTensorFeaturesARM New()
        {
            VkPhysicalDeviceTensorFeaturesARM ret = new VkPhysicalDeviceTensorFeaturesARM();
            ret.sType = VkStructureType.PhysicalDeviceTensorFeaturesArm;
            return ret;
        }
    }

    public unsafe partial struct VkDeviceTensorMemoryRequirementsARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTensorCreateInfoARM* pCreateInfo;
        public static VkDeviceTensorMemoryRequirementsARM New()
        {
            VkDeviceTensorMemoryRequirementsARM ret = new VkDeviceTensorMemoryRequirementsARM();
            ret.sType = VkStructureType.DeviceTensorMemoryRequirementsArm;
            return ret;
        }
    }

    public unsafe partial struct VkCopyTensorInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTensorARM srcTensor;
        public VkTensorARM dstTensor;
        public uint regionCount;
        public VkTensorCopyARM* pRegions;
        public static VkCopyTensorInfoARM New()
        {
            VkCopyTensorInfoARM ret = new VkCopyTensorInfoARM();
            ret.sType = VkStructureType.CopyTensorInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkTensorCopyARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint dimensionCount;
        public ulong* pSrcOffset;
        public ulong* pDstOffset;
        public ulong* pExtent;
        public static VkTensorCopyARM New()
        {
            VkTensorCopyARM ret = new VkTensorCopyARM();
            ret.sType = VkStructureType.TensorCopyArm;
            return ret;
        }
    }

    public unsafe partial struct VkMemoryDedicatedAllocateInfoTensorARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTensorARM tensor;
        public static VkMemoryDedicatedAllocateInfoTensorARM New()
        {
            VkMemoryDedicatedAllocateInfoTensorARM ret = new VkMemoryDedicatedAllocateInfoTensorARM();
            ret.sType = VkStructureType.MemoryDedicatedAllocateInfoTensorArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorBufferTensorPropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public UIntPtr tensorCaptureReplayDescriptorDataSize;
        public UIntPtr tensorViewCaptureReplayDescriptorDataSize;
        public UIntPtr tensorDescriptorSize;
        public static VkPhysicalDeviceDescriptorBufferTensorPropertiesARM New()
        {
            VkPhysicalDeviceDescriptorBufferTensorPropertiesARM ret = new VkPhysicalDeviceDescriptorBufferTensorPropertiesARM();
            ret.sType = VkStructureType.PhysicalDeviceDescriptorBufferTensorPropertiesArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceDescriptorBufferTensorFeaturesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 descriptorBufferTensorDescriptors;
        public static VkPhysicalDeviceDescriptorBufferTensorFeaturesARM New()
        {
            VkPhysicalDeviceDescriptorBufferTensorFeaturesARM ret = new VkPhysicalDeviceDescriptorBufferTensorFeaturesARM();
            ret.sType = VkStructureType.PhysicalDeviceDescriptorBufferTensorFeaturesArm;
            return ret;
        }
    }

    public unsafe partial struct VkTensorCaptureDescriptorDataInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTensorARM tensor;
        public static VkTensorCaptureDescriptorDataInfoARM New()
        {
            VkTensorCaptureDescriptorDataInfoARM ret = new VkTensorCaptureDescriptorDataInfoARM();
            ret.sType = VkStructureType.TensorCaptureDescriptorDataInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkTensorViewCaptureDescriptorDataInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTensorViewARM tensorView;
        public static VkTensorViewCaptureDescriptorDataInfoARM New()
        {
            VkTensorViewCaptureDescriptorDataInfoARM ret = new VkTensorViewCaptureDescriptorDataInfoARM();
            ret.sType = VkStructureType.TensorViewCaptureDescriptorDataInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkDescriptorGetTensorInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkTensorViewARM tensorView;
        public static VkDescriptorGetTensorInfoARM New()
        {
            VkDescriptorGetTensorInfoARM ret = new VkDescriptorGetTensorInfoARM();
            ret.sType = VkStructureType.DescriptorGetTensorInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkFrameBoundaryTensorsARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint tensorCount;
        public VkTensorARM* pTensors;
        public static VkFrameBoundaryTensorsARM New()
        {
            VkFrameBoundaryTensorsARM ret = new VkFrameBoundaryTensorsARM();
            ret.sType = VkStructureType.FrameBoundaryTensorsArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceExternalTensorInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public VkTensorDescriptionARM* pDescription;
        public VkExternalMemoryHandleTypeFlags handleType;
        public static VkPhysicalDeviceExternalTensorInfoARM New()
        {
            VkPhysicalDeviceExternalTensorInfoARM ret = new VkPhysicalDeviceExternalTensorInfoARM();
            ret.sType = VkStructureType.PhysicalDeviceExternalTensorInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkExternalTensorPropertiesARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryProperties externalMemoryProperties;
        public static VkExternalTensorPropertiesARM New()
        {
            VkExternalTensorPropertiesARM ret = new VkExternalTensorPropertiesARM();
            ret.sType = VkStructureType.ExternalTensorPropertiesArm;
            return ret;
        }
    }

    public unsafe partial struct VkExternalMemoryTensorCreateInfoARM
    {
        public VkStructureType sType;
        public void* pNext;
        public VkExternalMemoryHandleTypeFlags handleTypes;
        public static VkExternalMemoryTensorCreateInfoARM New()
        {
            VkExternalMemoryTensorCreateInfoARM ret = new VkExternalMemoryTensorCreateInfoARM();
            ret.sType = VkStructureType.ExternalMemoryTensorCreateInfoArm;
            return ret;
        }
    }

    public unsafe partial struct VkPhysicalDeviceShaderFloat8FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 shaderFloat8;
        public VkBool32 shaderFloat8CooperativeMatrix;
        public static VkPhysicalDeviceShaderFloat8FeaturesEXT New()
        {
            VkPhysicalDeviceShaderFloat8FeaturesEXT ret = new VkPhysicalDeviceShaderFloat8FeaturesEXT();
            ret.sType = VkStructureType.PhysicalDeviceShaderFloat8FeaturesEXT;
            return ret;
        }
    }

    public unsafe partial struct VkOHSurfaceCreateInfoOHOS
    {
        public VkStructureType sType;
        public void* pNext;
        public uint flags;
        public OHOS.OHNativeWindow* window;
        public static VkOHSurfaceCreateInfoOHOS New()
        {
            VkOHSurfaceCreateInfoOHOS ret = new VkOHSurfaceCreateInfoOHOS();
            ret.sType = VkStructureType.OhSurfaceCreateInfoOhos;
            return ret;
        }
    }

    public unsafe partial struct VkSurfaceCreateInfoOHOS
    {
    }
}
