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
    public partial class UserOrdersBy : Form
    {
        DataContext _context = new();
        public UserOrdersBy()
        {
            InitializeComponent();
            //bindGridView();
        }
        //void bindGridView()
        //{
        //    var query = from student in _context.Students1
        //                join teacher in _context.Teachers on student.Subject.Id equals teacher.SubjectId
        //                join subject in _context.Subjects on student.Subject.Id equals subject.Id
        //                select new
        //                {
        //                    StudentName = student.Name,
        //                    Subject = subject.SubjectName,
        //                    Taughtby = teacher.TeacherName
        //                };

        //    dgvOrderby.DataSource = query.ToList(); ;
        //}
    }
}
