using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolSystem.Models.AccountViewModels;

namespace SchoolSystem.Models.ViewModels
{
    public class HomeViewModel
    {
        public ApplicationUser User { get; set; }
        public bool IsAuthenticated { get; set; }
        public string UserId { get; set; }
    }
}
