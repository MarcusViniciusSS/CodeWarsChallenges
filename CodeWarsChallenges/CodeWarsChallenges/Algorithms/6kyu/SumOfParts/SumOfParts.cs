namespace CodeWarsChallenges.Algorithms._6kyu.SumOfParts;

public static class SumOfParts
{
    public static int[] PartsSums(int[] ls)
    {
        var sumParts = new int[ls.Length + 1];

        for (var i = sumParts.Length-2; i >= 0; i--)
        {
            sumParts[i] = ls[i] + sumParts[i + 1];
        }
        
        return sumParts;
    }
}