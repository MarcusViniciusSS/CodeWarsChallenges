namespace CodeWarsChallenges.Strings._6kyu.Highest_Scoring_Word;

public static class HighestScoringWord
{
    public static Dictionary<char, int> Weight = new()
    {
        {'a', 1},
        {'b', 2},
        {'c', 3},
        {'d', 4},
        {'e', 5},
        {'f', 6},
        {'g', 7},
        {'h', 8},
        {'i', 9},
        {'j', 10},
        {'k', 11},
        {'l', 12},
        {'m', 13},
        {'n', 14},
        {'o', 15},
        {'p', 16},
        {'q', 17},
        {'r', 18},
        {'s', 19},
        {'t', 20},
        {'u', 21},
        {'v', 22},
        {'w', 23},
        {'x', 24},
        {'y', 25},
        {'z', 26}
    };

    public static string High(string s)
    {
        var strs = s.Split(" ");
        
        var better = string.Empty;
        var points = 0;

        foreach (var str in strs)
        {
            var n = 0;
            var currentPoint = 0;

            while (n < str.Length)
            {
                currentPoint += Weight.GetValueOrDefault(str[n]);
                n++;
            }

            if (currentPoint <= points) continue;

            points = currentPoint;
            better = str;
        }
        
        return better;
    }
}