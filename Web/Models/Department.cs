using System.Collections.Generic;

namespace Web.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}