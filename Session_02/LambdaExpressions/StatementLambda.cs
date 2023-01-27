using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.LambdaExpressions
{
    delegate double StatementDelegate(int x);

    internal class StatementLambda
    {
        public StatementLambda() 
        {
            Console.WriteLine("\nInside Statement Lambda Expression");
            StatementDelegate del1 = (x) => x * x;
            StatementDelegate del2 = (int x) =>
            {
                return Math.Sqrt(x);
            };

            List<int> list = new List<int>()
            {
                1,2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            
            Console.WriteLine("Number \tSquare \tSquareRoot");
 
            foreach (var item in list)
            {
                Console.WriteLine($"{item}, \t{del1(item)}, \t{del2(item)}");
            }

            //using Func
            Func<int, int> square = x => 
            {
                Console.WriteLine("Inside Func Statement Lambda Expression");
                return x * x;
            };
            Console.WriteLine("\nLambda Expression using Func");
            Console.WriteLine(square(10));
        }
    }
}
