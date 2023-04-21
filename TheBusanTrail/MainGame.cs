global using Microsoft.Xna.Framework;
global using Microsoft.Xna.Framework.Graphics;
global using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using System.Net;
using TheBusanTrail.Characters;
using TheBusanTrail.InGameComponents;
using TheBusanTrail.States;

/* MainGame is the entry way of TheBusanTrail game. It manages the primary game states:
 * Title, InGame, GameOver and GameComplete. MainGame will always run with TitleState
 * enabled with the added TitleController primary game component to start the game.
 * 
 * TitleController is responsible for switching the primary game state to InGameState when
 * initiated by the user. Then InGameState is responsisble for proceeding the primary
 * game state to either GameOver or GameComplete state. 
 * 
 * When a controller (Title, InGame) is added, it will work with its own state variables
 * to add/remove specific components. Name schemes are used to differentiate the usage of 
 * components. I am following this scheme for now:
 * 
 * - ...Controller: Class with an Update() that checks for changes in the state, then proceed
 *                  to add/remove GameComponents (Components). And that is usually it.
 * - ...Component:  GameComponent class with an Update() that needs values to be constantly
 *                  updated and have it reflected on the screen, usually with a Draw().
 *                  
 * ^^^ this needs to be updated, as Controllers (class) cannot be added to Components. 
 * Verify what I really want to accomplish
 * 
 * MainGame acts as a GameController
 */
namespace TheBusanTrail
{
    public class MainGame : Game
    {
        internal GraphicsDeviceManager _graphics;
        public SpriteBatch _spriteBatch;
        internal SpriteFont Arial;

        // Marked static as primaryState should stay consistent
        private static PrimaryState primaryState;
        private static bool onChange = false;
        
        // Marked internal as only other controllers will need to
        // call set. 
        internal static PrimaryState PrimaryStateAccessor
        {
            get { return primaryState; }
            set
            {
                if (primaryState != value)
                {
                    primaryState = value;
                    onChange = true;
                }
            }
        }

        public MainGame()
        {
            _graphics = new GraphicsDeviceManager(this);

            // Creating the game should always start with the
            // title screen
            primaryState = PrimaryState.TitleMode;
            // temp spriteFont Arial : import later
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            this._graphics.PreferredBackBufferWidth = 1280;
            this._graphics.PreferredBackBufferHeight = 720;
        }

        protected override void Initialize()
        {
            // Initialize the title screen
            TitleComponent displayTitleComponent = new TitleComponent(this);
            Components.Add(displayTitleComponent);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            // Add default fonts
            Arial = Content.Load<SpriteFont>("font");
        }

        // Cannot be static because it is working with Components,
        // which is specific to the game instance
        public void HandlePrimaryStateChange()
        {
            switch (primaryState)
            {
                case PrimaryState.TitleMode:
                    Components.Clear();
                    Components.Add(new TitleComponent(this));
                    break;

                case PrimaryState.InGameMode:
                    Components.Clear();
                    Components.Add(new InGameController(this));
                    break;

                case PrimaryState.GameSuccessMode:
                    break;

                case PrimaryState.GameFailMode:
                    break;
            }

            onChange = false;
        }

        protected override void Update(GameTime gameTime)
        {           
            // State Manager
            if (onChange)
            {
                HandlePrimaryStateChange();
            }
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);   
            base.Draw(gameTime);
            
        }
    }
}