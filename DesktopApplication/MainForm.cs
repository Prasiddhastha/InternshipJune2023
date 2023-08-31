namespace DesktopApplication
{
    public partial class StudentManage : Form
    {

        UserSubjects userSubject = new();
        UserTeachers userTeachers = new();
        UserStudents userStudents = new();
        UserOrdersBy userOrdersBy = new();
        Rightpanelorder userRightOrder;


        public StudentManage()
        {
            InitializeComponent();

        }

        private void subjAddBtn_Click(object sender, EventArgs e)
        {

            userSubject.TopLevel = false;
            LeftPanel.Controls.Add(userSubject);
            userSubject.BringToFront();
            userSubject.Show();
            smallpic.BringToFront();
            smallpic.Visible = true;


        }

        private void teachAddBtn_Click(object sender, EventArgs e)
        {
            userTeachers.TopLevel = false;
            LeftPanel.Controls.Add(userTeachers);
            userTeachers.BringToFront();
            userTeachers.Show();
            smallpic.BringToFront();
            smallpic.Visible = true;


        }

        private void studentAddBtn_Click(object sender, EventArgs e)
        {
            userStudents.TopLevel = false;
            LeftPanel.Controls.Add(userStudents);
            userStudents.BringToFront();
            userStudents.Show();
            smallpic.BringToFront();
            smallpic.Visible = true;


        }

        private void orderByBtn_Click(object sender, EventArgs e)
        {
            userOrdersBy.TopLevel = false;
            LeftPanel.Controls.Add(userOrdersBy);
            userOrdersBy.BringToFront();
            userOrdersBy.Show();

            userRightOrder = new Rightpanelorder(LeftPanel, RightPanel);
            userRightOrder.TopLevel = false;
            RightPanel.Controls.Add(userRightOrder);
            userRightOrder.BringToFront();
            userRightOrder.Show();
        }
    }
}