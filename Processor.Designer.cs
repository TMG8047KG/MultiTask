
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.perfCPU = new System.Diagnostics.PerformanceCounter();
            this.cpuChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).BeginInit();
            this.SuspendLayout();
            // 
            // perfCPU
            // 
            this.perfCPU.CategoryName = "Processor";
            this.perfCPU.CounterName = "% Processor Time";
            this.perfCPU.InstanceName = "_Total";
            // 
            // cpuChart
            // 
            this.cpuChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.cpuChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.MaximumAutoSize = 50F;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BorderWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.cpuChart.ChartAreas.Add(chartArea1);
            this.cpuChart.Location = new System.Drawing.Point(21, 1);
            this.cpuChart.Name = "cpuChart";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            series1.Name = "CPU Usage";
            this.cpuChart.Series.Add(series1);
            this.cpuChart.Size = new System.Drawing.Size(685, 331);
            this.cpuChart.TabIndex = 0;
            this.cpuChart.Text = "CPU Usage";
            title1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "CPU Usage";
            title1.Text = "CPU Usage";
            this.cpuChart.Titles.Add(title1);
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
            // Processor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
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
            this.Controls.Add(this.cpuChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Processor";
            this.Text = "Processor";
            this.Load += new System.EventHandler(this.Processor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter perfCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
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
    }
}