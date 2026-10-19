using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string header, string body, int mark, Answer[] answers, int rightId) 
            : base(header, body, mark, answers, rightId) { }
    }
}
