namespace CodeWarsChallenges.Array._8kyu.Count_Of_Positives_and_Sum_Negatives;

public static class CountPositivesSumNegatives
{
    public static int[] CountOfPositivesSumNegatives(int[] input)
    {
        if (input is null || !input.Any())
            return new int[] { };
        
        return new int[2] { (int)input.LongCount(item => item > 0), input.Where(item => item < 0).Sum(item => item)  };
    }
}