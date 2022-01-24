
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.perfMem = new System.Diagnostics.PerformanceCounter();
            this.RAM_tick = new System.Windows.Forms.Timer(this.components);
            this.MemChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPhysicalRAM = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSSS = new System.Windows.Forms.Label();
            this.lblPresentUsed = new System.Windows.Forms.Label();
            this.lblAvaliableRAM = new System.Windows.Forms.Label();
            this.perfAvailableRAM = new System.Diagnostics.PerformanceCounter();
            this.lblUsedRAM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.perfMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.MemChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(212)))));
            this.MemChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MemChart.BorderlineWidth = 0;
            this.MemChart.BorderSkin.BackColor = System.Drawing.Color.DimGray;
            this.MemChart.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.MemChart.BorderSkin.BorderColor = System.Drawing.Color.Empty;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.MaximumAutoSize = 100F;
            chartArea2.AxisY.LineWidth = 0;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Maximum = 100D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.BorderWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.MemChart.ChartAreas.Add(chartArea2);
            this.MemChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemChart.Location = new System.Drawing.Point(0, 0);
            this.MemChart.Name = "MemChart";
            this.MemChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(193)))), ((int)(((byte)(201)))));
            series2.CustomProperties = "EmptyPointValue=Zero, LabelStyle=Center";
            series2.IsXValueIndexed = true;
            series2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series2.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series2.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            series2.Name = "Memory Usage";
            this.MemChart.Series.Add(series2);
            this.MemChart.Size = new System.Drawing.Size(772, 374);
            this.MemChart.TabIndex = 0;
            this.MemChart.Text = "Memory Usage";
            title2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title2.Name = "Memory Usage";
            title2.Text = "Memory Usage";
            this.MemChart.Titles.Add(title2);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 661);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(772, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 376);
            this.panel3.TabIndex = 4;
            // 
            // lblPhysicalRAM
            // 
            this.lblPhysicalRAM.AutoSize = true;
            this.lblPhysicalRAM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhysicalRAM.Location = new System.Drawing.Point(315, 21);
            this.lblPhysicalRAM.Name = "lblPhysicalRAM";
            this.lblPhysicalRAM.Size = new System.Drawing.Size(110, 19);
            this.lblPhysicalRAM.TabIndex = 4;
            this.lblPhysicalRAM.Text = "PhysicalRAM";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.MemChart);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(774, 376);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblUsedRAM);
            this.panel2.Controls.Add(this.lblPhysicalRAM);
            this.panel2.Controls.Add(this.lblSSS);
            this.panel2.Controls.Add(this.lblPresentUsed);
            this.panel2.Controls.Add(this.lblAvaliableRAM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 376);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 285);
            this.panel2.TabIndex = 3;
            // 
            // lblSSS
            // 
            this.lblSSS.AutoSize = true;
            this.lblSSS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSSS.Location = new System.Drawing.Point(33, 135);
            this.lblSSS.Name = "lblSSS";
            this.lblSSS.Size = new System.Drawing.Size(50, 19);
            this.lblSSS.TabIndex = 5;
            this.lblSSS.Text = "Soon";
            // 
            // lblPresentUsed
            // 
            this.lblPresentUsed.AutoSize = true;
            this.lblPresentUsed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPresentUsed.Location = new System.Drawing.Point(33, 180);
            this.lblPresentUsed.Name = "lblPresentUsed";
            this.lblPresentUsed.Size = new System.Drawing.Size(50, 19);
            this.lblPresentUsed.TabIndex = 3;
            this.lblPresentUsed.Text = "Soon";
            // 
            // lblAvaliableRAM
            // 
            this.lblAvaliableRAM.AutoSize = true;
            this.lblAvaliableRAM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvaliableRAM.Location = new System.Drawing.Point(33, 21);
            this.lblAvaliableRAM.Name = "lblAvaliableRAM";
            this.lblAvaliableRAM.Size = new System.Drawing.Size(113, 19);
            this.lblAvaliableRAM.TabIndex = 2;
            this.lblAvaliableRAM.Text = "AvaliableRAM";
            // 
            // perfAvailableRAM
            // 
            this.perfAvailableRAM.CategoryName = "Memory";
            this.perfAvailableRAM.CounterName = "Available MBytes";
            // 
            // lblUsedRAM
            // 
            this.lblUsedRAM.AutoSize = true;
            this.lblUsedRAM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsedRAM.Location = new System.Drawing.Point(192, 21);
            this.lblUsedRAM.Name = "lblUsedRAM";
            this.lblUsedRAM.Size = new System.Drawing.Size(85, 19);
            this.lblUsedRAM.TabIndex = 6;
            this.lblUsedRAM.Text = "UsedRAM";
            // 
            // RAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RAM";
            this.Text = "Memory";
            this.Load += new System.EventHandler(this.Memory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblAvaliableRAM;
        private System.Windows.Forms.Label lblSSS;
        private System.Windows.Forms.Label lblPhysicalRAM;
        private System.Windows.Forms.Label lblPresentUsed;
        private System.Diagnostics.PerformanceCounter perfAvailableRAM;
        private System.Windows.Forms.Label lblUsedRAM;
    }
}