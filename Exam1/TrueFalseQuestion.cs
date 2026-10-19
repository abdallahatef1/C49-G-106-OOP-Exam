using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark, bool isTrue): base(header, body, mark,
              new Answer[] { new Answer(1, "True"), new Answer(2, "False") }, isTrue ? 1 : 2) { }
    }
}
