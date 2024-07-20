using Computer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShopManagementSystem.PAL
{
    public partial class UserControlProduct : UserControl
    {
        private string id = "";
        ImageConverter imageConverter;
        MemoryStream memoryStream;

        public UserControlProduct()
        {
            InitializeComponent();
            imageConverter = new ImageConverter();
        }

        private void ImageUpload(PictureBox picture)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    picture.Image = Image.FromFile(openFileDialog.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Image upload error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EmptyBox()
        {
            txtProductName.Clear();
            picPhoto.Image = null;
            nudRate.Value = 0;
            nudQuatity.Value = 0;
            cmbBrand.Items.Clear();
            cmbBrand.Items.Add("-- SELECT --");
            Computer.Computer.BrandCategoryProduct("SELECT Brand_Name FROM Brand WHERE Brand_Status = 'Available' ORDER BY Brand_Name;", cmbBrand);
            cmbBrand.SelectedIndex = 0;
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("-- SELECT --");
            Computer.Computer.BrandCategoryProduct("SELECT Category_Name FROM Category WHERE Category_Status = 'Available' ORDER BY Category_Name;", cmbCategory);
            cmbCategory.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
        }

        private void EmptyBx1()
        {
            txtProductName1.Clear();
            picPhoto1.Image = null;
            nudRate1.Value = 0;
            nudQuantity1.Value = 0;
            ComboBoxAutoFill();
            cmbStatus1.SelectedIndex = 0;
            id = "";
        }

        private void ComboBoxAutoFill()
        {
            cmbBrand1.Items.Clear();
            cmbBrand1.Items.Add("-- SELECT --");
            Computer.Computer.BrandCategoryProduct("SELECT Brand_Name FROM Brand WHERE Brand_Status = 'Available' ORDER BY Brand_Name;", cmbBrand1);
            cmbBrand1.SelectedIndex = 0;
            cmbCategory1.Items.Clear();
            cmbCategory1.Items.Add("-- SELECT --");
            Computer.Computer.BrandCategoryProduct("SELECT Category_Name FROM Category WHERE Category_Status = 'Available' ORDER BY Category_Name;", cmbCategory1);
            cmbCategory1.SelectedIndex = 0;
        }

        private void picSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picSearch, "Search");
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ImageUpload(picPhoto);
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            ImageUpload(picPhoto1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter product name.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (picPhoto.Image == null)
            {
                MessageBox.Show("Please select image.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudRate.Value == 0)
            {
                MessageBox.Show("Please enter rate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (nudQuatity.Value == 0)
            {
                MessageBox.Show("Please enter quantity.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbBrand.SelectedIndex == 0)
            {
                MessageBox.Show("Please select brand.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbCategory.SelectedIndex == 0)
            {
                MessageBox.Show("Please select category.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (cmbStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please select status.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                Product product = new Product(txtProductName.Text.Trim(), (byte[])imageConverter.ConvertTo(picPhoto.Image, typeof(byte[])), Convert.ToInt32(nudRate.Value), Convert.ToInt32(nudQuatity.Value), cmbBrand.SelectedItem.ToString(), cmbCategory.SelectedItem.ToString(), cmbStatus.SelectedItem.ToString());
                Computer.Computer.AddProduct(product);
                EmptyBox();
            }
        }

        private void tpAddProduct_Enter(object sender, EventArgs e)
        {
            EmptyBox();
        }

        private void tpManageProduct_Enter(object sender, EventArgs e)
        {
            txtSearchProductName.Clear();
            dgvProduct.Columns[0].Visible = false;
            Computer.Computer.DisplayAndSearch("SELECT * FROM Product;", dgvProduct);
            lblTotal.Text = dgvProduct.Rows.Count.ToString();
        }

        private void txtSearchProductName_TextChanged(object sender, EventArgs e)
        {
            Computer.Computer.DisplayAndSearch("SELECT * FROM Product WHERE Product_Name LIKE ' %" + txtSearchProductName.Text + "%';", dgvProduct);
            lblTotal.Text = dgvProduct.Rows.Count.ToString();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
