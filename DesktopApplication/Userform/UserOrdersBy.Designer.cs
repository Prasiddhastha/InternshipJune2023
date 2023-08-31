namespace DesktopApplication
{
    partial class UserOrdersBy
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
            dgvOrderby = new DataGridView();
            label1 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOrderby).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderby
            // 
            dgvOrderby.AllowUserToAddRows = false;
            dgvOrderby.AllowUserToDeleteRows = false;
            dgvOrderby.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderby.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderby.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvOrderby.Location = new Point(12, 90);
            dgvOrderby.Name = "dgvOrderby";
            dgvOrderby.ReadOnly = true;
            dgvOrderby.RowTemplate.Height = 25;
            dgvOrderby.Size = new Size(431, 394);
            dgvOrderby.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 37);
            label1.Name = "label1";
            label1.Size = new Size(271, 30);
            label1.TabIndex = 1;
            label1.Text = "Order By Database";
            // 
            // Column1
            // 
            Column1.HeaderText = "StudentName";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Subject";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Taughtby";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // UserOrdersBy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(455, 492);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(dgvOrderby);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserOrdersBy";
            Text = "UserOrdersBy";
            ((System.ComponentModel.ISupportInitialize)dgvOrderby).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderby;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}