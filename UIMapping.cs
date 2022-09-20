using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TheBusanTrail.Tracker;


namespace TheBusanTrail
{
    class UIMapping
    {
        static Dictionary<int, Texture2D> ContentManager = new Dictionary<int, Texture2D>(5);
        GamemodeTracker mode = new GamemodeTracker();
        FoodTracker food = new FoodTracker();
        bool test = false;

        // button coordinates
        private Vector2 v_meagerbutton = new Vector2(1000, 30);




        public UIMapping(Dictionary<int, Texture2D> assets)
        {
            ContentManager = assets;
        }

        public void Update(GameTime gameTime, MouseState mState)
        {           
            if (mode.getMode() == GameMode.traveling)
            {
                // meager button
                if ((mState.Position.X < 1064 && mState.Position.X > 1000) && 
                    (mState.Position.Y < 94 && mState.Position.Y > 30) && 
                    (mState.LeftButton == ButtonState.Pressed))
                {
                    food.setFoodMode(FoodMode.meager);
                }
                
                
            }

        }

        public void Draw(GameTime gameTime, SpriteFont font, SpriteBatch _spriteBatch)
        {
            if (mode.getMode() == GameMode.traveling)
            {
                // meager button
                _spriteBatch.Draw(ContentManager[1], v_meagerbutton, Color.White);

                if (test)
                {
                    _spriteBatch.DrawString(font, "Hello World,", new Vector2(500, 500), Color.White);
                }

            }
        }


    }
}

