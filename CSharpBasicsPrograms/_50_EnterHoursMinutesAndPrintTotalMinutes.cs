using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _50_EnterHoursMinutesAndPrintTotalMinutes
    {
        public static void totalMinutes()
        {
            Console.Write("Enter Hours : ");
            string hours = Console.ReadLine();

            Console.Write("Enter Minutes : ");
            string minutes = Console.ReadLine();

            double parseHours = double.Parse(hours);
            double parseMinutes = double.Parse(minutes);

            Console.WriteLine("Total Minutes = " + ((parseHours * 60) + parseMinutes));
        }
    }
}
