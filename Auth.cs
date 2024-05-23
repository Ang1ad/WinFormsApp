using WinFormsApp.ORM;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.VisualBasic.Logging;
using BCrypt.Net;

namespace WinFormsApp
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }
        #region login
        private void button1_Click(object sender, EventArgs e)
        {
            var options = new DbContextOptionsBuilder<OrdersContext>()
            .UseSqlite("Filename=../../../MyLocalLibrary.db")
            .Options;
            var login = loginLoginTextBox.Text;
            var password = passwordLoginTextBox.Text;

            try
            {
                using (var db = new WinFormsApp.ORM.OrdersContext(options))
                {
                    var customer = db.Customers
                        .SingleOrDefault(c => c.Login == login);
                     
                    if (customer != null && BCrypt.Net.BCrypt.Verify(password, customer.Password))
                    {
                        MessageBox.Show("����������� �������!");
                        var SecondForm = new Form2();
                        this.Hide();
                        SecondForm.ShowDialog();
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
        #endregion
        #region register
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
                        var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                        var customer = new Customers
                        {   
                            Login = login,
                            Password = hashedPassword
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
        #endregion
    }
}
