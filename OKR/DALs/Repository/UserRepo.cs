using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    internal class UserRepo : IRepo<User, int, bool>
    {
        private readonly OkrDbContext _context;

        public UserRepo(DbContextOptions<OkrDbContext> options)
        {
            _context = new OkrDbContext(options);
        }
        public bool Add(User obj)
        {
           
                _context.Users.Add(obj);
                return _context.SaveChanges() > 0;

            
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }
    }


}
