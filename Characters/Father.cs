using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TheBusanTrail.Characters;

namespace TheBusanTrail
{
    enum Jobs
    {
        // Research popular jobs in NK at the same.
        farmer,
        banker,
        carpenter,
        none
    }

    class Father : Character
    {
        private string name = "";
        private Vector2 initial_position = new Vector2(500, 500);
        private Jobs job = Jobs.none;
        public Father() { }
        public Father(string name)
        {
            this.name = name;
        }

        public override string getName()
        {
            return name;
        }

    }
}
