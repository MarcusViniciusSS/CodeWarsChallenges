namespace CodeWarsChallenges.Algorithms._6kyu.PlayingWithDigits
{
    public static class PlayingWithDigits
    {
        public static long digPow(int n, int p)
        {
            var digits = n.ToString();
            var total = digits.Select((t, i) => (int) Math.Pow(int.Parse(t.ToString()), p + i)).Sum();

            if (total % n == 0)
            {
                return total / n;
            }
            
            return -1;
        }
    }
}

