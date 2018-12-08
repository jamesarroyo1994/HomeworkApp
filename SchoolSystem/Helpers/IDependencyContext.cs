using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Repositories;
using SchoolSystem.ViewModelFactory;

namespace SchoolSystem.Helpers
{
    public interface IDependencyContext
    {
        IStudentFactory StudentFactory { get; }
        IHomeworkFactory HomeworkFactory { get; }
        IClassFactory ClassFactory { get; set; }

        ITeacherRepository TeacherRepository { get; set; }
        IHomeworkRepository HomeworkRepository { get; set; }
        ISubjectRepository SubjectRepository { get; set; }
        IStudentRepository StudentRepository { get; set; }
        
        IMapper Mapper { get; set; }
    }

    public class DependencyContext : IDependencyContext
    {
        public DependencyContext(IStudentFactory studentFactory, IHomeworkFactory homeworkFactory, IClassFactory classFactory,
            ITeacherRepository teacherRepository, IHomeworkRepository homeworkRepository, ISubjectRepository subjectRepository, IMapper mapper,
            IStudentRepository studentRepository)
        {
            StudentFactory = studentFactory;
            HomeworkFactory = homeworkFactory;
            ClassFactory = classFactory;
            TeacherRepository = teacherRepository;
            HomeworkRepository = homeworkRepository;
            SubjectRepository = subjectRepository;
            Mapper = mapper;
            StudentRepository = studentRepository;
        }

        public IStudentFactory StudentFactory { get; }
        public IHomeworkFactory HomeworkFactory { get; }
        public IClassFactory ClassFactory { get; set; }
        public ITeacherRepository TeacherRepository { get; set; }
        public IHomeworkRepository HomeworkRepository { get; set; }
        public ISubjectRepository SubjectRepository { get; set; }
        public IStudentRepository StudentRepository { get; set; }
        public IMapper Mapper { get; set; }
    }
}
