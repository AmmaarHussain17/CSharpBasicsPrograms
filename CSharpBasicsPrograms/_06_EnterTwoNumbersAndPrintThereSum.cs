using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _06_EnterTwoNumbersAndPrintThereSum
    {
        public static void sum()
        {
            Console.Write("Enter Number 1 : ");
            string num1 = Console.ReadLine();

            Console.Write("Enter Number 2 : ");
            string num2 = Console.ReadLine();

            Console.WriteLine("Sum = " + (int.Parse(num1) + int.Parse(num2)));
        }
    }
}