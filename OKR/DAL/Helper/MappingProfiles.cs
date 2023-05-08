using AutoMapper;
using DAL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<DepartmentDTO, Department>();
            CreateMap<CompanyDTO, Company>();
            CreateMap<UserDTO, User>();
            CreateMap<TemplateDTO, Template>();
            CreateMap<TasksDTO, Tasks>();
        }
    }
}
