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

        public StudentFactory(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        public StudentIndexViewModel CreateStudentRegisterViewModel()
        {
            var model = new StudentIndexViewModel();
            var students = _studentRepo.GetStudents().Select(x => new StudentViewModel
            {
                Forename = x.Forename,
                Surname = x.Surname
            }).ToList();

            model.Students = students;

            return model;
        }
    }
}
