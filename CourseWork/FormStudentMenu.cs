using StudentLatesCSV1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormStudentMenu : Form
    {
        int studentID;
        public FormStudentMenu(int studentID)
        {
            InitializeComponent();
            this.studentID = studentID;
        }

        private void FormStudentMenu_Load(object sender, EventArgs e)
        {
            fillLabel(); // test sending the button id through



        }

        private void fillLabel()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string cmdString = $"SELECT FirstName & ' ' & LastName AS Name FROM Students WHERE StudentId = {studentID}";

            dbConnector.Connect();
            dr = dbConnector.DoSQL(cmdString);

            while (dr.Read())
            {
                label1.Text = " Hello " + dr["Name"].ToString();

            }
            dbConnector.Close();
        }
    }
}
