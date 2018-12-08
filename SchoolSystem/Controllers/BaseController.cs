using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Helpers;

namespace SchoolSystem.Controllers
{
    public class BaseController : Controller
    {
        public IDependencyContext _context;
        public int classId = 1;

        public BaseController(IDependencyContext dependencyContext)
        {
            _context = dependencyContext;
        }
    }
}
