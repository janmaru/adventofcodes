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


        public static int DayTwoWhatFloorBigO2ɛn(string input)
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

    }
}
