using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Session_07.LINQ_Queries.LINQToSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07.LINQ_Queries.LINQToSQL.Data
{
    public class EmployeeContext : DbContext
    {
        public string connectionString;

        public EmployeeContext()
        {
            connectionString = AppConfig.GetConnectionString();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Employees> Employee { get; set; }
    }
}
