namespace ProfileSocialMedia
{
    partial class UserProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.followersnb = new System.Windows.Forms.Label();
            this.followingnb = new System.Windows.Forms.Label();
            this.postnb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.followNewFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.followersnb);
            this.panel1.Controls.Add(this.followingnb);
            this.panel1.Controls.Add(this.postnb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(307, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 108);
            this.panel1.TabIndex = 4;
            // 
            // followersnb
            // 
            this.followersnb.AutoSize = true;
            this.followersnb.BackColor = System.Drawing.Color.White;
            this.followersnb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followersnb.Location = new System.Drawing.Point(418, 61);
            this.followersnb.Name = "followersnb";
            this.followersnb.Size = new System.Drawing.Size(64, 25);
            this.followersnb.TabIndex = 5;
            this.followersnb.Text = "label6";
            this.followersnb.Click += new System.EventHandler(this.followersnb_Click);
            // 
            // followingnb
            // 
            this.followingnb.AutoSize = true;
            this.followingnb.BackColor = System.Drawing.Color.White;
            this.followingnb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followingnb.Location = new System.Drawing.Point(220, 61);
            this.followingnb.Name = "followingnb";
            this.followingnb.Size = new System.Drawing.Size(64, 25);
            this.followingnb.TabIndex = 4;
            this.followingnb.Text = "label5";
            this.followingnb.Click += new System.EventHandler(this.followingnb_Click);
            // 
            // postnb
            // 
            this.postnb.AutoSize = true;
            this.postnb.BackColor = System.Drawing.Color.White;
            this.postnb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postnb.Location = new System.Drawing.Point(32, 61);
            this.postnb.Name = "postnb";
            this.postnb.Size = new System.Drawing.Size(23, 25);
            this.postnb.TabIndex = 3;
            this.postnb.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(376, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "FOLLOWERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(178, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "FOLLOWING";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "POSTS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 311);
            this.panel2.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.followNewFriendToolStripMenuItem,
            this.removeFriendToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 52);
            // 
            // followNewFriendToolStripMenuItem
            // 
            this.followNewFriendToolStripMenuItem.Name = "followNewFriendToolStripMenuItem";
            this.followNewFriendToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.followNewFriendToolStripMenuItem.Text = "Follow new friend";
            this.followNewFriendToolStripMenuItem.Click += new System.EventHandler(this.followNewFriendToolStripMenuItem_Click);
            // 
            // removeFriendToolStripMenuItem
            // 
            this.removeFriendToolStripMenuItem.Name = "removeFriendToolStripMenuItem";
            this.removeFriendToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.removeFriendToolStripMenuItem.Text = "Remove friend";
            this.removeFriendToolStripMenuItem.Click += new System.EventHandler(this.removeFriendToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(930, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 32);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::ProfileSocialMedia.Properties.Resources.icons8_avatar_96;
            this.pictureBox1.Location = new System.Drawing.Point(100, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userName.Location = new System.Drawing.Point(116, 182);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(117, 32);
            this.userName.TabIndex = 6;
            this.userName.Text = "userName";
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(982, 607);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserProfileForm";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label followersnb;
        private System.Windows.Forms.Label followingnb;
        private System.Windows.Forms.Label postnb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem followNewFriendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFriendToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}