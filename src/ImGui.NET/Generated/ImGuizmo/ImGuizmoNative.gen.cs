using System;
using System.Numerics;
using System.Runtime.InteropServices;
using ImGuiNET;

namespace ImGuizmoNET
{
    public static unsafe partial class ImGuizmoNative
    {
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_AllowAxisFlip(byte value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_BeginFrame();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_DecomposeMatrixToComponents(float* matrix, float* translation, float* rotation, float* scale);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_DrawCubes(float* view, float* projection, float* matrices, int matrixCount);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_DrawGrid(float* view, float* projection, float* matrix, float gridSize);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_Enable(byte enable);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuizmo_GetID_Str(byte* str_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuizmo_GetID_StrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuizmo_GetID_Ptr(void* ptr_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Style* ImGuizmo_GetStyle();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuizmo_IsOver_Nil();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuizmo_IsOver_OPERATION(OPERATION op);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuizmo_IsOver_FloatPtr(float* position, float pixelRadius);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuizmo_IsUsing();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuizmo_IsUsingAny();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuizmo_IsUsingViewManipulate();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuizmo_IsViewManipulateHovered();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuizmo_Manipulate(float* view, float* projection, OPERATION operation, MODE mode, float* matrix, float* deltaMatrix, float* snap, float* localBounds, float* boundsSnap);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_PopID();
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_PushID_Str(byte* str_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_PushID_StrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_PushID_Ptr(void* ptr_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_PushID_Int(int int_id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_RecomposeMatrixFromComponents(float* translation, float* rotation, float* scale, float* matrix);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_SetAlternativeWindow(IntPtr window);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_SetAxisLimit(float value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_SetAxisMask(byte x, byte y, byte z);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_SetDrawlist(ImDrawList* drawlist);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_SetGizmoSizeClipSpace(float value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_SetID(int id);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_SetImGuiContext(IntPtr ctx);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_SetOrthographic(byte isOrthographic);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_SetPlaneLimit(float value);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_SetRect(float x, float y, float width, float height);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_ViewManipulate_Float(float* view, float length, Vector2 position, Vector2 size, uint backgroundColor);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuizmo_ViewManipulate_FloatPtr(float* view, float* projection, OPERATION operation, MODE mode, float* matrix, float length, Vector2 position, Vector2 size, uint backgroundColor);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern void Style_destroy(Style* self);
        [DllImport("cimgui", CallingConvention = CallingConvention.Cdecl)]
        public static extern Style* Style_Style();
    }
}
