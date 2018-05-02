using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Strings
{
    public static class StringsClass
    {
        internal static void SuperReducedString()
        {
            var CharArray = Console.ReadLine().ToCharArray();
            var NewCharArray = SuperReducedString(CharArray);

            if (NewCharArray.Any())
                Console.WriteLine(string.Join("", NewCharArray));
            else
                Console.WriteLine("Empty String");
        }

        private static IEnumerable<char> SuperReducedString(char[] CharArray)
        {
            int N = CharArray.Count();

            for (int i = 1; i < N; i++)
            {
                if (CharArray[i - 1] == CharArray[i])
                {
                    CharArray[i - 1] = '0';
                    CharArray[i] = '0';
                    i++;
                }
            }

            var NewCharArray = CharArray.Where(c => c != '0').ToArray();

            if (CharArray.Count() > NewCharArray.Count()) SuperReducedString(NewCharArray);
            return NewCharArray;
        }

        internal static void CamelCase()
        {
            var CharArray = Encoding.Default.GetBytes(Console.ReadLine().ToCharArray());
            int WordCount = 1;
            foreach (var item in CharArray)
            {
                if ((int)item <= 90)
                    WordCount++;
            }

            Console.WriteLine(WordCount);
        }

        internal static void StrongPassword()
        {
            string numbers = "0123456789";
            string lower_case = "abcdefghijklmnopqrstuvwxyz";
            string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";

            Console.ReadLine();
            string Password = Console.ReadLine();
            int MinCharReq = 0;

            if (!Password.Intersect(numbers.ToCharArray()).Any()) MinCharReq++;
            if (!Password.Intersect(lower_case.ToCharArray()).Any()) MinCharReq++;
            if (!Password.Intersect(upper_case.ToCharArray()).Any()) MinCharReq++;
            if (!Password.Intersect(special_characters.ToCharArray()).Any()) MinCharReq++;

            MinCharReq = Math.Max(6 - Password.Length, MinCharReq);

            Console.WriteLine(MinCharReq);
        }

        internal static void CaesarCipher()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Mars Exploration
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/mars-exploration/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void MarsExploration()
        {
            char[] Message = Console.ReadLine().ToCharArray();
            char[] S = { 'S', 'O', 'S' };
            int i = 0;
            int result = 0;

            foreach (char c in Message)
            {
                if (c != S[i])
                    result++;

                i = i == 2 ? 0 : ++i;
            }

            Console.WriteLine(result);
        }


        /// <summary>
        /// HackerRank in a String!
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void HackerRankinaString()
        {
            int Queries = Convert.ToInt32(Console.ReadLine());
            char[] word = "hackerrank".ToCharArray();

            while (Queries-- > 0)
            {
                char[] Input = Console.ReadLine().ToCharArray();
                int i = 0;

                foreach (char C in Input)
                {
                    if (C == word[i])
                    {
                        i++;

                        if (i > word.Length - 1)
                            break;
                    }
                }

                Console.WriteLine((i > word.Length - 1 ? "YES" : "NO"));
            }
        }

        internal static void Pangrams()
        {
            throw new NotImplementedException();
        }

        internal static void WeightedUniformStrings()
        {
            throw new NotImplementedException();
        }

        internal static void SeparatetheNumbers()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Funny String
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/funny-string/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void FunnyString()
        {
            int TestCases = Convert.ToInt32(Console.ReadLine());

            while (TestCases-- > 0)
            {
                char[] S = Console.ReadLine().ToCharArray();
                char[] R = S.Reverse().ToArray();
                bool IsFunny = true;

                for (int i = 0; i < S.Length - 1; i++)
                {
                    if (Math.Abs(S[i + 1] - S[i]) != Math.Abs(R[i + 1] - R[i]))
                    {
                        IsFunny = false;
                        break;
                    }
                }

                Console.WriteLine(IsFunny ? "Funny" : "Not Funny");
            }
        }


        /// <summary>
        /// Gemstones
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/gem-stones/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void Gemstones()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            List<char> Gemstones = new List<char>();

            for (int i = 0; i < N; i++)
                Gemstones.AddRange(Console.ReadLine().ToCharArray().Distinct());

            Console.WriteLine(Gemstones.GroupBy(x => x).Where(x => x.Count() == N).Count());
        }


        /// <summary>
        /// Alternating Characters 
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/alternating-characters/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void AlternatingCharacters()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            while (N-- > 0)
            {
                char[] Input = Console.ReadLine().ToCharArray();
                char Prev = ' ';
                int DelCount = 0;

                foreach (char c in Input)
                {
                    if (Prev == c)
                        DelCount++;
                    else
                        Prev = c;
                }

                Console.WriteLine(DelCount);
            }
        }


        /// <summary>
        /// Beautiful Binary String
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/beautiful-binary-string/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void BeautifulBinaryString()
        {
            Console.ReadLine();
            string S = Console.ReadLine();
            Console.WriteLine((S.Length - S.Replace("010", "").Length) / 3);
        }


        /// <summary>
        /// The Love-Letter Mystery
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/the-love-letter-mystery/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void TheLoveLetterMystery()
        {
            int TestCases = Convert.ToInt32(Console.ReadLine());

            while (TestCases-- > 0)
            {
                char[] S = Console.ReadLine().ToCharArray();
                int N = (S.Length / 2) - 1;
                int Count = 0;

                for (int i = 0, j = S.Length - 1; i <= N && j >= N; i++, j--)
                    Count += Math.Abs(Convert.ToInt32(S[i]) - Convert.ToInt32(S[j]));

                Console.WriteLine(Count);

            }
        }

        internal static void DeterminingDNAHealth()
        {
            throw new NotImplementedException();
        }

        internal static void PalindromeIndex()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Anagram
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/anagram/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void Anagram()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            while (N-- > 0)
            {
                string S = Console.ReadLine();
                if (S.Length % 2 != 0)
                {
                    Console.WriteLine("-1");
                    continue;
                }

                int[] Count1 = new int[26];
                int[] Count2 = new int[26];
                int Count = 0;
                char[] S1 = S.Substring(0, (S.Length / 2) - 1).ToCharArray();
                char[] S2 = S.Substring(S.Length / 2).ToCharArray();

                foreach (char c in S1)
                    Count1[Convert.ToInt32(c) - 'a']++;

                foreach (char c in S2)
                    Count2[Convert.ToInt32(c) - 'a']++;

                for (int i = 0; i < 26; i++)
                    Count += Math.Abs(Count1[i] - Count2[i]);

                Console.WriteLine(Count / 2);
            }
        }


        /// <summary>
        /// Making Anagrams
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/making-anagrams/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void MakingAnagrams()
        {
            char[] S1 = Console.ReadLine().ToCharArray();
            char[] S2 = Console.ReadLine().ToCharArray();
            int[] Count1 = new int[26];
            int[] Count2 = new int[26];
            int Count = 0;

            foreach (char c in S1)
                Count1[Convert.ToInt32(c) - 'a']++;

            foreach (char c in S2)
                Count2[Convert.ToInt32(c) - 'a']++;

            for (int i = 0; i < 26; i++)
                Count += Math.Abs(Count1[i] - Count2[i]);

            Console.WriteLine(Count);
        }


        /// <summary>
        /// Game of Thrones - I
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/game-of-thrones/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void GameofThronesI()
        {
            Console.WriteLine(Console.ReadLine().GroupBy(x => x).Count(x => x.Count() % 2 != 0) > 1 ? "NO" : "YES");
        }


        /// <summary>
        /// Two Strings
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/two-strings/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void TwoStrings()
        {
            int N = Convert.ToInt32(Console.ReadLine());

            while (N-- > 0)
            {
                char[] S1 = Console.ReadLine().ToCharArray();
                char[] S2 = Console.ReadLine().ToCharArray();

                if (S1.Intersect(S2).Any())
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        internal static void SherlockandtheValidString()
        {
            throw new NotImplementedException();
        }

        internal static void RichieRich()
        {
            throw new NotImplementedException();
        }

        internal static void SherlockandAnagrams()
        {
            throw new NotImplementedException();
        }

        internal static void CommonChild()
        {
            throw new NotImplementedException();
        }

        internal static void BearandSteadyGene()
        {
            throw new NotImplementedException();
        }

        internal static void MorganandaString()
        {
            throw new NotImplementedException();
        }

        internal static void CountStrings()
        {
            throw new NotImplementedException();
        }

        internal static void StringFunctionCalculation()
        {
            throw new NotImplementedException();
        }

        internal static void BuildaPalindrome()
        {
            throw new NotImplementedException();
        }

        internal static void BuildaString()
        {
            throw new NotImplementedException();
        }

        internal static void GridlandProvinces()
        {
            throw new NotImplementedException();
        }

        internal static void AshtonandString()
        {
            throw new NotImplementedException();
        }

        internal static void StringSimilarity()
        {
            throw new NotImplementedException();
        }

        internal static void SuperFunctionalStrings()
        {
            throw new NotImplementedException();
        }

        internal static void CircularPalindromes()
        {
            throw new NotImplementedException();
        }

        internal static void SimilarStrings()
        {
            throw new NotImplementedException();
        }

        internal static void SaveHumanity()
        {
            throw new NotImplementedException();
        }

        internal static void FindStrings()
        {
            throw new NotImplementedException();
        }

        internal static void PalindromicBorder()
        {
            throw new NotImplementedException();
        }

        internal static void TwoTwo()
        {
            throw new NotImplementedException();
        }

        internal static void TwoStringsGame()
        {
            throw new NotImplementedException();
        }

        internal static void LetterIslands()
        {
            throw new NotImplementedException();
        }

        internal static void PseudoIsomorphicSubstrings()
        {
            throw new NotImplementedException();
        }

        internal static void HowManySubstrings()
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// String Construction
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/string-construction/problem</Detail>
        /// <Detail name="Comment"></Detail>
        internal static void StringConstruction()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            while (N-- > 0) Console.WriteLine(Console.ReadLine().ToCharArray().Distinct().Count());
        }
    }
}
