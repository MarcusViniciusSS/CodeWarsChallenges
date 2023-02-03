using System.Text;

namespace CodeWarsChallenges.Strings._7kyu.Multiply_Word_In_String;

public static class MultiplyWordInString
{
    public static string ModifyMultiply(string str,int loc,int num)
    {
        var strs = str.Split(" ");

        if (strs[loc] == null) return string.Empty;

        var stringbuilder = new StringBuilder((strs[loc].Length * num) + num);

        for (var i = 0; i < num; i++)
        {
            stringbuilder.Append(strs[loc]);

            if ((i + 1) == num)
            {
                continue;
            }
            
            stringbuilder.Append('-');
        }
        
        return stringbuilder.ToString();
    }
}