
namespace PaymentGatewayExample
{
    partial class frmCapturePayment
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxOrderID = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxAmou = new System.Windows.Forms.TextBox();
            this.textBoxReference = new System.Windows.Forms.TextBox();
            this.textBoxTendered = new System.Windows.Forms.TextBox();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            this.textBoxProvider = new System.Windows.Forms.TextBox();
            this.textBoxLast4 = new System.Windows.Forms.TextBox();
            this.textBoxHolder = new System.Windows.Forms.TextBox();
            this.panelCash = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.buttononfirm = new System.Windows.Forms.Button();
            this.panelCash.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxOrderID
            // 
            this.textBoxOrderID.Location = new System.Drawing.Point(89, 68);
            this.textBoxOrderID.Name = "textBoxOrderID";
            this.textBoxOrderID.PlaceholderText = "Order ID";
            this.textBoxOrderID.Size = new System.Drawing.Size(100, 23);
            this.textBoxOrderID.TabIndex = 0;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(89, 112);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.PlaceholderText = "Date";
            this.textBoxDate.Size = new System.Drawing.Size(100, 23);
            this.textBoxDate.TabIndex = 1;
            // 
            // textBoxAmou
            // 
            this.textBoxAmou.Location = new System.Drawing.Point(89, 157);
            this.textBoxAmou.Name = "textBoxAmou";
            this.textBoxAmou.PlaceholderText = "Amount";
            this.textBoxAmou.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmou.TabIndex = 2;
            // 
            // textBoxReference
            // 
            this.textBoxReference.Location = new System.Drawing.Point(89, 204);
            this.textBoxReference.Name = "textBoxReference";
            this.textBoxReference.PlaceholderText = "Reference";
            this.textBoxReference.Size = new System.Drawing.Size(100, 23);
            this.textBoxReference.TabIndex = 3;
            this.textBoxReference.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxTendered
            // 
            this.textBoxTendered.Location = new System.Drawing.Point(30, 27);
            this.textBoxTendered.Name = "textBoxTendered";
            this.textBoxTendered.PlaceholderText = "Amount Tendered";
            this.textBoxTendered.Size = new System.Drawing.Size(100, 23);
            this.textBoxTendered.TabIndex = 6;
            // 
            // textBoxChange
            // 
            this.textBoxChange.Location = new System.Drawing.Point(30, 70);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.PlaceholderText = "Change";
            this.textBoxChange.Size = new System.Drawing.Size(100, 23);
            this.textBoxChange.TabIndex = 7;
            // 
            // textBoxCurrency
            // 
            this.textBoxCurrency.Location = new System.Drawing.Point(30, 115);
            this.textBoxCurrency.Name = "textBoxCurrency";
            this.textBoxCurrency.PlaceholderText = "Currency";
            this.textBoxCurrency.Size = new System.Drawing.Size(100, 23);
            this.textBoxCurrency.TabIndex = 8;
            // 
            // textBoxProvider
            // 
            this.textBoxProvider.Location = new System.Drawing.Point(30, 115);
            this.textBoxProvider.Name = "textBoxProvider";
            this.textBoxProvider.PlaceholderText = "Card Provider";
            this.textBoxProvider.Size = new System.Drawing.Size(100, 23);
            this.textBoxProvider.TabIndex = 11;
            // 
            // textBoxLast4
            // 
            this.textBoxLast4.Location = new System.Drawing.Point(30, 70);
            this.textBoxLast4.Name = "textBoxLast4";
            this.textBoxLast4.PlaceholderText = "Last four Digits";
            this.textBoxLast4.Size = new System.Drawing.Size(100, 23);
            this.textBoxLast4.TabIndex = 10;
            // 
            // textBoxHolder
            // 
            this.textBoxHolder.Location = new System.Drawing.Point(30, 27);
            this.textBoxHolder.Name = "textBoxHolder";
            this.textBoxHolder.PlaceholderText = "Card Holder";
            this.textBoxHolder.Size = new System.Drawing.Size(100, 23);
            this.textBoxHolder.TabIndex = 9;
            // 
            // panelCash
            // 
            this.panelCash.Controls.Add(this.textBoxCurrency);
            this.panelCash.Controls.Add(this.textBoxChange);
            this.panelCash.Controls.Add(this.textBoxTendered);
            this.panelCash.Location = new System.Drawing.Point(339, 42);
            this.panelCash.Name = "panelCash";
            this.panelCash.Size = new System.Drawing.Size(155, 165);
            this.panelCash.TabIndex = 13;
            // 
            // panelCard
            // 
            this.panelCard.Controls.Add(this.textBoxProvider);
            this.panelCard.Controls.Add(this.textBoxLast4);
            this.panelCard.Controls.Add(this.textBoxHolder);
            this.panelCard.Location = new System.Drawing.Point(339, 232);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(155, 165);
            this.panelCard.TabIndex = 14;
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.DisplayMember = "Cash";
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(89, 259);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(100, 23);
            this.comboBoxPaymentMethod.TabIndex = 12;
            this.comboBoxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentMethod_SelectedIndexChanged);
            // 
            // buttononfirm
            // 
            this.buttononfirm.Location = new System.Drawing.Point(89, 373);
            this.buttononfirm.Name = "buttononfirm";
            this.buttononfirm.Size = new System.Drawing.Size(75, 23);
            this.buttononfirm.TabIndex = 15;
            this.buttononfirm.Text = "Confirm";
            this.buttononfirm.UseVisualStyleBackColor = true;
            this.buttononfirm.Click += new System.EventHandler(this.buttononfirm_Click);
            // 
            // frmCapturePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.buttononfirm);
            this.Controls.Add(this.comboBoxPaymentMethod);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.panelCash);
            this.Controls.Add(this.textBoxReference);
            this.Controls.Add(this.textBoxAmou);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxOrderID);
            this.Name = "frmCapturePayment";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCapturePayment_Load);
            this.panelCash.ResumeLayout(false);
            this.panelCash.PerformLayout();
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOrderID;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxAmou;
        private System.Windows.Forms.TextBox textBoxReference;
        private System.Windows.Forms.TextBox textBoxTendered;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.TextBox textBoxCurrency;
        private System.Windows.Forms.TextBox textBoxProvider;
        private System.Windows.Forms.TextBox textBoxLast4;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBoxHolder;
        private System.Windows.Forms.Panel panelCash;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Button buttononfirm;
    }
}

