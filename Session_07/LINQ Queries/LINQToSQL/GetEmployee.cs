using Session_07.LINQ_Queries.LINQToSQL.DAL;
using Session_07.LINQ_Queries.LINQToSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.LINQ_Queries.LINQToSQL
{
    public class GetEmployee
    {
        public void UsingSQLStatement()
        {
            List<Employees> employeeList = new EmployeeDAL().GetAllEmployeeUsingSQL();

            employeeList.ForEach(item =>
            {
                Console.WriteLine("Code: " + item.EmpCode + " Full Name: " + item.EmpFullName
                    + " Designation: " + item.Role);
            });

            Console.ReadKey();
        }

        public void UsingLINQStatement()
        {
            List<Employees> employeeList = new EmployeeDAL().GetAllEmployeeUsingLINQ();

            employeeList.ForEach(item =>
            {
                Console.WriteLine("Code: " + item.EmpCode + " Full Name: " + item.EmpFullName
                    + " Designation: " + item.Role);
            });

            Console.ReadKey();
        }


    }
}
