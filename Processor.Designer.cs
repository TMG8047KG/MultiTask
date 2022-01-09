
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
            this.cpuChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(212)))));
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
            this.cpuChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpuChart.Location = new System.Drawing.Point(0, 0);
            this.cpuChart.Name = "cpuChart";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            series1.Name = "CPU Usage";
            this.cpuChart.Series.Add(series1);
            this.cpuChart.Size = new System.Drawing.Size(984, 331);
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
            // Processor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.cpuChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Processor";
            this.Text = "Processor";
            this.Load += new System.EventHandler(this.Processor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter perfCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart cpuChart;
        private System.Windows.Forms.Timer CPU_tick;
    }
}