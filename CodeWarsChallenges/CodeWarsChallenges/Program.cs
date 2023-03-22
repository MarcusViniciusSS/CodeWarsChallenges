// See https://aka.ms/new-console-template for more information
using AlgTester.API;
using CodeWarsChallenges.Algorithms._6kyu.SumOfParts;
using CodeWarsChallenges.Algorithms._6kyu.Unique_In_Order;
using CodeWarsChallenges.Algorithms._7kyu.Sum_Of_The_First_nth_term_of_Series;
using CodeWarsChallenges.Algorithms._8kyu.Keep_Hydrated;
using CodeWarsChallenges.Array._5kyu.MovingZerosToTheEnd;
using CodeWarsChallenges.Array._6kyu.Array.Diff;
using CodeWarsChallenges.Array._6kyu.Find_The_Odd_Int;
using CodeWarsChallenges.Array._6kyu.MultiplicationTable;
using CodeWarsChallenges.Array._6kyu.Two_Sum;
using CodeWarsChallenges.Array._7kyu.Largest_Elements;
using CodeWarsChallenges.Array._7kyu.Sum_Of_Two_lowest_positive_integers;
using CodeWarsChallenges.Array._8kyu.Count_By_X;
using CodeWarsChallenges.Array._8kyu.Count_Of_Positives_and_Sum_Negatives;
using CodeWarsChallenges.Array._8kyu.CountingSheep;
using CodeWarsChallenges.Array._8kyu.Square_n_Sum;
using CodeWarsChallenges.Array._8kyu.SumOfOddNumber;
using CodeWarsChallenges.Strings._5kyu.ROT13;
using CodeWarsChallenges.Strings._6kyu.Counting_Duplicates;
using CodeWarsChallenges.Strings._6kyu.Detect_Pangram;
using CodeWarsChallenges.Strings._6kyu.Highest_Scoring_Word;
using CodeWarsChallenges.Strings._6kyu.Mexican_Wave;
using CodeWarsChallenges.Strings._6kyu.String_Array_Duplicates;
using CodeWarsChallenges.Strings._7kyu.BinaryAddition;
using CodeWarsChallenges.Strings._7kyu.ComplementaryDNA;
using CodeWarsChallenges.Strings._7kyu.Get_The_Middle_Character;
using CodeWarsChallenges.Strings._7kyu.Jaden_Casing_Strings;
using CodeWarsChallenges.Strings._7kyu.Multiply_Word_In_String;
using CodeWarsChallenges.Strings._7kyu.Mumbling;
using CodeWarsChallenges.Strings._7kyu.String_Ends_With;
using CodeWarsChallenges.Strings._7kyu.Two_to_One;
using CodeWarsChallenges.Strings._7kyu.VowelCount;
using CodeWarsChallenges.Strings._8kyu.AreYouPlayBanjo;
using CodeWarsChallenges.Strings._8kyu.Sentence_Smash;
using CodeWarsChallenges.Strings._8kyu.String_Repeat;

{
    Console.WriteLine("8kyu  --- Arrays -----");
    
    var sumOddNumbers = SumOfOddNumber.RowSumOddNumbers;
    SolutionTester.New().WithSolution(sumOddNumbers).Run();
    
    var squareSum = SquareSum.Sum;
    SolutionTester.New().WithSolution(squareSum).Run();
    
    var sCountingSheep = CountingSheep.Count;
    SolutionTester.New().WithSolution(sCountingSheep).Run();

    var sCountPositivesSumNegatives = CountPositivesSumNegatives.CountOfPositivesSumNegatives;
    SolutionTester.New().WithSolution(sCountPositivesSumNegatives).Run();

    var sCountByX = CountByX.CountBy;
    SolutionTester.New().WithSolution(sCountByX).Run();
}

{
    Console.WriteLine("8kyu  --- string -----");

    var sRepeat = StringRepeat.Repeat;
    SolutionTester.New().WithSolution(sRepeat).Run();
    
    
    var sBanjo = AreYouPlayBanjo.AreYouPlayingBanjo;
    SolutionTester.New().WithSolution(sBanjo).Run();

    var sSmash = SentenceSmash.Smash;
    SolutionTester.New().WithSolution(sSmash).Run();
    
    Console.WriteLine("8kyu  --- Algorithms -----");
    var sLitres = KeepHydrated.Litres;
    SolutionTester.New().WithSolution(sLitres).Run();

    var sStringEndWith = StringEndWith.EndWith;
    SolutionTester.New().WithSolution(sStringEndWith).Run();    
}

{
    Console.WriteLine("7kyu  --- Strings -----");
    var sMultiply = MultiplyWordInString.ModifyMultiply;
    SolutionTester.New().WithSolution(sMultiply).Run();

    var sBinaryAddition = BinaryAddition.AddBinary;
    SolutionTester.New().WithSolution(sBinaryAddition).Run();

    var sVowelCount = VowelCount.GetVowelCount;
    SolutionTester.New().WithSolution(sVowelCount);

    var sComplementaryDNA = ComplementaryDNA.MakeComplement;
    SolutionTester.New().WithSolution(sComplementaryDNA).Run();

    var sGetTheMiddleCharacter = GetTheMiddleCharacter.GetMiddle;
    SolutionTester.New().WithSolution(sGetTheMiddleCharacter).Run();
    
    var sToJadenCase = JadenCasing.ToJadenCase;
    SolutionTester.New().WithSolution(sToJadenCase).Run();
    
    var sLongest = TwoToOne.Longest;
    SolutionTester.New().WithSolution(sLongest).Run();
    
    var sMumbling = Mumbling.Accum;
    SolutionTester.New().WithSolution(sMumbling).Run();
    
    Console.WriteLine("7kyu  --- Arrays -----");
    var sLargest = LargestElements.Largest;
    SolutionTester.New().WithSolution(sLargest).Run();
    
    var sSumTwoSmallestNumbers = SumTwoLowestPositiveIntegers.sumTwoSmallestNumbers;
    SolutionTester.New().WithSolution(sSumTwoSmallestNumbers).Run();
    
    Console.WriteLine("7kyu  --- Algorithms -----");
    var sSeriesSum = SumOfTheFirstNthTermOfSeries.seriesSum;
    SolutionTester.New().WithSolution(sSeriesSum).Run();
}

{
    Console.WriteLine("6kyu  --- Strings -----");
    var sHighest = HighestScoringWord.High;
    SolutionTester.New().WithSolution(sHighest).Run();
    
    var sWave = MexicanWave.Wave;
    SolutionTester.New().WithSolution(sWave).Run();
    
    var sDup = StringArrayDuplicate.dup;
    SolutionTester.New().WithSolution(sDup).Run();

    var sDuplicateCount = CountingDuplicate.Count;
    SolutionTester.New().WithSolution(sDuplicateCount).Run();

    var sDetectPangram = DetectPangram.IsPangram;
    SolutionTester.New().WithSolution(sDetectPangram).Run();
}

{
    Console.WriteLine("6kyu  --- Arrays -----");
    var sMultiplationTable = Multiplication.MultiplicationTable;
    SolutionTester.New().WithSolution(sMultiplationTable).Run();
    
    var sIndex = TwoSum.GetIndex;
    SolutionTester.New().WithSolution(sIndex).Run();

    var sArrayDiff = ArrayDiff.GetDiff;
    SolutionTester.New().WithSolution(sArrayDiff).Run();
    
    var sFindIt = FindTheOddInt.find_it;
    SolutionTester.New().WithSolution(sFindIt).Run();
}

{
    Console.WriteLine("6kyu  --- Algorithms -----");
    var partsSums = SumOfParts.PartsSums;
    SolutionTester.New().WithSolution(partsSums).Run();

    var sUniqueInOrderEnumerable = UniqueInOrderEnumerable.UniqueInOrder<int>;
    SolutionTester.New().WithSolution(sUniqueInOrderEnumerable).Run();
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