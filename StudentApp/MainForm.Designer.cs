namespace StudentApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelDataSubmenu = new Panel();
            Order1Btn = new Button();
            panelSideMenu = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            orderByBtn = new Button();
            teachAddBtn = new Button();
            studentAddBtn = new Button();
            subjAddBtn = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panelForm = new Panel();
            pictureBox1 = new PictureBox();
            panelDataSubmenu.SuspendLayout();
            panelSideMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelDataSubmenu
            // 
            panelDataSubmenu.Anchor = AnchorStyles.None;
            panelDataSubmenu.BackColor = Color.FromArgb(35, 32, 39);
            panelDataSubmenu.Controls.Add(Order1Btn);
            panelDataSubmenu.Location = new Point(0, 397);
            panelDataSubmenu.Name = "panelDataSubmenu";
            panelDataSubmenu.Size = new Size(204, 47);
            panelDataSubmenu.TabIndex = 1;
            // 
            // Order1Btn
            // 
            Order1Btn.Anchor = AnchorStyles.None;
            Order1Btn.FlatAppearance.BorderSize = 0;
            Order1Btn.FlatStyle = FlatStyle.Flat;
            Order1Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Order1Btn.ForeColor = SystemColors.ActiveCaption;
            Order1Btn.Location = new Point(0, 0);
            Order1Btn.Name = "Order1Btn";
            Order1Btn.Size = new Size(204, 45);
            Order1Btn.TabIndex = 5;
            Order1Btn.Text = "Student Details\r\n";
            Order1Btn.UseVisualStyleBackColor = true;
            Order1Btn.Click += Order1Btn_Click;
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(29, 30, 33);
            panelSideMenu.Controls.Add(panel2);
            panelSideMenu.Controls.Add(panelDataSubmenu);
            panelSideMenu.Controls.Add(orderByBtn);
            panelSideMenu.Controls.Add(teachAddBtn);
            panelSideMenu.Controls.Add(studentAddBtn);
            panelSideMenu.Controls.Add(subjAddBtn);
            panelSideMenu.Controls.Add(panel1);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(204, 661);
            panelSideMenu.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(pictureBox3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 550);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 111);
            panel2.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-89, -22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(379, 156);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // orderByBtn
            // 
            orderByBtn.Anchor = AnchorStyles.None;
            orderByBtn.FlatAppearance.BorderSize = 0;
            orderByBtn.FlatStyle = FlatStyle.Flat;
            orderByBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            orderByBtn.ForeColor = SystemColors.ActiveCaption;
            orderByBtn.Location = new Point(0, 352);
            orderByBtn.Name = "orderByBtn";
            orderByBtn.Size = new Size(204, 45);
            orderByBtn.TabIndex = 4;
            orderByBtn.Text = "Data";
            orderByBtn.UseVisualStyleBackColor = true;
            orderByBtn.Click += orderByBtn_Click;
            // 
            // teachAddBtn
            // 
            teachAddBtn.Anchor = AnchorStyles.None;
            teachAddBtn.FlatAppearance.BorderSize = 0;
            teachAddBtn.FlatStyle = FlatStyle.Flat;
            teachAddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            teachAddBtn.ForeColor = SystemColors.ActiveCaption;
            teachAddBtn.Location = new Point(0, 307);
            teachAddBtn.Name = "teachAddBtn";
            teachAddBtn.Size = new Size(204, 45);
            teachAddBtn.TabIndex = 3;
            teachAddBtn.Text = "Teachers";
            teachAddBtn.UseVisualStyleBackColor = true;
            teachAddBtn.Click += teachAddBtn_Click;
            // 
            // studentAddBtn
            // 
            studentAddBtn.Anchor = AnchorStyles.None;
            studentAddBtn.FlatAppearance.BorderSize = 0;
            studentAddBtn.FlatStyle = FlatStyle.Flat;
            studentAddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            studentAddBtn.ForeColor = SystemColors.ActiveCaption;
            studentAddBtn.Location = new Point(0, 262);
            studentAddBtn.Name = "studentAddBtn";
            studentAddBtn.Size = new Size(204, 45);
            studentAddBtn.TabIndex = 2;
            studentAddBtn.Text = "Students";
            studentAddBtn.UseVisualStyleBackColor = true;
            studentAddBtn.Click += studentAddBtn_Click;
            // 
            // subjAddBtn
            // 
            subjAddBtn.Anchor = AnchorStyles.None;
            subjAddBtn.FlatAppearance.BorderSize = 0;
            subjAddBtn.FlatStyle = FlatStyle.Flat;
            subjAddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            subjAddBtn.ForeColor = SystemColors.ActiveCaption;
            subjAddBtn.Location = new Point(0, 217);
            subjAddBtn.Name = "subjAddBtn";
            subjAddBtn.Size = new Size(204, 45);
            subjAddBtn.TabIndex = 1;
            subjAddBtn.Text = "Subjects";
            subjAddBtn.UseVisualStyleBackColor = true;
            subjAddBtn.Click += subjAddBtn_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 184);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(204, 184);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panelForm
            // 
            panelForm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelForm.BackColor = Color.FromArgb(32, 30, 45);
            panelForm.Controls.Add(pictureBox1);
            panelForm.Location = new Point(250, 24);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(893, 608);
            panelForm.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(236, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(420, 397);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.OF18H90;
            ClientSize = new Size(1184, 661);
            Controls.Add(panelForm);
            Controls.Add(panelSideMenu);
            MinimumSize = new Size(1200, 700);
            Name = "MainForm";
            Text = "StudentApp";
            panelDataSubmenu.ResumeLayout(false);
            panelSideMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDataSubmenu;
        private Button Order1Btn;
        private Panel panelSideMenu;
        private Button orderByBtn;
        private Button teachAddBtn;
        private Button studentAddBtn;
        private Button subjAddBtn;
        private Panel panel1;
        private Panel panelForm;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}