namespace StudentApp
{
    partial class UserTeacher
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
            label1 = new Label();
            dvgTeachers = new DataGridView();
            teachAddress = new TextBox();
            labelA = new Label();
            teachName = new TextBox();
            labelN = new Label();
            cmbSubject = new ComboBox();
            label2 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgTeachers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(188, 19);
            label1.Name = "label1";
            label1.Size = new Size(411, 86);
            label1.TabIndex = 27;
            label1.Text = "Add Teacher";
            // 
            // dvgTeachers
            // 
            dvgTeachers.AllowUserToAddRows = false;
            dvgTeachers.AllowUserToDeleteRows = false;
            dvgTeachers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTeachers.BackgroundColor = SystemColors.ActiveCaption;
            dvgTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTeachers.Location = new Point(63, 275);
            dvgTeachers.Name = "dvgTeachers";
            dvgTeachers.ReadOnly = true;
            dvgTeachers.RowTemplate.Height = 25;
            dvgTeachers.Size = new Size(657, 283);
            dvgTeachers.TabIndex = 28;
            dvgTeachers.CellClick += dvgTeachers_CellClick;
            // 
            // teachAddress
            // 
            teachAddress.Anchor = AnchorStyles.Top;
            teachAddress.Location = new Point(247, 172);
            teachAddress.Name = "teachAddress";
            teachAddress.PlaceholderText = "Enter address....";
            teachAddress.Size = new Size(127, 23);
            teachAddress.TabIndex = 32;
            // 
            // labelA
            // 
            labelA.Anchor = AnchorStyles.Top;
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelA.ForeColor = SystemColors.Control;
            labelA.Location = new Point(144, 165);
            labelA.Name = "labelA";
            labelA.Size = new Size(97, 30);
            labelA.TabIndex = 31;
            labelA.Text = "Address:";
            // 
            // teachName
            // 
            teachName.Anchor = AnchorStyles.Top;
            teachName.Location = new Point(247, 124);
            teachName.Multiline = true;
            teachName.Name = "teachName";
            teachName.PlaceholderText = "Enter name....";
            teachName.Size = new Size(127, 23);
            teachName.TabIndex = 30;
            // 
            // labelN
            // 
            labelN.Anchor = AnchorStyles.Top;
            labelN.AutoSize = true;
            labelN.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelN.ForeColor = SystemColors.Control;
            labelN.Location = new Point(157, 118);
            labelN.Name = "labelN";
            labelN.Size = new Size(77, 30);
            labelN.TabIndex = 29;
            labelN.Text = "Name:";
            // 
            // cmbSubject
            // 
            cmbSubject.Anchor = AnchorStyles.Top;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(511, 144);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(131, 23);
            cmbSubject.TabIndex = 34;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(413, 137);
            label2.Name = "label2";
            label2.Size = new Size(92, 30);
            label2.TabIndex = 33;
            label2.Text = "Subject:";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top;
            btnClear.BackColor = SystemColors.AppWorkspace;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(500, 214);
            btnClear.Margin = new Padding(3, 5, 3, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 43);
            btnClear.TabIndex = 35;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top;
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatAppearance.BorderColor = Color.Lime;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(405, 214);
            btnDelete.Margin = new Padding(3, 5, 3, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 43);
            btnDelete.TabIndex = 36;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top;
            btnEdit.BackColor = Color.Lime;
            btnEdit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(310, 214);
            btnEdit.Margin = new Padding(3, 5, 3, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(81, 43);
            btnEdit.TabIndex = 37;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(215, 214);
            btnAdd.Margin = new Padding(3, 5, 3, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 43);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // UserTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(787, 585);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(cmbSubject);
            Controls.Add(label2);
            Controls.Add(teachAddress);
            Controls.Add(labelA);
            Controls.Add(teachName);
            Controls.Add(labelN);
            Controls.Add(dvgTeachers);
            Controls.Add(label1);
            Name = "UserTeacher";
            Text = "UserTeacher";
            ((System.ComponentModel.ISupportInitialize)dvgTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dvgTeachers;
        private TextBox teachAddress;
        private Label labelA;
        private TextBox teachName;
        private Label labelN;
        private ComboBox cmbSubject;
        private Label label2;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
    }
}