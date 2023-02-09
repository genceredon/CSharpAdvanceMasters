using Session_01.Delegates;
using Session_01.Events;
using System.Net.Http.Headers;

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
            //var multiDel = new MultiDel();
            //multiDel.MultiDelegate();

            //Call to GenericDelegate
            //GenericDel.GenericDelegate();

            //Call delegate with Anonymous method
            //var anony = new AnonymousDel();
            //anony.AnonymousDelegate();

            //var order = new Order();
            //order.OrderEvent();

            ExtendingEventArgs.OrderEvent();
        }
    }
}