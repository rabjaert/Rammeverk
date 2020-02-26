using ConsoleAppASCIIFramework.View;
using System;

namespace ConsoleAppASCIIFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            var start = new Application();

            var mainWindow = new Window("main") {

                Width = 100;
                Height = 100;
                BackgroundColor = "Green";
                
            }

            start.add(mainWindow);


            var menuForMainWindow = new NavigationMenu(1, 1, mainWindow)
            {
                new menuField(1, "Settings") => settingsWindow.Open();
            }
            


       
                
            menuForMainWindow.changeTextColor("red");

    


            
            NagivationMenu nagivationMenu = new NagivationMenu("bolle");
            Console.WriteLine(nagivationMenu);
            


        dropdown menu
        menuBar
        checkbox : Clicked, width, height, x, y
        button : Action, Size, Color, Text
        radio button
        textfield : Size, Position, Content
        textbox : Size, Position, Content
        textlabel : Size, Position, Content
        asciiImage
        asciiDrawing
        listview
        Menu : Size, Color, Type, Text, Clickable, Action, Position


        }
    }
}
