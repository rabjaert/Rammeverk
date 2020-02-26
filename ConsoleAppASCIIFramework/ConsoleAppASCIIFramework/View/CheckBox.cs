using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppASCIIFramework.View
{
   abstract class CheckBox : View
    {
        protected bool Clicked;
        protected int height;
        protected int width;
        protected int posX;
        protected int posY;

    }

    class ClickableCheckBox : CheckBox
    {
        public ClickableCheckBox(int height, int width, int posX, int posY)
        {
            this.height = height;
            this.width = width;
            this.posX = posX;
            this.posY = posY;
         
           
        }






    }




}
