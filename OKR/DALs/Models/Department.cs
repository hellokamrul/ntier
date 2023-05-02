using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public int ComId { get; set; }
        [ForeignKey(nameof(ComId))]
        public Company Company { get; set; }
    }
}
