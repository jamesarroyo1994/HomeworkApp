using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using Repositories;
using SchoolSystem.Models;
using SchoolSystem.Models.ViewModels;
using AutoMapper;
using DataDomain.Data.Models;
using SchoolSystem.ViewModelFactory;

namespace SchoolSystem.Controllers
{
    [Authorize]
    public class PortalController : Controller
    {
        public IStudentFactory _studentFactory;
        public IHomeworkFactory _homeworkFactory;
        private readonly IMapper _mapper;

        public PortalController(IStudentFactory studentFactory, IHomeworkFactory homeworkFactory, IMapper mapper)
        {
            _studentFactory = studentFactory;
            _homeworkFactory = homeworkFactory;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StudentRegister()
        {
            var model = _studentFactory.CreateStudentRegisterViewModel();
            return View(model);
        }

        public IActionResult CreateHomework()
        {
            var model = _homeworkFactory.CreateHomeworkViewModel();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateHomework(HomeworkViewModel model)
        {
            return View();
        }



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
