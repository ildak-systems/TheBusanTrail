using System;
using System.Collections.Generic;
using System.Text;

namespace TheBusanTrail.Tracker
{ 
    class GamemodeTracker
    {
        static GameMode mode = GameMode.traveling; // default

        public void setMode(GameMode changeMode)
        {
            mode = changeMode;
        }

        public GameMode getMode()
        {
            return mode;
        }

    }
}

