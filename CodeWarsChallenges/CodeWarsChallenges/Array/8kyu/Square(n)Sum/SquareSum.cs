namespace CodeWarsChallenges.Array._8kyu.Square_n_Sum;

public  static  class SquareSum
{
    public static int Sum(int[] numbers)
    {
        return numbers.Sum(item => item * item);
    }
}