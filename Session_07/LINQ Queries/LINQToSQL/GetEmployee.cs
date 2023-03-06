using Session_07.LINQ_Queries.LINQToSQL.DAL;
using Session_07.LINQ_Queries.LINQToSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.LINQ_Queries.LINQToSQL
{
    public static class GetEmployee
    {
        public static void UsingSQLStatement()
        {
            Console.WriteLine("Inside UsingSQLStatement");
            List<Employees> employeeList = new EmployeeDAL().GetAllEmployeeUsingSQL();

            employeeList.ForEach(item =>
            {
                Console.WriteLine("Code: " + item.EmpCode + " Full Name: " + item.EmpFullName
                    + " Designation: " + item.Role);
            });

            Console.ReadKey();
        }

        public static void UsingLINQStatement()
        {
            Console.WriteLine("Inside UsingLINQStatement");

            //List<Employees> employeeList = new EmployeeDAL().GetAllEmployeeUsingLINQ();

            //var emp = employeeList.Where(item => item.EmpFullName == "Juanna Dela Cruz").FirstOrDefault();

            //Console.WriteLine("Code: " + emp.EmpCode + " Full Name: " + emp.EmpFullName
            //       + " Designation: " + emp.Role);

            //employeeList.ForEach(item =>
            //{
            //    Console.WriteLine("Code: " + item.EmpCode + " Full Name: " + item.EmpFullName
            //        + " Designation: " + item.Role);
            //});


            var employee = new EmployeeDAL().GetSpecificEmployeeUsingLINQ();

            Console.WriteLine("Code: " + employee.EmpCode + " Full Name: " + employee.EmpFullName
                   + " Designation: " + employee.Role);
        }
    }
}
