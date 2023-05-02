using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_test.Models
{
    public class UserTempAssign
    {
        public int TempId { get; set; }
        public int UserId { get; set; }
        public Template Template { get; set; }
        public User User { get; set; }
    }
}
