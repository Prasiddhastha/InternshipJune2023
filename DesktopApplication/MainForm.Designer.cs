namespace DesktopApplication
{
    partial class StudentManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentManage));
            RightPanel = new Panel();
            orderByBtn = new Button();
            studentAddBtn = new Button();
            teachAddBtn = new Button();
            subjAddBtn = new Button();
            label1 = new Label();
            LeftPanel = new Panel();
            smallpic = new PictureBox();
            FrontPic = new PictureBox();
            RightPanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)smallpic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FrontPic).BeginInit();
            SuspendLayout();
            // 
            // RightPanel
            // 
            RightPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            RightPanel.Controls.Add(orderByBtn);
            RightPanel.Controls.Add(studentAddBtn);
            RightPanel.Controls.Add(teachAddBtn);
            RightPanel.Controls.Add(subjAddBtn);
            RightPanel.Controls.Add(label1);
            RightPanel.Location = new Point(457, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(343, 492);
            RightPanel.TabIndex = 0;
            // 
            // orderByBtn
            // 
            orderByBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            orderByBtn.Location = new Point(95, 370);
            orderByBtn.Name = "orderByBtn";
            orderByBtn.Size = new Size(131, 48);
            orderByBtn.TabIndex = 4;
            orderByBtn.Text = "Order By";
            orderByBtn.UseVisualStyleBackColor = true;
            orderByBtn.Click += orderByBtn_Click;
            // 
            // studentAddBtn
            // 
            studentAddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            studentAddBtn.Location = new Point(95, 292);
            studentAddBtn.Name = "studentAddBtn";
            studentAddBtn.Size = new Size(131, 48);
            studentAddBtn.TabIndex = 3;
            studentAddBtn.Text = "Student";
            studentAddBtn.UseVisualStyleBackColor = true;
            studentAddBtn.Click += studentAddBtn_Click;
            // 
            // teachAddBtn
            // 
            teachAddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            teachAddBtn.Location = new Point(95, 214);
            teachAddBtn.Name = "teachAddBtn";
            teachAddBtn.Size = new Size(131, 48);
            teachAddBtn.TabIndex = 2;
            teachAddBtn.Text = "Teacher";
            teachAddBtn.UseVisualStyleBackColor = true;
            teachAddBtn.Click += teachAddBtn_Click;
            // 
            // subjAddBtn
            // 
            subjAddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            subjAddBtn.Location = new Point(95, 136);
            subjAddBtn.Name = "subjAddBtn";
            subjAddBtn.Size = new Size(131, 48);
            subjAddBtn.TabIndex = 1;
            subjAddBtn.Text = "Subject";
            subjAddBtn.UseVisualStyleBackColor = true;
            subjAddBtn.Click += subjAddBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 74);
            label1.Name = "label1";
            label1.Size = new Size(241, 32);
            label1.TabIndex = 0;
            label1.Text = "Student Application";
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.White;
            LeftPanel.Controls.Add(smallpic);
            LeftPanel.Controls.Add(FrontPic);
            LeftPanel.Location = new Point(1, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(455, 492);
            LeftPanel.TabIndex = 1;
            // 
            // smallpic
            // 
            smallpic.Anchor = AnchorStyles.None;
            smallpic.Image = (Image)resources.GetObject("smallpic.Image");
            smallpic.Location = new Point(0, 0);
            smallpic.Name = "smallpic";
            smallpic.Size = new Size(154, 140);
            smallpic.SizeMode = PictureBoxSizeMode.Zoom;
            smallpic.TabIndex = 1;
            smallpic.TabStop = false;
            smallpic.Visible = false;
            // 
            // FrontPic
            // 
            FrontPic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FrontPic.Image = (Image)resources.GetObject("FrontPic.Image");
            FrontPic.Location = new Point(42, 50);
            FrontPic.Name = "FrontPic";
            FrontPic.Size = new Size(343, 329);
            FrontPic.SizeMode = PictureBoxSizeMode.Zoom;
            FrontPic.TabIndex = 0;
            FrontPic.TabStop = false;
            // 
            // StudentManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 488);
            Controls.Add(LeftPanel);
            Controls.Add(RightPanel);
            Name = "StudentManage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            LeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)smallpic).EndInit();
            ((System.ComponentModel.ISupportInitialize)FrontPic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel RightPanel;
        public Panel LeftPanel;
        private Button subjAddBtn;
        private Label label1;
        private PictureBox smallpic;
        private PictureBox FrontPic;
        private Button orderByBtn;
        private Button studentAddBtn;
        private Button teachAddBtn;

    }
}