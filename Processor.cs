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
    public partial class Processor : Form
    {
        public Processor()
        {
            InitializeComponent();
        }

        private void Processor_Load(object sender, EventArgs e)
        {
            CPU_tick.Start();
            //GetComponet("Processor's Name\n", lblCPUname, "Win32_Processor", "Name");
            //GetComponet("Cores\n", lblCPUcores, "Win32_Processor", "NumberOfCores");
        }

        //private void GetComponet(string text, Label lable, string win_class, string syntax)
        //{
        //    ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + win_class);
        //    foreach(ManagementObject mobj in mos.Get())
        //    {
        //        lable.Text = text + Convert.ToString(mobj[syntax]);
        //    }
        //}

        private void CPU_tick_Tick(object sender, EventArgs e)
        {
            //GetComponet("Status", lblStatus, "Win32_Processor", "CpuStatus");
            //GetComponet("Persent Used", lblCPUpersent , "Win32_Processor", "LoadPercentage");
            //GetComponet("Current Speed", lblCPUspeed, "Win32_Processor", "CurrentClockSpeed");
            //GetComponet("Threads", lblTreads, "Win32_Processor", "ThreadCount");
            float CPU = perfCPU.NextValue();
            cpuChart.Series["CPU Usage"].Points.AddY(CPU);
            
        }
    }
}
