﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Algorithms.Implementation
{
    public static class ImplementationClass
    {
        internal static void GradingStudents()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                int Grade = Convert.ToInt32(Console.ReadLine());
                if (Grade >= 38 && Grade % 5 > 2) Grade = ((Grade / 5) + 1) * 5;
                Console.WriteLine(Grade);
            }
        }

        internal static void AppleandOrange()
        {
            var HouseRange = Console.ReadLine().Split().Select(Int32.Parse).ToList();
            int Hstart = HouseRange[0];
            int HEnd = HouseRange[1];

            var TreesLoc = Console.ReadLine().Split().Select(Int32.Parse).ToList();
            int AppleTreeLoc = TreesLoc[0];
            int OrangeTreeLoc = TreesLoc[1];


            int AppleRangeStart = Hstart - AppleTreeLoc;
            int AppleRangeEnd = HEnd - AppleTreeLoc;

            int OrangeRangeStart = Hstart - OrangeTreeLoc;
            int OrangeRangeEnd = HEnd - OrangeTreeLoc;

            Console.ReadLine();

            Console.WriteLine(Console.ReadLine().Split().Select(Int32.Parse).Where(n => (n >= AppleRangeStart && n <= AppleRangeEnd)).Count());
            Console.WriteLine(Console.ReadLine().Split().Select(Int32.Parse).Where(n => (n >= OrangeRangeStart && n <= OrangeRangeEnd)).Count());
        }

        internal static void Kangaroo()
        {
            var N = Console.ReadLine().Split().Select(Int32.Parse).ToList();
            int X1 = N[0] <= N[2] ? N[0] : N[2];
            int V1 = N[0] <= N[2] ? N[1] : N[3];
            int X2 = N[0] > N[2] ? N[0] : N[2];
            int V2 = N[0] > N[2] ? N[1] : N[3];

            bool WillMeet = false;

            while (X1 <= X2)
            {
                X1 += V1;
                X2 += V2;

                if (X1 == X2)
                {
                    WillMeet = true;
                    break;
                }
            }

            Console.WriteLine(WillMeet ? "YES" : "NO");
        }

        internal static void BetweenTwoSets()
        {

        }

        internal static void BreakingtheRecords()
        {
            Console.ReadLine();
            var Scores = Console.ReadLine().Split().Select(Int32.Parse);
            int BestCount = 0;
            int WorstCount = 0;
            int Best = Scores.First();
            int Worst = Scores.First();

            foreach (var score in Scores)
            {
                if (score > Best)
                {
                    BestCount++;
                    Best = score;
                    continue;
                }

                if (score < Worst)
                {
                    WorstCount++;
                    Worst = score;
                }
            }

            Console.WriteLine("{0} {1}", BestCount, WorstCount);
        }

        internal static void BirthdayChocolate()
        {
            throw new NotImplementedException();
        }

        internal static void DivisibleSumPairs()
        {
            throw new NotImplementedException();
        }

        internal static void MigratoryBirds()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);

            var abc = ar.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x => x.Key).Select(x => x.Key).FirstOrDefault(); ;

            //Console.WriteLine(result);
        }

        internal static void DayoftheProgrammer()
        {
            int Year = Convert.ToInt32(Console.ReadLine());
            int DaysToBeAdded = 256;

            if (Year == 1918)
                DaysToBeAdded += 13;

            if (Year < 1918 && (Year % 100 == 0))
                --DaysToBeAdded;

            Console.WriteLine(DateTime.ParseExact(string.Format("01/01/{0}", Year), "dd/MM/yyyy", CultureInfo.InvariantCulture).AddDays(--DaysToBeAdded).ToString("dd.MM.yyyy", CultureInfo.InvariantCulture));

        }

        internal static void BonAppétit()
        {
            int NotEaten = Console.ReadLine().Split(' ').Select(int.Parse).ToArray()[1];

            int[] Price = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ToBePaidByAnna = (Price.Sum() - Price[NotEaten]) / 2;
            int PaidByAnna = Convert.ToInt32(Console.ReadLine());

            if (PaidByAnna == ToBePaidByAnna)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(PaidByAnna - ToBePaidByAnna);
        }

        internal static void SockMerchant()
        {
            Console.ReadLine();
            IEnumerable<int> Socks = Console.ReadLine().Split(' ').Select(int.Parse);
            HashSet<int> Colors = new HashSet<int>();
            int Count = 0;

            foreach (int i in Socks)
            {
                if (!Colors.Contains(i))
                    Colors.Add(i);
                else
                {
                    Count++;
                    Colors.Remove(i);
                }
            }

            Console.WriteLine(Count);
        }

        internal static void DrawingBook()
        {
            int TotalPages = Convert.ToInt32(Console.ReadLine());
            int PageNo = Convert.ToInt32(Console.ReadLine());

            int fromFront = PageNo / 2;
            int fromBack = (TotalPages - PageNo == 1 && TotalPages % 2 == 0) ? 1 : (TotalPages - PageNo) / 2;

            Console.WriteLine(Math.Min(fromFront, fromBack));

        }

        internal static void CountingValleys()
        {
            Console.ReadLine();
            char[] Steps = Console.ReadLine().ToCharArray();
            int PrevStep = int.MaxValue;
            int CurrStep = 0;
            int VallyCount = 0;

            foreach (char C in Steps)
            {
                if (C == 'D')
                    CurrStep--;
                else
                    CurrStep++;

                if (PrevStep < 0 && CurrStep == 0)
                    VallyCount++;

                PrevStep = CurrStep;
            }

            Console.WriteLine(VallyCount);

        }

        internal static void ElectronicsShop()
        {
            int[] N = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int Money = N[0];
            int K = N[1];
            int M = N[2];
            int[] KbPrices = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int[] MPrices = Console.ReadLine().Split(' ').Select(Int32.Parse).ToArray();
            int Max = -1;

            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if ((Money >= KbPrices[i] + MPrices[j]) && (Max < KbPrices[i] + MPrices[j]))
                        Max = KbPrices[i] + MPrices[j];
                }
            }

            Console.WriteLine(Max);
        }

        internal static void CatsandaMouse()
        {
            int TestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < TestCases; i++)
            {
                int[] Positions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int CatA = Positions[0];
                int CatB = Positions[1];
                int MouseC = Positions[2];

                if (Math.Abs(MouseC - CatA) < Math.Abs(MouseC - CatB)) Console.WriteLine("Cat A");
                else if (Math.Abs(MouseC - CatA) > Math.Abs(MouseC - CatB)) Console.WriteLine("Cat B");
                else Console.WriteLine("Mouse C");
            }
        }

        internal static void FormingaMagicSquare()
        {
            throw new NotImplementedException();
        }

        internal static void PickingNumbers()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Stack<int> Digits = new Stack<int>();
            int Max = 0;
            int LocalMax = 0;

            while (n > 0)
            {
                Digits.Push(n % 2);
                n = n / 2;
            }

            while (Digits.Any())
            {
                int Curr = Digits.Pop();

                LocalMax = Curr == 1 ? LocalMax + 1 : 0;

                if (LocalMax > Max)
                    Max = LocalMax;

            }

            Console.WriteLine(Max);
            throw new NotImplementedException();
        }

        internal static void ClimbingtheLeaderboard()
        {
            throw new NotImplementedException();
        }

        internal static void TheHurdleRace()
        {
            throw new NotImplementedException();
        }

        internal static void DesignerPDFViewer()
        {
            throw new NotImplementedException();
        }

        internal static void UtopianTree()
        {
            throw new NotImplementedException();
        }

        internal static void AngryProfessor()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Beautiful Days at the Movies
        /// </summary>
        /// <Detail name="URL">https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem</Detail>
        internal static void BeautifulDaysattheMovies()
        {
            int[] N = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int Start = N[0];
            int End = N[1];
            int k = N[2];
            int Count = 0;

            for (int Day = Start; Day <= End; Day++)
            {
                int RevNum=0;
                int DayTemp = Day;
                while(DayTemp != 0)
                {
                    RevNum = (RevNum * 10) + (DayTemp % 10);
                    DayTemp /= 10;
                }

                if (Math.Abs(Day - RevNum) % k == 0) Count++;
            }

            Console.WriteLine(Count);

        }

        internal static void ViralAdvertising()
        {
            throw new NotImplementedException();
        }

        internal static void SavethePrisoner()
        {
            throw new NotImplementedException();
        }

        internal static void CircularArrayRotation()
        {
            throw new NotImplementedException();
        }

        internal static void SequenceEquation()
        {
            throw new NotImplementedException();
        }

        internal static void JumpingontheCloudsRevisited()
        {
            throw new NotImplementedException();
        }

        internal static void FindDigits()
        {
            throw new NotImplementedException();
        }

        internal static void ExtraLongFactorials()
        {
            throw new NotImplementedException();
        }

        internal static void AppendandDelete()
        {
            throw new NotImplementedException();
        }

        internal static void SherlockandSquares()
        {
            throw new NotImplementedException();
        }

        internal static void LibraryFine()
        {
            throw new NotImplementedException();
        }

        internal static void Cutthesticks()
        {
            throw new NotImplementedException();
        }

        internal static void NonDivisibleSubset()
        {
            throw new NotImplementedException();
        }

        internal static void RepeatedString()
        {
            throw new NotImplementedException();
        }

        internal static void JumpingontheClouds()
        {
            throw new NotImplementedException();
        }

        internal static void EqualizetheArray()
        {
            throw new NotImplementedException();
        }

        internal static void QueensAttackII()
        {
            throw new NotImplementedException();
        }

        internal static void ACMICPCTeam()
        {
            throw new NotImplementedException();
        }

        internal static void TaumandBday()
        {
            throw new NotImplementedException();
        }

        internal static void OrganizingContainersofBalls()
        {
            throw new NotImplementedException();
        }

        internal static void Encryption()
        {
            throw new NotImplementedException();
        }

        internal static void BiggerisGreater()
        {
            throw new NotImplementedException();
        }

        internal static void ModifiedKaprekarNumbers()
        {
            throw new NotImplementedException();
        }

        internal static void BeautifulTriplets()
        {
            throw new NotImplementedException();
        }

        internal static void MinimumDistances()
        {
            throw new NotImplementedException();
        }

        internal static void TheTimeinWords()
        {
            Dictionary<int, string> IntToWord = new Dictionary<int, string>() {
                {1,  "one"          },
                {2,  "two"          },
                {3,  "three"        },
                {4,  "four"         },
                {5,  "five"         },
                {6,  "six"          },
                {7,  "seven"        },
                {8,  "eight"        },
                {9,  "nine"         },
                {10, "ten"          },
                {11, "eleven"       },
                {12, "twelve"       },
                {13, "thirteen"     },
                {14, "fourteen"     },
                {15, "fifteen"      },
                {16, "sixteen"      },
                {17, "seventeen"    },
                {18, "eighteen"     },
                {19, "nineteen"     },
                {20, "twenty"       },
                {21, "twenty one"   },
                {22, "twenty two"   },
                {23, "twenty three" },
                {24, "twenty four"  },
                {25, "twenty five"  },
                {26, "twenty six"   },
                {27, "twenty seven" },
                {28, "twenty eight" },
                {29, "twenty nine"  },
            };

            int H = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());


            switch (M)
            {
                case 0:
                    Console.WriteLine("{0} o' clock", IntToWord[H]);
                    break;
                case 15:
                    Console.WriteLine("quarter past {0}", IntToWord[H]);
                    break;
                case 45:
                    if (H == 12) Console.WriteLine("quarter to {0}", IntToWord[1]);
                    else Console.WriteLine("quarter to {0}", IntToWord[H + 1]);
                    break;
                case 30:
                    Console.WriteLine("half past {0}", IntToWord[H]);
                    break;
                default:
                    if (M < 30) Console.WriteLine("{0} minutes past {1}", IntToWord[M], IntToWord[H]);
                    else
                    {
                        if (H == 12) Console.WriteLine("{0} minutes to {1}", IntToWord[60 - M], IntToWord[1]);
                        else Console.WriteLine("{0} minutes to {1}", IntToWord[60 - M], IntToWord[H + 1]);
                    }
                    break;
            }
        }

        internal static void ChocolateFeast()
        {
            throw new NotImplementedException();
        }

        internal static void ServiceLane()
        {
            throw new NotImplementedException();
        }

        internal static void LisasWorkbook()
        {
            throw new NotImplementedException();
        }

        internal static void FlatlandSpaceStations()
        {
            throw new NotImplementedException();
        }

        internal static void FairRations()
        {
            throw new NotImplementedException();
        }

        internal static void CavityMap()
        {
            throw new NotImplementedException();
        }

        internal static void ManasaandStones()
        {
            throw new NotImplementedException();
        }

        internal static void TheGridSearch()
        {
            throw new NotImplementedException();
        }

        internal static void HappyLadybugs()
        {
            throw new NotImplementedException();
        }

        internal static void StrangeCounter()
        {
            throw new NotImplementedException();
        }

        internal static void AbsolutePermutation()
        {
            throw new NotImplementedException();
        }

        internal static void TheBombermanGame()
        {
            throw new NotImplementedException();
        }

        internal static void EmasSupercomputer()
        {

            int Trips = Convert.ToInt32(Console.ReadLine());
            while (Trips-- > 0)
            {
                int PooledMoney = Convert.ToInt32(Console.ReadLine());
                Console.ReadLine();
                int[] Flavours = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                bool SolutionFound = false;


                for (int j = 0; j < Flavours.Length - 1; j++)
                {
                    for (int k = j + 1; k < Flavours.Length; k++)
                    {
                        if (PooledMoney == Flavours[j] + Flavours[k])
                        {
                            Console.WriteLine($"{j + 1} {k + 1}");
                            SolutionFound = true;
                            break;
                        }
                    }

                    if (SolutionFound)
                        break;
                }
            }


            throw new NotImplementedException();
        }

        internal static void LarrysArray()
        {
            throw new NotImplementedException();
        }

        internal static void AlmostSorted()
        {
            throw new NotImplementedException();
        }

        internal static void MatrixLayerRotation()
        {
            throw new NotImplementedException();
        }
    }


}
