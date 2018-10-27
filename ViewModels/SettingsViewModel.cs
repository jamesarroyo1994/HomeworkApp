using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolSystem.Models.ViewModels
{
    public class SettingsViewModel
    {
        public int ClassId { get; set; }
        public string PassMessage { get; set; }
        public string FailMessage { get; set; }
    }
}
