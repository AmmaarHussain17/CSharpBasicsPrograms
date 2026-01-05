using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _05_EnterTwoNumbersAndPrintYouEnteredXandY
    {
        public static void twoValuesXAndY()
        {
            Console.Write("Enter Two Numbers X : ");
            string x = Console.ReadLine();

            Console.Write("Enter Two Numbers Y : ");
            string y = Console.ReadLine();

            Console.Write("You Entered " + x + " And " + y);
        }
    }
}