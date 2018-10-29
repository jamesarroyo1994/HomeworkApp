using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Repositories;
using ViewModels;

namespace SchoolSystem.ViewModelFactory
{
    public interface IClassFactory
    {
        Task<SettingsModel> CreateSettingsViewModel(int classId);
        Task<List<SubjectModel>> GetSubjects();
    }

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

        public async Task<SettingsModel> CreateSettingsViewModel(int classId)
        {
            var result = await _teacherRepository.GetSettings(classId);
            var setting = _mapper.Map<SettingsModel>(result);

            return setting;
        }

        public async Task<List<SubjectModel>> GetSubjects()
        {
            var result = _mapper.Map<List<SubjectModel>>(await _subjectRepository.GetAll());

            return result;
        }
    }
}
