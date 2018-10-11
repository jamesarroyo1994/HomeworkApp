using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface IStudentRepository
    {
        List<ApplicationUser> GetStudentByClassCode(string code);
        List<ApplicationUser> GetStudents();
    }
}
