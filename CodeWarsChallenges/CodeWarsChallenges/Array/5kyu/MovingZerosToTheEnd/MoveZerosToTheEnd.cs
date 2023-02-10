namespace CodeWarsChallenges.Array._5kyu.MovingZerosToTheEnd;

public static class MoveZerosToTheEnd
{
    public static int[] MoveZeroes(int[] arr)
    {
        if (arr.Length <= 0) return System.Array.Empty<int>();

        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0) continue;

            for (var j = i+1; j < arr.Length; j++)
            {
                if (arr[j] == 0) continue;

                arr[i] = arr[j];
                arr[j] = 0;
                break;
            }
        }
        
        return arr;
    }
}