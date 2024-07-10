using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShopManagementSystem.PAL
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void EmptyBox()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picShow_Click(object sender, EventArgs e)
        {
            if(picShow.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                picShow.Visible = false;
                picHide.Visible = true;
            }
        }

        private void picHide_Click(object sender, EventArgs e)
        {
            if (picHide.Visible == true)
            {
                txtPassword.UseSystemPasswordChar = true;
                picShow.Visible = true;
                picHide.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please enter username.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (txtPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please enter password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    bool check = Computer.Computer.IsValidNamePass(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                    if (check)
                    {
                        this.Hide();
                        FormMain formMain = new FormMain();
                        formMain.ShowDialog();
                        EmptyBox();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            formForgotPassword.ShowDialog();
            this.Show();
        }
    }
}
