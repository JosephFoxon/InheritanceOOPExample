using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGatewayExample
{
    class CashPayment: Payment
    {
        private float amountTendered;
        private float change;
        private String currency;

        public CashPayment(int orderID, DateTime date, float amount, string reference, float amountTendered, float change, string currency) : base(orderID, date, amount, reference)
        {
            this.amountTendered = amountTendered;
            this.change = change;
            this.currency = currency;

        }

        public float AmountTendered { get => amountTendered; set => amountTendered = value; }
        public float Change { get => change; set => change = value; }
        public string Currency { get => currency; set => currency = value; }
    }
}
