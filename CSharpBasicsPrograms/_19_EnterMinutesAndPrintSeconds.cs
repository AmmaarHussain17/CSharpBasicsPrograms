using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _19_EnterMinutesAndPrintSeconds
    {
        public static void minutesToSeconds()
        {
            Console.Write("Enter Minutes : ");
            String minutes = Console.ReadLine();

            Console.Write("Seconds = " + int.Parse(minutes) * 60);
        }
    }
}
