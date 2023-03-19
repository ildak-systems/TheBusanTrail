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
        Texture2D texture;
        double Health;
        int Moral;
        int MaxHealth;
        int MaxMoral;
        
        private Vector2 initial_position = new Vector2(500, 500);
        private Jobs job = Jobs.none;

        HealthCalculator Healthcalc = new HealthCalculator();
        public Father() { }
        public Father(string name, Texture2D texture)
        {
            Health = base.GetCurrentHealth();
            Moral = base.GetCurrentMoral();
            MaxHealth = base.GetMaxHealth();
            MaxMoral = base.GetMaxMoral();
            this.name = name;
        }

        public override string getName()
        {
            return name;
        }

        public override void Update(GameTime gameTime) 
        {
            double dt = gameTime.ElapsedGameTime.TotalSeconds;
            // health
            Healthcalc.UpdateHealth_Adult(this, gameTime);
        }
        public override void TakeDamage(double damage)
        {
            Health -= damage;
        }

        public override double GetCurrentHealth()
        {
            return Health;
        }

        public override void setHealth(double health)
        {
            Health = health;
        }

        public override int GetCurrentMoral()
        {
            return Moral;
        }

        public override int GetMaxHealth()
        {
            return MaxHealth;
        }

        public override int GetMaxMoral()
        {
            return MaxMoral;
        }
    }
}
