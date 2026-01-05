using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _01_EnterYourNameAndPrintHelloName
    {
        public static void yourName()
        {
            Console.Write("Enter Your Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
        }
    }
}
