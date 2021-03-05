using System.Collections.Generic;

namespace Web.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
    }
}