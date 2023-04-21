﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBusanTrail
{
    public class InGameController : DrawableGameComponent
    {
        private MainGame game;
        internal InGameController(MainGame game) : base(game)
        {
            this.game = game;
        }
        public override void Initialize()
        {
            base.Initialize();
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        public override void Draw(GameTime gameTime)
        {
            game._spriteBatch.Begin();
            game._spriteBatch.DrawString(game.Arial, "This is InGame Display", 
                new Vector2(500, 500), Color.White);
            game._spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}