using ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using SchoolSystem.Models;
using DataDomain.Data.Models;

namespace SchoolSystem.AutoMapper
{   
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<HomeworkModel, Homework>();
            CreateMap<Homework, HomeworkModel>();
            CreateMap<Setting, SettingsModel>();
            CreateMap<SettingsModel, Setting>();
            CreateMap<Subject, SubjectModel>();
            CreateMap<SubjectModel, Subject>();
        }
    }
}
