using System;
using System.Collections.Generic;
using System.Text;

namespace DataDomain.Data.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public string PassMessage { get; set; }
        public string FailMessage { get; set; }
    }
}
