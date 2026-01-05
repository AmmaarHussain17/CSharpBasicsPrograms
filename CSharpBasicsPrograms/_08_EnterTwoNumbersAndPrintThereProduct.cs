using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _08_EnterTwoNumbersAndPrintThereProduct
    {
        public static void product()
        {
            Console.Write("Enter Number 1 : ");
            string num1 = Console.ReadLine();

            Console.Write("Enter Number 2 : ");
            string num2 = Console.ReadLine();

            Console.WriteLine("Product = " + (int.Parse(num1) * int.Parse(num2)));
        }
    }
}
