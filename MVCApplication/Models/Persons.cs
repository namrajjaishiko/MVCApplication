using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;


namespace WebApplication1.Models
{
    public class Persons
    {
        [Key]
        public int? Id { get; set; }
        [Required(ErrorMessage = "Id is required")]
        [StringLength(100)]
        public string? Name { get; set; }
        [Required(ErrorMessage = "nae is required")]
        [Range(10, 20)]
        public int? Age { get; set; }
        public string? Address { get; set; }
        public string Faculty { get; set; }
        [EmailAddress]

        public string Email { get; set; }

    }
}