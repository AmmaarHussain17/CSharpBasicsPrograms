using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _40_EnterDistanceTimePrintSpeed
    {
        public static void speed()
        {
            Console.Write("Enter Distance : ");
            string distance = Console.ReadLine();

            Console.Write("Enter Time : ");
            string time = Console.ReadLine();

            Console.WriteLine("Speed = " + double.Parse(distance) / double.Parse(time));
        }
    }
}
