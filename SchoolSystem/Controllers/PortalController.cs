using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Elmah;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using SchoolSystem.Helpers;
using ViewModels;
using SchoolSystem.ViewModelFactory;
using ViewModels.Homeworks;

namespace SchoolSystem.Controllers
{
    [Authorize]
    public class PortalController : BaseController
    {
        public IDependencyContext _context;

        public PortalController(IDependencyContext context) : base (context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> StudentRegister()
        {
            var model = await _context.StudentFactory.CreateStudentRegisterViewModel();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Homeworks()
        {
            var model = await _context.HomeworkFactory.CreateHomeworkIndexViewModel(classId);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateHomework()
        {
            var model = await _context.HomeworkFactory.CreateHomeworkViewModel(classId);
            return View(model);
        }

        public async Task<IActionResult> CreateQuestion(int homeworkId)
        {
            var model = new CreateQuestionModel();
            model.Homework = await _context.HomeworkFactory.CreateHomeworkViewModel(classId);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateHomework(HomeworkModel model)
        {
            TempData["Success"] = "Some value";
            model.Subjects = await _context.ClassFactory.GetSubjects();
            model.DateSet = DateTime.Now;
            await _context.HomeworkFactory.Create(model);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Settings()
        {
            var model = await _context.ClassFactory.CreateSettingsViewModel(classId);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Settings(SettingsModel model)
        {
            model.ClassId = classId;
            await _context.TeacherRepository.SaveSettings(model);

            return View(model);
        }
    }
}
