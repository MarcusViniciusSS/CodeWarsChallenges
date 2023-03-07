using System.Text;

namespace CodeWarsChallenges.Strings._7kyu.Jaden_Casing_Strings;

public static class JadenCasing
{
    public static string ToJadenCase(string phrase)
    {
        var words = phrase.Split(" ");

        var builder = new StringBuilder(phrase.Length);

        for (int i = 0; i < words.Length; i++)
        {
            if (!char.IsLetter(words[i][0]) || char.IsUpper(words[i][0]))
            {
                builder.Append(words[i]);
                
                if ((i + 1) == words.Length) 
                    continue;
                
                builder.Append(' ');
                continue;
            }
            
            builder.Append((char)(words[i][0] - 32));
            builder.Append(words[i][1..]);
            
            if ((i + 1) == words.Length) 
                continue;

            builder.Append(' ');
        }

        return builder.ToString();
    }
}