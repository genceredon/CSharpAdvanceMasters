using Session_07.LINQ_Queries.LINQToSQL.Data;
using Session_07.LINQ_Queries.LINQToSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.LINQ_Queries.LINQToSQL
{
    public class AddEmployee
    {
        public void Add()
        {
            using (var context = new EmployeeContext())
            {
                DbInitializer.Initialize(context);

                var emp = new Employees
                {
                    EmpCode = "S005",
                    EmpFullName = "Gen C",
                    Role = "Developer"
                };

                context.Add(emp);
                context.SaveChanges();
            }
        }
    }
}
