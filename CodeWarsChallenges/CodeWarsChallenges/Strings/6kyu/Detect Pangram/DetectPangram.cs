namespace CodeWarsChallenges.Strings._6kyu.Detect_Pangram;

public static class DetectPangram
{
    private static readonly HashSet<int> ASCIIAlphabet = new()
    {
        65,
        66,
        67,
        68,
        69,
        70,
        71,
        72,
        73,
        74,
        75,
        76,
        77,
        78,
        79,
        80,
        81,
        82,
        83,
        84,
        85,
        86,
        87,
        88,
        89,
        90
    };
    
    
    public static bool IsPangram(string str)
    {
        var countAlphabet = ASCIIAlphabet.Count;
        var hashSet = new HashSet<int>();
        var stringUpper = str.ToUpper();
        var count = 0;

        for (var i = 0; i < stringUpper.Length; i++)
        {
            if (count == countAlphabet) 
                return true;
            
            if (!ASCIIAlphabet.Contains((int)stringUpper[i])) 
                continue;

            if (hashSet.Contains((int) stringUpper[i]))
                continue;

            hashSet.Add(stringUpper[i]);
            count++;
        }

        return count == countAlphabet;
    }
}