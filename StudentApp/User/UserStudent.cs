

namespace StudentApp
{
    public partial class UserStudent : Form
    {
        int id = 0;
        DataContext _context = new();
        Student _student = new();

        public UserStudent()
        {
            InitializeComponent();
            bindGridView();
            var subjects = _context.Subjects.Select(s => s.SubjectName).ToList();
            cmbSubject.DataSource = subjects;
        }
        void bindGridView()
        {
            var query = from _student in _context.Students1
                        join _subject in _context.Subjects on _student.SubjectId equals _subject.Id
                        select new
                        {
                            _student.Id,
                            _student.Name,
                            _student.Age,
                            _student.Address,
                            _student.Email,
                            Subject = _subject.SubjectName
                        };

            dgvStudent.DataSource = query.ToList();
        }
        void ClearControls()
        {
            studentName.Clear();
            studentAddress.Clear();
            txtEmail.Clear();
            nuDAGe.Value = 0;
            cmbSubject.SelectedItem = null;
            studentPicture.ImageLocation = null;
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = Convert.ToInt32(dgvStudent.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

            var subjclick = _context.Students1.Include(t => t.Subject).Where(x => x.Id == id).FirstOrDefault();
            studentName.Text = subjclick.Name;
            nuDAGe.Value = subjclick.Age;
            cmbSubject.SelectedItem = subjclick.Subject.SubjectName.ToString();
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(studentName.Text) || string.IsNullOrEmpty(cmbSubject.SelectedItem as string) ||
                string.IsNullOrEmpty(studentAddress.Text) || string.IsNullOrEmpty(txtEmail.Text)
                || string.IsNullOrEmpty(studentPicture.ImageLocation) || nuDAGe.Value == 0)
            {
                MessageBox.Show("Field is Empty,Please fill them all.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectedSubj = cmbSubject.SelectedItem as string;
                Subject subject = _context.Subjects.Where(c => c.SubjectName == selectedSubj).FirstOrDefault();
                Student newStudent = new Student
                {
                    Name = studentName.Text,
                    Age = (int)nuDAGe.Value,
                    Subject = subject,
                    Address = studentAddress.Text,
                    Email = txtEmail.Text,
                    ImageUrl = studentPicture.ImageLocation
                };
                _context.Students1.Add(newStudent);
                var affectedRows = _context.SaveChanges();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Thanks For your time. We will contact you through Email.Have a good day.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(studentName.Text) || string.IsNullOrEmpty(cmbSubject.SelectedItem as string) ||
                 string.IsNullOrEmpty(studentAddress.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                 string.IsNullOrEmpty(studentPicture.ImageLocation) || nuDAGe.Value == 0)
            {
                MessageBox.Show("Field is Empty,Please fill them all.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectedSubj = cmbSubject.SelectedItem as string;
                Subject subject = _context.Subjects.Where(c => c.SubjectName == selectedSubj).FirstOrDefault();
                _student = _context.Students1.FirstOrDefault(x => x.Id == id);
                _student.Name = studentName.Text;
                _student.Age = (int)nuDAGe.Value;
                _student.Subject = subject;
                _student.Address = studentAddress.Text;
                _student.Email = txtEmail.Text;
                _student.ImageUrl = studentPicture.ImageLocation;
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
            if (string.IsNullOrEmpty(studentName.Text) || string.IsNullOrEmpty(cmbSubject.SelectedItem as string) ||
                 string.IsNullOrEmpty(studentAddress.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                 string.IsNullOrEmpty(studentPicture.ImageLocation) || nuDAGe.Value == 0)
            {
                MessageBox.Show("Field is Empty,Please fill them all.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult boxResult = MessageBox.Show("Are You sure You want to delete", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (boxResult == DialogResult.Yes)
                {
                    _student = _context.Students1.FirstOrDefault(x => x.Id == id);
                    if (_student != null)
                    {
                        _context.Students1.Remove(_student);
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
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                studentPicture.ImageLocation = imagePath;
                _student.ImageUrl = imagePath;
            }
        }
    }
}
