using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _28_EnterPrincipalRateTimePrintSimpleInterest
    {
        public static void simpleInterest()
        {
            Console.Write("Enter Principal : ");
            string principal = Console.ReadLine();

            Console.Write("Enter rate : ");
            string rate = Console.ReadLine();

            Console.Write("Enter time : ");
            string time = Console.ReadLine();

            double simpleInterest = (double.Parse(principal) * double.Parse(rate) * double.Parse(time)) / 100.0;

            Console.Write("Simple Interest = " + simpleInterest);
        }
    }
}
