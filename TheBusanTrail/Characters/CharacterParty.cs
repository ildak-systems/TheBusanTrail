using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TheBusanTrail.Characters
{
    public class CharacterParty
    {
        private List<Character> partyContainer;

        public CharacterParty()
        {
            partyContainer = new List<Character>();
        }

        public void Update(GameTime gameTime) 
        {
            // Update() on CharacterParty calls Update() on
            // all Character objects in the List
            foreach (var character in this.partyContainer) 
            {
                character.Update(gameTime);
            }

        }

        public void add(Character ch) 
        {
            this.partyContainer.Add(ch);
        }

        public void remove(Character ch) 
        {
            this.partyContainer.Remove(ch);
        }

        public List<Character> GetParty()
        {
            return partyContainer;
        }


    }
}
