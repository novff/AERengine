using System;
using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;

namespace AERengine.render.window;

public class Window
{
    private int _sizeX;
    private int _sizeY;
    private string _title;
    private int _fps;
    private NativeWindowSettings _nws;
    private GameWindowSettings _gws;
    public GameWindow _window;

    public Window(string title, int sizeX, int sizeY, int fps = 60)
    {
        _sizeX = sizeX;
        _sizeY = sizeY;
        _title = title;
        _fps = fps;

        _gws = GameWindowSettings.Default;
        _gws.RenderFrequency = _fps;
        _gws.UpdateFrequency = _fps;
        _gws.IsMultiThreaded = true;

        _nws = NativeWindowSettings.Default;
        //_nws.APIVersion = Version.Parse("4.6");
        _nws.Size = new Vector2i(_sizeX, _sizeY);
        _nws.Title = _title;
        _nws.IsEventDriven = false;

        _window = new GWindow(_gws, _nws);

    }
}
