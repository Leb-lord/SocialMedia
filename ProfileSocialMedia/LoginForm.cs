using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileSocialMedia
{
    public partial class LoginForm : Form
    {
        DataBase connection = new DataBase();
        TextBox userName, password;
        Label message;

        public LoginForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkExistence()) {
                UserProfileForm form= new UserProfileForm();
                form.setUserName(userName.Text);
                form.Show();
               

            }
            else
            {
                MessageBox.Show("User name or Password incorrect"); 
            }
            
        }

        private void newAccount_Click(object sender, EventArgs e)
        {
            newAccount account= new newAccount();
            account.Show();

        }

        private bool checkExistence()
        {
            
            string user = userName.Text;
            string pass = password.Text;
            SqlConnection conn = connection.Connect();

            if (conn.State != ConnectionState.Open)
             {
                    conn.Open();
             }

                string query = "SELECT COUNT(*) FROM loginData WHERE userName = @UserName AND password = @Password";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@UserName", user);
                        command.Parameters.AddWithValue("@Password", pass);

                        int count = (int)command.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false; // Return false indicating an error occurred
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            
        }

    }
}
