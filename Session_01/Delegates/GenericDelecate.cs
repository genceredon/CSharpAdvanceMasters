namespace Session_01
{
    //Step1: Declare a generic delegate
    public delegate void Print(int value);

    public partial class Program
    {
        public void AnonymousDelegate()
        {
            Console.WriteLine("\nInside Anonymous Delegate...");
            Print print = delegate(int val)
            {
                Console.WriteLine($"Value: {val}"); 
            };

            print(100);

            //Example: Anonymous Method as Parameter
            Console.WriteLine("\nInside Anonymous Method as Parameter...");
            PrintHelperMethod(delegate(int val)
            {
                Console.WriteLine($"Anonymous method: {val}");
            }, 240);
        }

        static void PrintHelperMethod(Print printDel,int val)
        {
            val += 10;
            printDel(val);
        }
    }
}