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
    public partial class newAccount : Form
    {
        DataBase connection = new DataBase();
        public newAccount()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = connection.Connect();
            if (fullName.Text == "" || userName.Text == "" || password.Text == "")
            {
                MessageBox.Show("You need to fully all empty fields");

            }
            else
            {
                if (checkExistence() != 0)
                {
                    MessageBox.Show("Your Account Creation Success!");
                }
                MessageBox.Show("User Name Already Exists!");
            }
        }


        private int checkExistence()
        {
            string user = userName.Text;
            string pass = password.Text;
            string fName = fullName.Text;
            {
                using (SqlConnection con = connection.Connect())
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    try
                    {
                        string selectQuery = "SELECT COUNT(userName) FROM loginData WHERE userName = @user";
                        using (SqlCommand selectCmd = new SqlCommand(selectQuery, con))
                        {
                            selectCmd.Parameters.AddWithValue("@user", user);
                            int count = (int)selectCmd.ExecuteScalar();
                            if (count == 0)
                            {
                                string insertQuery = "INSERT INTO loginData (userName, password, fullName) VALUES (@user, @pass, @fName)";
                                using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                                {
                                    insertCmd.Parameters.AddWithValue("@user", user);
                                    insertCmd.Parameters.AddWithValue("@pass", pass);
                                    insertCmd.Parameters.AddWithValue("@fName", fName);
                                    insertCmd.ExecuteNonQuery();
                                    return 1; // Indicates successful insertion
                                }
                            }
                            return 0;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex; // Propagate the exception for handling elsewhere
                                  // return -1; // Consider returning a specific error code instead of -1
                    }
                }
            }

        }
    }
}
