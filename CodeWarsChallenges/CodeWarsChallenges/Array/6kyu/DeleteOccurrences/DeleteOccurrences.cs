namespace CodeWarsChallenges.Array._6kyu.DeleteOccurrences;

public static class DeleteOccurrences
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        var tupleList = new List<Tuple<int, bool>>(arr.Length);
        var dic = new Dictionary<int, int>(arr.Length);

        for (var i = 0; i < arr.Length; i++)
        {
            if (!dic.ContainsKey(arr[i]))
            {
                dic.Add(arr[i], 1);
                continue;
            }

            dic[arr[i]] += 1;

            if (dic[arr[i]] > x)
            {
                tupleList.Add(new Tuple<int, bool>(i, true));
            }
        }

        var result = new List<int>();
        
        for (var i = 0; i < arr.Length; i++)
        {
            if (!tupleList.Contains(new Tuple<int, bool>(i, true)))
            {
                result.Add(arr[i]);
            }
        }

        return result.ToArray();
    }
}