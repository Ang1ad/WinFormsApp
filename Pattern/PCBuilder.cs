using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using WinFormsApp.ORM;

namespace WinFormsApp.Pattern
{
    public class PCBuilder : IPCBuilder
    {
        private PC _pc;
        private Connection _connection;

        public PCBuilder()
        {
            _pc = new();
            _connection = new Connection();
            _connection.GetConnection(Constructor.SharedDataGridView, "SELECT * FROM components");
        }
        public void BuildMotherboard()
        {
            _connection.GetConnection(Constructor.SharedDataGridView, "SELECT * FROM COMPONENTS WHERE type = 'Motherboard'");
        }

        public void BuildPSU()
        {
            _connection.GetConnection(Constructor.SharedDataGridView, "SELECT * FROM COMPONENTS WHERE type = 'PSU'");
        }
        public void BuildGPU()
        {
            _connection.GetConnection(Constructor.SharedDataGridView, "SELECT * FROM COMPONENTS WHERE type = 'GPU'");
        }
        public void BuildCPU()
        {
            _connection.GetConnection(Constructor.SharedDataGridView, "SELECT * FROM COMPONENTS WHERE type = 'CPU'");
        }
        public void BuildRAM()
        {
            _connection.GetConnection(Constructor.SharedDataGridView, "SELECT * FROM COMPONENTS WHERE type = 'RAM'");
        }
        public void BuildROM()
        {
            _connection.GetConnection(Constructor.SharedDataGridView, "SELECT * FROM COMPONENTS WHERE type = 'ROM'");
        }

        public PC GetPC()
        {
            PC pc = _pc;
            _pc = new();
            return pc;
        }
    }
}
