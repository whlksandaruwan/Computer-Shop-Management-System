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
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
        }
        public void Count()
        {
            IblTotalProduct.Text = Computer.Computer.Count("SELECT COUNT(*)FROM PRODUCT;").ToString();
            IblTotalOrders.Text = Computer.Computer.Count("SELECT COUNT(*)FROM Orders WHERE Payment Satus = 'Not Paid';").ToString();
            IblLowStock.Text = Computer.Computer.Count("SELECT COUNT(*) FROM Product Status = 'Not Available';").ToString();
            IblTotalRevenue.Text = Computer.Computer.Count("SELECT SUM(Grand Total) FROM Orders;").ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            Count();
        }
    }
}
