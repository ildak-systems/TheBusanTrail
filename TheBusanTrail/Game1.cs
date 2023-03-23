using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TheBusanTrail.Characters; // import Characters

namespace TheBusanTrail
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        CharacterParty Party;
        Character f1;
        Character c1;
        Character c2;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            // initialize characters
            f1 = new Father("Darrel", 40);
            c1 = new Child("Max", 7);
            c2 = new Child("Mary", 13);
            Party = new CharacterParty();

            // put characters into party
            Party.add(f1); Party.add(c1); Party.add(c2);

        }

        protected override void Initialize()
        {
            // set resolution

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // initialize Texture2D, load/set sprite
            Texture2D father;
            father = Content.Load<Texture2D>("father");
            f1.setSprite(father);


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(f1.getSprite(), new Vector2(100,100), Color.White);
            _spriteBatch.End();
            // TODO: Add your drawing code here
            base.Draw(gameTime);
        }
    }
}