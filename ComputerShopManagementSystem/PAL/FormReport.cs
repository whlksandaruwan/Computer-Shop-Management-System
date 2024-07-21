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
    public partial class FormReport : Form
    {
        internal static FormReport formReport;
        public DateTime startDate, endDate;

        public FormReport()
        {
            InitializeComponent();
        }
    }
}
