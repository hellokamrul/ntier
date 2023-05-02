using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.DTO
{
    public class TemplateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
       
    }
}
