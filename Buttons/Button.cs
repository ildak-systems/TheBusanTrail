using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;
using System.Collections.Generic;
using System.Text;

namespace TheBusanTrail.Buttons
{
    abstract class Button
    {
        Texture2D Image;
        Vector2 Position;
        int Width;
        int Height;

        public virtual void clickButton() { }
    }
}
