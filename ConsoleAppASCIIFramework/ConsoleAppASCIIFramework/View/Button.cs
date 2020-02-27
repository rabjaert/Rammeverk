
namespace ConsoleAppASCIIFramework.View
{
    abstract class Button : View
    {
        protected string placeholder;
        protected int height;
        protected int width;
        protected int posX;
        protected int posY;

        public virtual void OnActionButton()
        {
             
        }

    }
    class ButtonClicked : Button
    {

        private bool isClicked;

       public ButtonClicked(string placeholder, int height, int width, int posX, int posY)
        {
            this.placeholder = placeholder;
            this.height = height;
            this.width = width;
            this.posX = posX;
            this.posY = posY;
            OnActionButton();

        }

        //Then we have the possibility to either use our base method, or override it if we want to do something a little bit more different
        public override void OnActionButton()
        {
           
            base.OnActionButton();
            
        }
        

    }
}



