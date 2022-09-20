﻿using System;
using System.Collections.Generic;
using System.Text;
using TheBusanTrail.Characters;

namespace TheBusanTrail
{
    // Idea: UnhealthyChild variant where the health and moral of the child is little, but increases the moral and health of
    // other members of the family. Also exposes to random encounters that has generous outcome. 
    class Child : Character
    {
        private string name = "";
        private int Health;
        private int Moral; 
        private int MaxHealth;
        private int MaxMoral;

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

        public override string getName()
        {
            return name;
        }

        public override int GetCurrentHealth()
        {
            return Health;
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
