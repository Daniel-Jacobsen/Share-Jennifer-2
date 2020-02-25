using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankLogin
{
    public partial class Form1 : Form
    {
        private int loggedIn = 0;
        private int foundPosition = -1;
        public List<Account> accountList = new List<Account>();

        public Form1()
        {
            InitializeComponent();
            accountList.Add(new Account("AB", "123", "Mr. Adams", 1));
            accountList.Add(new Account("CD", "123", "Mr. Beasley", 2));
            accountList.Add(new Account("EF", "123", "Mr. Chávez", 3));
            accountList.Add(new Account("GH", "123", "Mr. Dell", 4));
            accountList.Add(new Account("IJ", "123", "Mr. Echo", 5));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Login()
        {
            string getAN = txtAcc.Text;
            string getPIN = txtPIN.Text;
            for (int i = 0; i < accountList.Count; i++)

            {
                if (getAN == accountList[i].GetAccountNumber() && getPIN == accountList[i].GetPIN() && loggedIn == 0)
                {
                    loggedIn++;
                    lblWelcome.Text = String.Format("{0}", accountList[i].GetName());
                    lblBalance.Text = String.Format("{0:C}", accountList[i].GetBalance());
                    pnlMain.Visible = true;
                    foundPosition = i;
                    break;
                }
                if (getAN != accountList[i].GetAccountNumber() && getPIN != accountList[i].GetPIN() && loggedIn == 0)
                {
                    MessageBox.Show("bad login");
                    txtAcc.Text = "";
                    txtPIN.Text = "";
                    lblWelcome.Text = "";
                    lblBalance.Text = "";
                    pnlMain.Visible = false;
                    break;
                }
                if (getAN == accountList[i].GetAccountNumber() && getPIN == accountList[i].GetPIN() && loggedIn == 1)
                {
                    loggedIn--;
                    MessageBox.Show("user already logged in, now logged out");
                    txtAcc.Text = "";
                    txtPIN.Text = "";
                    lblWelcome.Text = "";
                    lblBalance.Text = "";
                    pnlMain.Visible = false;
                    break;
                }
            }
        }

        private void Logout()
        {
            loggedIn = 0;
            lblWelcome.Text = "";
            lblBalance.Text = "";
            pnlMain.Visible = false;
        }

        public void MakeDeposit(decimal amount)
        {
            lblBalance.Text = "";
            accountList[foundPosition].MakeDeposit(amount);
            lblBalance.Text = String.Format("{0:C}", accountList[foundPosition].GetBalance());
        }

        public void MakeWithDrawal(decimal amount)
        {
            lblBalance.Text = "";
            accountList[foundPosition].MakeWithDrawal(amount);
            lblBalance.Text = String.Format("{0:C}", accountList[foundPosition].GetBalance());
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            try
            {
                MakeDeposit(Convert.ToDecimal(txtDep.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
        }

        private void btnWith_Click(object sender, EventArgs e)
        {
            try
            {
                MakeWithDrawal(Convert.ToDecimal(txtWit.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
        }
    }
}