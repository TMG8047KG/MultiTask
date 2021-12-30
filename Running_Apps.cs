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

namespace TaskManger
{
    public partial class Running_Apps : Form
    {
        public Running_Apps()
        {
            InitializeComponent();
        }

        private void Running_Apps_Load(object sender, EventArgs e)
        {
            ListOfAllProcesses();
        }

        private void ListOfAllProcesses()
        {
            Process[] Procs = Process.GetProcesses();
            foreach (Process proc in Procs)
            {
                try
                {
                    dataGrid.Rows.Add(proc.ProcessName, proc.Id);
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

        private void btnStopProc_Click(object sender, EventArgs e)
        {
            //Process[] process = Process.GetProcesses();
            //try
            //{
            //    process p = process.getprocessbyid(int32.parse(datagrid.selectedrows[0].cells[1].value.tostring()));
            //    p.kill();
            //}
            //catch (Exception ex)
            //{
            //    messagebox.show(ex.message, "message", messageboxbuttons.ok, messageboxicon.error);
            //}
        }

       
    }
}
