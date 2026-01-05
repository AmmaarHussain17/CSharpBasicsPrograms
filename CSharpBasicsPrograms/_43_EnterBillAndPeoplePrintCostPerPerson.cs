using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _43_EnterBillAndPeoplePrintCostPerPerson
    {
        public static void costPerPerson()
        {
            Console.Write("Enter Bill : ");
            string bill = Console.ReadLine();

            Console.Write("Enter Number of People : ");
            string people = Console.ReadLine();

            double billPerPerson = double.Parse(bill) / double.Parse(people);

            Console.WriteLine("Bill Per Person = " + billPerPerson);
        }
    }
}
