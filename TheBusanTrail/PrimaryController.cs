using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBusanTrail.States;

namespace TheBusanTrail
{
    public class PrimaryController
    {
        private MainGame game;
        private PrimaryState primaryState;
        private PrimaryState prevPrimaryState;
        public PrimaryController(MainGame game) 
        {
            this.game = game;
            this.prevPrimaryState = PrimaryState.None;
            this.primaryState = PrimaryState.TitleMode;
        }

        // Update()
        public void setComponents()
        {
            if (primaryState != prevPrimaryState) 
            {
                switch (primaryState) 
                {
                    case PrimaryState.TitleMode:

                        game.Components.Add(new TitleComponent(game, this));
                        break;

                    case PrimaryState.InGameMode:

                        break;
                }
            }  
        }
        
        public void setState(PrimaryState state)
        {
            this.primaryState = state;
        }

        
    }
}
