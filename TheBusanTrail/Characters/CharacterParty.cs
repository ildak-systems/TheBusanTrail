using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBusanTrail.Characters
{
    public class CharacterParty
    {
        private Character[] partyContainer;

        public CharacterParty(int size)
        {
            // arrays are declared as new by default.
            this.partyContainer = new Character[size];
        }

        public void add(Character ch) 
        {
            this.partyContainer.Append(ch);
        }

        public void remove(Character ch) 
        {
            
        }

        public Character[] getParty()
        {
            return partyContainer;
        }


    }
}
