using Repositories;
using SchoolSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.ViewModelFactory
{
    public class HomeworkFactory : IHomeworkFactory
    {
        public IHomeworkRepository _homeworkRepo;

        public HomeworkFactory(IHomeworkRepository homeworkRepo)
        {
            _homeworkRepo = homeworkRepo;
        }

        public async Task<HomeworkViewModel> CreateHomeworkViewModel()
        {
            return new HomeworkViewModel();
        }
    }
}
