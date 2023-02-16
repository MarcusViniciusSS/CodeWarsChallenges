using System.Text;

namespace CodeWarsChallenges.Strings._8kyu.String_Repeat;

public static class StringRepeat
{
    public static string Repeat(int n, string s)
    {
        var stringBuilder = new StringBuilder(s.Length * n);

        for (var i = 0; i < n; i++)
            stringBuilder.Append(s);

        return stringBuilder.ToString();
    }
}