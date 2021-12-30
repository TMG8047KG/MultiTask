﻿using System;
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
    public partial class Processor : Form
    {
        public Processor()
        {
            InitializeComponent();
        }

        private void Processor_Load(object sender, EventArgs e)
        {
            float CPU = perfCPU.NextValue();
            cpuChart.Series["CPU Usage"].Points.AddY(CPU);
        }
    }
}
