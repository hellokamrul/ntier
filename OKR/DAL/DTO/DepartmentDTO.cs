using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.DTO
{
    public class DepartmentDTO
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int ComId { get; set; }
    }
}
