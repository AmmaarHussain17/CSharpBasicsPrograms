using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _23_EnterMetersAndPrintCentiMeters
    {
        public static void metersToCm()
        {
            Console.Write("Enter Meters : ");
            string meters = Console.ReadLine();

            int cm = int.Parse(meters) * 100;
            Console.WriteLine("Centi Meters = " + cm);
        }
    }
}
