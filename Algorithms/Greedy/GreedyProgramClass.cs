using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Greedy
{
    public static class GreedyProgramClass
    {

        /// <summary>
        /// Minimum Absolute Difference in an Array
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/minimum-absolute-difference-in-an-array/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void MinimumAbsoluteDifferenceinanArray()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Arr = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            int MinDiff = int.MaxValue;

            for (int i = 0; i < N - 1; i++)
                if (Math.Abs(Arr[i + 1] - Arr[i]) < MinDiff)
                    MinDiff = Math.Abs(Arr[i + 1] - Arr[i]);

            Console.WriteLine(MinDiff);
        }


        /// <summary>
        /// Marc's Cakewalk
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/marcs-cakewalk/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void MarcsCakewalk()
        {
            Console.ReadLine();
            int[] CaloriesArray = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToArray();
            double result = 0;

            for (int i = 0; i < CaloriesArray.Length; i++)
                result += CaloriesArray[i] * Math.Pow(2, (double)i);

            Console.WriteLine(result);
        }


        /// <summary>
        /// Grid Challenge
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/grid-challenge/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void GridChallenge()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            while (t-- > 0)
            {
                int N = Convert.ToInt32(Console.ReadLine());
                char[][] Matrix = new char[N][];
                bool IsSorted = true;

                for (int i = 0; i < N; i++)
                    Matrix[i] = Console.ReadLine().OrderBy(x => x).ToArray();

                for (int x = 0; x < N; x++)
                {
                    for (int y = 0; y < N - 1; y++)
                    {
                        if (Matrix[y][x] > Matrix[y + 1][x])
                        {
                            IsSorted = false;
                            break;
                        }
                    }
                    if (!IsSorted) break;
                }

                Console.WriteLine(IsSorted ? "YES" : "NO");
            }
        }

        internal static void LuckBalance()
        {
            throw new NotImplementedException();
        }

        internal static void MaximumPerimeterTriangle()
        {
            throw new NotImplementedException();
        }

        internal static void BeautifulPairs()
        {
            throw new NotImplementedException();
        }

        internal static void SherlockandTheBeast()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Priyanka and Toys
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/priyanka-and-toys/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void PriyankaandToys()
        {
            Console.ReadLine();
            int[] ToyWeights = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            int NumberOfBoxes = 0;
            int minWeight = Int32.MinValue;

            foreach (int weight in ToyWeights)
            {
                if (weight > minWeight + 4)
                {
                    minWeight = weight;
                    NumberOfBoxes++;
                }
            }

            Console.WriteLine(NumberOfBoxes);
        }

        internal static void LargestPermutation()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Mark and Toys
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/mark-and-toys/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void MarkandToys()
        {
            int[] N = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int Amount = N[1];
            int[] ToyPrices = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            int result = 0;

            foreach (int i in ToyPrices)
            {
                Amount -= i;
                if (Amount < 0)
                    break;
                result++;
            }

            Console.WriteLine(result);

        }


        /// <summary>
        /// Greedy Florist
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/greedy-florist/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void GreedyFlorist()
        {
            int[] N = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int flowersNum = N[0];
            int friendsNum = N[1];
            int[] FlowerRates = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToArray();
            int rounds = (int)Math.Ceiling((decimal)flowersNum / friendsNum);
            int MinAmt = 0;

            while (rounds > 0)
            {
                MinAmt += FlowerRates.Skip(friendsNum * (rounds - 1)).Take(friendsNum).Sum() * rounds;
                rounds--;
            }
            Console.WriteLine(MinAmt);
        }

        internal static void MaxMin()
        {
            throw new NotImplementedException();
        }

        internal static void JimandtheOrders()
        {
            throw new NotImplementedException();
        }

        internal static void PermutingTwoArrays()
        {
            throw new NotImplementedException();
        }

        internal static void CuttingBoards()
        {
            throw new NotImplementedException();
        }

        internal static void ReverseShuffleMerge()
        {
            throw new NotImplementedException();
        }

        internal static void ChiefHopper()
        {
            throw new NotImplementedException();
        }

        internal static void SherlockandMiniMax()
        {
            throw new NotImplementedException();
        }

        internal static void AccessoryCollection()
        {
            throw new NotImplementedException();
        }

        internal static void TeamFormation()
        {
            throw new NotImplementedException();
        }

        internal static void FightingPits()
        {
            throw new NotImplementedException();
        }

        internal static void GoodlandElectricity()
        {
            throw new NotImplementedException();
        }

        internal static void CloudyDay()
        {
            throw new NotImplementedException();
        }
    }
}
