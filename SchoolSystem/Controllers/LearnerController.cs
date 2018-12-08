using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolSystem.Helpers;
using SchoolSystem.ViewModelFactory;

namespace SchoolSystem.Controllers
{
    public class LearnerController : BaseController
    {
        public IDependencyContext _context;

        public LearnerController(IDependencyContext context) : base(context)
        {
            _context = context;
        } 
        public IStudentFactory _studentFactory;

    }
}