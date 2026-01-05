using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _33_EnterNumberAndPrintItsHalf
    {
        public static void halfNumber()
        {
            Console.Write("Enter number : ");
            string number = Console.ReadLine();

            Console.WriteLine("Half Value = " + double.Parse(number) / 2);
        }
    }
}
