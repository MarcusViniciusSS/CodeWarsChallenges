using System.Text;

namespace CodeWarsChallenges.Strings._8kyu.Sentence_Smash;

public static class SentenceSmash
{
    public static string Smash(string[] words)
    {
        var sb = new StringBuilder();

        for (var i = 0; i < words.Length; i++)
        {
            if (i != 0)
            {
                sb.Append(' ');
            } 
            
            sb.Append(words[i]);
        }

        return sb.ToString();
    }
}