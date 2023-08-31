using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class UserTeacher : Form
    {
        int id = 0;
        DataContext _context = new();
        Teacher _teacher = new();
        public UserTeacher()
        {
            InitializeComponent();
            bindGridView();
            var subjects = _context.Subjects.Select(s => s.SubjectName).ToList();
            cmbSubject.DataSource = subjects;
        }
        void bindGridView()
        {
            var query = from _teacher in _context.Teachers
                        join _subject in _context.Subjects on _teacher.SubjectId equals _subject.Id
                        select new
                        {
                            _teacher.Id,
                            _teacher.TeacherName,
                            _teacher.Address,
                            Subject = _subject.SubjectName
                        };

            dvgTeachers.DataSource = query.ToList();
        }
        void ClearControls()
        {
            teachName.Clear();
            teachAddress.Clear();
            cmbSubject.SelectedItem = null;
        }
        private void dvgTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgTeachers.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = Convert.ToInt32(dvgTeachers.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            var subjclick = _context.Teachers.Include(t => t.Subject).Where(x => x.Id == id).FirstOrDefault();
            teachName.Text = subjclick.TeacherName;
            teachAddress.Text = subjclick.Address;
            cmbSubject.SelectedItem = subjclick.Subject.SubjectName.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teachName.Text) || string.IsNullOrEmpty(cmbSubject.SelectedItem as string) || string.IsNullOrEmpty(teachAddress.Text))
            {
                MessageBox.Show("Field is Empty,Please fill them all.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectedSubj = cmbSubject.SelectedItem as string;
                Subject subject = _context.Subjects.Where(c => c.SubjectName == selectedSubj).FirstOrDefault();
                Teacher newTeacher = new Teacher
                {
                    TeacherName = teachName.Text,
                    Address = teachAddress.Text,
                    Subject = subject
                };
                _context.Teachers.Add(newTeacher);
                var affectedRows = _context.SaveChanges();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Data Inserted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindGridView();
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Data Not Inserted!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teachName.Text) || string.IsNullOrEmpty(cmbSubject.SelectedItem as string) || string.IsNullOrEmpty(teachAddress.Text))
            {
                MessageBox.Show("Field is Empty,Please fill them all.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectedSubj = cmbSubject.SelectedItem as string;
                Subject subject = _context.Subjects.Where(c => c.SubjectName == selectedSubj).FirstOrDefault();
                _teacher = _context.Teachers.FirstOrDefault(x => x.Id == id);
                _teacher.TeacherName = teachName.Text;
                _teacher.Address = teachAddress.Text;
                _teacher.Subject = subject;
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(teachName.Text) || string.IsNullOrEmpty(cmbSubject.SelectedItem as string) || string.IsNullOrEmpty(teachAddress.Text))
            {
                MessageBox.Show("Field is Empty,Please fill them all.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DialogResult boxResult = MessageBox.Show("Are You sure You want to delete", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (boxResult == DialogResult.Yes)
            {
                //_context.Entry(_subject).State = EntityState.Detached;

                _teacher = _context.Teachers.FirstOrDefault(x => x.Id == id);
                if (_teacher != null)
                {
                    _context.Teachers.Remove(_teacher);
                    var affectedRows = _context.SaveChanges();

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Data Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindGridView();
                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("Data Not Deleted!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
