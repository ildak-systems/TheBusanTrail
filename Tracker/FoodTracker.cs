using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TheBusanTrail.Characters;
using TheBusanTrail.Tracker;

namespace TheBusanTrail
{
    class FoodTracker
    {
        static double Food;
        static FoodMode FMode;
        GamemodeTracker mode = new GamemodeTracker();
        // Use for controlling the amount of food that is decreasing per day. Affects health.

        public FoodTracker()
        {
            Food = 100;
            FMode = FoodMode.filling;
        }

        public void Update(GameTime gameTime)
        {
            double dt = gameTime.ElapsedGameTime.TotalSeconds; //dt keeps track of gametime in seconds.

            if (mode.getMode() == GameMode.traveling)
            {
                if (FMode == FoodMode.barebones)
                {
                    Food -= dt / 5;
                }

                else if (FMode == FoodMode.meager)
                {
                    Food -= dt / 2;
                }

                else if (FMode == FoodMode.filling)
                {
                    Food -= dt;
                }
            }
            
           
        }

        public void setFoodMode(FoodMode mode)
        {
            FMode = mode;
        }
        
        public void updateFoodAmount(int num)
        {
            Food += num;
        }

        public double getFoodAmount()
        {
            return Food;
        }
    }
}
