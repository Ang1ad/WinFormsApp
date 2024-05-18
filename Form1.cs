using WinFormsApp.ORM;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.VisualBasic.Logging;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var options = new DbContextOptionsBuilder<OrdersContext>()
            .UseSqlite("Filename=../../../MyLocalLibrary.db")
            .Options;
            var login = loginLoginTextBox.Text;
            var password = passwordLoginTextBox.Text;

            try
            {
                using (var db = new OrdersContext(options))
                {
                    var customer = db.Customers
                        .SingleOrDefault(c => c.Login == login && c.Password == password);

                    if (customer != null)
                    {
                        MessageBox.Show("����������� �������!");
                        // �������������� �������� ��� �������� �����������, ��������, �������� ����� �����
                    }
                    else
                    {
                        MessageBox.Show("�������� ����� ��� ������. ����������, ���������� �����.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"��������� ������: {ex.Message}");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var options = new DbContextOptionsBuilder<OrdersContext>()
                .UseSqlite("Filename=../../../MyLocalLibrary.db")
                .Options;
            var login = loginRegisterTextBox.Text;
            try
            {
                var password = passwordRegisterTextBox.Text;
                var password2 = repeatPasswordRegisterTextBox.Text;
                if (password == password2)
                {
                    using (var db = new WinFormsApp.ORM.OrdersContext(options))
                    {
                        var customer = new WinFormsApp.ORM.Customers
                        {
                            Login = login,
                            Password = password
                        };

                        db.Customers.Add(customer);
                        db.SaveChanges();
                        MessageBox.Show("����������� ������ �������!");
                    }
                }
                else
                {
                    MessageBox.Show("������ �� ���������");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"��������� ������: {ex.Message}");
            }
        }
    }
}
