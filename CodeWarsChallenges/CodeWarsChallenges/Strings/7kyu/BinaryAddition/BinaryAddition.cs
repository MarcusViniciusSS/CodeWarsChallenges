namespace CodeWarsChallenges.Strings._7kyu.BinaryAddition;

public static class BinaryAddition
{
    public static string AddBinary(int a, int b)
    {
        var number = a + b;
        var result = string.Empty;
        for (var i = 0; number > 0; i++)
        {
            result = number % 2 + result;
            number /= 2;
        }
    
        return result;
    }
}