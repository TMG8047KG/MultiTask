using MultiTaskBase.Forms;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace MultiTaskBase
{
    public partial class MultiTask : Form
    {
        public MultiTask()
        {
            DataSaver ds = new DataSaver();
            ds.WriteJson();
            InitializeComponent();
        }

        public ContextMenu IcoMenu = new ContextMenu();
        private bool dragging;
        private Point st_point = new Point(0, 0);

        private void MultiTask_Load(object sender, EventArgs e)
        {
            load_Form(new home_page());
            IconMenu();
            notifyIcon.Visible = true;
        }

        public void IconMenu()
        {
            IcoMenu.MenuItems.Add("Open Application", (s, e) => Ico_openApp());
            IcoMenu.MenuItems.Add("Exit", (s, e) => Application.Exit());
            notifyIcon.ContextMenu = IcoMenu;
        }

        public void Ico_openApp()
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        public void load_Form(object Form)
        {   
            Form fm = Form as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            if(this.mainPanel.Controls.Count > 0)
            {
                this.mainPanel.Controls.RemoveAt(0);
            }
            this.mainPanel.Controls.Add(fm);
            this.mainPanel.Tag = fm;
            fm.Show();
        }

        private void btnRunningApps_Click(object sender, EventArgs e)
        {
            load_Form(new Running_Apps());
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            load_Form(new Processor());
        }

        private void btnMem_Click(object sender, EventArgs e)
        {
            load_Form(new RAM());
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TMG8047KG/MultiTask");
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;

            WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FnBar_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            st_point = new Point(e.X, e.Y);
        }

        private void FnBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point point = PointToScreen(e.Location);
                Location = new Point(point.X - this.st_point.X, point.Y - this.st_point.Y);
            }
        }

        private void FnBar_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnActiveT_Click(object sender, EventArgs e)
        {
            load_Form(new Application_Usage_Time());
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            load_Form(new home_page());
        }
    }
}
