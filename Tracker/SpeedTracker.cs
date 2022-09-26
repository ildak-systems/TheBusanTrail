using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;
using System.Collections.Generic;
using System.Text;

namespace TheBusanTrail.Tracker
{
    class SpeedTracker
    {
        // maps, use dictionary. key: name of landmark, value: miles away from point 0. Remove keys from array when arriving
        // Used for displaying the progress of the game. 
        
        static double milesTraveled;
        static SpeedMode Smode;
        static GamemodeTracker mode = new GamemodeTracker();
        static int milesUntilNextDestination;


        public SpeedTracker()
        {
            Smode = SpeedMode.grueling;
            milesTraveled = 0;
        }
        public void Update(GameTime gameTime)
        {
            double dt = gameTime.ElapsedGameTime.TotalSeconds;
            
            if (mode.getMode() == GameMode.traveling)
            {
                if (Smode == SpeedMode.slow)
                {
                    milesTraveled += dt / 6;
                }

                if (Smode == SpeedMode.steady)
                {
                    milesTraveled += dt / 4;
                }

                if (Smode == SpeedMode.grueling)
                {
                    milesTraveled += dt / 2;
                }
            }
            
        }
        public void setSpeed(SpeedMode mode)
        {
            Smode = mode;
        }
        public SpeedMode getSpeed()
        {
            return Smode;
        }

        public double getMiles()
        {
            return milesTraveled;
        }


    }
}
