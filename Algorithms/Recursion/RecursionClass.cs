using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Recursion
{
    public static class RecursionClass
    {

        #region The Power Sum

        /// <summary>
        /// The Power Sum
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/the-power-sum/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void ThePowerSum()
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());
            int Result = ComputePowerSum(X, N, 1);
            Console.WriteLine(Result);
        }

        private static int ComputePowerSum(int X, int N, int num)
        {
            if ((int)Math.Pow(num, N) > X) return 0;
            if ((int)Math.Pow(num, N) == X) return 1;
            return ComputePowerSum(X, N, num + 1) + ComputePowerSum(X - (int)Math.Pow(num, N), N, num + 1);
        }

        #endregion

        internal static void CrosswordPuzzle()
        {
            throw new NotImplementedException();
        }

        #region Recursive Digit Sum

        /// <summary>
        /// Recursive Digit Sum
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/recursive-digit-sum/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void RecursiveDigitSum()
        {
            string[] X = Console.ReadLine().Split(' ').ToArray();
            string S = (X[0].Select(x => Convert.ToInt32(x) - 48).Sum() * Convert.ToInt64(X[1])).ToString();
            int Result = ComputeSuperDigit(S);
            Console.WriteLine(Result);
        }

        private static int ComputeSuperDigit(string S)
        {
            int[] N = S.Select(x => Convert.ToInt32(x) - 48).ToArray();
            if (N.Count() <= 1) return N.First();
            return ComputeSuperDigit(N.Sum().ToString());
        }
        #endregion

        internal static void SimplifiedChessEngine()
        {
            throw new NotImplementedException();
        }


        #region Password Cracker
        /// <summary>
        /// Password Cracker
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/password-cracker/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void PasswordCracker()
        {
            throw new NotImplementedException("Some testcases are still failing.");
            int T = Convert.ToInt32(Console.ReadLine());

            while (T-- > 0)
            {
                int N = Convert.ToInt32(Console.ReadLine());
                string[] PassArray = Console.ReadLine().Split(' ').OrderByDescending(s => s.Length).ToArray();
                string loginAttempt = Console.ReadLine();
                string result = ComputePasswordOrder(loginAttempt, PassArray).Trim();
                Console.WriteLine(loginAttempt != result.Replace(" ", "") ? "WRONG PASSWORD" : result);
            }
        }

        private static string ComputePasswordOrder(string loginAttempt, string[] passArray)
        {
            if (string.IsNullOrEmpty(loginAttempt)) return string.Empty;
            string Result = string.Empty;

            foreach (string pass in passArray)
            {
                if (!loginAttempt.StartsWith(pass))
                    continue;

                Result = pass;
                loginAttempt = loginAttempt.Substring(pass.Length);
                break;
            }

            if (string.IsNullOrEmpty(Result)) return string.Empty;

            Result = Result + " " + ComputePasswordOrder(loginAttempt, passArray);

            return Result;
        } 
        #endregion

        internal static void ArithmeticExpressions()
        {
            throw new NotImplementedException();
        }

        internal static void StoneDivisionRevisited()
        {
            throw new NotImplementedException();
        }

        internal static void KFactorization()
        {
            throw new NotImplementedException();
        }

        internal static void BowlingPins()
        {
            throw new NotImplementedException();
        }

        internal static void SimplifiedChessEngineII()
        {
            throw new NotImplementedException();
        }

        internal static void RepetitiveKSums()
        {
            throw new NotImplementedException();
        }
    }
}
