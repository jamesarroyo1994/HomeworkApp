using SchoolSystem.Models.ViewModels;
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
            CreateMap<HomeworkViewModel, Homework>();
            CreateMap<Homework, HomeworkViewModel>();
            CreateMap<Setting, SettingsViewModel>();
            CreateMap<SettingsViewModel, Setting>();
            CreateMap<Subject, SubjectViewModel>();
            CreateMap<SubjectViewModel, Subject>();
        }
    }
}
