namespace Banksida
{
    partial class Form1
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
            this.viewAccount = new System.Windows.Forms.ComboBox();
            this.addAccount = new System.Windows.Forms.Button();
            this.transferMoney = new System.Windows.Forms.Button();
            this.viewTransactions = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // viewAccount
            // 
            this.viewAccount.FormattingEnabled = true;
            this.viewAccount.Location = new System.Drawing.Point(376, 59);
            this.viewAccount.Name = "viewAccount";
            this.viewAccount.Size = new System.Drawing.Size(319, 33);
            this.viewAccount.TabIndex = 0;
            // 
            // addAccount
            // 
            this.addAccount.Location = new System.Drawing.Point(177, 44);
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(177, 48);
            this.addAccount.TabIndex = 1;
            this.addAccount.Text = "Add account";
            this.addAccount.UseVisualStyleBackColor = true;
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // transferMoney
            // 
            this.transferMoney.Location = new System.Drawing.Point(177, 116);
            this.transferMoney.Name = "transferMoney";
            this.transferMoney.Size = new System.Drawing.Size(177, 44);
            this.transferMoney.TabIndex = 2;
            this.transferMoney.Text = "Pay / transfer";
            this.transferMoney.UseVisualStyleBackColor = true;
            // 
            // viewTransactions
            // 
            this.viewTransactions.Location = new System.Drawing.Point(378, 118);
            this.viewTransactions.Name = "viewTransactions";
            this.viewTransactions.Size = new System.Drawing.Size(509, 341);
            this.viewTransactions.TabIndex = 3;
            this.viewTransactions.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 526);
            this.Controls.Add(this.viewTransactions);
            this.Controls.Add(this.transferMoney);
            this.Controls.Add(this.addAccount);
            this.Controls.Add(this.viewAccount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox viewAccount;
        private Button addAccount;
        private Button transferMoney;
        private RichTextBox viewTransactions;
    }
}