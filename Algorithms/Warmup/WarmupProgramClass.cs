using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Warmup
{
    internal class WarmupProgramClass
    {
        internal static void SolveMeFirst()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = val1 + val2;
            Console.WriteLine(sum);
        }

        internal static void SimpleArraySum()
        {
            throw new NotImplementedException();
        }

        internal static void ComparetheTriplets()
        {
            int[] AliceScore = Console.ReadLine().Split().Select(Int32.Parse).ToArray();
            int[] BobScore = Console.ReadLine().Split().Select(Int32.Parse).ToArray();

            int AlicePoints = 0;
            int BobPoints = 0;

            for (int i = 0; i < 3; i++)
            {
                if (AliceScore[i] > BobScore[i])
                    AlicePoints++;
                else if (AliceScore[i] < BobScore[i])
                    BobPoints++;
            }

            Console.WriteLine("{0} {1}", AlicePoints, BobPoints);
        }

        internal static void AVeryBigSum()
        {
            throw new NotImplementedException();
        }

        internal static void DiagonalDifference()
        {
            throw new NotImplementedException();
        }

        internal static void PlusMinus()
        {
            throw new NotImplementedException();
        }

        internal static void Staircase()
        {
            throw new NotImplementedException();
        }

        internal static void MiniMaxSum()
        {
            List<Int64> IntArray = Console.ReadLine().Split().Select(Int64.Parse).ToList();
            IntArray.Sort();

            Int64 Max = IntArray.Skip(1).Sum();
            Int64 Min = Max + IntArray.First() - IntArray.Last();

            Console.WriteLine("{0} {1}", Min, Max);
        }

        internal static void BirthdayCakeCandles()
        {
            Console.ReadLine();
            var N = Console.ReadLine().Split().Select(Int32.Parse).OrderByDescending(x => x).ToArray();
            Console.WriteLine(N.Count(n => n == N.First()));
        }

        internal static void TimeConversion()
        {
            throw new NotImplementedException();
        }
    }
}
