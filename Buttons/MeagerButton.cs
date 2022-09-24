using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;
using System.Collections.Generic;
using System.Text;

namespace TheBusanTrail.Buttons
{
    class MeagerButton
    {
        Texture2D Image;
        Vector2 Position;
        int Width;
        int Height;
        FoodTracker food = new FoodTracker();

        public MeagerButton(Texture2D image)
        {
            Image = image;
            Position = new Vector2(1000, 60);
            Width = image.Width;
            Height = image.Height;
        }

        public Texture2D getImage()
        {
            return Image;
        }

        public Vector2 getPosition()
        {
            return Position; 
        }

        public int getWidth()
        {
            return Width;
        }

        public int getHeight()
        {
            return Height;
        }

        public void clickButton()
        {
            food.setFoodMode(FoodMode.meager);
        }
            

    }
}
