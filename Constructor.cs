using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data.Common;
using SQLitePCL;
using System.Runtime.CompilerServices;

namespace WinFormsApp
{

    public partial class Constructor : Form
    {
        public Connection connection;
        public static DataGridView SharedDataGridView { get; private set; }
        public Constructor()
        {
            InitializeComponent();
            SharedDataGridView = dataGridView1;
        }

        public void Constructor_Load(object sender, EventArgs e)
        {
            connection = new();
            connection.GetConnection(SharedDataGridView, "SELECT * FROM components");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.SaveConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения данных: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.DeleteConnection(SharedDataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления строки: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            connection.RestoreConnection();
        }
    }
}
