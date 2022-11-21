using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;
using System.Collections.Generic;
using System.Text;
using TheBusanTrail.Tracker;

namespace TheBusanTrail.Buttons
{
    class SteadyButton
    {
        Texture2D Image;
        Vector2 Position;
        int Width;
        int Height;
        SpeedTracker speed = new SpeedTracker();
        public SteadyButton(Texture2D image)
        {
            Image = image;
            Position = new Vector2(1070, 125);
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
            speed.setSpeed(SpeedMode.steady);
        }
    }
}
