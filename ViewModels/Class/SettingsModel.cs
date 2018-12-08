using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModels
{
    public class SettingsModel : BaseModel
    {
        public string PassMessage { get; set; }
        public string FailMessage { get; set; }
    }
}
