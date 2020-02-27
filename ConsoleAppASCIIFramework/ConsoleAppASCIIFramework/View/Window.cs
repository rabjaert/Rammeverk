using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppASCIIFramework.View
{
    class Window : Application
    {
        private int Width { get; set; }
        private int Height { get; set; }
        private string BackgroundColor { get; set; }
        public IEnumerable<View> addedViews { get; set; }


        public Window(int Width, int Height, string BackgroundColor, Application application)
        {
            this.Width = Width;
            this.Height = Height;
            this.BackgroundColor = BackgroundColor;
            this.application = application;
        }
    }
}