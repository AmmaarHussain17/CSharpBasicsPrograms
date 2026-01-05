using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _46_EnterHeroNameAndPowerPrintStoryLine
    {
        public static void storyLine()
        {
            Console.Write("Enter Hero name : ");
            string heroName = Console.ReadLine();

            Console.Write("Enter Hero power : ");
            string heroPower = Console.ReadLine();

            Console.WriteLine("Story line = " + heroName + " " + heroPower);
        }
    }
}