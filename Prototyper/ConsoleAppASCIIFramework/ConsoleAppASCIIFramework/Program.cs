using ConsoleAppASCIIFramework.View;
using System;


namespace ConsoleAppASCIIFramework
{
    class Program
    {
        //All the view classes derived from the View-class, and every class has a abstract method for general variables etc
        //so it's easy to add more functionality to the framework



        static void Main(string[] args)
        {

            //3 SCENARIOS FOR THIS FRAMEWORK

            // 1. Login in terminal [

            /* With textfield and labels you can create a loginsystem in the CMD
             */


            var start = new Application();
            start.Initialize();

            var mainWindow = new Window(100, 100, "black", start);


            ButtonClicked enButton = new ButtonClicked("hei", 1, 1, 1, 1);
            enButton.OnActionButton();

            mainWindow.AddedViews.Add(enButton);

            new TextLabel("ku", 10, 20, 0, 0);
            new TextInputField("Enter Name", 10, 20, 30, 40);
            //    ]

            // 2. Create a calulator in the CMD [

            /*
             * Since you already can implement textlabels and textfield, the user can override the OnActions methods
             * so make a calculator 
             * 
             */

            var start2 = new Application();
            start.Initialize();

            var mainWindow2 = new Window(100, 100, "black", start);


            ButtonClicked addButton = new ButtonClicked("Add", 1, 1, 1, 1);
            enButton.OnActionButton();

            ButtonClicked substractButton = new ButtonClicked("Substract", 1, 1, 1, 1);
            enButton.OnActionButton();

            ButtonClicked divideButton = new ButtonClicked("Divide", 1, 1, 1, 1);
            enButton.OnActionButton();

            ButtonClicked multiplyButton = new ButtonClicked("Mulitply", 1, 1, 1, 1);
            enButton.OnActionButton();

            var firstTextBlock = new TextLabel("3", 10, 20, 0, 0);
            var firstTextField = new TextInputField("Enter the first number", 0, 20, 30, 40);

            var secondTextBlock = new TextLabel("5", 10, 20, 0, 0);
            var secondTextField = new TextInputField("Enter the second number", 10, 20, 30, 40);

            mainWindow.AddedViews.Add(addButton);
            mainWindow.AddedViews.Add(substractButton);
            mainWindow.AddedViews.Add(divideButton);
            mainWindow.AddedViews.Add(multiplyButton);
            mainWindow.AddedViews.Add(firstTextBlock);
            mainWindow.AddedViews.Add(firstTextField);
            mainWindow.AddedViews.Add(secondTextBlock);
            mainWindow.AddedViews.Add(secondTextField);


            //    ]
            // 3. Excel sheet [
            var star1t = new Application();
            star1t.Initialize();


            var tertiaryWindow = new Window(200, 100, "black", start);
            int w = 0, h = 0, x = 0, y = 0;
            for (int i = 0; i < 10; i++) {
                tertiaryWindow.AddedViews.Add(new TextInputField("", 5, 10, 0, 0));
                w += 10;
                h += 5;
                x += 10;
                if (i == 5)
                {
                    y += 5;
                }

            }
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

