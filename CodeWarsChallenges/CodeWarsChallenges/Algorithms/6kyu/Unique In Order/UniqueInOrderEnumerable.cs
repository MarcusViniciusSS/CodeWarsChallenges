namespace CodeWarsChallenges.Algorithms._6kyu.Unique_In_Order;

public static class UniqueInOrderEnumerable
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        var array = iterable.ToArray();
        var result = new List<T>();

        if (!array.Any())
            return Enumerable.Empty<T>();
        
        var preview = array[0];
        result.Add(preview);
        
        for (var i = 1; i < array.Length; i++)
        {
            if (preview!.Equals(array[i]))
                continue;

            preview = array[i];
            result.Add(array[i]);
        }

        return result.AsEnumerable();
    }
}