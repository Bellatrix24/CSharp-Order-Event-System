using System;

namespace OrderApp
{
    public delegate void OrderPlacedHandler(Order order);

    public class OrderProcessor
    {
        public event OrderPlacedHandler? OnOrderPlaced;

        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Order Placed: " + order.OrderId);
            
            // trigger the event if anyone is subscribed
            if (OnOrderPlaced != null)
            {
                OnOrderPlaced(order);
            }
        }
    }
}
