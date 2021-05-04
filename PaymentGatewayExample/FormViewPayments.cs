using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaymentGatewayExample
{
    public partial class FormViewPayments : Form
    {
        public FormViewPayments()
        {
            InitializeComponent();
        }

        private void FormViewPayments_Load(object sender, EventArgs e)
        {
            foreach (CardPayment c in PaymentServices.cards)
            {
                listBoxCards.Items.Add(c.OrderId + " - " + c.amount);
            }
            foreach (CashPayment c in PaymentServices.cash)
            {
                listBoxCash.Items.Add(c.OrderId + " - " + c.amount);
            }
        }
    }
}
