using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using WinFormsApp.ORM;
using Xunit;

namespace WinFormsApp.Tests
{
    public class AuthTest : IClassFixture<DatabaseFixture>
    {
        private readonly DatabaseFixture _fixture;
        private readonly Auth _auth;

        public AuthTest(DatabaseFixture fixture)
        {
            _fixture = fixture;
            _auth = new Auth();
        }

        [Fact]
        public void Should_Register()
        {
            var login = "login";
            var password1 = "password";
            var password2 = "password";

            var actual = _auth.Register(_fixture.Options, login, password1, password2);

            var expected = "Регистрация прошла успешно!";

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Login()
        {
            var login = "login";
            var password = "password";

            var actual = _auth.Login(_fixture.Options, login, password);
            
            var expected = "Авторизация прошла успешно!";

            Assert.Equal(expected, actual);
        }
    }
}