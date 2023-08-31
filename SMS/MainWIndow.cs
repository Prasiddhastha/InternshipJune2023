using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class MainWIndow : Form
    {
        public MainWIndow()
        {
            InitializeComponent();
        }

        private void btnSchoolInfo_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SchoolInfo schoolInfo = new();
            schoolInfo.ShowDialog();
            //schoolInfo.Show();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects();
            subjects.ShowDialog();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.ShowDialog();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {

        }
    }
}
