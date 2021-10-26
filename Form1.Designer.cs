
namespace SMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.panel_posts = new System.Windows.Forms.Panel();
            this.button_notice = new System.Windows.Forms.Button();
            this.button_poll = new System.Windows.Forms.Button();
            this.button_posts = new System.Windows.Forms.Button();
            this.panel_members = new System.Windows.Forms.Panel();
            this.button_students = new System.Windows.Forms.Button();
            this.button_teachers = new System.Windows.Forms.Button();
            this.button_members = new System.Windows.Forms.Button();
            this.button_module = new System.Windows.Forms.Button();
            this.button_class = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_posts.SuspendLayout();
            this.panel_members.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel_nav);
            this.panel1.Controls.Add(this.panel_posts);
            this.panel1.Controls.Add(this.button_posts);
            this.panel1.Controls.Add(this.panel_members);
            this.panel1.Controls.Add(this.button_members);
            this.panel1.Controls.Add(this.button_module);
            this.panel1.Controls.Add(this.button_class);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button_dashboard);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 807);
            this.panel1.TabIndex = 0;
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel_nav.Location = new System.Drawing.Point(0, 193);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(3, 45);
            this.panel_nav.TabIndex = 3;
            // 
            // panel_posts
            // 
            this.panel_posts.Controls.Add(this.button_notice);
            this.panel_posts.Controls.Add(this.button_poll);
            this.panel_posts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_posts.Location = new System.Drawing.Point(0, 513);
            this.panel_posts.Name = "panel_posts";
            this.panel_posts.Size = new System.Drawing.Size(200, 294);
            this.panel_posts.TabIndex = 3;
            this.panel_posts.Visible = false;
            // 
            // button_notice
            // 
            this.button_notice.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_notice.FlatAppearance.BorderSize = 0;
            this.button_notice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_notice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_notice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button_notice.Location = new System.Drawing.Point(0, 45);
            this.button_notice.Name = "button_notice";
            this.button_notice.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_notice.Size = new System.Drawing.Size(200, 45);
            this.button_notice.TabIndex = 1;
            this.button_notice.Text = "View Details";
            this.button_notice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_notice.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_notice.UseVisualStyleBackColor = true;
            this.button_notice.Click += new System.EventHandler(this.button_notice_Click);
            // 
            // button_poll
            // 
            this.button_poll.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_poll.FlatAppearance.BorderSize = 0;
            this.button_poll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_poll.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_poll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button_poll.Location = new System.Drawing.Point(0, 0);
            this.button_poll.Name = "button_poll";
            this.button_poll.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_poll.Size = new System.Drawing.Size(200, 45);
            this.button_poll.TabIndex = 1;
            this.button_poll.Text = "Register";
            this.button_poll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_poll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_poll.UseVisualStyleBackColor = true;
            this.button_poll.Click += new System.EventHandler(this.button_poll_Click);
            this.button_poll.Leave += new System.EventHandler(this.button_poll_Leave);
            // 
            // button_posts
            // 
            this.button_posts.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_posts.FlatAppearance.BorderSize = 0;
            this.button_posts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_posts.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_posts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button_posts.Location = new System.Drawing.Point(0, 468);
            this.button_posts.Name = "button_posts";
            this.button_posts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_posts.Size = new System.Drawing.Size(200, 45);
            this.button_posts.TabIndex = 1;
            this.button_posts.Text = "Students";
            this.button_posts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_posts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_posts.UseVisualStyleBackColor = true;
            this.button_posts.Click += new System.EventHandler(this.button_posts_Click);
            this.button_posts.Leave += new System.EventHandler(this.button_posts_Leave);
            // 
            // panel_members
            // 
            this.panel_members.Controls.Add(this.button_students);
            this.panel_members.Controls.Add(this.button_teachers);
            this.panel_members.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_members.Location = new System.Drawing.Point(0, 380);
            this.panel_members.Name = "panel_members";
            this.panel_members.Size = new System.Drawing.Size(200, 88);
            this.panel_members.TabIndex = 2;
            this.panel_members.Visible = false;
            // 
            // button_students
            // 
            this.button_students.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_students.FlatAppearance.BorderSize = 0;
            this.button_students.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_students.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_students.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button_students.Location = new System.Drawing.Point(0, 45);
            this.button_students.Name = "button_students";
            this.button_students.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_students.Size = new System.Drawing.Size(200, 45);
            this.button_students.TabIndex = 1;
            this.button_students.Text = "View Details";
            this.button_students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_students.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_students.UseVisualStyleBackColor = true;
            this.button_students.Click += new System.EventHandler(this.button_Students_Click);
            // 
            // button_teachers
            // 
            this.button_teachers.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_teachers.FlatAppearance.BorderSize = 0;
            this.button_teachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_teachers.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_teachers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button_teachers.Location = new System.Drawing.Point(0, 0);
            this.button_teachers.Name = "button_teachers";
            this.button_teachers.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button_teachers.Size = new System.Drawing.Size(200, 45);
            this.button_teachers.TabIndex = 1;
            this.button_teachers.Text = "Register";
            this.button_teachers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_teachers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_teachers.UseVisualStyleBackColor = true;
            this.button_teachers.Click += new System.EventHandler(this.button_teachers_Click);
            // 
            // button_members
            // 
            this.button_members.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_members.FlatAppearance.BorderSize = 0;
            this.button_members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_members.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_members.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button_members.Location = new System.Drawing.Point(0, 335);
            this.button_members.Name = "button_members";
            this.button_members.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_members.Size = new System.Drawing.Size(200, 45);
            this.button_members.TabIndex = 1;
            this.button_members.Tag = "button_members";
            this.button_members.Text = "Teacher";
            this.button_members.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_members.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_members.UseVisualStyleBackColor = true;
            this.button_members.Click += new System.EventHandler(this.button_members_Click);
            this.button_members.Leave += new System.EventHandler(this.button_members_Leave);
            // 
            // button_module
            // 
            this.button_module.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_module.FlatAppearance.BorderSize = 0;
            this.button_module.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_module.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_module.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button_module.Location = new System.Drawing.Point(0, 290);
            this.button_module.Name = "button_module";
            this.button_module.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_module.Size = new System.Drawing.Size(200, 45);
            this.button_module.TabIndex = 1;
            this.button_module.Text = "Modules";
            this.button_module.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_module.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_module.UseVisualStyleBackColor = true;
            this.button_module.Click += new System.EventHandler(this.button_modules_Click);
            this.button_module.Leave += new System.EventHandler(this.button_module_Leave);
            // 
            // button_class
            // 
            this.button_class.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_class.FlatAppearance.BorderSize = 0;
            this.button_class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_class.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button_class.Location = new System.Drawing.Point(0, 245);
            this.button_class.Name = "button_class";
            this.button_class.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_class.Size = new System.Drawing.Size(200, 45);
            this.button_class.TabIndex = 1;
            this.button_class.Text = "Classes";
            this.button_class.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_class.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_class.UseVisualStyleBackColor = true;
            this.button_class.Click += new System.EventHandler(this.button_classes__Click);
            this.button_class.Leave += new System.EventHandler(this.button_class_Leave);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Location = new System.Drawing.Point(0, 251);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 43);
            this.button3.TabIndex = 1;
            this.button3.Text = "Modules";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_dashboard
            // 
            this.button_dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dashboard.FlatAppearance.BorderSize = 0;
            this.button_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashboard.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button_dashboard.Image = ((System.Drawing.Image)(resources.GetObject("button_dashboard.Image")));
            this.button_dashboard.Location = new System.Drawing.Point(0, 200);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_dashboard.Size = new System.Drawing.Size(200, 45);
            this.button_dashboard.TabIndex = 1;
            this.button_dashboard.Text = "Dashboard";
            this.button_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_dashboard.UseVisualStyleBackColor = true;
            this.button_dashboard.Click += new System.EventHandler(this.button_Dashboard_Click);
            this.button_dashboard.Leave += new System.EventHandler(this.button_dashboard_Leave);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(0, 208);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(200, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Classes";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 200);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label2.Location = new System.Drawing.Point(12, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = " Quality education our motto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(29, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Herald College ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormLoader.Location = new System.Drawing.Point(0, 102);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.panelFormLoader.Size = new System.Drawing.Size(1007, 705);
            this.panelFormLoader.TabIndex = 4;
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(978, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(29, 102);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(949, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 102);
            this.button1.TabIndex = 5;
            this.button1.Text = "O";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(920, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 102);
            this.button4.TabIndex = 6;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Padding = new System.Windows.Forms.Padding(40, 50, 20, 20);
            this.labelTitle.Size = new System.Drawing.Size(255, 109);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Dashboard";
            this.labelTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.labelTitle);
            this.panel3.Controls.Add(this.buttonClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1007, 102);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelFormLoader);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1007, 807);
            this.panel4.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1207, 807);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel_posts.ResumeLayout(false);
            this.panel_members.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_posts;
        private System.Windows.Forms.Button button_notice;
        private System.Windows.Forms.Button button_poll;
        private System.Windows.Forms.Panel panel_members;
        private System.Windows.Forms.Button button_teachers;
        private System.Windows.Forms.Button button_students;
        private System.Windows.Forms.Button button_posts;
        private System.Windows.Forms.Button button_members;
        private System.Windows.Forms.Button button_module;
        private System.Windows.Forms.Button button_class;
        private System.Windows.Forms.Button button_dashboard;
        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

