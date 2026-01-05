using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _38_EnterDiameterPrintRadius
    {
        public static void diameterToRadius()
        {
            Console.Write("Enter Diameter : ");
            string diameter = Console.ReadLine();

            Console.WriteLine("Radius = " + double.Parse(diameter) / 2);
        }
    }
}
