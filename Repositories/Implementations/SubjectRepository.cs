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
    public class SubjectRepository : Repository<Subject>, ISubjectRepository
    {
        private ApplicationDbContext _context;

        public SubjectRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
