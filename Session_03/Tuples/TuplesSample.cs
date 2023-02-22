using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03.Tuples
{
    public class TuplesSample
    {
        public TuplesSample()
        {
            var tupleSample = ("Edwin", "Gen", "Raffy", "Coleen", "Ryan");

            tupleSample.Item3 = "Raffy Ang";
            Console.WriteLine(tupleSample.Item3); // Output: Raffy Ang

            // named tuples
            var result = (Sum: 150, Count: 3);
            Console.WriteLine($"The sum of result set is {result.Sum} and count is {result.Count}");

            // tuple assignment

            (int, string, string) person = (29, "Raffy", "Manila");
            Console.WriteLine($"Person has a name {person.Item2} and age {person.Item1} lives in {person.Item3}");
            (string firstName, int idNumber) idCard = ("Rafyang", 13);
            Console.WriteLine($"Person has a username {idCard.firstName} and ID number {idCard.idNumber}");

            // tuple deconstruction
            // 1) Explicitly declare the type of each variable inside parenthesis
            var shopeeItem = ("cellphone holder", 75m);
            (string itemName, decimal itemPrice) = shopeeItem;
            Console.WriteLine($"The {itemName} has a price {itemPrice}");
            // Output: The cellphone holder has a price 75

            // 2) Use the var keyword outside the parentheses to declare implicitly typed variables and let the compiler decide their types
            var lazadaItem = ("vitamins", 350m);
            var (lazItemName, lazItemPrice) = lazadaItem;
            Console.WriteLine($"The {lazItemName} has a price {lazItemPrice}");
            // Output: The vitamins has a price 350

            // 3) use existing variables
            var productName = string.Empty;
            var productPrice = 0m;
            var item = ("Speaker", 550.75m);
            (productName, productPrice) = item;
            Console.WriteLine($"The {productName} has a price {productPrice}");
            // Output: The Speaker has a price 550.75


            //Tuple Equality
            // Tuple c# are value types therefore int 5 and long 5 are equal
            (int a, byte b) left = (5, 10);
            (long a, int b) right = (5, 10);
            Console.WriteLine(left == right);  // output: True
            Console.WriteLine(left != right);  // output: False
        }
    }
}
