using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Not sure why inheritance isn't working like it should
// will fix
namespace TheBusanTrail.Characters
{
    public abstract class Character
    {
        string name = "";
        Texture2D texture;
        double Health = 50; // default health, lesser for children
        int Moral = 30; // default moral, lesser for children
        const int MaxHealth = 50;
        const int MaxMoral = 30;
        HealthCalculator Healthcalc = new HealthCalculator();

        public virtual string getName()
        {
            return name;
        }

        public virtual Texture2D getSprite()
        {
            return texture;
        }

        public virtual void Update(GameTime gameTime) { } 
        

        public virtual void GainHealth(int health)
        {
            Health += health;
            // set conditions for max health
        }

        public virtual void setHealth(double health) { }

        public virtual void TakeDamage(double damage)
        {
            Health -= damage;
        }

        public virtual double GetCurrentHealth()
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
