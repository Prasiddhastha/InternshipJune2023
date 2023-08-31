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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

        int sn = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvSubjects.Rows.Add(++sn, txtSubject.Text);
        }
    }
}
