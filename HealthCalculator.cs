using System;
using System.Collections.Generic;
using System.Text;
using TheBusanTrail.Characters;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace TheBusanTrail
{
    // update health of characters
    class HealthCalculator
    {
        public void UpdateHealth_Adult(Character character, GameTime gameTime)
        {
            double dt = gameTime.ElapsedGameTime.TotalSeconds;

            // health           
            character.TakeDamage((float)dt/3);
        }

        public void UpdateHealth_Child(Character character, GameTime gameTime)
        {
            double dt = gameTime.ElapsedGameTime.TotalSeconds;

            // health
            character.TakeDamage((float)dt);

        }
    }
}
