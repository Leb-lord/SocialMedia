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
using System.Xml.Linq;

namespace ProfileSocialMedia
{
    public partial class removeFriends : Form
    {
        DataBase connection = new DataBase();
        static String userName = "";
        public removeFriends()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            getAllFollowing();
        }


        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            string name = listBox1.SelectedItem.ToString();
            removeFromDataBase(name);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void removeFromDataBase(String name)
        {
            SqlConnection con = connection.Connect();
            if (con.State != ConnectionState.Open) { con.Open(); }
            String query = "delete from profileData where followingName= @name and userName=@userName";
            String query1 = "delete from profileData where followersName=@userName and userName=@name";
            using (SqlCommand cmd = new SqlCommand(query1, con))
            using (SqlCommand command = new SqlCommand(query, con))
            {

                command.Parameters.AddWithValue("userName", userName);
                command.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("@userName", userName);
                command.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
                getAllFollowing();
            }
            con.Close();
        }




        public void setUserName (string user)
        {
            userName=user;
            getAllFollowing();
        }

        private void getAllFollowing()
        {
            listBox1.Items.Clear();
            String name = textBox1.Text.Trim();
            SqlConnection con = connection.Connect();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            string query = "SELECT followingName FROM profileData WHERE followingName = @name and userName=@userName";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@userName", userName);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string followingNm = reader["followingName"].ToString();
                        // Add the community name to the list
                        listBox1.Items.Add(followingNm);

                    }
                }
            }
            if (textBox1.Text.Trim() == "")
            {
                listBox1.Items.Clear();
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                string query1 = "SELECT followingName FROM profileData where followingName is not null and userName = @userName ";
                using (SqlCommand command = new SqlCommand(query1, con))
                {
                    command.Parameters.AddWithValue("@userName", userName);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string followingName = reader["followingName"].ToString();
                        listBox1.Items.Add(followingName);

                    }

                }
            }
            con.Close();
        }

    }
}
