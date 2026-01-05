using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _13_EnterLenghtAndWidthPrintRectangleArea
    {
        public static void rectangleArea()
        {
            Console.Write("Enter Length : ");
            string length = Console.ReadLine();

            Console.Write("Enter Widht : ");
            string width = Console.ReadLine();

            Console.Write("Area of Rectangle = " + int.Parse(length) * int.Parse(width));
        }
    }
}
