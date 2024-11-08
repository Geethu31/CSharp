using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public enum OrderStatus
    {
        Pending,  
        Shipped,   
        Delivered  
    }
    public class Order
    {
        public int OrderId;
        public OrderStatus Status;
        public Order(int orderId)
        {
            OrderId = orderId;
            Status = OrderStatus.Pending; // Default status is Pending
        }
        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus; 
            Console.WriteLine($"Order {OrderId} status updated to {Status}.");
        }
        public void DisplayOrderInfo()
        {
            Console.WriteLine($"Order ID: {OrderId}, Status: {Status}");
        }
    }
}
