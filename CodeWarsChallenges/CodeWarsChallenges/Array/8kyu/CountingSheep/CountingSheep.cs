namespace CodeWarsChallenges.Array._8kyu.CountingSheep;

public static class CountingSheep
{
    public static int Count(bool[] sheeps)
    {
        return sheeps.Count(sheep => sheep);
    }
}