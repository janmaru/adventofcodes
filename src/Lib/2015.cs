﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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
    }
}
