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
using System.Runtime.InteropServices;
using System.Data.Linq.Mapping;
using System.Runtime.CompilerServices;

namespace MultiTaskBase
{
    public partial class RAM : Form
    {
        ulong TotalPhysical;
        double KbyteToGb = Math.Pow(1024, 3) + 0.5;

        public RAM()
        {
            InitializeComponent();
        }

        private void Static_Info()
        {
            int form_factor;
            string form_value = string.Empty;
            ManagementObjectSearcher mosc = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject obj in mosc.Get())
            {
                form_factor = Convert.ToInt32(obj["FormFactor"]);
                lblSpeed.Text = "Speed:\n" + obj["Speed"] + " MHz";
                switch (form_factor)
                {
                    case 0: form_value = "Unknown"; break;
                    case 1: form_value = "Other"; break;
                    case 2: form_value = "SIP"; break;
                    case 3: form_value = "DIP"; break;
                    case 4: form_value = "ZIP"; break;
                    case 5: form_value = "SOJ"; break;
                    case 6: form_value = "Proprietary"; break;
                    case 7: form_value = "SIMM"; break;
                    case 8: form_value = "DIMM"; break;
                    case 9: form_value = "TSOP"; break;
                    case 10: form_value = "PGA"; break;
                    case 11: form_value = "RIMM"; break;
                    case 12: form_value = "SODIMM"; break;
                    case 13: form_value = "SRIMM"; break;
                    case 14: form_value = "SMD"; break;
                    case 15: form_value = "SSMP"; break;
                    case 16: form_value = "QFP"; break;
                    case 17: form_value = "TQFP"; break;
                    case 18: form_value = "SOIC"; break;
                    case 19: form_value = "LCC"; break;
                    case 20: form_value = "PLCC"; break;
                    case 21: form_value = "BGA"; break;
                    case 22: form_value = "FPBGA"; break;
                    case 23: form_value = "LGA"; break;
                }
                lblFormFactor.Text = "Form Factor:\n" + form_value;
            }
            
            
        }


        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private class MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;
            public MEMORYSTATUSEX()
            {
                this.dwLength = (uint)Marshal.SizeOf(this);
            }
        }

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);


        private void Memory_Load(object sender, EventArgs e)
        {
            RAM_tick.Start();;
            Static_Info();
            
            MEMORYSTATUSEX ramStaticInfo = new MEMORYSTATUSEX();
            if (GlobalMemoryStatusEx(ramStaticInfo))
            { 
                TotalPhysical = ramStaticInfo.ullTotalPhys / (ulong)(Math.Pow(1024, 2) + 0.5);
                MemChart.Titles[0].Text = "Total Memory\n" + string.Format("{0:0.0} GB", (TotalPhysical/(1024+0.5)));
                MemChart.ChartAreas[0].AxisY.Maximum = TotalPhysical;
                MemChart.ChartAreas[0].AxisY.Minimum = 0;
            }
        }

        private void RAM_tick_Tick(object sender, EventArgs e)
        {
            ulong UsedMem;
            MEMORYSTATUSEX ramInfo = new MEMORYSTATUSEX();
            if (GlobalMemoryStatusEx(ramInfo))
            {
                UsedMem = (ramInfo.ullTotalPhys - ramInfo.ullAvailPhys) / (ulong)Math.Pow(1024, 2);
                lblUsedRAM.Text = "Used Memory\n" + string.Format("{0:0.0} GB", (UsedMem/(1024 + 0.5)));
                lblAvaliableRAM.Text = "Available Memory\n" + string.Format("{0:0.0} GB", (ramInfo.ullAvailPhys / KbyteToGb));
                MemChart.Series["memory"].Points.AddY(UsedMem);
            }
            
        }
    }
}
