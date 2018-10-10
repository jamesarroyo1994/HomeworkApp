using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void Mark(Homework homework)
        {            
        }

    }
}
