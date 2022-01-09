using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;

namespace MultiTaskBase
{
    public partial class RAM : Form
    {

        public RAM()
        {
            InitializeComponent();
        }

        private void Memory_Load(object sender, EventArgs e)
        {
            
            RAM_tick.Start();
        }

        private void RAM_tick_Tick(object sender, EventArgs e)
        {
            var RAMinfo = new Microsoft.VisualBasic.Devices.ComputerInfo();
            float memory = perfMem.NextValue();

            lblPhysicalRAM.Text = "Total Memory\n" + string.Format("{0:0.0} GB", (RAMinfo.TotalPhysicalMemory/(Math.Pow(1024, 3)+0.5)));
            lblAvaliableRAM.Text = "Available Memory\n" + string.Format("{0:0.0} GB", (RAMinfo.AvailablePhysicalMemory / (Math.Pow(1024, 3) + 0.5)));
            MemChart.Series["Memory Usage"].Points.AddY(memory);
        }
    }
}
