using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DTO
{
    public class TemplateDTOs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
       
    }
}
