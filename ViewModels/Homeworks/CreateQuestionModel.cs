using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Homeworks
{
    public class CreateQuestionModel
    {
        public string Text { get; set; }
        public string Answer { get; set; }
        public HomeworkModel Homework { get; set; }
        public string Hint { get; set; }
    }
}
