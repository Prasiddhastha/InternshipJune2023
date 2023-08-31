

using WindowsApplication.Models;

namespace WindowsApplication
{
    public partial class Form1 : Form
    {
        int id = 0;
        DataContext _context = new DataContext();
        Student student = new();

        public Form1()
        {
            InitializeComponent();
            bindGridView();
        }
        void ClearControls()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            txtAdress.Clear();

        }
        void bindGridView()
        {
            dataGridView1.DataSource = _context.Students.ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            Student newStudent = new()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Age = Convert.ToInt32(txtAge.Text),
                Address = txtAdress.Text
            };
           
            _context.Students.Add(newStudent);
            var affectedRows = _context.SaveChanges();
            if (affectedRows > 0)
            {
                MessageBox.Show("Data Inserted !!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindGridView();
                ClearControls();
            }
            else
            {
                MessageBox.Show("Data Not Inserted !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
           
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            if(int.TryParse(txtAge.Text, out int age))
            {
                student.Age = age;
                student.Address = txtAdress.Text;

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
            else
            {
                MessageBox.Show("Invalid age value. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            student = _context.Students.Where(x => x.Id == id).FirstOrDefault();
            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.LastName;
            txtAge.Text = student.Age.ToString();
            txtAdress.Text = student.Address;
        }

        private void Deletbtn_Click(object sender, EventArgs e)
        {

            DialogResult boxResult = MessageBox.Show("Are You sure You want to delete", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (boxResult == DialogResult.Yes)
            {
                
                _context.Students.Remove(student);
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

        //private void SelectBtn_Click(object sender, EventArgs e)
        //{
        //    var input = Microsoft.VisualBasic.Interaction.InputBox("Enter ID", "Alert", "");
        //    Convert.ToInt32(input);
        //    student = _context.Students.Where(x => x.Id == id).FirstOrDefault();
        //    if (student != null)
        //    {
        //        dataGridView1.DataSource = null;
        //        dataGridView1.DataSource = student;
        //    }

        //}
    }

}