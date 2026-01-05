using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _32_EnterTwoDigitsNumberAndPrintThereSum
    {
        public static void twoDigitsSum()
        {
            Console.Write("Enter 2-Digits Number : ");
            string number = Console.ReadLine();

            int ParsedNumber = int.Parse(number);

            Console.WriteLine((ParsedNumber / 10) + (ParsedNumber % 10));

        }
    }
}
