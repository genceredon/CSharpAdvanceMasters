namespace Session_01.Delegates
{
    //Step1: Declare a delegate
    public delegate int MyDelegate();

    public class MultiDel
    {
        public void MultiDelegate()
        {
            Console.WriteLine("\nInside Multicast Delegate...");
            var add = new MultiDel();

            //Step2: Instantiate a delegate
            MyDelegate del1 = new MyDelegate(Num1);
            MyDelegate del2 = new MyDelegate(Num2);


            //Step 3: Invoke the delegate
            MyDelegate del = del1 + del2;   
            Console.WriteLine("\nAfter del1 + del2");
            Console.WriteLine(del());
        }

        static int Num1()
        {
            return 100;
        }
        static int Num2()
        {
            return 150;
        }
    }
}