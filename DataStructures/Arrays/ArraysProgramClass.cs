using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Arrays
{
    internal static class ArraysProgramClass
    {
        internal static void ArrayDS()
        {
            Console.ReadLine();
            var intArray = Console.ReadLine().Split(' ').Select(Int32.Parse);
            Console.WriteLine(string.Join(" ", intArray.Reverse()));
        }

        internal static void TwoDArrayDS()
        {
            int[][] intArray = new int[6][];

            for (int i = 0; i < 6; i++)
                intArray[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int MaxSum = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int Sum = intArray[i][j] + intArray[i][j + 1] + intArray[i][j + 2] +
                                  intArray[i + 1][j + 1] +
                                  intArray[i + 2][j] + intArray[i + 2][j + 1] + intArray[i + 2][j + 2];

                    if (Sum > MaxSum) MaxSum = Sum;
                }
            }

            Console.WriteLine(MaxSum);
        }

        internal static void DynamicArray()
        {
            Int64 LastAnswer = 0;
            int[] Info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int NumberOfSequences = Info[0];
            int QueryCount = Info[1];
            List<Int64>[] Sequences;
            Sequences = Enumerable.Range(0, NumberOfSequences).Select((Sequence) => new List<Int64>()).ToArray();

            for (int i = 0; i < QueryCount; i++)
            {
                Int64[] Query = Console.ReadLine().Split().Select(Int64.Parse).ToArray();
                Int64 Ops = Query[0];
                Int64 SeqNum = (Query[1] ^ LastAnswer) % NumberOfSequences;

                if (Ops == 1)
                {
                    Sequences[SeqNum].Add(Query[2]);
                }
                else if (Ops == 2)
                {
                    Int64 index = Query[2] % (Int64)Sequences[SeqNum].Count;
                    LastAnswer = Sequences[SeqNum][(int)index];
                    Console.WriteLine(LastAnswer);
                }

            }

        }

        internal static void LeftRotation()
        {
            int[] Info = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] Input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int InputSize = Info[0];
            int RotateBy = Info[1];
            int[] OutPut = new int[InputSize];

            for (int i = 0; i < InputSize; i++)
            {
                int j = i - RotateBy;

                if (j < 0) j = InputSize + j;

                OutPut[j] = Input[i];
            }
            Console.WriteLine(string.Join(" ", OutPut));
        }

        internal static void SparseArrays()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<string> StringCollection = new List<string>();

            for (int i = 0; i < N; i++)
                StringCollection.Add(Console.ReadLine());

            int Q = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < Q; j++)
            {
                string QStr = Console.ReadLine();
                Console.WriteLine(StringCollection.Count(x => x == QStr));
            }
        }

        internal static void AlgorithmicCrush()
        {
            Int64[] Info = Console.ReadLine().Split().Select(Int64.Parse).ToArray();
            Int64 FinalArraySize = Info[0];
            Int64 NoOfOperations = Info[1];

            Int64[] FinalArray = new Int64[FinalArraySize + 1];

            Int64[] Vals;
            Int64 start;
            Int64 end;
            Int64 Value;
            Int64 x = 0, max = 0;

            // Iterate through all operations
            for (Int64 i = 0; i < NoOfOperations; i++)
            {
                Vals = Console.ReadLine().Split().Select(Int64.Parse).ToArray();
                start = Vals[0] - 1;
                end = Vals[1];
                Value = Vals[2];

                FinalArray[start] += Value;
                FinalArray[end] -= Value;
            }

            foreach (long item in FinalArray)
            {
                x += item;
                if (x > max) max = x;
            }
            Console.WriteLine(max);
        }
    }
}
