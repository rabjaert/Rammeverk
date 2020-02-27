using ConsoleAppASCIIFramework.View;

namespace ConsoleAppASCIIFramework.View
{
   abstract class CheckBox : View
    {
        protected bool Clicked;
        protected int width;
        protected int height;
        protected int posX;
        protected int posY;

    }

    class ClickableCheckBox : CheckBox
    {
        public ClickableCheckBox(int width, int height, int posX, int posY)
        {
            this.width = width;
            this.height = height;
            this.posX = posX;
            this.posY = posY;
        }
    }
}

    class RadioButton : CheckBox
    {
        public RadioButton(int height, int width, int posX, int posY)
        {
        this.height = height;
        this.width = width;
        this.posX = posX;
        this.posY = posY;
        }
}

