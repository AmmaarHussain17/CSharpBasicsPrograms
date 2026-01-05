using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _03_EnterYourCityAndPrintYouLiveIn
    {
        public static void youLive()
        {
            Console.Write("Enter Your City : ");
            string city = Console.ReadLine();

            Console.WriteLine("You Live in " + city);
        }
    }
}
