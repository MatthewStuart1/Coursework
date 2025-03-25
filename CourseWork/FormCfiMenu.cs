using StudentLatesCSV1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormCfiMenu : Form
    {

        public string Username {  get; set; }  //tom ballantine special
        public FormCfiMenu()
        {
            InitializeComponent();
        }

        private void FormCfiMenu_Load(object sender, EventArgs e)
        {
            nameLabel(sender);
        }

        private void nameLabel(object sender)
        {

            clsDBConnector dBConnector = new clsDBConnector();

            string sql = $"SELECT FirstName FROM instructors WHERE Username = '{sender.ToString()}'";
            dBConnector.Connect();
            lblName.Text =dBConnector.DoSQL(sql).ToString();
            dBConnector.Close();
           

        }
    }
}
