using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04.DynamicBinding
{
    public class DynamicBindingSample
    {
        public DynamicBindingSample()
        {
            object obj = 1;
            // Need to unbox before add to an int
            Console.WriteLine((int)obj + 1);

            // can be declared without initial type
            dynamic dyn;

            // becomes and int during the runtime
            dyn = 1;
            // Behind the scenes it will do conversion and becomes double and add
            dyn = dyn + 1.1;
            Console.WriteLine(dyn);
            // Output: 2.1

            // Cost in conversion:
            // Additional processing
            // Will eliminate the design time error checking
            // No intellisense
            // Bug prone

            // var type must have initialized to a type
            // var type is strongly typed
            // var has intellisense

            //var var;


            object operson = new Person();
            dynamic dperson = new Person();
            var vperson = new Person();

            ((Person)operson).FirstName = "FirstName Object";
            ((Person)operson).LastName = "LastName Object";

            dperson.FirstName = "FirstName Dyanmic";
            dperson.LastName = "lastName Dynamic";

            vperson.FirstName = "FirstName var";
            vperson.LastName = "LastName var";

            Console.WriteLine(((Person)operson).Hello());
            Console.WriteLine(dperson.Hello());
            Console.WriteLine(vperson.Hello());

            dperson = "Hi";

            // you can change the type of dperson on the fly at runtime and wipeout the instance of person
            // and put a string
            Console.WriteLine(dperson);
        }
    }

    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string Hello()
        {
            return $"Hello {FirstName}, {LastName}";
        }
    }

}
