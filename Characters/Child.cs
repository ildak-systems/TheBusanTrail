using System;
using System.Collections.Generic;
using System.Text;
using TheBusanTrail.Characters;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TheBusanTrail
{
    // Idea: UnhealthyChild variant where the health and moral of the child is little, but increases the moral and health of
    // other members of the family. Also exposes to random encounters that has generous outcome. 
    class Child : Character
    {
        private string name = "";
        private double Health;
        private int Moral; 
        private int MaxHealth;
        private int MaxMoral;
        HealthCalculator HealthCalc = new HealthCalculator();

        private const double percent = 0.5;

        public Child() {}
        public Child(string name)
        {
            this.name = name;
            Health = Convert.ToInt32(base.GetCurrentHealth() * percent);
            Moral = Convert.ToInt32(base.GetCurrentMoral() * percent);
            MaxHealth = Convert.ToInt32(base.GetMaxHealth() * percent);
            MaxMoral = Convert.ToInt32(base.GetMaxMoral() * percent);    
        }

        // Update character health, moral, injury, disease 
        public override void Update(GameTime gameTime)
        {
            HealthCalc.UpdateHealth_Child(this, gameTime);
            // update moral
        }

        public override string getName()
        {
            return name;
        }

        public override double GetCurrentHealth()
        {
            return Health;
        }

        public override void setHealth(double health)
        {
            Health += health;
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
