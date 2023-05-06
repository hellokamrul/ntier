using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TempRepo : IRepo<Template, int, string>
    {
        private readonly OkrDbContext _context;

        public TempRepo(OkrDbContext context)
        {
            _context = context;
        }

        //public TempRepo()
        //{
        //    context = new  OkrDbContext();    
        //}
        public string Add(Template obj)
        {
            try
            {
                _context.Templates.Add(obj);
                _context.SaveChanges();
                return "Template added successfully!";
            }
            catch (Exception ex)
            {
                return "Error adding template: " + ex.Message;
            }
        }


        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Template> Get()
        {
            throw new NotImplementedException();
        }

        public Template Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Template obj)
        {
            throw new NotImplementedException();
        }
    }
}
