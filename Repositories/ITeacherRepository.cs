using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataDomain.Data.Models;
using SchoolSystem.Models.ViewModels;

namespace Repositories
{
    public interface ITeacherRepository 
    {
        Task SaveSettings(SettingsViewModel settings);
        Task<Setting> GetSettings(int classId);
    }
}
