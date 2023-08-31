namespace DesktopApplication
{
    partial class UserStudents
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
            subName1 = new TextBox();
            label1a = new Label();
            studentName = new TextBox();
            labelNa = new Label();
            labelT = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvStudent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // subName1
            // 
            subName1.Location = new Point(284, 100);
            subName1.Name = "subName1";
            subName1.Size = new Size(100, 23);
            subName1.TabIndex = 18;
            // 
            // label1a
            // 
            label1a.AutoSize = true;
            label1a.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1a.Location = new Point(199, 100);
            label1a.Name = "label1a";
            label1a.Size = new Size(83, 25);
            label1a.TabIndex = 17;
            label1a.Text = "Subject:";
            // 
            // studentName
            // 
            studentName.Location = new Point(274, 56);
            studentName.Name = "studentName";
            studentName.Size = new Size(100, 23);
            studentName.TabIndex = 16;
            // 
            // labelNa
            // 
            labelNa.AutoSize = true;
            labelNa.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelNa.Location = new Point(199, 54);
            labelNa.Name = "labelNa";
            labelNa.Size = new Size(69, 25);
            labelNa.TabIndex = 15;
            labelNa.Text = "Name:";
            // 
            // labelT
            // 
            labelT.AutoSize = true;
            labelT.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelT.Location = new Point(199, 9);
            labelT.Name = "labelT";
            labelT.Size = new Size(137, 30);
            labelT.TabIndex = 14;
            labelT.Text = "Add Student";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(328, 154);
            btnClear.Margin = new Padding(3, 5, 3, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 43);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(233, 154);
            btnDelete.Margin = new Padding(3, 5, 3, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 43);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(138, 154);
            btnEdit.Margin = new Padding(3, 5, 3, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(81, 43);
            btnEdit.TabIndex = 22;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(32, 154);
            btnAdd.Margin = new Padding(3, 5, 3, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 43);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(5, 205);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowTemplate.Height = 25;
            dgvStudent.Size = new Size(438, 275);
            dgvStudent.TabIndex = 24;
            dgvStudent.MouseDoubleClick += dgvStudent_MouseDoubleClick;
            // 
            // UserStudents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 492);
            ControlBox = false;
            Controls.Add(dgvStudent);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(subName1);
            Controls.Add(label1a);
            Controls.Add(studentName);
            Controls.Add(labelNa);
            Controls.Add(labelT);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserStudents";
            Text = "UserStudents";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox subName1;
        private Label label1a;
        private TextBox studentName;
        private Label labelNa;
        private Label labelT;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvStudent;
    }
}