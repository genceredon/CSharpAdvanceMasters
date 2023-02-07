using Session_01.Delegates;
using Session_01.Events;

namespace Session_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////Instantiate class obj
            //Console.WriteLine("Instantiate class object");
            //var add = new DelegatesSample();
            //add.AddNums(100, 25);

            ////call static method
            //Console.WriteLine("Call Static Method");
            //Console.WriteLine(DelegatesSample.SayHello("Gen"));

            //Call method using delegate
            //var del = new DelegatesSample();
            //del.CallDelegate();

            //Call to Multicast delegate
            var multiDel = new MultiDel();
            multiDel.MultiDelegate();

            //var order = new Order();
            //order.OrderEvent();
        }
    }
}