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
    public partial class FormCfiMenu : Form
    {

        public string Username {  get; set; }  //tom ballantine special
        public FormCfiMenu(string strUser)
        {
            InitializeComponent();
            Username = strUser;
        }

        private void FormCfiMenu_Load(object sender, EventArgs e)
        {
           nameLabel(sender);
            lstBookingFill();
        }

        private void lstBookingFill()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = $"SELECT DateandTime, StudentID, Duration FROM Bookings WHERE InstructorID = {Convert.ToInt32(Username)}";
            dr = dbConnector.DoSQL(sqlStr);
            lstBookings.Items.Clear();
            while (dr.Read())
            {
                DateTime BookingTime = Convert.ToDateTime(dr[0]);
                lstBookings.Items.Add(BookingTime.ToString("dd-MM-yyy mm:ss"));
                lstBookings.Items[lstBookings.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstBookings.Items[lstBookings.Items.Count - 1].SubItems.Add(dr[2].ToString());
            }
            dbConnector.Close();
        }
        

        private void nameLabel(object sender)
        {
            clsDBConnector dBConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sql = $"SELECT FirstName FROM instructors WHERE UserID = {Username}";
            dBConnector.Connect();
            dr = dBConnector.DoSQL(sql);
            while (dr.Read())
            {
                lblName.Text = " Hello " + dr[0].ToString();
            }
            dBConnector.Close();
        }

    }
}
