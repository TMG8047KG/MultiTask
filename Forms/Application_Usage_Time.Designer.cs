
namespace MultiTaskBase.Forms
{
    partial class Application_Usage_Time
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timeGrid = new System.Windows.Forms.DataGridView();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.dataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_useTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_runningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.timeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // timeGrid
            // 
            this.timeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.timeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.timeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.timeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataName,
            this.useTime,
            this.runningTime,
            this.total_useTime,
            this.total_runningTime});
            this.timeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeGrid.EnableHeadersVisualStyles = false;
            this.timeGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.timeGrid.Location = new System.Drawing.Point(0, 0);
            this.timeGrid.Name = "timeGrid";
            this.timeGrid.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.timeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.timeGrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.timeGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.timeGrid.Size = new System.Drawing.Size(1000, 660);
            this.timeGrid.TabIndex = 0;
            // 
            // tick
            // 
            this.tick.Enabled = true;
            this.tick.Interval = 1000;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // dataName
            // 
            this.dataName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataName.HeaderText = "Name";
            this.dataName.Name = "dataName";
            this.dataName.ReadOnly = true;
            // 
            // useTime
            // 
            this.useTime.HeaderText = "Use Time";
            this.useTime.Name = "useTime";
            this.useTime.ReadOnly = true;
            // 
            // runningTime
            // 
            this.runningTime.HeaderText = "Running Time";
            this.runningTime.Name = "runningTime";
            this.runningTime.ReadOnly = true;
            // 
            // total_useTime
            // 
            this.total_useTime.HeaderText = "Total Use Time";
            this.total_useTime.Name = "total_useTime";
            this.total_useTime.ReadOnly = true;
            // 
            // total_runningTime
            // 
            this.total_runningTime.HeaderText = "Total Running Time";
            this.total_runningTime.Name = "total_runningTime";
            this.total_runningTime.ReadOnly = true;
            // 
            // Application_Usage_Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.timeGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Application_Usage_Time";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UsageTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView timeGrid;
        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataName;
        private System.Windows.Forms.DataGridViewTextBoxColumn useTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn runningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_useTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_runningTime;
    }
}