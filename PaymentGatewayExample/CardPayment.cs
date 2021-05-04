using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGatewayExample
{
    class CardPayment : Payment
    {
        public string Cardholder { get; set; }
        public int Last4Digits { get; set; }
        public string Provider { get; set; }
        public CardPayment(int orderID, DateTime date, float amount, string reference, string holder, int last4, string provide): base(orderID,date,amount,reference)
        {
            cardholder = holder;
            last4Digits = last4;
            provider = provide;
        }
        private string cardholder;
        private int last4Digits;
        private string provider;

       
    }
}
