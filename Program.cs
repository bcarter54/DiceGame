// See https://aka.ms/new-console-template for more information

using DiceGame;

internal class Program
{
    public static void Main(string[] args)
    {
        
        // Introduction and asking for number of rolls
        Console.WriteLine("Welcome to the dice throwing simulator!\n\n" +
                          "How many dice rolls would you like to simulate?");

        int numRolls = int.Parse(Console.ReadLine());

        // Call MathTime class and run the Run method to give the array rollTallies its values
        int[] rollTallies = MathTime.Run(numRolls);
        
        // With the values, print out how many times each number was rolled and make a histogram using the results
        for (int tally = 0; tally < rollTallies.Length; tally++)
        {
            Console.WriteLine($"{tally + 2} was rolled {rollTallies[tally]} times");
            
            // Calculate what percentage of the rolls that number made up and use that percentage to determine the number of stars
            double percent = ((double)rollTallies[tally] / numRolls) * 100;
            int numStars = (int)Math.Round(percent);
            // Add an * equal to the amount of percentage that number makes up the rolls
            string stars = new string('*', numStars);
            
            // Print the stars along with the percentage 
            Console.WriteLine($"{tally + 2}: {stars} ({percent}%)");
        }
    }
}