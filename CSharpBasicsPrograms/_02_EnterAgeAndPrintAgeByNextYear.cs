using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _02_EnterAgeAndPrintAgeByNextYear
    {
        public static void yourAge()
        {
            Console.Write("What is your Age : ");
            string age = Console.ReadLine();
            Console.WriteLine("Next Year you will be : " + (int.Parse(age) + 1));
        }
    }
}
