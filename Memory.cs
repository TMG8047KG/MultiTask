using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiTaskBase
{
    public partial class RAM : Form
    {
        public RAM()
        {
            InitializeComponent();
        }

        private void Memory_Load(object sender, EventArgs e)
        {
            tick.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float memory = perfMem.NextValue();
            MemChart.Series["Memory Usage"].Points.AddY(memory);
        }
    }
}
