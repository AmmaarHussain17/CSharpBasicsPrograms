using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _36_EnterSquareSideAndPrintPerimeteres
    {
        public static void squarePerimeter()
        {
            Console.Write("Enter Side of Square Value : ");
            string side = Console.ReadLine();

            Console.WriteLine("Perimeter of Square = " + 4 * int.Parse(side));
        }
    }
}