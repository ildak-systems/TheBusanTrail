using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoGame.Extended.Input;

namespace TheBusanTrail
{
    public class Button
    {
        Action onClick;
        // we can get the mouse click bounds from image
        Texture2D image;
        // declare position of the button
        Point position;
        Rectangle bounds;
        
        public Button(Action action, Texture2D image, Point position)
        {
            this.onClick = action;
            this.image = image;
            this.position = position;

            // calculate bounds
            bounds = new Rectangle(position.X, position.Y, image.Width, image.Height);
        }

        public void Update(MouseState mousestate)
        {

            if (bounds.Contains(mousestate.Position))
            {
                // onclick invokes when left button is PRESSED, not PRESSED THEN RELEASED
                // I cant seem to figure this out. Put it on backlog and work on it later

                if (MouseExtended.GetState().WasButtonJustDown(MouseButton.Left))
                {
                    onClick.Invoke();
                }
            }
                           
        }

        public void Draw(SpriteBatch spritebatch, MouseState mousestate)
        {
            spritebatch.Draw(image, bounds, Color.White);
            if (bounds.Contains(mousestate.Position))
            {
                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    spritebatch.Draw(image, bounds, Color.Gray);
                }
            }
        }

    }
}
