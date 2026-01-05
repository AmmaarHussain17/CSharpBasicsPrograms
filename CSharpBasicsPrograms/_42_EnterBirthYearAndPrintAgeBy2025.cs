using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _42_EnterBirthYearAndPrintAgeBy2025
    {
        public static void AgeBy2025()
        {
            Console.Write("Enter Birth Year : ");
            string year = Console.ReadLine();

            Console.WriteLine("Age by 2025 = " + (2025 - int.Parse(year)));
        }
    }
}
