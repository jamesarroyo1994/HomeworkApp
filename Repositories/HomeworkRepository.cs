using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDomain.Data;
using DataDomain.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public class HomeworkRepository : Repository<Homework>, IHomeworkRepository
    {
        public ApplicationDbContext context;

        public HomeworkRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<List<Homework>> GetHomeworks(int classId)
        {
            var homeworks = await GetAll();
                
            return homeworks.Where(x => x.ClassId == classId).ToList(); 
        }

        public void Mark(Homework homework)
        {            
        }

    }
}
