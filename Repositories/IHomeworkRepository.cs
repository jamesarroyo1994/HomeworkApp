﻿using System;
using System.Collections.Generic;
using System.Text;
using DataDomain.Data.Models;

namespace Repositories
{
    public interface IHomeworkRepository : IRepository<Homework>
    {
        IEnumerable<Homework> GetHomeworks();
    }
}
