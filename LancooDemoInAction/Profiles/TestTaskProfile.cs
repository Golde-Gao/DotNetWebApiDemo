using AutoMapper;
using LancooDemoInAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LancooDemoInAction.ViewModel;

namespace LancooDemoInAction.Profiles
{
    public class TestTaskProfile:Profile
    {
        public TestTaskProfile()
        {
            CreateMap<TaskView, TestTaskViewModel>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.TaskName))
                .ForMember(dest=>dest.Id,
                    opt=>opt.MapFrom(src=>src.TaskId));

        }
    }
}
