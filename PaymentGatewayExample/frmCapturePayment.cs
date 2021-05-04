using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentGatewayExample
{
    public partial class frmCapturePayment : Form
    {
        public frmCapturePayment()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCapturePayment_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonCash_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object temp = comboBoxPaymentMethod.SelectedItem;
            string temp2 = temp.ToString();
            if (temp2.Equals("Cash")) 
            {
                panelCash.Visible = true;
                panelCard.Visible = false;
            }
            else
            {
                panelCard.Visible = true;
                panelCash.Visible = false;
            }
        }

        private void buttononfirm_Click(object sender, EventArgs e)
        {
            Object temp = comboBoxPaymentMethod.SelectedItem;
            string temp2 = temp.ToString();
            if (temp2.Equals("Cash"))
            {
                CashPayment cp = new CashPayment(Int32.Parse(textBoxOrderID.Text),DateTime.Parse(textBoxDate.Text),float.Parse(textBoxAmou.Text),textBoxReference.Text, float.Parse(textBoxTendered.Text),float.Parse(textBoxChange.Text),textBoxCurrency.Text);
                System.Windows.Forms.MessageBox.Show(cp.ToString());
            }
            else
            {
                CardPayment cp = new CardPayment(Int32.Parse(textBoxOrderID.Text), DateTime.Parse(textBoxDate.Text), float.Parse(textBoxAmou.Text), textBoxReference.Text, textBoxHolder.Text, Int32.Parse(textBoxLast4.Text), textBoxProvider.Text);
                System.Windows.Forms.MessageBox.Show(cp.ToString());
            }
            
        }
    }
}
