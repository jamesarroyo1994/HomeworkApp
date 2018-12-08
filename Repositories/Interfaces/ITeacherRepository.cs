using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataDomain.Data.Models;
using ViewModels;

namespace Repositories
{
    public interface ITeacherRepository
    {
        Task SaveSettings(SettingsModel settings);
        Task<Setting> GetSettings(int classId);
    }
}
