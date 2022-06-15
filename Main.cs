//using
using System;
using AERengine.render;
using AERengine.render.window;
//namespaces

namespace AERengine;

public static class Program
{
    public static void Main(string[] args)
    {
        Window window = new Window("из очка Сани", 1280, 720, 60);
        window._window.Run();
    }
}
    