using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using MultiTaskBase.Forms.Processor;

namespace MultiTaskBase
{
    public partial class Processor : Form
    {
        PerformanceCounter cpuCounter;

        private List<float> xV = new List<float>();
        private List<float> yV = new List<float>();

        long L1, L2, L3;
        float tick = 0.0f;

        

        public Processor()
        {
            InitializeComponent();
        }

        private void Processor_Load(object sender, EventArgs e)
        {
            CPU_tick.Start();
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");

            CPU_cache.GetPerCoreCacheSizes(out L1, out L2, out L3);

            lblL1cache.Text = "L1 Cache:\n" + string.Format("{0} KB", (L1/1024)*6);
            lblL2cache.Text = "L2 Cache:\n" + string.Format("{0:0.0} KB", (L2 / Math.Pow(1024, 2) * 6) + 0.0);
            lblL3cache.Text = "L3 Cache:\n" + string.Format("{0:0.0} KB", (L3/Math.Pow(1024, 2) * 2) + 0.0);
            
            GetCPUInfo(0);
            GetCPUInfo(1);
            GetCPUInfo(2);
            GetCPUInfo(3);
        }
        

        public TimeSpan UpTime
        {
            get
            {
                using (var uptime = new PerformanceCounter("System", "System Up Time"))
                {
                    uptime.NextValue();       //Call this an extra time before reading its value
                    return TimeSpan.FromSeconds(uptime.NextValue());
                }
            }
        }

        private void TimerUpTime_Tick(object sender, EventArgs e)
        {
            lblUpTime.Text = "Up Time\n" + UpTime.ToString();
        }

        private void GetCPUInfo(int index)
        {
            try
            {
                ManagementObjectSearcher mosuc = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject obj in mosuc.Get())
                {
                    switch (index)
                    {
                        case 0: ProcChart.Titles[0].Text = "" + obj["Name"];
                            break;
                        case 1: lblCores.Text = "Cores:\n" + obj["NumberOfCores"];
                            break;
                        case 2: lblLogicalProcs.Text = "Logical Processors:\n" + obj["NumberOfLogicalProcessors"];
                            break;
                        case 3: lblBaseSpeed.Text = "Base Speed:\n" + string.Format("{0:0.00} GHz", Convert.ToInt32(obj["CurrentClockSpeed"])/1000.0);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CPU_tick_Tick(object sender, EventArgs e)
        {
            float util = cpuCounter.NextValue();
            
            xV.Add(tick);
            yV.Add(util);

            if(tick > 12)
            {
                xV.RemoveAt(0);
                yV.RemoveAt(0);
            }

            ProcChart.ChartAreas["chAreaCPU"].AxisX.Minimum = xV[0];
            ProcChart.ChartAreas["chAreaCPU"].AxisX.Maximum = tick;

            ProcChart.Series["CPUchart"].Points.DataBindXY(xV, yV);
            tick += 1;

            lblUtily.Text = "Utilization\n" + (int)util;
        }
    }
}
