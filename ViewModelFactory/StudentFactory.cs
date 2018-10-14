using Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModelFactory
{
    public class StudentFactory
    {
        public IStudentRepository _studentRepo;

        public StudentFactory(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }
    }
}
