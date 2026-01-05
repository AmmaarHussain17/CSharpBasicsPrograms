using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _27_EnterAmountGSTAndPrintGSTAmount
    {
        public static void GSTAmount()
        {
            Console.Write("Enter Amount : ");
            string amount = Console.ReadLine();

            Console.Write("Enter GST % : ");
            string gst = Console.ReadLine();

            double ParsedAmount = double.Parse(amount);
            double ParsedGst = double.Parse(gst);

            double amountWIthGST = ParsedAmount * (ParsedGst / 100.0);

            Console.WriteLine("GST amount : " + (amountWIthGST - ParsedGst));
        }
    }
}
