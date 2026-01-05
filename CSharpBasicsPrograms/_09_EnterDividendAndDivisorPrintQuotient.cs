using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _09_EnterDividendAndDivisorPrintQuotient
    {
        public static void quotient()
        {
            Console.Write("Enter Dividend : ");
            string dividend = Console.ReadLine();

            Console.Write("Enter Divisor : ");
            string divisor = Console.ReadLine();

            Console.WriteLine("Quotient = " + double.Parse(dividend) / double.Parse(divisor));
        }
    }
}
