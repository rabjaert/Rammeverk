using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppASCIIFramework.View
{
    class Window
    {
        private int Width { get; set; }
        private int Height { get; set;
        private string BackgroundColor { get; set; }
        private static IEnumerable<View> addedViews {get; set;}
    }

    public Window(int Width, int Height, string BackgroundColor)
    {
        this.Width = Width;
        this.Height = Height;
        this.BackgroundColor = BackgroundColor;
    }
}
