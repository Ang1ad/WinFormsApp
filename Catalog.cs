using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var GameForm = new ForGames();
            GameForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var ServerForm = new ForServers();
            ServerForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var WorkForm = new ForWork();
            WorkForm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var ConstructorForm = new Constructor();
            ConstructorForm.ShowDialog();
        }
    }
}
