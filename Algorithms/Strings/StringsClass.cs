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

            MinCharReq = Math.Max(6-Password.Length, MinCharReq);

            Console.WriteLine(MinCharReq);
        }

        internal static void CaesarCipher()
        {
            throw new NotImplementedException();
        }

        internal static void MarsExploration()
        {
            throw new NotImplementedException();
        }

        internal static void HackerRankinaString()
        {
            throw new NotImplementedException();
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

        internal static void FunnyString()
        {
            throw new NotImplementedException();
        }

        internal static void Gemstones()
        {
            throw new NotImplementedException();
        }

        internal static void AlternatingCharacters()
        {
            throw new NotImplementedException();
        }

        internal static void BeautifulBinaryString()
        {
            throw new NotImplementedException();
        }

        internal static void TheLoveLetterMystery()
        {
            throw new NotImplementedException();
        }

        internal static void DeterminingDNAHealth()
        {
            throw new NotImplementedException();
        }

        internal static void PalindromeIndex()
        {
            throw new NotImplementedException();
        }

        internal static void Anagram()
        {
            throw new NotImplementedException();
        }

        internal static void MakingAnagrams()
        {
            throw new NotImplementedException();
        }

        internal static void GameofThronesI()
        {
            throw new NotImplementedException();
        }

        internal static void TwoStrings()
        {
            throw new NotImplementedException();
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
    }
}
