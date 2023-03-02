namespace CodeWarsChallenges.Algorithms._8kyu.Keep_Hydrated;

public static class KeepHydrated
{
    public static int Litres(double time)
    {
        return (int)Math.Round(time * 0.5, MidpointRounding.ToZero);
    }
}