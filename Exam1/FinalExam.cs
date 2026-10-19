using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int number, Subject subject) : base(time, number, subject) { }

        public override void ShowExam()
        {
            int grade = 0, total = 0;

            for (int i = 0; i < Questions.Length; i++)
            {
                Questions[i].Show();
                Console.Write("Your answer (id): ");
                int choice = int.Parse(Console.ReadLine());

                total += Questions[i].Mark;
                if (choice == Questions[i].RightAnswer.AnswerId)
                    grade += Questions[i].Mark;
                Console.WriteLine();
            }

            Console.WriteLine("Grade: " + grade + " / " + total);
        }
    }
}
