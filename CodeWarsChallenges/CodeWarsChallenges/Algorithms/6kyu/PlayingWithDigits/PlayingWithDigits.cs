namespace CodeWarsChallenges.Algorithms._6kyu.PlayingWithDigits
{
    public static class PlayingWithDigits
    {
        public static long digPow(int n, int p)
        {
            string digits = n.ToString();
            int total = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                total += (int)Math.Pow(int.Parse(digits[i].ToString()), p + i);
            }

            if (total % n == 0)
            {
                return total / n;
            }
            else
            {
                return -1;
            }
        }
    }
}

