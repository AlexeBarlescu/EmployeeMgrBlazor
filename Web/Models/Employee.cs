using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee full name is required.")]
        [MinLength(3, ErrorMessage = "Name should be 3 or more characters.")]
        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Select employee department.")]
        public int DepartmentId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Select employee location.")]
        public int LocationId { get; set; }

        public Department Department { get; set; }
        public Location Location { get; set; }
    }
}
