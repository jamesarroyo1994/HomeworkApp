using AutoMapper;
using DataDomain.Data.Models;
using Repositories;
using SchoolSystem.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.ViewModelFactory
{
    public class HomeworkFactory : IHomeworkFactory
    {
        public IHomeworkRepository _homeworkRepo;
        public ISubjectRepository _subjectRepo;

        public IClassFactory _classFactory;

        public IMapper _mapper;

        public HomeworkFactory(IHomeworkRepository homeworkRepo, ISubjectRepository subjectRepo, IMapper mapper, IClassFactory classFactory)
        {
            _homeworkRepo = homeworkRepo;
            _subjectRepo = subjectRepo;
            _classFactory = classFactory;
            _mapper = mapper;
        }

        public async Task<HomeworkIndexViewModel> CreateHomeworkIndexViewModel(int classId)
        {
            var model = new HomeworkIndexViewModel();
            var result = await _homeworkRepo.GetHomeworks(classId);

            model.Homeworks = result.Select(x => new HomeworkViewModel()
            {
                Title = x.Title,
                Description = x.Description,
                Subject = _subjectRepo.GetById(x.SubjectId).Result.Name,
                DateDue = x.DateDue,
                DateSet = x.DateSet,
               
            }).ToList();

            return model;
        }

        public async Task<HomeworkViewModel> CreateHomeworkViewModel(int classId)
        {
            var model = new HomeworkViewModel();
            model.ClassId = classId;
            model.Subjects = await _classFactory.GetSubjects();

            return model;
        }

        public async Task Create(HomeworkViewModel model)
        {
            await _homeworkRepo.Create(_mapper.Map<Homework>(model));
        }
    }
}
