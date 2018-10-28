﻿using SchoolSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.ViewModelFactory
{
    public interface IHomeworkFactory
    {
        Task<HomeworkViewModel> CreateHomeworkViewModel();
        Task<HomeworkIndexViewModel> CreateHomeworkIndexViewModel(int classId);
    }
}