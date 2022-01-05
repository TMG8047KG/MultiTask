
namespace TaskManger
{
    partial class MultiTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiTask));
            this.basePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnMem = new System.Windows.Forms.Button();
            this.btnActiveT = new System.Windows.Forms.Button();
            this.btnRunningApps = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnGit = new System.Windows.Forms.Button();
            this.lblGitinfo = new System.Windows.Forms.Label();
            this.basePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.basePanel.Controls.Add(this.panel2);
            this.basePanel.Controls.Add(this.panel1);
            this.basePanel.Controls.Add(this.logoPanel);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(211, 661);
            this.basePanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblGitinfo);
            this.panel2.Controls.Add(this.btnGit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 601);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(211, 60);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCPU);
            this.panel1.Controls.Add(this.btnMem);
            this.panel1.Controls.Add(this.btnActiveT);
            this.panel1.Controls.Add(this.btnRunningApps);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 210);
            this.panel1.TabIndex = 1;
            // 
            // btnCPU
            // 
            this.btnCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(80)))));
            this.btnCPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCPU.FlatAppearance.BorderSize = 0;
            this.btnCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPU.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            this.btnCPU.Location = new System.Drawing.Point(0, 156);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(211, 52);
            this.btnCPU.TabIndex = 3;
            this.btnCPU.Text = "CPU Usage";
            this.btnCPU.UseVisualStyleBackColor = false;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnMem
            // 
            this.btnMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(80)))));
            this.btnMem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMem.FlatAppearance.BorderSize = 0;
            this.btnMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            this.btnMem.Location = new System.Drawing.Point(0, 104);
            this.btnMem.Name = "btnMem";
            this.btnMem.Size = new System.Drawing.Size(211, 52);
            this.btnMem.TabIndex = 2;
            this.btnMem.Text = "Memory Usage";
            this.btnMem.UseVisualStyleBackColor = false;
            this.btnMem.Click += new System.EventHandler(this.btnMem_Click);
            // 
            // btnActiveT
            // 
            this.btnActiveT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(80)))));
            this.btnActiveT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActiveT.FlatAppearance.BorderSize = 0;
            this.btnActiveT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveT.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnActiveT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            this.btnActiveT.Location = new System.Drawing.Point(0, 52);
            this.btnActiveT.Name = "btnActiveT";
            this.btnActiveT.Size = new System.Drawing.Size(211, 52);
            this.btnActiveT.TabIndex = 1;
            this.btnActiveT.Text = "Active Time";
            this.btnActiveT.UseVisualStyleBackColor = false;
            this.btnActiveT.Visible = false;
            // 
            // btnRunningApps
            // 
            this.btnRunningApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(69)))), ((int)(((byte)(80)))));
            this.btnRunningApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRunningApps.FlatAppearance.BorderSize = 0;
            this.btnRunningApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunningApps.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunningApps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(162)))), ((int)(((byte)(173)))));
            this.btnRunningApps.Location = new System.Drawing.Point(0, 0);
            this.btnRunningApps.Name = "btnRunningApps";
            this.btnRunningApps.Size = new System.Drawing.Size(211, 52);
            this.btnRunningApps.TabIndex = 0;
            this.btnRunningApps.Text = "Running Apps";
            this.btnRunningApps.UseVisualStyleBackColor = false;
            this.btnRunningApps.Click += new System.EventHandler(this.btnRunningApps_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(111)))), ((int)(((byte)(124)))));
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(211, 108);
            this.logoPanel.TabIndex = 0;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(211, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(973, 661);
            this.mainPanel.TabIndex = 2;
            // 
            // btnGit
            // 
            this.btnGit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGit.FlatAppearance.BorderSize = 0;
            this.btnGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGit.Image = ((System.Drawing.Image)(resources.GetObject("btnGit.Image")));
            this.btnGit.Location = new System.Drawing.Point(0, 0);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(60, 60);
            this.btnGit.TabIndex = 0;
            this.btnGit.UseVisualStyleBackColor = false;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // lblGitinfo
            // 
            this.lblGitinfo.AutoSize = true;
            this.lblGitinfo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGitinfo.Location = new System.Drawing.Point(66, 22);
            this.lblGitinfo.Name = "lblGitinfo";
            this.lblGitinfo.Size = new System.Drawing.Size(103, 16);
            this.lblGitinfo.TabIndex = 1;
            this.lblGitinfo.Text = "by TMG8047KG";
            // 
            // MultiTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.basePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MultiTask";
            this.Text = "MultiTask";
            this.Load += new System.EventHandler(this.MultiTask_Load);
            this.basePanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRunningApps;
        private System.Windows.Forms.Button btnActiveT;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnMem;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.Label lblGitinfo;
    }
}

