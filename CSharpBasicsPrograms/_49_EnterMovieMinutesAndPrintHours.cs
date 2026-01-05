using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _49_EnterMovieMinutesAndPrintHours
    {
        public static void movieMinutesToHours()
        {
            Console.Write("Enter Movie Minutes : ");
            string movieMinutes = Console.ReadLine();

            Console.WriteLine("Hours = " + double.Parse(movieMinutes) / 60);
        }
    }
}
