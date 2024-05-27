namespace WinFormsApp
{
    partial class Auth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginLoginTextBox = new TextBox();
            loginButton = new Button();
            registerButton = new Button();
            passwordLoginTextBox = new TextBox();
            loginRegisterTextBox = new TextBox();
            passwordRegisterTextBox = new TextBox();
            repeatPasswordRegisterTextBox = new TextBox();
            loginLabelLogin = new Label();
            passwordLabelLogin = new Label();
            loginLabelRegister = new Label();
            passwordRegister = new Label();
            repeatPasswordRegister = new Label();
            SuspendLayout();
            // 
            // loginLoginTextBox
            // 
            loginLoginTextBox.Location = new Point(28, 83);
            loginLoginTextBox.Name = "loginLoginTextBox";
            loginLoginTextBox.Size = new Size(125, 27);
            loginLoginTextBox.TabIndex = 0;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(47, 193);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 1;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(233, 193);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(94, 29);
            registerButton.TabIndex = 2;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // passwordLoginTextBox
            // 
            passwordLoginTextBox.Location = new Point(28, 145);
            passwordLoginTextBox.Name = "passwordLoginTextBox";
            passwordLoginTextBox.Size = new Size(125, 27);
            passwordLoginTextBox.TabIndex = 3;
            passwordLoginTextBox.UseSystemPasswordChar = true;
            // 
            // loginRegisterTextBox
            // 
            loginRegisterTextBox.Location = new Point(215, 35);
            loginRegisterTextBox.Name = "loginRegisterTextBox";
            loginRegisterTextBox.Size = new Size(125, 27);
            loginRegisterTextBox.TabIndex = 4;
            // 
            // passwordRegisterTextBox
            // 
            passwordRegisterTextBox.Location = new Point(215, 98);
            passwordRegisterTextBox.Name = "passwordRegisterTextBox";
            passwordRegisterTextBox.Size = new Size(125, 27);
            passwordRegisterTextBox.TabIndex = 5;
            passwordRegisterTextBox.UseSystemPasswordChar = true;
            // 
            // repeatPasswordRegisterTextBox
            // 
            repeatPasswordRegisterTextBox.Location = new Point(215, 160);
            repeatPasswordRegisterTextBox.Name = "repeatPasswordRegisterTextBox";
            repeatPasswordRegisterTextBox.Size = new Size(125, 27);
            repeatPasswordRegisterTextBox.TabIndex = 6;
            repeatPasswordRegisterTextBox.UseSystemPasswordChar = true;
            // 
            // loginLabelLogin
            // 
            loginLabelLogin.AutoSize = true;
            loginLabelLogin.Location = new Point(71, 60);
            loginLabelLogin.Name = "loginLabelLogin";
            loginLabelLogin.Size = new Size(46, 20);
            loginLabelLogin.TabIndex = 7;
            loginLabelLogin.Text = "Login";
            // 
            // passwordLabelLogin
            // 
            passwordLabelLogin.AutoSize = true;
            passwordLabelLogin.Location = new Point(59, 122);
            passwordLabelLogin.Name = "passwordLabelLogin";
            passwordLabelLogin.Size = new Size(70, 20);
            passwordLabelLogin.TabIndex = 8;
            passwordLabelLogin.Text = "Password";
            // 
            // loginLabelRegister
            // 
            loginLabelRegister.AutoSize = true;
            loginLabelRegister.Location = new Point(254, 12);
            loginLabelRegister.Name = "loginLabelRegister";
            loginLabelRegister.Size = new Size(46, 20);
            loginLabelRegister.TabIndex = 9;
            loginLabelRegister.Text = "Login";
            // 
            // passwordRegister
            // 
            passwordRegister.AutoSize = true;
            passwordRegister.Location = new Point(242, 75);
            passwordRegister.Name = "passwordRegister";
            passwordRegister.Size = new Size(70, 20);
            passwordRegister.TabIndex = 10;
            passwordRegister.Text = "Password";
            // 
            // repeatPasswordRegister
            // 
            repeatPasswordRegister.AutoSize = true;
            repeatPasswordRegister.Location = new Point(217, 137);
            repeatPasswordRegister.Name = "repeatPasswordRegister";
            repeatPasswordRegister.Size = new Size(123, 20);
            repeatPasswordRegister.TabIndex = 11;
            repeatPasswordRegister.Text = "Repeat password";
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 252);
            Controls.Add(repeatPasswordRegister);
            Controls.Add(passwordRegister);
            Controls.Add(loginLabelRegister);
            Controls.Add(passwordLabelLogin);
            Controls.Add(loginLabelLogin);
            Controls.Add(repeatPasswordRegisterTextBox);
            Controls.Add(passwordRegisterTextBox);
            Controls.Add(loginRegisterTextBox);
            Controls.Add(passwordLoginTextBox);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(loginLoginTextBox);
            Name = "Auth";
            Text = "Login or register";
            Load += Auth_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox loginLoginTextBox;
        public Button loginButton;
        public Button registerButton;
        public TextBox passwordLoginTextBox;
        public TextBox loginRegisterTextBox;
        public TextBox passwordRegisterTextBox;
        public TextBox repeatPasswordRegisterTextBox;
        private Label loginLabelLogin;
        private Label passwordLabelLogin;
        private Label loginLabelRegister;
        private Label passwordRegister;
        private Label repeatPasswordRegister;
    }
}
