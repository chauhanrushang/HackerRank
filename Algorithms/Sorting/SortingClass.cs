using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public static class SortingClass
    {
        internal static void BigSorting()
        {
            throw new NotImplementedException();
        }

        internal static void IntrotoTutorialChallenges()
        {
            throw new NotImplementedException();
        }

        internal static void InsertionSortPart1()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] NumArray = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int Temp = NumArray[N - 1];
            int i;

            // Insertion Sort
            for (i = N - 1; i > 0 && NumArray[i - 1] > Temp; i--)
            {
                NumArray[i] = NumArray[i - 1];
                Console.WriteLine(string.Join(" ", NumArray));
            }

            NumArray[i] = Temp;
            Console.WriteLine(string.Join(" ", NumArray));
        }

        internal static void InsertionSortPart2()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] NumArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // Insertion Sort
            for (int j = 1; j < N; j++)
            {
                int Temp = NumArray[j];
                int i;

                for (i = j; i > 0 && NumArray[i - 1] > Temp; i--)
                    NumArray[i] = NumArray[i - 1];

                NumArray[i] = Temp;
                Console.WriteLine(string.Join(" ", NumArray));
            }
        }

        internal static void CorrectnessandtheLoopInvariant()
        {
            Console.ReadLine();
            int[] A = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
            var j = 0;
            for (var i = 1; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j >= 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", A));
        }

        internal static void RunningTimeofAlgorithms()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] NumArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int shifts = 0;

            // Insertion Sort
            for (int j = 1; j < N; j++)
            {
                int Temp = NumArray[j];
                int i;

                for (i = j; i > 0 && NumArray[i - 1] > Temp; i--)
                {
                    NumArray[i] = NumArray[i - 1];
                    shifts++;
                }
                NumArray[i] = Temp;

            }
            Console.WriteLine(shifts);
        }

        internal static void Quicksort1Partition()
        {
            Console.ReadLine();
            List<int> A = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> LTA = new List<int>();
            List<int> GTA = new List<int>();

            foreach (int i in A.Skip(1))
            {
                if (i < A[0])
                    LTA.Add(i);
                else
                    GTA.Add(i);
            }
            LTA.Add(A[0]);
            Console.WriteLine(string.Join(" ", LTA.Concat(GTA)));
        }

        // Method
        private static int[] Partition(int[] A, int low, int up)
        {
            int i, j, pivot, temp;

            pivot = A[low];
            i = low + 1;
            j = up;

            while (i <= j)
            {
                while (A[i] < pivot && i < up) i++;
                while (A[j] > pivot) j--;

                if (i < j)
                {
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                    i++;
                    j--;
                }
                else
                    break;
            }

            A[low] = A[j];
            A[j] = pivot;

            return A;
        }

        internal static void CountingSort1()
        {
            Console.ReadLine();
            IEnumerable<int> NumArray = Console.ReadLine().Split(' ').Select(int.Parse);
            int[] Numbers = new int[100];

            foreach (int i in NumArray)
            {
                Numbers[i]++;
            }

            Console.WriteLine(string.Join(" ", Numbers));
        }

        internal static void CountingSort2()
        {
            throw new NotImplementedException();
        }

        internal static void TheFullCountingSort()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<Tuple<int, string>> IntStringPair = new List<Tuple<int, string>>();
            string[] Arr;

            for (int i = 0; i < N; i++)
            {
                Arr = Console.ReadLine().Split(' ');
                if ((i + 1) <= N / 2)
                    IntStringPair.Add(new Tuple<int, string>(Convert.ToInt32(Arr[0]), "-"));
                else
                    IntStringPair.Add(new Tuple<int, string>(Convert.ToInt32(Arr[0]), Arr[1]));
            }

            List<Tuple<int, string>> result = InsertionSortForFullCountingSort(IntStringPair);

            StringBuilder sb = new StringBuilder();

            foreach (var item in result)
            {
                sb.Append(item.Item2 + " ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }

        private static List<Tuple<int, string>> InsertionSortForFullCountingSort(List<Tuple<int, string>> intStringPair)
        {
            // Insertion Sort Implementation
            for (int i = 1; i < intStringPair.Count; i++)
            {
                Tuple<int, string> Key = intStringPair[i];
                int j = i - 1;

                while (j >= 0 && intStringPair[j].Item1 > Key.Item1)
                {
                    intStringPair[j + 1] = intStringPair[j];
                    j--;
                }
                intStringPair[j + 1] = Key;
            }

            return intStringPair;
        }

        internal static void ClosestNumbers()
        {
            throw new NotImplementedException();
        }

        internal static void FindtheMedian()
        {
            throw new NotImplementedException();
        }

        internal static void InsertionSortAdvancedAnalysis()
        {
            throw new NotImplementedException();
        }

        internal static void FraudulentActivityNotifications()
        {
            throw new NotImplementedException();
        }

        internal static void LilysHomework()
        {
            int j = 0;
            Console.ReadLine();
            IEnumerable<int> Nums = Console.ReadLine().Split(' ').Select(int.Parse);
            Dictionary<int, int> NumAndIndex = new Dictionary<int, int>();
            
            foreach (int num in Nums) NumAndIndex.Add(num, j++);

           


        }


    }
}
