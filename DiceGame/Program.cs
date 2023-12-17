using System;
using System.Security.Cryptography.X509Certificates;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Dice Game!");
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadLine();
                Turn turn = new Turn();
                int result = turn.Roll();
            }
        }
        // Show Result of each roll in a class
    }
}


