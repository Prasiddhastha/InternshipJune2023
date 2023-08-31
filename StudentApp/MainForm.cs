namespace StudentApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelDataSubmenu.Visible = false;
        }
        private void HideSubMenu()
        {
            if (panelDataSubmenu.Visible == true)
            {
                panelDataSubmenu.Visible = false;
            }
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void orderByBtn_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelDataSubmenu);
            OpenChildForm(new DataOrderby());
        }

        #region DataSubMenu
        private void Order1Btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Order1());

        }


        #endregion

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelForm.Controls.Add(childForm);
            panelForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void subjAddBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserSubject());
        }

        private void studentAddBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserStudent());
        }

        private void teachAddBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserTeacher());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            activeForm.Close();
        }
    }
}