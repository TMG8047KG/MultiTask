using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MultiTaskBase.Forms
{
    public partial class Application_Usage_Time : Form
    {
        public int use_time=1;


        public Application_Usage_Time()
        {
            InitializeComponent();
        }

        private void UsageTime_Load(object sender, EventArgs e)
        {

        }
        public void getActiveWindowName()
        {
            string processName=""; 
            var activatedHandle = GetForegroundWindow();
            try { 
                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {
                    if(activatedHandle == clsProcess.MainWindowHandle)
                    {
                        
                        processName = clsProcess.ProcessName;
                        timeGrid.Rows.Add(processName, use_time, clsProcess.StartTime.ToString("T"), 0, 0);
                    }
                }

                for (int i = 0; i < timeGrid.RowCount - 1; i++)
                {
                    var Row = timeGrid.Rows[i];
                    string rowFields = Row.Cells[0].Value.ToString();

                    for (int j = i + 1; j < timeGrid.RowCount -1; j++)
                    {
                        var Row2 = timeGrid.Rows[j];
                        int r1, r2;
                        string def = Row2.Cells[0].Value.ToString();
                        if (rowFields == def)
                        {
                            Row.Cells[1].Value = (int)Row.Cells[1].Value + (int)Row2.Cells[1].Value;
                            timeGrid.Rows.Remove(Row2);
                            j--;
                        }
                    }
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();


        private void tick_Tick(object sender, EventArgs e)
        {
            getActiveWindowName();
        }
    }
}
