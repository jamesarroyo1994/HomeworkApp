using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModels
{
    public class HomeworkIndexModel
    {
        public int ClassId { get; set; }
        public List<HomeworkModel> Homeworks { get; set; }
    }
}
