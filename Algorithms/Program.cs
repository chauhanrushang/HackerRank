using System;
using Algorithms.DynamicProgramming;
using Algorithms.Greedy;
using Algorithms.Implementation;
using Algorithms.Sorting;
using Algorithms.Strings;
using Algorithms.Warmup;

namespace Algorithms
{
    static class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                bool exit = false;
                Console.WriteLine("Please select an Algorithm for simulation.");
                Console.WriteLine("===================================================");
                Console.WriteLine("0. Exit!");
                Console.WriteLine("1. Warmup");
                Console.WriteLine("2. Implementation");
                Console.WriteLine("3. Strings");
                Console.WriteLine("4. Sorting");
                Console.WriteLine("5. Graph Theory");
                Console.WriteLine("6. Greedy");
                Console.WriteLine("7. Dynamic Programming");
                Console.WriteLine("8. Constructive Algorithms");
                Console.WriteLine("9. Bit Manipulation");
                Console.WriteLine("10. Recursion");
                Console.WriteLine("11. Game Theory");
                Console.WriteLine("12. NP Complete");
                Console.WriteLine("===================================================");
                Console.WriteLine();
                int input = Convert.ToInt32(Console.ReadLine());

                switch ((AlgorithmType)input)
                {
                    case AlgorithmType.Exit:
                        exit = true;
                        break;
                    case AlgorithmType.Warmup:
                        WarmupProgram();
                        break;
                    case AlgorithmType.Implementation:
                        ImplementationProgram();
                        break;
                    case AlgorithmType.Strings:
                        StringsProgram();
                        break;
                    case AlgorithmType.Sorting:
                        SortingProgram();
                        break;
                    case AlgorithmType.GraphTheory:
                        GraphTheoryProgram();
                        break;
                    case AlgorithmType.Greedy:
                        GreedyProgram();
                        break;
                    case AlgorithmType.DynamicProgramming:
                        DynamicProgrammingProgram();
                        break;
                    case AlgorithmType.ConstructiveAlgorithms:
                        ConstructiveAlgorithmsProgram();
                        break;
                    case AlgorithmType.BitManipulation:
                        BitManipulationProgram();
                        break;
                    case AlgorithmType.Recursion:
                        RecursionProgram();
                        break;
                    case AlgorithmType.GameTheory:
                        GameTheoryProgram();
                        break;
                    case AlgorithmType.NPComplete:
                        NPCompleteProgram();
                        break;
                    default:
                        break;
                }

                if (exit) break;
            }
        }

        private static void WarmupProgram()
        {
            Console.WriteLine("Please select an Warmup Program for simulation.");
            Console.WriteLine("===================================================");
            Console.WriteLine("0. Exit!");
            Console.WriteLine("1. Solve Me First");
            Console.WriteLine("2. Simple Array Sum");
            Console.WriteLine("3. Compare the Triplets");
            Console.WriteLine("4. A Very Big Sum");
            Console.WriteLine("5. Diagonal Difference");
            Console.WriteLine("6. Plus Minus");
            Console.WriteLine("7. Staircase");
            Console.WriteLine("8. Mini-Max Sum");
            Console.WriteLine("9. Birthday Cake Candles");
            Console.WriteLine("10. Time Conversion");
            Console.WriteLine("===================================================");
            int input = Convert.ToInt32(Console.ReadLine());

            switch ((WarmupProgramTypes)input)
            {
                case WarmupProgramTypes.Exit:
                    break;
                case WarmupProgramTypes.SolveMeFirst:
                    WarmupProgramClass.SolveMeFirst();
                    break;
                case WarmupProgramTypes.SimpleArraySum:
                    WarmupProgramClass.SimpleArraySum();
                    break;
                case WarmupProgramTypes.ComparetheTriplets:
                    WarmupProgramClass.ComparetheTriplets();
                    break;
                case WarmupProgramTypes.AVeryBigSum:
                    WarmupProgramClass.AVeryBigSum();
                    break;
                case WarmupProgramTypes.DiagonalDifference:
                    WarmupProgramClass.DiagonalDifference();
                    break;
                case WarmupProgramTypes.PlusMinus:
                    WarmupProgramClass.PlusMinus();
                    break;
                case WarmupProgramTypes.Staircase:
                    WarmupProgramClass.Staircase();
                    break;
                case WarmupProgramTypes.MiniMaxSum:
                    WarmupProgramClass.MiniMaxSum();
                    break;
                case WarmupProgramTypes.BirthdayCakeCandles:
                    WarmupProgramClass.BirthdayCakeCandles();
                    break;
                case WarmupProgramTypes.TimeConversion:
                    WarmupProgramClass.TimeConversion();
                    break;
                default:
                    break;
            }
        }

        private static void ImplementationProgram()
        {
            Console.WriteLine("Please select an Implementation Program for simulation.");
            Console.WriteLine("===================================================");
            Console.WriteLine("00. Exit!");
            Console.WriteLine("01. Grading Students");
            Console.WriteLine("02. Apple and Orange");
            Console.WriteLine("03. Kangaroo");
            Console.WriteLine("04. Between Two Sets");
            Console.WriteLine("05. Breaking the Records");
            Console.WriteLine("06. Birthday Chocolate");
            Console.WriteLine("07. Divisible Sum Pairs");
            Console.WriteLine("08. Migratory Birds");
            Console.WriteLine("09. Day of the Programmer");
            Console.WriteLine("10. Bon Appétit");
            Console.WriteLine("11. Sock Merchant");
            Console.WriteLine("12. Drawing Book");
            Console.WriteLine("13. Counting Valleys");
            Console.WriteLine("14. Electronics Shop");
            Console.WriteLine("15. Cats and a Mouse");
            Console.WriteLine("16. Forming a Magic Square");
            Console.WriteLine("17. Picking Numbers");
            Console.WriteLine("18. Climbing the Leaderboard");
            Console.WriteLine("19. The Hurdle Race");
            Console.WriteLine("20. Designer PDF Viewer");
            Console.WriteLine("21. Utopian Tree");
            Console.WriteLine("22. Angry Professor");
            Console.WriteLine("23. Beautiful Days at the Movies");
            Console.WriteLine("24. Viral Advertising");
            Console.WriteLine("25. Save the Prisoner!");
            Console.WriteLine("26. Circular Array Rotation");
            Console.WriteLine("27. Sequence Equation");
            Console.WriteLine("28. Jumping on the Clouds: Revisited");
            Console.WriteLine("29. Find Digits");
            Console.WriteLine("30. Extra Long Factorials");
            Console.WriteLine("31. Append and Delete");
            Console.WriteLine("32. Sherlock and Squares");
            Console.WriteLine("33. Library Fine");
            Console.WriteLine("34. Cut the sticks");
            Console.WriteLine("35. Non-Divisible Subset");
            Console.WriteLine("36. Repeated String");
            Console.WriteLine("37. Jumping on the Clouds");
            Console.WriteLine("38. Equalize the Array");
            Console.WriteLine("39. Queen's Attack II");
            Console.WriteLine("40. ACM ICPC Team");
            Console.WriteLine("41. Taum and B'day");
            Console.WriteLine("42. Organizing Containers of Balls");
            Console.WriteLine("43. Encryption");
            Console.WriteLine("44. Bigger is Greater");
            Console.WriteLine("45. Modified Kaprekar Numbers");
            Console.WriteLine("46. Beautiful Triplets");
            Console.WriteLine("47. Minimum Distances");
            Console.WriteLine("48. The Time in Words");
            Console.WriteLine("49. Chocolate Feast");
            Console.WriteLine("50. Service Lane");
            Console.WriteLine("51. Lisa's Workbook");
            Console.WriteLine("52. Flatland Space Stations");
            Console.WriteLine("53. Fair Rations");
            Console.WriteLine("54. Cavity Map");
            Console.WriteLine("55. Manasa and Stones");
            Console.WriteLine("56. The Grid Search");
            Console.WriteLine("57. Happy Ladybugs");
            Console.WriteLine("58. Strange Counter");
            Console.WriteLine("59. Absolute Permutation");
            Console.WriteLine("60. The Bomberman Game");
            Console.WriteLine("61. Ema's Supercomputer");
            Console.WriteLine("62. Larry's Array");
            Console.WriteLine("63. Almost Sorted");
            Console.WriteLine("64. Matrix Layer Rotation");
            Console.WriteLine("===================================================");
            int input = Convert.ToInt32(Console.ReadLine());

            switch ((ImplementationProgramTypes)input)
            {
                case ImplementationProgramTypes.Exit:
                    break;
                case ImplementationProgramTypes.GradingStudents:
                    ImplementationClass.GradingStudents();
                    break;
                case ImplementationProgramTypes.AppleandOrange:
                    ImplementationClass.AppleandOrange();
                    break;
                case ImplementationProgramTypes.Kangaroo:
                    ImplementationClass.Kangaroo();
                    break;
                case ImplementationProgramTypes.BetweenTwoSets:
                    ImplementationClass.BetweenTwoSets();
                    break;
                case ImplementationProgramTypes.BreakingtheRecords:
                    ImplementationClass.BreakingtheRecords();
                    break;
                case ImplementationProgramTypes.BirthdayChocolate:
                    ImplementationClass.BirthdayChocolate();
                    break;
                case ImplementationProgramTypes.DivisibleSumPairs:
                    ImplementationClass.DivisibleSumPairs();
                    break;
                case ImplementationProgramTypes.MigratoryBirds:
                    ImplementationClass.MigratoryBirds();
                    break;
                case ImplementationProgramTypes.DayoftheProgrammer:
                    ImplementationClass.DayoftheProgrammer();
                    break;
                case ImplementationProgramTypes.BonAppétit:
                    ImplementationClass.BonAppétit();
                    break;
                case ImplementationProgramTypes.SockMerchant:
                    ImplementationClass.SockMerchant();
                    break;
                case ImplementationProgramTypes.DrawingBook:
                    ImplementationClass.DrawingBook();
                    break;
                case ImplementationProgramTypes.CountingValleys:
                    ImplementationClass.CountingValleys();
                    break;
                case ImplementationProgramTypes.ElectronicsShop:
                    ImplementationClass.ElectronicsShop();
                    break;
                case ImplementationProgramTypes.CatsandaMouse:
                    ImplementationClass.CatsandaMouse();
                    break;
                case ImplementationProgramTypes.FormingaMagicSquare:
                    ImplementationClass.FormingaMagicSquare();
                    break;
                case ImplementationProgramTypes.PickingNumbers:
                    ImplementationClass.PickingNumbers();
                    break;
                case ImplementationProgramTypes.ClimbingtheLeaderboard:
                    ImplementationClass.ClimbingtheLeaderboard();
                    break;
                case ImplementationProgramTypes.TheHurdleRace:
                    ImplementationClass.TheHurdleRace();
                    break;
                case ImplementationProgramTypes.DesignerPDFViewer:
                    ImplementationClass.DesignerPDFViewer();
                    break;
                case ImplementationProgramTypes.UtopianTree:
                    ImplementationClass.UtopianTree();
                    break;
                case ImplementationProgramTypes.AngryProfessor:
                    ImplementationClass.AngryProfessor();
                    break;
                case ImplementationProgramTypes.BeautifulDaysattheMovies:
                    ImplementationClass.BeautifulDaysattheMovies();
                    break;
                case ImplementationProgramTypes.ViralAdvertising:
                    ImplementationClass.ViralAdvertising();
                    break;
                case ImplementationProgramTypes.SavethePrisoner:
                    ImplementationClass.SavethePrisoner();
                    break;
                case ImplementationProgramTypes.CircularArrayRotation:
                    ImplementationClass.CircularArrayRotation();
                    break;
                case ImplementationProgramTypes.SequenceEquation:
                    ImplementationClass.SequenceEquation();
                    break;
                case ImplementationProgramTypes.JumpingontheCloudsRevisited:
                    ImplementationClass.JumpingontheCloudsRevisited();
                    break;
                case ImplementationProgramTypes.FindDigits:
                    ImplementationClass.FindDigits();
                    break;
                case ImplementationProgramTypes.ExtraLongFactorials:
                    ImplementationClass.ExtraLongFactorials();
                    break;
                case ImplementationProgramTypes.AppendandDelete:
                    ImplementationClass.AppendandDelete();
                    break;
                case ImplementationProgramTypes.SherlockandSquares:
                    ImplementationClass.SherlockandSquares();
                    break;
                case ImplementationProgramTypes.LibraryFine:
                    ImplementationClass.LibraryFine();
                    break;
                case ImplementationProgramTypes.Cutthesticks:
                    ImplementationClass.Cutthesticks();
                    break;
                case ImplementationProgramTypes.NonDivisibleSubset:
                    ImplementationClass.NonDivisibleSubset();
                    break;
                case ImplementationProgramTypes.RepeatedString:
                    ImplementationClass.RepeatedString();
                    break;
                case ImplementationProgramTypes.JumpingontheClouds:
                    ImplementationClass.JumpingontheClouds();
                    break;
                case ImplementationProgramTypes.EqualizetheArray:
                    ImplementationClass.EqualizetheArray();
                    break;
                case ImplementationProgramTypes.QueensAttackII:
                    ImplementationClass.QueensAttackII();
                    break;
                case ImplementationProgramTypes.ACMICPCTeam:
                    ImplementationClass.ACMICPCTeam();
                    break;
                case ImplementationProgramTypes.TaumandBday:
                    ImplementationClass.TaumandBday();
                    break;
                case ImplementationProgramTypes.OrganizingContainersofBalls:
                    ImplementationClass.OrganizingContainersofBalls();
                    break;
                case ImplementationProgramTypes.Encryption:
                    ImplementationClass.Encryption();
                    break;
                case ImplementationProgramTypes.BiggerisGreater:
                    ImplementationClass.BiggerisGreater();
                    break;
                case ImplementationProgramTypes.ModifiedKaprekarNumbers:
                    ImplementationClass.ModifiedKaprekarNumbers();
                    break;
                case ImplementationProgramTypes.BeautifulTriplets:
                    ImplementationClass.BeautifulTriplets();
                    break;
                case ImplementationProgramTypes.MinimumDistances:
                    ImplementationClass.MinimumDistances();
                    break;
                case ImplementationProgramTypes.TheTimeinWords:
                    ImplementationClass.TheTimeinWords();
                    break;
                case ImplementationProgramTypes.ChocolateFeast:
                    ImplementationClass.ChocolateFeast();
                    break;
                case ImplementationProgramTypes.ServiceLane:
                    ImplementationClass.ServiceLane();
                    break;
                case ImplementationProgramTypes.LisasWorkbook:
                    ImplementationClass.LisasWorkbook();
                    break;
                case ImplementationProgramTypes.FlatlandSpaceStations:
                    ImplementationClass.FlatlandSpaceStations();
                    break;
                case ImplementationProgramTypes.FairRations:
                    ImplementationClass.FairRations();
                    break;
                case ImplementationProgramTypes.CavityMap:
                    ImplementationClass.CavityMap();
                    break;
                case ImplementationProgramTypes.ManasaandStones:
                    ImplementationClass.ManasaandStones();
                    break;
                case ImplementationProgramTypes.TheGridSearch:
                    ImplementationClass.TheGridSearch();
                    break;
                case ImplementationProgramTypes.HappyLadybugs:
                    ImplementationClass.HappyLadybugs();
                    break;
                case ImplementationProgramTypes.StrangeCounter:
                    ImplementationClass.StrangeCounter();
                    break;
                case ImplementationProgramTypes.AbsolutePermutation:
                    ImplementationClass.AbsolutePermutation();
                    break;
                case ImplementationProgramTypes.TheBombermanGame:
                    ImplementationClass.TheBombermanGame();
                    break;
                case ImplementationProgramTypes.EmasSupercomputer:
                    ImplementationClass.EmasSupercomputer();
                    break;
                case ImplementationProgramTypes.LarrysArray:
                    ImplementationClass.LarrysArray();
                    break;
                case ImplementationProgramTypes.AlmostSorted:
                    ImplementationClass.AlmostSorted();
                    break;
                case ImplementationProgramTypes.MatrixLayerRotation:
                    ImplementationClass.MatrixLayerRotation();
                    break;
                default:
                    break;
            }

        }

        private static void StringsProgram()
        {
            Console.WriteLine("Please select an Strings Program for simulation.");
            Console.WriteLine("===================================================");
            Console.WriteLine("00. Exit!");
            Console.WriteLine("01. Super Reduced String");
            Console.WriteLine("02. CamelCase");
            Console.WriteLine("03. Two Characters");
            Console.WriteLine("04. Strong Password");
            Console.WriteLine("05. Caesar Cipher");
            Console.WriteLine("06. Mars Exploration");
            Console.WriteLine("07. HackerRank in a String!");
            Console.WriteLine("08. Pangrams");
            Console.WriteLine("09. Weighted Uniform Strings");
            Console.WriteLine("10. Separate the Numbers");
            Console.WriteLine("11. Funny String");
            Console.WriteLine("12. Gemstones");
            Console.WriteLine("13. Alternating Characters");
            Console.WriteLine("14. Beautiful Binary String");
            Console.WriteLine("15. The Love-Letter Mystery");
            Console.WriteLine("16. Determining DNA Health");
            Console.WriteLine("17. Palindrome Index");
            Console.WriteLine("18. Anagram");
            Console.WriteLine("19. Making Anagrams");
            Console.WriteLine("20. Game of Thrones - I");
            Console.WriteLine("21. Two Strings");
            Console.WriteLine("22. Sherlock and the Valid String");
            Console.WriteLine("23. Richie Rich");
            Console.WriteLine("24. Sherlock and Anagrams");
            Console.WriteLine("25. Common Child");
            Console.WriteLine("26. Bear and Steady Gene");
            Console.WriteLine("27. Morgan and a String");
            Console.WriteLine("28. Count Strings");
            Console.WriteLine("29. String Function Calculation");
            Console.WriteLine("30. Build a Palindrome");
            Console.WriteLine("31. Build a String");
            Console.WriteLine("32. Gridland Provinces");
            Console.WriteLine("33. Ashton and String");
            Console.WriteLine("34. String Similarity");
            Console.WriteLine("35. Super Functional Strings");
            Console.WriteLine("36. Circular Palindromes");
            Console.WriteLine("37. Similar Strings");
            Console.WriteLine("38. Save Humanity");
            Console.WriteLine("39. Find Strings");
            Console.WriteLine("40. Palindromic Border");
            Console.WriteLine("41. Two Two");
            Console.WriteLine("42. Two Strings Game");
            Console.WriteLine("43. Letter Islands");
            Console.WriteLine("44. Pseudo-Isomorphic Substrings");
            Console.WriteLine("45. How Many Substrings?");
            Console.WriteLine("===================================================");
            int input = Convert.ToInt32(Console.ReadLine());

            switch ((StringsProgramTypes)input)
            {
                case StringsProgramTypes.Exit:
                    break;
                case StringsProgramTypes.SuperReducedString:
                    StringsClass.SuperReducedString();
                    break;
                case StringsProgramTypes.CamelCase:
                    StringsClass.CamelCase();
                    break;
                case StringsProgramTypes.TwoCharacters:
                    StringsClass.StrongPassword();
                    break;
                case StringsProgramTypes.StrongPassword:
                    StringsClass.StrongPassword();
                    break;
                case StringsProgramTypes.CaesarCipher:
                    StringsClass.CaesarCipher();
                    break;
                case StringsProgramTypes.MarsExploration:
                    StringsClass.MarsExploration();
                    break;
                case StringsProgramTypes.HackerRankinaString:
                    StringsClass.HackerRankinaString();
                    break;
                case StringsProgramTypes.Pangrams:
                    StringsClass.Pangrams();
                    break;
                case StringsProgramTypes.WeightedUniformStrings:
                    StringsClass.WeightedUniformStrings();
                    break;
                case StringsProgramTypes.SeparatetheNumbers:
                    StringsClass.SeparatetheNumbers();
                    break;
                case StringsProgramTypes.FunnyString:
                    StringsClass.FunnyString();
                    break;
                case StringsProgramTypes.Gemstones:
                    StringsClass.Gemstones();
                    break;
                case StringsProgramTypes.AlternatingCharacters:
                    StringsClass.AlternatingCharacters();
                    break;
                case StringsProgramTypes.BeautifulBinaryString:
                    StringsClass.BeautifulBinaryString();
                    break;
                case StringsProgramTypes.TheLoveLetterMystery:
                    StringsClass.TheLoveLetterMystery();
                    break;
                case StringsProgramTypes.DeterminingDNAHealth:
                    StringsClass.DeterminingDNAHealth();
                    break;
                case StringsProgramTypes.PalindromeIndex:
                    StringsClass.PalindromeIndex();
                    break;
                case StringsProgramTypes.Anagram:
                    StringsClass.Anagram();
                    break;
                case StringsProgramTypes.MakingAnagrams:
                    StringsClass.MakingAnagrams();
                    break;
                case StringsProgramTypes.GameofThronesI:
                    StringsClass.GameofThronesI();
                    break;
                case StringsProgramTypes.TwoStrings:
                    StringsClass.TwoStrings();
                    break;
                case StringsProgramTypes.SherlockandtheValidString:
                    StringsClass.SherlockandtheValidString();
                    break;
                case StringsProgramTypes.RichieRich:
                    StringsClass.RichieRich();
                    break;
                case StringsProgramTypes.SherlockandAnagrams:
                    StringsClass.SherlockandAnagrams();
                    break;
                case StringsProgramTypes.CommonChild:
                    StringsClass.CommonChild();
                    break;
                case StringsProgramTypes.BearandSteadyGene:
                    StringsClass.BearandSteadyGene();
                    break;
                case StringsProgramTypes.MorganandaString:
                    StringsClass.MorganandaString();
                    break;
                case StringsProgramTypes.CountStrings:
                    StringsClass.CountStrings();
                    break;
                case StringsProgramTypes.StringFunctionCalculation:
                    StringsClass.StringFunctionCalculation();
                    break;
                case StringsProgramTypes.BuildaPalindrome:
                    StringsClass.BuildaPalindrome();
                    break;
                case StringsProgramTypes.BuildaString:
                    StringsClass.BuildaString();
                    break;
                case StringsProgramTypes.GridlandProvinces:
                    StringsClass.GridlandProvinces();
                    break;
                case StringsProgramTypes.AshtonandString:
                    StringsClass.AshtonandString();
                    break;
                case StringsProgramTypes.StringSimilarity:
                    StringsClass.StringSimilarity();
                    break;
                case StringsProgramTypes.SuperFunctionalStrings:
                    StringsClass.SuperFunctionalStrings();
                    break;
                case StringsProgramTypes.CircularPalindromes:
                    StringsClass.CircularPalindromes();
                    break;
                case StringsProgramTypes.SimilarStrings:
                    StringsClass.SimilarStrings();
                    break;
                case StringsProgramTypes.SaveHumanity:
                    StringsClass.SaveHumanity();
                    break;
                case StringsProgramTypes.FindStrings:
                    StringsClass.FindStrings();
                    break;
                case StringsProgramTypes.PalindromicBorder:
                    StringsClass.PalindromicBorder();
                    break;
                case StringsProgramTypes.TwoTwo:
                    StringsClass.TwoTwo();
                    break;
                case StringsProgramTypes.TwoStringsGame:
                    StringsClass.TwoStringsGame();
                    break;
                case StringsProgramTypes.LetterIslands:
                    StringsClass.LetterIslands();
                    break;
                case StringsProgramTypes.PseudoIsomorphicSubstrings:
                    StringsClass.PseudoIsomorphicSubstrings();
                    break;
                case StringsProgramTypes.HowManySubstrings:
                    StringsClass.HowManySubstrings();
                    break;
                default:
                    break;
            }
        }

        private static void SortingProgram()
        {
            Console.WriteLine("Please select an Algorithm for simulation.");
            Console.WriteLine("===================================================");
            Console.WriteLine("0. Exit!");
            Console.WriteLine("1. Big Sorting");
            Console.WriteLine("2. Intro to Tutorial Challenges");
            Console.WriteLine("3. Insertion Sort - Part 1");
            Console.WriteLine("4. Insertion Sort - Part 2");
            Console.WriteLine("5. Correctness and the Loop Invariant");
            Console.WriteLine("6. Running Time of Algorithms");
            Console.WriteLine("7. Quicksort 1 - Partition");
            Console.WriteLine("8. Counting Sort 1");
            Console.WriteLine("9. Counting Sort 2");
            Console.WriteLine("10. The Full Counting Sort");
            Console.WriteLine("===================================================");
            int input = Convert.ToInt32(Console.ReadLine());

            switch ((SortingProgramTypes)input)
            {
                case SortingProgramTypes.Exit:
                    break;
                case SortingProgramTypes.BigSorting:
                    SortingClass.BigSorting();
                    break;
                case SortingProgramTypes.IntrotoTutorialChallenges:
                    SortingClass.IntrotoTutorialChallenges();
                    break;
                case SortingProgramTypes.InsertionSortPart1:
                    SortingClass.InsertionSortPart1();
                    break;
                case SortingProgramTypes.InsertionSortPart2:
                    SortingClass.InsertionSortPart2();
                    break;
                case SortingProgramTypes.CorrectnessandtheLoopInvariant:
                    SortingClass.CorrectnessandtheLoopInvariant();
                    break;
                case SortingProgramTypes.RunningTimeofAlgorithms:
                    SortingClass.RunningTimeofAlgorithms();
                    break;
                case SortingProgramTypes.Quicksort1Partition:
                    SortingClass.Quicksort1Partition();
                    break;
                case SortingProgramTypes.CountingSort1:
                    SortingClass.CountingSort1();
                    break;
                case SortingProgramTypes.CountingSort2:
                    SortingClass.CountingSort2();
                    break;
                case SortingProgramTypes.TheFullCountingSort:
                    SortingClass.TheFullCountingSort();
                    break;
                case SortingProgramTypes.ClosestNumbers:
                    SortingClass.ClosestNumbers();
                    break;
                case SortingProgramTypes.FindtheMedian:
                    SortingClass.FindtheMedian();
                    break;
                case SortingProgramTypes.InsertionSortAdvancedAnalysis:
                    SortingClass.InsertionSortAdvancedAnalysis();
                    break;
                case SortingProgramTypes.FraudulentActivityNotifications:
                    SortingClass.FraudulentActivityNotifications();
                    break;
                case SortingProgramTypes.LilysHomework:
                    SortingClass.LilysHomework();
                    break;
                default:
                    break;
            }
        }

        private static void GraphTheoryProgram()
        {
            throw new NotImplementedException();
        }

        private static void GreedyProgram()
        {
            Console.WriteLine("Please select an Dynamic Programming Program for simulation.");
            Console.WriteLine("===================================================");
            Console.WriteLine("00. Exit!");
            Console.WriteLine("01. Minimum Absolute Difference in an Array");
            Console.WriteLine("02. Marc's Cakewalk");
            Console.WriteLine("03. Grid Challenge");
            Console.WriteLine("04. Luck Balance");
            Console.WriteLine("05. Maximum Perimeter Triangle");
            Console.WriteLine("06. Beautiful Pairs");
            Console.WriteLine("07. Sherlock and The Beast");
            Console.WriteLine("08. Priyanka and Toys");
            Console.WriteLine("09. Largest Permutation");
            Console.WriteLine("10. Mark and Toys");
            Console.WriteLine("11. Greedy Florist");
            Console.WriteLine("12. Max Min");
            Console.WriteLine("13. Jim and the Orders");
            Console.WriteLine("14. Permuting Two Arrays");
            Console.WriteLine("15. Cutting Boards");
            Console.WriteLine("16. Reverse Shuffle Merge");
            Console.WriteLine("17. Goodland Electricity");
            Console.WriteLine("18. Cloudy Day");
            Console.WriteLine("19. Chief Hopper");
            Console.WriteLine("20. Sherlock and MiniMax");
            Console.WriteLine("21. Accessory Collection");
            Console.WriteLine("22. Team Formation");
            Console.WriteLine("23. Fighting Pits");
            int input = Convert.ToInt32(Console.ReadLine());

            switch ((GreedyProgramTypes)input)
            {
                case GreedyProgramTypes.Exit:
                    break;
                case GreedyProgramTypes.MinimumAbsoluteDifferenceinanArray:
                    GreedyProgramClass.MinimumAbsoluteDifferenceinanArray();
                    break;
                case GreedyProgramTypes.MarcsCakewalk:
                    GreedyProgramClass.MarcsCakewalk();
                    break;
                case GreedyProgramTypes.GridChallenge:
                    GreedyProgramClass.GridChallenge();
                    break;
                case GreedyProgramTypes.LuckBalance:
                    GreedyProgramClass.LuckBalance();
                    break;
                case GreedyProgramTypes.MaximumPerimeterTriangle:
                    GreedyProgramClass.MaximumPerimeterTriangle();
                    break;
                case GreedyProgramTypes.BeautifulPairs:
                    GreedyProgramClass.BeautifulPairs();
                    break;
                case GreedyProgramTypes.SherlockandTheBeast:
                    GreedyProgramClass.SherlockandTheBeast();
                    break;
                case GreedyProgramTypes.PriyankaandToys:
                    GreedyProgramClass.PriyankaandToys();
                    break;
                case GreedyProgramTypes.LargestPermutation:
                    GreedyProgramClass.LargestPermutation();
                    break;
                case GreedyProgramTypes.MarkandToys:
                    GreedyProgramClass.MarkandToys();
                    break;
                case GreedyProgramTypes.GreedyFlorist:
                    GreedyProgramClass.GreedyFlorist();
                    break;
                case GreedyProgramTypes.MaxMin:
                    GreedyProgramClass.MaxMin();
                    break;
                case GreedyProgramTypes.JimandtheOrders:
                    GreedyProgramClass.JimandtheOrders();
                    break;
                case GreedyProgramTypes.PermutingTwoArrays:
                    GreedyProgramClass.PermutingTwoArrays();
                    break;
                case GreedyProgramTypes.CuttingBoards:
                    GreedyProgramClass.CuttingBoards();
                    break;
                case GreedyProgramTypes.ReverseShuffleMerge:
                    GreedyProgramClass.ReverseShuffleMerge();
                    break;
                case GreedyProgramTypes.GoodlandElectricity:
                    GreedyProgramClass.GoodlandElectricity();
                    break;
                case GreedyProgramTypes.CloudyDay:
                    GreedyProgramClass.CloudyDay();
                    break;
                case GreedyProgramTypes.ChiefHopper:
                    GreedyProgramClass.ChiefHopper();
                    break;
                case GreedyProgramTypes.SherlockandMiniMax:
                    GreedyProgramClass.SherlockandMiniMax();
                    break;
                case GreedyProgramTypes.AccessoryCollection:
                    GreedyProgramClass.AccessoryCollection();
                    break;
                case GreedyProgramTypes.TeamFormation:
                    GreedyProgramClass.TeamFormation();
                    break;
                case GreedyProgramTypes.FightingPits:
                    GreedyProgramClass.FightingPits();
                    break;
                default:
                    break;
            }
        }

        private static void DynamicProgrammingProgram()
        {
            Console.WriteLine("Please select an Dynamic Programming Program for simulation.");
            Console.WriteLine("===================================================");
            Console.WriteLine("00. Exit!");
            Console.WriteLine("01. The Coin Change Problem");
            Console.WriteLine("02. Equal");
            Console.WriteLine("03. Sherlock and Cost");
            Console.WriteLine("04. Construct the Array");
            Console.WriteLine("05. Kingdom Division");
            Console.WriteLine("06. Candies");
            Console.WriteLine("07. Sam and sub-strings");
            Console.WriteLine("08. Fibonacci Modified");
            Console.WriteLine("09. Abbreviation");
            Console.WriteLine("10. Prime XOR");
            Console.WriteLine("11. Decibinary Numbers");
            Console.WriteLine("12. Fair Cut");
            Console.WriteLine("13. The Maximum Subarray");
            Console.WriteLine("14. Angry Children 2");
            Console.WriteLine("15. Sherlock's Array Merging Algorithm");
            Console.WriteLine("16. Prime Digit Sums");
            Console.WriteLine("17. HackerRank City");
            Console.WriteLine("18. Summing Pieces");
            Console.WriteLine("19. Mr K marsh");
            Console.WriteLine("20. Substring Diff");
            Console.WriteLine("21. Xor and Sum");
            Console.WriteLine("22. Lego Blocks");
            Console.WriteLine("23. Brick Tiling");
            Console.WriteLine("24. Alien Languages");
            Console.WriteLine("25. Stock Maximize");
            Console.WriteLine("26. Two Robots");
            Console.WriteLine("27. Cut Tree");
            Console.WriteLine("28. Tara's Beautiful Permutations");
            Console.WriteLine("29. Wet Shark and Two Subsequences");
            Console.WriteLine("30. Nikita and the Game");
            Console.WriteLine("31. Choosing White Balls");
            Console.WriteLine("32. Mandragora Forest");
            Console.WriteLine("33. Red John is Back");
            Console.WriteLine("34. LCS Returns");
            Console.WriteLine("35. Grid Walking");
            Console.WriteLine("36. Matrix Land");
            Console.WriteLine("37. Knapsack");
            Console.WriteLine("38. Bricks Game");
            Console.WriteLine("39. The Longest Increasing Subsequence");
            Console.WriteLine("40. Coin on the Table");
            Console.WriteLine("41. The Longest Common Subsequence");
            Console.WriteLine("42. Play with words");
            Console.WriteLine("43. Black and White Tree");
            Console.WriteLine("44. Counting Special Sub-Cubes");
            Console.WriteLine("45. Interval Selection");
            Console.WriteLine("46. String Reduction");
            Console.WriteLine("47. Far Vertices");
            Console.WriteLine("48. Counting Road Networks");
            Console.WriteLine("49. Superman Celebrates Diwali");
            Console.WriteLine("50. Hexagonal Grid");
            int input = Convert.ToInt32(Console.ReadLine());

            switch ((DynamicProgrammingProgramTypes)input)
            {
                case DynamicProgrammingProgramTypes.Exit:
                    break;
                case DynamicProgrammingProgramTypes.TheCoinChangeProblem:
                    DynamicClass.TheCoinChangeProblem();
                    break;
                case DynamicProgrammingProgramTypes.Equal:
                    DynamicClass.Equal();
                    break;
                case DynamicProgrammingProgramTypes.SherlockandCost:
                    DynamicClass.SherlockandCost();
                    break;
                case DynamicProgrammingProgramTypes.ConstructtheArray:
                    DynamicClass.ConstructtheArray();
                    break;
                case DynamicProgrammingProgramTypes.KingdomDivision:
                    DynamicClass.KingdomDivision();
                    break;
                case DynamicProgrammingProgramTypes.Candies:
                    DynamicClass.Candies();
                    break;
                case DynamicProgrammingProgramTypes.Samandsubstrings:
                    DynamicClass.Samandsubstrings();
                    break;
                case DynamicProgrammingProgramTypes.FibonacciModified:
                    DynamicClass.FibonacciModified();
                    break;
                case DynamicProgrammingProgramTypes.Abbreviation:
                    DynamicClass.Abbreviation();
                    break;
                case DynamicProgrammingProgramTypes.PrimeXOR:
                    DynamicClass.PrimeXOR();
                    break;
                case DynamicProgrammingProgramTypes.DecibinaryNumbers:
                    DynamicClass.DecibinaryNumbers();
                    break;
                case DynamicProgrammingProgramTypes.FairCut:
                    DynamicClass.FairCut();
                    break;
                case DynamicProgrammingProgramTypes.TheMaximumSubarray:
                    DynamicClass.TheMaximumSubarray();
                    break;
                case DynamicProgrammingProgramTypes.AngryChildren2:
                    DynamicClass.AngryChildren2();
                    break;
                case DynamicProgrammingProgramTypes.SherlocksArrayMergingAlgorithm:
                    DynamicClass.SherlocksArrayMergingAlgorithm();
                    break;
                case DynamicProgrammingProgramTypes.PrimeDigitSums:
                    DynamicClass.PrimeDigitSums();
                    break;
                case DynamicProgrammingProgramTypes.HackerRankCity:
                    DynamicClass.HackerRankCity();
                    break;
                case DynamicProgrammingProgramTypes.SummingPieces:
                    DynamicClass.SummingPieces();
                    break;
                case DynamicProgrammingProgramTypes.MrKmarsh:
                    DynamicClass.MrKmarsh();
                    break;
                case DynamicProgrammingProgramTypes.SubstringDiff:
                    DynamicClass.SubstringDiff();
                    break;
                case DynamicProgrammingProgramTypes.XorandSum:
                    DynamicClass.XorandSum();
                    break;
                case DynamicProgrammingProgramTypes.LegoBlocks:
                    DynamicClass.LegoBlocks();
                    break;
                case DynamicProgrammingProgramTypes.BrickTiling:
                    DynamicClass.BrickTiling();
                    break;
                case DynamicProgrammingProgramTypes.AlienLanguages:
                    DynamicClass.AlienLanguages();
                    break;
                case DynamicProgrammingProgramTypes.StockMaximize:
                    DynamicClass.StockMaximize();
                    break;
                case DynamicProgrammingProgramTypes.TwoRobots:
                    DynamicClass.TwoRobots();
                    break;
                case DynamicProgrammingProgramTypes.CutTree:
                    DynamicClass.CutTree();
                    break;
                case DynamicProgrammingProgramTypes.TarasBeautifulPermutations:
                    DynamicClass.TarasBeautifulPermutations();
                    break;
                case DynamicProgrammingProgramTypes.WetSharkandTwoSubsequences:
                    DynamicClass.WetSharkandTwoSubsequences();
                    break;
                case DynamicProgrammingProgramTypes.NikitaandtheGame:
                    DynamicClass.NikitaandtheGame();
                    break;
                case DynamicProgrammingProgramTypes.ChoosingWhiteBalls:
                    DynamicClass.ChoosingWhiteBalls();
                    break;
                case DynamicProgrammingProgramTypes.MandragoraForest:
                    DynamicClass.MandragoraForest();
                    break;
                case DynamicProgrammingProgramTypes.RedJohnisBack:
                    DynamicClass.RedJohnisBack();
                    break;
                case DynamicProgrammingProgramTypes.LCSReturns:
                    DynamicClass.LCSReturns();
                    break;
                case DynamicProgrammingProgramTypes.GridWalking:
                    DynamicClass.GridWalking();
                    break;
                case DynamicProgrammingProgramTypes.MatrixLand:
                    DynamicClass.MatrixLand();
                    break;
                case DynamicProgrammingProgramTypes.Knapsack:
                    DynamicClass.Knapsack();
                    break;
                case DynamicProgrammingProgramTypes.BricksGame:
                    DynamicClass.BricksGame();
                    break;
                case DynamicProgrammingProgramTypes.TheLongestIncreasingSubsequence:
                    DynamicClass.TheLongestIncreasingSubsequence();
                    break;
                case DynamicProgrammingProgramTypes.CoinontheTable:
                    DynamicClass.CoinontheTable();
                    break;
                case DynamicProgrammingProgramTypes.TheLongestCommonSubsequence:
                    DynamicClass.TheLongestCommonSubsequence();
                    break;
                case DynamicProgrammingProgramTypes.Playwithwords:
                    DynamicClass.Playwithwords();
                    break;
                case DynamicProgrammingProgramTypes.BlackandWhiteTree:
                    DynamicClass.BlackandWhiteTree();
                    break;
                case DynamicProgrammingProgramTypes.CountingSpecialSubCubes:
                    DynamicClass.CountingSpecialSubCubes();
                    break;
                case DynamicProgrammingProgramTypes.IntervalSelection:
                    DynamicClass.IntervalSelection();
                    break;
                case DynamicProgrammingProgramTypes.StringReduction:
                    DynamicClass.StringReduction();
                    break;
                case DynamicProgrammingProgramTypes.FarVertices:
                    DynamicClass.FarVertices();
                    break;
                case DynamicProgrammingProgramTypes.CountingRoadNetworks:
                    DynamicClass.CountingRoadNetworks();
                    break;
                case DynamicProgrammingProgramTypes.SupermanCelebratesDiwali:
                    DynamicClass.SupermanCelebratesDiwali();
                    break;
                case DynamicProgrammingProgramTypes.HexagonalGrid:
                    DynamicClass.HexagonalGrid();
                    break;
                default:
                    break;
            }
        }

        private static void ConstructiveAlgorithmsProgram()
        {
            throw new NotImplementedException();
        }

        private static void BitManipulationProgram()
        {
            throw new NotImplementedException();
        }

        private static void RecursionProgram()
        {
            throw new NotImplementedException();
        }

        private static void GameTheoryProgram()
        {
            throw new NotImplementedException();
        }

        private static void NPCompleteProgram()
        {
            throw new NotImplementedException();
        }
    }
}
