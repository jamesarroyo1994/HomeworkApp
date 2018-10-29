using AutoMapper;
using DataDomain.Data.Models;
using Repositories;
using ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.ViewModelFactory
{
    public interface IHomeworkFactory
    {
        Task<HomeworkModel> CreateHomeworkViewModel(int classId);
        Task<HomeworkIndexModel> CreateHomeworkIndexViewModel(int classId);
        Task Create(HomeworkModel homework);
    }

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

        public async Task<HomeworkIndexModel> CreateHomeworkIndexViewModel(int classId)
        {
            var model = new HomeworkIndexModel();
            var result = await _homeworkRepo.GetHomeworks(classId);

            model.Homeworks = result.Select(x => new HomeworkModel()
            {
                Title = x.Title,
                Description = x.Description,
                Subject = _subjectRepo.GetById(x.SubjectId).Result.Name,
                DateDue = x.DateDue,
                DateSet = x.DateSet,
               
            }).ToList();

            return model;
        }

        public async Task<HomeworkModel> CreateHomeworkViewModel(int classId)
        {
            var model = new HomeworkModel();
            model.ClassId = classId;
            model.Subjects = await _classFactory.GetSubjects();

            return model;
        }

        public async Task Create(HomeworkModel model)
        {
            await _homeworkRepo.Create(_mapper.Map<Homework>(model));
        }
    }
}
