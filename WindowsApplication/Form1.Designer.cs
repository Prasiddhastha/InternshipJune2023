namespace WindowsApplication
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            SelectBtn = new Button();
            label4 = new Label();
            txtAdress = new TextBox();
            UpdateBtn = new Button();
            InsertBtn = new Button();
            Deletbtn = new Button();
            dataGridView1 = new DataGridView();
            Student = new Label();
            txtAge = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 93);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 93);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "LastName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 145);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(101, 90);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(291, 90);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 1;
            // 
            // SelectBtn
            // 
            SelectBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            SelectBtn.Location = new Point(163, 301);
            SelectBtn.Name = "SelectBtn";
            SelectBtn.Size = new Size(111, 49);
            SelectBtn.TabIndex = 8;
            SelectBtn.Text = "Select";
            SelectBtn.UseVisualStyleBackColor = true;
            //SelectBtn.Click += SelectBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 145);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 7;
            label4.Text = "Address";
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(291, 142);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(100, 23);
            txtAdress.TabIndex = 3;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateBtn.Location = new Point(163, 214);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(111, 49);
            UpdateBtn.TabIndex = 5;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // InsertBtn
            // 
            InsertBtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            InsertBtn.Location = new Point(12, 214);
            InsertBtn.Name = "InsertBtn";
            InsertBtn.Size = new Size(111, 49);
            InsertBtn.TabIndex = 4;
            InsertBtn.Text = "Insert";
            InsertBtn.UseVisualStyleBackColor = true;
            InsertBtn.Click += InsertBtn_Click;
            // 
            // Deletbtn
            // 
            Deletbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Deletbtn.Location = new Point(310, 214);
            Deletbtn.Name = "Deletbtn";
            Deletbtn.Size = new Size(111, 49);
            Deletbtn.TabIndex = 6;
            Deletbtn.Text = "Delete";
            Deletbtn.UseVisualStyleBackColor = true;
            Deletbtn.Click += Deletbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(440, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(526, 426);
            dataGridView1.TabIndex = 7;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // Student
            // 
            Student.AutoSize = true;
            Student.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Student.Location = new Point(138, 28);
            Student.Name = "Student";
            Student.Size = new Size(147, 25);
            Student.TabIndex = 13;
            Student.Text = "Student Details";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(101, 145);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(991, 450);
            Controls.Add(txtAge);
            Controls.Add(Student);
            Controls.Add(dataGridView1);
            Controls.Add(Deletbtn);
            Controls.Add(InsertBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(txtAdress);
            Controls.Add(label4);
            Controls.Add(SelectBtn);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button SelectBtn;
        private Label label4;
        private TextBox txtAdress;
        private Button UpdateBtn;
        private Button InsertBtn;
        private Button Deletbtn;
        private DataGridView dataGridView1;
        private Label Student;
        private TextBox txtAge;
    }
}