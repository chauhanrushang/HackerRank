using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Queues
{
    static class QueueProgramClass
    {
        #region Queue using Two Stacks Implementation
        private static Stack<Int32> _S1 = new Stack<int>();
        private static Stack<Int32> _S2 = new Stack<int>();

        internal static void QueueusingTwoStacks()
        {
            int Ops = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < Ops; i++)
            {
                int[] N = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (N[0] == 1) Enqueue(N[1]);
                else if (N[0] == 2) Dequeue();
                else Print();
            }
        }

        private static void Enqueue(int item)
        {
            _S1.Push(item);
        }

        private static void Dequeue()
        {
            CheckSecondaryStack();

            _S2.Pop();
        }
        
        private static void Print()
        {
            CheckSecondaryStack();
            Console.WriteLine(_S2.Peek());
        }

        private static void CheckSecondaryStack()
        {
            if (!_S2.Any())
                while (_S1.Any())
                    _S2.Push(_S1.Pop());
        }


        #endregion

        internal static void CastleontheGrid()
        {
            throw new NotImplementedException();
        }

        internal static void DowntoZeroII()
        {
            throw new NotImplementedException();
        }

        internal static void TruckTour()
        {
            throw new NotImplementedException();
        }

        internal static void QuerieswithFixedLength()
        {
            throw new NotImplementedException();
        }
    }
}
