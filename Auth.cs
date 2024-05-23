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
                        MessageBox.Show("Авторизация успешна!");
                        var SecondForm = new Form2();
                        this.Hide();
                        SecondForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль. Пожалуйста, попробуйте снова.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
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
                        MessageBox.Show("Регистрация прошла успешно!");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
        #endregion
    }
}
