namespace Session_01.Events
{
    //1. define a delegate type for the event
    public delegate void OrderHandler();
    public delegate void OrderMsg();

    public class Order
    {
        //2. declare an event associated with the delegate type
        private event OrderHandler? OnCreated;
        private event OrderMsg? Msg;


        public void OrderEvent()
        {
            var order = new Order(); //publisher

            order.Msg += Success;
            order.OnCreated += Email.Send; //Subscriber
            order.OnCreated += SMS.Send; //Subscriber            
            


            order.Create();
        }

        private void Create()
        {
            Console.WriteLine("Order Created");

            //Raising an Event
            if (OnCreated != null)
            {
                OnCreated();
            }

            if (Msg != null)
            {
                Msg();
            }
            //Email.Send();
            //SMS.Send();
        }

        private static void Success()
        {
            //Action Delegate
            Console.WriteLine("\nUsing Action Delegate...");
            Action<int, int> action = PrintSum;
            //Action<int, int> action = new Action<int,int>(PrintSum);
            action.Invoke(10, 7);
        }
        static void PrintSum(int val1, int val2)
        {
            Console.WriteLine($"Sum: {val1 + val2}");
        }

    }

    class Email
    {
        public static void Send()
        {
            Console.WriteLine("Send an email");
        }
    }

    class SMS
    {
        public static void Send()
        {
            Console.WriteLine("Send an SMS");
        }
    }
}