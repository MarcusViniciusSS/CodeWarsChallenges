namespace CodeWarsChallenges.Strings._7kyu.Get_The_Middle_Character;

public static class GetTheMiddleCharacter
{
    public static string GetMiddle(string s)
    {
        if (string.IsNullOrEmpty(s)) 
            return s;
        
        var isEven = s.Length % 2 == 0;
        var length = 1;
        var index = 0;

        if (s.Length != 1)
        {
            length = isEven ? 2 : 1;
        }

        if (length != 0)
        {
            index =  isEven ? (s.Length / 2) - 1 : (s.Length / 2);
        }
        
        return s.Substring(index , length);
    }
}