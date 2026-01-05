using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _20_EnterDaysPrintHours
    {
        public static void daysToHours()
        {
            Console.Write("Enter Days : ");
            string days = Console.ReadLine();

            Console.WriteLine("Hours = " + int.Parse(days) * 24);
        }
    }
}
