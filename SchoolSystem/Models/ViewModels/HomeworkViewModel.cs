﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models.ViewModels
{
    public class HomeworkViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SubjectViewModel> Subjects { get; set; }
        public int SelectedSubjectId { get; set; }
        public int? PassMark { get; set; }
        public DateTime DateDue { get; set; }
    }

    public class SubjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
