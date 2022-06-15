using OpenTK.Graphics.OpenGL;
using System.ComponentModel;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using Boolean = System.Boolean;
using Vector3 = OpenTK.Mathematics.Vector3;

namespace AERengine.render.window;

public class GWindow : GameWindow
{
    public GWindow(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings){}

    protected override void OnLoad()
    {
        base.OnLoad();
    }

    protected override void OnUpdateFrame(FrameEventArgs args)
    {

        if (this.KeyboardState.IsKeyDown(Keys.Escape))
        {
            this.OnClosing(new CancelEventArgs());
            this.Close();
        }
        
        base.OnUpdateFrame(args);
    }

    protected override void OnResize(ResizeEventArgs e)
    {
        base.OnResize(e);
        GL.Viewport(0, 0, e.Width, e.Height);
    }
    protected override void OnMouseMove(MouseMoveEventArgs e)
    {
    }
}
