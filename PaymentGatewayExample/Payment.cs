using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGatewayExample
{
    abstract class Payment
    {
        public int orderId;
        public DateTime date;
        public float amount;
        public string reference;

        public int OrderId { get => orderId; set => orderId = value; }
        public DateTime Date { get => date; set => date = value; }
        public float Amount { get => amount; set => amount = value; }
        public string Reference { get => reference; set => reference = value; }

        public Payment(int orderId, DateTime date, float amount, string reference)
        {
            this.OrderId = orderId;
            this.Date = date;
            this.Amount = amount;
            this.Reference = reference;
        }

        protected Payment()
        {
        }
    }
}
