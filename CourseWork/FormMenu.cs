using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            DarkMode.Apply(this);
        }


        private void FormMenu_Load(object sender, EventArgs e)
        {


        }


        private void ImgSettings_Click(object sender, EventArgs e)
        {
            FormSettings formSettings = new FormSettings();
            formSettings.Show();
        }

        private void MbcLogs_Click(object sender, EventArgs e)
        {
            FormLogsMenu formLogsMenu = new FormLogsMenu();
            formLogsMenu.Show();
        }

        private void MbcInstructor_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
        }

        private void MbcStudent_Click(object sender, EventArgs e)
        {
            FormStudentMenu formStudentMenu = new FormStudentMenu();
            formStudentMenu.Show();
        }

        private void MbcAircraft_Click(object sender, EventArgs e)
        {
            FormAircraftMenu formAircraftMenu = new FormAircraftMenu();
            formAircraftMenu.Show();
        }
    }
}
