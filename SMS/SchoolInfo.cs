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
    public partial class SchoolInfo : Form
    {
        public SchoolInfo()
        {
            InitializeComponent();
        }

        private void SchoolInfo_Load(object sender, EventArgs e)
        {
            txtSchoolName.Text = "Amnil Technologies";
            txtAddress.Text = "Jhamsikhel, Lalitpur";
            txtEmail.Text = "info@amniltech.com";
            txtTelephone.Text = "9842855484";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
