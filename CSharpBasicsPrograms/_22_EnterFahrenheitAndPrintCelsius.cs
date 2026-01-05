using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _22_EnterFahrenheitAndPrintCelsius
    {
        public static void fahrenheitToCelsius()
        {
            Console.Write("Enter Fahrenheit : ");
            string fahrenheit = Console.ReadLine();

            double celsius = (double.Parse(fahrenheit) - 32) * (5.0 / 9);
            Console.WriteLine("Celsius = " + celsius);
        }
    }
}
