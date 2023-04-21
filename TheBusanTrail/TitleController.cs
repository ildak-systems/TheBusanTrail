using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TheBusanTrail.States;

namespace TheBusanTrail
{
    public class TitleComponent : DrawableGameComponent
    {
        private MainGame game;
        private TitleState titleState; // startGame, Settings, Selection (default)
        private bool onChange = false;

        String title = "The Busan Trail";
        Texture2D startGameButtonTexture;
        Texture2D settingButtonTexture;
        Button startGameButton;
        Button settingButton;

        public TitleState TitleStateAccess
        { 
            get { return titleState; } 
            set 
            { 
                if (titleState != value) 
                {
                    titleState = value;
                    onChange = true;
                }
            }
        }
            
        public TitleComponent(MainGame game) : base(game)
        {
            // When a title is displayed to the user, always 
            // start with a selection display
            titleState = TitleState.SelectionMode;
            this.game = game;
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            startGameButtonTexture = game.Content.Load<Texture2D>("sampleStartGame");
            settingButtonTexture = game.Content.Load<Texture2D>("sampleSettings");

            // Intialize Button objects.
            // startGameButton Action => change TitleState.StartGameMode
            // settingButton Action => change TitleState.SettingMode
            startGameButton = new Button(new Action(() =>
            { this.TitleStateAccess = TitleState.StartGameMode; }), startGameButtonTexture,
            new Point(50, 50));

            settingButton = new Button(new Action(() =>
            { this.TitleStateAccess = TitleState.SettingMode; }), settingButtonTexture,
            new Point(100, 100));
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {            
            // Call Button object's Update method : If the passed Mousestate is within the 
            // bounds of the Button object with buttonRelease, it calls the Button object's
            // onClick action.
            startGameButton.Update(Mouse.GetState());
            settingButton.Update(Mouse.GetState());
                        
            // Button's action onClick triggers the onChange : changes the state
            if (onChange)
            {
                HandleTitleStateChange();
            }

            base.Update(gameTime);
        }

        public void HandleTitleStateChange()
        {
            switch (titleState)
            {
                case TitleState.SelectionMode:
                    break;

                case TitleState.StartGameMode:
                    // Trigger setState to MainGame's primaryState to InGameMode
                    MainGame.PrimaryStateAccessor = PrimaryState.InGameMode;
                    break;

                    // Display of the settingsComponent should be controlled within titlecontroller
                case TitleState.SettingMode:
                    game.Components.Add(new SettingsComponent(game, this));
                    break;
            }

            onChange = false;
        }

        public override void Draw(GameTime gameTime)
        {       
            game._spriteBatch.Begin();
            // Draw Title : Come up with a better method
            game._spriteBatch.DrawString(game.Arial, title, new Vector2(200, 200), Color.White);

            // Draw Screen
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Draw the buttons
            startGameButton.Draw(game._spriteBatch, Mouse.GetState());
            settingButton.Draw(game._spriteBatch, Mouse.GetState());
            game._spriteBatch.End();
                  
            base.Draw(gameTime);
        }


    }
}
