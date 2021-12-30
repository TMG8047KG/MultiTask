using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TaskManger
{
    public partial class MultiTask : Form
    {
        public MultiTask()
        {
            InitializeComponent();
        }


        private void MultiTask_Load(object sender, EventArgs e)
        {
            //hi
        }

        public void load_Form(object Form)
        {
            if(this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            Form fm = Form as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(fm);
            this.mainPanel.Tag = fm;
            fm.Show();
        }

        private void btnRunningApps_Click(object sender, EventArgs e)
        {
            load_Form(new Running_Apps());
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            load_Form(new Processor());
        }

        private void btnMem_Click(object sender, EventArgs e)
        {
            load_Form(new RAM());
        }
    }
}
