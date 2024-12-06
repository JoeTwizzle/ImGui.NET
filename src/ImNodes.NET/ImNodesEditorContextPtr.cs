using System;

namespace ImNodesNET
{
    public struct ImNodesContextPtr
    {
        public ImNodesContextPtr(IntPtr nativePtr)
        {
            NativePtr = nativePtr;
        }

        internal unsafe IntPtr NativePtr { get; }
    }
}