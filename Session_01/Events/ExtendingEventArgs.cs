namespace Session_01.Events
{
    //1. define a class that inherits from the EventArgs class
    class OrderEventArgs : EventArgs
    {
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }

    public class ExtendingEventArgs
    {
        //2.define the event using the EventHandler with the OrderEventArgs type
        private event EventHandler<OrderEventArgs>? OnCreated;

        public static void OrderEvent()
        {
            var order = new ExtendingEventArgs(); //publisher

            order.OnCreated += SendEmailWithData.Send; //Subscriber
            order.OnCreated += SendSMSWithData.Send; //Subscriber

            order.Create("genc@test.com", "0919-123-4567");
        }

        public void Create(string email, string phone)
        {
            Console.WriteLine("Order Created using ExtendingEventArgs");

            //3. raise an event and a new instance of the OrderEventArgs class
            if (OnCreated != null)
            {
                OnCreated(this, new OrderEventArgs { Email = email, Phone = phone});
            }
        }
    }

    class SendEmailWithData
    {
        public static void Send(object? sender, OrderEventArgs e)
        {
            Console.WriteLine($"Send an email to {e.Email}");
        }
    }

    class SendSMSWithData
    {
        public static void Send(object? sender, OrderEventArgs e)
        {
            Console.WriteLine($"Send an SMS to {e.Phone}");
        }
    }
}