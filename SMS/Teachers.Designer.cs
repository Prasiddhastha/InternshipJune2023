namespace SMS
{
    partial class Teachers
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
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvTeachers = new DataGridView();
            SNColumn = new DataGridViewTextBoxColumn();
            TeacherNameColumn = new DataGridViewTextBoxColumn();
            SubjectColumn = new DataGridViewTextBoxColumn();
            ClassColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 43);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 39);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(236, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 82);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 0;
            label2.Text = "Last Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 78);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 27);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 121);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 0;
            label3.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 159);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 0;
            label4.Text = "Class";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(134, 155);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(236, 27);
            textBox4.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "C Sharp", "Python", "Javascript", "Ruby", "Rust", "Java" });
            comboBox1.Location = new Point(134, 117);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 28);
            comboBox1.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(289, 210);
            btnClear.Margin = new Padding(3, 5, 3, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 43);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(202, 210);
            btnDelete.Margin = new Padding(3, 5, 3, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 43);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(115, 210);
            btnEdit.Margin = new Padding(3, 5, 3, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(81, 43);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(28, 210);
            btnAdd.Margin = new Padding(3, 5, 3, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 43);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dgvTeachers
            // 
            dgvTeachers.AllowUserToAddRows = false;
            dgvTeachers.AllowUserToDeleteRows = false;
            dgvTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeachers.Columns.AddRange(new DataGridViewColumn[] { SNColumn, TeacherNameColumn, SubjectColumn, ClassColumn });
            dgvTeachers.Location = new Point(428, 39);
            dgvTeachers.Name = "dgvTeachers";
            dgvTeachers.ReadOnly = true;
            dgvTeachers.RowTemplate.Height = 25;
            dgvTeachers.Size = new Size(482, 214);
            dgvTeachers.TabIndex = 7;
            // 
            // SNColumn
            // 
            SNColumn.HeaderText = "SN";
            SNColumn.Name = "SNColumn";
            SNColumn.ReadOnly = true;
            SNColumn.Width = 50;
            // 
            // TeacherNameColumn
            // 
            TeacherNameColumn.HeaderText = "Teacher Name";
            TeacherNameColumn.Name = "TeacherNameColumn";
            TeacherNameColumn.ReadOnly = true;
            TeacherNameColumn.Width = 150;
            // 
            // SubjectColumn
            // 
            SubjectColumn.HeaderText = "Subject";
            SubjectColumn.Name = "SubjectColumn";
            SubjectColumn.ReadOnly = true;
            // 
            // ClassColumn
            // 
            ClassColumn.HeaderText = "Class";
            ClassColumn.Name = "ClassColumn";
            ClassColumn.ReadOnly = true;
            // 
            // Teachers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 292);
            Controls.Add(dgvTeachers);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Teachers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Teachers";
            ((System.ComponentModel.ISupportInitialize)dgvTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvTeachers;
        private DataGridViewTextBoxColumn SNColumn;
        private DataGridViewTextBoxColumn TeacherNameColumn;
        private DataGridViewTextBoxColumn SubjectColumn;
        private DataGridViewTextBoxColumn ClassColumn;
    }
}