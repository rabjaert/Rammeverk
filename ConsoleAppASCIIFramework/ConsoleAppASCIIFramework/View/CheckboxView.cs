using ConsoleAppASCIIFramework.View;

namespace ConsoleAppASCIIFramework.View
{
   abstract class CheckboxView : View
    {
        protected bool Clicked;
        protected int Width;
        protected int Height;
        protected int PosX;
        protected int PosY;

    }

    class ClickableCheckBox : CheckboxView
    {
        public ClickableCheckBox(int width, int height, int posX, int posY)
        {
            this.Width = width;
            this.Height = height;
            this.PosX = posX;
            this.PosY = posY;
        }
    }
}

    
    class RadioButton : CheckboxView
    {
        public RadioButton(int width, int height, int posX, int posY)
    {
        this.Width = width;
        this.Height = height;
        this.PosX = posX;
        this.PosY = posY;
    }
}

