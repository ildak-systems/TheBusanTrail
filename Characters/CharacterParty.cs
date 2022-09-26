using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace TheBusanTrail.Characters
{
    public class CharacterParty
    {
        private List<Character> Party = new List<Character>();

        public CharacterParty() { }

        

        public List<Character> getParty()
        {
            return Party;
        }

        public void Add(Character ch)
        {
            Party.Add(ch);
        }

        public void Remove(Character ch)
        {
            Party.Remove(ch);
        }

        public int PartySize()
        {
            return Party.Count();
        }


    }
}
