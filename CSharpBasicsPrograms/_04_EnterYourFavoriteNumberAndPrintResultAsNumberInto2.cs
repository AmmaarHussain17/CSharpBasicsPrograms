using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _04_EnterYourFavoriteNumberAndPrintResultAsNumberInto2
    {
        public static void favoriteNumber()
        {
            Console.Write("Enter Your Favorite Number : ");
            string number = Console.ReadLine();

            Console.WriteLine("Result = " + int.Parse(number) * 2);
        }
    }
}
