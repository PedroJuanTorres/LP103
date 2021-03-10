using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string inputString;
            char inputChar;

            //Ask user for a string
            Console.Write("Write a string: ");
            inputString = Console.ReadLine();

            //Ask user for a character
            Console.Write("Write a char: ");
            inputChar = Console.ReadLine()[0];

            // Write thr string without the character
            foreach (char c in inputString)
            {
                if (c != inputChar)
                {
                    Console.Write(c);
                }
            }
            Console.WriteLine();
        }
    }
}
