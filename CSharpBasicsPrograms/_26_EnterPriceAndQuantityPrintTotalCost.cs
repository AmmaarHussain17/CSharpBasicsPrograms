using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _26_EnterPriceAndQuantityPrintTotalCost
    {
        public static void totalCost()
        {
            Console.Write("Enter Price : ");
            string price = Console.ReadLine();

            Console.Write("Enter Quantity : ");
            string quantity = Console.ReadLine();

            Console.WriteLine("Total Cost = " + double.Parse(price) * double.Parse(quantity));
        }
    }
}
