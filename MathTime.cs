namespace DiceGame;

public class MathTime
{
    public static int[] Run(int numRolls)
    {
        int[] rollTallies = new int[11];

        for (int iCount = 0; iCount < numRolls; iCount++)
        {
            Random dice = new Random();
            int dice1 = dice.Next(1, 7);
            int dice2 = dice.Next(1, 7);
            int sum = dice1 + dice2;


            rollTallies[sum - 2]++;
        }
        
        return(rollTallies);
        
    }
}