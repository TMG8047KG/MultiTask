
namespace MultiTaskBase
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.perfMem = new System.Diagnostics.PerformanceCounter();
            this.RAM_tick = new System.Windows.Forms.Timer(this.components);
            this.MemChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAvaliableRAM = new System.Windows.Forms.Label();
            this.lblUsedRAM = new System.Windows.Forms.Label();
            this.lblPhysicalRAM = new System.Windows.Forms.Label();
            this.lblSSS = new System.Windows.Forms.Label();
            this.lblPresentUsed = new System.Windows.Forms.Label();
            this.perfAvailableRAM = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.perfMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfAvailableRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // perfMem
            // 
            this.perfMem.CategoryName = "Memory";
            this.perfMem.CounterName = "% Committed Bytes In Use";
            // 
            // RAM_tick
            // 
            this.RAM_tick.Interval = 1000;
            this.RAM_tick.Tick += new System.EventHandler(this.RAM_tick_Tick);
            // 
            // MemChart
            // 
            this.MemChart.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Graphics;
            this.MemChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.MemChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MemChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.MemChart.BorderlineWidth = 0;
            this.MemChart.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.MemChart.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.MemChart.BorderSkin.BorderColor = System.Drawing.Color.Empty;
            this.MemChart.BorderSkin.BorderWidth = 0;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MaximumAutoSize = 100F;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            chartArea1.BorderWidth = 0;
            chartArea1.Name = "ChartArea1";
            this.MemChart.ChartAreas.Add(chartArea1);
            this.MemChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemChart.IsSoftShadows = false;
            this.MemChart.Location = new System.Drawing.Point(0, 0);
            this.MemChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MemChart.Name = "MemChart";
            this.MemChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(38)))), ((int)(((byte)(115)))));
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(49)))), ((int)(((byte)(155)))));
            series1.CustomProperties = "EmptyPointValue=Zero, LabelStyle=Center";
            series1.IsXValueIndexed = true;
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(38)))), ((int)(((byte)(189)))));
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Memory Usage";
            this.MemChart.Series.Add(series1);
            this.MemChart.Size = new System.Drawing.Size(1000, 293);
            this.MemChart.TabIndex = 0;
            this.MemChart.Text = "Memory Usage";
            this.MemChart.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title1.BorderWidth = 0;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Memory";
            this.MemChart.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MemChart);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 660);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lblAvaliableRAM);
            this.panel2.Controls.Add(this.lblUsedRAM);
            this.panel2.Controls.Add(this.lblPhysicalRAM);
            this.panel2.Controls.Add(this.lblSSS);
            this.panel2.Controls.Add(this.lblPresentUsed);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 336);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 324);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(38)))), ((int)(((byte)(115)))));
            this.panel5.Location = new System.Drawing.Point(20, 34);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 55);
            this.panel5.TabIndex = 7;
            // 
            // lblAvaliableRAM
            // 
            this.lblAvaliableRAM.AutoSize = true;
            this.lblAvaliableRAM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvaliableRAM.Location = new System.Drawing.Point(470, 26);
            this.lblAvaliableRAM.Name = "lblAvaliableRAM";
            this.lblAvaliableRAM.Size = new System.Drawing.Size(113, 19);
            this.lblAvaliableRAM.TabIndex = 2;
            this.lblAvaliableRAM.Text = "AvaliableRAM";
            // 
            // lblUsedRAM
            // 
            this.lblUsedRAM.AutoSize = true;
            this.lblUsedRAM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsedRAM.Location = new System.Drawing.Point(51, 26);
            this.lblUsedRAM.Name = "lblUsedRAM";
            this.lblUsedRAM.Size = new System.Drawing.Size(85, 19);
            this.lblUsedRAM.TabIndex = 6;
            this.lblUsedRAM.Text = "UsedRAM";
            // 
            // lblPhysicalRAM
            // 
            this.lblPhysicalRAM.AutoSize = true;
            this.lblPhysicalRAM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhysicalRAM.Location = new System.Drawing.Point(274, 26);
            this.lblPhysicalRAM.Name = "lblPhysicalRAM";
            this.lblPhysicalRAM.Size = new System.Drawing.Size(110, 19);
            this.lblPhysicalRAM.TabIndex = 4;
            this.lblPhysicalRAM.Text = "PhysicalRAM";
            // 
            // lblSSS
            // 
            this.lblSSS.AutoSize = true;
            this.lblSSS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSSS.Location = new System.Drawing.Point(38, 166);
            this.lblSSS.Name = "lblSSS";
            this.lblSSS.Size = new System.Drawing.Size(50, 19);
            this.lblSSS.TabIndex = 5;
            this.lblSSS.Text = "Soon";
            // 
            // lblPresentUsed
            // 
            this.lblPresentUsed.AutoSize = true;
            this.lblPresentUsed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPresentUsed.Location = new System.Drawing.Point(38, 222);
            this.lblPresentUsed.Name = "lblPresentUsed";
            this.lblPresentUsed.Size = new System.Drawing.Size(50, 19);
            this.lblPresentUsed.TabIndex = 3;
            this.lblPresentUsed.Text = "Soon";
            // 
            // perfAvailableRAM
            // 
            this.perfAvailableRAM.CategoryName = "Memory";
            this.perfAvailableRAM.CounterName = "Available MBytes";
            // 
            // RAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RAM";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.Memory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.perfAvailableRAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter perfMem;
        private System.Windows.Forms.Timer RAM_tick;
        private System.Windows.Forms.DataVisualization.Charting.Chart MemChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAvaliableRAM;
        private System.Windows.Forms.Label lblSSS;
        private System.Windows.Forms.Label lblPhysicalRAM;
        private System.Windows.Forms.Label lblPresentUsed;
        private System.Diagnostics.PerformanceCounter perfAvailableRAM;
        private System.Windows.Forms.Label lblUsedRAM;
        private System.Windows.Forms.Panel panel5;
    }
}