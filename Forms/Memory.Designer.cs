
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
            this.RAM_tick = new System.Windows.Forms.Timer(this.components);
            this.MemChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblFormFactor = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblPhysicalRAM = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUsedRAM = new System.Windows.Forms.Label();
            this.lblAvaliableRAM = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MemChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RAM_tick
            // 
            this.RAM_tick.Interval = 1000;
            this.RAM_tick.Tick += new System.EventHandler(this.RAM_tick_Tick);
            // 
            // MemChart
            // 
            this.MemChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.MemChart.BorderlineWidth = 0;
            this.MemChart.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.MemChart.BorderSkin.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.MemChart.BorderSkin.BorderColor = System.Drawing.Color.Empty;
            this.MemChart.BorderSkin.BorderWidth = 0;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.ScaleBreakStyle.StartFromZero = System.Windows.Forms.DataVisualization.Charting.StartFromZero.Yes;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            chartArea1.Name = "ChartArea1";
            this.MemChart.ChartAreas.Add(chartArea1);
            this.MemChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemChart.Location = new System.Drawing.Point(0, 0);
            this.MemChart.Name = "MemChart";
            this.MemChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(38)))), ((int)(((byte)(115)))));
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(49)))), ((int)(((byte)(155)))));
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(13)))), ((int)(((byte)(38)))));
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(26)))), ((int)(((byte)(76)))));
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "memory";
            series1.ToolTip = "#VAL{In use}";
            this.MemChart.Series.Add(series1);
            this.MemChart.Size = new System.Drawing.Size(1000, 330);
            this.MemChart.TabIndex = 0;
            this.MemChart.Text = "Memory Usage";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.IsDockedInsideChartArea = false;
            title1.Name = "Total_memory";
            this.MemChart.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MemChart);
            this.panel1.Controls.Add(this.lblPhysicalRAM);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 660);
            this.panel1.TabIndex = 2;
            // 
            // lblPhysicalRAM
            // 
            this.lblPhysicalRAM.AutoSize = true;
            this.lblPhysicalRAM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhysicalRAM.Location = new System.Drawing.Point(704, 275);
            this.lblPhysicalRAM.Name = "lblPhysicalRAM";
            this.lblPhysicalRAM.Size = new System.Drawing.Size(110, 19);
            this.lblPhysicalRAM.TabIndex = 4;
            this.lblPhysicalRAM.Text = "PhysicalRAM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 330);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 330);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblFormFactor);
            this.panel4.Controls.Add(this.lblSpeed);
            this.panel4.Location = new System.Drawing.Point(295, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(236, 295);
            this.panel4.TabIndex = 11;
            // 
            // lblFormFactor
            // 
            this.lblFormFactor.AutoSize = true;
            this.lblFormFactor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFormFactor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFormFactor.Location = new System.Drawing.Point(0, 19);
            this.lblFormFactor.Name = "lblFormFactor";
            this.lblFormFactor.Size = new System.Drawing.Size(102, 19);
            this.lblFormFactor.TabIndex = 9;
            this.lblFormFactor.Text = "Form Factor";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSpeed.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpeed.Location = new System.Drawing.Point(0, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(58, 19);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "Speed";
            // 
            // lblPhysicalRAM
            // 
            this.lblPhysicalRAM.AutoSize = true;
            this.lblPhysicalRAM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhysicalRAM.Location = new System.Drawing.Point(767, 79);
            this.lblPhysicalRAM.Name = "lblPhysicalRAM";
            this.lblPhysicalRAM.Size = new System.Drawing.Size(110, 19);
            this.lblPhysicalRAM.TabIndex = 4;
            this.lblPhysicalRAM.Text = "PhysicalRAM";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblUsedRAM);
            this.panel3.Controls.Add(this.lblAvaliableRAM);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(12, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(277, 50);
            this.panel3.TabIndex = 8;
            // 
            // lblUsedRAM
            // 
            this.lblUsedRAM.AutoSize = true;
            this.lblUsedRAM.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUsedRAM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUsedRAM.Location = new System.Drawing.Point(5, 0);
            this.lblUsedRAM.Name = "lblUsedRAM";
            this.lblUsedRAM.Size = new System.Drawing.Size(114, 19);
            this.lblUsedRAM.TabIndex = 1;
            this.lblUsedRAM.Text = "Used Memory\r\n";
            // 
            // lblAvaliableRAM
            // 
            this.lblAvaliableRAM.AutoSize = true;
            this.lblAvaliableRAM.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAvaliableRAM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvaliableRAM.Location = new System.Drawing.Point(135, 0);
            this.lblAvaliableRAM.Name = "lblAvaliableRAM";
            this.lblAvaliableRAM.Size = new System.Drawing.Size(142, 19);
            this.lblAvaliableRAM.TabIndex = 2;
            this.lblAvaliableRAM.Text = "Avaliable Memory\r\n";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(49)))), ((int)(((byte)(155)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 50);
            this.panel5.TabIndex = 7;
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
            ((System.ComponentModel.ISupportInitialize)(this.MemChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer RAM_tick;
        private System.Windows.Forms.DataVisualization.Charting.Chart MemChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAvaliableRAM;
        private System.Windows.Forms.Label lblUsedRAM;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblFormFactor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPhysicalRAM;
        private System.Windows.Forms.Panel panel2;
    }
}