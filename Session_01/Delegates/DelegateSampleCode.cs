namespace Session_01.Delegates
{
    //Step1: Declare a delegate
    public delegate void AddDelegate(int a, int b);
    public delegate void SayDelegate(string msg);

    public class DelegatesSample
    {
        public void CallDelegate()
        {
            Console.WriteLine("\nInside Delegate...");
            var add = new DelegatesSample();

            //Step2: Instantiate a delegate
            AddDelegate addNum = new AddDelegate(add.AddNums);
            SayDelegate sayHelloDel = new SayDelegate(SayHello);
            SayDelegate sayHiDel = new SayDelegate(SayHi);

            //Step 3: Invoke the delegate
            InvokeDelegate(addNum, sayHelloDel);

            SayDelegate sayDel = sayHelloDel + sayHiDel;
            Console.WriteLine("\nAfter sayHelloDel + sayHiDel");
            sayDel("Multicast delegate...");
        }

        private static void InvokeDelegate(AddDelegate addNum, SayDelegate sayDel)
        {
            //Call Directly
            addNum(100, 30);
            sayDel("Students!");
            //Console.WriteLine(sayDel("Students!"));

            //Call using Invoke method
            addNum.Invoke(100, 40);
            sayDel.Invoke("C#");
            //Console.WriteLine(sayDel.Invoke("C#"));
        }

        public void AddNums(int a, int b)
        {
            Console.WriteLine($"Sum is {a + b}");
        }

        public static void SayHello(string msg)
        {
            Console.WriteLine($"Hello, {msg}!");
        }

        public static void SayHi(string msg)
        {
            Console.WriteLine($"Hi, {msg}!");
        }
    }
}