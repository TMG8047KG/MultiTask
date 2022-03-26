using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace MultiTaskBase
{
    public partial class Processor : Form
    {
        PerformanceCounter cpuCounter;

        private List<float> xV = new List<float>();
        private List<float> yV = new List<float>();

        float tick = 0.0f;

        

        public Processor()
        {
            InitializeComponent();
        }

        private void Processor_Load(object sender, EventArgs e)
        {
            CPU_tick.Start();
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
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
