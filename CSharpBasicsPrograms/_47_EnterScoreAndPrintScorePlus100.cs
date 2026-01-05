using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _47_EnterScoreAndPrintScorePlus100
    {
        public static void scorePlus100()
        {
            Console.Write("Enter Score : ");
            string score = Console.ReadLine();

            Console.Write("Score = " + (int.Parse(score) + 100));
        }
    }
}
