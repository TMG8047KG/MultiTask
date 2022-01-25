using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

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
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject mo in mos.Get())
            {
                
            }
            //var RAMinfo = new Microsoft.VisualBasic.Devices.ComputerInfo();
            float memory = perfMem.NextValue();
            //ulong UsedRAM = RAMinfo.TotalPhysicalMemory - RAMinfo.AvailablePhysicalMemory;
            double ByteToGb = Math.Pow(1024, 3) + 0.5;

            //lblUsedRAM.Text = "Used Memory\n" + string.Format("{0:0.0} GB", UsedRAM/ByteToGb);
            //lblPhysicalRAM.Text = "Total Memory\n" + string.Format("{0:0.0} GB", (RAMinfo.TotalPhysicalMemory/ByteToGb)) + " " + string.Format("{0:0.0} GB", Math.Round(RAMinfo.TotalPhysicalMemory / ByteToGb));
            //lblAvaliableRAM.Text = "Available Memory\n" + string.Format("{0:0.0} GB", (RAMinfo.AvailablePhysicalMemory / ByteToGb));
            MemChart.Series["Memory Usage"].Points.AddY(memory);
        }
    }
}
