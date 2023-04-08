using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using ImGuiNET;

namespace ImGuizmoNET
{
    public unsafe partial struct Style
    {
        public float TranslationLineThickness;
        public float TranslationLineArrowSize;
        public float RotationLineThickness;
        public float RotationOuterLineThickness;
        public float ScaleLineThickness;
        public float ScaleLineCircleSize;
        public float HatchedAxisLineThickness;
        public float CenterCircleSize;
        public Vector4 Colors_0;
        public Vector4 Colors_1;
        public Vector4 Colors_2;
        public Vector4 Colors_3;
        public Vector4 Colors_4;
        public Vector4 Colors_5;
        public Vector4 Colors_6;
        public Vector4 Colors_7;
        public Vector4 Colors_8;
        public Vector4 Colors_9;
        public Vector4 Colors_10;
        public Vector4 Colors_11;
        public Vector4 Colors_12;
        public Vector4 Colors_13;
        public Vector4 Colors_14;
    }
    public unsafe partial struct StylePtr
    {
        public Style* NativePtr { get; }
        public StylePtr(Style* nativePtr) => NativePtr = nativePtr;
        public StylePtr(IntPtr nativePtr) => NativePtr = (Style*)nativePtr;
        public static implicit operator StylePtr(Style* nativePtr) => new StylePtr(nativePtr);
        public static implicit operator Style* (StylePtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator StylePtr(IntPtr nativePtr) => new StylePtr(nativePtr);
        public ref float TranslationLineThickness => ref Unsafe.AsRef<float>(&NativePtr->TranslationLineThickness);
        public ref float TranslationLineArrowSize => ref Unsafe.AsRef<float>(&NativePtr->TranslationLineArrowSize);
        public ref float RotationLineThickness => ref Unsafe.AsRef<float>(&NativePtr->RotationLineThickness);
        public ref float RotationOuterLineThickness => ref Unsafe.AsRef<float>(&NativePtr->RotationOuterLineThickness);
        public ref float ScaleLineThickness => ref Unsafe.AsRef<float>(&NativePtr->ScaleLineThickness);
        public ref float ScaleLineCircleSize => ref Unsafe.AsRef<float>(&NativePtr->ScaleLineCircleSize);
        public ref float HatchedAxisLineThickness => ref Unsafe.AsRef<float>(&NativePtr->HatchedAxisLineThickness);
        public ref float CenterCircleSize => ref Unsafe.AsRef<float>(&NativePtr->CenterCircleSize);
        public RangeAccessor<Vector4> Colors => new RangeAccessor<Vector4>(&NativePtr->Colors_0, 15);
        public void Destroy()
        {
            ImGuizmoNative.Style_destroy((Style*)(NativePtr));
        }
    }
}
