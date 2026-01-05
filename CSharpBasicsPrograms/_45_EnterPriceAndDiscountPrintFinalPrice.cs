using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _45_EnterPriceAndDiscountPrintFinalPrice
    {
        public static void finalPrice()
        {
            Console.Write("Enter Price : ");
            string price = Console.ReadLine();

            Console.Write("Enter Discount : ");
            string discount = Console.ReadLine();

            double ParsedPriceByDiscount = double.Parse(price) * double.Parse(discount) / 100;

            Console.WriteLine("Final Price = " + (double.Parse(price) - ParsedPriceByDiscount));
        }
    }
}
