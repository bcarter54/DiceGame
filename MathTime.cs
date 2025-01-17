namespace DiceGame;

//MathTime class is in charge of handling the dice rolls as well as providing the array with the sums of the rolls
public class MathTime
{
    //Run method for the actual rolls and tallying
    public static int[] Run(int numRolls)
    {
        //Initialize array
        int[] rollTallies = new int[11];

        //For loop designed to run for as many rolls as requested by the user
        for (int iCount = 0; iCount < numRolls; iCount++)
        {
            // Randomization represented by the variable dice used to simulate dice rolls
            Random dice = new Random();
            int dice1 = RollDice();
            int dice2 = RollDice();
            
            // Add up dice rolls
            int sum = dice1 + dice2;

            // Place tally in array
            rollTallies[sum - 2]++;
        }
        // Return completed array
        return(rollTallies);
        
    }

    public static int RollDice()
    {
        Random rnd = new Random();
        int dice = rnd.Next(1, 7);
        
        return dice;
    }
}