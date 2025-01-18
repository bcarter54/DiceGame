// See https://aka.ms/new-console-template for more information
// Bryce Carter
// Section 1
// Create a program that simulates the rolling of 2 6-sided die and the number of rolls is determined by the user 


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
        
        Console.WriteLine($"\nDICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = {numRolls}.\n");
        
        // With the values, print out how many times each number was rolled and make a histogram using the results
        for (int tally = 0; tally < rollTallies.Length; tally++)
        {
            
            // Calculate what percentage of the rolls that number made up and use that percentage to determine the number of stars
            double percent = ((double)rollTallies[tally] / numRolls) * 100;
            int numStars = (int)Math.Round(percent);
            // Add an * equal to the amount of percentage that number makes up the rolls
            string stars = new string('*', numStars);
            
            // Print the stars along with the percentage 
            Console.WriteLine($"{tally + 2}: {stars}");
        }
        Console.WriteLine($"\n\nThank you for using the dice throwing simulator. Goodbye!");
    }
}