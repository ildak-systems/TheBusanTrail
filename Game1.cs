using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;
using TheBusanTrail.Characters;

// To draw a the UI: Make a method that draws both UI and the value. e.g: Food: 32lbs. 
// For each value. So make draw method for both food and money, even though they are going to be a very similar code.
// DrawFood(vector2 position, int direction(where to place the actual value, mostly left or bottom), int fontsize)

// 

// DrawParty() or DrawCharacter() (takes in obj individually), that takes in a array of characters (current characters that the user chose) and draws each of them by
// retrieving information. 

// DrawGameBox(), this method takes in the position of where the gamebox will go to and includes all the methods that 
// draws the party, the variables that goes in the box. 


namespace TheBusanTrail
{
    // Global modes: These are accessible in every class

    // FoodMode: Controlled in FoodTracker class
    enum FoodMode
    {
        barebones,
        meager,
        filling
    }

    // GameMode: Controlled in GamemodeTracker class
    enum GameMode
    {
        traveling,
        encounter,
    }

    // Use for controlling the amount of moral is decreasing per day. Affects moral and health?
    enum SpeedMode
    {
        slow,
        steady,
        grueling
    }

    // Should work with the year, month, and day variables to choose one of the four weather systems.
    enum WeatherMode
    {
        hot,
        veryhot,
        cold,
        verycold,
    }

    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        
        MouseState mState;

        static Dictionary<int, Texture2D> AssetManager = new Dictionary<int, Texture2D>(5);

        // Assets for AssetManager
        Texture2D meagerButton;
        SpriteFont Arial_20;

        // Used for dates, should work with weather. Determines the rate of health/moral of characters and random events.
        double Year = 0;
        int Month = 0;
        int Day = 0;

        // Used for displaying the progress of the game. 
        int milesTraveled = 0;
        int milesUntilNextDestination = 0;
        
        FoodTracker foodtracker = new FoodTracker();
        CharacterParty party1 = new CharacterParty();
        UIMapping mapping = new UIMapping(AssetManager);


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // Load font.spritefont
            Arial_20 = Content.Load<SpriteFont>("font");
            meagerButton = Content.Load<Texture2D>("meagerButton");

            int num = 1;
            AssetManager.Add(num, meagerButton);
           


        }

        protected override void Update(GameTime gameTime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            mState = Mouse.GetState();
            mapping.Update(gameTime, mState);
            
            foodtracker.Update(gameTime);

            base.Update(gameTime);
        }
       

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();

            DrawGameBox();
            
            mapping.Draw(gameTime, Arial_20, _spriteBatch);

            _spriteBatch.End();

            base.Draw(gameTime);
        }

        protected void DrawFood(Vector2 position, SpriteFont font, int direction)
        {
            string st_food = Math.Ceiling(foodtracker.getFoodAmount()).ToString();
            _spriteBatch.DrawString(font, "Food: " + st_food + " lbs", position, Color.White);
        }

        protected void DrawMoney(Vector2 position, SpriteFont font, int direction)
        {
            //string st_money = tracker.getMoneyAmount().ToString();
            //_spriteBatch.DrawString(font, "Money: W " + st_money, position, Color.White);
        }

        protected void DrawMiles()
        {

        }

        protected void DrawGameBox()
        {
            DrawFood(new Vector2(20, 20), Arial_20, 3);
            DrawMoney(new Vector2(250, 20), Arial_20, 3);
            DrawParty(party1, Arial_20);
        }

        protected void DrawParty(CharacterParty party, SpriteFont font)
        {
            int initial_Y = 500;
            Vector2 position = new Vector2(0, initial_Y);
            
            for (int i = 0; i < party.PartySize(); i++)
            {
                position.X += 100;
                Character temp = party.getParty()[i];
                _spriteBatch.DrawString(font, temp.getName().ToString(), position, Color.White); // Draw name
                position.Y += 30;
                _spriteBatch.DrawString(font, temp.GetCurrentHealth().ToString(), position, Color.White); // Draw Health
                position.Y += 30;
                _spriteBatch.DrawString(font, temp.GetCurrentMoral().ToString(), position, Color.White); // Draw Moral
                position.Y = initial_Y;
                                                                                                         
            }
        }

        
        
    }
}
