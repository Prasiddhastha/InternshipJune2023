namespace SMS
{
    partial class SchoolInfo
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
            txtSchoolName = new TextBox();
            label2 = new Label();
            txtAddress = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtTelephone = new TextBox();
            btnOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 0;
            label1.Text = "School Name";
            // 
            // txtSchoolName
            // 
            txtSchoolName.Location = new Point(192, 63);
            txtSchoolName.Margin = new Padding(4);
            txtSchoolName.Name = "txtSchoolName";
            txtSchoolName.ReadOnly = true;
            txtSchoolName.Size = new Size(414, 29);
            txtSchoolName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 0;
            label2.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(192, 104);
            txtAddress.Margin = new Padding(4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(414, 89);
            txtAddress.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(192, 203);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(414, 29);
            txtEmail.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 248);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 0;
            label4.Text = "Telephone";
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(192, 244);
            txtTelephone.Margin = new Padding(4);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.ReadOnly = true;
            txtTelephone.Size = new Size(414, 29);
            txtTelephone.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(305, 316);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(78, 36);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // SchoolInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 396);
            Controls.Add(btnOk);
            Controls.Add(txtTelephone);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(txtSchoolName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SchoolInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "School Information";
            Load += SchoolInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSchoolName;
        private Label label2;
        private TextBox txtAddress;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtTelephone;
        private Button btnOk;
    }
}