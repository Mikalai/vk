using System;

namespace Vulkan
{
    // Windows

    namespace Win32
    {
        public struct HINSTANCE
        {
            public IntPtr Handle;
            public static implicit operator IntPtr(HINSTANCE hinst)
            {
                return hinst.Handle;
            }

            public static implicit operator HINSTANCE(IntPtr handle)
            {
                return new HINSTANCE() { Handle = handle };
            }
        }

        public struct HMONITOR
        {
            public IntPtr Handle;
            public static implicit operator IntPtr(HMONITOR hinst)
            {
                return hinst.Handle;
            }

            public static implicit operator HMONITOR(IntPtr handle)
            {
                return new HMONITOR() { Handle = handle };
            }
        }

        public struct HWND
        {
            public IntPtr Handle;
            public static implicit operator IntPtr(HWND hwnd)
            {
                return hwnd.Handle;
            }

            public static implicit operator HWND(IntPtr handle)
            {
                return new HWND() { Handle = handle };
            }
        }

        public struct HANDLE
        {
            public IntPtr Handle;
            public static implicit operator IntPtr(HANDLE handle)
            {
                return handle.Handle;
            }

            public static implicit operator HANDLE(IntPtr handle)
            {
                return new HANDLE() { Handle = handle };
            }
        }

        public struct SECURITY_ATTRIBUTES
        {
            public uint nLength;
            public IntPtr lpSecurityDescriptor;
            public uint bInheritHandle;
        }
    }

    // Android
    namespace Android
    {
        public struct ANativeWindow { }
        public struct AHardwareBuffer
        {
            // opaque handle, defined in <android/hardware_buffer.h>
        }
    }

    namespace OHOS
    {
        public struct OHNativeWindow
        {
            // opaque, platform-specific
        }
    }

    namespace Qnx
    {
        public struct ScreenBuffer
        {
            // opaque handle
        }
        public struct ScreenContext
        {
            // opaque type from QNX Screen API
        }

        public struct ScreenWindow
        {
        }
    }

    namespace Metal
    {
        public struct CAMetalLayer
        {
            // Objective-C: CALayer subclass for Metal rendering
        }

        public struct MTLSharedEvent
        {
            // opaque pointer to Objective-C id<MTLSharedEvent>
        }

        public struct MTLTexture
        {
            // opaque Objective-C id<MTLTexture>
        }

        public struct MTLBuffer
        {
            // opaque Objective-C id<MTLBuffer>
        }

        public struct MTLCommandQueue
        {
            // opaque Objective-C id<MTLBuffer>
        }

        public struct MTLDevice
        {
            // opaque Objective-C id<MTLBuffer>
        }
    }

    namespace Ggp
    {
        public struct FrameToken
        {
            // opaque type for Google Stadia
        }

        public struct StreamDescriptor
        {
            // opaque handle for Google Stadia stream
        }
    }


    namespace Apple
    {
        public struct IOSurfaceRef
        {
            // opaque pointer to IOSurface
        }
    }

    // Linux
    namespace Mir
    {
        public struct MirConnection { }
        public struct MirSurface { }
    }

    namespace Wayland
    {
        public struct wl_display { }
        public struct wl_surface { }
    }

    namespace Xlib
    {
        public struct Display { }
        public struct Window
        {
            public IntPtr Value;
        }
        public struct VisualID
        {
            public ulong ID;
            public static implicit operator VisualID(ulong value)
            {
                return new VisualID() { ID = value };
            }

            public static implicit operator ulong(VisualID id)
            {
                return id.ID;
            }
        }
    }

    namespace Xcb
    {
        public struct xcb_connection_t { }
        public struct xcb_window_t { }
        public struct xcb_visualid_t
        {
            public uint ID;
            public static implicit operator xcb_visualid_t(uint value)
            {
                return new xcb_visualid_t() { ID = value };
            }

            public static implicit operator uint(xcb_visualid_t id)
            {
                return id.ID;
            }
        }
    }

    namespace Nvidia
    {
        public struct NvSciBufObj
        {
            // opaque buffer handle from NVIDIA SDK
        }

        public struct NvSciBufAttrList
        {

        }

        public struct NvSciSyncFence
        {
            // opaque type from NVIDIA Drive SDK
        }

        public struct NvSciSyncObj
        {
            // opaque handle from NVIDIA NvSciSync
        }

        public struct NvSciSyncAttrList
        {
            // opaque type from NVIDIA SDK
        }
    }

    namespace DirectFB
    {
        public struct IDirectFB { }
        public struct IDirectFBSurface { }
    }

}
