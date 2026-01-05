using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasicsPrograms
{
    internal class _17_EnterFiveSubjectsMarksAndPrintAverage
    {
        public static void fiveSubjectAverage()
        {
            Console.Write("Enter marks of subject 1 : ");
            string sub1 = Console.ReadLine();

            Console.Write("Enter marks of subject 2 : ");
            string sub2 = Console.ReadLine();

            Console.Write("Enter marks of subject 3 : ");
            string sub3 = Console.ReadLine();

            Console.Write("Enter marks of subject 4 : ");
            string sub4 = Console.ReadLine();

            Console.Write("Enter marks of subject 5 : ");
            string sub5 = Console.ReadLine();

            double allSubjects = double.Parse(sub1) + double.Parse(sub2) + double.Parse(sub3) + double.Parse(sub4) + double.Parse(sub5);

            Console.Write("Total 5 Subjects Average = " + allSubjects / 5.0);
        }
    }
}
