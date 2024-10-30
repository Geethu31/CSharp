using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Payment
    {
        public abstract void ProcessPayment();
    }

    // Derived class for credit card payment
    public class CreditCardPayment : Payment
    {
        // Overriding the ProcessPayment method
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment");
        }
    }

    // Derived class for PayPal payment
    public class PayPalPayment : Payment
    {
        // Overriding the ProcessPayment method
        public override void ProcessPayment()
        {
            Console.WriteLine("Processing PayPal payment");
        }
    }
}
