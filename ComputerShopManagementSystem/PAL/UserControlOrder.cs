using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShopManagementSystem.PAL
{
    public partial class UserControlOrder : UserControl
    {
        private string id = "";

        public UserControlOrder()
        {
            InitializeComponent();
        }

        public void EmptyBox()
        {
            dtpDate.Value = DateTime.Now;
            txtCustomerName.Clear();
            mtbCustomerNumber.Clear();
            AddClear();
            dgvProductList.Rows.Clear();
            txtTotalAmount.Text = "0";
            nudPaidAmount.Value = 0;
            txtDueAmount.Text = "0";
            nudDiscount.Value = 0;
            txtGrandTotal.Text = "0";
            cmbPaymentStatus.SelectedIndex = 0;
        }

        private void AddClear()
        {
            cmbProduct.Items.Clear();
            cmbProduct.Items.Add("-- SELECT --");
            Computer.Computer.BrandCategoryProduct("SELECT Product_Name FROM Product WHERE Product_Status = 'Available' ORDER BY Product_Name;", cmbProduct);
            cmbProduct.SelectedIndex = 0;
            txtRate.Clear();
            nudQuatity.Value = 0;
            txtTotal.Clear();
        }

        private void EmptyBox1()
        {
            dtpDate1.Value = DateTime.Now;
            txtCustomerName1.Clear();
            mtbCustomerNumber1.Clear();
            txtTotalAmount1.Text = "0";
            nudPaidAmount1.Value = 0;
            txtDueAmount1.Text = "0";
            nudDiscount1.Value = 0;
            txtGrandTotal1.Text = "0";
            cmbPaymentStatus1.SelectedIndex = 0;
            id = "";
        }

        RichTextBox richTextBox = new RichTextBox();
        private void Receipt()
        {
            richTextBox.Clear();
            richTextBox.Text += "\t       COMPUTER SHOP MANAGEMENT SYSTEM\n";
            richTextBox.Text += "*************************************************\n\n";
            richTextBox.Text += "   Date: " + dtpDate.Text + "\n";
            richTextBox.Text += "   Name: " + txtSearchCustomerName.Text.Trim() + "\n";
            richTextBox.Text += "   Number: " + mtbCustomerNumber.Text.Trim() + "\n\n";
            richTextBox.Text += "*************************************************\n";
            richTextBox.Text += "   Name\t\tRate\t\tQuantity\t\tTotal\n";
            for (int i = 0; i < dgvProductList.Rows.Count; i++)
            {
                for (int j = 0; j < dgvProductList.Columns.Count - 1; j++)
                    richTextBox.Text += dgvProductList.Rows[i].Cells[j].Value.ToString() + "\t\t";
                richTextBox.Text += "\n";
            }
            richTextBox.Text += "*************************************************\n\n";
            richTextBox.Text += "\t\t\t\t\tTotal: $ " + txtTotalAmount.Text + "\n";
            richTextBox.Text += "\t\t\t\t\tPaid Amount: $ " + nudPaidAmount.Value + "\n";
            richTextBox.Text += "\t\t\t\t\tDue Amount: $ " + txtDueAmount.Text + "\n";
            richTextBox.Text += "\t\t\t\t\tDiscount: $ " + nudDiscount.Value + "\n";
            richTextBox.Text += "\t\t\t\t\tGrand Total: $ " + txtGrandTotal.Text + "\n";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAdd, "Add");
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(picSearch, "Search");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cmbProduct.SelectedIndex == 0)
            {
                MessageBox.Show("Please select product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudQuatity.Value == 0)
            {
                MessageBox.Show("Please enter quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if(nudQuatity.Value > 0)
                {
                    int rate, total;
                    Int32.TryParse(txtRate.Text, out rate);
                    Int32.TryParse(txtTotal.Text, out total);
                    if(dgvProductList.Rows.Count !=0)
                    {
                        foreach(DataGridViewRow rows in dgvProductList.Rows)
                        {
                            if (rows.Cells[0].Value.ToString() == cmbProduct.SelectedItem.ToString())
                            {
                                int quantity = Convert.ToInt32(rows.Cells[2].Value.ToString());
                                int total1 = Convert.ToInt32(rows.Cells[3].Value.ToString());
                                quantity += Convert.ToInt32(nudQuatity.Value);
                                total += total;
                                rows.Cells[2].Value = quantity;
                                rows.Cells[3].Value = total1;
                                AddClear();
                            }
                            else
                            {
                                if(cmbProduct.SelectedIndex != 0)
                                {
                                    txtTotal.Text = (rate * Convert.ToInt32(nudQuatity.Value)).ToString();
                                    string[] row =
                                    {
                                        cmbProduct.SelectedItem.ToString(), txtRate.Text, nudQuatity.Value.ToString(), txtTotal.Text
                                    };
                                    dgvProductList.Rows.Add(row);
                                    AddClear();
                                }
                            }
                        }
                    }
                    else
                    {
                        txtTotal.Text = (rate * Convert.ToInt32(nudQuatity.Value)).ToString();
                        string[] row =
                                    {
                                        cmbProduct.SelectedItem.ToString(), txtRate.Text, nudQuatity.Value.ToString(), txtTotal.Text
                                    };
                        dgvProductList.Rows.Add(row);
                        AddClear();
                    }
                }
                txtTotalAmount
            }
        }
    }
}
