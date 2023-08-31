using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApplication
{
    public partial class UserSubjects : Form
    {
        int id = 0;
        DataContext _context = new();
        Subject _subject = new();
        public UserSubjects()
        {
            InitializeComponent();
            bindGridView();
        }
        void bindGridView()
        {
            dgvSubject.DataSource = _context.Subjects.ToList();
        }
        void ClearControls()
        {
            txtSubject.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var subjectName = txtSubject.Text.Trim();
            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("--Subject Name Require--.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Subject newSubject = new()
            {
                SubjectName = txtSubject.Text,
            };

            _context.Subjects.Add(newSubject);
            var affectedRows = _context.SaveChanges();
            if (affectedRows > 0)
            {
                MessageBox.Show("Data Inserted !!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindGridView();
            }
            else
            {
                MessageBox.Show("Data Not Inserted !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var subjectName = txtSubject.Text.Trim();
            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Please fill in the subject name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _subject.Id = id;
            _subject.SubjectName = txtSubject.Text;

            var affectedRows = _context.SaveChanges();
            if (affectedRows > 0)
            {
                MessageBox.Show("Data Updated !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindGridView();
                ClearControls();
            }
            else
            {
                MessageBox.Show("Data Not Updated !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvSubject_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells[0].Value);
            _subject = _context.Subjects.Where(x => x.Id == id).FirstOrDefault();
            txtSubject.Text = _subject.SubjectName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var subjectName = txtSubject.Text.Trim();
            if (string.IsNullOrEmpty(subjectName))
            {
                MessageBox.Show("Please fill in the subject name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult boxResult = MessageBox.Show("Are You sure You want to delete", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (boxResult == DialogResult.Yes)
            {
                _subject.Id = id;
                _context.Subjects.Remove(_subject);
                var affectedRows = _context.SaveChanges();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Data Deleted !!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindGridView();
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Data Not Deleted !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Delete operation Cancelled.", "Message");
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

  
    }
}
