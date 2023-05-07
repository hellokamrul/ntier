using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace DAL
{
    public class DataAccessFactory
    {

        //private readonly IConfiguration _configuration;
        //private readonly DbContextOptions<OkrDbContext> _options;

        //public DataAccessFactory(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //    _options = new DbContextOptionsBuilder<OkrDbContext>()
        //        .UseNpgsql(_configuration.GetConnectionString("DefaultConnection"))
        //        .Options;
        //}

        //public IRepo<Template, int, string> TemplateDataAccess()
        //{
        //    return new TempRepo(new OkrDbContext(_options));
        //}

        public IRepo<Template, int, string> TemplateDataAccess()
        {
            return new TempRepo();
        }

    }
}
