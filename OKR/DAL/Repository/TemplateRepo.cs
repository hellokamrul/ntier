using AutoMapper;
using DAL.Context;
using DAL.DTO;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    
    
    public class TemplateRepo : ITemplate
    {
        private readonly OkrDbContext _context;
        private readonly IMapper _mapper;

        public TemplateRepo(OkrDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public string CreateTask(TasksDTO tasks)
        {
            Tasks obj = new Tasks
            {
                Name = tasks.Name,
                PId = tasks.PId,
                CreatedDate = DateTime.SpecifyKind(DateTime.Parse("29-May-2023"), DateTimeKind.Utc),
                DueDate = DateTime.SpecifyKind(DateTime.Parse("26-May-2023"), DateTimeKind.Utc),
                EstimatedDate = DateTime.SpecifyKind(DateTime.Parse("07-May-2023"), DateTimeKind.Utc),
                TempId = tasks.TempId



            };

            try
            {
               // var data = _mapper.Map<Tasks>(tasks);
                _context.Tasks.Add(obj);
                var state = (_context.SaveChanges());
                if (state > 0)
                {
                    return "Task Created...";
                }
                else
                {
                    return "An Error Occur..!!";
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred while creating the task: {ex.Message}";
            }
        }


        public string CreateTemplate(TemplateDTO template)
        {
            Template temp = new Template
            {
                Id = template.Id,
                Name = template.Name,
                OwnerId = template.OwnerId,

            };
            _context.Templates.Add(temp);
               
            return _context.SaveChanges().ToString();
        }

        public string DeleteTask(int id)
        {
            try
            {
                var task = _context.Tasks.SingleOrDefault(x => x.Id == id);
                if (task != null)
                {
                    _context.Tasks.Remove(task);
                    _context.SaveChanges();
                    return "Deleted Successfully.";
                }
                else
                {
                    return "Task not found.";
                }
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }


        public string DeleteTemp(TemplateDTO templateDTO)
        {
            throw new NotImplementedException();
        }

        public string EditTemp(TemplateDTO templateDTO)
        {
            throw new NotImplementedException();
        }

        public List<Tasks> GetTaskListByTemp(int tId)
        {
            throw new NotImplementedException();
        }

        public List<Tasks> GetTaskListByUser(int? userId)
        {
            throw new NotImplementedException();
        }

        public List<Template> GetTemplateList()
        {
            return _context.Templates.Include(t => t.Owner).ToList();
        }

        public List<Template> GetTempListByUser(int? userId)
        {
            throw new NotImplementedException();
        }

        public List<Template> GetTempOwner(int uId)
        {
            throw new NotImplementedException();
        }

        public List<UserTaskAssign> GetTodayTaskByUid(int uid)
        {
            var taskList = _context.UserTaskAssigns.Where(t => t.UserId == uid && t.Tasks.DueDate.Date == DateTime.UtcNow.Date).ToList(); 
            return taskList;

        }

        public string UpdateTask(TasksDTO task)
        {
            var existingTask = _context.Tasks.SingleOrDefault(x => x.Id == task.Id);
            if (existingTask != null)
            {
                existingTask.Name = task.Name;
                existingTask.PId = task.PId;
                existingTask.CreatedDate = task.CreatedDate;
                existingTask.DueDate = task.DueDate;
                existingTask.EstimatedDate = task.EstimatedDate;
                existingTask.TempId = task.TempId;

                _context.SaveChanges();
                return "Task updated successfully.";
            }
            else
            {
                return "Task not found.";
            }
        }


        public bool UserExists(int? userId)
        {
            throw new NotImplementedException();
        }
    }
}
