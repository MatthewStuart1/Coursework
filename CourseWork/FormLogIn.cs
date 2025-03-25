using StudentLatesCSV1;
using System;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int username = txtUser.Text;
            string hashtext = Hashing(txtPass.Text);

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string cmdString = $"SELECT PasswordHash FROM Instructors WHERE Username = '{username}'";
            dbConnector.Connect();

            dr = dbConnector.DoSQL(cmdString);
            dr.Read();
            if (dr["passwordhash"] == hashtext)
            {

                FormCfiMenu formCfiMenu = new FormCfiMenu();
                username = Convert.ToInt32(txtUser.Text);
                formCfiMenu.Show();

            }
            else
            {
                MessageBox.Show("failed to Sign In; +" +
                    "Please Try Again");

                txtPass.Clear();
                txtUser.Clear();
            }
        }

        private string Hashing(string plaintextPassword)
        {
            //https://stackoverflow.com/questions/3984138/hash-string-in-c-sharp
            string hashtext = "";
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(plaintextPassword);
                byte[] hashedbytes = sha256Hash.ComputeHash(bytes);

                for (int i = 0; i < hashedbytes.Length; i++)
                {
                    string hexhash = hashedbytes[i].ToString("x2"); //x is for hex, 2 forces it to be 2 chars
                    hashtext += hexhash;
                    // += adds to the string (each hex result gets added into the string)
                }
                return hashtext;
            }

        } // returns SHA 256 hash of plaintextPassword
    }
}
