using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _14_EnterBaseAndHeightPrintTriangleArea
    {
        public static void triangleArea()
        {
            Console.Write("Enter length : ");
            string length = Console.ReadLine();

            Console.Write("Enter Height : ");
            string height = Console.ReadLine();

            Console.WriteLine("Area of Triangle = " + 0.5 * double.Parse(height) * double.Parse(length));
        }
    }
}
