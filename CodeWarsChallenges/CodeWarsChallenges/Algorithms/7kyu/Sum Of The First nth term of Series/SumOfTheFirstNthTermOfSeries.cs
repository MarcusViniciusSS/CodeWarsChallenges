using System.Globalization;

namespace CodeWarsChallenges.Algorithms._7kyu.Sum_Of_The_First_nth_term_of_Series;

public static class SumOfTheFirstNthTermOfSeries
{
    public static string seriesSum(int n)
    {
        decimal result = 0m;
        int divisor = 1;
    
        while(n > 0){
            n--;
            result += (decimal ) 1 / divisor;
            divisor+= 3;
        }

        return Math.Round(result, 2).ToString("0.00", CultureInfo.InvariantCulture);
    }
}