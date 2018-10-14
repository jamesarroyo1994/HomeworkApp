using DataDomain.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using AutoMapper;
using SchoolSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Repositories
{
    public class StudentRepository : IStudentRepository
    {
        public ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ApplicationUser>> GetStudentByClassCode(string code)
        {
            return await Task.Run(() => _context.Users
                           .Include(x => x.Class)
                           .Where(x => x.Class.ClassCode == code).ToList());
        }

        public async Task<List<ApplicationUser>> GetStudents()
        {
            return await Task.Run(() => _context.Users.ToListAsync());
        }


    }
}
