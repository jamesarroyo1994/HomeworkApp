using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using SchoolSystem.Models;
using SchoolSystem.Models.ViewModels;
using SchoolSystem.ViewModelFactory;

namespace SchoolSystem.Controllers
{
    [Authorize]
    public class PortalController : Controller
    {
        public IStudentFactory _studentFactory;
        public IHomeworkFactory _homeworkFactory;
        public IClassFactory _classFactory;

        public ITeacherRepository _teacherRepository;
        public IHomeworkRepository _homeworkRepository;

        public int classId = 1;

        public PortalController(IStudentFactory studentFactory, IHomeworkFactory homeworkFactory,
                                IClassFactory classFactory, ITeacherRepository teacherRepository,
                                IHomeworkRepository homeworkRepository)
        {
            _studentFactory = studentFactory;
            _homeworkFactory = homeworkFactory;
            _classFactory = classFactory;
            _teacherRepository = teacherRepository;
            _homeworkRepository = homeworkRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> StudentRegister()
        {
            var model = await _studentFactory.CreateStudentRegisterViewModel();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Homeworks()
        {
            var model = await _homeworkFactory.CreateHomeworkIndexViewModel(classId);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateHomework()
        {
            var model = await _homeworkFactory.CreateHomeworkViewModel(classId);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateHomework(HomeworkViewModel model)
        {
            ViewBag.Success = true;
            model.Subjects = await _classFactory.GetSubjects();
            model.DateSet = DateTime.Now;
            await _homeworkFactory.Create(model);

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Settings()
        {
            var model = await _classFactory.CreateSettingsViewModel(classId);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Settings(SettingsViewModel model)
        {
            model.ClassId = classId;
            await _teacherRepository.SaveSettings(model);

            return View(model);
        }
    }
}
