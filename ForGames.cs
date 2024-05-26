using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Pattern;

namespace WinFormsApp
{
    public partial class ForGames : Form
    {
        private DataGridView _dataGridView;
        private Connection _connection = new Connection();
        public ForGames(DataGridView dataGridView)
        {
            InitializeComponent();
            _dataGridView = dataGridView;
        }

        private void ForGames_Load(object sender, EventArgs e)
        {

        }

        private void CreateConfiguration_Click(object sender, EventArgs e)
        {
            var builder = new PCBuilder();
            var director = new PCDirector(builder);
            director.Build();
            var pc = builder.GetPC();
            Console.WriteLine(pc.ToString());
        }
    }
}
