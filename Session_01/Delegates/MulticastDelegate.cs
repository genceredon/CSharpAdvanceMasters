namespace Session_01.Delegates
{
    //Step1: Declare a delegate
    public delegate void MyDelegate();
    public delegate int MyIntDelegate(int num);

    public class MultiDel
    {
        public void MultiDelegate()
        {
            Console.WriteLine("\nInside Multicast Delegate...");
            var add = new MultiDel();

            //Step2: Instantiate a delegate
            //MyDelegate del1 = new MyDelegate(Word1);
            //MyDelegate del2 = new MyDelegate(Word2);

            //Step 3: Invoke the delegate
            //MyDelegate del = del1 + del2;
            //del = del - del1;

            //var del = del1 + del2;   
            //Console.WriteLine("\nAfter del1 + del2");
            //del();
            //Console.WriteLine(del());


            MyIntDelegate intDel1 = new MyIntDelegate(Num1);
            MyIntDelegate intDel2 = new MyIntDelegate(Num2);

            intDel1(100);
            intDel2(50);

            Console.WriteLine(intDel1 + intDel2);
        }

        static void Word1()
        {
            Console.WriteLine("\nInside Num1");
        }

        static void Word2()
        {
            Console.WriteLine("\nInside Num2");
        }

        static int Num1(int num)
        {
            return num;
        }

        static int Num2(int num)
        {
            return num;
        }
    }
}