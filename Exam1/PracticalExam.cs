using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    internal class PracticalExam: Exam
    {
        public PracticalExam(int time, int number, Subject subject) : base(time, number, subject) { }

        public override void ShowExam()
        {
            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].Show();
                Console.Write("Your answer (id): ");
                Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("--- Right Answers ---");
            for (int i = 0; i < Questions.Length; i++)
                Console.WriteLine(Questions[i].Header + ": " + Questions[i].RightAnswer);
        }
    }
}
