namespace DiceGame{


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