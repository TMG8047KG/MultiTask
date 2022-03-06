using System;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using Microsoft.Win32;

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
            GetInfo("Win32_OperatingSystem", 0);
            GetInfo("Win32_OperatingSystem", 1);
            GetInfo("Win32_Processor", 2);
            GetInfo("Win32_OperatingSystem", 3);
            GetInfo("Win32_Processor", 4);
            lblDeviceName.Text = "Device name: " + System.Windows.Forms.SystemInformation.ComputerName; 
        }

        public void GetInfo(string CIM, int info)
        {
            try
            {
                RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
                var buildNumber = registryKey.GetValue("UBR").ToString();
            

                ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from " + CIM);

                foreach (ManagementObject obj in mos.Get())
                {
                    switch (info)
                    {
                        case 0:
                            {
                                lblWedition.Text = "Edition: " + (string)obj["Caption"];
                                break;
                            }
                        case 1:
                            {
                                lblSerialNumber.Text = "Serial Number: " + (string)obj["SerialNumber"];
                                break;
                            }
                        case 2:
                            {
                                lblSystemType.Text = "System Type: " + obj["AddressWidth"] + "-bit operating system, x" + obj["DataWidth"] + "-based processor";
                                break;
                            }
                        case 3:
                            {
                                lblOSbuild.Text = $"OS build: {obj["Version"]}.{buildNumber}";
                                break;
                            }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("devmgmt.msc");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("T");
        }
    }
}
