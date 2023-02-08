using System.Text;

namespace CodeWarsChallenges.Strings._6kyu.String_Array_Duplicates;

public static class StringArrayDuplicate
{
    public static string[] dup(string[] arr)
    {
        var strings = new string[arr.Length];
        
        for (var i = 0; i < arr.Length; i++)
        {
            var n = 0;
            var stringBuilder = new StringBuilder(arr[i].Length);
            var currentLetter = ' ';
            while (n < arr[i].Length)
            {
                if (char.IsWhiteSpace(currentLetter))
                {
                    stringBuilder.Append(arr[i][n]);
                    currentLetter = arr[i][n];
                } 
                else if (!currentLetter.Equals(arr[i][n]))
                {
                    stringBuilder.Append(arr[i][n]);
                    currentLetter = arr[i][n];
                }

                n++;
            }
            
            strings[i] = stringBuilder.ToString();
        }
        
        return strings;
    }
}