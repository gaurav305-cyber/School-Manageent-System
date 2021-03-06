 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SMS
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nButtonRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
       
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panel_nav.Height = button_dashboard.Height;
            panel_nav.Top = button_dashboard.Top;
            panel_nav.Left = button_dashboard.Left;
            button_dashboard.BackColor = Color.FromArgb(46, 51, 73);


            labelTitle.Text = "Dashboard";
            this.panelFormLoader.Controls.Clear();
            frmdashboard Frmdashboard_vrb = new frmdashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(Frmdashboard_vrb);
            Frmdashboard_vrb.Show();

        }

        



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // showSubmenu(panel_members);
        }

        private void customDesign()
        {
           panel_members.Visible = false;
           panel_posts.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel_members.Visible == true)
                panel_members.Visible = false;
            if (panel_posts.Visible == true)
                panel_posts.Visible = false;
        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private void button_members_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_members);
            panel_nav.Height = button_members.Height;
            panel_nav.Top = button_members.Top;
            panel_nav.Left = button_members.Left;
            button_members.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button_Students_Click(object sender, EventArgs e)
        {
            //hideSubmenu();
            labelTitle.Text = "Students";
            this.panelFormLoader.Controls.Clear();
            FrmStudent FrmStudent_vrb = new FrmStudent() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmStudent_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FrmStudent_vrb);
            FrmStudent_vrb.Show();
        }

        private void button_teachers_Click(object sender, EventArgs e)
        {
            //hideSubmenu();
            labelTitle.Text = "Teacher Registration Form";
            this.panelFormLoader.Controls.Clear();
            FrmTeacher FrmTeacher_vrb = new FrmTeacher() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmTeacher_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FrmTeacher_vrb);
            FrmTeacher_vrb.Show();
        }

        private void button_posts_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_posts);
            panel_nav.Height = button_posts.Height;
            panel_nav.Top = button_posts.Top;
            panel_nav.Left = button_posts.Left;
            button_posts.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void button_poll_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Student Registration Form";
            this.panelFormLoader.Controls.Clear();
            Rstudent Rstudent_vrb = new Rstudent() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Rstudent_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(Rstudent_vrb);
            Rstudent_vrb.Show();
        }

        private void button_notice_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Student Details";
            this.panelFormLoader.Controls.Clear();
            Vstudents Vstudent_vrb = new Vstudents() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Vstudent_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(Vstudent_vrb);
            Vstudent_vrb.Show();
            // hideSubmenu();
        }

        private void button_Dashboard_Click(object sender, EventArgs e)
        {
            panel_nav.Height = button_dashboard.Height;
            panel_nav.Top = button_dashboard.Top;
            panel_nav.Left = button_dashboard.Left;
            button_dashboard.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Dashboard";
            this.panelFormLoader.Controls.Clear();
            frmdashboard Frmdashboard_vrb = new frmdashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(Frmdashboard_vrb);
            Frmdashboard_vrb.Show();


        }

        private void button_classes__Click(object sender, EventArgs e)
        {
            panel_nav.Height = button_class.Height;
            panel_nav.Top = button_class.Top;
            panel_nav.Left = button_class.Left;
            button_class.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Classes";
            this.panelFormLoader.Controls.Clear();
            FrmClasses FrmClasses_vrb = new FrmClasses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmClasses_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FrmClasses_vrb);
            FrmClasses_vrb.Show();
        }

        private void button_modules_Click(object sender, EventArgs e)
        {
            panel_nav.Height = button_module.Height;
            panel_nav.Top = button_module.Top;
            panel_nav.Left = button_module.Left;
            button_module.BackColor = Color.FromArgb(46, 51, 73);

            labelTitle.Text = "Modules";
            this.panelFormLoader.Controls.Clear();
            FrmModules FrmModules_vrb = new FrmModules() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmModules_vrb.FormBorderStyle = FormBorderStyle.None;
            this.panelFormLoader.Controls.Add(FrmModules_vrb);
            FrmModules_vrb.Show();
        }

        private void button_dashboard_Leave(object sender, EventArgs e)
        {
            button_dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button_class_Leave(object sender, EventArgs e)
        {
            button_class.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button_module_Leave(object sender, EventArgs e)
        {
            button_module.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button_members_Leave(object sender, EventArgs e)
        {
            button_members.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button_posts_Leave(object sender, EventArgs e)
        {
            button_posts.BackColor = Color.FromArgb(24, 30, 54);
            //hideSubmenu();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_poll_Leave(object sender, EventArgs e)
        {
            button_poll.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
       
}
