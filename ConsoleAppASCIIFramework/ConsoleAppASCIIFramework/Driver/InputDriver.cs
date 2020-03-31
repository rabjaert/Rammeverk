using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ConsoleAppASCIIFramework.Driver
{
    class InputDriver
    {

        public static System.Windows.Input.MouseButtonState LeftButton { get; }

        public static void KeyPressed()
        {

            if(Mouse.LeftButton == MouseButtonState.Pressed)
            {
                //doSomething();
            }
            else if(Mouse.RightButton == MouseButtonState.Pressed)
            {
                //doSomething();
            }

        }


    }
}
