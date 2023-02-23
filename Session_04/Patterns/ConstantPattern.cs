using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04.Patterns
{
    public class ConstantPattern
    {
        public ConstantPattern()
        {
            void Valid(object o)
            {
                if (o is PersonRecord)
                {
                    Console.WriteLine(o.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }

            PersonRecord personRecord = new("Raffy", "Ang");
            PersonClass personClass = new();

            Valid(personClass);
            // Output: Invalid


            // boxing
            object o = 3;

            // Can also be named
            if(o is int integerNumber)
            {
                // unboxing
                Console.WriteLine($"The {o} x {integerNumber} = {(int)o * integerNumber}");
            }
            else
            {
                Console.WriteLine($"{ o} is not an int, cannot multiply");
            }

        }

        public record PersonRecord(string FirstName, string LastName);

        public class PersonClass
        {
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
        }

    }
}
