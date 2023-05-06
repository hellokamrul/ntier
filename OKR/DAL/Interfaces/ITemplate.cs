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
        string CreateTemplate(Template template);
    }
}
