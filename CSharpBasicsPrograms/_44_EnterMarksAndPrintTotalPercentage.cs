using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _44_EnterMarksAndPrintTotalPercentage
    {
        public static void totalPer()
        {
            Console.Write("Enter Marks : ");
            string marks = Console.ReadLine();

            Console.Write("Enter Total : ");
            string total = Console.ReadLine();

            Console.Write("Percantage = " + double.Parse(marks) / double.Parse(total) * 100 + " %");
        }
    }
}
