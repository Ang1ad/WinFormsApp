using WinFormsApp.ORM;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.VisualBasic.Logging;
using BCrypt.Net;
using Microsoft.VisualBasic;

namespace WinFormsApp
{
    public partial class Auth : Form
    {
        public string Login(DbContextOptions<AuthContext> options, string login, string password)
        {
            using (var db = new WinFormsApp.ORM.AuthContext(options))
            {
                var customer = db.Users
                    .SingleOrDefault(c => c.Login == login);
                if (customer != null && BCrypt.Net.BCrypt.Verify(password, customer.Password))
                {
                    string msg = "Авторизация успешна!";
                    MessageBox.Show(msg);
                    var SecondForm = new Form2();
                    this.Hide();
                    SecondForm.ShowDialog();
                    return msg;
                }
                else
                {
                    string msg = "Неверный логин или пароль. Пожалуйста, попробуйте снова.";
                    MessageBox.Show(msg);
                    return msg;
                }
            }
        }

        public string Register(DbContextOptions<AuthContext> options, string login, string password, string password2)
        {
            if (password == password2)
            {
                using (var db = new WinFormsApp.ORM.AuthContext(options))
                {
                    var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                    var customer = new Users
                    {
                        Login = login,
                        Password = hashedPassword
                    };

                    db.Users.Add(customer);
                    db.SaveChanges();
                    string msg = "Регистрация прошла успешно!";
                    MessageBox.Show(msg);
                    return msg;
                }
            }
            else
            {
                string msg = "Пароли не совпадают";
                MessageBox.Show(msg);
                return msg;
            }
        }

        public Auth()
        {
            InitializeComponent();
        }
        #region login
        private void loginButton_Click(object sender, EventArgs e)
        {
            var options = new DbContextOptionsBuilder<AuthContext>()
            .UseSqlite("Filename=../../../MyLocalLibrary.db")
            .Options;
            var login = loginLoginTextBox.Text;
            var password = passwordLoginTextBox.Text;
            try
            {
                Login(options, login, password);
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
            var options = new DbContextOptionsBuilder<AuthContext>()
                .UseSqlite("Filename=../../../MyLocalLibrary.db")
                .Options;
            var login = loginRegisterTextBox.Text;
            try
            {
                var password = passwordRegisterTextBox.Text;
                var password2 = repeatPasswordRegisterTextBox.Text;
                Register(options, login, password, password2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
        #endregion

        private void Auth_Load(object sender, EventArgs e)
        {

        }
    }
}
