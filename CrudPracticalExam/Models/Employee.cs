using System.ComponentModel.DataAnnotations;

namespace CrudPracticalExam.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Position { get; set; }

        [Range(0, 1000000)]
        public decimal Salary { get; set; }

        public DateTime DateHired { get; set; } = DateTime.Now;
    }
}
