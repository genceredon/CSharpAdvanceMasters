namespace Session_01.Events
{
    public class OrderEventHandler
    {
        private event EventHandler? OnCreated;

        public static void OrderEvent()
        {
            var order = new OrderEventHandler(); //publisher

            order.OnCreated += SendEmail.Send; //Subscriber
            order.OnCreated += SendSMS.Send; //Subscriber

            order.Create();
        }

        public void Create()
        {
            Console.WriteLine("Order Created using EventHandler");

            //Raising an Event
            if (OnCreated != null)
            {
                OnCreated(this, EventArgs.Empty);
            }
        }
    }

    class SendEmail
    {
        public static void Send(object? sender, EventArgs e)
        {
            Console.WriteLine("Send an email");
        }
    }

    class SendSMS
    {
        public static void Send(object? sender, EventArgs e)
        {
            Console.WriteLine("Send an SMS");
        }
    }
}