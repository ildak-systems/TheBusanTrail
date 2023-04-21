using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBusanTrail
{
    public class SettingsComponent : DrawableGameComponent
    {
        private MainGame game;
        private TitleComponent titleDisplay;
        private SpriteBatch spriteBatch;

        // Should only be called from TitleController
        internal SettingsComponent(MainGame game, TitleComponent titleDisplay) : base(game)
        {
            this.titleDisplay = titleDisplay;
            this.game = game;
        }
        public override void Initialize()
        {
            titleDisplay.Enabled = false;
            base.Initialize();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            game._spriteBatch.Begin();
            game._spriteBatch.DrawString(game.Arial, "This is settings Display",
                new Vector2(500, 500), Color.White);
            game._spriteBatch.End();
                       
            base.Draw(gameTime);
        }
    }
}
