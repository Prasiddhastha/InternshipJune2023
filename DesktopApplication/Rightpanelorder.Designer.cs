using System.Windows.Forms;

namespace DesktopApplication
{
    partial class Rightpanelorder
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
            Order3Btn = new Button();
            Order2Btn = new Button();
            Order1Btn = new Button();
            label1 = new Label();
            BackBtn = new Button();
            leftPanel = new Panel();
            rightPanel = new Panel();
            SuspendLayout();
            // 
            // Order3Btn
            // 
            Order3Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Order3Btn.Location = new Point(52, 321);
            Order3Btn.Name = "Order3Btn";
            Order3Btn.Size = new Size(223, 48);
            Order3Btn.TabIndex = 7;
            Order3Btn.Text = "Student, Subject, Teacher";
            Order3Btn.UseVisualStyleBackColor = true;
            Order3Btn.Click += Order3Btn_Click;
            // 
            // Order2Btn
            // 
            Order2Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Order2Btn.Location = new Point(52, 238);
            Order2Btn.Name = "Order2Btn";
            Order2Btn.Size = new Size(223, 48);
            Order2Btn.TabIndex = 6;
            Order2Btn.Text = "Subject, Teacher";
            Order2Btn.UseVisualStyleBackColor = true;
            Order2Btn.Click += Order2Btn_Click;
            // 
            // Order1Btn
            // 
            Order1Btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Order1Btn.Location = new Point(52, 155);
            Order1Btn.Name = "Order1Btn";
            Order1Btn.Size = new Size(223, 48);
            Order1Btn.TabIndex = 5;
            Order1Btn.Text = "Subject, Students";
            Order1Btn.UseVisualStyleBackColor = true;
            Order1Btn.Click += Order1Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 89);
            label1.Name = "label1";
            label1.Size = new Size(222, 33);
            label1.TabIndex = 4;
            label1.Text = "Order List Here";
            // 
            // BackBtn
            // 
            BackBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BackBtn.ImageAlign = ContentAlignment.MiddleLeft;
            BackBtn.Location = new Point(220, 12);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(82, 48);
            BackBtn.TabIndex = 7;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
          
            // Rightpanelorder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(327, 453);
            ControlBox = false;
            Controls.Add(BackBtn);
            Controls.Add(Order3Btn);
            Controls.Add(Order2Btn);
            Controls.Add(Order1Btn);
            Controls.Add(label1);
            
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rightpanelorder";
            Text = "Rightpanelorder";
            ResumeLayout(false);
            PerformLayout();
           

            
        }

        #endregion
        private Panel leftPanel;
        private Panel rightPanel;
        private Button Order3Btn;
        private Button Order2Btn;
        private Button Order1Btn;
        private Label label1;
        private Button BackBtn;
    }
}