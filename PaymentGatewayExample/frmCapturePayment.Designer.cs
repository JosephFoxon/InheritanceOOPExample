
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
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.radioButtonCard = new System.Windows.Forms.RadioButton();
            this.textBoxTendered = new System.Windows.Forms.TextBox();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.textBoxCurrency = new System.Windows.Forms.TextBox();
            this.textBoxProvider = new System.Windows.Forms.TextBox();
            this.textBoxLast4 = new System.Windows.Forms.TextBox();
            this.textBoxHolder = new System.Windows.Forms.TextBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.panelCash = new System.Windows.Forms.Panel();
            this.panelCard = new System.Windows.Forms.Panel();
            this.groupBoxOptions.SuspendLayout();
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
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(6, 52);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(51, 19);
            this.radioButtonCash.TabIndex = 4;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Cash";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            this.radioButtonCash.CheckedChanged += new System.EventHandler(this.radioButtonCash_CheckedChanged);
            // 
            // radioButtonCard
            // 
            this.radioButtonCard.AutoSize = true;
            this.radioButtonCard.Location = new System.Drawing.Point(168, 52);
            this.radioButtonCard.Name = "radioButtonCard";
            this.radioButtonCard.Size = new System.Drawing.Size(50, 19);
            this.radioButtonCard.TabIndex = 5;
            this.radioButtonCard.TabStop = true;
            this.radioButtonCard.Text = "Card";
            this.radioButtonCard.UseVisualStyleBackColor = true;
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
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.radioButtonCash);
            this.groupBoxOptions.Controls.Add(this.radioButtonCard);
            this.groupBoxOptions.Location = new System.Drawing.Point(26, 283);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(224, 114);
            this.groupBoxOptions.TabIndex = 12;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Payment Method";
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
            // frmCapturePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.panelCash);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.textBoxReference);
            this.Controls.Add(this.textBoxAmou);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxOrderID);
            this.Name = "frmCapturePayment";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCapturePayment_Load);
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.RadioButton radioButtonCard;
        private System.Windows.Forms.TextBox textBoxTendered;
        private System.Windows.Forms.TextBox textBoxChange;
        private System.Windows.Forms.TextBox textBoxCurrency;
        private System.Windows.Forms.TextBox textBoxProvider;
        private System.Windows.Forms.TextBox textBoxLast4;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBoxHolder;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Panel panelCash;
        private System.Windows.Forms.Panel panelCard;
    }
}

