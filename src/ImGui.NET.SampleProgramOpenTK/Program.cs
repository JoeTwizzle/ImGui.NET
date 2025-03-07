using ImGuiNET;
using ImGuizmoNET;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace ImGuiExampleOTK;

internal class Program
{
    static void Main(string[] args)
    {
        MyGame g = new(GameWindowSettings.Default, NativeWindowSettings.Default);
        g.Run();
    }
}

class MyGame : GameWindow
{
    ImGuiController _controller;

    public MyGame(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
    {
        _controller = new(nativeWindowSettings.ClientSize.X, nativeWindowSettings.ClientSize.Y);
    }

    protected override void OnLoad()
    {
        base.OnLoad();
    }

    protected override void OnResize(ResizeEventArgs e)
    {
        base.OnResize(e);
        _controller.WindowResized(e.Width, e.Height);
        GL.Viewport(0, 0, e.Width, e.Height);
        ImGuizmo.SetRect(0, 0, e.Width, e.Height);
    }

    protected override void OnMouseWheel(MouseWheelEventArgs e)
    {
        base.OnMouseWheel(e);
        _controller.MouseScroll(e.Offset);
    }


    Matrix4 viewMatrix = Matrix4.LookAt(Vector3.Zero, Vector3.Zero + new Vector3(0, 0, -1), Vector3.UnitY).Transposed();
    Matrix4 projMatrix = Matrix4.CreatePerspectiveFieldOfView(MathHelper.DegreesToRadians(90f), 16 / 9f, 0.1f, 1000f).Transposed();
    Matrix4 gridMatrix = Matrix4.Identity.Transposed();
    protected override void OnUpdateFrame(FrameEventArgs args)
    {

        base.OnUpdateFrame(args);
        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        _controller.Update(this, (float)args.Time);
        ImGui.ShowDemoWindow();
        ImGuizmo.DrawGrid(ref viewMatrix.Row0.X, ref projMatrix.Row0.X, ref gridMatrix.Row0.X, 100f);
        _controller.Render();
        SwapBuffers();
    }
}
