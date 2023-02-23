using Session_07.LINQ_Queries.LINQToSQL.Data;
using Session_07.LINQ_Queries.LINQToSQL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                //Using LINQ to SQL
                //linqtosqldatacontext dataOject = new LINQToSQLDataContext();

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

                    var emp = new Employees
                    {
                        EmpCode = "S005",
                        EmpFullName = "Gen C",
                        Role = "Developer"
                    };

                    employeesList = context.Employee.ToList();

                }

                //Using LINQ to SQL
                //linqtosqldatacontext dataOject = new LINQToSQLDataContext();

            }
            catch (Exception exp)
            {
                throw;
            }

            return employeesList;
        }
    }
}
