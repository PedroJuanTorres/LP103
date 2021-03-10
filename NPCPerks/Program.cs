using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numNPCs;
            Perks[] npcPerks;

            // Ask user for number of NPC
            Console.Write("How many NPC? ");
            numNPCs = int.Parse(Console.ReadLine());

            // Create array of NPC perks
            npcPerks = new Perks[numNPCs];

            // for each NPC, ask for its perks
            for (int n = 0; n < numNPCs; n++)
            {
                // User input
                string input;

                // Stealth?
                Console.Write($"Does NPC {n} has stealth (y/n)?");
                input = Console.ReadLine();
                if (input == "y")
                {
                    npcPerks[n] |= Perks.Stealth;
                }
                // Combat?
                Console.Write($"Does NPC {n} has combat (y/n)?");
                input = Console.ReadLine();
                if (input == "y")
                {
                    npcPerks[n] |= Perks.Combat;
                }
                // Lockpick?
                Console.Write($"Does NPC {n} has lockpick (y/n)?");
                input = Console.ReadLine();
                if (input == "y")
                {
                    npcPerks[n] |= Perks.Lockpick;
                }
                // Luck?
                Console.Write($"Does NPC {n} has Luck (y/n)?");
                input = Console.ReadLine();
                if (input == "y")
                {
                    npcPerks[n] |= Perks.Luck;
                }  
            }

            // Show all NPC's perks
            foreach (Perks perks in npcPerks)
            {
                Perks special = Perks.Combat | Perks.Luck;
                Console.WriteLine($"NPC has {perks}");
                if ((perks & special) == special)
                {
                    Console.WriteLine("\tYou shall win all fights");
                }
            }
        }
    }
}
