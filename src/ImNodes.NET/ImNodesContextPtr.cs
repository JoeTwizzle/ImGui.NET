using System;

namespace ImNodesNET
{
    public struct ImNodesEditorContextPtr
    {
        public ImNodesEditorContextPtr(IntPtr nativePtr)
        {
            NativePtr = nativePtr;
        }

        internal unsafe IntPtr NativePtr { get; }
    }
}