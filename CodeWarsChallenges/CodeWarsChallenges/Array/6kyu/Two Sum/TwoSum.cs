namespace CodeWarsChallenges.Array._6kyu.Two_Sum;

public static class TwoSum
{
    public static int[] GetIndex(int[] numbers, int target)
    {
        var dictionary = new Dictionary<int, int>();
        
        for (var i = 0; i < numbers.Length; i++)
        {
            if (dictionary.ContainsKey(numbers[i]))
                continue;
            
            dictionary.Add(numbers[i], i);
        }
        
        for (var i = 0; i < numbers.Length; i++)
        {
            var value = target - numbers[i];
            
            if (dictionary.ContainsKey(value) && dictionary[value] != i)
            {
                return i > dictionary[value]
                    ? new[] {dictionary[value], i} 
                    : new[] {i, dictionary[value]};
            }
        }
        
        return System.Array.Empty<int>();
    }
}