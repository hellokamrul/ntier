using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using Microsoft.Extensions.Configuration;

public class OkrServices
{
    private readonly IMapper _mapper;
    private readonly IConfiguration _config;

    public OkrServices(IMapper mapper, IConfiguration config)
    {
        _mapper = mapper;
        _config = config;
    }

    public string Add(TemplateDTO temp)
    {
        try
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TemplateDTO, Template>();
                cfg.CreateMap<Template, TemplateDTO>();
            });
            var mapper = new Mapper(config);
            var dbtemp = mapper.Map<Template>(temp);
            var factory = new DataAccessFactory(_config);
            var rt = factory.TemplateDataAccess().Add(dbtemp);

            return rt.ToString();
        }
        catch (Exception ex)
        {
            // Log the exception details here
            Console.WriteLine($"Error adding template: {ex.Message}");
            throw;
        }

    }


    //public string CreateTemp(TemplateDTO templateDTO)
    //{
    //    var template = _mapper.Map<Template>(templateDTO);
    //    var rt = DataAccessFactory.TemplateDataAccess(_config).Add(template);
    //    return rt.ToString();
    //}
}
