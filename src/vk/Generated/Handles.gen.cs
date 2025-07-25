// This file is generated.

using System;
using System.Diagnostics;

namespace Vulkan
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkInstance : IEquatable<VkInstance>
    {
        public readonly IntPtr Handle;
        public VkInstance(IntPtr existingHandle) { Handle = existingHandle; }
        public static VkInstance Null => new VkInstance(IntPtr.Zero);
        public static implicit operator VkInstance(IntPtr handle) => new VkInstance(handle);
        public static bool operator ==(VkInstance left, VkInstance right) => left.Handle == right.Handle;
        public static bool operator !=(VkInstance left, VkInstance right) => left.Handle != right.Handle;
        public static bool operator ==(VkInstance left, IntPtr right) => left.Handle == right;
        public static bool operator !=(VkInstance left, IntPtr right) => left.Handle != right;
        public bool Equals(VkInstance h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkInstance h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkInstance [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A dispatchable handle owned by a VkInstance.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkPhysicalDevice : IEquatable<VkPhysicalDevice>
    {
        public readonly IntPtr Handle;
        public VkPhysicalDevice(IntPtr existingHandle) { Handle = existingHandle; }
        public static VkPhysicalDevice Null => new VkPhysicalDevice(IntPtr.Zero);
        public static implicit operator VkPhysicalDevice(IntPtr handle) => new VkPhysicalDevice(handle);
        public static bool operator ==(VkPhysicalDevice left, VkPhysicalDevice right) => left.Handle == right.Handle;
        public static bool operator !=(VkPhysicalDevice left, VkPhysicalDevice right) => left.Handle != right.Handle;
        public static bool operator ==(VkPhysicalDevice left, IntPtr right) => left.Handle == right;
        public static bool operator !=(VkPhysicalDevice left, IntPtr right) => left.Handle != right;
        public bool Equals(VkPhysicalDevice h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkPhysicalDevice h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkPhysicalDevice [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A dispatchable handle owned by a VkPhysicalDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkDevice : IEquatable<VkDevice>
    {
        public readonly IntPtr Handle;
        public VkDevice(IntPtr existingHandle) { Handle = existingHandle; }
        public static VkDevice Null => new VkDevice(IntPtr.Zero);
        public static implicit operator VkDevice(IntPtr handle) => new VkDevice(handle);
        public static bool operator ==(VkDevice left, VkDevice right) => left.Handle == right.Handle;
        public static bool operator !=(VkDevice left, VkDevice right) => left.Handle != right.Handle;
        public static bool operator ==(VkDevice left, IntPtr right) => left.Handle == right;
        public static bool operator !=(VkDevice left, IntPtr right) => left.Handle != right;
        public bool Equals(VkDevice h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkDevice h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkDevice [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkQueue : IEquatable<VkQueue>
    {
        public readonly IntPtr Handle;
        public VkQueue(IntPtr existingHandle) { Handle = existingHandle; }
        public static VkQueue Null => new VkQueue(IntPtr.Zero);
        public static implicit operator VkQueue(IntPtr handle) => new VkQueue(handle);
        public static bool operator ==(VkQueue left, VkQueue right) => left.Handle == right.Handle;
        public static bool operator !=(VkQueue left, VkQueue right) => left.Handle != right.Handle;
        public static bool operator ==(VkQueue left, IntPtr right) => left.Handle == right;
        public static bool operator !=(VkQueue left, IntPtr right) => left.Handle != right;
        public bool Equals(VkQueue h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkQueue h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkQueue [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A dispatchable handle owned by a VkCommandPool.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkCommandBuffer : IEquatable<VkCommandBuffer>
    {
        public readonly IntPtr Handle;
        public VkCommandBuffer(IntPtr existingHandle) { Handle = existingHandle; }
        public static VkCommandBuffer Null => new VkCommandBuffer(IntPtr.Zero);
        public static implicit operator VkCommandBuffer(IntPtr handle) => new VkCommandBuffer(handle);
        public static bool operator ==(VkCommandBuffer left, VkCommandBuffer right) => left.Handle == right.Handle;
        public static bool operator !=(VkCommandBuffer left, VkCommandBuffer right) => left.Handle != right.Handle;
        public static bool operator ==(VkCommandBuffer left, IntPtr right) => left.Handle == right;
        public static bool operator !=(VkCommandBuffer left, IntPtr right) => left.Handle != right;
        public bool Equals(VkCommandBuffer h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkCommandBuffer h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkCommandBuffer [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkDeviceMemory : IEquatable<VkDeviceMemory>
    {
        public readonly ulong Handle;
        public VkDeviceMemory(ulong existingHandle) { Handle = existingHandle; }
        public static VkDeviceMemory Null => new VkDeviceMemory(0);
        public static implicit operator VkDeviceMemory(ulong handle) => new VkDeviceMemory(handle);
        public static bool operator ==(VkDeviceMemory left, VkDeviceMemory right) => left.Handle == right.Handle;
        public static bool operator !=(VkDeviceMemory left, VkDeviceMemory right) => left.Handle != right.Handle;
        public static bool operator ==(VkDeviceMemory left, ulong right) => left.Handle == right;
        public static bool operator !=(VkDeviceMemory left, ulong right) => left.Handle != right;
        public bool Equals(VkDeviceMemory h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkDeviceMemory h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkDeviceMemory [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkCommandPool : IEquatable<VkCommandPool>
    {
        public readonly ulong Handle;
        public VkCommandPool(ulong existingHandle) { Handle = existingHandle; }
        public static VkCommandPool Null => new VkCommandPool(0);
        public static implicit operator VkCommandPool(ulong handle) => new VkCommandPool(handle);
        public static bool operator ==(VkCommandPool left, VkCommandPool right) => left.Handle == right.Handle;
        public static bool operator !=(VkCommandPool left, VkCommandPool right) => left.Handle != right.Handle;
        public static bool operator ==(VkCommandPool left, ulong right) => left.Handle == right;
        public static bool operator !=(VkCommandPool left, ulong right) => left.Handle != right;
        public bool Equals(VkCommandPool h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkCommandPool h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkCommandPool [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkBuffer : IEquatable<VkBuffer>
    {
        public readonly ulong Handle;
        public VkBuffer(ulong existingHandle) { Handle = existingHandle; }
        public static VkBuffer Null => new VkBuffer(0);
        public static implicit operator VkBuffer(ulong handle) => new VkBuffer(handle);
        public static bool operator ==(VkBuffer left, VkBuffer right) => left.Handle == right.Handle;
        public static bool operator !=(VkBuffer left, VkBuffer right) => left.Handle != right.Handle;
        public static bool operator ==(VkBuffer left, ulong right) => left.Handle == right;
        public static bool operator !=(VkBuffer left, ulong right) => left.Handle != right;
        public bool Equals(VkBuffer h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkBuffer h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkBuffer [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkBufferView : IEquatable<VkBufferView>
    {
        public readonly ulong Handle;
        public VkBufferView(ulong existingHandle) { Handle = existingHandle; }
        public static VkBufferView Null => new VkBufferView(0);
        public static implicit operator VkBufferView(ulong handle) => new VkBufferView(handle);
        public static bool operator ==(VkBufferView left, VkBufferView right) => left.Handle == right.Handle;
        public static bool operator !=(VkBufferView left, VkBufferView right) => left.Handle != right.Handle;
        public static bool operator ==(VkBufferView left, ulong right) => left.Handle == right;
        public static bool operator !=(VkBufferView left, ulong right) => left.Handle != right;
        public bool Equals(VkBufferView h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkBufferView h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkBufferView [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkImage : IEquatable<VkImage>
    {
        public readonly ulong Handle;
        public VkImage(ulong existingHandle) { Handle = existingHandle; }
        public static VkImage Null => new VkImage(0);
        public static implicit operator VkImage(ulong handle) => new VkImage(handle);
        public static bool operator ==(VkImage left, VkImage right) => left.Handle == right.Handle;
        public static bool operator !=(VkImage left, VkImage right) => left.Handle != right.Handle;
        public static bool operator ==(VkImage left, ulong right) => left.Handle == right;
        public static bool operator !=(VkImage left, ulong right) => left.Handle != right;
        public bool Equals(VkImage h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkImage h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkImage [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkImageView : IEquatable<VkImageView>
    {
        public readonly ulong Handle;
        public VkImageView(ulong existingHandle) { Handle = existingHandle; }
        public static VkImageView Null => new VkImageView(0);
        public static implicit operator VkImageView(ulong handle) => new VkImageView(handle);
        public static bool operator ==(VkImageView left, VkImageView right) => left.Handle == right.Handle;
        public static bool operator !=(VkImageView left, VkImageView right) => left.Handle != right.Handle;
        public static bool operator ==(VkImageView left, ulong right) => left.Handle == right;
        public static bool operator !=(VkImageView left, ulong right) => left.Handle != right;
        public bool Equals(VkImageView h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkImageView h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkImageView [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkShaderModule : IEquatable<VkShaderModule>
    {
        public readonly ulong Handle;
        public VkShaderModule(ulong existingHandle) { Handle = existingHandle; }
        public static VkShaderModule Null => new VkShaderModule(0);
        public static implicit operator VkShaderModule(ulong handle) => new VkShaderModule(handle);
        public static bool operator ==(VkShaderModule left, VkShaderModule right) => left.Handle == right.Handle;
        public static bool operator !=(VkShaderModule left, VkShaderModule right) => left.Handle != right.Handle;
        public static bool operator ==(VkShaderModule left, ulong right) => left.Handle == right;
        public static bool operator !=(VkShaderModule left, ulong right) => left.Handle != right;
        public bool Equals(VkShaderModule h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkShaderModule h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkShaderModule [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkPipeline : IEquatable<VkPipeline>
    {
        public readonly ulong Handle;
        public VkPipeline(ulong existingHandle) { Handle = existingHandle; }
        public static VkPipeline Null => new VkPipeline(0);
        public static implicit operator VkPipeline(ulong handle) => new VkPipeline(handle);
        public static bool operator ==(VkPipeline left, VkPipeline right) => left.Handle == right.Handle;
        public static bool operator !=(VkPipeline left, VkPipeline right) => left.Handle != right.Handle;
        public static bool operator ==(VkPipeline left, ulong right) => left.Handle == right;
        public static bool operator !=(VkPipeline left, ulong right) => left.Handle != right;
        public bool Equals(VkPipeline h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkPipeline h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkPipeline [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkPipelineLayout : IEquatable<VkPipelineLayout>
    {
        public readonly ulong Handle;
        public VkPipelineLayout(ulong existingHandle) { Handle = existingHandle; }
        public static VkPipelineLayout Null => new VkPipelineLayout(0);
        public static implicit operator VkPipelineLayout(ulong handle) => new VkPipelineLayout(handle);
        public static bool operator ==(VkPipelineLayout left, VkPipelineLayout right) => left.Handle == right.Handle;
        public static bool operator !=(VkPipelineLayout left, VkPipelineLayout right) => left.Handle != right.Handle;
        public static bool operator ==(VkPipelineLayout left, ulong right) => left.Handle == right;
        public static bool operator !=(VkPipelineLayout left, ulong right) => left.Handle != right;
        public bool Equals(VkPipelineLayout h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkPipelineLayout h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkPipelineLayout [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkSampler : IEquatable<VkSampler>
    {
        public readonly ulong Handle;
        public VkSampler(ulong existingHandle) { Handle = existingHandle; }
        public static VkSampler Null => new VkSampler(0);
        public static implicit operator VkSampler(ulong handle) => new VkSampler(handle);
        public static bool operator ==(VkSampler left, VkSampler right) => left.Handle == right.Handle;
        public static bool operator !=(VkSampler left, VkSampler right) => left.Handle != right.Handle;
        public static bool operator ==(VkSampler left, ulong right) => left.Handle == right;
        public static bool operator !=(VkSampler left, ulong right) => left.Handle != right;
        public bool Equals(VkSampler h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkSampler h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkSampler [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDescriptorPool.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkDescriptorSet : IEquatable<VkDescriptorSet>
    {
        public readonly ulong Handle;
        public VkDescriptorSet(ulong existingHandle) { Handle = existingHandle; }
        public static VkDescriptorSet Null => new VkDescriptorSet(0);
        public static implicit operator VkDescriptorSet(ulong handle) => new VkDescriptorSet(handle);
        public static bool operator ==(VkDescriptorSet left, VkDescriptorSet right) => left.Handle == right.Handle;
        public static bool operator !=(VkDescriptorSet left, VkDescriptorSet right) => left.Handle != right.Handle;
        public static bool operator ==(VkDescriptorSet left, ulong right) => left.Handle == right;
        public static bool operator !=(VkDescriptorSet left, ulong right) => left.Handle != right;
        public bool Equals(VkDescriptorSet h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkDescriptorSet h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkDescriptorSet [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkDescriptorSetLayout : IEquatable<VkDescriptorSetLayout>
    {
        public readonly ulong Handle;
        public VkDescriptorSetLayout(ulong existingHandle) { Handle = existingHandle; }
        public static VkDescriptorSetLayout Null => new VkDescriptorSetLayout(0);
        public static implicit operator VkDescriptorSetLayout(ulong handle) => new VkDescriptorSetLayout(handle);
        public static bool operator ==(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Handle == right.Handle;
        public static bool operator !=(VkDescriptorSetLayout left, VkDescriptorSetLayout right) => left.Handle != right.Handle;
        public static bool operator ==(VkDescriptorSetLayout left, ulong right) => left.Handle == right;
        public static bool operator !=(VkDescriptorSetLayout left, ulong right) => left.Handle != right;
        public bool Equals(VkDescriptorSetLayout h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkDescriptorSetLayout h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkDescriptorSetLayout [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkDescriptorPool : IEquatable<VkDescriptorPool>
    {
        public readonly ulong Handle;
        public VkDescriptorPool(ulong existingHandle) { Handle = existingHandle; }
        public static VkDescriptorPool Null => new VkDescriptorPool(0);
        public static implicit operator VkDescriptorPool(ulong handle) => new VkDescriptorPool(handle);
        public static bool operator ==(VkDescriptorPool left, VkDescriptorPool right) => left.Handle == right.Handle;
        public static bool operator !=(VkDescriptorPool left, VkDescriptorPool right) => left.Handle != right.Handle;
        public static bool operator ==(VkDescriptorPool left, ulong right) => left.Handle == right;
        public static bool operator !=(VkDescriptorPool left, ulong right) => left.Handle != right;
        public bool Equals(VkDescriptorPool h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkDescriptorPool h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkDescriptorPool [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkFence : IEquatable<VkFence>
    {
        public readonly ulong Handle;
        public VkFence(ulong existingHandle) { Handle = existingHandle; }
        public static VkFence Null => new VkFence(0);
        public static implicit operator VkFence(ulong handle) => new VkFence(handle);
        public static bool operator ==(VkFence left, VkFence right) => left.Handle == right.Handle;
        public static bool operator !=(VkFence left, VkFence right) => left.Handle != right.Handle;
        public static bool operator ==(VkFence left, ulong right) => left.Handle == right;
        public static bool operator !=(VkFence left, ulong right) => left.Handle != right;
        public bool Equals(VkFence h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkFence h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkFence [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkSemaphore : IEquatable<VkSemaphore>
    {
        public readonly ulong Handle;
        public VkSemaphore(ulong existingHandle) { Handle = existingHandle; }
        public static VkSemaphore Null => new VkSemaphore(0);
        public static implicit operator VkSemaphore(ulong handle) => new VkSemaphore(handle);
        public static bool operator ==(VkSemaphore left, VkSemaphore right) => left.Handle == right.Handle;
        public static bool operator !=(VkSemaphore left, VkSemaphore right) => left.Handle != right.Handle;
        public static bool operator ==(VkSemaphore left, ulong right) => left.Handle == right;
        public static bool operator !=(VkSemaphore left, ulong right) => left.Handle != right;
        public bool Equals(VkSemaphore h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkSemaphore h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkSemaphore [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkEvent : IEquatable<VkEvent>
    {
        public readonly ulong Handle;
        public VkEvent(ulong existingHandle) { Handle = existingHandle; }
        public static VkEvent Null => new VkEvent(0);
        public static implicit operator VkEvent(ulong handle) => new VkEvent(handle);
        public static bool operator ==(VkEvent left, VkEvent right) => left.Handle == right.Handle;
        public static bool operator !=(VkEvent left, VkEvent right) => left.Handle != right.Handle;
        public static bool operator ==(VkEvent left, ulong right) => left.Handle == right;
        public static bool operator !=(VkEvent left, ulong right) => left.Handle != right;
        public bool Equals(VkEvent h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkEvent h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkEvent [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkQueryPool : IEquatable<VkQueryPool>
    {
        public readonly ulong Handle;
        public VkQueryPool(ulong existingHandle) { Handle = existingHandle; }
        public static VkQueryPool Null => new VkQueryPool(0);
        public static implicit operator VkQueryPool(ulong handle) => new VkQueryPool(handle);
        public static bool operator ==(VkQueryPool left, VkQueryPool right) => left.Handle == right.Handle;
        public static bool operator !=(VkQueryPool left, VkQueryPool right) => left.Handle != right.Handle;
        public static bool operator ==(VkQueryPool left, ulong right) => left.Handle == right;
        public static bool operator !=(VkQueryPool left, ulong right) => left.Handle != right;
        public bool Equals(VkQueryPool h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkQueryPool h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkQueryPool [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkFramebuffer : IEquatable<VkFramebuffer>
    {
        public readonly ulong Handle;
        public VkFramebuffer(ulong existingHandle) { Handle = existingHandle; }
        public static VkFramebuffer Null => new VkFramebuffer(0);
        public static implicit operator VkFramebuffer(ulong handle) => new VkFramebuffer(handle);
        public static bool operator ==(VkFramebuffer left, VkFramebuffer right) => left.Handle == right.Handle;
        public static bool operator !=(VkFramebuffer left, VkFramebuffer right) => left.Handle != right.Handle;
        public static bool operator ==(VkFramebuffer left, ulong right) => left.Handle == right;
        public static bool operator !=(VkFramebuffer left, ulong right) => left.Handle != right;
        public bool Equals(VkFramebuffer h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkFramebuffer h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkFramebuffer [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkRenderPass : IEquatable<VkRenderPass>
    {
        public readonly ulong Handle;
        public VkRenderPass(ulong existingHandle) { Handle = existingHandle; }
        public static VkRenderPass Null => new VkRenderPass(0);
        public static implicit operator VkRenderPass(ulong handle) => new VkRenderPass(handle);
        public static bool operator ==(VkRenderPass left, VkRenderPass right) => left.Handle == right.Handle;
        public static bool operator !=(VkRenderPass left, VkRenderPass right) => left.Handle != right.Handle;
        public static bool operator ==(VkRenderPass left, ulong right) => left.Handle == right;
        public static bool operator !=(VkRenderPass left, ulong right) => left.Handle != right;
        public bool Equals(VkRenderPass h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkRenderPass h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkRenderPass [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkPipelineCache : IEquatable<VkPipelineCache>
    {
        public readonly ulong Handle;
        public VkPipelineCache(ulong existingHandle) { Handle = existingHandle; }
        public static VkPipelineCache Null => new VkPipelineCache(0);
        public static implicit operator VkPipelineCache(ulong handle) => new VkPipelineCache(handle);
        public static bool operator ==(VkPipelineCache left, VkPipelineCache right) => left.Handle == right.Handle;
        public static bool operator !=(VkPipelineCache left, VkPipelineCache right) => left.Handle != right.Handle;
        public static bool operator ==(VkPipelineCache left, ulong right) => left.Handle == right;
        public static bool operator !=(VkPipelineCache left, ulong right) => left.Handle != right;
        public bool Equals(VkPipelineCache h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkPipelineCache h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkPipelineCache [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkPipelineBinaryKHR : IEquatable<VkPipelineBinaryKHR>
    {
        public readonly ulong Handle;
        public VkPipelineBinaryKHR(ulong existingHandle) { Handle = existingHandle; }
        public static VkPipelineBinaryKHR Null => new VkPipelineBinaryKHR(0);
        public static implicit operator VkPipelineBinaryKHR(ulong handle) => new VkPipelineBinaryKHR(handle);
        public static bool operator ==(VkPipelineBinaryKHR left, VkPipelineBinaryKHR right) => left.Handle == right.Handle;
        public static bool operator !=(VkPipelineBinaryKHR left, VkPipelineBinaryKHR right) => left.Handle != right.Handle;
        public static bool operator ==(VkPipelineBinaryKHR left, ulong right) => left.Handle == right;
        public static bool operator !=(VkPipelineBinaryKHR left, ulong right) => left.Handle != right;
        public bool Equals(VkPipelineBinaryKHR h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkPipelineBinaryKHR h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkPipelineBinaryKHR [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkIndirectCommandsLayoutNV : IEquatable<VkIndirectCommandsLayoutNV>
    {
        public readonly ulong Handle;
        public VkIndirectCommandsLayoutNV(ulong existingHandle) { Handle = existingHandle; }
        public static VkIndirectCommandsLayoutNV Null => new VkIndirectCommandsLayoutNV(0);
        public static implicit operator VkIndirectCommandsLayoutNV(ulong handle) => new VkIndirectCommandsLayoutNV(handle);
        public static bool operator ==(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Handle == right.Handle;
        public static bool operator !=(VkIndirectCommandsLayoutNV left, VkIndirectCommandsLayoutNV right) => left.Handle != right.Handle;
        public static bool operator ==(VkIndirectCommandsLayoutNV left, ulong right) => left.Handle == right;
        public static bool operator !=(VkIndirectCommandsLayoutNV left, ulong right) => left.Handle != right;
        public bool Equals(VkIndirectCommandsLayoutNV h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkIndirectCommandsLayoutNV h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkIndirectCommandsLayoutNV [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkIndirectCommandsLayoutEXT : IEquatable<VkIndirectCommandsLayoutEXT>
    {
        public readonly ulong Handle;
        public VkIndirectCommandsLayoutEXT(ulong existingHandle) { Handle = existingHandle; }
        public static VkIndirectCommandsLayoutEXT Null => new VkIndirectCommandsLayoutEXT(0);
        public static implicit operator VkIndirectCommandsLayoutEXT(ulong handle) => new VkIndirectCommandsLayoutEXT(handle);
        public static bool operator ==(VkIndirectCommandsLayoutEXT left, VkIndirectCommandsLayoutEXT right) => left.Handle == right.Handle;
        public static bool operator !=(VkIndirectCommandsLayoutEXT left, VkIndirectCommandsLayoutEXT right) => left.Handle != right.Handle;
        public static bool operator ==(VkIndirectCommandsLayoutEXT left, ulong right) => left.Handle == right;
        public static bool operator !=(VkIndirectCommandsLayoutEXT left, ulong right) => left.Handle != right;
        public bool Equals(VkIndirectCommandsLayoutEXT h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkIndirectCommandsLayoutEXT h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkIndirectCommandsLayoutEXT [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkIndirectExecutionSetEXT : IEquatable<VkIndirectExecutionSetEXT>
    {
        public readonly ulong Handle;
        public VkIndirectExecutionSetEXT(ulong existingHandle) { Handle = existingHandle; }
        public static VkIndirectExecutionSetEXT Null => new VkIndirectExecutionSetEXT(0);
        public static implicit operator VkIndirectExecutionSetEXT(ulong handle) => new VkIndirectExecutionSetEXT(handle);
        public static bool operator ==(VkIndirectExecutionSetEXT left, VkIndirectExecutionSetEXT right) => left.Handle == right.Handle;
        public static bool operator !=(VkIndirectExecutionSetEXT left, VkIndirectExecutionSetEXT right) => left.Handle != right.Handle;
        public static bool operator ==(VkIndirectExecutionSetEXT left, ulong right) => left.Handle == right;
        public static bool operator !=(VkIndirectExecutionSetEXT left, ulong right) => left.Handle != right;
        public bool Equals(VkIndirectExecutionSetEXT h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkIndirectExecutionSetEXT h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkIndirectExecutionSetEXT [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkDescriptorUpdateTemplate : IEquatable<VkDescriptorUpdateTemplate>
    {
        public readonly ulong Handle;
        public VkDescriptorUpdateTemplate(ulong existingHandle) { Handle = existingHandle; }
        public static VkDescriptorUpdateTemplate Null => new VkDescriptorUpdateTemplate(0);
        public static implicit operator VkDescriptorUpdateTemplate(ulong handle) => new VkDescriptorUpdateTemplate(handle);
        public static bool operator ==(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Handle == right.Handle;
        public static bool operator !=(VkDescriptorUpdateTemplate left, VkDescriptorUpdateTemplate right) => left.Handle != right.Handle;
        public static bool operator ==(VkDescriptorUpdateTemplate left, ulong right) => left.Handle == right;
        public static bool operator !=(VkDescriptorUpdateTemplate left, ulong right) => left.Handle != right;
        public bool Equals(VkDescriptorUpdateTemplate h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkDescriptorUpdateTemplate h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkDescriptorUpdateTemplate [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkSamplerYcbcrConversion : IEquatable<VkSamplerYcbcrConversion>
    {
        public readonly ulong Handle;
        public VkSamplerYcbcrConversion(ulong existingHandle) { Handle = existingHandle; }
        public static VkSamplerYcbcrConversion Null => new VkSamplerYcbcrConversion(0);
        public static implicit operator VkSamplerYcbcrConversion(ulong handle) => new VkSamplerYcbcrConversion(handle);
        public static bool operator ==(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Handle == right.Handle;
        public static bool operator !=(VkSamplerYcbcrConversion left, VkSamplerYcbcrConversion right) => left.Handle != right.Handle;
        public static bool operator ==(VkSamplerYcbcrConversion left, ulong right) => left.Handle == right;
        public static bool operator !=(VkSamplerYcbcrConversion left, ulong right) => left.Handle != right;
        public bool Equals(VkSamplerYcbcrConversion h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkSamplerYcbcrConversion h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkSamplerYcbcrConversion [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkValidationCacheEXT : IEquatable<VkValidationCacheEXT>
    {
        public readonly ulong Handle;
        public VkValidationCacheEXT(ulong existingHandle) { Handle = existingHandle; }
        public static VkValidationCacheEXT Null => new VkValidationCacheEXT(0);
        public static implicit operator VkValidationCacheEXT(ulong handle) => new VkValidationCacheEXT(handle);
        public static bool operator ==(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Handle == right.Handle;
        public static bool operator !=(VkValidationCacheEXT left, VkValidationCacheEXT right) => left.Handle != right.Handle;
        public static bool operator ==(VkValidationCacheEXT left, ulong right) => left.Handle == right;
        public static bool operator !=(VkValidationCacheEXT left, ulong right) => left.Handle != right;
        public bool Equals(VkValidationCacheEXT h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkValidationCacheEXT h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkValidationCacheEXT [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkAccelerationStructureKHR : IEquatable<VkAccelerationStructureKHR>
    {
        public readonly ulong Handle;
        public VkAccelerationStructureKHR(ulong existingHandle) { Handle = existingHandle; }
        public static VkAccelerationStructureKHR Null => new VkAccelerationStructureKHR(0);
        public static implicit operator VkAccelerationStructureKHR(ulong handle) => new VkAccelerationStructureKHR(handle);
        public static bool operator ==(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Handle == right.Handle;
        public static bool operator !=(VkAccelerationStructureKHR left, VkAccelerationStructureKHR right) => left.Handle != right.Handle;
        public static bool operator ==(VkAccelerationStructureKHR left, ulong right) => left.Handle == right;
        public static bool operator !=(VkAccelerationStructureKHR left, ulong right) => left.Handle != right;
        public bool Equals(VkAccelerationStructureKHR h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkAccelerationStructureKHR h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkAccelerationStructureKHR [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkAccelerationStructureNV : IEquatable<VkAccelerationStructureNV>
    {
        public readonly ulong Handle;
        public VkAccelerationStructureNV(ulong existingHandle) { Handle = existingHandle; }
        public static VkAccelerationStructureNV Null => new VkAccelerationStructureNV(0);
        public static implicit operator VkAccelerationStructureNV(ulong handle) => new VkAccelerationStructureNV(handle);
        public static bool operator ==(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Handle == right.Handle;
        public static bool operator !=(VkAccelerationStructureNV left, VkAccelerationStructureNV right) => left.Handle != right.Handle;
        public static bool operator ==(VkAccelerationStructureNV left, ulong right) => left.Handle == right;
        public static bool operator !=(VkAccelerationStructureNV left, ulong right) => left.Handle != right;
        public bool Equals(VkAccelerationStructureNV h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkAccelerationStructureNV h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkAccelerationStructureNV [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkPerformanceConfigurationINTEL : IEquatable<VkPerformanceConfigurationINTEL>
    {
        public readonly ulong Handle;
        public VkPerformanceConfigurationINTEL(ulong existingHandle) { Handle = existingHandle; }
        public static VkPerformanceConfigurationINTEL Null => new VkPerformanceConfigurationINTEL(0);
        public static implicit operator VkPerformanceConfigurationINTEL(ulong handle) => new VkPerformanceConfigurationINTEL(handle);
        public static bool operator ==(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Handle == right.Handle;
        public static bool operator !=(VkPerformanceConfigurationINTEL left, VkPerformanceConfigurationINTEL right) => left.Handle != right.Handle;
        public static bool operator ==(VkPerformanceConfigurationINTEL left, ulong right) => left.Handle == right;
        public static bool operator !=(VkPerformanceConfigurationINTEL left, ulong right) => left.Handle != right;
        public bool Equals(VkPerformanceConfigurationINTEL h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkPerformanceConfigurationINTEL h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkPerformanceConfigurationINTEL [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkBufferCollectionFUCHSIA : IEquatable<VkBufferCollectionFUCHSIA>
    {
        public readonly ulong Handle;
        public VkBufferCollectionFUCHSIA(ulong existingHandle) { Handle = existingHandle; }
        public static VkBufferCollectionFUCHSIA Null => new VkBufferCollectionFUCHSIA(0);
        public static implicit operator VkBufferCollectionFUCHSIA(ulong handle) => new VkBufferCollectionFUCHSIA(handle);
        public static bool operator ==(VkBufferCollectionFUCHSIA left, VkBufferCollectionFUCHSIA right) => left.Handle == right.Handle;
        public static bool operator !=(VkBufferCollectionFUCHSIA left, VkBufferCollectionFUCHSIA right) => left.Handle != right.Handle;
        public static bool operator ==(VkBufferCollectionFUCHSIA left, ulong right) => left.Handle == right;
        public static bool operator !=(VkBufferCollectionFUCHSIA left, ulong right) => left.Handle != right;
        public bool Equals(VkBufferCollectionFUCHSIA h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkBufferCollectionFUCHSIA h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkBufferCollectionFUCHSIA [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkDeferredOperationKHR : IEquatable<VkDeferredOperationKHR>
    {
        public readonly ulong Handle;
        public VkDeferredOperationKHR(ulong existingHandle) { Handle = existingHandle; }
        public static VkDeferredOperationKHR Null => new VkDeferredOperationKHR(0);
        public static implicit operator VkDeferredOperationKHR(ulong handle) => new VkDeferredOperationKHR(handle);
        public static bool operator ==(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Handle == right.Handle;
        public static bool operator !=(VkDeferredOperationKHR left, VkDeferredOperationKHR right) => left.Handle != right.Handle;
        public static bool operator ==(VkDeferredOperationKHR left, ulong right) => left.Handle == right;
        public static bool operator !=(VkDeferredOperationKHR left, ulong right) => left.Handle != right;
        public bool Equals(VkDeferredOperationKHR h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkDeferredOperationKHR h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkDeferredOperationKHR [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkPrivateDataSlot : IEquatable<VkPrivateDataSlot>
    {
        public readonly ulong Handle;
        public VkPrivateDataSlot(ulong existingHandle) { Handle = existingHandle; }
        public static VkPrivateDataSlot Null => new VkPrivateDataSlot(0);
        public static implicit operator VkPrivateDataSlot(ulong handle) => new VkPrivateDataSlot(handle);
        public static bool operator ==(VkPrivateDataSlot left, VkPrivateDataSlot right) => left.Handle == right.Handle;
        public static bool operator !=(VkPrivateDataSlot left, VkPrivateDataSlot right) => left.Handle != right.Handle;
        public static bool operator ==(VkPrivateDataSlot left, ulong right) => left.Handle == right;
        public static bool operator !=(VkPrivateDataSlot left, ulong right) => left.Handle != right;
        public bool Equals(VkPrivateDataSlot h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkPrivateDataSlot h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkPrivateDataSlot [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkCuModuleNVX : IEquatable<VkCuModuleNVX>
    {
        public readonly ulong Handle;
        public VkCuModuleNVX(ulong existingHandle) { Handle = existingHandle; }
        public static VkCuModuleNVX Null => new VkCuModuleNVX(0);
        public static implicit operator VkCuModuleNVX(ulong handle) => new VkCuModuleNVX(handle);
        public static bool operator ==(VkCuModuleNVX left, VkCuModuleNVX right) => left.Handle == right.Handle;
        public static bool operator !=(VkCuModuleNVX left, VkCuModuleNVX right) => left.Handle != right.Handle;
        public static bool operator ==(VkCuModuleNVX left, ulong right) => left.Handle == right;
        public static bool operator !=(VkCuModuleNVX left, ulong right) => left.Handle != right;
        public bool Equals(VkCuModuleNVX h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkCuModuleNVX h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkCuModuleNVX [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkCuFunctionNVX : IEquatable<VkCuFunctionNVX>
    {
        public readonly ulong Handle;
        public VkCuFunctionNVX(ulong existingHandle) { Handle = existingHandle; }
        public static VkCuFunctionNVX Null => new VkCuFunctionNVX(0);
        public static implicit operator VkCuFunctionNVX(ulong handle) => new VkCuFunctionNVX(handle);
        public static bool operator ==(VkCuFunctionNVX left, VkCuFunctionNVX right) => left.Handle == right.Handle;
        public static bool operator !=(VkCuFunctionNVX left, VkCuFunctionNVX right) => left.Handle != right.Handle;
        public static bool operator ==(VkCuFunctionNVX left, ulong right) => left.Handle == right;
        public static bool operator !=(VkCuFunctionNVX left, ulong right) => left.Handle != right;
        public bool Equals(VkCuFunctionNVX h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkCuFunctionNVX h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkCuFunctionNVX [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkOpticalFlowSessionNV : IEquatable<VkOpticalFlowSessionNV>
    {
        public readonly ulong Handle;
        public VkOpticalFlowSessionNV(ulong existingHandle) { Handle = existingHandle; }
        public static VkOpticalFlowSessionNV Null => new VkOpticalFlowSessionNV(0);
        public static implicit operator VkOpticalFlowSessionNV(ulong handle) => new VkOpticalFlowSessionNV(handle);
        public static bool operator ==(VkOpticalFlowSessionNV left, VkOpticalFlowSessionNV right) => left.Handle == right.Handle;
        public static bool operator !=(VkOpticalFlowSessionNV left, VkOpticalFlowSessionNV right) => left.Handle != right.Handle;
        public static bool operator ==(VkOpticalFlowSessionNV left, ulong right) => left.Handle == right;
        public static bool operator !=(VkOpticalFlowSessionNV left, ulong right) => left.Handle != right;
        public bool Equals(VkOpticalFlowSessionNV h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkOpticalFlowSessionNV h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkOpticalFlowSessionNV [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkMicromapEXT : IEquatable<VkMicromapEXT>
    {
        public readonly ulong Handle;
        public VkMicromapEXT(ulong existingHandle) { Handle = existingHandle; }
        public static VkMicromapEXT Null => new VkMicromapEXT(0);
        public static implicit operator VkMicromapEXT(ulong handle) => new VkMicromapEXT(handle);
        public static bool operator ==(VkMicromapEXT left, VkMicromapEXT right) => left.Handle == right.Handle;
        public static bool operator !=(VkMicromapEXT left, VkMicromapEXT right) => left.Handle != right.Handle;
        public static bool operator ==(VkMicromapEXT left, ulong right) => left.Handle == right;
        public static bool operator !=(VkMicromapEXT left, ulong right) => left.Handle != right;
        public bool Equals(VkMicromapEXT h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkMicromapEXT h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkMicromapEXT [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkShaderEXT : IEquatable<VkShaderEXT>
    {
        public readonly ulong Handle;
        public VkShaderEXT(ulong existingHandle) { Handle = existingHandle; }
        public static VkShaderEXT Null => new VkShaderEXT(0);
        public static implicit operator VkShaderEXT(ulong handle) => new VkShaderEXT(handle);
        public static bool operator ==(VkShaderEXT left, VkShaderEXT right) => left.Handle == right.Handle;
        public static bool operator !=(VkShaderEXT left, VkShaderEXT right) => left.Handle != right.Handle;
        public static bool operator ==(VkShaderEXT left, ulong right) => left.Handle == right;
        public static bool operator !=(VkShaderEXT left, ulong right) => left.Handle != right;
        public bool Equals(VkShaderEXT h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkShaderEXT h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkShaderEXT [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkTensorARM : IEquatable<VkTensorARM>
    {
        public readonly ulong Handle;
        public VkTensorARM(ulong existingHandle) { Handle = existingHandle; }
        public static VkTensorARM Null => new VkTensorARM(0);
        public static implicit operator VkTensorARM(ulong handle) => new VkTensorARM(handle);
        public static bool operator ==(VkTensorARM left, VkTensorARM right) => left.Handle == right.Handle;
        public static bool operator !=(VkTensorARM left, VkTensorARM right) => left.Handle != right.Handle;
        public static bool operator ==(VkTensorARM left, ulong right) => left.Handle == right;
        public static bool operator !=(VkTensorARM left, ulong right) => left.Handle != right;
        public bool Equals(VkTensorARM h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkTensorARM h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkTensorARM [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkTensorViewARM : IEquatable<VkTensorViewARM>
    {
        public readonly ulong Handle;
        public VkTensorViewARM(ulong existingHandle) { Handle = existingHandle; }
        public static VkTensorViewARM Null => new VkTensorViewARM(0);
        public static implicit operator VkTensorViewARM(ulong handle) => new VkTensorViewARM(handle);
        public static bool operator ==(VkTensorViewARM left, VkTensorViewARM right) => left.Handle == right.Handle;
        public static bool operator !=(VkTensorViewARM left, VkTensorViewARM right) => left.Handle != right.Handle;
        public static bool operator ==(VkTensorViewARM left, ulong right) => left.Handle == right;
        public static bool operator !=(VkTensorViewARM left, ulong right) => left.Handle != right;
        public bool Equals(VkTensorViewARM h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkTensorViewARM h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkTensorViewARM [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkPhysicalDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkDisplayKHR : IEquatable<VkDisplayKHR>
    {
        public readonly ulong Handle;
        public VkDisplayKHR(ulong existingHandle) { Handle = existingHandle; }
        public static VkDisplayKHR Null => new VkDisplayKHR(0);
        public static implicit operator VkDisplayKHR(ulong handle) => new VkDisplayKHR(handle);
        public static bool operator ==(VkDisplayKHR left, VkDisplayKHR right) => left.Handle == right.Handle;
        public static bool operator !=(VkDisplayKHR left, VkDisplayKHR right) => left.Handle != right.Handle;
        public static bool operator ==(VkDisplayKHR left, ulong right) => left.Handle == right;
        public static bool operator !=(VkDisplayKHR left, ulong right) => left.Handle != right;
        public bool Equals(VkDisplayKHR h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkDisplayKHR h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkDisplayKHR [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDisplayKHR.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkDisplayModeKHR : IEquatable<VkDisplayModeKHR>
    {
        public readonly ulong Handle;
        public VkDisplayModeKHR(ulong existingHandle) { Handle = existingHandle; }
        public static VkDisplayModeKHR Null => new VkDisplayModeKHR(0);
        public static implicit operator VkDisplayModeKHR(ulong handle) => new VkDisplayModeKHR(handle);
        public static bool operator ==(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Handle == right.Handle;
        public static bool operator !=(VkDisplayModeKHR left, VkDisplayModeKHR right) => left.Handle != right.Handle;
        public static bool operator ==(VkDisplayModeKHR left, ulong right) => left.Handle == right;
        public static bool operator !=(VkDisplayModeKHR left, ulong right) => left.Handle != right;
        public bool Equals(VkDisplayModeKHR h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkDisplayModeKHR h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkDisplayModeKHR [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkInstance.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkSurfaceKHR : IEquatable<VkSurfaceKHR>
    {
        public readonly ulong Handle;
        public VkSurfaceKHR(ulong existingHandle) { Handle = existingHandle; }
        public static VkSurfaceKHR Null => new VkSurfaceKHR(0);
        public static implicit operator VkSurfaceKHR(ulong handle) => new VkSurfaceKHR(handle);
        public static bool operator ==(VkSurfaceKHR left, VkSurfaceKHR right) => left.Handle == right.Handle;
        public static bool operator !=(VkSurfaceKHR left, VkSurfaceKHR right) => left.Handle != right.Handle;
        public static bool operator ==(VkSurfaceKHR left, ulong right) => left.Handle == right;
        public static bool operator !=(VkSurfaceKHR left, ulong right) => left.Handle != right;
        public bool Equals(VkSurfaceKHR h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkSurfaceKHR h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkSurfaceKHR [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkSwapchainKHR : IEquatable<VkSwapchainKHR>
    {
        public readonly ulong Handle;
        public VkSwapchainKHR(ulong existingHandle) { Handle = existingHandle; }
        public static VkSwapchainKHR Null => new VkSwapchainKHR(0);
        public static implicit operator VkSwapchainKHR(ulong handle) => new VkSwapchainKHR(handle);
        public static bool operator ==(VkSwapchainKHR left, VkSwapchainKHR right) => left.Handle == right.Handle;
        public static bool operator !=(VkSwapchainKHR left, VkSwapchainKHR right) => left.Handle != right.Handle;
        public static bool operator ==(VkSwapchainKHR left, ulong right) => left.Handle == right;
        public static bool operator !=(VkSwapchainKHR left, ulong right) => left.Handle != right;
        public bool Equals(VkSwapchainKHR h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkSwapchainKHR h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkSwapchainKHR [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkInstance.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkDebugReportCallbackEXT : IEquatable<VkDebugReportCallbackEXT>
    {
        public readonly ulong Handle;
        public VkDebugReportCallbackEXT(ulong existingHandle) { Handle = existingHandle; }
        public static VkDebugReportCallbackEXT Null => new VkDebugReportCallbackEXT(0);
        public static implicit operator VkDebugReportCallbackEXT(ulong handle) => new VkDebugReportCallbackEXT(handle);
        public static bool operator ==(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Handle == right.Handle;
        public static bool operator !=(VkDebugReportCallbackEXT left, VkDebugReportCallbackEXT right) => left.Handle != right.Handle;
        public static bool operator ==(VkDebugReportCallbackEXT left, ulong right) => left.Handle == right;
        public static bool operator !=(VkDebugReportCallbackEXT left, ulong right) => left.Handle != right;
        public bool Equals(VkDebugReportCallbackEXT h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkDebugReportCallbackEXT h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkDebugReportCallbackEXT [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkInstance.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkDebugUtilsMessengerEXT : IEquatable<VkDebugUtilsMessengerEXT>
    {
        public readonly ulong Handle;
        public VkDebugUtilsMessengerEXT(ulong existingHandle) { Handle = existingHandle; }
        public static VkDebugUtilsMessengerEXT Null => new VkDebugUtilsMessengerEXT(0);
        public static implicit operator VkDebugUtilsMessengerEXT(ulong handle) => new VkDebugUtilsMessengerEXT(handle);
        public static bool operator ==(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Handle == right.Handle;
        public static bool operator !=(VkDebugUtilsMessengerEXT left, VkDebugUtilsMessengerEXT right) => left.Handle != right.Handle;
        public static bool operator ==(VkDebugUtilsMessengerEXT left, ulong right) => left.Handle == right;
        public static bool operator !=(VkDebugUtilsMessengerEXT left, ulong right) => left.Handle != right;
        public bool Equals(VkDebugUtilsMessengerEXT h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkDebugUtilsMessengerEXT h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkDebugUtilsMessengerEXT [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkVideoSessionKHR : IEquatable<VkVideoSessionKHR>
    {
        public readonly ulong Handle;
        public VkVideoSessionKHR(ulong existingHandle) { Handle = existingHandle; }
        public static VkVideoSessionKHR Null => new VkVideoSessionKHR(0);
        public static implicit operator VkVideoSessionKHR(ulong handle) => new VkVideoSessionKHR(handle);
        public static bool operator ==(VkVideoSessionKHR left, VkVideoSessionKHR right) => left.Handle == right.Handle;
        public static bool operator !=(VkVideoSessionKHR left, VkVideoSessionKHR right) => left.Handle != right.Handle;
        public static bool operator ==(VkVideoSessionKHR left, ulong right) => left.Handle == right;
        public static bool operator !=(VkVideoSessionKHR left, ulong right) => left.Handle != right;
        public bool Equals(VkVideoSessionKHR h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkVideoSessionKHR h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkVideoSessionKHR [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkVideoSessionKHR.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkVideoSessionParametersKHR : IEquatable<VkVideoSessionParametersKHR>
    {
        public readonly ulong Handle;
        public VkVideoSessionParametersKHR(ulong existingHandle) { Handle = existingHandle; }
        public static VkVideoSessionParametersKHR Null => new VkVideoSessionParametersKHR(0);
        public static implicit operator VkVideoSessionParametersKHR(ulong handle) => new VkVideoSessionParametersKHR(handle);
        public static bool operator ==(VkVideoSessionParametersKHR left, VkVideoSessionParametersKHR right) => left.Handle == right.Handle;
        public static bool operator !=(VkVideoSessionParametersKHR left, VkVideoSessionParametersKHR right) => left.Handle != right.Handle;
        public static bool operator ==(VkVideoSessionParametersKHR left, ulong right) => left.Handle == right;
        public static bool operator !=(VkVideoSessionParametersKHR left, ulong right) => left.Handle != right;
        public bool Equals(VkVideoSessionParametersKHR h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkVideoSessionParametersKHR h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkVideoSessionParametersKHR [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkSemaphoreSciSyncPoolNV : IEquatable<VkSemaphoreSciSyncPoolNV>
    {
        public readonly ulong Handle;
        public VkSemaphoreSciSyncPoolNV(ulong existingHandle) { Handle = existingHandle; }
        public static VkSemaphoreSciSyncPoolNV Null => new VkSemaphoreSciSyncPoolNV(0);
        public static implicit operator VkSemaphoreSciSyncPoolNV(ulong handle) => new VkSemaphoreSciSyncPoolNV(handle);
        public static bool operator ==(VkSemaphoreSciSyncPoolNV left, VkSemaphoreSciSyncPoolNV right) => left.Handle == right.Handle;
        public static bool operator !=(VkSemaphoreSciSyncPoolNV left, VkSemaphoreSciSyncPoolNV right) => left.Handle != right.Handle;
        public static bool operator ==(VkSemaphoreSciSyncPoolNV left, ulong right) => left.Handle == right;
        public static bool operator !=(VkSemaphoreSciSyncPoolNV left, ulong right) => left.Handle != right;
        public bool Equals(VkSemaphoreSciSyncPoolNV h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkSemaphoreSciSyncPoolNV h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkSemaphoreSciSyncPoolNV [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkCudaModuleNV : IEquatable<VkCudaModuleNV>
    {
        public readonly ulong Handle;
        public VkCudaModuleNV(ulong existingHandle) { Handle = existingHandle; }
        public static VkCudaModuleNV Null => new VkCudaModuleNV(0);
        public static implicit operator VkCudaModuleNV(ulong handle) => new VkCudaModuleNV(handle);
        public static bool operator ==(VkCudaModuleNV left, VkCudaModuleNV right) => left.Handle == right.Handle;
        public static bool operator !=(VkCudaModuleNV left, VkCudaModuleNV right) => left.Handle != right.Handle;
        public static bool operator ==(VkCudaModuleNV left, ulong right) => left.Handle == right;
        public static bool operator !=(VkCudaModuleNV left, ulong right) => left.Handle != right;
        public bool Equals(VkCudaModuleNV h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkCudaModuleNV h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkCudaModuleNV [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A non-dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkCudaFunctionNV : IEquatable<VkCudaFunctionNV>
    {
        public readonly ulong Handle;
        public VkCudaFunctionNV(ulong existingHandle) { Handle = existingHandle; }
        public static VkCudaFunctionNV Null => new VkCudaFunctionNV(0);
        public static implicit operator VkCudaFunctionNV(ulong handle) => new VkCudaFunctionNV(handle);
        public static bool operator ==(VkCudaFunctionNV left, VkCudaFunctionNV right) => left.Handle == right.Handle;
        public static bool operator !=(VkCudaFunctionNV left, VkCudaFunctionNV right) => left.Handle != right.Handle;
        public static bool operator ==(VkCudaFunctionNV left, ulong right) => left.Handle == right;
        public static bool operator !=(VkCudaFunctionNV left, ulong right) => left.Handle != right;
        public bool Equals(VkCudaFunctionNV h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkCudaFunctionNV h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkCudaFunctionNV [0x{0}]", Handle.ToString("X"));
    }

    ///<summary>A dispatchable handle owned by a VkDevice.</summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial struct VkExternalComputeQueueNV : IEquatable<VkExternalComputeQueueNV>
    {
        public readonly IntPtr Handle;
        public VkExternalComputeQueueNV(IntPtr existingHandle) { Handle = existingHandle; }
        public static VkExternalComputeQueueNV Null => new VkExternalComputeQueueNV(IntPtr.Zero);
        public static implicit operator VkExternalComputeQueueNV(IntPtr handle) => new VkExternalComputeQueueNV(handle);
        public static bool operator ==(VkExternalComputeQueueNV left, VkExternalComputeQueueNV right) => left.Handle == right.Handle;
        public static bool operator !=(VkExternalComputeQueueNV left, VkExternalComputeQueueNV right) => left.Handle != right.Handle;
        public static bool operator ==(VkExternalComputeQueueNV left, IntPtr right) => left.Handle == right;
        public static bool operator !=(VkExternalComputeQueueNV left, IntPtr right) => left.Handle != right;
        public bool Equals(VkExternalComputeQueueNV h) => Handle == h.Handle;
        public override bool Equals(object o) => o is VkExternalComputeQueueNV h && Equals(h);
        public override int GetHashCode() => Handle.GetHashCode();
        private string DebuggerDisplay => string.Format("VkExternalComputeQueueNV [0x{0}]", Handle.ToString("X"));
    }
}
