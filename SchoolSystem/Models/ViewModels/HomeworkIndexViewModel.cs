using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models.ViewModels
{
    public class HomeworkIndexViewModel
    {
        public int ClassId { get; set; }
        public List<HomeworkViewModel> Homeworks { get; set; }
    }
}
