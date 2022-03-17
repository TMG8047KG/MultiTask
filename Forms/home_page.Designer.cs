
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_page));
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOSbuild = new System.Windows.Forms.Label();
            this.lblWedition = new System.Windows.Forms.Label();
            this.lblSystemType = new System.Windows.Forms.Label();
            this.lblversion = new System.Windows.Forms.Label();
            this.TimerClock = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("Cubano", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceName.Location = new System.Drawing.Point(18, 23);
            this.lblDeviceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(136, 23);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "Device name: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.lblSerialNumber);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblOSbuild);
            this.panel1.Controls.Add(this.lblWedition);
            this.panel1.Controls.Add(this.lblSystemType);
            this.panel1.Controls.Add(this.lblDeviceName);
            this.panel1.Font = new System.Drawing.Font("Cubano", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 636);
            this.panel1.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Cubano", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(6, 607);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(94, 23);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "hh:mm:ss";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Font = new System.Drawing.Font("Cubano", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumber.Location = new System.Drawing.Point(18, 59);
            this.lblSerialNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(151, 23);
            this.lblSerialNumber.TabIndex = 9;
            this.lblSerialNumber.Text = "Serial Number:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.panel4.Location = new System.Drawing.Point(10, 232);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 5);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.panel2.Location = new System.Drawing.Point(10, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 3);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Doppio One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            this.button1.Location = new System.Drawing.Point(576, 601);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Device Manager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOSbuild
            // 
            this.lblOSbuild.AutoSize = true;
            this.lblOSbuild.Font = new System.Drawing.Font("Cubano", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSbuild.Location = new System.Drawing.Point(18, 196);
            this.lblOSbuild.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOSbuild.Name = "lblOSbuild";
            this.lblOSbuild.Size = new System.Drawing.Size(97, 23);
            this.lblOSbuild.TabIndex = 5;
            this.lblOSbuild.Text = "OS build: ";
            // 
            // lblWedition
            // 
            this.lblWedition.AutoSize = true;
            this.lblWedition.Font = new System.Drawing.Font("Cubano", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWedition.Location = new System.Drawing.Point(18, 160);
            this.lblWedition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWedition.Name = "lblWedition";
            this.lblWedition.Size = new System.Drawing.Size(168, 23);
            this.lblWedition.TabIndex = 3;
            this.lblWedition.Text = "Windows Editon: ";
            // 
            // lblSystemType
            // 
            this.lblSystemType.AutoSize = true;
            this.lblSystemType.Font = new System.Drawing.Font("Cubano", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemType.Location = new System.Drawing.Point(18, 95);
            this.lblSystemType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemType.Name = "lblSystemType";
            this.lblSystemType.Size = new System.Drawing.Size(141, 23);
            this.lblSystemType.TabIndex = 2;
            this.lblSystemType.Text = "System type: ";
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.ForeColor = System.Drawing.Color.Gray;
            this.lblversion.Location = new System.Drawing.Point(885, 632);
            this.lblversion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(102, 19);
            this.lblversion.TabIndex = 6;
            this.lblversion.Text = "v1.0.0 alpha";
            // 
            // TimerClock
            // 
            this.TimerClock.Enabled = true;
            this.TimerClock.Interval = 1;
            this.TimerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(741, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 247);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblversion);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cubano", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "home_page";
            this.Text = "home_page";
            this.Load += new System.EventHandler(this.home_page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label lblOSbuild;
        private System.Windows.Forms.Label lblWedition;
        private System.Windows.Forms.Label lblSystemType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer TimerClock;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}