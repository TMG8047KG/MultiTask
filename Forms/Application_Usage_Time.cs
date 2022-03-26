using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
                    }
                }
            }
            catch {  }
            return null;

            //timeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //try
            //{
            //    foreach (DataGridViewRow row in timeGrid.Rows)
            //    {
            //        if (row.Cells[0].Value.Equals(processName))
            //        {
            //            row.Selected = true;
            //            break;
            //        }
            //    }
            //}
            //catch (Exception exc)
            //{
            //    MessageBox.Show(exc.Message);
            //}
            //return null;
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
                    timeGrid.Rows.Add(test.ProcessName, 0, 0, 0, 0);
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
        }
    }
}
