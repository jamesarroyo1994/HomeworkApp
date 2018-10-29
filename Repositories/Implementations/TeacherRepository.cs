using AutoMapper;
using DataDomain.Data;
using DataDomain.Data.Enums;
using DataDomain.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        public ApplicationDbContext _context;
        public IMapper _mapper;

        public TeacherRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }
    
        public async Task<Setting> GetSettings(int classId)
        {
            var result = _context.Settings.FirstOrDefault(x => x.ClassId == classId);
            return result;
        }

        public async Task SaveSettings(SettingsModel model)
        {
            var setting = _context.Settings.FirstOrDefault(x => x.ClassId == model.ClassId);
           
            if (setting != null)
            {
                setting.PassMessage = model.PassMessage;
                setting.FailMessage = model.FailMessage;
            }
            else
            {
                setting = _mapper.Map<Setting>(model);
                _context.Settings.Add(setting);
            }

            _context.SaveChanges();
        }
    }
}
