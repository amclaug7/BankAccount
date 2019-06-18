using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            accountName = "";
        }

        decimal deposit;
        decimal total;
        decimal total2;
        string accountName;
        float accountNameError;

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (rbnCreateAccount.Checked == true)
            {
                if (tbxAccountName.Text == "")
                {
                    MessageBox.Show("Enter Account Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (accountName != "")
                {
                    MessageBox.Show("Account Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxAccountName.Text = accountName;
                }
                else
                {
                    if (float.TryParse(tbxAccountName.Text, out accountNameError))
                    {
                        MessageBox.Show("Account Name Must Have Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        accountName = tbxAccountName.Text;
                    }
                }
            }
            if(rbnDeposit.Checked == true)
            {
                if (accountName == "")
                {
                    MessageBox.Show("Enter Account Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Decimal.TryParse(tbxDepositWithdraw.Text, out deposit))
                    {
                        total = total + deposit;
                        total2 = Math.Round(total, 2);
                        lblBalanceTotal.Text = $"${total2}";
                        tbxAccountName.Text = accountName;
                    }
                    else
                    {
                        MessageBox.Show("Must Enter Decimal Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (rbnWithdraw.Checked == true)
            {
                if (accountName == "")
                {
                    MessageBox.Show("Enter Account Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Decimal.TryParse(tbxDepositWithdraw.Text, out deposit))
                    {
                        total = total - deposit;
                        total2 = Math.Round(total, 2);
                        if (total2 < 0)
                        {
                            MessageBox.Show("Negative Balance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            total = total + deposit;
                            total2 = Math.Round(total, 2);
                            tbxAccountName.Text = accountName;
                        }
                        else
                        {
                            lblBalanceTotal.Text = $"${total2}";
                            tbxAccountName.Text = accountName;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Must Enter Decimal Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (rbnCloseAccount.Checked == true)
            {
                if (accountName == "")
                {
                    MessageBox.Show("Enter Account Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show("Are You Sure", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        tbxAccountName.Text = "";
                        tbxDepositWithdraw.Text = "";
                        lblBalanceTotal.Text = "";
                        accountName = "";
                        total = 0;
                    }
                    else if (result == DialogResult.No)
                    {

                    }
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}
