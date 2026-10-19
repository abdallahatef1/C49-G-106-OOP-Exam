using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    internal class Subject : ICloneable, IComparable<Subject>
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam(int type)
        {
            if (type == 1)
            {
                Exam = new FinalExam(30, 2, this);
                Exam.Questions[0] = new TrueFalseQuestion("Q1", "C# is an object oriented language", 5, true);
                Exam.Questions[1] = new MCQQuestion("Q2", "Which symbol is used for inheritance?", 5,
                    new Answer[] { new Answer(1, "::"), new Answer(2, ":"), new Answer(3, "->") }, 2);
            }
            else
            {
                Exam = new PracticalExam(60, 2, this);
                Exam.Questions[0] = new MCQQuestion("Q1", "Which keyword creates an object?", 5,
                    new Answer[] { new Answer(1, "new"), new Answer(2, "make"), new Answer(3, "create") }, 1);
                Exam.Questions[1] = new MCQQuestion("Q2", "Which keyword prevents inheritance?", 5,
                    new Answer[] { new Answer(1, "static"), new Answer(2, "sealed"), new Answer(3, "abstract") }, 2);
            }
        }
            public object Clone() => MemberwiseClone();

        public int CompareTo(Subject other) => SubjectId.CompareTo(other.SubjectId);

        public override string ToString() => SubjectId + " - " + SubjectName;
    }

    
}
