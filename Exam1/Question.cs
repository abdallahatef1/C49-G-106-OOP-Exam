using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    abstract class Question :ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }
        public Question(string header, string body, int mark, Answer[] answers, int rightId)
       : this(header, body, mark)
        {
            AnswerList = answers;
            RightAnswer = answers[rightId - 1];
        }
        public void Show()
        {
            Console.WriteLine(Header + ": " + Body + " (" + Mark + " marks)");
            foreach (Answer a in AnswerList)
                Console.WriteLine("   " + a);
        }
        public object Clone() => MemberwiseClone();

        public int CompareTo(Question other) => Mark.CompareTo(other.Mark);

        public override string ToString() => Header + " - " + Body + " - " + Mark;
    }



}
