﻿using ConsoleAppASCIIFramework.View;


namespace ConsoleAppASCIIFramework
{
    class Program
    {
        static void Main(string[] args)
        {

            var start = new Application();

            var mainWindow = new Window(100,100,"black");
            

            ButtonClicked enButton = new ButtonClicked("hei", 1, 1, 1, 1);
            enButton.OnActionButton();

            mainWindow.addedViews = enButton;
        } 
    }
}

    


         
     

//        dropdown menu
  //      menuBar
    //    checkbox : Clicked, width, height, x, y
      //  button : Action, Size, Color, Text
        //radio button
        //textfield : Size, Position, Content
        //textbox : Size, Position, Content
        //textlabel : Size, Position, Content
      //  asciiImage
    //    asciiDrawing
  //      listview
//        Menu : Size, Color, Type, Text, Clickable, Action, Position

