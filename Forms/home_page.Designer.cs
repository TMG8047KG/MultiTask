
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
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOSbuild = new System.Windows.Forms.Label();
            this.lblWversion = new System.Windows.Forms.Label();
            this.lblWedition = new System.Windows.Forms.Label();
            this.lblSystemType = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblversion = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(18, 13);
            this.lblDeviceName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(150, 25);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "Device name: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblOSbuild);
            this.panel1.Controls.Add(this.lblWversion);
            this.panel1.Controls.Add(this.lblWedition);
            this.panel1.Controls.Add(this.lblSystemType);
            this.panel1.Controls.Add(this.lblProductID);
            this.panel1.Controls.Add(this.lblDeviceName);
            this.panel1.Font = new System.Drawing.Font("Cubano", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(14, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 637);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.panel4.Location = new System.Drawing.Point(10, 275);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(700, 5);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(100)))), ((int)(((byte)(143)))));
            this.panel2.Location = new System.Drawing.Point(10, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 3);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            this.button1.Location = new System.Drawing.Point(590, 600);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Device Manager";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOSbuild
            // 
            this.lblOSbuild.AutoSize = true;
            this.lblOSbuild.Location = new System.Drawing.Point(18, 232);
            this.lblOSbuild.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOSbuild.Name = "lblOSbuild";
            this.lblOSbuild.Size = new System.Drawing.Size(107, 25);
            this.lblOSbuild.TabIndex = 5;
            this.lblOSbuild.Text = "OS build: ";
            // 
            // lblWversion
            // 
            this.lblWversion.AutoSize = true;
            this.lblWversion.Location = new System.Drawing.Point(18, 198);
            this.lblWversion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWversion.Name = "lblWversion";
            this.lblWversion.Size = new System.Drawing.Size(198, 25);
            this.lblWversion.TabIndex = 4;
            this.lblWversion.Text = "Windows version: ";
            // 
            // lblWedition
            // 
            this.lblWedition.AutoSize = true;
            this.lblWedition.Location = new System.Drawing.Point(18, 164);
            this.lblWedition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWedition.Name = "lblWedition";
            this.lblWedition.Size = new System.Drawing.Size(186, 25);
            this.lblWedition.TabIndex = 3;
            this.lblWedition.Text = "Windows Editon: ";
            // 
            // lblSystemType
            // 
            this.lblSystemType.AutoSize = true;
            this.lblSystemType.Location = new System.Drawing.Point(18, 80);
            this.lblSystemType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSystemType.Name = "lblSystemType";
            this.lblSystemType.Size = new System.Drawing.Size(157, 25);
            this.lblSystemType.TabIndex = 2;
            this.lblSystemType.Text = "System type: ";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(18, 47);
            this.lblProductID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(126, 25);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID:";
            // 
            // lblversion
            // 
            this.lblversion.AutoSize = true;
            this.lblversion.ForeColor = System.Drawing.Color.Gray;
            this.lblversion.Location = new System.Drawing.Point(903, 632);
            this.lblversion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblversion.Name = "lblversion";
            this.lblversion.Size = new System.Drawing.Size(84, 19);
            this.lblversion.TabIndex = 6;
            this.lblversion.Text = "1.0.0 beta";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::MultiTaskBase.Properties.Resources._264833419_4639386566115027_6923715813496419059_n;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(741, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 247);
            this.panel3.TabIndex = 7;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblversion;
        private System.Windows.Forms.Label lblOSbuild;
        private System.Windows.Forms.Label lblWversion;
        private System.Windows.Forms.Label lblWedition;
        private System.Windows.Forms.Label lblSystemType;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}