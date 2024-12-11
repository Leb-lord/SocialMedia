using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileSocialMedia
{
    public partial class UserProfileForm : Form
    {
        Label userName;
        DataBase connection = new DataBase();

        public UserProfileForm()
        {
            InitializeComponent();

        }

        private void UserProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(pictureBox2, 0 - contextMenuStrip1.Width, 0);
        }

        private void followersnb_Click(object sender, EventArgs e)
        {
            followingFollowers form3 = new followingFollowers();
            form3.setUserName(userName.Text);
            form3.Show();
        }

        private void followNewFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFriends form4 = new addFriends();
            form4.setUserName(userName.Text);
            form4.Show();
        }

        private void removeFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFriends form5 = new removeFriends();
            form5.setUserName(userName.Text);
            form5.Show();
        }

        private void followingnb_Click(object sender, EventArgs e)
        {
            followingFollowers form3 = new followingFollowers();
            form3.setUserName(userName.Text);
            form3.Show();

        }

        public void setUserName(string user)
        {
            userName.Text = user;
            setData(userName.Text);

        }


        private void setData(String user)
        {
            SqlConnection con = connection.Connect();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            String getFollowing = "select count(followingName) from profileData where followingName is not null and userName=@user ";
            using (SqlCommand comand1 = new SqlCommand(getFollowing, con))
            {
                comand1.Parameters.AddWithValue("@user", user);
                int nbFollowing = (int)comand1.ExecuteScalar();
                followingnb.Text = nbFollowing.ToString();
            }
            String getFollowers = "select count(followersName) from profileData where followersName is not null and userName=@user";
            using (SqlCommand comand2 = new SqlCommand(getFollowers, con))
            {
                comand2.Parameters.AddWithValue("@user", user);
                int nbFollowers = (int)comand2.ExecuteScalar();
                followersnb.Text = nbFollowers.ToString();
            }
            String getImage = "select picture from loginData where userName=@user";
            using (SqlCommand command3 = new SqlCommand(getImage, con))
            {
                command3.Parameters.AddWithValue("@user", user);
                SqlDataReader reader = command3.ExecuteReader();

                if (reader.Read()) // Check if there are any rows returned by the query
                {
                    byte[] imageData = (byte[])reader["picture"]; // Access the picture column
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBox1.Image = image;
                    }
                }
            }
        }
    } 
}
