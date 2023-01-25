namespace Session_01
{
    public partial class Program
    {
        private static void Main(string[] args)
        {
            //Instantiate class obj
            var add = new Program();
            add.AddNums(100, 25);

            //call static method
            Console.WriteLine(SayHello("Gen"));

            //Call method using delegate
            var del = new Program();
            del.CallDelegate();
        }
    }
}