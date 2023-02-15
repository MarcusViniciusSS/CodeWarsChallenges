// See https://aka.ms/new-console-template for more information
using AlgTester.API;
using CodeWarsChallenges.Algorithms._6kyu.SumOfParts;
using CodeWarsChallenges.Array._5kyu.MovingZerosToTheEnd;
using CodeWarsChallenges.Array._6kyu.Array.Diff;
using CodeWarsChallenges.Array._6kyu.MultiplicationTable;
using CodeWarsChallenges.Array._6kyu.Two_Sum;
using CodeWarsChallenges.Array._7kyu.Largest_Elements;
using CodeWarsChallenges.Array._8kyu.SumOfOddNumber;
using CodeWarsChallenges.Strings._5kyu.ROT13;
using CodeWarsChallenges.Strings._6kyu.Highest_Scoring_Word;
using CodeWarsChallenges.Strings._6kyu.Mexican_Wave;
using CodeWarsChallenges.Strings._6kyu.String_Array_Duplicates;
using CodeWarsChallenges.Strings._7kyu.Multiply_Word_In_String;

{
    Console.WriteLine("8kyu  --- Arrays -----");
    
    var sumOddNumbers = SumOfOddNumber.RowSumOddNumbers;
    SolutionTester.New().WithSolution(sumOddNumbers).Run();
}

{
    Console.WriteLine("7kyu  --- Strings -----");
    var sMultiply = MultiplyWordInString.ModifyMultiply;
    SolutionTester.New().WithSolution(sMultiply).Run();
    
    
    Console.WriteLine("7kyu  --- Arrays -----");
    
    var sLargest = LargestElements.Largest;
    SolutionTester.New().WithSolution(sLargest).Run();
}

{
    Console.WriteLine("6kyu  --- Strings -----");
    var sHighest = HighestScoringWord.High;
    SolutionTester.New().WithSolution(sHighest).Run();
    
    var sWave = MexicanWave.Wave;
    SolutionTester.New().WithSolution(sWave).Run();
    
    var sDup = StringArrayDuplicate.dup;
    SolutionTester.New().WithSolution(sDup).Run();
}

{
    Console.WriteLine("6kyu  --- Arrays -----");
    var sMultiplationTable = Multiplication.MultiplicationTable;
    SolutionTester.New().WithSolution(sMultiplationTable).Run();
    
    var sIndex = TwoSum.GetIndex;
    SolutionTester.New().WithSolution(sIndex).Run();

    var sArrayDiff = ArrayDiff.GetDiff;
    SolutionTester.New().WithSolution(sArrayDiff).Run();
}

{
    Console.WriteLine("6kyu  --- Algorithms -----");
    var partsSums = SumOfParts.PartsSums;
    SolutionTester.New().WithSolution(partsSums).Run();
}

{
    Console.WriteLine("5kyu  --- Arrays -----");
    var sMoveZeroes = MoveZerosToTheEnd.MoveZeroes;
    SolutionTester.New().WithSolution(sMoveZeroes).Run();
}

{
    Console.WriteLine("5kyu  --- Strings -----");
    var sEncrypt = ROT13.Encrypt;
    SolutionTester.New().WithSolution(sEncrypt).Run();
}