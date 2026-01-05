using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _12_EnterNumberAndPrintCube
    {
        public static void cube()
        {
            Console.Write("Enter Number : ");
            string num = Console.ReadLine();

            Console.WriteLine("Cube of Number = " + int.Parse(num) * int.Parse(num) * int.Parse(num));
        }
    }
}
