﻿
namespace MultiTaskBase
{
    partial class Running_Apps
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnStopProc = new System.Windows.Forms.Button();
            this.procName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(219)))), ((int)(((byte)(217)))));
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.procName,
            this.PID});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(219)))), ((int)(((byte)(217)))));
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.MaximumSize = new System.Drawing.Size(984, 661);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(219)))), ((int)(((byte)(217)))));
            this.dataGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(189)))), ((int)(((byte)(186)))));
            this.dataGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGrid.Size = new System.Drawing.Size(984, 661);
            this.dataGrid.TabIndex = 0;
            // 
            // btnStopProc
            // 
            this.btnStopProc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(80)))));
            this.btnStopProc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStopProc.FlatAppearance.BorderSize = 0;
            this.btnStopProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopProc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopProc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            this.btnStopProc.Location = new System.Drawing.Point(0, 615);
            this.btnStopProc.Name = "btnStopProc";
            this.btnStopProc.Size = new System.Drawing.Size(984, 46);
            this.btnStopProc.TabIndex = 1;
            this.btnStopProc.Text = "Stop Process";
            this.btnStopProc.UseVisualStyleBackColor = false;
            this.btnStopProc.Click += new System.EventHandler(this.btnStopProc_Click);
            // 
            // procName
            // 
            this.procName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.procName.FillWeight = 1000F;
            this.procName.HeaderText = "Process Name";
            this.procName.Name = "procName";
            this.procName.ReadOnly = true;
            this.procName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.procName.Width = 842;
            // 
            // PID
            // 
            this.PID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PID.FillWeight = 1000F;
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Width = 142;
            // 
            // Running_Apps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnStopProc);
            this.Controls.Add(this.dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Running_Apps";
            this.Text = "Running_Apps";
            this.Load += new System.EventHandler(this.Running_Apps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnStopProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn procName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
    }
}