namespace DesktopApplication
{
    partial class Order2
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
            dgvOrder2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOrder2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 25);
            label1.Name = "label1";
            label1.Size = new Size(271, 30);
            label1.TabIndex = 5;
            label1.Text = "Order By Database";
            // 
            // dgvOrder2
            // 
            dgvOrder2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder2.Location = new Point(12, 74);
            dgvOrder2.Name = "dgvOrder2";
            dgvOrder2.RowTemplate.Height = 25;
            dgvOrder2.Size = new Size(431, 394);
            dgvOrder2.TabIndex = 4;
            // 
            // Order2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(455, 492);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(dgvOrder2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order2";
            Text = "Order2";
            ((System.ComponentModel.ISupportInitialize)dgvOrder2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvOrder2;
    }
}