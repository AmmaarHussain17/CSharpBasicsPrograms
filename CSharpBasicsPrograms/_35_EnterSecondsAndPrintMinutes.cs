using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _35_EnterSecondsAndPrintMinutes
    {
        public static void secondsToMinutes()
        {
            Console.Write("Enter Seconds : ");
            string seconds = Console.ReadLine();

            Console.WriteLine(int.Parse(seconds) / 60.0);
        }
    }
}
