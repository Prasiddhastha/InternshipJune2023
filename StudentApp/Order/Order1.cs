

namespace StudentApp
{
    public partial class Order1 : Form
    {
        int id;
        DataContext _context = new();
        bool isAscending = true;

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
                        orderby subject.SubjectName, student.Name ascending
                        group teacher by new { subject.SubjectName, student.Name } into grp
                        select new
                        {
                            grp.Key.Name,
                            grp.Key.SubjectName,
                            Teachers = grp.Select(t => t.TeacherName)
                        };

            if (!isAscending)
            {
                query = query.OrderByDescending(g => g.SubjectName).ThenByDescending(g => g.Name);
            }

            var groupedData = query.ToList();
            var modifiedData = groupedData.Select(g => new
            {
                StudentName = g.Name,
                Subject = g.SubjectName,
                TaughtBy = string.Join(", ", g.Teachers.OrderBy(t => t))
            }).ToList();

            dgvOrder1.DataSource = modifiedData;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            isAscending = !isAscending;
            bindGridView();
        }

        private void dgvOrder1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrder1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string subjectName = dgvOrder1.Rows[e.RowIndex].Cells[1].Value.ToString();
                var subjclick = _context.Students1.Include(t => t.Subject).FirstOrDefault(x => x.Subject.SubjectName == subjectName);
                if (subjclick != null)
                {
                    studentName.Text = subjclick.Name;
                    nuDAGe.Value = subjclick.Age;
                    txtSubject.Text = subjclick.Subject.SubjectName.ToString();
                    studentAddress.Text = subjclick.Address;
                    txtEmail.Text = subjclick.Email;
                    if (!string.IsNullOrEmpty(subjclick.ImageUrl))
                    {
                        studentPicture.ImageLocation = subjclick.ImageUrl;
                    }
                    else
                    {
                        studentPicture.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Student not found for the selected subject!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
