using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBusanTrail.Characters
{
    public class Father : Character
    {
        // const values cannot be marked static : const already means static
        protected const int MAX_HEALTH = 100;
        protected const int MIN_HEALTH = 0;

        public Father(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override void Update(GameTime gameTime)
        {

        }
    }
}
