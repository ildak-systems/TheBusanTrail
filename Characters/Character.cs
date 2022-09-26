using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace TheBusanTrail.Characters
{
    public abstract class Character
    {
        string name = "";
        int Health = 50; // default health, lesser for children
        int Moral = 30; // default moral, lesser for children
        const int MaxHealth = 50;
        const int MaxMoral = 30;

        public virtual string getName()
        {
            return name;
        }

        public virtual void GainHealth(int health)
        {
            Health += health;
            // set conditions for max health
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public virtual int GetCurrentHealth()
        {
            return Health;
        }

        public virtual int GetMaxHealth()
        {
            return MaxHealth;
        }

        public virtual int GetCurrentMoral()
        {
            return Moral;
        }

        public virtual int GetMaxMoral()
        {
            return MaxMoral;
        }


    }
}
