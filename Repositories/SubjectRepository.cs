using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataDomain.Data;
using DataDomain.Data.Models;
using System.Linq;

namespace Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private ApplicationDbContext _context;

        public SubjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
