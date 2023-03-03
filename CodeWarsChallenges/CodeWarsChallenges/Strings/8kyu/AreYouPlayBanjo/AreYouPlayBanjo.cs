namespace CodeWarsChallenges.Strings._8kyu.AreYouPlayBanjo;

public static class AreYouPlayBanjo
{
    public static string AreYouPlayingBanjo(string name)
    {
        if (name.StartsWith("R") || name.StartsWith("r"))
            return $"{name} plays banjo";
        
        return $"{name} does not play banjo";
    }
}