using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfileSocialMedia
{
    internal class DataBase
    {
        SqlConnection SqlConnection;
        SqlDataReader SqlDataReader;

        private string connection = "Server=localhost;Database=ProfileSocialMedia;User=leb;Password=leblord01";

        public DataBase() { }

        public SqlConnection Connect()
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            try
            {
                sqlConnection.Open();
                return sqlConnection;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; 
            }
        }


    }
}
