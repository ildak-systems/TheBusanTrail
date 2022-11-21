using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using System;
using System.Collections.Generic;
using System.Text;

namespace TheBusanTrail.Tracker
{
    class LocationTracker
    {
        static Dictionary<double, string> Locations = new Dictionary<double, string>()
        {
            {0, "hometown" },
            {10, "someLocation"},
            {20, "SomOtherLocation" }
        };
        private double[] miles = {0, 10, 20};
        static string CurrentLocation = "";
        static string NextLocation = "";
        static SpeedTracker speedtracker = new SpeedTracker();

        public LocationTracker() { }
        public void Update(GameTime gameTime)
        {
            // Update() method should be made to loop 30 times per second
            // Loop through every elements in the dictionary
            for (int i = 0; i < Locations.Count; i++)
            {
                if (Math.Ceiling(speedtracker.getMiles()) == miles[i])
                {
                    CurrentLocation = Locations[miles[i]];
                }
            }
        }

        public string getCurrentLocation()
        {
            return CurrentLocation;
        }

        // Implementation Idea: Make name of the locations into a global enums. Each value in an enums are associated
        // with a number. (1, 2, 3, 4)


    }
}
