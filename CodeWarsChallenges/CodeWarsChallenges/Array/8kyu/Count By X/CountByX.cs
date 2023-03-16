namespace CodeWarsChallenges.Array._8kyu.Count_By_X;

public static class CountByX
{
    public static int[] CountBy(int x, int n)
    {
        int[] z = new int[n];
        var index = 0;
        var value = 0;
        while (n > 0)
        {
            value += x;
            z[index] = value;
            n--;
            index++;
        }
    
        return z;
    }
}