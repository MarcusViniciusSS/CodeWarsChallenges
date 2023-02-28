using System.Text;

namespace CodeWarsChallenges.Strings._7kyu.ComplementaryDNA;

public static class ComplementaryDNA
{
    private static Dictionary<char, char> Deoxyribonucleic = new Dictionary<char, char>()
    {
        {'A', 'T'},
        {'T', 'A'},
        {'C', 'G'},
        {'G', 'C'}
    };
    
    public static string MakeComplement(string dna)
    {
       var builder = new StringBuilder(dna.Length);

        foreach (var key in dna)
        {
            if (!Deoxyribonucleic.ContainsKey(key)) continue;

            builder.Append(Deoxyribonucleic.GetValueOrDefault(key));
        }
        
        return builder.ToString();
    } 
}