namespace Session_01.Events
{
    //1. define a delegate type for the event
    public delegate void OrderHandler();

    public class Order
    {
        //2. declare an event associated with the delegate type
        private event OrderHandler? OnCreated;

        public void OrderEvent()
        {
            var order = new Order(); //publisher

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
            //Email.Send();
            //SMS.Send();
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