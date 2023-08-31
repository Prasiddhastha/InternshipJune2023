namespace StudentApp
{
    partial class UserStudent
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
            components = new System.ComponentModel.Container();
            dgvStudent = new DataGridView();
            label1 = new Label();
            studentName = new TextBox();
            labelNa = new Label();
            label2 = new Label();
            cmbSubject = new ComboBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            label3 = new Label();
            nuDAGe = new NumericUpDown();
            studentBindingSource = new BindingSource(components);
            studentAddress = new TextBox();
            label4 = new Label();
            studentPicture = new PictureBox();
            BtnBrowse = new Button();
            txtEmail = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuDAGe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentPicture).BeginInit();
            SuspendLayout();
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToDeleteRows = false;
            dgvStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.BackgroundColor = SystemColors.ActiveCaption;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(27, 295);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowTemplate.Height = 25;
            dgvStudent.Size = new Size(495, 278);
            dgvStudent.TabIndex = 25;
            dgvStudent.CellClick += dgvStudent_CellClick;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(185, 5);
            label1.Name = "label1";
            label1.Size = new Size(417, 86);
            label1.TabIndex = 26;
            label1.Text = "Add Student";
            // 
            // studentName
            // 
            studentName.Anchor = AnchorStyles.Top;
            studentName.Location = new Point(108, 155);
            studentName.Name = "studentName";
            studentName.PlaceholderText = "Enter your name....";
            studentName.Size = new Size(165, 23);
            studentName.TabIndex = 28;
            // 
            // labelNa
            // 
            labelNa.Anchor = AnchorStyles.Top;
            labelNa.AutoSize = true;
            labelNa.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelNa.ForeColor = SystemColors.Control;
            labelNa.Location = new Point(25, 148);
            labelNa.Name = "labelNa";
            labelNa.Size = new Size(77, 30);
            labelNa.TabIndex = 27;
            labelNa.Text = "Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(303, 148);
            label2.Name = "label2";
            label2.Size = new Size(92, 30);
            label2.TabIndex = 29;
            label2.Text = "Subject:";
            // 
            // cmbSubject
            // 
            cmbSubject.Anchor = AnchorStyles.Top;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(403, 155);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(131, 23);
            cmbSubject.TabIndex = 30;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Right;
            btnClear.BackColor = SystemColors.AppWorkspace;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(664, 482);
            btnClear.Margin = new Padding(3, 5, 3, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 43);
            btnClear.TabIndex = 31;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Right;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderColor = Color.Lime;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(569, 482);
            btnDelete.Margin = new Padding(3, 5, 3, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 43);
            btnDelete.TabIndex = 32;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Right;
            btnEdit.BackColor = Color.Lime;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(664, 392);
            btnEdit.Margin = new Padding(3, 5, 3, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(81, 43);
            btnEdit.TabIndex = 33;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Right;
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(569, 392);
            btnAdd.Margin = new Padding(3, 5, 3, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 43);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(326, 197);
            label3.Name = "label3";
            label3.Size = new Size(58, 30);
            label3.TabIndex = 35;
            label3.Text = "Age:";
            // 
            // nuDAGe
            // 
            nuDAGe.Anchor = AnchorStyles.Top;
            nuDAGe.Location = new Point(393, 204);
            nuDAGe.Name = "nuDAGe";
            nuDAGe.Size = new Size(120, 23);
            nuDAGe.TabIndex = 36;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // studentAddress
            // 
            studentAddress.Anchor = AnchorStyles.Top;
            studentAddress.Location = new Point(124, 206);
            studentAddress.Name = "studentAddress";
            studentAddress.PlaceholderText = "Enter address....";
            studentAddress.Size = new Size(165, 23);
            studentAddress.TabIndex = 38;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(25, 204);
            label4.Name = "label4";
            label4.Size = new Size(97, 30);
            label4.TabIndex = 37;
            label4.Text = "Address:";
            // 
            // studentPicture
            // 
            studentPicture.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            studentPicture.BorderStyle = BorderStyle.Fixed3D;
            studentPicture.Location = new Point(584, 94);
            studentPicture.Name = "studentPicture";
            studentPicture.Size = new Size(165, 180);
            studentPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            studentPicture.TabIndex = 39;
            studentPicture.TabStop = false;
            // 
            // BtnBrowse
            // 
            BtnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBrowse.BackColor = SystemColors.Menu;
            BtnBrowse.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBrowse.ForeColor = SystemColors.ActiveCaptionText;
            BtnBrowse.Location = new Point(629, 295);
            BtnBrowse.Margin = new Padding(3, 5, 3, 5);
            BtnBrowse.Name = "BtnBrowse";
            BtnBrowse.Size = new Size(81, 43);
            BtnBrowse.TabIndex = 40;
            BtnBrowse.Text = "Browse";
            BtnBrowse.UseVisualStyleBackColor = false;
            BtnBrowse.Click += BtnBrowse_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(246, 251);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter email....";
            txtEmail.Size = new Size(188, 23);
            txtEmail.TabIndex = 54;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(151, 244);
            label5.Name = "label5";
            label5.Size = new Size(72, 30);
            label5.TabIndex = 53;
            label5.Text = "Email:";
            // 
            // UserStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(787, 585);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(BtnBrowse);
            Controls.Add(studentPicture);
            Controls.Add(studentAddress);
            Controls.Add(label4);
            Controls.Add(nuDAGe);
            Controls.Add(label3);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(cmbSubject);
            Controls.Add(label2);
            Controls.Add(studentName);
            Controls.Add(labelNa);
            Controls.Add(label1);
            Controls.Add(dgvStudent);
            Name = "UserStudent";
            Text = "UserStudent";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuDAGe).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudent;
        private Label label1;
        private TextBox studentName;
        private Label labelNa;
        private Label label2;
        private ComboBox cmbSubject;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Label label3;
        private NumericUpDown nuDAGe;
        private BindingSource studentBindingSource;
        private TextBox studentAddress;
        private Label label4;
        private PictureBox studentPicture;
        private Button BtnBrowse;
        private TextBox txtEmail;
        private Label label5;
    }
}