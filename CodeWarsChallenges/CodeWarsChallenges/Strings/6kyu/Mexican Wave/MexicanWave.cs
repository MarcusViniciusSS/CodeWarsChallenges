namespace CodeWarsChallenges.Strings._6kyu.Mexican_Wave;

public static class MexicanWave
{
    public static List<string> Wave(string str)
    {
        var result = new List<string>(str.Length);
        if (str.Length <= 0) return result;
        
        for (var i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ') continue;
            var temp = str.ToCharArray();
            temp[i] = char.ToUpper(temp[i]);
            result.Add(new (temp));
        }
        
        return result;
    }
}