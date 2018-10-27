using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataDomain.Data;
using DataDomain.Data.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private ApplicationDbContext _context;

        public SubjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Subject>> GetSubjects()
        {
            return await Task.Run(() => _context.Subjects.ToListAsync());
        }
    }
}
