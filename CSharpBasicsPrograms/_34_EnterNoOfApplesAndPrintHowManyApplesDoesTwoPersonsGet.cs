using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _34_EnterNoOfApplesAndPrintHowManyApplesDoesTwoPersonsGet
    {
        public static void twoPersonsApples()
        {
            Console.Write("Enter Number of Apples : ");
            string apples = Console.ReadLine();

            Console.WriteLine("Apples for each person = " + double.Parse(apples) / 2);
        }
    }
}
