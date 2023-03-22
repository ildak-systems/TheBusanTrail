using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBusanTrail.Characters
{
    public class Child : Character
    {
        protected const int MAX_HEALTH = 50;
        protected const int MIN_HEALTH = 0;

        public Child(string name, int age)
        {
            this.name = name;
            this.age = age;

            // child health set of 50 : But faster regeneration
            this.health = 50;
        }
    }
}
