
namespace ConsoleAppASCIIFramework.View
{
    abstract class ButtonView : View
    {
        protected string Placeholder;
        protected int Width;
        protected int Height;
        protected int PosX;
        protected int PosY;

        //This method should be in an event class since people probably make several buttons, but we will store this function in Button for now.
        public virtual void OnActionButton()
        {
             
        }
       
    }
    class ButtonClicked : ButtonView
    {

        private bool isClicked;

       public ButtonClicked(string placeholder, int width, int height, int posX, int posY)
        {
            this.Placeholder = placeholder;
            this.Width = width;
            this.Height = height;
            this.PosX = posX;
            this.PosY = posY;
            OnActionButton();

        }

        //Then we have the possibility to either use our base method, or override it if we want to do something a little bit more different
        public override void OnActionButton()
        {
           
            base.OnActionButton();
            
        }
        

    }
}



