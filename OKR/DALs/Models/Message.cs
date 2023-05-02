using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Message
    {
        [Key] public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UserId { get; set; }
        public int TaskId { get; set; }
        [ForeignKey("UserId")]
        public User Users { get; set; }
        [ForeignKey("TaskId")]
        public Tasks Tasks { get; set; }
    }
}
