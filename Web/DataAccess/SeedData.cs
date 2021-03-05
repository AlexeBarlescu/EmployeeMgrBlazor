using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Models;

namespace Web.DataAccess
{
    public static class SeedData
    {
        public static void Seed(DataContext ctx)
        {
            ctx.Database.EnsureCreated();
            if(ctx.Employees.Count() == 0 && ctx.Departments.Count() == 0 && ctx.Locations.Count() == 0)
            {
                Department marketing = new Department { Name = "Marketing"};
                Department operations = new Department { Name = "Operations"};
                Department sales = new Department { Name = "Sales"};
                Department accounting = new Department { Name = "Accounting"};

                Location l1 = new Location { City = "Denver", State = "Colorado" };
                Location l2 = new Location { City = "Sacramento", State = "California" };
                Location l3 = new Location { City = "Kansas City", State = "Missouri" };
                Location l4 = new Location { City = "New York City", State = "NY" };

                ctx.Employees.AddRange(new Employee[] 
                { 
                    new Employee{ Name = "Mark Taylor", Department = marketing, Location = l1},
                    new Employee{ Name = "Jack White", Department = marketing, Location = l1},
                    new Employee{ Name = "Lisa Moore", Department = marketing, Location = l1},
                    new Employee{ Name = "Laura Wilson", Department = marketing, Location = l1},
                    new Employee{ Name = "San Smith", Department = operations, Location = l2},
                    new Employee{ Name = "Oscar Johnson", Department = operations, Location = l2},
                    new Employee{ Name = "Dave Brown", Department = operations, Location = l2},
                    new Employee{ Name = "Niamh Davies", Department = operations, Location = l2},
                    new Employee{ Name = "Harpper Lee", Department = sales, Location = l3},
                    new Employee{ Name = "Mylo Young", Department = sales, Location = l3},
                    new Employee{ Name = "Steven Hall", Department = sales, Location = l3},
                    new Employee{ Name = "Travis King", Department = accounting, Location = l4},
                    new Employee{ Name = "Jane Cox", Department = accounting, Location = l4},
                    new Employee{ Name = "Peter Gray", Department = accounting, Location = l4}
                });

                ctx.SaveChanges();
            }
        }
    }
}
