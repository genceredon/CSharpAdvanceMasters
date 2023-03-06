using Microsoft.EntityFrameworkCore.Metadata;
using Session_07.LINQ_Queries.LINQToSQL.Data;
using Session_07.LINQ_Queries.LINQToSQL.Models;
using System.Data;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Session_07.LINQ_Queries.LINQToSQL.DAL
{
    public class EmployeeDAL
    {
        public string connectionString;

        public EmployeeDAL()
        {
            connectionString = AppConfig.GetConnectionString();
        }

        public List<Employees> GetAllEmployeeUsingSQL()
        {
            List<Employees> employeesList = new List<Employees>();
            try
            {
                //using SQL => SQL Server
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT [Id], [EmpCode], [EmpFullName], [Role] FROM EMPLOYEE";

                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        employeesList.Add(new Employees
                        {
                            Id = Convert.ToInt32(rdr[0]),
                            EmpCode = rdr[1].ToString(),
                            EmpFullName = rdr[2].ToString(),
                            Role = rdr[3].ToString()
                        });
                    }
                }
            }
            catch (Exception exp)
            {
                throw;
            }

            return employeesList;
        }

        public List<Employees> GetAllEmployeeUsingLINQ()
        {
            List<Employees> employeesList = new List<Employees>();
            try
            {
                using (var context = new EmployeeContext())
                {
                    DbInitializer.Initialize(context);

                    //employeesList = context.Employee.ToList();
                    employeesList = (List<Employees>)(from emp in context.Employee.ToList()
                                    where emp.EmpFullName == "Juanna Dela Cruz"
                                    select emp);

                }
            }
            catch (Exception exp)
            {
                throw;
            }

            return employeesList;
        }

        public Employees GetSpecificEmployeeUsingLINQ()
        {
            List<Employees> employeesList = new List<Employees>();
            Employees employee = new Employees();
            try
            {
                using (var context = new EmployeeContext())
                {
                    DbInitializer.Initialize(context);

                    employeesList = context.Employee.ToList();
                    
                    employee = (from emp in context.Employee
                                where emp.EmpFullName == "Juanna Dela Cruz"
                                select emp).FirstOrDefault();

                    var employee2 = employeesList.Where(x => x.EmpFullName == "Juanna Dela Cruz").FirstOrDefault();


                }
            }
            catch (Exception exp)
            {
                throw;
            }

            return employee;
        }
    }
}