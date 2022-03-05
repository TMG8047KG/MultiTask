
namespace MultiTaskBase.Forms
{
    partial class home_page
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
            this.lblPCname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSysType = new System.Windows.Forms.Label();
            this.lblPCID = new System.Windows.Forms.Label();
            this.lblversion = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPCname
            // 
            this.lblPCname.AutoSize = true;
            this.lblPCname.Location = new System.Drawing.Point(16, 14);
            this.lblPCname.Name = "lblPCname";
            this.lblPCname.Size = new System.Drawing.Size(180, 25);
            this.lblPCname.TabIndex = 0;
            this.lblPCname.Text = "Device name: TMPC";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSysType);
            this.panel1.Controls.Add(this.lblPCID);
            this.panel1.Controls.Add(this.lblPCname);
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 636);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "OS build: 22000.527";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Windows version: 21H2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Windows Editon: Windows 11 Pro";
            // 
            // lblSysType
            // 
            this.lblSysType.AutoSize = true;
            this.lblSysType.Location = new System.Drawing.Point(16, 84);
            this.lblSysType.Name = "lblSysType";
            this.lblSysType.Size = new System.Drawing.Size(518, 25);
            this.lblSysType.TabIndex = 2;
            this.lblSysType.Text = "System type: 64-bit operating system, x64-based processor";
            // 
            // lblPCID
            // 
            this.lblPCID.AutoSize = true;
            this.lblPCID.Location = new System.Drawing.Point(16, 49);
            this.lblPCID.Name = "lblPCID";
            this.lblPCID.Size = new System.Drawing.Size(466, 25);
            this.lblPCID.TabIndex = 1;
            this.lblPCID.Text = "Device ID: 0258A10E-33CE-4D0D-9A59-623ABC03B190";
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.ForeColor = System.Drawing.Color.Gray;
            this.lblversion.Location = new System.Drawing.Point(920, 631);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(68, 20);
            this.lblversion.TabIndex = 6;
            this.lblversion.Text = "1.0.0 beta";
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "home_page";
            this.Text = "home_page";
            this.Load += new System.EventHandler(this.home_page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPCname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSysType;
        private System.Windows.Forms.Label lblPCID;
    }
}