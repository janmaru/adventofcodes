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

    }
}
