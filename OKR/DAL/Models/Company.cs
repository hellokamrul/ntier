using System.ComponentModel.DataAnnotations;


namespace DAL_test.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ComId { get; set;}
        [EmailAddress]
        public string Email { get; set; }
    }
}
