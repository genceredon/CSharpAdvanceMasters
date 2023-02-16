using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03.Records
{
    public class RecordEquality
    {
        public RecordEquality()
        {
            Record1 rec1 = new("Raffy", "Ang");
            Record1 rec2 = new("Raffy", "Ang");

            Class1 clas1 = new("Raffy", "Ang");
            Class1 clas2 = new("Raffy", "Ang");

            Console.WriteLine("Record Type:");
            Console.WriteLine($"To String {rec1}");
            Console.WriteLine($"Are two objects equal: { Equals(rec1,rec2) }");
            Console.WriteLine($"Are two objects reference equal: {ReferenceEquals(rec1, rec2)}");
            Console.WriteLine($"Are two objects reference equal: {rec1 == rec2}");
            Console.WriteLine($"Hash code of object 1: {rec1.GetHashCode()}");
            Console.WriteLine($"Hash code of object 1: {rec2.GetHashCode()}");

            Console.WriteLine("Class Type:");
            Console.WriteLine($"To String {clas1}");
            Console.WriteLine($"Are two objects equal: {Equals(clas1, clas2)}");
            Console.WriteLine($"Are two objects referencew equal: {ReferenceEquals(clas1, clas2)}");
            Console.WriteLine($"Are two objects reference equal: {clas1 == clas2}");
            Console.WriteLine($"Hash code of object 1: {clas1.GetHashCode()}");
            Console.WriteLine($"Hash code of object 1: {clas2.GetHashCode()}");


            // Record Deconstructor
            Record1 rec = new("Raffy", "Ang");
            var (fn, ln) = rec;
            Console.WriteLine($"The value of fn is {fn} and the ln is {ln}");
            // Output: The value of fn is Raffy and the ln is Ang


            // Record Mutation
            Record1 recRaffy = new("Raffy", "Ang");
            Record1 recZoe = recRaffy with { FirstName = "Zoe" };
            Console.WriteLine(recRaffy);
            Console.WriteLine(recZoe);
            // Output: Record1 {FisrtName = Raffy, LastName = Ang}
            // Output: Record1 {FisrtName = Zoe, LastName = Ang}

        }

    }
}
