using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBusanTrail.Characters;

namespace TheBusanTrail.InGameComponents
{
    public class DisplayComponent : DrawableGameComponent
    {
        private GameComponent component;
        private MainGame game;

        public DisplayComponent(MainGame game, GameComponent com) : base(game)
        {
            component = com;
            this.game = game;
        }

        public override void Update(GameTime gameTime)
        {
            component.Enabled = true;
            base.Update(gameTime);
        }


    }
}
