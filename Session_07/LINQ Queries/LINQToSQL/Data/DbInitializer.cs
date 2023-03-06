using Session_07.LINQ_Queries.LINQToSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.LINQ_Queries.LINQToSQL.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EmployeeContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Employee.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Employees[]
            {
            new Employees{EmpCode="S001",EmpFullName="John Doe",Role="Manager"},
            new Employees{EmpCode="S002",EmpFullName="Jane Doe",Role="Senior Software Engineer"},
            new Employees{EmpCode="S003",EmpFullName="Juan Dela Cruz",Role="Software Engineer"},
            new Employees{EmpCode="S004",EmpFullName="Juanna Dela Cruz",Role="Project Manager"},
            };
            foreach (Employees s in students)
            {
                context.Employee.Add(s);
            }
            context.SaveChanges();
        }
    }
}
