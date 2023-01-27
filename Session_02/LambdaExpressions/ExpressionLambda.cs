using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_02.LambdaExpressions
{
    delegate double ExpressionDelegate(int x);

    internal class ExpressionLambda
    {
        public ExpressionLambda() 
        {
            Console.WriteLine("Inside Expression Lambda Expression");

            ExpressionDelegate del1 = (x) => x * x;
            ExpressionDelegate del2 = (x) => Math.Sqrt(x);

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
            Func<int, int> square = x => x * x;
            Console.WriteLine("\nLambda Expression using Func");
            Console.WriteLine(square(5));
        }
    }
}
