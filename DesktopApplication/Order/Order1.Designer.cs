namespace DesktopApplication
{
    partial class Order1
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
            dgvOrder1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrder1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 25);
            label1.Name = "label1";
            label1.Size = new Size(271, 30);
            label1.TabIndex = 3;
            label1.Text = "Order By Database";
            // 
            // dgvOrder1
            // 
            dgvOrder1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder1.Location = new Point(12, 74);
            dgvOrder1.Name = "dgvOrder1";
            dgvOrder1.RowTemplate.Height = 25;
            dgvOrder1.Size = new Size(431, 394);
            dgvOrder1.TabIndex = 2;
            // 
            // Order1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(455, 492);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(dgvOrder1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order1";
            Text = "Order1";
            ((System.ComponentModel.ISupportInitialize)dgvOrder1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvOrder1;
    }
}