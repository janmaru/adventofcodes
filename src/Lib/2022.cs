using System;
using System.Collections.Generic;
using System.Linq;

namespace Mahamudra.AdventOfCode.Core
{
    public class TwoThousandTwentyTwo
    {
        #region first day
        public static int DayOneCalorieCounting(string[] inputs)
        {
            int previous = 0;
            int max = 0;
            foreach (var line in inputs)
            {
                if (string.IsNullOrEmpty(line))
                {
                    if (previous > max)
                        max = previous;
                    previous = 0;
                }
                else
                    previous += Convert.ToInt32(line);
            }
            return max;
        }

        public static int DayOneCalorieCountingBestThree(string[] inputs)
        {
            var lista = new List<int>();
            int previous = 0;
            foreach (var line in inputs)
            {
                if (string.IsNullOrEmpty(line))
                {
                    lista.Add(previous);
                    previous = 0;
                }
                else
                    previous += Convert.ToInt32(line);
            }
            return lista.OrderByDescending(s => s).Take(3).Sum();
        }
        #endregion


        #region second day
        private static readonly int[,] values = new int[3, 3] { { 8, 4, 3 }, { 5, 1, 9 }, { 2, 7, 6 } };

        private static int DayTwo(string[] inputs, int[,] values)
        {
            var sum = 0;
            foreach (var line in inputs)
            {
                var v = line.Split(" ");
                var c = v[0].Replace("A", "0");
                c = c.Replace("B", "1");
                c = c.Replace("C", "2");

                var r = v[1].Replace("Y", "0");
                r = r.Replace("X", "1");
                r = r.Replace("Z", "2");

                var column = Convert.ToInt32(c);
                var row = Convert.ToInt32(r);
                sum += values[column, row];
            }
            return sum;
        }
        public static int DayTwoRockPaperScissors(string[] inputs)
        {
            return DayTwo(inputs, values);
        }
        private static readonly int[,] values2 = new int[3, 3] { { 4, 3, 8 }, { 5, 1, 9 }, { 6, 2, 7 } };
        public static int DayTwoRockPaperScissors2(string[] inputs)
        {
            return DayTwo(inputs, values2);
        }
        #endregion


        #region third day
        private static string[] GiveOutHalves(string value)
        {
            var f = value.Length / 2;
            var s = value.Length - f;
            return new[]
                 {
                    value[..f],
                    value.Substring(f, s)
                 };
        }
        private static Dictionary<string, int> lowerLetters = new Dictionary<string, int>()
        {
            {"a", 1 },
            {"b", 2 },
            {"c", 3 },
            {"d", 4 },
            {"e", 5 },
            {"f", 6 },
            {"g", 7 },
            {"h", 8 },
            {"i", 9 },
            {"j", 10 },
            {"k", 11 },
            {"l", 12 },
            {"m", 13 },
            {"n", 14 },
            {"o", 15 },
            {"p", 16 },
            {"q", 17 },
            {"r", 18 },
            {"s", 19 },
            {"t", 20 },
            {"u", 21 },
            {"v", 22 },
            {"w", 23 },
            {"x", 24 },
            {"y", 25 },
            {"z", 26 }
        };
        private static Dictionary<string, int> upperLetters = new Dictionary<string, int>()
        {
            {"A", 27 },
            {"B", 28 },
            {"C", 29 },
            {"D", 30 },
            {"E", 31 },
            {"F", 32 },
            {"G", 33 },
            {"H", 34 },
            {"I", 35 },
            {"J", 36 },
            {"K", 37 },
            {"L", 38 },
            {"M", 39 },
            {"N", 40 },
            {"O", 41 },
            {"P", 42 },
            {"Q", 43 },
            {"R", 44 },
            {"S", 45 },
            {"T", 46 },
            {"U", 47 },
            {"V", 48 },
            {"W", 49 },
            {"X", 50 },
            {"Y", 51 },
            {"Z", 52 }
        };

        public static int DayThreeRucksackReorganization(string[] inputs)
        {
            var sum = 0;
            foreach (var line in inputs)
            {
                var rucksackPockets = GiveOutHalves(line);
                var a = rucksackPockets[0].ToCharArray();
                var b = rucksackPockets[1].ToCharArray();
                var item = a.Intersect(b).FirstOrDefault().ToString();
                if (lowerLetters.TryGetValue(item, out int priority1))
                    sum += priority1;
                if (upperLetters.TryGetValue(item, out int priority2))
                    sum += priority2;
            }
            return sum;
        }
        public static int DayThreeRucksackReorganization3(string[] inputs)
        {
            var sum = 0;
            var count = 1;
            List<char> previous = new();
            List<char> items = new();
            foreach (var line in inputs)
            {
                if (previous.Any())
                    items = line.ToCharArray().Intersect(previous).ToList();
                else
                    items = line.ToCharArray().ToList();

                if (count % 3 == 0)
                {
                    var item = items.FirstOrDefault().ToString();
                    if (lowerLetters.TryGetValue(item, out int priority1))
                        sum += priority1;
                    if (upperLetters.TryGetValue(item, out int priority2))
                        sum += priority2;
                    previous = new();
                }
                else
                    previous = items.ToList();

                count++;
            }
            return sum;
        }
        #endregion

    }
}
