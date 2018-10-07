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

namespace SchoolSystem.Controllers
{
    [Authorize]
    public class PortalController : Controller
    {
        public IHomeworkRepository homeworkRepo;

        public PortalController(IHomeworkRepository homeworkRepo)
        {
            this.homeworkRepo = homeworkRepo;
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
