using System;
using System.Collections.Generic;
using System.Text;

namespace TheBusanTrail
{
    class MoneyTracker
    {
        private double Money;

        public MoneyTracker()
        {
            Money = 1000;
        }

        public void addMoney(double amount)
        {
            Money += amount;
        }

        public void spendMoney(double amount)
        {
            Money -= amount;
        }

        public double getMoney()
        {
            return Money;
        }


    }
}
