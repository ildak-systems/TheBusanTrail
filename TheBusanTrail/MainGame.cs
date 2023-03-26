global using Microsoft.Xna.Framework;
global using Microsoft.Xna.Framework.Graphics;
global using Microsoft.Xna.Framework.Input;
using System.ComponentModel;
using TheBusanTrail.Characters;
using TheBusanTrail.InGameComponents;
using TheBusanTrail.States;

namespace TheBusanTrail
{
    public class MainGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private PrimaryController primarycontroller;
        public SpriteBatch _spriteBatch;

        
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
            primarycontroller = new PrimaryController(this);
           
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime)
        {
            primarycontroller.setComponents();
               

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            base.Draw(gameTime);
        }
    }
}