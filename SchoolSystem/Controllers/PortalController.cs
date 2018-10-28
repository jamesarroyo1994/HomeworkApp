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

        public int classId = 1;

        public PortalController(IStudentFactory studentFactory, IHomeworkFactory homeworkFactory, IClassFactory classFactory, ITeacherRepository teacherRepository)
        {
            _studentFactory = studentFactory;
            _homeworkFactory = homeworkFactory;
            _classFactory = classFactory;
            _teacherRepository = teacherRepository;
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
        public async Task<IActionResult> Homework()
        {
            var model = await _homeworkFactory.CreateHomeworkIndexViewModel(classId);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> CreateHomework()
        {
            var model = new HomeworkViewModel();
            model.Subjects = await _classFactory.GetSubjects();

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateHomework(HomeworkViewModel model)
        {
            return View();
        }
    }
}
