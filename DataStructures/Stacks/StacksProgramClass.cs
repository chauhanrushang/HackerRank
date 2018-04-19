using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Stacks
{
    internal static class StacksProgramClass
    {
        internal static void MaximumElement()
        {
            int TotalOps = Convert.ToInt32(Console.ReadLine());
            Stack<int> Stack = new Stack<int>();
            Stack<int> Max = new Stack<int>();
            Max.Push(int.MinValue);

            for (int i = 0; i < TotalOps; i++)
            {
                var OpsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (OpsArray[0] == 1)
                {
                    if (OpsArray[1] >= Max.Peek())
                        Max.Push(OpsArray[1]);
                    Stack.Push(OpsArray[1]);
                }
                else if (OpsArray[0] == 2)
                {
                    if (Max.Peek() == Stack.Pop())
                        Max.Pop();
                }
                else if (OpsArray[0] == 3)
                    Console.WriteLine(Max.Peek());
            }
        }

        internal static void BalancedBrackets()
        {
            int Iterations = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < Iterations; i++)
            {
                var CharArray = Console.ReadLine().ToCharArray();
                Stack<char> CharStack = new Stack<char>();

                string Result = "YES";
                foreach (var item in CharArray)
                {
                    if (item == '(' || item == '[' || item == '{')
                    {
                        CharStack.Push(item);
                    }
                    else
                    {
                        if (CharStack.Count <= 0)
                        {
                            Result = "NO";
                            break;
                        }
                        if (!((item == ')' && CharStack.Peek() == '(') ||
                              (item == '}' && CharStack.Peek() == '{') ||
                              (item == ']' && CharStack.Peek() == '[')))
                        {
                            Result = "NO";
                            break;
                        }
                        CharStack.Pop();
                    }
                }
                if (CharStack.Count != 0) Result = "NO";
                Console.WriteLine(Result);
            }
        }

        internal static void EqualStacks()
        {
            int[] StacksSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> FirstStack = new Stack<int>(Console.ReadLine().Split().Select(Int32.Parse));
            Stack<int> SecondStack = new Stack<int>(Console.ReadLine().Split().Select(Int32.Parse));
            Stack<int> ThirdStack = new Stack<int>(Console.ReadLine().Split().Select(Int32.Parse));

            int[] SumOne = new int[StacksSize[0]];
            int[] SumTwo = new int[StacksSize[1]];
            int[] SumThree = new int[StacksSize[2]];
            int[] Prev = new int[3];
            for (int i = StacksSize.Max() - 1; i >= 0; i--)
            {
                if (StacksSize[0] > i)
                {
                    SumOne[i] += FirstStack.Pop() + Prev[0];
                    Prev[0] = SumOne[i];
                }

                if (StacksSize[1] > i)
                {
                    SumTwo[i] += SecondStack.Pop() + Prev[1];
                    Prev[1] = SumTwo[i];
                }

                if (StacksSize[2] > i)
                {
                    SumThree[i] += ThirdStack.Pop() + Prev[2];
                    Prev[2] = SumThree[i];
                }
            }

            int Val = SumOne.Intersect(SumTwo).Intersect(SumThree).FirstOrDefault();
            Console.WriteLine(Val);
        }

        internal static void GameofTwoStacks()
        {
            // Incomplete
            int NoOfGames = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NoOfGames; i++)
            {
                Int64[] Info = Console.ReadLine().Split().Select(Int64.Parse).ToArray();
                int nA = (int)Info[0];
                int nB = (int)Info[1];
                Int64 x = Info[2];

                Stack<Int64> StackA = new Stack<Int64>(Console.ReadLine().Split().Select(Int64.Parse).Reverse());
                Stack<Int64> StackB = new Stack<Int64>(Console.ReadLine().Split().Select(Int64.Parse).Reverse());

                int TotalElements = 0;

                while (x >= 0)
                {

                    if (nA == 0 && nB == 0)
                    {
                        TotalElements++;
                        break;
                    }
                    else if (nB == 0 || StackA.Peek() < StackB.Peek())
                    {
                        x -= StackA.Pop();
                        nA--;
                    }
                    else
                    {
                        x -= StackB.Pop();
                        nB--;
                    }

                    TotalElements++;
                }

                Console.WriteLine(--TotalElements);
            }
        }

        internal static void LargestRectangle()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] heightsArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> heightStack = new Stack<int>();
            int MaxRectWidth = Int32.MinValue;

            foreach (int item in heightsArray)
                heightStack.Push(item);

            for (int i = 1; i < N + 1; i++)
            {
                int CurrWidth = heightStack.Pop() * i;
                if (MaxRectWidth < CurrWidth) MaxRectWidth = CurrWidth;
            }

            Console.WriteLine(MaxRectWidth);
        }

        internal static void SimpleTextEditor()
        {
            throw new NotImplementedException();
        }

        internal static void PoisonousPlants()
        {
            throw new NotImplementedException();
        }

        internal static void ANDxorOR()
        {
            throw new NotImplementedException();
        }

        internal static void Waiter()
        {
            throw new NotImplementedException();
        }
    }
}
