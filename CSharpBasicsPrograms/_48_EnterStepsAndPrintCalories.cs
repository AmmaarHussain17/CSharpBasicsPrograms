using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _48_EnterStepsAndPrintCalories
    {
        public static void calories()
        {
            Console.Write("Enter Number of Steps : ");
            string steps = Console.ReadLine();

            Console.WriteLine("Calories = " + double.Parse(steps) * 0.04);
        }
    }
}
