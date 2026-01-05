using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _37_EnterLengthWidhtHeightPrintVolume
    {
        public static void volume()
        {
            Console.Write("Enter Length : ");
            string lenght = Console.ReadLine();

            Console.Write("Enter Width : ");
            string width = Console.ReadLine();

            Console.Write("Enter Height : ");
            string height = Console.ReadLine();

            Console.WriteLine("Volume = " + double.Parse(lenght) * double.Parse(width) * double.Parse(height));
        }
    }
}
