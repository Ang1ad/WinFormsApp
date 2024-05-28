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
            Constructor = new PictureBox();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ForGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ForServers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ForWork).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Constructor).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ForGames);
            flowLayoutPanel1.Controls.Add(ForServers);
            flowLayoutPanel1.Controls.Add(ForWork);
            flowLayoutPanel1.Controls.Add(Constructor);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(532, 411);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // ForGames
            // 
            ForGames.BackgroundImageLayout = ImageLayout.None;
            ForGames.Cursor = Cursors.Hand;
            ForGames.Image = Properties.Resources.ForGames;
            ForGames.Location = new Point(3, 3);
            ForGames.Name = "ForGames";
            ForGames.Size = new Size(268, 197);
            ForGames.SizeMode = PictureBoxSizeMode.StretchImage;
            ForGames.TabIndex = 13;
            ForGames.TabStop = false;
            ForGames.Click += GameForm_Click;
            // 
            // ForServers
            // 
            ForServers.Cursor = Cursors.Hand;
            ForServers.Image = Properties.Resources.ForServers;
            ForServers.Location = new Point(277, 3);
            ForServers.Name = "ForServers";
            ForServers.Size = new Size(244, 197);
            ForServers.SizeMode = PictureBoxSizeMode.StretchImage;
            ForServers.TabIndex = 14;
            ForServers.TabStop = false;
            ForServers.Click += ServerForm_Click;
            // 
            // ForWork
            // 
            ForWork.Cursor = Cursors.Hand;
            ForWork.Image = Properties.Resources.ForWork;
            ForWork.Location = new Point(3, 206);
            ForWork.Name = "ForWork";
            ForWork.Size = new Size(268, 200);
            ForWork.SizeMode = PictureBoxSizeMode.StretchImage;
            ForWork.TabIndex = 15;
            ForWork.TabStop = false;
            ForWork.Click += WorkForm_Click;
            // 
            // Constructor
            // 
            Constructor.Cursor = Cursors.Hand;
            Constructor.Image = Properties.Resources.hyperpc_teaser_configurator;
            Constructor.Location = new Point(277, 206);
            Constructor.Name = "Constructor";
            Constructor.Size = new Size(244, 200);
            Constructor.SizeMode = PictureBoxSizeMode.StretchImage;
            Constructor.TabIndex = 16;
            Constructor.TabStop = false;
            Constructor.Click += ConstructorForm_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 427);
            Controls.Add(flowLayoutPanel1);
            Name = "Form2";
            Text = "Catalog";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ForGames).EndInit();
            ((System.ComponentModel.ISupportInitialize)ForServers).EndInit();
            ((System.ComponentModel.ISupportInitialize)ForWork).EndInit();
            ((System.ComponentModel.ISupportInitialize)Constructor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox ForGames;
        private PictureBox ForServers;
        private PictureBox ForWork;
        private PictureBox Constructor;
    }
}