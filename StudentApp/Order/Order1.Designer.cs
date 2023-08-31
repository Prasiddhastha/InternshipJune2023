namespace StudentApp
{
    partial class Order1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order1));
            pictureBox1 = new PictureBox();
            dgvOrder1 = new DataGridView();
            btnOrder = new Button();
            studentAddress = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            studentName = new TextBox();
            labelNa = new Label();
            nuDAGe = new NumericUpDown();
            txtSubject = new TextBox();
            studentPicture = new PictureBox();
            txtEmail = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuDAGe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentPicture).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // dgvOrder1
            // 
            dgvOrder1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrder1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder1.BackgroundColor = SystemColors.ActiveCaption;
            dgvOrder1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder1.Location = new Point(74, 278);
            dgvOrder1.Name = "dgvOrder1";
            dgvOrder1.RowTemplate.Height = 25;
            dgvOrder1.Size = new Size(634, 295);
            dgvOrder1.TabIndex = 3;
            dgvOrder1.CellClick += dgvOrder1_CellClick;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(255, 128, 128);
            btnOrder.FlatAppearance.BorderColor = Color.OrangeRed;
            btnOrder.FlatAppearance.BorderSize = 5;
            btnOrder.FlatAppearance.MouseDownBackColor = Color.Black;
            btnOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.ForeColor = SystemColors.Highlight;
            btnOrder.Image = (Image)resources.GetObject("btnOrder.Image");
            btnOrder.Location = new Point(84, 247);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(33, 25);
            btnOrder.TabIndex = 4;
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // studentAddress
            // 
            studentAddress.Anchor = AnchorStyles.Top;
            studentAddress.BackColor = SystemColors.Control;
            studentAddress.Enabled = false;
            studentAddress.ForeColor = SystemColors.ControlText;
            studentAddress.Location = new Point(387, 80);
            studentAddress.Name = "studentAddress";
            studentAddress.ReadOnly = true;
            studentAddress.Size = new Size(165, 23);
            studentAddress.TabIndex = 47;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(292, 73);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 46;
            label4.Text = "Address:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(297, 205);
            label3.Name = "label3";
            label3.Size = new Size(58, 30);
            label3.TabIndex = 44;
            label3.Text = "Age:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(297, 119);
            label2.Name = "label2";
            label2.Size = new Size(92, 30);
            label2.TabIndex = 42;
            label2.Text = "Subject:";
            // 
            // studentName
            // 
            studentName.Anchor = AnchorStyles.Top;
            studentName.BackColor = SystemColors.Control;
            studentName.Enabled = false;
            studentName.ForeColor = SystemColors.ControlText;
            studentName.Location = new Point(380, 31);
            studentName.Name = "studentName";
            studentName.ReadOnly = true;
            studentName.Size = new Size(172, 23);
            studentName.TabIndex = 41;
            // 
            // labelNa
            // 
            labelNa.Anchor = AnchorStyles.Top;
            labelNa.AutoSize = true;
            labelNa.BackColor = Color.Transparent;
            labelNa.FlatStyle = FlatStyle.Flat;
            labelNa.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNa.ForeColor = SystemColors.ActiveBorder;
            labelNa.Location = new Point(297, 24);
            labelNa.Name = "labelNa";
            labelNa.Size = new Size(77, 30);
            labelNa.TabIndex = 40;
            labelNa.Text = "Name:";
            // 
            // nuDAGe
            // 
            nuDAGe.Anchor = AnchorStyles.Top;
            nuDAGe.BackColor = SystemColors.Control;
            nuDAGe.BorderStyle = BorderStyle.None;
            nuDAGe.Enabled = false;
            nuDAGe.ForeColor = SystemColors.ControlText;
            nuDAGe.InterceptArrowKeys = false;
            nuDAGe.Location = new Point(361, 216);
            nuDAGe.Name = "nuDAGe";
            nuDAGe.ReadOnly = true;
            nuDAGe.Size = new Size(102, 19);
            nuDAGe.TabIndex = 45;
            // 
            // txtSubject
            // 
            txtSubject.Anchor = AnchorStyles.Top;
            txtSubject.BackColor = SystemColors.Control;
            txtSubject.Enabled = false;
            txtSubject.ForeColor = SystemColors.ControlText;
            txtSubject.Location = new Point(395, 126);
            txtSubject.Name = "txtSubject";
            txtSubject.ReadOnly = true;
            txtSubject.Size = new Size(130, 23);
            txtSubject.TabIndex = 50;
            // 
            // studentPicture
            // 
            studentPicture.Anchor = AnchorStyles.Top;
            studentPicture.BackColor = Color.Transparent;
            studentPicture.BorderStyle = BorderStyle.Fixed3D;
            studentPicture.Location = new Point(596, 31);
            studentPicture.Name = "studentPicture";
            studentPicture.Size = new Size(165, 180);
            studentPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            studentPicture.TabIndex = 48;
            studentPicture.TabStop = false;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.BackColor = SystemColors.Control;
            txtEmail.Enabled = false;
            txtEmail.ForeColor = SystemColors.ControlText;
            txtEmail.Location = new Point(387, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(165, 23);
            txtEmail.TabIndex = 52;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(292, 161);
            label1.Name = "label1";
            label1.Size = new Size(72, 30);
            label1.TabIndex = 51;
            label1.Text = "Email:";
            // 
            // Order1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(787, 585);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(studentPicture);
            Controls.Add(txtSubject);
            Controls.Add(studentAddress);
            Controls.Add(label4);
            Controls.Add(nuDAGe);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(studentName);
            Controls.Add(labelNa);
            Controls.Add(btnOrder);
            Controls.Add(dgvOrder1);
            Controls.Add(pictureBox1);
            Name = "Order1";
            Text = "Order1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuDAGe).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvOrder1;
        private Button btnOrder;
        private TextBox studentAddress;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox studentName;
        private Label labelNa;
        private NumericUpDown nuDAGe;
        private TextBox txtSubject;
        private PictureBox studentPicture;
        private TextBox txtEmail;
        private Label label1;
    }
}