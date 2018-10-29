using Repositories;
using ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.ViewModelFactory
{
    public interface IStudentFactory
    {
        Task<StudentIndexModel> CreateStudentRegisterViewModel();
        Task<HomeworkIndexModel> CreateHomeworkViewModel();
    }

    public class StudentFactory : IStudentFactory
    {
        public IStudentRepository _studentRepo;
        int classId = 1;

        public StudentFactory(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public Task<HomeworkIndexModel> CreateHomeworkViewModel()
        {
            throw new NotImplementedException();
        }

        /* public Task<HomeworkIndexViewModel> CreateHomeworkViewModel()
        {
            var model = new HomeworkIndexViewModel();
            var homeworks = _studentRepo.GetHomeworks(classId);
        } */

        public async Task<StudentIndexModel> CreateStudentRegisterViewModel()
        {
            var model = new StudentIndexModel();
            var students = (await _studentRepo.GetStudents()).
                Select(x => new StudentModel
                {
                    Forename = x.Forename,
                    Surname = x.Surname
                }).ToList();

            model.Students = students;

            return model;
        }
    }
}
