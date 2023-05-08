using DAL.DTO;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IProject
    {
        string CreateProject(ProjectDTO project);
        List<Project> GetAllProjectsByCom(int comId);
        List<Project> GetAllProjectsByOwner(int OwnerId);
        List<Project> GetAllProjectsByUser(int userId);
        string UpdateProject(Project project);
        string DeleteProject(Project project);
        string CreateUnd(List<Understanding> understanding);
        List<Understanding> GetUndByProj(int userId);
        string UpdateUnd(Understanding understanding);
        string DeleteUnd(int UndId);
    }
}
