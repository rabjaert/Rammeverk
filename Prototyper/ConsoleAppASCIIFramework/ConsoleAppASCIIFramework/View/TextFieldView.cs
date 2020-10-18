using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppASCIIFramework.View
{
    abstract class TextFieldView : View
    {
        protected string TextContent;
        protected int Width;
        protected int Height;
        protected int PosX;
        protected int PosY;
    }

    class TextLabel : TextFieldView
    {
        public TextLabel(string textContent, int width, int height, int posX, int posY)
        {
            base.TextContent = textContent;
            base.Width = width;
            base.Height = height;
            base.PosX = posX;
            base.PosY = posY;
        }
    }

    class TextInputField : TextFieldView
    {
        protected string PlaceHolderText;
        public TextInputField(string placeHolderText, int width, int height, int posX, int posY)
        {
            this.PlaceHolderText = placeHolderText;
            base.Width = width;
            base.Height = height;
            base.PosX = posX;
            base.PosY = posY;
        }
    }

}
