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
        GamemodeTracker mode = new GamemodeTracker();
        FoodTracker food = new FoodTracker();

        //food buttons
        BonesButton bonesButton;
        MeagerButton meagerButton;
        FillingButton fillingButton;

        //speed buttons
        SlowButton slowButton;
        SteadyButton steadyButton;
        GruelingButton gruelingButton;



        public UIMapping(Dictionary<int, Texture2D> assets)
        {
            // ContentManager<int, Sprite2D> gets copied from assets, which is another
            // Dictionary<int, Sprite2D> that is fully initialized with all the buttons
            
            bonesButton = new BonesButton(assets[2]);
            meagerButton = new MeagerButton(assets[0]);
            fillingButton = new FillingButton(assets[1]);
            slowButton = new SlowButton(assets[3]);
            steadyButton = new SteadyButton(assets[4]);
            gruelingButton = new GruelingButton(assets[5]);

        }

        public void Update(GameTime gameTime, MouseState mState)
        {
            // State system: If current global game mode is "traveling", we map the x and y coordinates
            // When the user clicks on any given x and y fields, it triggers the button's clickButton()
            // method. 
            if (mode.getMode() == GameMode.traveling)
            {
                // meager button

                if ((mState.Position.X < (meagerButton.getPosition().X + meagerButton.getWidth()) // 1000 + 64
                    && mState.Position.X > meagerButton.getPosition().X) &&
                    (mState.Position.Y < (meagerButton.getPosition().Y + meagerButton.getHeight()) &&
                    mState.Position.Y > meagerButton.getPosition().Y) &&
                    (mState.LeftButton == ButtonState.Pressed))
                {
                    meagerButton.clickButton();
                }
                // filling button
                if ((mState.Position.X < (fillingButton.getPosition().X + fillingButton.getWidth())
                    && mState.Position.X > fillingButton.getPosition().X) &&
                    (mState.Position.Y < (fillingButton.getPosition().Y + fillingButton.getHeight()) &&
                    mState.Position.Y > fillingButton.getPosition().Y) &&
                    (mState.LeftButton == ButtonState.Pressed))
                {
                    fillingButton.clickButton();
                }
                // barebones button
                if ((mState.Position.X < (bonesButton.getPosition().X + bonesButton.getWidth())
                    && mState.Position.X > bonesButton.getPosition().X) &&
                    (mState.Position.Y < (bonesButton.getPosition().Y + bonesButton.getHeight()) &&
                    mState.Position.Y > bonesButton.getPosition().Y) &&
                    (mState.LeftButton == ButtonState.Pressed))
                {
                    bonesButton.clickButton();
                }

                // slow button
                if ((mState.Position.X < (slowButton.getPosition().X + slowButton.getWidth())
                    && mState.Position.X > slowButton.getPosition().X) &&
                    (mState.Position.Y < (slowButton.getPosition().Y + slowButton.getHeight()) &&
                    mState.Position.Y > slowButton.getPosition().Y) &&
                    (mState.LeftButton == ButtonState.Pressed))
                {
                    slowButton.clickButton();
                }

                // steady button
                if ((mState.Position.X < (steadyButton.getPosition().X + steadyButton.getWidth())
                    && mState.Position.X > steadyButton.getPosition().X) &&
                    (mState.Position.Y < (steadyButton.getPosition().Y + steadyButton.getHeight()) &&
                    mState.Position.Y > steadyButton.getPosition().Y) &&
                    (mState.LeftButton == ButtonState.Pressed))
                {
                    steadyButton.clickButton();
                }

                // grueling button
                if ((mState.Position.X < (gruelingButton.getPosition().X + gruelingButton.getWidth())
                    && mState.Position.X > gruelingButton.getPosition().X) &&
                    (mState.Position.Y < (gruelingButton.getPosition().Y + gruelingButton.getHeight()) &&
                    mState.Position.Y > gruelingButton.getPosition().Y) &&
                    (mState.LeftButton == ButtonState.Pressed))
                {
                    gruelingButton.clickButton();
                }
            }
        }

        public void Draw(GameTime gameTime, SpriteFont font, SpriteBatch _spriteBatch)
        {
            // Draw() works just like Update(), and is calling _spriteBatch.Draw() each game time.
            if (mode.getMode() == GameMode.traveling)
            {
                 // bare-bones button
                 _spriteBatch.Draw(bonesButton.getImage(), bonesButton.getPosition(), Color.White);
                 //meager button
                 _spriteBatch.Draw(meagerButton.getImage(), meagerButton.getPosition(), Color.White);
                 // filling button
                 _spriteBatch.Draw(fillingButton.getImage(), fillingButton.getPosition(), Color.White);

                //slow button
                _spriteBatch.Draw(slowButton.getImage(), slowButton.getPosition(), Color.White);
                //steady button
                _spriteBatch.Draw(steadyButton.getImage(), steadyButton.getPosition(), Color.White);
                //gruwling button
                _spriteBatch.Draw(gruelingButton.getImage(), gruelingButton.getPosition(), Color.White);
            }
        }


        
    }
}

