using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    
    
    public class TemplateRepo : ITemplate
    {
        private readonly OkrDbContext _context;
        public TemplateRepo(OkrDbContext context)
        {
            _context = context;
        }
        public List<UserTaskAssign> GetTodayTaskByUid(int uid)
        {
            var taskList = _context.UserTaskAssigns.Where(t => t.UserId == uid && t.Tasks.DueDate.Date == DateTime.UtcNow.Date).ToList(); 
            return taskList;

        }
    }
}
