using System;
using SchoolSystem.Models;

namespace DataDomain.Data.Models
{
    public class Homework
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? PassMark { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DateSet { get; set; }
        public DateTime DateDue { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}