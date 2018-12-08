using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModels
{
    public class HomeworkModel
    {
        public int ClassId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int SubjectId { get; set; }
        public int PassMark { get; set; }
        public string Subject { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateSet { get; set; }
        public List<SubjectModel> Subjects { get; set; }
    }
}
