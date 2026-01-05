using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _41_EnterFirstAndLastNamePrintFullName
    {
        public static void fullName()
        {
            Console.Write("Enter First Name : ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name : ");
            string lastName = Console.ReadLine();

            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
