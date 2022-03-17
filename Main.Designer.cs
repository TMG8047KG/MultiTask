
namespace MultiTaskBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiTask));
            this.basePanel = new System.Windows.Forms.Panel();
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnActiveT = new System.Windows.Forms.Button();
            this.btnRunningApps = new System.Windows.Forms.Button();
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnMem = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblGitinfo = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.FnBar = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGit = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.basePanel.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.FnBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // basePanel
            // 
            this.basePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.basePanel.Controls.Add(this.pButtons);
            this.basePanel.Controls.Add(this.panel2);
            this.basePanel.Controls.Add(this.logoPanel);
            this.basePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.basePanel.Location = new System.Drawing.Point(0, 0);
            this.basePanel.Name = "basePanel";
            this.basePanel.Size = new System.Drawing.Size(200, 700);
            this.basePanel.TabIndex = 1;
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.btnActiveT);
            this.pButtons.Controls.Add(this.btnRunningApps);
            this.pButtons.Controls.Add(this.btnCPU);
            this.pButtons.Controls.Add(this.btnMem);
            this.pButtons.Controls.Add(this.btn_Home);
            this.pButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pButtons.Location = new System.Drawing.Point(0, 108);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(200, 532);
            this.pButtons.TabIndex = 3;
            // 
            // btnActiveT
            // 
            this.btnActiveT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnActiveT.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActiveT.FlatAppearance.BorderSize = 0;
            this.btnActiveT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActiveT.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiveT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.btnActiveT.Location = new System.Drawing.Point(0, 240);
            this.btnActiveT.Name = "btnActiveT";
            this.btnActiveT.Size = new System.Drawing.Size(200, 60);
            this.btnActiveT.TabIndex = 1;
            this.btnActiveT.Text = "Active Time";
            this.btnActiveT.UseCompatibleTextRendering = true;
            this.btnActiveT.UseVisualStyleBackColor = false;
            this.btnActiveT.Visible = false;
            this.btnActiveT.Click += new System.EventHandler(this.btnActiveT_Click);
            // 
            // btnRunningApps
            // 
            this.btnRunningApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnRunningApps.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRunningApps.FlatAppearance.BorderSize = 0;
            this.btnRunningApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunningApps.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunningApps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.btnRunningApps.Location = new System.Drawing.Point(0, 180);
            this.btnRunningApps.Name = "btnRunningApps";
            this.btnRunningApps.Size = new System.Drawing.Size(200, 60);
            this.btnRunningApps.TabIndex = 0;
            this.btnRunningApps.Text = "Processes";
            this.btnRunningApps.UseCompatibleTextRendering = true;
            this.btnRunningApps.UseVisualStyleBackColor = false;
            this.btnRunningApps.Click += new System.EventHandler(this.btnRunningApps_Click);
            // 
            // btnCPU
            // 
            this.btnCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnCPU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCPU.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCPU.FlatAppearance.BorderSize = 0;
            this.btnCPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCPU.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.btnCPU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCPU.ImageKey = "(none)";
            this.btnCPU.Location = new System.Drawing.Point(0, 120);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(200, 60);
            this.btnCPU.TabIndex = 3;
            this.btnCPU.Text = "CPU";
            this.btnCPU.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCPU.UseCompatibleTextRendering = true;
            this.btnCPU.UseVisualStyleBackColor = false;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnMem
            // 
            this.btnMem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btnMem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMem.FlatAppearance.BorderSize = 0;
            this.btnMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMem.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.btnMem.Location = new System.Drawing.Point(0, 60);
            this.btnMem.Name = "btnMem";
            this.btnMem.Size = new System.Drawing.Size(200, 60);
            this.btnMem.TabIndex = 2;
            this.btnMem.Text = "Memory";
            this.btnMem.UseCompatibleTextRendering = true;
            this.btnMem.UseVisualStyleBackColor = false;
            this.btnMem.Click += new System.EventHandler(this.btnMem_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(48)))));
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.btn_Home.Location = new System.Drawing.Point(0, 0);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(200, 60);
            this.btn_Home.TabIndex = 4;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseCompatibleTextRendering = true;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblGitinfo);
            this.panel2.Controls.Add(this.btnGit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 60);
            this.panel2.TabIndex = 2;
            // 
            // lblGitinfo
            // 
            this.lblGitinfo.AutoSize = true;
            this.lblGitinfo.Font = new System.Drawing.Font("Cubano", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGitinfo.Location = new System.Drawing.Point(66, 22);
            this.lblGitinfo.Name = "lblGitinfo";
            this.lblGitinfo.Size = new System.Drawing.Size(100, 16);
            this.lblGitinfo.TabIndex = 1;
            this.lblGitinfo.Text = "by TMG8047KG";
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MultiTask";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // FnBar
            // 
            this.FnBar.Controls.Add(this.pictureBox1);
            this.FnBar.Controls.Add(this.btnMinimize);
            this.FnBar.Controls.Add(this.btnExit);
            this.FnBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.FnBar.Location = new System.Drawing.Point(200, 0);
            this.FnBar.Name = "FnBar";
            this.FnBar.Size = new System.Drawing.Size(1000, 40);
            this.FnBar.TabIndex = 3;
            this.FnBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FnBar_MouseDown);
            this.FnBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FnBar_MouseMove);
            this.FnBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FnBar_MouseUp);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(200, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1000, 660);
            this.mainPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FnBar_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FnBar_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FnBar_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.btnMinimize.Location = new System.Drawing.Point(920, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(85)))), ((int)(((byte)(130)))));
            this.btnExit.Location = new System.Drawing.Point(960, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGit
            // 
            this.btnGit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGit.BackgroundImage")));
            this.btnGit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGit.FlatAppearance.BorderSize = 0;
            this.btnGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGit.Location = new System.Drawing.Point(0, 0);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(60, 60);
            this.btnGit.TabIndex = 0;
            this.btnGit.UseVisualStyleBackColor = false;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(200, 108);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FnBar_MouseDown);
            this.logoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FnBar_MouseMove);
            this.logoPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FnBar_MouseUp);
            // 
            // MultiTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.FnBar);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.basePanel);
            this.Font = new System.Drawing.Font("Cubano", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiTask";
            this.Load += new System.EventHandler(this.MultiTask_Load);
            this.basePanel.ResumeLayout(false);
            this.pButtons.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.FnBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel basePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRunningApps;
        private System.Windows.Forms.Button btnActiveT;
        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnMem;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.Label lblGitinfo;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel FnBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Home;
    }
}

