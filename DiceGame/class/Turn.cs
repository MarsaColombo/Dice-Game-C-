namespace DiceGame
{
    public class Turn
    {
        private readonly Dice dice = new Dice();

        public int Roll()
        {
            Console.WriteLine("Press Enter to roll the dice");

            var inputTask = Task.Run(() => Console.ReadLine());
            if (inputTask.Wait(TimeSpan.FromSeconds(10)))
            {
                int result = dice.Roll();
                Console.WriteLine($"You rolled a {result}");
                return result;
            }
            else
            {
                Console.WriteLine("FTimeout! Proceeding with default action.");
                int result = 1;
                Console.WriteLine($"You rolled a {result}");
                return result;
            }
        }
    }
}