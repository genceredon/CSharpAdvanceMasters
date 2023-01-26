namespace Session_01.Delegates
{
    //Step1: Declare a generic delegate
    public delegate T MyGenericDelegate<T>(T param1, T param2);

    public class GenericDel
    {
        public void GenericDelegate()
        {
            Console.WriteLine("\nInside Generic Delegate...");
            MyGenericDelegate<int> sum = Sum;
            Console.WriteLine($"Sum: {sum(10, 20)}");

            //Func Delegate
            Console.WriteLine("\nUsing Func Delegate...");
            Func<int, int, int> addFunc = Sum;
            int result = addFunc(10, 15);
            Console.WriteLine($"Sum: {result}");

            //Action Delegate
            Console.WriteLine("\nUsing Action Delegate...");
            Action<int, int> action = PrintSum;
            //Action<int, int> action = new Action<int,int>(PrintSum);
            action.Invoke(10, 7);

            //Predicate Delegate
            Console.WriteLine("\nUsing Predicate Delegate...");
            Predicate<string> isUpper = IsUpperCase;
            bool res = isUpper("hello world");
            Console.WriteLine(res);
        }

        static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        static void PrintSum(int val1, int val2)
        {
            Console.WriteLine($"Sum: {val1 + val2}");
        }

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}