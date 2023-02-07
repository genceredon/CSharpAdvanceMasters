namespace Session_01.Delegates
{
    //Step1: Declare a delegate
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string msg);

    public class DelegatesSample
    {
        public void CallDelegate()
        {
            Console.WriteLine("\nInside Delegate...");
            var add = new DelegatesSample();

            //Step2: Instantiate a delegate
            AddDelegate addNum = new AddDelegate(add.AddNums);
            SayDelegate sayDel = new SayDelegate(SayHello);

            //Step 3: Invoke the delegate
            InvokeDelegate(addNum, sayDel);
        }

        private static void InvokeDelegate(AddDelegate addNum, SayDelegate sayDel)
        {
            //Call Directly
            addNum(100, 30);
            Console.WriteLine(sayDel("Students!"));

            //Call using Invoke method
            addNum.Invoke(100, 40);
            Console.WriteLine(sayDel.Invoke("C#"));
        }

        public void AddNums(int a, int b)
        {
            Console.WriteLine($"Sum is {a + b}");
        }

        public static string SayHello(string msg)
        {
            return $"Hello, {msg}!";
        }
    }
}