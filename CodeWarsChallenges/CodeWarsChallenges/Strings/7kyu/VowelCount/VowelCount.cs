namespace CodeWarsChallenges.Strings._7kyu.VowelCount;

public static class VowelCount
{
    private static HashSet<char> Vowels = new HashSet<char>()
    {
        'a', 'e', 'i', 'o', 'u'
    };
    
    public static int GetVowelCount(string str)
    {
        return str.Count(t => Vowels.Contains(t));
    }
}