using System;
using TheBusanTrail.Characters;


namespace TheBusanTrail
{
    public class CharacterComponent : DrawableGameComponent
    {
        private MainGame game;
        Texture2D father;
        Texture2D child1;
        Texture2D child2;

        public CharacterComponent(MainGame game) : base(game)
        {
            this.game = game;
            game.f1 = new Father("Test", 43);
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            father = game.Content.Load<Texture2D>("father");
            game.f1.setSprite(father);
            base.LoadContent();
        }

        // GameComponent class forces public 
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            game._spriteBatch.Begin();
            game._spriteBatch.Draw(game.f1.getSprite(), new Vector2(1000, 100), Color.White);
            game._spriteBatch.End();
            base.Draw(gameTime);
        }


    }
}
