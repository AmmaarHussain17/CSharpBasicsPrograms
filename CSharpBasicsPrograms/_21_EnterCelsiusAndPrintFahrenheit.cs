using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _21_EnterCelsiusAndPrintFahrenheit
    {
        public static void celsiusToFahrenheit()
        {
            Console.Write("Enter Celsius : ");
            string celsius = Console.ReadLine();

            double faherheit = (double.Parse(celsius) * 9 / 5.0) + 32;

            Console.Write("Faherheit = " + faherheit);
        }
    }
}
