using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.UIA3;

namespace WinFormsApp.Tests
{
    public class EndToEndTests : IDisposable
    {
        private readonly Application _app;
        private readonly AutomationBase _automation;

        public EndToEndTests()
        {
            string appPath = @"D:\Programs\Visual Studio Projects\WinFormsApp\bin\Debug\net8.0-windows\WinFormsApp.exe";
            _app = Application.Launch(appPath);
            _automation = new UIA3Automation();
        }

        public void Dispose()
        {
        }

        [Fact]
        public void CompleteFlowTest()
        {
            var mainWindow = _app.GetMainWindow(_automation);
            ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
            var loginRegisterTextBox = mainWindow.FindFirstDescendant(cf.ByAutomationId("loginRegisterTextBox")).AsTextBox();
            var passwordRegisterTextBox = mainWindow.FindFirstDescendant(cf.ByAutomationId("passwordRegisterTextBox")).AsTextBox();
            var repeatPasswordRegisterTextBox = mainWindow.FindFirstDescendant(cf.ByAutomationId("repeatPasswordRegisterTextBox")).AsTextBox();
            var registerButton = mainWindow.FindFirstDescendant(cf.ByAutomationId("registerButton")).AsButton();

            loginRegisterTextBox.Enter("newUser");
            passwordRegisterTextBox.Enter("password");
            repeatPasswordRegisterTextBox.Enter("password");
            registerButton.Click();

            Thread.Sleep(1000);

            var registerSuccessWindow = _app.GetMainWindow(_automation);
            Assert.NotNull(registerSuccessWindow);
            registerSuccessWindow.Close();

            Thread.Sleep(1000);

            mainWindow = _app.GetMainWindow(_automation);
            var loginLoginTextBox = mainWindow.FindFirstDescendant(cf.ByAutomationId("loginLoginTextBox")).AsTextBox();
            var passwordLoginTextBox = mainWindow.FindFirstDescendant(cf.ByAutomationId("passwordLoginTextBox")).AsTextBox();
            var loginButton = mainWindow.FindFirstDescendant(cf.ByAutomationId("loginButton")).AsButton();

            loginLoginTextBox.Enter("newUser");
            passwordLoginTextBox.Enter("password");
            loginButton.Click();

            Thread.Sleep(1000);

            var loginSuccessWindow = _app.GetAllTopLevelWindows(_automation).FirstOrDefault(w => w.Title.Contains("Авторизация"));
            Assert.NotNull(loginSuccessWindow);
            var okButton = loginSuccessWindow.FindFirstDescendant(cf.ByAutomationId("okButton")).AsButton();
            Assert.NotNull(okButton);
            okButton.Click();

            Thread.Sleep(1000);

            var catalogWindow = _app.GetAllTopLevelWindows(_automation).FirstOrDefault(w => w.Title.Contains("Catalog"));
            Assert.NotNull(catalogWindow);
            catalogWindow.DrawHighlight();
        }
    }
}