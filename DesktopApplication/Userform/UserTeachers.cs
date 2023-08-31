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

namespace DesktopApplication
{
    public partial class UserTeachers : Form
    {
        int id = 0;
        DataContext _context = new();
        Teacher _teacher = new();
        public UserTeachers()
        {
            InitializeComponent();
            bindGridView();
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
            subName1.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var subjectName = subName1.Text;
            Subject subject = _context.Subjects.FirstOrDefault(s => s.SubjectName == subjectName);
            if (subject != null)
            {
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

                _teacher.TeacherName = teachName.Text;
                _teacher.Address = teachAddress.Text;
                _teacher.Subject = subject;


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

        private void dvgTeachers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(dvgTeachers.SelectedRows[0].Cells[0].Value);
            _teacher = _context.Teachers.Include(t => t.Subject).FirstOrDefault(x => x.Id == id);
            teachName.Text = _teacher.TeacherName;
            teachAddress.Text = _teacher.Address;
            subName1.Text = _teacher.Subject.SubjectName.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_teacher.TeacherName != null)
            {
                DialogResult boxResult = MessageBox.Show("Are You sure You want to delete", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (boxResult == DialogResult.Yes)
                {
                    _context.Teachers.Remove(_teacher);
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
