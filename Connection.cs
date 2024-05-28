using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public class Connection
    {
        private SqlConnection? _sqlConnection = new();
        private SqlDataAdapter? _adapter = null;
        private SqlCommandBuilder? _commandBuilder = null;
        private DataTable? _table = null;
        private DataTable? _backupTable;

        public Connection()
        {
            _sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Programs\Visual Studio Projects\WinFormsApp\DB\Database1.mdf"";Integrated Security=True");
            _sqlConnection.Open();
        }

        public void GetConnection(DataGridView dataGridView, string sqlRequest)
        {
            _adapter = new SqlDataAdapter(sqlRequest, _sqlConnection);
            _commandBuilder = new SqlCommandBuilder();
            _table = new DataTable();
            _adapter.Fill(_table);
            dataGridView.DataSource = _table;
            _backupTable = _table.Copy();
        }

        public void DeleteConnection(DataGridView dataGridView)
        {
            if (_adapter != null && _table != null)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView.Rows.Remove(row);
                    }
                }

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(_adapter);
                _adapter.DeleteCommand = commandBuilder.GetDeleteCommand();
                _adapter.Update(_table);
                MessageBox.Show("Выбранные строки успешно удалены.");
            }
            else
            {
                MessageBox.Show("Не удалось выполнить удаление.");
            }
        }

        public void SaveConnection()
        {
            if (_adapter != null && _table != null)
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(_adapter);
                _adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                _adapter.Update(_table);
                _backupTable = _table.Copy();
                MessageBox.Show("Данные успешно сохранены.");
            }
            else
            {
                MessageBox.Show("Не удалось сохранить данные.");
            }
        }

        public void RestoreConnection()
        {
            if (_backupTable != null && _table != null)
            {
                _table.Clear();
                _table.Merge(_backupTable);
                MessageBox.Show("Данные успешно восстановлены.");
            }
            else
            {
                MessageBox.Show("Не удалось восстановить данные.");
            }
        }

    }
}
