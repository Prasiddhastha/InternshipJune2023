namespace SMS
{
    partial class MainWIndow
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
            btnSchoolInfo = new Button();
            btnSubjects = new Button();
            btnTeachers = new Button();
            btnStudents = new Button();
            SuspendLayout();
            // 
            // btnSchoolInfo
            // 
            btnSchoolInfo.Location = new Point(347, 155);
            btnSchoolInfo.Name = "btnSchoolInfo";
            btnSchoolInfo.Size = new Size(114, 56);
            btnSchoolInfo.TabIndex = 0;
            btnSchoolInfo.Text = "School Info";
            btnSchoolInfo.UseVisualStyleBackColor = true;
            btnSchoolInfo.Click += btnSchoolInfo_Click;
            // 
            // btnSubjects
            // 
            btnSubjects.Location = new Point(123, 239);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(114, 56);
            btnSubjects.TabIndex = 1;
            btnSubjects.Text = "Subjects";
            btnSubjects.UseVisualStyleBackColor = true;
            btnSubjects.Click += btnSubjects_Click;
            // 
            // btnTeachers
            // 
            btnTeachers.Location = new Point(347, 239);
            btnTeachers.Name = "btnTeachers";
            btnTeachers.Size = new Size(114, 56);
            btnTeachers.TabIndex = 2;
            btnTeachers.Text = "Teachers";
            btnTeachers.UseVisualStyleBackColor = true;
            btnTeachers.Click += btnTeachers_Click;
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(563, 239);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(114, 56);
            btnStudents.TabIndex = 2;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // MainWIndow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStudents);
            Controls.Add(btnTeachers);
            Controls.Add(btnSubjects);
            Controls.Add(btnSchoolInfo);
            Name = "MainWIndow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWIndow";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSchoolInfo;
        private Button btnSubjects;
        private Button btnTeachers;
        private Button btnStudents;
    }
}