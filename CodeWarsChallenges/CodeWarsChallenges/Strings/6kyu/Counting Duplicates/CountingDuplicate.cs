namespace CodeWarsChallenges.Strings._6kyu.Counting_Duplicates;

public static class CountingDuplicate
{
    public static int Count(string str)
    {
        var lowerString = str.ToLower();
        var hashSet = new HashSet<char>(lowerString.Length);
        var alreadyCount = new HashSet<char>(lowerString.Length);
        var count = 0;
        
        foreach (var value in lowerString)
        {
            if (hashSet.Contains(value))
            {
                if (!alreadyCount.Contains(value))
                {
                    count++;
                    alreadyCount.Add(value);
                }
                continue;
            }

            hashSet.Add(value);
        }
        
        return count;
    }
}