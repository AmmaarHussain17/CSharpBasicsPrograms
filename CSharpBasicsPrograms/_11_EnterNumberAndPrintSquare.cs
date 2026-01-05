using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _11_EnterNumberAndPrintSquare
    {
        public static void square()
        {
            Console.Write("Enter Number : ");
            string num = Console.ReadLine();

            Console.WriteLine("Square of Number = " + int.Parse(num) * int.Parse(num));
        }
    }
}
