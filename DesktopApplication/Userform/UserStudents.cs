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
    public partial class UserStudents : Form
    {
        int id = 0;
        DataContext _context = new();
        Student _student = new();
       
        public UserStudents()
        {
            InitializeComponent();
            bindGridView();
        }
        void bindGridView()
        {
            var query = from _student in _context.Students1
                        join _subject in _context.Subjects on _student.SubjectId equals _subject.Id
                        select new
                        {
                            _student.Id,
                            _student.Name,
                            Subject = _subject.SubjectName
                        };

            dgvStudent.DataSource = query.ToList();
        }
        void ClearControls()
        {
            studentName.Clear();
            subName1.Clear();
        }
        private void dgvStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(dgvStudent.SelectedRows[0].Cells[0].Value);
            _student = _context.Students1.Include(t => t.Subject).FirstOrDefault(x => x.Id == id);
            studentName.Text = _student.Name;
            subName1.Text = _student.Subject.SubjectName.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var subjectName = subName1.Text;
            Subject subject = _context.Subjects.FirstOrDefault(s => s.SubjectName == subjectName);
            if (subject != null)
            {
                Student newStudent = new Student
                {
                    Name = studentName.Text,
                    Subject = subject
                };

                _context.Students1.Add(newStudent);
                var affectedRows = _context.SaveChanges();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Data Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindGridView();
                }
                else
                {
                    MessageBox.Show("Data Not Inserted!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Subject Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var subjectName = subName1.Text;
            Subject subject = _context.Subjects.FirstOrDefault(s => s.SubjectName == subjectName);
            if (subject != null)
            {

                _student.Name = studentName.Text;
                _student.Subject = subject;


                var affectedRows = _context.SaveChanges();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Data Updated !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindGridView();
                }
                else
                {
                    MessageBox.Show("Data Not Updated !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Subject Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (_student != null)
            {
                DialogResult boxResult = MessageBox.Show("Are You sure You want to delete", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (boxResult == DialogResult.Yes)
                {

                    _context.Students1.Remove(_student);
                    var affectedRows = _context.SaveChanges();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Data Deleted !!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindGridView();

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
            else

            {
                MessageBox.Show("No Teacher Selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
