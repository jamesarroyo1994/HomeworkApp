using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataDomain.Data.Models;

namespace Repositories
{
    public interface IHomeworkRepository : IRepository<Homework>
    {
        void Mark(Homework homework);
        Task<List<Homework>> GetHomeworks(int classId);
    }
}
