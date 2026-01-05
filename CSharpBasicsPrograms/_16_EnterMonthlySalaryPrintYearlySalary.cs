using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _16_EnterMonthlySalaryPrintYearlySalary
    {
        public static void YearlySalary()
        {
            Console.Write("Enter Montly Salary : ");
            string montlySalary = Console.ReadLine();

            Console.WriteLine("Yearly Salary : " + double.Parse(montlySalary) * 12);
        }
    }
}
