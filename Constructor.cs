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
        private SqlConnection? sqlConnection = null;
        private SqlDataAdapter? adapter = null;
        private SqlCommandBuilder? commandBuilder = null;
        private DataTable? table = null;
        private DataTable? backupTable;
        public Constructor()
        {
            InitializeComponent();
        }

        internal void Constructor_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programs\Visual Studio Projects\WinFormsApp\DB\Database1.mdf"";Integrated Security=True");
            sqlConnection.Open();
            adapter = new SqlDataAdapter("SELECT * FROM components", sqlConnection);
            commandBuilder = new SqlCommandBuilder(adapter);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            backupTable = table.Copy();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(table);
                backupTable = table.Copy();
                MessageBox.Show("Данные успешно сохранены.");
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
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
                adapter.Update(table);
                MessageBox.Show("Выбранные строки успешно удалены.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления строки: " + ex.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            table.Clear();
            table.Merge(backupTable);
            MessageBox.Show("Данные успешно восстановлены.");
        }
    }
}
