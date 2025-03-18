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
    }
}
