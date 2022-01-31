
namespace MultiTaskBase
{
    partial class Processor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.perfCPU = new System.Diagnostics.PerformanceCounter();
            this.CPU_tick = new System.Windows.Forms.Timer(this.components);
            this.lblCPUname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCPUpersent = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCPUtemp = new System.Windows.Forms.Label();
            this.lblTreads = new System.Windows.Forms.Label();
            this.lblCPUspeed = new System.Windows.Forms.Label();
            this.lblCPUcores = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // perfCPU
            // 
            this.perfCPU.CategoryName = "Processor";
            this.perfCPU.CounterName = "% Processor Time";
            this.perfCPU.InstanceName = "_Total";
            // 
            // CPU_tick
            // 
            this.CPU_tick.Interval = 1000;
            this.CPU_tick.Tick += new System.EventHandler(this.CPU_tick_Tick);
            // 
            // lblCPUname
            // 
            this.lblCPUname.AutoSize = true;
            this.lblCPUname.Location = new System.Drawing.Point(52, 356);
            this.lblCPUname.Name = "lblCPUname";
            this.lblCPUname.Size = new System.Drawing.Size(58, 13);
            this.lblCPUname.TabIndex = 1;
            this.lblCPUname.Text = "CPU name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPU name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPU name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPU name";
            // 
            // lblCPUpersent
            // 
            this.lblCPUpersent.AutoSize = true;
            this.lblCPUpersent.Location = new System.Drawing.Point(504, 356);
            this.lblCPUpersent.Name = "lblCPUpersent";
            this.lblCPUpersent.Size = new System.Drawing.Size(87, 13);
            this.lblCPUpersent.TabIndex = 5;
            this.lblCPUpersent.Text = "CPU loadpersent";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(433, 356);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblCPUtemp
            // 
            this.lblCPUtemp.AutoSize = true;
            this.lblCPUtemp.Location = new System.Drawing.Point(52, 476);
            this.lblCPUtemp.Name = "lblCPUtemp";
            this.lblCPUtemp.Size = new System.Drawing.Size(55, 13);
            this.lblCPUtemp.TabIndex = 7;
            this.lblCPUtemp.Text = "CPU temp";
            // 
            // lblTreads
            // 
            this.lblTreads.AutoSize = true;
            this.lblTreads.Location = new System.Drawing.Point(52, 499);
            this.lblTreads.Name = "lblTreads";
            this.lblTreads.Size = new System.Drawing.Size(71, 13);
            this.lblTreads.TabIndex = 8;
            this.lblTreads.Text = "CPU Threads";
            // 
            // lblCPUspeed
            // 
            this.lblCPUspeed.AutoSize = true;
            this.lblCPUspeed.Location = new System.Drawing.Point(691, 356);
            this.lblCPUspeed.Name = "lblCPUspeed";
            this.lblCPUspeed.Size = new System.Drawing.Size(61, 13);
            this.lblCPUspeed.TabIndex = 9;
            this.lblCPUspeed.Text = "CPU speed";
            // 
            // lblCPUcores
            // 
            this.lblCPUcores.AutoSize = true;
            this.lblCPUcores.Location = new System.Drawing.Point(331, 356);
            this.lblCPUcores.Name = "lblCPUcores";
            this.lblCPUcores.Size = new System.Drawing.Size(59, 13);
            this.lblCPUcores.TabIndex = 10;
            this.lblCPUcores.Text = "CPU Cores";
            // 
            // chart1
            // 
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "cpuChart";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(984, 338);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // Processor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblCPUcores);
            this.Controls.Add(this.lblCPUspeed);
            this.Controls.Add(this.lblTreads);
            this.Controls.Add(this.lblCPUtemp);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCPUpersent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCPUname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Processor";
            this.Text = "Processor";
            this.Load += new System.EventHandler(this.Processor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter perfCPU;
        private System.Windows.Forms.Timer CPU_tick;
        private System.Windows.Forms.Label lblCPUname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCPUpersent;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCPUtemp;
        private System.Windows.Forms.Label lblTreads;
        private System.Windows.Forms.Label lblCPUspeed;
        private System.Windows.Forms.Label lblCPUcores;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}