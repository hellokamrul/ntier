using System.ComponentModel.DataAnnotations.Schema;

namespace DAL_test.Models
{
    public class UserTaskAssign
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public Tasks Tasks { get; set; }
        public User User { get; set; }
    }
}
