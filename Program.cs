// See https://aka.ms/new-console-template for more information

using DiceGame;

internal class Program
{
    public static void Main(string[] args)
    {
        

        Console.WriteLine("Welcome to the dice throwing simulator!\n\n" +
                          "How many dice rolls would you like to simulate?");

        int numRolls = int.Parse(Console.ReadLine());

        int[] rollTallies = MathTime.Run(numRolls);
        
        for (int tally = 0; tally < rollTallies.Length; tally++)
        {
            Console.WriteLine($"Sum of {tally + 2} was rolled {rollTallies[tally]} times");
            double percent = ((double)rollTallies[tally] / numRolls) * 100;

            int numStars = (int)Math.Round(percent);

            string stars = new string('*', numStars);
            Console.WriteLine($"{tally + 2}: {stars} ({percent}%)");
        }
    }
}