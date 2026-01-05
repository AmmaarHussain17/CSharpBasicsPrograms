using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _15_EnterRadiusPrintCircleArea
    {
        public static void cirlceArea()
        {
            Console.Write("Enter Radius : ");
            string radius = Console.ReadLine();

            Console.WriteLine("Area of Circle = " + 3.14 * double.Parse(radius) * double.Parse(radius));
        }
    }
}
