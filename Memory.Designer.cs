
namespace TaskManger
{
    partial class RAM
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.perfMem = new System.Diagnostics.PerformanceCounter();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.MemChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.perfMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemChart)).BeginInit();
            this.SuspendLayout();
            // 
            // perfMem
            // 
            this.perfMem.CategoryName = "Memory";
            this.perfMem.CounterName = "% Committed Bytes In Use";
            // 
            // tick
            // 
            this.tick.Interval = 1000;
            this.tick.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MemChart
            // 
            this.MemChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(212)))));
            this.MemChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MemChart.BorderlineWidth = 0;
            this.MemChart.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.MemChart.BorderSkin.BorderColor = System.Drawing.Color.Empty;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.MemChart.ChartAreas.Add(chartArea1);
            this.MemChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(174)))), ((int)(((byte)(187)))));
            legend1.BorderWidth = 0;
            legend1.Name = "Legend1";
            this.MemChart.Legends.Add(legend1);
            this.MemChart.Location = new System.Drawing.Point(0, 0);
            this.MemChart.Name = "MemChart";
            this.MemChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            series1.CustomProperties = "EmptyPointValue=Zero, LabelStyle=Center";
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series1.Name = "Memory Usage";
            this.MemChart.Series.Add(series1);
            this.MemChart.Size = new System.Drawing.Size(800, 450);
            this.MemChart.TabIndex = 0;
            this.MemChart.Text = "Memory Usage";
            title1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Memory Usage";
            title1.Text = "Memory Usage";
            this.MemChart.Titles.Add(title1);
            // 
            // RAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MemChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RAM";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.Memory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter perfMem;
        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.DataVisualization.Charting.Chart MemChart;
    }
}