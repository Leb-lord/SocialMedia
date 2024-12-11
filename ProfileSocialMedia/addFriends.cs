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
    public partial class addFriends : Form
    {
        DataBase connection = new DataBase();
        private static String userName = "";
        public addFriends()
        {
            InitializeComponent();
            listBox1.Hide();
            flowLayoutPanel1.Hide();   
        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            getPeopleCommunity();
        }
        private void FollowButtonClick(object sender, EventArgs e)
        {
            Button followButton = sender as Button;
            string communityName = followButton.Tag.ToString();
            insertNewFriend(followButton, communityName);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Identity identity = new Identity();
            identity.setUserName(listBox1.SelectedItem.ToString());
            identity.Show();
        }

        public void setUserName(string user)
        {
            userName = user;
            getPeopleCommunity();
        }
        private void getPeopleCommunity()
        {
            listBox1.Items.Clear();
            flowLayoutPanel1.Controls.Clear();

            String nameText = textBox1.Text.Trim().ToLower();

            using (SqlConnection con = connection.Connect())
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                if (nameText == "")
                {
                    string getAll = "SELECT name FROM community WHERE name != @userName AND NOT EXISTS (SELECT 1 FROM profileData WHERE userName = @userName AND followingName = community.name)";
                    using (SqlCommand command = new SqlCommand(getAll, con))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string communityName = reader["name"].ToString();
                                listBox1.Items.Add(communityName);
                                CreateFollowButton(communityName);
                            }
                        }
                    }
                }
                else
                {
                    string query = "SELECT name FROM community WHERE name = @nameText and  name != @userName AND NOT EXISTS (SELECT 1 FROM profileData WHERE userName = @userName AND followingName = community.name) ";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("userName", userName);
                        command.Parameters.AddWithValue("@nameText", nameText);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string communityName = reader["name"].ToString();
                                listBox1.Items.Add(communityName);
                                CreateFollowButton(communityName);
                            }
                        }
                    }
                }
            }

            listBox1.Show();
            flowLayoutPanel1.Show();
        }

        private void CreateFollowButton(string communityName)
        {
            Button button = new Button();
            button.Tag = communityName;
            button.Text = "Follow";
            button.ForeColor = Color.White;
            button.Click += FollowButtonClick; // Attach event handler for button click
            button.Font = new Font("Segoe Script", 12);
            // Add button to the form's controls
            flowLayoutPanel1.Controls.Add(button);
        }



        private void insertNewFriend(Button followButton, string communityName)
        {
            try
            {
                using (SqlConnection con = connection.Connect())
                {
                    if (con.State != ConnectionState.Open) { con.Open(); }

                    // Construct the first query to insert following data
                    string query = "INSERT INTO profileData (followingName, userName, picture) " +
                                   "VALUES (@communityName, @userName, (SELECT picture FROM loginData WHERE userName = @communityName))";

                    // Construct the second query to insert follower data
                    string query1 = "INSERT INTO profileData (followersName, userName, picture) " +
                                    "VALUES (@userName, @communityName, (SELECT picture FROM loginData WHERE userName = @communityName))";

                    using (SqlCommand command = new SqlCommand(query, con))
                    using (SqlCommand command1 = new SqlCommand(query1, con))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@communityName", communityName);

                        command1.Parameters.AddWithValue("@userName", userName);
                        command1.Parameters.AddWithValue("@communityName", communityName);

                        // Execute the first command to insert following data
                        int rowsAffected = command.ExecuteNonQuery();

                        // If insertion successful, execute second command and disable followButton
                        if (rowsAffected > 0)
                        {
                            command1.ExecuteNonQuery();
                            followButton.Enabled = false;
                            getPeopleCommunity();
                        }
                        else
                        {
                            // Follow action failed
                            MessageBox.Show("Failed to follow the community.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


    }
}
