using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Repositories;
using SchoolSystem.Models.ViewModels;

namespace SchoolSystem.ViewModelFactory
{
    public class ClassFactory : IClassFactory
    {
        public ITeacherRepository _teacherRepository;
        public ISubjectRepository _subjectRepository;
        public IMapper _mapper;

        public ClassFactory(ITeacherRepository teacherRepository, ISubjectRepository subjectRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _subjectRepository = subjectRepository;
            _mapper = mapper;
        }

        public async Task<SettingsViewModel> CreateSettingsViewModel(int classId)
        {
            var result = await _teacherRepository.GetSettings(classId);
            var setting = _mapper.Map<SettingsViewModel>(result);

            return setting;
        }

        public async Task<List<string>> GetSubjects()
        {
            var subjects = await _subjectRepository.GetAll();
            var result = new List<string>();

            foreach (var subject in subjects)
            {
                result.Add(subject.Name);
            }

            return result;
        }
    }
}
