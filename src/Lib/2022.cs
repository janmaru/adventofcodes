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
    }
}
