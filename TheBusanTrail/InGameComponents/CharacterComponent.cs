using Microsoft.Xna.Framework.Content;
using TheBusanTrail.Characters;
using System;
using System.ComponentModel;

namespace TheBusanTrail.InGameComponents
{
    public class CharacterComponent : DrawableGameComponent
    {
        private MainGame game;
        public static Character f1;
        public static Character c1;
        public static Character c2;
        public static CharacterParty party;

        Texture2D father;
        Texture2D child1;
        Texture2D child2;

        public CharacterComponent(MainGame game) : base(game)
        {
            this.game = game;
            f1 = new Father("Test", 43);
        }

        public override void Initialize()
        {
            DisplayComponent displayUI = new DisplayComponent(game, this);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // access MainGame's ContentMananger
            father = game.Content.Load<Texture2D>("father");
            f1.setSprite(father);
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
            game._spriteBatch.Draw(f1.getSprite(), new Vector2(1000, 100), Color.White);
            game._spriteBatch.End();
            base.Draw(gameTime);
        }


    }
}
