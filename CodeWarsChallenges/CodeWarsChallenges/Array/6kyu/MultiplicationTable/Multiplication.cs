namespace CodeWarsChallenges.Array._6kyu.MultiplicationTable;

public static class Multiplication
{
    public static int[,] MultiplicationTable(int size)
    {
        var table = new int [size, size];

        for (var line = 1; line <= size; line++)
        {
            for (var column = 0; column < size; column++)
            {
                table[line - 1, column] = line * (1 + column);
            }
        }

        return table;
    }
}