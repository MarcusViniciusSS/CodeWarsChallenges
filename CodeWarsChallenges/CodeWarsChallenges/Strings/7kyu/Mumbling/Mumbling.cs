using System.Text;

namespace CodeWarsChallenges.Strings._7kyu.Mumbling;

public static class Mumbling
{
    public static string Accum(string s) 
    {
        var sb = new StringBuilder();
        var index = 0;
        
        foreach (var c in s)
        {
            sb.Append(char.ToUpper(c));
            for (var i = 0; i < index; i++)
            {
                sb.Append(char.ToLower(c));
            }
            index++;
            
            if (index < s.Length)
                sb.Append('-');
        }

        return sb.ToString();
    }
}