using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ComputerShopManagementSystem.PAL
{
    public partial class FormMain : Form
    {
        public String name = "{?}";
        public FormMain()
        {
            InitializeComponent();
        }


        private void MoveOanel(Control btn)
        {
            pnlMove.Top = btn.Top;
            pnlMove.Height = btn.Height;
        }
        private void FromMain(object sender, EventArgs e)
        {
            IblUsername.Text = name;
            timerDateAndTime.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to log out?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult == DialogResult.Yes)
            {
                MovePanel(btnClose);
                timerDateAndTime.Stop();
                Close();
                

                 
            }
        }

        private void MovePanel(Button btnClose)
        {
            throw new NotImplementedException();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            MovePanel(btnDashboard);
            userControlDashboard1.Visible = true;
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            MovePanel(btnBrand);
            userControlDashboard1.Visible = false;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            MovePanel(btnCategory);
            userControlDashboard1.Visible = false;
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MovePanel(btnProduct);
            userControlDashboard1.Visible = false;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            MovePanel(btnOrders);
            userControlDashboard1.Visible = false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MovePanel(btnReport);
            userControlDashboard1.Visible = false;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            MovePanel(btnUsers);
            userControlDashboard1.Visible = false;
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            IblTimeAndDate.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
