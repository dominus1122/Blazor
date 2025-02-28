using System.ComponentModel.DataAnnotations;

namespace CrudDemo.Models
{
        public class Employee
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public string Name { get; set; } = string.Empty;

            [Required]
            [EmailAddress]
            public string Email { get; set; } = string.Empty;

            [StringLength(20)]
            public string Department { get; set; } = string.Empty;
        }
    }

