namespace WinFormsApp
{
    partial class Form2
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            ForGames = new PictureBox();
            ForServers = new PictureBox();
            ForWork = new PictureBox();
            pictureBox4 = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ForGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ForServers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ForWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ForGames);
            flowLayoutPanel1.Controls.Add(ForServers);
            flowLayoutPanel1.Controls.Add(ForWork);
            flowLayoutPanel1.Controls.Add(pictureBox4);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(772, 426);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // ForGames
            // 
            ForGames.BackgroundImageLayout = ImageLayout.None;
            ForGames.Cursor = Cursors.Hand;
            ForGames.Image = Properties.Resources.ForGames;
            ForGames.Location = new Point(3, 3);
            ForGames.Name = "ForGames";
            ForGames.Size = new Size(187, 135);
            ForGames.SizeMode = PictureBoxSizeMode.StretchImage;
            ForGames.TabIndex = 13;
            ForGames.TabStop = false;
            ForGames.Click += pictureBox3_Click;
            // 
            // ForServers
            // 
            ForServers.Cursor = Cursors.Hand;
            ForServers.Image = Properties.Resources.ForServers;
            ForServers.Location = new Point(196, 3);
            ForServers.Name = "ForServers";
            ForServers.Size = new Size(187, 135);
            ForServers.SizeMode = PictureBoxSizeMode.StretchImage;
            ForServers.TabIndex = 14;
            ForServers.TabStop = false;
            ForServers.Click += pictureBox1_Click;
            // 
            // ForWork
            // 
            ForWork.Cursor = Cursors.Hand;
            ForWork.Image = Properties.Resources.ForWork;
            ForWork.Location = new Point(389, 3);
            ForWork.Name = "ForWork";
            ForWork.Size = new Size(187, 135);
            ForWork.SizeMode = PictureBoxSizeMode.StretchImage;
            ForWork.TabIndex = 15;
            ForWork.TabStop = false;
            ForWork.Click += pictureBox2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(582, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(187, 135);
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 450);
            Controls.Add(flowLayoutPanel1);
            Name = "Form2";
            Text = "Form2";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ForGames).EndInit();
            ((System.ComponentModel.ISupportInitialize)ForServers).EndInit();
            ((System.ComponentModel.ISupportInitialize)ForWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox ForGames;
        private PictureBox ForServers;
        private PictureBox ForWork;
        private PictureBox pictureBox4;
    }
}