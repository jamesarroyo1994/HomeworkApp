using AutoMapper;
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
        public IMapper _mapper;

        public HomeworkFactory(IHomeworkRepository homeworkRepo, ISubjectRepository subjectRepo, IMapper mapper)
        {
            _homeworkRepo = homeworkRepo;
            _subjectRepo = subjectRepo;
            _mapper = mapper;
        }

        public async Task<HomeworkViewModel> CreateHomeworkViewModel()
        {
            var result = new HomeworkViewModel();
            result.Subjects = _mapper.Map<List<SubjectViewModel>>(await _subjectRepo.GetSubjects());

            return new HomeworkViewModel();
        }
    }
}
