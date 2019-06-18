namespace BankAccount
{
    partial class Form1
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
            this.gbxButtons = new System.Windows.Forms.GroupBox();
            this.rbnCloseAccount = new System.Windows.Forms.RadioButton();
            this.rbnWithdraw = new System.Windows.Forms.RadioButton();
            this.rbnDeposit = new System.Windows.Forms.RadioButton();
            this.rbnCreateAccount = new System.Windows.Forms.RadioButton();
            this.gbxTextBox = new System.Windows.Forms.GroupBox();
            this.lblBalanceTotal = new System.Windows.Forms.Label();
            this.tbxDepositWithdraw = new System.Windows.Forms.TextBox();
            this.tbxAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.lblDepositWithdraw = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.gbxButtons.SuspendLayout();
            this.gbxTextBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxButtons
            // 
            this.gbxButtons.Controls.Add(this.rbnCloseAccount);
            this.gbxButtons.Controls.Add(this.rbnWithdraw);
            this.gbxButtons.Controls.Add(this.rbnDeposit);
            this.gbxButtons.Controls.Add(this.rbnCreateAccount);
            this.gbxButtons.Location = new System.Drawing.Point(12, 12);
            this.gbxButtons.Name = "gbxButtons";
            this.gbxButtons.Size = new System.Drawing.Size(140, 119);
            this.gbxButtons.TabIndex = 0;
            this.gbxButtons.TabStop = false;
            this.gbxButtons.Text = "Choose An Option";
            // 
            // rbnCloseAccount
            // 
            this.rbnCloseAccount.AutoSize = true;
            this.rbnCloseAccount.Location = new System.Drawing.Point(7, 92);
            this.rbnCloseAccount.Name = "rbnCloseAccount";
            this.rbnCloseAccount.Size = new System.Drawing.Size(94, 17);
            this.rbnCloseAccount.TabIndex = 3;
            this.rbnCloseAccount.TabStop = true;
            this.rbnCloseAccount.Text = "Close Account";
            this.rbnCloseAccount.UseVisualStyleBackColor = true;
            // 
            // rbnWithdraw
            // 
            this.rbnWithdraw.AutoSize = true;
            this.rbnWithdraw.Location = new System.Drawing.Point(7, 68);
            this.rbnWithdraw.Name = "rbnWithdraw";
            this.rbnWithdraw.Size = new System.Drawing.Size(70, 17);
            this.rbnWithdraw.TabIndex = 2;
            this.rbnWithdraw.TabStop = true;
            this.rbnWithdraw.Text = "Withdraw";
            this.rbnWithdraw.UseVisualStyleBackColor = true;
            // 
            // rbnDeposit
            // 
            this.rbnDeposit.AutoSize = true;
            this.rbnDeposit.Location = new System.Drawing.Point(7, 44);
            this.rbnDeposit.Name = "rbnDeposit";
            this.rbnDeposit.Size = new System.Drawing.Size(61, 17);
            this.rbnDeposit.TabIndex = 1;
            this.rbnDeposit.TabStop = true;
            this.rbnDeposit.Text = "Deposit";
            this.rbnDeposit.UseVisualStyleBackColor = true;
            // 
            // rbnCreateAccount
            // 
            this.rbnCreateAccount.AutoSize = true;
            this.rbnCreateAccount.Location = new System.Drawing.Point(7, 20);
            this.rbnCreateAccount.Name = "rbnCreateAccount";
            this.rbnCreateAccount.Size = new System.Drawing.Size(124, 17);
            this.rbnCreateAccount.TabIndex = 0;
            this.rbnCreateAccount.TabStop = true;
            this.rbnCreateAccount.Text = "Create New Account";
            this.rbnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // gbxTextBox
            // 
            this.gbxTextBox.Controls.Add(this.lblBalanceTotal);
            this.gbxTextBox.Controls.Add(this.tbxDepositWithdraw);
            this.gbxTextBox.Controls.Add(this.tbxAccountName);
            this.gbxTextBox.Controls.Add(this.lblAccountBalance);
            this.gbxTextBox.Controls.Add(this.lblDepositWithdraw);
            this.gbxTextBox.Controls.Add(this.lblAccountName);
            this.gbxTextBox.Location = new System.Drawing.Point(176, 12);
            this.gbxTextBox.Name = "gbxTextBox";
            this.gbxTextBox.Size = new System.Drawing.Size(226, 119);
            this.gbxTextBox.TabIndex = 1;
            this.gbxTextBox.TabStop = false;
            // 
            // lblBalanceTotal
            // 
            this.lblBalanceTotal.AllowDrop = true;
            this.lblBalanceTotal.Location = new System.Drawing.Point(100, 77);
            this.lblBalanceTotal.Name = "lblBalanceTotal";
            this.lblBalanceTotal.Size = new System.Drawing.Size(103, 13);
            this.lblBalanceTotal.TabIndex = 5;
            this.lblBalanceTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxDepositWithdraw
            // 
            this.tbxDepositWithdraw.Location = new System.Drawing.Point(103, 47);
            this.tbxDepositWithdraw.Name = "tbxDepositWithdraw";
            this.tbxDepositWithdraw.Size = new System.Drawing.Size(100, 20);
            this.tbxDepositWithdraw.TabIndex = 4;
            // 
            // tbxAccountName
            // 
            this.tbxAccountName.Location = new System.Drawing.Point(103, 20);
            this.tbxAccountName.Name = "tbxAccountName";
            this.tbxAccountName.Size = new System.Drawing.Size(100, 20);
            this.tbxAccountName.TabIndex = 3;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(7, 77);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(89, 13);
            this.lblAccountBalance.TabIndex = 2;
            this.lblAccountBalance.Text = "Account Balance";
            // 
            // lblDepositWithdraw
            // 
            this.lblDepositWithdraw.AutoSize = true;
            this.lblDepositWithdraw.Location = new System.Drawing.Point(7, 50);
            this.lblDepositWithdraw.Name = "lblDepositWithdraw";
            this.lblDepositWithdraw.Size = new System.Drawing.Size(93, 13);
            this.lblDepositWithdraw.TabIndex = 1;
            this.lblDepositWithdraw.Text = "Deposit/Withdraw";
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(7, 23);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(78, 13);
            this.lblAccountName.TabIndex = 0;
            this.lblAccountName.Text = "Account Name";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 138);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(140, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process Transaction";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(176, 138);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(100, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 178);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.gbxTextBox);
            this.Controls.Add(this.gbxButtons);
            this.Name = "Form1";
            this.Text = "First Trust Savings Bank";
            this.gbxButtons.ResumeLayout(false);
            this.gbxButtons.PerformLayout();
            this.gbxTextBox.ResumeLayout(false);
            this.gbxTextBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxButtons;
        private System.Windows.Forms.RadioButton rbnCloseAccount;
        private System.Windows.Forms.RadioButton rbnWithdraw;
        private System.Windows.Forms.RadioButton rbnDeposit;
        private System.Windows.Forms.RadioButton rbnCreateAccount;
        private System.Windows.Forms.GroupBox gbxTextBox;
        private System.Windows.Forms.TextBox tbxDepositWithdraw;
        private System.Windows.Forms.TextBox tbxAccountName;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label lblDepositWithdraw;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblBalanceTotal;
    }
}

