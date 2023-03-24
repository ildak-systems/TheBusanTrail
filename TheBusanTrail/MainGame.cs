global using Microsoft.Xna.Framework;
global using Microsoft.Xna.Framework.Graphics;
global using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using TheBusanTrail.Characters;
using TheBusanTrail.States;

namespace TheBusanTrail
{
    public class MainGame : Game
    {
        private GraphicsDeviceManager _graphics;

        // must declare public for derived GameComponent classes
        public SpriteBatch _spriteBatch;

        // MainGame data members for GameComponent access 
        public Character f1;
        public Character c1;
        public Character c2;
        public CharacterParty party;

        public MainGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            this._graphics.PreferredBackBufferWidth = 1280;
            this._graphics.PreferredBackBufferHeight = 720;
        }

        protected override void Initialize()
        {
            // set resolution
            
            CharacterComponent charc = new CharacterComponent(this);
            Components.Add(charc);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            base.Draw(gameTime);
        }
    }
}