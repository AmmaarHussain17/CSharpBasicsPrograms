using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _39_EnterSpeedTimePrintDistance
    {
        public static void distance()
        {
            Console.Write("Enter Speed : ");
            string speed = Console.ReadLine();

            Console.Write("Enter Time : ");
            string time = Console.ReadLine();

            Console.WriteLine("Distance = " + double.Parse(speed) * double.Parse(time));
        }
    }
}