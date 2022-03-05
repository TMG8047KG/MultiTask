using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTaskBase.Forms
{
    public partial class home_page : Form
    {
        public home_page()
        {
            InitializeComponent();
        }

        private void home_page_Load(object sender, EventArgs e)
        {
            lblPCname.Text = System.Windows.Forms.SystemInformation.ComputerName;
        }
    }
}
