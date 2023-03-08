namespace CodeWarsChallenges.Array._6kyu.Find_The_Odd_Int;

public static class FindTheOddInt
{
    public static int find_it(int[] seq)
    {
        if (!seq.Any()) return -1;
        
        var groups = seq.GroupBy(item => item);
        
        return groups.First(item => item.Count() % 2 != 0).Key;
    }
}