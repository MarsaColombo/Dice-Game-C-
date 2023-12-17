using System;
using System.Security.Cryptography.X509Certificates;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {

        }


    }
    public class Dice
    {
        private static Random random = new Random();

        public int Roll()
        {
            int randomNumber = random.Next(0, 7);

            if (randomNumber == 0)
            {
                return 1;
            }
            else if (randomNumber == 7)
            {
                return 6;
            }
            else
            {
                return randomNumber;
            }
        }
    }
}


