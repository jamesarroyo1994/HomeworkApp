using SchoolSystem.Models;

namespace DataDomain.Data.Models
{
    public class Question
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public Homework Homework { get; set; }
    }
}
