using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_practice_winka
{
    public partial class Form1 : Form

    {
        public List<Item> itemList = new List<Item>();
        public int foundPosition = -1;

        public Form1()

        {
            InitializeComponent();
            itemList.Add(new Item()
            {
                Name = "paul",
                UPC = "123",
                Price = 9,
                CaseCost = 100,
                CaseUnits = 12,
                Distributor = "Winka"
            });
            itemList.Add(new Item()
            {
                Name = "ted",
                UPC = "456",
                Price = 19,
                CaseCost = 1900,
                CaseUnits = 1002,
                Distributor = "bounty"
            });
            itemList.Add(new Item()
            {
                Name = "john",
                UPC = "443",
                Price = 9999,
                CaseCost = 6100,
                CaseUnits = 3412,
                Distributor = "tower"
            });
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string getName = txtSearchName.Text;
            bool found = false;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (getName.ToLower() == itemList[i].Name)
                {
                    txtShowName.Text = itemList[i].Name;
                    txtShowUPC.Text = itemList[i].UPC;
                    txtShowPrice.Text = String.Format("{0:C}", itemList[i].Price);
                    txtShowCaseCost.Text = Convert.ToString(itemList[i].CaseCost);
                    txtShowCaseUnits.Text = Convert.ToString(itemList[i].CaseUnits);
                    txtShowDistributor.Text = itemList[i].Distributor;
                    foundPosition = i;
                    found = true;
                    pnlAdd.Visible = true;
                    pnlChange.Visible = true;
                    pnlDelete.Visible = true;
                }
            }
            if (found == false)
            {
                txtShowName.Text = "";
                txtShowUPC.Text = "";
                txtShowPrice.Text = "";
                txtShowCaseCost.Text = "";
                txtShowCaseUnits.Text = "";
                txtShowDistributor.Text = "";
                MessageBox.Show("nothing found");
            }
        }

        private void btnSearchUPC_Click(object sender, EventArgs e)
        {
            string getUPC = txtSearchUPC.Text;
            bool found = false;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (getUPC == itemList[i].UPC)
                {
                    txtShowName.Text = itemList[i].Name;
                    txtShowUPC.Text = itemList[i].UPC;
                    txtShowPrice.Text = String.Format("{0:C}", itemList[i].Price);
                    txtShowCaseCost.Text = Convert.ToString(itemList[i].CaseCost);
                    txtShowCaseUnits.Text = Convert.ToString(itemList[i].CaseUnits);
                    txtShowDistributor.Text = itemList[i].Distributor;
                    txtShowName.Text = itemList[i].Name;
                    txtShowUPC.Text = itemList[i].UPC;
                    txtShowPrice.Text = String.Format("{0:C}", itemList[i].Price);
                    txtShowCaseCost.Text = Convert.ToString(itemList[i].CaseCost);
                    txtShowCaseUnits.Text = Convert.ToString(itemList[i].CaseUnits);
                    txtShowDistributor.Text = itemList[i].Distributor;
                    pnlAdd.Visible = true;
                    pnlChange.Visible = true;
                    pnlDelete.Visible = true;
                }
            }
            if (found == false)
            {
                txtShowName.Text = "";
                txtShowUPC.Text = "";
                txtShowPrice.Text = "";
                txtShowCaseCost.Text = "";
                txtShowCaseUnits.Text = "";
                txtShowDistributor.Text = "";
                MessageBox.Show("nothing found");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            txtErrorAdd.Text = "";
            string getAccess = txtChangeAccess.Text;
            double getPrice = Convert.ToDouble(txtChangePrice.Text);
            if (getAccess == "123")
            {
                itemList[foundPosition].Price = getPrice;
                txtShowPrice.Text = String.Format("{0:C}", getPrice);
                MessageBox.Show("update price");
            }
            else { txtErrorAdd.Text = "a k i"; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtErrorDelete.Text = "";
            string getAccess = txtDeleteAccess.Text;
            string getUPC = txtUPCVerify.Text;
            if (getAccess == "123")
            {
                if (getUPC == itemList[foundPosition].UPC)
                {
                    itemList.Remove(itemList[foundPosition]);
                    MessageBox.Show("deleted");
                    txtShowName.Text = "";
                    txtShowPrice.Text = "";
                    txtShowCaseCost.Text = "";
                    txtShowCaseUnits.Text = "";
                    txtShowDistributor.Text = "";
                    txtShowUPC.Text = "";
                }
            }
            else { txtErrorAdd.Text = "a k i"; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool duplicates = false;
            string getUPC = txtAddUPC.Text;
            string getAccess = txtAddAccess.Text;
            for (int i = 0; i < itemList.Count; i++)
            {
                if (itemList[foundPosition].UPC == getUPC)
                {
                    duplicates = true;
                    MessageBox.Show("duplicates");
                }
                else { duplicates = false; }
            }
            if (getAccess == "123")
            {
                if (duplicates == false)
                {
                    string addName = txtAddName.Text;
                    double addPrice = Convert.ToDouble(txtAddPrice.Text);
                    double addCaseCost = Convert.ToDouble(txtAddCostCase.Text);
                    double addCaseUnits = Convert.ToDouble(txtAddUnitsCase.Text);
                    string addDistributor = txtAddDistributor.Text;
                    itemList.Add(new Item()
                    {
                        Name = addName,
                        Price = addPrice,
                        UPC = getUPC,
                        CaseCost = addCaseCost,
                        CaseUnits = addCaseUnits,
                        Distributor = addDistributor
                    });
                    MessageBox.Show("item added");
                }
            }
            else { MessageBox.Show("a k i "); }
        }
    }
}