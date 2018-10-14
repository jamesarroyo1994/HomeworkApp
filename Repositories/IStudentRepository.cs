using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IStudentRepository
    {
        Task<List<ApplicationUser>> GetStudentByClassCode(string code);
        Task<List<ApplicationUser>> GetStudents();
    }
}
