using DAL.Context;
using DAL.DTO;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProjectRepo : IProject
    {

        private readonly OkrDbContext _context;
        public ProjectRepo(OkrDbContext context)
        {
            _context = context;
        }
        public string CreateProject(ProjectDTO project)
        {
            Project obj = new Project
            {
                Name = project.Name,
                DueDate = DateTime.SpecifyKind(DateTime.Parse("29-May-2023"), DateTimeKind.Utc),
                EstDate = DateTime.SpecifyKind(DateTime.Parse("26-May-2023"), DateTimeKind.Utc),
                CreateDate = DateTime.SpecifyKind(DateTime.Parse("07-May-2023"), DateTimeKind.Utc),
                Progress = project.Progress,
                Tags = project.Tags,
                ComId = project.ComId,
                OwnerId = project.OwnerId,
                TempId = project.TempId,
                UndId = project.UndId,
                DeptId = project.DeptId
            };

            _context.Projects.Add(obj);
            return _context.SaveChanges().ToString();
        }




        public string CreateUnd(List<Understanding> understanding)
        {
            throw new NotImplementedException();
        }

        public string DeleteProject(Project project)
        {
            throw new NotImplementedException();
        }

        public string DeleteUnd(int UndId)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllProjectsByCom(int comId)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllProjectsByOwner(int OwnerId)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetAllProjectsByUser(int userId)
        {
            throw new NotImplementedException();
        }

        public List<Understanding> GetUndByProj(int userId)
        {
            throw new NotImplementedException();
        }

        public string UpdateProject(Project project)
        {
            throw new NotImplementedException();
        }

        public string UpdateUnd(Understanding understanding)
        {
            throw new NotImplementedException();
        }
    }
}
