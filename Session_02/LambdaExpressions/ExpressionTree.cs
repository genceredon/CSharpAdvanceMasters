namespace Session_02.LambdaExpressions
{
    internal class ExpressionTree
    {
        public ExpressionTree()
        {
            Console.WriteLine("Inside Expression Lambda Expression");

            List<int> numbers = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            //foreach (int ab in numbers.Where(x =>
            //{
            //    if (x % 3 == 0)
            //        return true;
            //    else if (x % 5 == 0)
            //        return true;
            //    else
            //        return false;
            //}))
            //{
            //    Console.WriteLine(ab);
            //}

            foreach (var ab in numbers.Where(x =>
            {
                int number = 5;
                return x > number;

            }))
            {
                Console.WriteLine(ab);
            }

            Console.WriteLine("\n\n");

            numbers.Where(x =>
            {
                int number = 5;
                return x > number;
            }).ToList().ForEach(b => Console.WriteLine(b));
        }
    }
}