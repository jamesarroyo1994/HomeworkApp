﻿using SchoolSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.ViewModelFactory
{
    public interface IStudentFactory
    {
        Task<StudentIndexViewModel> CreateStudentRegisterViewModel();
        Task<HomeworkIndexViewModel> CreateHomeworkViewModel();
    }
}