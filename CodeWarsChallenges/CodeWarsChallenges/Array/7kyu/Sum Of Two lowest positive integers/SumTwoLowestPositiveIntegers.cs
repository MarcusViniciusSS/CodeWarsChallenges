namespace CodeWarsChallenges.Array._7kyu.Sum_Of_Two_lowest_positive_integers;

public static class SumTwoLowestPositiveIntegers
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        if (numbers.Length == 0) 
            return 0;

        if (numbers.Length == 1)
            return numbers[0];

        var ordersNumbers = numbers.OrderBy(item => item);
        using var enumerator = ordersNumbers.GetEnumerator();

        enumerator.MoveNext();
        var x = enumerator.Current;
        enumerator.MoveNext();
        var y = enumerator.Current;
        
        return x + y;
    }
}