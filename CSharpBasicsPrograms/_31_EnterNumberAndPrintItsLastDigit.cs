using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _31_EnterNumberAndPrintItsLastDigit
    {
        public static void lastDigit()
        {
            Console.Write("Enter the Number : ");
            string number = Console.ReadLine();

            Console.WriteLine("Last Digit = " + int.Parse(number) % 10);
        }
    }
}
