using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBusanTrail.States
{
    public struct Button
    {
        Action onClick = default;
        Texture2D image = default;
        Vector2 position = default;
        public Button(Action action)
        {
            onClick = action;
        }

        public void Press()
        {
            onClick.Invoke();
        }

    }
    public enum PrimaryState
    {
        None,
        TitleMode,
        InGameMode,
        GameFailMode,
        GameSuccessMode
    }

    public enum TitleState
    {
        SelectionMode,
        StartGameMode,
        SettingMode
    }


}
