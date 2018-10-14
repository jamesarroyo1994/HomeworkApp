using DataDomain.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ISubjectRepository
    {
        Task<List<Subject>> GetSubjects();
    }
}
