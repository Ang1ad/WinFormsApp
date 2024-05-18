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
                        MessageBox.Show("Авторизация успешна!");
                        // Дополнительные действия при успешной авторизации, например, открытие новой формы
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
    }
}
