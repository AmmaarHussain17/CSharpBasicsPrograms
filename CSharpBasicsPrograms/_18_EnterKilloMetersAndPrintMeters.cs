using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _18_EnterKilloMetersAndPrintMeters
    {
        public static void kmToM()
        {
            Console.Write("Enter Kilo Meteres : ");
            string km = Console.ReadLine();

            Console.Write("Meters = " + int.Parse(km) * 1000);
        }
    }
}
