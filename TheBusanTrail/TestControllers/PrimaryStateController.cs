using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBusanTrail.States;

// 
namespace TheBusanTrail.TestControllers
{
    public class PrimaryStateController : GameComponent
    {
        private MainGame game;
        private static PrimaryState primaryState;
        PrimaryStateController(MainGame game) : base(game)
        {
            this.game = game;
        }

        public override void Initialize()
        {
            // initialize titleComponent, InGameController, 
            // GameFailComponent and GameSuccessComponent
            
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            // if (primaryState changed)
            // then call method that adds the right component
            
        }
    }
}

