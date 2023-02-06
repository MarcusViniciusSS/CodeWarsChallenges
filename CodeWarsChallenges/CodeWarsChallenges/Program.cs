// See https://aka.ms/new-console-template for more information
using AlgTester.API;
using CodeWarsChallenges.Array._6kyu.MultiplicationTable;
using CodeWarsChallenges.Array._7kyu.Largest_Elements;
using CodeWarsChallenges.Strings._6kyu.Highest_Scoring_Word;
using CodeWarsChallenges.Strings._7kyu.Multiply_Word_In_String;

{
    Console.Write("7kyu  --- Strings -----");
    var sMultiply = MultiplyWordInString.ModifyMultiply;
    SolutionTester.New().WithSolution(sMultiply).Run();
    
    
    Console.Write("7kyu  --- Arrays -----");
    
    var sLargest = LargestElements.Largest;
    SolutionTester.New().WithSolution(sLargest).Run();
}

{
    Console.Write("6kyu  --- Strings -----");
    var sHighest = HighestScoringWord.High;
    SolutionTester.New().WithSolution(sHighest).Run();
}

{
    Console.Write("6kyu  --- Arrays -----");
    var sMultiplationTable = Multiplication.MultiplicationTable;
    SolutionTester.New().WithSolution(sMultiplationTable).Run();
}