using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_04.Patterns.ConstantPattern;

namespace Session_04.Patterns
{
    public class PropertyPattern
    {
        public PropertyPattern()
        {
            string name = "Raffy";

            if(name is { Length: 5 })
            {
                Console.WriteLine($"String of length of {name} is 5");
            }
            else
            {
                Console.WriteLine("Not length 5");
            }

            PrintLength(name);
        }

        void PrintLength(string str)
        {
            switch (str)
            {
                case { Length: 3 }:
                    Console.WriteLine($"String of length 3");
                    break;
                case { Length: 4 }:
                    Console.WriteLine($"String of length 4");
                    break;
                case { Length: 5 }:
                    Console.WriteLine($"String of length 5");
                break;
                default:
                    Console.WriteLine("undefined");
                break;
            }
        }
    }
}
