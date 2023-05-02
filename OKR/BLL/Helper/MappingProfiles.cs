using AutoMapper;
using BLL.DTO;
using DAL.Models;

namespace BLL.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<DepartmentDTO, Department>();
            CreateMap<CompanyDTO, Company > ();
            CreateMap<UserDTO, User > ();
            CreateMap<TemplateDTO, Template> ();
            CreateMap<TasksDTO, Tasks> ();
            CreateMap<ProjectDTO, Project> ();
        }
    }
}
