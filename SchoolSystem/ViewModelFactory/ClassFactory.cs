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
        public IMapper _mapper;

        public ClassFactory(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public async Task<SettingsViewModel> CreateSettingsViewModel(int classId)
        {
            var result = await _teacherRepository.GetSettings(classId);
            var setting = _mapper.Map<SettingsViewModel>(result);

            return setting;
        }
    }
}
