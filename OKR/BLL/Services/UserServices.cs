using AutoMapper;
using BLL.DTO;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserServices
    {
        //private readonly IMapper _mapper;

        //public UserServices( IMapper mapper)
        //{

        //    _mapper = mapper;
        //}

        public static bool Add(UserDTO userDTO)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDTO, User>();
                cfg.CreateMap<User, UserDTO>();
            });
            var mapper = new Mapper(config);
            var dbuser = mapper.Map<User>(userDTO);
            var rt = DataAccessFactory.UserDataAccess().Add(dbuser);
            return rt;
        }

        //public string CreateCompany(UserDTO userDTO)
        //{
        //    var user = _mapper.Map<User>(userDTO);
        //    var rt = DataAccessFactory.UserDataAccess().Add(user);
        //    if(rt == true)
        //    {
        //        return rt.ToString();   
        //    }
        //    else {

        //            return "Failed";
        //        }
        //}

        //controller done..
        //public string CreateDept(DepartmentDTO department)
        //{
        //    //Department dept = new Department
        //    //{
        //    //    Id = department.Id,
        //    //    DepartmentName = department.DepartmentName,
        //    //    ComId = department.ComId,

        //    //};
        //    var dept = _mapper.Map<Department>(department);
        //    _db.Departments.Add(dept);
        //    var state = _db.SaveChanges();
        //    if (state > 0)
        //    {
        //        return "Successful";

        //    }
        //    return "Failed";
        //}

        ////controller done..
        //public string CreateUser(UserDTO user)
        //{
        //    User userInfo = new User
        //    {
        //        UserId = user.UserId,
        //        Name = user.Name,
        //        Email = user.Email,
        //        Phone = user.Phone,
        //        Role = user.Role,
        //        ComId = user.ComId,
        //        DeptId = user.DeptId
        //    };
        //    _db.Add(userInfo);
        //    var state = _db.SaveChanges();
        //    if (state > 0)
        //    {
        //        return "Successful";
        //    }
        //    return "Failed";
        //}

        ////controller done..
        //public string EditCompany(CompanyDTO company)
        //{
        //    Company com = new Company
        //    {
        //        Id = company.Id,
        //        CompanyName = company.CompanyName,
        //        ComId = company.ComId,
        //        Email = company.Email
        //    };
        //    _db.Companies.Update(com);
        //    var state = _db.SaveChanges();
        //    if (state > 0)
        //    {
        //        return "Successful";
        //    }
        //    return "Failed";
        //}

        ////controller done..
        //public Company GetCompanyByEmail(string email)
        //{
        //    Company company = _db.Companies.FirstOrDefault(c => c.Email == email);

        //    return company;
        //}
        ////controller done...
        //public List<Company> GetCompanyList()
        //{
        //    return _db.Companies.ToList();
        //}

        ////controller done..
        //public List<Department> GetDeptByCom(int comId)
        //{
        //    List<Department> depList = _db.Departments.Where(c => c.ComId == comId).ToList();
        //    return depList;
        //}

        ////controller done..
        //public Department GetDeptById(int id)
        //{
        //    return _db.Departments.Include(c => c.Company).FirstOrDefault(c => c.Id == id);
        //}

        ////controller done..
        //public User GetUserByEmail(string email)
        //{
        //    return _db.Users.FirstOrDefault(c => c.Email == email);
        //}

        ////controller done..
        //public User GetUserById(int id)
        //{
        //    return _db.Users.FirstOrDefault(c => c.Id == id);
        //}

        ////controller done..
        //public List<User> GetUserListByCom(int comId)
        //{
        //    return _db.Users.Where(c => c.ComId == comId).ToList();
        //}

        ////contrller done...
        //public List<User> GetUserListByDept(int deptId)
        //{
        //    return _db.Users.Where(c => c.DeptId == deptId).ToList();
        //}

        //public List<User> GetUserListByTemp(int? tempId)
        //{

        //    return _db.UserTempAssigns.Where(c => c.TempId == tempId).Select(c => c.User).ToList();

        //}

        //public List<User> GetUserListByTask(int? taskId)
        //{
        //    return _db.UserTaskAssigns.Where(c => c.TaskId == taskId).Select(c => c.User).ToList();

        //}
    }
}
