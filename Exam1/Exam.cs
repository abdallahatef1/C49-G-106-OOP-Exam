using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    abstract class Exam : ICloneable, IComparable<Exam>
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        public Subject Subject { get; set; }
        public Exam(int time, int number, Subject subject)
        {
            Time = time;
            NumberOfQuestions = number;
            Subject = subject;
            Questions = new Question[number];
        }
        public abstract void ShowExam();

        public object Clone() => MemberwiseClone();

        public int CompareTo(Exam other) => Time.CompareTo(other.Time);

        public override string ToString() => GetType().Name + " | Time: " + Time + " | Questions: " + NumberOfQuestions;

    }
}
