namespace CodeWarsChallenges.Strings._7kyu.Two_to_One;

public static class TwoToOne
{
    public static string Longest (string s1, string s2)
    {
        if (string.IsNullOrEmpty(s1) && string.IsNullOrEmpty(s2)) 
            return string.Empty;

        return new string(s1.Concat(s2).Select(item => item).Distinct().OrderBy(item => item).ToArray());
    }
}