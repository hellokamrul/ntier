using AutoMapper;
using BLL.Helper;
using DAL.DTO;
using DAL.Models;
using DAL.Repository;
using Microsoft.EntityFrameworkCore;

namespace BLL.Services
{
    public class OkrServices : MappingProfiles
    {
        private readonly IMapper _mapper;
        private readonly TemplateRepo _templateRepo;
        public OkrServices(IMapper mapper,TemplateRepo repo)
        {
            _mapper = mapper;
            _templateRepo = repo;        
        }
        public string CreateTemp(TemplateDTO templateDTO)
        {

            Template template = _mapper.Map<Template>(templateDTO);

            return _templateRepo.CreateTemplate(template).ToString();

            //var state = _context.SaveChanges();
            //if (state > 0)
            //{
            //    return "Successful";
            //}
            //return "Failed";

            //var config = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<TemplateDTO, Template>();
            //    cfg.CreateMap<Template, TemplateDTO>();
            //});
            //var mapper = new Mapper(config);
            //var dbtemp = mapper.Map<TemplateDTO>(templateDTO);
            //var rt = _templateRepo.CreateTemplate(dbtemp).ToString();
            //return rt;

        }
    }
}
