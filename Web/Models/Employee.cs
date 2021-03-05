namespace Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public int LocationId { get; set; }

        public Department Department { get; set; }
        public Location Location { get; set; }
    }
}
