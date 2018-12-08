using SchoolSystem.Models;

namespace DataDomain.Data.Models
{
    public class Question
    {
        public int Id { get; set; }
       /* public string Text { get; set; }
        public QuestionType Type { get; set; }
        public string Hint { get; set; } */
        public ApplicationUser User { get; set; }
        public Homework Homework { get; set; }
    }

   /* public class QuestionType
    {
        public int Id { get; set; }
        public string Type { get; set; }
    } */
}
