using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBusanTrail.States;

namespace TheBusanTrail
{
    public class TitleComponent : DrawableGameComponent
    {
        private MainGame game;
        private PrimaryController primaryController;
        private static TitleState titleState;


        public TitleComponent(MainGame game, PrimaryController controller) : base(game)
        {
            // When a title is displayed to the user, always 
            // start with a selection display
            titleState = TitleState.SelectionMode;
            this.game = game;
            this.primaryController = controller;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            if (titleState == TitleState.SelectionMode)
            {
                // display default title menu
            }
            else if (titleState == TitleState.StartGameMode)
            {
                primaryController.setState(PrimaryState.InGameMode);
            }
            else if (titleState == TitleState.SettingMode)
            {
                // Add Settings Component
            }
            else
            {
                // display selection mode
            }


            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {


            base.Draw(gameTime);
        }


    }
}
