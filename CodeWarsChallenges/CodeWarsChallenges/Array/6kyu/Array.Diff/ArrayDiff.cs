using System.Collections;

namespace CodeWarsChallenges.Array._6kyu.Array.Diff;

public static class ArrayDiff
{
    public static int[] GetDiff(int[] a, int[] b)
    {
        if (a.Length == 0) return a;
        if (b.Length == 0) return a;

        var hashSet = new HashSet<int>(a.Length);

        for (int i = 0; i < b.Length; i++)
        {
            if (hashSet.Contains(b[i])) continue;
            
            hashSet.Add(b[i]);
        }

        var result = new List<int>();

        for (int i = 0; i < a.Length; i++)
        {
            if (hashSet.Contains(a[i])) continue;

            result.Add(a[i]);
        }
        
        return result.ToArray();
    }
}