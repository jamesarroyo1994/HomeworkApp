using DataDomain.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using SchoolSystem.Models;

namespace Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ApplicationUser> GetStudentByClassCode(string code)
        {
            return _context.Users.ToList();
        }

        public List<ApplicationUser> GetStudents()
        {
            return _context.Users.ToList();
        }


    }
}
