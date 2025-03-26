using StudentLatesCSV1;
using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormLogInStu : Form
    {

        public FormLogInStu()
        {
            InitializeComponent();
        }

        private void FormLogInStu_Load(object sender, EventArgs e)
        {
            DarkMode.Apply(this);
            DynamicButtons();
        }

        private void DynamicButtons()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string cmdString = $"SELECT StudentId, FirstName & ' ' & LastName AS Name FROM Students";

            dbConnector.Connect();
            dr = dbConnector.DoSQL(cmdString);

            while (dr.Read())
            {
                Button button = new Button();
                flowLayoutPanel1.Controls.Add(button);
                button.Text = dr["Name"].ToString();
                button.Name = dr["StudentId"].ToString();
                button.Click += DynamicButton_Click;
                DarkMode.Apply(button);


            }
            dbConnector.Close();
        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            Button Pressed = sender as Button;


            FormStudentMenu formStudentMenu = new FormStudentMenu(Convert.ToInt32(Pressed.Name));
            formStudentMenu.Show();

        }


    }
}
