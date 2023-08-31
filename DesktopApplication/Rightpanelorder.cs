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
    public partial class Rightpanelorder : Form
    {

        UserOrdersBy _userOrdersBy = new();
        Order1 _order1 = new Order1();
        Order2 _order2 = new Order2();
        Order3 _order3 = new Order3();


        public Rightpanelorder(Panel leftPanel, Panel rightPanel)
        {
            InitializeComponent();
            this.leftPanel = leftPanel;
            this.rightPanel = rightPanel;

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        private void Order1Btn_Click(object sender, EventArgs e)
        {
           
            _order1.TopLevel = false;


           leftPanel.Controls.Add(_order1);
            _order1.BringToFront();
            _order1.Show();

        }

        private void Order2Btn_Click(object sender, EventArgs e)
        {
           
            _order2.TopLevel = false;


            leftPanel.Controls.Add(_order2);
            _order2.BringToFront();
            _order2.Show();
        }

        private void Order3Btn_Click(object sender, EventArgs e)
        {
          
            _order3.TopLevel = false;


            leftPanel.Controls.Add(_order3);
            _order3.BringToFront();
            _order3.Show();
        }
    }
}
