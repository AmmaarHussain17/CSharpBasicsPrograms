using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _25_EnterRupeesToPaisa
    {
       public static void rupeesToPaisa()
        {
            Console.Write("Enter Rupees : ");
            string rupees = Console.ReadLine();

            Console.Write("Paisa = " + int.Parse(rupees) * 100);
        }
    }
}
