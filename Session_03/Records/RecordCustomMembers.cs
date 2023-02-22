using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03.Records
{
    public class RecordCustomMembers
    {
        public RecordCustomMembers()
        {
            Employee employee = new("Raffy", "Ang");

            Console.WriteLine(employee.FullName);

            employee.Hello();

            EmployeeWithId employee1 = new(1, "Coleen", "Zamoranos");

            employee1.Hello();
        }
    }

    public record Employee(string FirstName, string LastName)
    {
        public string FullName { get => $"{FirstName} {LastName}"; }

        public void Hello()
        {
            Console.WriteLine($"Hello {FullName}");
        }
    }

    public record EmployeeWithId(int Id, string FirstName, string LastName): Employee(FirstName, LastName);
}
