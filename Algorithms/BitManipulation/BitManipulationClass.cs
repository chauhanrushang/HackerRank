using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.BitManipulation
{
    public class BitManipulationClass
    {

        /// <summary>
        /// Lonely Integer
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/lonely-integer/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void LonelyInteger()
        {
            Console.ReadLine();
            IEnumerable<int> Input = Console.ReadLine().Split(' ').Select(int.Parse);
            int result = 0;

            foreach (int i in Input)
                result ^= i;

            Console.WriteLine(result);

        }


        /// <summary>
        /// Maximizing XOR
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/maximizing-xor/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void MaximizingXOR()
        {
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            int result = 0;

            for (int i = a; i <= b; i++)
                for (int j = a; j <= b; j++)
                    result = result > (i ^ j) ? result : (i ^ j);

            Console.WriteLine(result);
        }

        internal static void Countergame()
        {
            throw new NotImplementedException();
        }

        internal static void Xorsequence()
        {
            throw new NotImplementedException();
        }

        internal static void SumvsXOR()
        {
            throw new NotImplementedException();
        }

        internal static void TheGreatXOR()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Flipping bits
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/flipping-bits/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void Flippingbits()
        {
            Int16 N = Convert.ToInt16(Console.ReadLine());
            while (N-- > 0) Console.WriteLine(~Convert.ToUInt32(Console.ReadLine()));
        }

        internal static void YetAnotherMinimaxProblem()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Sansa and XOR
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/sansa-and-xor/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void SansaandXOR()
        {
            int T = Convert.ToInt16(Console.ReadLine());

            while (T-- > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"n = {n}");
                int[] Arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine($"Arr = {string.Join(",",Arr)}");
                int result = Arr[0];

                for (int i = 2; i < n; i += 2)
                    result ^= Arr[i];

                Console.WriteLine(result);
            }
        }

        internal static void ANDProduct()
        {
            throw new NotImplementedException();
        }

        internal static void WinningLotteryTicket()
        {
            throw new NotImplementedException();
        }

        internal static void XoringNinja()
        {
            throw new NotImplementedException();
        }

        internal static void Cipher()
        {
            throw new NotImplementedException();
        }

        internal static void XORMatrix()
        {
            throw new NotImplementedException();
        }

        internal static void WhatsNext()
        {
            throw new NotImplementedException();
        }

        internal static void StringTransmission()
        {
            throw new NotImplementedException();
        }

        internal static void AorB()
        {
            throw new NotImplementedException();
        }

        internal static void ManipulativeNumbers()
        {
            throw new NotImplementedException();
        }

        internal static void StoneGame()
        {
            throw new NotImplementedException();
        }

        internal static void Tscomplement()
        {
            throw new NotImplementedException();
        }

        internal static void ChangingBits()
        {
            throw new NotImplementedException();
        }

        internal static void XORkey()
        {
            throw new NotImplementedException();
        }

        internal static void MaximizingtheFunction()
        {
            throw new NotImplementedException();
        }

        internal static void XORSubsequences()
        {
            throw new NotImplementedException();
        }

        internal static void IterateIt()
        {
            throw new NotImplementedException();
        }

        internal static void HammingDistance()
        {
            throw new NotImplementedException();
        }

        internal static void Mixingproteins()
        {
            throw new NotImplementedException();
        }
    }
}
