using System;
using TheBusanTrail.Characters;

namespace TheBusanTrail
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();

            /* Debugging */
            // Father class inheriting private vars from its base class works. (maxhealth, health etc)
            // Father class inheriting public methods from its base class works. (Get etc)
            // Father class manipulating private varible from base class works (TakeDamage())
            // Child class works, but only when making a separate base class: ChildCharacterStats. It would not override
            // the private variables from CharacterStats. 
            // The C# compiler doesn't allow the use of uninitialized variable
            /*Character father1 = new Father("Dan");
            Character child1 = new Child("Vlad");
            Character father2 = new Father("Tarry");

            CharacterParty party1 = new CharacterParty();

            party1.Add(father1);
            party1.Add(child1);
            party1.Add(father2);
            Console.WriteLine(party1.PartySize());

            for (int i = 0; i < party1.PartySize(); i++)
            {
                Character temp = party1.getParty()[i];
                Console.WriteLine(temp.getName() + ": ");
                Console.WriteLine("Health" + temp.GetCurrentHealth());
                Console.WriteLine("Max Health" + temp.GetMaxHealth());
                Console.WriteLine("Moral" + temp.GetCurrentMoral());
                Console.WriteLine("Max Moral" + temp.GetMaxMoral());
            }*/




            

        }
    }
}
