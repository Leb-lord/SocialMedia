using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ProfileSocialMedia
{
    internal class Components
    {
        public class ImageTextItem : UserControl
        {
            private PictureBox pictureBox;
            private Label label;

            public ImageTextItem()
            {
                InitializeComponents();
            }

            private void InitializeComponents()
            {
                pictureBox = new PictureBox();
                pictureBox.Dock = DockStyle.Left;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 100; // Adjust size as needed
                label = new Label();
                label.Dock = DockStyle.Fill;
                label.ForeColor = Color.White;

                this.Controls.Add(pictureBox);
                this.Controls.Add(label);
            }

            // Properties to set image and text
            public Image Image
            {
                get { return pictureBox.Image; }
                set { pictureBox.Image = value; }
            }

            public string Text
            {
                get { return label.Text; }
                set { label.Text = value; }
            }
        }
        // In your Form3 class


    }
}
