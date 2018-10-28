using SchoolSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.ViewModelFactory
{
    public interface IHomeworkFactory
    {
        Task<HomeworkViewModel> CreateHomeworkViewModel(int classId);
        Task<HomeworkIndexViewModel> CreateHomeworkIndexViewModel(int classId);
        Task Create(HomeworkViewModel homework);
    }
}
