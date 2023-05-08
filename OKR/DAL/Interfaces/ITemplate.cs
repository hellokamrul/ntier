using DAL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ITemplate
    {
        List<UserTaskAssign> GetTodayTaskByUid(int uid);  
        List<Template> GetTemplateList();  
        string CreateTemplate(TemplateDTO template);
        //string CreateTemp(TemplateDTO templateDTO);
        String EditTemp(TemplateDTO templateDTO);   
        String DeleteTemp(TemplateDTO templateDTO);
        List<Template> GetTempOwner(int uId);
        string CreateTask(TasksDTO tasks);
        List<Tasks> GetTaskListByTemp(int tId);
        string UpdateTask(TasksDTO task);
        string DeleteTask(int id);
        List<Tasks> GetTaskListByUser(int? userId);
        bool UserExists(int? userId);
        List<Template> GetTempListByUser(int? userId);
    }
}
