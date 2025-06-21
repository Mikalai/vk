using System.Collections.Generic;

namespace Vk.Generator
{
    public class TypeNameMappings
    {
        private readonly Dictionary<string, string> _nameMappings = new Dictionary<string, string>()
        {
            { "uint8_t", "byte" },
            { "uint16_t", "ushort" },
            { "uint32_t", "uint" },
            { "uint64_t", "ulong" },
            { "int32_t", "int" },
            { "int64_t", "long" },
            { "int64_t*", "long*" },
            { "char", "byte" },
            { "size_t", "UIntPtr" },
            { "DWORD", "uint" },

            { "ANativeWindow", "Android.ANativeWindow" },
            { "OHNativeWindow", "OHOS.OHNativeWindow" },

            { "MirConnection", "Mir.MirConnection" },
            { "MirSurface", "Mir.MirSurface" },

            { "wl_display", "Wayland.wl_display" },
            { "wl_surface", "Wayland.wl_surface" },

            { "Display", "Xlib.Display" },
            { "Window", "Xlib.Window" },
            { "VisualID", "Xlib.VisualID" },
            { "RROutput", "IntPtr" },
            { "VkRemoteAddressNV", "IntPtr" },
            { "zx_handle_t", "uint" },
            { "_screen_buffer", "Qnx.ScreenBuffer" },
            { "MTLSharedEvent_id", "Metal.MTLSharedEvent" },
            { "IOSurfaceRef", "Apple.IOSurfaceRef" },
            { "MTLTexture_id", "Metal.MTLTexture" },
            { "MTLBuffer_id", "Metal.MTLBuffer" },
            { "MTLCommandQueue_id", "Metal.MTLCommandQueue" },
            { "MTLDevice_id", "Metal.MTLDevice" },
            { "StdVideoEncodeH265SliceSegmentHeader", "IntPtr" },
            { "StdVideoEncodeH265PictureInfo", "IntPtr" },
            { "StdVideoDecodeAV1ReferenceInfo", "IntPtr" },
            { "StdVideoDecodeAV1PictureInfo", "IntPtr" },
            { "StdVideoDecodeVP9PictureInfo", "IntPtr" },
            { "StdVideoDecodeH265ReferenceInfo", "IntPtr" },
            { "StdVideoDecodeH265PictureInfo", "IntPtr" },
            { "StdVideoDecodeH264ReferenceInfo", "IntPtr" },
            { "StdVideoDecodeH264PictureInfo", "IntPtr" },
            { "StdVideoVP9Level", "int" },
            { "StdVideoVP9Profile", "int" },
            { "StdVideoAV1Profile", "IntPtr" },
            { "StdVideoEncodeAV1PictureInfo", "IntPtr" },
            { "StdVideoEncodeAV1ReferenceInfo", "IntPtr" },
            { "StdVideoEncodeAV1OperatingPointInfo", "IntPtr" },
            { "StdVideoEncodeAV1DecoderModelInfo", "IntPtr" },
            { "StdVideoAV1SequenceHeader", "IntPtr" },
            { "StdVideoAV1Level", "int" },
            { "StdVideoEncodeH265ReferenceInfo", "IntPtr" },
            { "StdVideoEncodeH264ReferenceInfo", "IntPtr" },
            { "StdVideoH265ProfileIdc", "int" },
            { "StdVideoH264ProfileIdc", "int" },
            { "StdVideoH265LevelIdc", "int" },
            { "StdVideoH264LevelIdc", "int" },
            { "StdVideoEncodeH264SliceHeader", "IntPtr" },
            { "StdVideoEncodeH264PictureInfo", "IntPtr" },
            { "StdVideoH265VideoParameterSet", "IntPtr" },
            { "StdVideoH265SequenceParameterSet", "IntPtr" },
            { "StdVideoH265PictureParameterSet", "IntPtr" },
            { "StdVideoH264VideoParameterSet", "IntPtr" },
            { "StdVideoH264SequenceParameterSet", "IntPtr" },
            { "StdVideoH264PictureParameterSet", "IntPtr" },
            { "GgpFrameToken", "Ggp.FrameToken" },
            { "GgpStreamDescriptor", "Ggp.StreamDescriptor" },

            { "HINSTANCE", "Win32.HINSTANCE" },
            { "HWND", "Win32.HWND" },
            { "HANDLE", "Win32.HANDLE" },
            { "HMONITOR", "Win32.HMONITOR" },
            { "SECURITY_ATTRIBUTES", "Win32.SECURITY_ATTRIBUTES" },
            { "LPCWSTR", "IntPtr" },

            { "AHardwareBuffer", "Android.AHardwareBuffer" },
            { "CAMetalLayer", "Metal.CAMetalLayer" },
            { "NvSciSyncFence", "Nvidia.NvSciSyncFence" },
            { "NvSciSyncObj", "Nvidia.NvSciSyncObj" },
            { "NvSciSyncAttrList", "Nvidia.NvSciSyncAttrList" },
            { "NvSciBufObj", "Nvidia.NvSciBufObj" },
            { "NvSciBufAttrList", "Nvidia.NvSciBufAttrList" },

            { "_screen_context", "Qnx.ScreenContext" },
            { "_screen_window", "Qnx.ScreenWindow" },

            { "xcb_connection_t", "Xcb.xcb_connection_t" },
            { "xcb_window_t", "Xcb.xcb_window_t" },
            { "xcb_visualid_t", "Xcb.xcb_visualid_t" },

            { "IDirectFB", "DirectFB.IDirectFB" },
            { "IDirectFBSurface", "DirectFB.IDirectFBSurface" }
        };

        internal IEnumerable<KeyValuePair<string, string>> GetAllMappings()
        {
            return _nameMappings;
        }

        public void AddMapping(string originalName, string newName)
        {
            if (_nameMappings.TryGetValue(originalName, out var value))
            {
                if (value == null)
                    _nameMappings.Add(originalName, newName);
            }
            else
                _nameMappings.Add(originalName, newName);
        }

        public string GetMappedName(string name)
        {
            if (_nameMappings.TryGetValue(name, out string mappedName))
            {
                return GetMappedName(mappedName);
            }
            else if (name.StartsWith("PFN"))
            {
                return "IntPtr";
            }
            else
            {
                return name;
            }
        }
    }
}
