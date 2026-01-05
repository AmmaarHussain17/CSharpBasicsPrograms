using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _30_EnterLoanAndMonthsPrintEMI
    {
        public static void emi()
        {
            Console.Write("Enter Loan : ");
            string loan = Console.ReadLine();

            Console.Write("Enter Months : ");
            string months = Console.ReadLine();

            Console.WriteLine("EMI = " + double.Parse(loan) / double.Parse(months));
        }
    }
}
