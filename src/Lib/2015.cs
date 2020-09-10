using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Mahamudra.AdventOfCode.Core
{
    public class TwoThousandFifteen
    {
        #region 1 day
        public static int DayOneWhatFloorBigO2ɛn(string input)
        {
            var symbols = input.ToCharArray();  //  number of char as the Length of the input string
            var count = 0;
            foreach (var s in symbols)
            {
                if (s == '(')
                    count++;
                else
                    count--;
            }
            return count;
        }

        public static int DayOneWhatFloorv2BigO2ɛn(string input)  // BigOɛn linear x 2, hence again linear. The running time grows no faster than a constant times nnn
        {
            var up = input.ToCharArray().Where(x => x == ')').Sum(x => -1);
            return input.Length + 2 * up;
        }

        public static int DayOneWhatFloorv3BigO2ɛn(string input)  // BigOɛn linear x 2, hence again linear. The running time grows no faster than a constant times nnn
        {
            var count = 0;
            var separators = new string[] { "()", ")(" };
            var sections = input.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (var s in sections)
            {
                if (s.First() == '(')
                    count += s.Length;
                else
                    count -= s.Length;
            }
            return count;
        }


        public static int DayOneSecondQuestionWhatFloorBigO2ɛn(string input)
        {
            var symbols = input.ToCharArray();  //  number of char as the Length of the input string
            var count = 0;
            var index = 0;
            foreach (var s in symbols)
            {
                if (s == '(')
                {
                    count++;
                }
                else
                    count--;

                index++;
                if (count == -1)
                    return index;
            }
            return count;
        }
        #endregion
        #region 2 day
        public static long DayTwoPaperBigOɛn(string[] input)
        {
            Int64 total = 0;
            var separators = new string[] { "x" };

            Func<Int64, Int64, Int64, Int64> paper = (x, y, z) => 2 * (x + y + z) + Math.Min(Math.Min(x, y), z);

            foreach (var box in input)
            {
                var measures = box.Split(separators, System.StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt64(x)).ToArray();
                var l = measures[0];
                var w = measures[1];
                var h = measures[2];
                Int64 x = l * w;
                Int64 y = w * h;
                Int64 z = h * l;
                total += paper(x, y, z);
            }
            return total;
        }

        public static long DayTwoRibbonBigOɛn(string[] input)
        {
            Int64 total = 0;
            var separators = new string[] { "x" };

            Func<Int64, Int64, Int64, Int64> ribbon = (l, w, h) => (new Int64[] { l, w, h }).OrderBy(x => x).Take(2).Sum(x => 2 * x);
            Func<Int64, Int64, Int64, Int64> bow = (l, w, h) => l * w * h;
            foreach (var box in input)
            {
                var measures = box.Split(separators, System.StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt64(x)).ToArray();
                var l = measures[0];
                var w = measures[1];
                var h = measures[2];

                total += ribbon(l, w, h) + bow(l, w, h);
            }
            return total;
        }
        #endregion
        #region 3 day
        private static Func<(int, int), (int, int)> Right = (a) => (a.Item1 + 1, a.Item2);
        private static Func<(int, int), (int, int)> Left = (a) => (a.Item1 - 1, a.Item2);
        private static Func<(int, int), (int, int)> Up = (a) => (a.Item1, a.Item2 + 1);
        private static Func<(int, int), (int, int)> Down = (a) => (a.Item1, a.Item2 - 1);

        private static void DayThreeHouseBigOɛn(char symbol, ref Dictionary<(int, int), int> houses, ref (int, int) point)
        {
            switch (symbol)
            {
                case '>':
                    point = Right(point);
                    break;
                case '<':
                    point = Left(point);
                    break;
                case '^':
                    point = Up(point);
                    break;
                case 'v':
                    point = Down(point);
                    break;
                default:
                    throw new Exception("wtf!");
            }
            var check = houses.TryAdd(point, 1);
            if (!check)
                houses[point] += 1;
        }

        public static long DayThreeHouseBigOɛn(string input)
        {
            Dictionary<(int, int), int> houses = new Dictionary<(int, int), int>();
            var symbols = input.ToCharArray();
            var point = (0, 0);
            houses.Add(point, 1); // add first point start walk

            foreach (var sy in symbols)
            {
                DayThreeHouseBigOɛn(sy, ref houses, ref point);
            }

            return houses.Count();
        }

        public static long DayThreeHouseTwoSantaBigO2ɛn(string input)
        {
            Dictionary<(int, int), int> houses = new Dictionary<(int, int), int>();
            var pointS = (0, 0);
            var pointRs = (0, 0);

            var symbols = input.ToCharArray();
            if (symbols.Length == 1)
                throw new Exception("path valid only for one santa");

            houses.Add(pointS, 2); // add first point start walk for each santa

            for (int i = 0; i < symbols.Length; i++)
            {
                if (i % 2 == 0)
                    DayThreeHouseBigOɛn(symbols[i], ref houses, ref pointS);
                else
                    DayThreeHouseBigOɛn(symbols[i], ref houses, ref pointRs);
            }

            return houses.Count();
        }
        #endregion
        #region 4 day

        private static string GetMd5Hash(string input)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Create a new Stringbuilder to collect the bytes
                // and create a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop through each byte of the hashed data
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }

        public static Int32 DayFourAdventCoinsBigO2ɛn(string secretKey, int numberOfZeros)
        {

            for (int i = 0; i <= Int32.MaxValue; i++)
            {
                if (GetMd5Hash($"{secretKey}{i}").Substring(0, numberOfZeros) == new string('0', numberOfZeros))
                    return i;
            }
            return 0;
        }
        #endregion

        #region 5 day
        public static long DayFiveNiceStringBigOɛnPower2(string niceString)
        {
            long count = 0;
            string[] inputs = niceString.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            var aeiou = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var noGoods = new string[] { "ab", "cd", "pq", "xy" };

            foreach (var text in inputs)
            {
                var isnoGoods = false;
                foreach (string no in noGoods)
                {
                    if (text.Trim().Contains(no))
                    {
                        isnoGoods = true;
                        break;
                    }
                }

                if (isnoGoods)
                    continue;

                var at = text.Select((c, index) => text.Substring(index).TakeWhile(e => e == c))
                    .OrderByDescending(e => e.Count())
                    .FirstOrDefault();

                if (at == null)
                    continue;

                if (at.ToArray().Length < 2)
                    continue;

                var countVowels = 0;
                foreach (char vow in aeiou)
                {
                    countVowels += text.Count(f => f == vow);
                    if (countVowels >= 3)
                    {
                        count++;
                        break;
                    }
                }
            }

            return count;
        }


        private static Func<char[], bool> RepeatLetter = (ta) =>
        {
            var oddPrevious = ' ';
            var evenprevious = ' ';

            for (int i = 0; i < ta.Length; i++)
            {
                if (i % 2 == 0) //odd
                    if (oddPrevious == ta[i])
                        return true;
                    else
                        oddPrevious = ta[i];
                else //even
                {
                    if (evenprevious == ta[i])
                        return true;
                    else
                        evenprevious = ta[i];
                }
            }
            return false;
        };

        private static Func<string, bool> TwoLettersTwice = (input) =>
         {
             var pattern = @"([a-zA-Z]{2,}).*?\1";

             Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
             return m.Success;
         };

        public static long DayFive2QuestionNiceStringBigOɛnPower2(string niceString)
        {
            long count = 0;
            string[] inputs = niceString.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            foreach (var text in inputs)
            {
                var ta = text.ToCharArray();
                if (RepeatLetter(ta) && TwoLettersTwice(text))
                    count++;
            }

            return count;
        }
        #endregion

        #region 6 day
        private static int CountOnOff(ref bool[,] matrix, bool onOff, int initI, int finI, int initJ, int finJ)
        {
            var count = 0;
            for (int i = initI; i <= finI; i++)
            {
                for (int j = initJ; j <= finJ; j++)
                {
                    if (matrix[i, j] == onOff)
                        count++;
                }
            }
            return count;
        }

        private static void TurnOnOff(ref bool[,] matrix, bool onOff, int initI, int finI, int initJ, int finJ)
        {
            for (int i = initI; i <= finI; i++)
            {
                for (int j = initJ; j <= finJ; j++)
                {
                    matrix[i, j] = onOff;
                }
            }
        }

        private static void Toogle(ref bool[,] matrix, int initI, int finI, int initJ, int finJ)
        {
            for (int i = initI; i <= finI; i++)
            {
                for (int j = initJ; j <= finJ; j++)
                {
                    matrix[i, j] = !matrix[i, j];
                }
            }
        }
        public static int DaySixQuestionLightsBigOɛnPower2(string input)
        {
            string[] inputs = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            bool[,] matrix = new bool[1000, 1000];

            foreach (var item in inputs)
            {
                int initI, finI, initJ, finJ;
                if (item.Contains("toggle"))
                {
                    var values = item.Replace("toggle ", "").Replace(" through ", ",").Split(',');
                    initI = Convert.ToInt32(values[0]);
                    initJ = Convert.ToInt32(values[1]);
                    finI = Convert.ToInt32(values[2]);
                    finJ = Convert.ToInt32(values[3]);
                    Toogle(ref matrix, initI, finI, initJ, finJ);
                }
                else if (item.Contains("turn off"))
                {
                    var values = item.Replace("turn off ", "").Replace(" through ", ",").Split(',');
                    initI = Convert.ToInt32(values[0]);
                    initJ = Convert.ToInt32(values[1]);
                    finI = Convert.ToInt32(values[2]);
                    finJ = Convert.ToInt32(values[3]);
                    TurnOnOff(ref matrix, false, initI, finI, initJ, finJ);
                }
                else if (item.Contains("turn on"))
                {
                    var values = item.Replace("turn on ", "").Replace(" through ", ",").Split(',');
                    initI = Convert.ToInt32(values[0]);
                    initJ = Convert.ToInt32(values[1]);
                    finI = Convert.ToInt32(values[2]);
                    finJ = Convert.ToInt32(values[3]);
                    TurnOnOff(ref matrix, true, initI, finI, initJ, finJ);
                }
            }

            return CountOnOff(ref matrix, true, 0, 999, 0, 999);
        }

        private static long CountOnOff2(ref int[,] matrix, int initI, int finI, int initJ, int finJ)
        {
            long count = 0;
            for (int i = initI; i <= finI; i++)
            {
                for (int j = initJ; j <= finJ; j++)
                {
                    count += matrix[i, j];
                }
            }
            return count;
        }

        private static void TurnOnOff2(ref int[,] matrix, int onOff, int initI, int finI, int initJ, int finJ)
        {
            for (int i = initI; i <= finI; i++)
            {
                for (int j = initJ; j <= finJ; j++)
                {
                    if (onOff == 1)
                        matrix[i, j] += 1;
                    else
                        matrix[i, j] = matrix[i, j] > 0 ? matrix[i, j] - 1 : 0;
                }
            }
        }

        private static void Toogle2(ref int[,] matrix, int initI, int finI, int initJ, int finJ)
        {
            for (int i = initI; i <= finI; i++)
            {
                for (int j = initJ; j <= finJ; j++)
                {
                    matrix[i, j] += 2;
                }
            }
        }
        public static long DaySixQuestion2LightsBigOɛnPower2(string input)
        {
            string[] inputs = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            int[,] matrix = new int[1000, 1000];

            foreach (var item in inputs)
            {
                int initI, finI, initJ, finJ;
                if (item.Contains("toggle"))
                {
                    var values = item.Replace("toggle ", "").Replace(" through ", ",").Split(',');
                    initI = Convert.ToInt32(values[0]);
                    initJ = Convert.ToInt32(values[1]);
                    finI = Convert.ToInt32(values[2]);
                    finJ = Convert.ToInt32(values[3]);
                    Toogle2(ref matrix, initI, finI, initJ, finJ);
                }
                else if (item.Contains("turn off"))
                {
                    var values = item.Replace("turn off ", "").Replace(" through ", ",").Split(',');
                    initI = Convert.ToInt32(values[0]);
                    initJ = Convert.ToInt32(values[1]);
                    finI = Convert.ToInt32(values[2]);
                    finJ = Convert.ToInt32(values[3]);
                    TurnOnOff2(ref matrix, -1, initI, finI, initJ, finJ);
                }
                else if (item.Contains("turn on"))
                {
                    var values = item.Replace("turn on ", "").Replace(" through ", ",").Split(',');
                    initI = Convert.ToInt32(values[0]);
                    initJ = Convert.ToInt32(values[1]);
                    finI = Convert.ToInt32(values[2]);
                    finJ = Convert.ToInt32(values[3]);
                    TurnOnOff2(ref matrix, 1, initI, finI, initJ, finJ);
                }
            }

            return CountOnOff2(ref matrix, 0, 999, 0, 999);
        }

        #endregion


        #region 7 day 
        public static Int16 DaySevenQuestionCircuitOɛn(string input)
        {
            string[] circuit = input.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);

            foreach (var branch in circuit)
            {
                
            }

            return 0;
        }

        #endregion

        #region 8 day
        private static int CountTextElements(String s)
        { 
            StringBuilder builder = new StringBuilder(s.Length);
            foreach (Rune rune in s.EnumerateRunes())
            {
                builder.Append(Rune.ToUpperInvariant(rune));
            }
            return builder.Length; 
        }

        public static int DayEightQuestionStringLiteralO2ɛn(string[] input)
        {
            var count = 0;

            foreach (var item in input)
            {
                var nStringcode = item.GetHashCode().ToString().Length + 1;
                var nInMemory = item.Length;
                count += nStringcode - nInMemory;
            }

            return count;
        }
        #endregion
    }
}
