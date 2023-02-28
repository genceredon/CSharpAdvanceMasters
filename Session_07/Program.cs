using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Session_07.LINQ_Queries.LINQToSQL.Data;
using Microsoft.Extensions.Hosting;
using Session_07.LINQ_Queries;
using Session_07.LINQ_Queries.LINQToSQL.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Session_07.LINQ_Queries.LINQToSQL;

namespace Session_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var obj = new SimpleLinqQuery();
            //obj.DisplayScores();

            //LINQToObjects.LINQToObjectsSample();

            //GetEmployee.UsingSQLStatement();
            GetEmployee.UsingLINQStatement();
        }

    }
}