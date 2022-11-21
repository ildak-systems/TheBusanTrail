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
            ContentManager = assets;
            bonesButton = new BonesButton(assets[3]);
            meagerButton = new MeagerButton(assets[1]);
            fillingButton = new FillingButton(assets[2]);
            slowButton = new SlowButton(assets[4]);
            steadyButton = new SteadyButton(assets[5]);
            gruelingButton = new GruelingButton(assets[6]);

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

