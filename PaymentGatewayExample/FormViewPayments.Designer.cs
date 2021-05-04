
namespace PaymentGatewayExample
{
    partial class FormViewPayments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxCash = new System.Windows.Forms.ListBox();
            this.listBoxCards = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxCash
            // 
            this.listBoxCash.FormattingEnabled = true;
            this.listBoxCash.ItemHeight = 15;
            this.listBoxCash.Location = new System.Drawing.Point(131, 47);
            this.listBoxCash.Name = "listBoxCash";
            this.listBoxCash.Size = new System.Drawing.Size(120, 94);
            this.listBoxCash.TabIndex = 0;
            // 
            // listBoxCards
            // 
            this.listBoxCards.FormattingEnabled = true;
            this.listBoxCards.ItemHeight = 15;
            this.listBoxCards.Location = new System.Drawing.Point(419, 47);
            this.listBoxCards.Name = "listBoxCards";
            this.listBoxCards.Size = new System.Drawing.Size(120, 94);
            this.listBoxCards.TabIndex = 1;
            // 
            // FormViewPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxCards);
            this.Controls.Add(this.listBoxCash);
            this.Name = "FormViewPayments";
            this.Text = "FormViewPayments";
            this.Load += new System.EventHandler(this.FormViewPayments_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCash;
        private System.Windows.Forms.ListBox listBoxCards;
    }
}