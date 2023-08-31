namespace DesktopApplication
{
    partial class UserSubjects
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
            txtSubject = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvSubject = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            SuspendLayout();
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(194, 105);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(140, 23);
            txtSubject.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(194, 77);
            label2.Name = "label2";
            label2.Size = new Size(140, 25);
            label2.TabIndex = 5;
            label2.Text = "Subject Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(185, 22);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 4;
            label1.Text = "Add Subject";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(329, 161);
            btnClear.Margin = new Padding(3, 5, 3, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 43);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(234, 161);
            btnDelete.Margin = new Padding(3, 5, 3, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 43);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(139, 161);
            btnEdit.Margin = new Padding(3, 5, 3, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(81, 43);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(44, 161);
            btnAdd.Margin = new Padding(3, 5, 3, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 43);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvSubject
            // 
            dgvSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(12, 233);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.RowTemplate.Height = 25;
            dgvSubject.Size = new Size(431, 247);
            dgvSubject.TabIndex = 11;
            //dgvSubject.MouseDoubleClick += dgvSubject_MouseDoubleClick;
            // 
            // UserSubjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 492);
            ControlBox = false;
            Controls.Add(dgvSubject);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(txtSubject);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserSubjects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserSubjects";
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSubject;
        private Label label2;
        private Label label1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dgvSubject;
    }
}