using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppASCIIFramework.View
{
    abstract class TextField : View
    {
        protected string textContent;
        protected int width;
        protected int height;
        protected int posX;
        protected int posY;
    }

    class TextLabel : TextField
    {
        public TextLabel(string textContent, int width, int height, int posX, int posY)
        {
            base.textContent = textContent;
            base.width = width;
            base.height = height;
            base.posX = posX;
            base.posY = posY;
        }
    }

    class TextInputField : TextField
    {
        protected string placeHolderText;
        public TextInputField(string placeHolderText, int width, int height, int posX, int posY)
        {
            this.placeHolderText = placeHolderText;
            base.width = width;
            base.height = height;
            base.posX = posX;
            base.posY = posY;
        }
    }

}
