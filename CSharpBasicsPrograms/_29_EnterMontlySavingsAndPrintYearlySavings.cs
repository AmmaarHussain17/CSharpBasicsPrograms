using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _29_EnterMontlySavingsAndPrintYearlySavings
    {
        public static void MontlySavingsToYearlySavings()
        {
            Console.Write("Enter Monthly Savings : ");
            string monthlySavings = Console.ReadLine();

            Console.WriteLine("Yearly Savings = " + double.Parse(monthlySavings) * 12.0);
        }
    }
}
