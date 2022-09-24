using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TheBusanTrail.Tracker;
using TheBusanTrail.Buttons;


namespace TheBusanTrail
{
    class UIMapping
    {
        static Dictionary<int, Texture2D> ContentManager = new Dictionary<int, Texture2D>(5);
        GamemodeTracker mode = new GamemodeTracker();
        FoodTracker food = new FoodTracker();

        // button coordinates
        MeagerButton meagerButton;



        public UIMapping(Dictionary<int, Texture2D> assets)
        {
            ContentManager = assets;
            meagerButton = new MeagerButton(assets[1]);
        }

        public void Update(GameTime gameTime, MouseState mState)
        {
            
            if (mode.getMode() == GameMode.traveling)
            {
                // meager button
               
                if ((mState.Position.X < (meagerButton.getPosition().X + meagerButton.getWidth()) // 1000 + 64
                    && mState.Position.X > meagerButton.getPosition().X) && 
                    (mState.Position.Y < (meagerButton.getPosition().Y + meagerButton.getHeight()) && 
                    mState.Position.Y > meagerButton.getPosition().Y) && 
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
                _spriteBatch.Draw(meagerButton.getImage(), meagerButton.getPosition(), Color.White);
            }
        }


    }
}

