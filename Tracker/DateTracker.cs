using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TheBusanTrail.Tracker
{
    class DateTracker // Controls weather and seasons
    {
        // weathertracker dependent on datetracker
        // date will increase during traveling game mode.
        
        static Seasons currentSeason;
        DateTime dateTime;
        int year;
        int month;
        int day;

        public DateTracker()
        {
            // Starting Dates
            year = 1950;
            month = 06;
            day = 25;
            currentSeason = Seasons.summer;
            dateTime = new DateTime(year, month, day);
        }

        // update date, stop during pausing game mode, 
        public void Update(GameTime gameTime)
        {
            double dt = gameTime.ElapsedGameTime.TotalSeconds; //dt keeps track of gametime in seconds.
            dateTime = dateTime.AddDays(dt/5); // returns a new DateTime object with the added days. Worrying about inefficiency.

            if (dateTime.Month == 7)
            {
                currentSeason = Seasons.summer;
            }
        }

        public DateTime getDate()
        {
            return dateTime;
        }

        public Seasons getSeason()
        {
            return currentSeason;
        }


    }
}
