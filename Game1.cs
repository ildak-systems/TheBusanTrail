using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;
using TheBusanTrail.Characters;
using TheBusanTrail.Tracker;

// To draw a the UI: Make a method that draws both UI and the value. e.g: Food: 32lbs. 
// For each value. So make draw method for both food and money, even though they are going to be a very similar code.
// DrawFood(vector2 position, int direction(where to place the actual value, mostly left or bottom), int fontsize)

// 

// DrawParty() or DrawCharacter() (takes in obj individually), that takes in a array of characters (current characters that the user chose) and draws each of them by
// retrieving information. 

// DrawGameBox(), this method takes in the position of where the gamebox will go to and includes all the methods that 
// draws the party, the variables that goes in the box. 

// 9/25
// Know more info about: 1. Info dates 2. Settings, for maps. 
// Calculating character stats: 1. Stuff that effects directly to a specific character should work with individual HealthCalc
// class. 2. Stuff that effects the entire party such as: weather conditions, food conditions: should use the partyHealthcalc


namespace TheBusanTrail
{
    // Global modes: These are accessible in every class
    // FoodMode: Controlled in FoodTracker class.
    enum FoodMode //  User Input
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
    enum SpeedMode // User Input
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

    enum Seasons
    {
        spring,
        summer,
        fall,
        winter
    }

    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        
        MouseState mState;

        static Dictionary<int, Texture2D> AssetManager = new Dictionary<int, Texture2D>();

        // food buttons
        Texture2D bonesButton;
        Texture2D meagerButton;
        Texture2D fillingButton;

        // speed buttons
        Texture2D slowButton;
        Texture2D steadyButton;
        Texture2D gruelingButton;

        // fonts
        SpriteFont Arial_20;

        // Used for dates, should work with weather. Determines the rate of health/moral of characters and random events.
        double Year = 0;
        int Month = 0;
        int Day = 0;
        
        FoodTracker foodtracker = new FoodTracker();
        SpeedTracker speedtracker = new SpeedTracker();
        MoneyTracker moneytracker = new MoneyTracker();
        CharacterParty party1 = new CharacterParty();
        LocationTracker locationtracker = new LocationTracker();
        DateTracker datetracker = new DateTracker();
        UIMapping mapping;

        // Characters
        Character father1 = new Father("Harry");
        Character child1 = new Child("Cole");
        Character child2 = new Child("Fred");
        
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            party1.Add(father1);
            party1.Add(child1);
            party1.Add(child2);
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

            // food buttons
            bonesButton = Content.Load<Texture2D>("bonesButton");
            meagerButton = Content.Load<Texture2D>("meagerButton");
            fillingButton = Content.Load<Texture2D>("fillingButton");

            // speed buttons
            slowButton = Content.Load<Texture2D>("slowButton");
            steadyButton = Content.Load<Texture2D>("steadyButton");
            gruelingButton = Content.Load<Texture2D>("gruelingButton");

            AssetManager.Add(1, meagerButton);
            AssetManager.Add(2, fillingButton);
            AssetManager.Add(3, bonesButton);
            AssetManager.Add(4, slowButton);
            AssetManager.Add(5, steadyButton);
            AssetManager.Add(6, gruelingButton);
            mapping = new UIMapping(AssetManager);
        }

        protected override void Update(GameTime gameTime)
        {    
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Exit();
            }
            mState = Mouse.GetState();
            mapping.Update(gameTime, mState);
            speedtracker.Update(gameTime);
            foodtracker.Update(gameTime);
            locationtracker.Update(gameTime);
            party1.Update(gameTime);
            datetracker.Update(gameTime);
            

            base.Update(gameTime);
        }
       

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();

            DrawGameBox();
            DrawMiles();
            DrawDate();
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
            string st_money = moneytracker.getMoney().ToString();
            _spriteBatch.DrawString(font, "Money: W " + st_money, position, Color.White);
        }

        protected void DrawLocation(Vector2 position, SpriteFont font, int direction)
        {
            string st_location = locationtracker.getCurrentLocation();
            _spriteBatch.DrawString(font, "Location: " + st_location, position, Color.White);
        }

        protected void DrawMiles()
        {
            string st_miles = Math.Ceiling(speedtracker.getMiles()).ToString();
            _spriteBatch.DrawString(Arial_20, "Miles Traveled: " + st_miles + " Miles ", new Vector2(500, 500), Color.White);
        }

        protected void DrawDate()
        {
            string st_month = datetracker.getDate().Month.ToString();
            _spriteBatch.DrawString(Arial_20, st_month, new Vector2(500, 600), Color.White);

            // draw /
            _spriteBatch.DrawString(Arial_20, "/", new Vector2(520, 600), Color.White);

            string st_day = datetracker.getDate().Day.ToString();
            _spriteBatch.DrawString(Arial_20, st_day, new Vector2(530, 600), Color.White);

            // draw /
            _spriteBatch.DrawString(Arial_20, "/", new Vector2(560, 600), Color.White);

            string st_year = datetracker.getDate().Year.ToString();
            _spriteBatch.DrawString(Arial_20, st_year, new Vector2(570, 600), Color.White);

        }

        protected void DrawGameBox()
        {
            DrawFood(new Vector2(20, 20), Arial_20, 3);
            DrawMoney(new Vector2(250, 20), Arial_20, 3);
            DrawLocation(new Vector2(500, 20), Arial_20, 3);
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
                // Print Name
                _spriteBatch.DrawString(font, temp.getName().ToString(), position, Color.White); // Draw name
                position.Y += 30;
                // Print Health
                _spriteBatch.DrawString(font, Math.Ceiling(temp.GetCurrentHealth()).ToString(), position, Color.White); // Draw Health
                position.Y += 30;
                // Print Moral
                _spriteBatch.DrawString(font, temp.GetCurrentMoral().ToString(), position, Color.White); // Draw Moral
                position.Y = initial_Y;
                                                                                                         
            }
        }

        
        
    }
}
