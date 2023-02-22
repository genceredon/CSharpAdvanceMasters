using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03.Records
{
    public class RecordSample
    {    

    }

    public record Record1(string FirstName, string LastName);

    
    public class Class1
    {
        public string FirstName { get; init;}
        public string LastName { get; init;}

        public Class1(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Deconstruct(out string FirstName, out string LastName)
        {
            FirstName = this.FirstName;
            LastName = this.LastName;
        }
    }
}
