using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan beginbeginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);
            TimeSpan consultationTime = new TimeSpan(0, 30, 0);
            int[] durations = { 60, 30, 10, 10, 40, 30 };
            TimeSpan[] startTimes = new TimeSpan[] { new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0), new TimeSpan(15, 0, 0), new TimeSpan(15, 30, 0), new TimeSpan(16, 50, 0), new TimeSpan(18, 0, 0), };
            int j = 0;
            for (var i = beginbeginWorkingTime; i < endWorkingTime; i += consultationTime)
            {

                if (j <= startTimes.Length - 1 && startTimes[j] == i)
                {
                    i += new TimeSpan(0, durations[j], 0);

                    j++;

                    if (j <= startTimes.Length - 1 && startTimes[j] == i)
                    {
                        i += new TimeSpan(0, durations[j], 0);
                        j++;
                    }
                    if (j <= startTimes.Length - 1 && startTimes[j] - i < consultationTime)
                    {
                        i = startTimes[j] + new TimeSpan(0, durations[j], 0);
                        j++;
                    }

                }

                if (i < startTimes[startTimes.Length - 1] && j <= startTimes.Length - 1 && startTimes[j] - i < consultationTime)
                {
                    i = startTimes[j] + new TimeSpan(0, durations[j], 0);
                    j++;
                }

                Console.WriteLine(i);
            }    }
    }
}
