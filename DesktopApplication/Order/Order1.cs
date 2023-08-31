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
    public partial class Order1 : Form
    {
        DataContext _context = new();
        Student _student;
        public Order1()
        {
            InitializeComponent();
            bindGridView();
        }
        void bindGridView()
        {
            var query = from student in _context.Students1
                        join teacher in _context.Teachers on student.Subject.Id equals teacher.SubjectId
                        join subject in _context.Subjects on student.Subject.Id equals subject.Id
                        orderby subject.SubjectName, student.Name
                        group teacher by new { student.Name, subject.SubjectName } into grp
                        select new
                        {
                            grp.Key.Name,
                            grp.Key.SubjectName,
                            Teachers = grp.Select(t => t.TeacherName)
                        };
            var groupedData = query.ToList();
            var modifiedData = groupedData.Select(g => new
            {
                StudentName = g.Name,
                Subject = g.SubjectName,
                TaughtBy = string.Join(", ", g.Teachers.OrderBy(t => t))
            }).ToList();

            dgvOrder1.DataSource = modifiedData ;
        }
    }
}
