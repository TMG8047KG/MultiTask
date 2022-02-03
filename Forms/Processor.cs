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
using System.Diagnostics;

namespace MultiTaskBase
{
    public partial class Processor : Form
    {
        PerformanceCounter cpuCounter;

        int L1, L2, L3;

        public Processor()
        {
            InitializeComponent();
        }

        private void Processor_Load(object sender, EventArgs e)
        {
            CPU_tick.Start();
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            ManagementObjectSearcher mosuc = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach(ManagementObject obj in mosuc.Get())
            {
                ProcChart.Titles[0].Text = "" + obj["Name"];
                lblCores.Text = "Cores:\n" + obj["NumberOfCores"];
                lblLogicalProcs.Text = "Logical Processors:\n" + obj["NumberOfLogicalProcessors"];
                lblBaseSpeed.Text = "Base Speed:\n" + obj["CurrentClockSpeed"];
                L2 = Convert.ToInt32(obj["L2CacheSize"]);
                L3 = Convert.ToInt32(obj["L3CacheSize"]); 
            }
            lblL2cache.Text = "L2 Cache:\n" + string.Format("{0:0.0} MB", L2 / 0.5);
            lblL3cache.Text = "L3 Cache:\n" + string.Format("{0:0.0} MB", L3 / 0.5);
        }

        private void CPU_tick_Tick(object sender, EventArgs e)
        {
            ProcChart.Series[0].Points.AddY(cpuCounter.NextValue());
        }
    }
}
