using System;
using System.Linq;

namespace Mahamudra.AdventOfCode.Core
{
    public class TwoThousandFifteen
    {
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
    }
}
