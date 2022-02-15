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

        private List<float> xV = new List<float>();
        private List<float> yV = new List<float>();

        int L2, L3;
        float tick = 0.0f;

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
            xV.Add(tick);
            yV.Add(cpuCounter.NextValue());

            if(tick > 12)
            {
                xV.RemoveAt(0);
                yV.RemoveAt(0);
            }

            ProcChart.ChartAreas["chAreaCPU"].AxisX.Minimum = xV[0];
            ProcChart.ChartAreas["chAreaCPU"].AxisX.Maximum = tick;

            ProcChart.Series["CPUchart"].Points.DataBindXY(xV, yV);
            tick += 1;
        }
    }
}
