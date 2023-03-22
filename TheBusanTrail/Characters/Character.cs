// if base class is declared abstract, the derived class can still use
// the base class's default constructor if there is no implementation for default
// constructor. Seems like at least the default constructor is needed for the
// abstract base class
//
// class father : character
// character() { age = 50; }
// father f1()
// f1.age() prints 50;

using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBusanTrail.Characters
{
    public abstract class Character
    {
        protected string name;
        protected int age;
        protected Texture2D sprite;
        protected int health; // change to unsigned int?

        protected Character()
        {
            // default value for health
            health = 100;
        }

        public string getName()
        {
            return name;
        }

        public int getCurrentAge()
        {
            return age;
        }

        public int getCurrentHealth()
        {
            return health;
        }

        public Texture2D getSprite()
        {
            return sprite;
        }

        public void setSprite(Texture2D spr)
        {
            sprite = spr;
        }



    }
}
