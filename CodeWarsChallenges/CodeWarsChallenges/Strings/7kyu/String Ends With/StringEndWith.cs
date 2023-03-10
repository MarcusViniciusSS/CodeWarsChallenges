namespace CodeWarsChallenges.Strings._7kyu.String_Ends_With;

public static class StringEndWith
{
    public static bool EndWith(string str, string ending)
    {
        if (string.IsNullOrEmpty(str)) 
            return false;

        if(string.IsNullOrEmpty(ending))
            return true;
    
        var startIndex = str.Length - ending.Length;
        if (startIndex < 0)
            return false;

        var substring = str[startIndex..];

        return substring == ending;
    }
}