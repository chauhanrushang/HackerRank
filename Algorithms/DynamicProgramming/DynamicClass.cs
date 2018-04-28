using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DynamicProgramming
{
    public static class DynamicClass
    {

        #region The Coin Change Problem
        /// <summary>
        /// The Coin Change Problem
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/coin-change/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void TheCoinChangeProblem()
        {
            int[] N = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int Amount = N[0];
            int[] Coins = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToArray();
            Console.WriteLine(makeChange(Coins, Amount));
        }

        // Calling recursive function
        private static Int64 makeChange(int[] coins, int amount)
        {
            return makeChange(coins, amount, 0, new Dictionary<string, Int64>());
        }

        // Dynamic Approach
        private static Int64 makeChange(int[] coins, int amount, int index, Dictionary<string, Int64> hashMap)
        {
            // Edge Cases.
            if (amount == 0) return 1;
            if (index >= coins.Length) return 0;

            string Key = $"{amount} : {index}";
            if (hashMap.ContainsKey(Key))
                return hashMap[Key];

            Int64 Ways = 0;
            int AmountWithCoins = 0;

            while (AmountWithCoins <= amount)
            {
                int remainingAmt = amount - AmountWithCoins;
                Ways += makeChange(coins, remainingAmt, index + 1, hashMap);
                AmountWithCoins += coins[index];
            }

            hashMap[Key] = Ways;
            return Ways;
        }
        #endregion

        internal static void Equal()
        {
            throw new NotImplementedException();
        }

        internal static void SherlockandCost()
        {
            throw new NotImplementedException();
        }

        internal static void ConstructtheArray()
        {
            throw new NotImplementedException();
        }

        internal static void KingdomDivision()
        {
            throw new NotImplementedException();
        }

        internal static void Candies()
        {
            throw new NotImplementedException();
        }

        internal static void Samandsubstrings()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fibonacci Modified
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/fibonacci-modified/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void FibonacciModified()
        {
            int[] N = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            BigInteger t1 = N[0];
            BigInteger t2 = N[1];
            BigInteger result = 0;
            int Count = N[2];

            while (Count-- > 2)
            {
                result = t1 + t2 * t2;
                t1 = t2;
                t2 = result;
            }

            Console.WriteLine(result);
        }

        internal static void Abbreviation()
        {
            throw new NotImplementedException();
        }

        internal static void PrimeXOR()
        {
            throw new NotImplementedException();
        }

        internal static void DecibinaryNumbers()
        {
            throw new NotImplementedException();
        }

        internal static void FairCut()
        {
            throw new NotImplementedException();
        }

        internal static void TheMaximumSubarray()
        {
            throw new NotImplementedException();
        }

        internal static void AngryChildren2()
        {
            throw new NotImplementedException();
        }

        internal static void SherlocksArrayMergingAlgorithm()
        {
            throw new NotImplementedException();
        }

        internal static void PrimeDigitSums()
        {
            throw new NotImplementedException();
        }

        internal static void HackerRankCity()
        {
            throw new NotImplementedException();
        }

        internal static void SummingPieces()
        {
            throw new NotImplementedException();
        }

        internal static void MrKmarsh()
        {
            throw new NotImplementedException();
        }

        internal static void SubstringDiff()
        {
            throw new NotImplementedException();
        }

        internal static void XorandSum()
        {
            throw new NotImplementedException();
        }

        internal static void LegoBlocks()
        {
            throw new NotImplementedException();
        }

        internal static void BrickTiling()
        {
            throw new NotImplementedException();
        }

        internal static void AlienLanguages()
        {
            throw new NotImplementedException();
        }

        internal static void StockMaximize()
        {
            throw new NotImplementedException();
        }

        internal static void TwoRobots()
        {
            throw new NotImplementedException();
        }

        internal static void CutTree()
        {
            throw new NotImplementedException();
        }

        internal static void TarasBeautifulPermutations()
        {
            throw new NotImplementedException();
        }

        internal static void WetSharkandTwoSubsequences()
        {
            throw new NotImplementedException();
        }

        internal static void NikitaandtheGame()
        {
            throw new NotImplementedException();
        }

        internal static void ChoosingWhiteBalls()
        {
            throw new NotImplementedException();
        }

        internal static void MandragoraForest()
        {
            throw new NotImplementedException();
        }

        internal static void RedJohnisBack()
        {
            throw new NotImplementedException();
        }

        internal static void LCSReturns()
        {
            throw new NotImplementedException();
        }

        internal static void GridWalking()
        {
            throw new NotImplementedException();
        }

        internal static void MatrixLand()
        {
            throw new NotImplementedException();
        }

        internal static void Knapsack()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// The Longest Increasing Subsequence
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/longest-increasing-subsequent/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void TheLongestIncreasingSubsequence()
        {


            #region N^2 time using Dynamic Programming
                /*
                int N = Convert.ToInt32(Console.ReadLine());
                int[] Arr = new int[N];
                int[] SeqLen = new int[N];

                // Read input
                for (int x = 0; x < N; x++)
                    Arr[x] = Convert.ToInt32(Console.ReadLine());

                // Intialize Array
                for (int y = 0; y < N; y++)
                    SeqLen[y] = 1;

                for (int j = 1; j < N; j++)
                    for (int k = 0; k < j; k++)
                        if (Arr[k] < Arr[j])
                            SeqLen[j] = Math.Max(1 + SeqLen[k], SeqLen[j]);

                Console.WriteLine(SeqLen.Max());
                */
            #endregion
        }

        internal static void CoinontheTable()
        {
            throw new NotImplementedException();
        }

        internal static void TheLongestCommonSubsequence()
        {
            throw new NotImplementedException();
        }

        internal static void BricksGame()
        {
            throw new NotImplementedException();
        }

        internal static void Playwithwords()
        {
            throw new NotImplementedException();
        }

        internal static void CountingSpecialSubCubes()
        {
            throw new NotImplementedException();
        }

        internal static void BlackandWhiteTree()
        {
            throw new NotImplementedException();
        }

        internal static void IntervalSelection()
        {
            throw new NotImplementedException();
        }

        internal static void StringReduction()
        {
            throw new NotImplementedException();
        }

        internal static void FarVertices()
        {
            throw new NotImplementedException();
        }

        internal static void CountingRoadNetworks()
        {
            throw new NotImplementedException();
        }

        internal static void SupermanCelebratesDiwali()
        {
            throw new NotImplementedException();
        }

        internal static void HexagonalGrid()
        {
            throw new NotImplementedException();
        }
    }
}
