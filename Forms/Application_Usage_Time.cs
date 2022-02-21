using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MultiTaskBase.Forms
{
    public partial class Application_Usage_Time : Form
    {
        public Application_Usage_Time()
        {
            InitializeComponent();
        }

        private void UsageTime_Load(object sender, EventArgs e)
        {

        }
        public string getActiveWindowName()
        {
            string processName;
            try
            {
                var activatedHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {

                    if (activatedHandle == clsProcess.MainWindowHandle)
                    {
                        processName = clsProcess.ProcessName;

                        return processName;
                        if (processName != timeGrid.GetType().Name)
                        {
                            //timeGrid.Rows.Add(clsProcess.MainWindowTitle);
                        }
                        else if (processName == timeGrid.GetType().Name)
                        {

                        }
                    }
                }
            }
            catch { }
            return null;

            timeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in timeGrid.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(processName))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();

        public void fifi()
        {
            Process[] proc = Process.GetProcesses();
            foreach (Process test in proc)
            {
                try
                {
                   timeGrid.Rows.Add(test.MainWindowTitle);
                }
                catch (Win32Exception ex)
                {
                    if (ex.NativeErrorCode == 5)
                    {
                        continue;
                    }
                    throw;
                }
            }
        }


        private void tick_Tick(object sender, EventArgs e)
        {
            getActiveWindowName();
        }
    }
}
