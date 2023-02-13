namespace CodeWarsChallenges.Strings._5kyu.ROT13;

public static class ROT13
{
    public static string Encrypt(string input)
    {
        var inputArray = input.ToCharArray();
        for (var i = 0; i < inputArray.Length; i++)
        {
            var c = inputArray[i];
            inputArray[i] = c switch
            {
                >= 'a' and <= 'z' => (char) ('a' + (c - 'a' + 13) % 26),
                >= 'A' and <= 'Z' => (char) ('A' + (c - 'A' + 13) % 26),
                _ => inputArray[i]
            };
        }
        return new string(inputArray);
    }
}