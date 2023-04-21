using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBusanTrail.States
{
    public enum PrimaryState
    {
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
