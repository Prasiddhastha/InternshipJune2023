namespace DesktopApplication
{
    partial class UserTeachers
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
            label1 = new Label();
            teachAddress = new TextBox();
            labelA = new Label();
            teachName = new TextBox();
            labelN = new Label();
            labelT = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dvgTeachers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dvgTeachers).BeginInit();
            SuspendLayout();
            // 
            // subName1
            // 
            subName1.Location = new Point(258, 142);
            subName1.Name = "subName1";
            subName1.Size = new Size(127, 23);
            subName1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(173, 142);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 14;
            label1.Text = "Subject:";
            // 
            // teachAddress
            // 
            teachAddress.Location = new Point(258, 100);
            teachAddress.Name = "teachAddress";
            teachAddress.Size = new Size(127, 23);
            teachAddress.TabIndex = 13;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelA.Location = new Point(173, 100);
            labelA.Name = "labelA";
            labelA.Size = new Size(88, 25);
            labelA.TabIndex = 12;
            labelA.Text = "Address:";
            // 
            // teachName
            // 
            teachName.Location = new Point(248, 57);
            teachName.Multiline = true;
            teachName.Name = "teachName";
            teachName.Size = new Size(127, 23);
            teachName.TabIndex = 11;
            // 
            // labelN
            // 
            labelN.AutoSize = true;
            labelN.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelN.Location = new Point(173, 57);
            labelN.Name = "labelN";
            labelN.Size = new Size(69, 25);
            labelN.TabIndex = 10;
            labelN.Text = "Name:";
            // 
            // labelT
            // 
            labelT.AutoSize = true;
            labelT.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelT.Location = new Point(173, 9);
            labelT.Name = "labelT";
            labelT.Size = new Size(134, 30);
            labelT.TabIndex = 9;
            labelT.Text = "Add Teacher";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(321, 184);
            btnClear.Margin = new Padding(3, 5, 3, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(81, 43);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(226, 184);
            btnDelete.Margin = new Padding(3, 5, 3, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(81, 43);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(131, 184);
            btnEdit.Margin = new Padding(3, 5, 3, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(81, 43);
            btnEdit.TabIndex = 18;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(25, 184);
            btnAdd.Margin = new Padding(3, 5, 3, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 43);
            btnAdd.TabIndex = 19;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dvgTeachers
            // 
            dvgTeachers.AllowUserToAddRows = false;
            dvgTeachers.AllowUserToDeleteRows = false;
            dvgTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvgTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTeachers.Location = new Point(12, 254);
            dvgTeachers.Name = "dvgTeachers";
            dvgTeachers.ReadOnly = true;
            dvgTeachers.RowTemplate.Height = 25;
            dvgTeachers.Size = new Size(431, 226);
            dvgTeachers.TabIndex = 20;
            dvgTeachers.MouseDoubleClick += dvgTeachers_MouseDoubleClick;
            // 
            // UserTeachers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 492);
            ControlBox = false;
            Controls.Add(dvgTeachers);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(subName1);
            Controls.Add(label1);
            Controls.Add(teachAddress);
            Controls.Add(labelA);
            Controls.Add(teachName);
            Controls.Add(labelN);
            Controls.Add(labelT);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserTeachers";
            Text = "UserTeachers";
            ((System.ComponentModel.ISupportInitialize)dvgTeachers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox subName1;
        private Label label1;
        private TextBox teachAddress;
        private Label labelA;
        private TextBox teachName;
        private Label labelN;
        private Label labelT;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dvgTeachers;
    }
}