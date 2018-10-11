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

namespace SchoolSystem.Controllers
{
    [Authorize]
    public class PortalController : Controller
    {
        public IHomeworkRepository _homeworkRepo;
        public IStudentRepository _studentRepo;
        private readonly IMapper _mapper;

        public PortalController(IHomeworkRepository homeworkRepo,
                                IStudentRepository studentRepo,
                                IMapper mapper)
        {
            _homeworkRepo = homeworkRepo;
            _studentRepo = studentRepo;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult StudentRegister()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
