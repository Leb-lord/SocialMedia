using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProfileSocialMedia
{
    public partial class followingFollowers : Form
    {
        private static String userName;
        private readonly DataBase connection = new DataBase();
        private bool followingFetched = false;
        private bool followersFetched = false;

        public followingFollowers()
        {
            InitializeComponent();
            InitializeListView();

        }

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("People", this.Width);
        }


        private void followingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FetchFollowingData(userName);
        }

        private void followersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FetchFollowersData(userName);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setUserName(String user)
        {
            userName = user;
            FetchFollowingData(user);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedUserName = listView1.SelectedItems[0].Text;
                Identity identity = new Identity();
                identity.setUserName(selectedUserName);
                identity.Show();
            }
        }
        private void FetchFollowingData(String user )
        {
            if (!followingFetched)
            {
                try
                {
                    listView1.Items.Clear();
                    ImageList list = new ImageList();

                    using (SqlConnection con = connection.Connect())
                    using (SqlCommand command = con.CreateCommand())
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.CommandText = "SELECT followingName, followersName, picture FROM profileData WHERE followingName IS NOT NULL and userName=@user";
                        command.Parameters.AddWithValue("@user", user);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string followingName = reader["followingName"].ToString();
                                string followers = reader["followersName"].ToString();

                                if (reader["picture"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["picture"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        Image image = Image.FromStream(ms);
                                        list.ImageSize = new Size(image.Width, image.Height);
                                        list.Images.Add(image);
                                        string itemText = (followers == followingName) ? $"{followingName} (He Follows You)" : followingName;
                                        listView1.SmallImageList = list;
                                        listView1.Items.Add(itemText, 0);
                                    }
                                }
                            }
                        }
                    }
                    followingFetched = true;
                    followersFetched = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FetchFollowersData(String user)
        {
            if (!followersFetched)
            {
                try
                {
                    listView1.Items.Clear();
                    ImageList list = new ImageList();

                    using (SqlConnection con = connection.Connect())
                    using (SqlCommand command = con.CreateCommand())
                    {

                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }
                        command.CommandText = "SELECT followersName, picture FROM profileData WHERE followersName IS NOT NULL and userName=@user";
                        command.Parameters.AddWithValue("@user", user);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string followers = reader["followersName"].ToString();

                                if (reader["picture"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["picture"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        Image image = Image.FromStream(ms);
                                        list.ImageSize = new Size(image.Width, image.Height);
                                        list.Images.Add(image);
                                        string itemText = followers;
                                        listView1.SmallImageList = list;
                                        listView1.Items.Add(itemText, 0);
                                    }
                                }
                            }
                        }
                    }
                    followersFetched = true;
                    followingFetched = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}

