using StudentLatesCSV1;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class FormLogIn : Form
    {

        bool login = false;
        string username = "";
        string password = "";
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            username = txtUser.Text;
            Hashing(txtPass.Text);
          

            clsDBConnector dbConnector = new clsDBConnector();
            //stuck


            if (login == true)
            {

                FormCfiMenu.Username = username;
            }
            else
            { 
            
            
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
