using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_04.Patterns.ConstantPattern;

namespace Session_04.Patterns
{
    public class TypePattern
    {
        public TypePattern()
        {
            PersonClass pc = new PersonClass();
            PersonRecord pr = new("Raffy", "Ang"); 

            PrintType(pc);
        }

        void PrintType(object o)
        {
            switch (o)
            {
                case PersonClass:
                    Console.WriteLine("This is a person class");
                    break;
                case PersonRecord:
                    Console.WriteLine("This is a person record");
                    break;
                case int i:
                    Console.WriteLine("obj is an int");
                    Console.WriteLine($"Value of the int: {i}");
                    break;

                case double d:
                    Console.WriteLine("obj is a double");
                    Console.WriteLine($"Value of the double: {d}");
                    break;

                default:
                    Console.WriteLine("obj is some other type");
                    break;
            }
        }
    }
}
