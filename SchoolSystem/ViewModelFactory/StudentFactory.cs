using Repositories;
using SchoolSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.ViewModelFactory
{
    public class StudentFactory : IStudentFactory
    {
        public IStudentRepository _studentRepo;
        int classId = 1;

        public StudentFactory(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public Task<HomeworkIndexViewModel> CreateHomeworkViewModel()
        {
            throw new NotImplementedException();
        }

        /* public Task<HomeworkIndexViewModel> CreateHomeworkViewModel()
        {
            var model = new HomeworkIndexViewModel();
            var homeworks = _studentRepo.GetHomeworks(classId);
        } */

        public async Task<StudentIndexViewModel> CreateStudentRegisterViewModel()
        {
            var model = new StudentIndexViewModel();
            var students = (await _studentRepo.GetStudents()).
                Select(x => new StudentViewModel
                {
                    Forename = x.Forename,
                    Surname = x.Surname
                }).ToList();

            model.Students = students;

            return model;
        }
    }
}
