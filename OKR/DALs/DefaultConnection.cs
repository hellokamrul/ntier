using DAL.Context;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repository;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, int, bool> UserDataAccess()
        {
          
            var optionsBuilder = new DbContextOptionsBuilder<OkrDbContext>();
            optionsBuilder.UseNpgsql("Server=localhost;Database=GTR_OKR;Port=5432;User Id=postgres;Password=GTR;");

            var options = optionsBuilder.Options;

            return new UserRepo(options);
        }

    }
}
