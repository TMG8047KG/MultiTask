
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.CPU_tick = new System.Windows.Forms.Timer(this.components);
            this.ProcChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChartLine = new System.Windows.Forms.Panel();
            this.lblUtily = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblL3cache = new System.Windows.Forms.Label();
            this.lblL2cache = new System.Windows.Forms.Label();
            this.lblL1cache = new System.Windows.Forms.Label();
            this.lblLogicalProcs = new System.Windows.Forms.Label();
            this.lblCores = new System.Windows.Forms.Label();
            this.lblBaseSpeed = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblUpTime = new System.Windows.Forms.Label();
            this.TimerUpTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProcChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CPU_tick
            // 
            this.CPU_tick.Interval = 1000;
            this.CPU_tick.Tick += new System.EventHandler(this.CPU_tick_Tick);
            // 
            // ProcChart
            // 
            this.ProcChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.LabelStyle.Enabled = false;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            chartArea2.Name = "chAreaCPU";
            this.ProcChart.ChartAreas.Add(chartArea2);
            this.ProcChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcChart.Location = new System.Drawing.Point(0, 0);
            this.ProcChart.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ProcChart.Name = "ProcChart";
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(138)))), ((int)(((byte)(158)))));
            series2.BorderWidth = 5;
            series2.ChartArea = "chAreaCPU";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(173)))), ((int)(((byte)(194)))));
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(90)))));
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(123)))));
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "CPUchart";
            this.ProcChart.Series.Add(series2);
            this.ProcChart.Size = new System.Drawing.Size(1000, 330);
            this.ProcChart.TabIndex = 11;
            this.ProcChart.Text = "chart1";
            title2.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.IsDockedInsideChartArea = false;
            title2.Name = "procName";
            this.ProcChart.Titles.Add(title2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.ChartLine);
            this.panel1.Controls.Add(this.lblUtily);
            this.panel1.Location = new System.Drawing.Point(14, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 57);
            this.panel1.TabIndex = 12;
            // 
            // ChartLine
            // 
            this.ChartLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(173)))), ((int)(((byte)(194)))));
            this.ChartLine.Location = new System.Drawing.Point(0, 0);
            this.ChartLine.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ChartLine.Name = "ChartLine";
            this.ChartLine.Size = new System.Drawing.Size(5, 57);
            this.ChartLine.TabIndex = 0;
            // 
            // lblUtily
            // 
            this.lblUtily.AutoSize = true;
            this.lblUtily.Location = new System.Drawing.Point(13, 9);
            this.lblUtily.Name = "lblUtily";
            this.lblUtily.Size = new System.Drawing.Size(0, 19);
            this.lblUtily.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblL3cache);
            this.panel3.Controls.Add(this.lblL2cache);
            this.panel3.Controls.Add(this.lblL1cache);
            this.panel3.Controls.Add(this.lblLogicalProcs);
            this.panel3.Controls.Add(this.lblCores);
            this.panel3.Controls.Add(this.lblBaseSpeed);
            this.panel3.Location = new System.Drawing.Point(478, 8);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 309);
            this.panel3.TabIndex = 13;
            // 
            // lblL3cache
            // 
            this.lblL3cache.AutoSize = true;
            this.lblL3cache.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblL3cache.Location = new System.Drawing.Point(0, 95);
            this.lblL3cache.Name = "lblL3cache";
            this.lblL3cache.Size = new System.Drawing.Size(0, 19);
            this.lblL3cache.TabIndex = 5;
            // 
            // lblL2cache
            // 
            this.lblL2cache.AutoSize = true;
            this.lblL2cache.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblL2cache.Location = new System.Drawing.Point(0, 76);
            this.lblL2cache.Name = "lblL2cache";
            this.lblL2cache.Size = new System.Drawing.Size(0, 19);
            this.lblL2cache.TabIndex = 4;
            // 
            // lblL1cache
            // 
            this.lblL1cache.AutoSize = true;
            this.lblL1cache.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblL1cache.Location = new System.Drawing.Point(0, 57);
            this.lblL1cache.Name = "lblL1cache";
            this.lblL1cache.Size = new System.Drawing.Size(0, 19);
            this.lblL1cache.TabIndex = 3;
            // 
            // lblLogicalProcs
            // 
            this.lblLogicalProcs.AutoSize = true;
            this.lblLogicalProcs.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogicalProcs.Location = new System.Drawing.Point(0, 38);
            this.lblLogicalProcs.Name = "lblLogicalProcs";
            this.lblLogicalProcs.Size = new System.Drawing.Size(0, 19);
            this.lblLogicalProcs.TabIndex = 1;
            // 
            // lblCores
            // 
            this.lblCores.AutoSize = true;
            this.lblCores.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCores.Location = new System.Drawing.Point(0, 19);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(0, 19);
            this.lblCores.TabIndex = 0;
            // 
            // lblBaseSpeed
            // 
            this.lblBaseSpeed.AutoSize = true;
            this.lblBaseSpeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaseSpeed.Location = new System.Drawing.Point(0, 0);
            this.lblBaseSpeed.Name = "lblBaseSpeed";
            this.lblBaseSpeed.Size = new System.Drawing.Size(0, 19);
            this.lblBaseSpeed.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 330);
            this.panel2.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(51)))));
            this.panel4.Controls.Add(this.lblUpTime);
            this.panel4.Location = new System.Drawing.Point(14, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 246);
            this.panel4.TabIndex = 14;
            // 
            // lblUpTime
            // 
            this.lblUpTime.AutoSize = true;
            this.lblUpTime.Location = new System.Drawing.Point(3, 206);
            this.lblUpTime.Name = "lblUpTime";
            this.lblUpTime.Size = new System.Drawing.Size(9, 19);
            this.lblUpTime.TabIndex = 2;
            this.lblUpTime.Text = "\r\n";
            // 
            // TimerUpTime
            // 
            this.TimerUpTime.Enabled = true;
            this.TimerUpTime.Interval = 1;
            this.TimerUpTime.Tick += new System.EventHandler(this.TimerUpTime_Tick);
            // 
            // Processor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.ProcChart);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Processor";
            this.Text = "Processor";
            this.Load += new System.EventHandler(this.Processor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer CPU_tick;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProcChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ChartLine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUtily;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblL3cache;
        private System.Windows.Forms.Label lblL2cache;
        private System.Windows.Forms.Label lblL1cache;
        private System.Windows.Forms.Label lblLogicalProcs;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.Label lblBaseSpeed;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUpTime;
        private System.Windows.Forms.Timer TimerUpTime;
    }
}