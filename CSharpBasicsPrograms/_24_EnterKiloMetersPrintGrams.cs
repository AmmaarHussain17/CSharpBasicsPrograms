using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _24_EnterKiloMetersPrintGrams
    {
        public static void kmToGrams()
        {
            Console.Write("Enter Kilo Grams : ");
            string kg = Console.ReadLine();

            Console.WriteLine("Grams = " + int.Parse(kg) * 1000);
        }
    }
}