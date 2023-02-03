namespace CodeWarsChallenges.Array._7kyu.Largest_Elements;

public static class LargestElements
{
    public static List<int> Largest(int n, List<int> xs)
    {
        if (n == 0) return new();

        var list = xs.OrderByDescending(item => item).ToList();
        var result = new Stack<int>(n);

        for (var i = 0; i < n; i++)
        {
            result.Push(list[i]);
        }
        
        // Find the n highest elements in a list
        return result.ToList();
    }
}