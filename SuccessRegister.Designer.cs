namespace WinFormsApp
{
    partial class SuccessRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            registrationLabel = new Label();
            okButton = new Button();
            SuspendLayout();
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Location = new Point(29, 45);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(224, 20);
            registrationLabel.TabIndex = 0;
            registrationLabel.Text = "Регистрация прошла успешно!";
            // 
            // okButton
            // 
            okButton.Location = new Point(96, 115);
            okButton.Name = "okButton";
            okButton.Size = new Size(94, 29);
            okButton.TabIndex = 1;
            okButton.Text = " OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // SuccessRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 156);
            Controls.Add(okButton);
            Controls.Add(registrationLabel);
            Name = "SuccessRegister";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registrationLabel;
        private Button okButton;
    }
}