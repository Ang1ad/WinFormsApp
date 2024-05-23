namespace WinFormsApp
{
    partial class Constructor
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
            panel1 = new Panel();
            labelPSU = new Label();
            labelRAM = new Label();
            labelROM = new Label();
            labelMotherboard = new Label();
            labelGPU = new Label();
            labelCPU = new Label();
            buttonPSU = new Button();
            comboBoxPSU = new ComboBox();
            comboBoxRAM = new ComboBox();
            buttonRAM = new Button();
            buttonROM = new Button();
            comboBoxROM = new ComboBox();
            buttonMotherboard = new Button();
            buttonGPU = new Button();
            comboBoxMotherboard = new ComboBox();
            comboBoxGPU = new ComboBox();
            comboBoxCPU = new ComboBox();
            buttonCPU = new Button();
            buttonCart = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCart);
            panel1.Controls.Add(labelPSU);
            panel1.Controls.Add(labelRAM);
            panel1.Controls.Add(labelROM);
            panel1.Controls.Add(labelMotherboard);
            panel1.Controls.Add(labelGPU);
            panel1.Controls.Add(labelCPU);
            panel1.Controls.Add(buttonPSU);
            panel1.Controls.Add(comboBoxPSU);
            panel1.Controls.Add(comboBoxRAM);
            panel1.Controls.Add(buttonRAM);
            panel1.Controls.Add(buttonROM);
            panel1.Controls.Add(comboBoxROM);
            panel1.Controls.Add(buttonMotherboard);
            panel1.Controls.Add(buttonGPU);
            panel1.Controls.Add(comboBoxMotherboard);
            panel1.Controls.Add(comboBoxGPU);
            panel1.Controls.Add(comboBoxCPU);
            panel1.Controls.Add(buttonCPU);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 0;
            // 
            // labelPSU
            // 
            labelPSU.AutoSize = true;
            labelPSU.Location = new Point(275, 124);
            labelPSU.Name = "labelPSU";
            labelPSU.Size = new Size(35, 20);
            labelPSU.TabIndex = 17;
            labelPSU.Text = "PSU";
            // 
            // labelRAM
            // 
            labelRAM.AutoSize = true;
            labelRAM.Location = new Point(113, 124);
            labelRAM.Name = "labelRAM";
            labelRAM.Size = new Size(41, 20);
            labelRAM.TabIndex = 16;
            labelRAM.Text = "RAM";
            // 
            // labelROM
            // 
            labelROM.AutoSize = true;
            labelROM.Location = new Point(586, 23);
            labelROM.Name = "labelROM";
            labelROM.Size = new Size(42, 20);
            labelROM.TabIndex = 15;
            labelROM.Text = "ROM";
            // 
            // labelMotherboard
            // 
            labelMotherboard.AutoSize = true;
            labelMotherboard.Location = new Point(405, 23);
            labelMotherboard.Name = "labelMotherboard";
            labelMotherboard.Size = new Size(97, 20);
            labelMotherboard.TabIndex = 14;
            labelMotherboard.Text = "Motherboard";
            // 
            // labelGPU
            // 
            labelGPU.AutoSize = true;
            labelGPU.Location = new Point(273, 23);
            labelGPU.Name = "labelGPU";
            labelGPU.Size = new Size(37, 20);
            labelGPU.TabIndex = 13;
            labelGPU.Text = "GPU";
            // 
            // labelCPU
            // 
            labelCPU.AutoSize = true;
            labelCPU.Location = new Point(113, 23);
            labelCPU.Name = "labelCPU";
            labelCPU.Size = new Size(36, 20);
            labelCPU.TabIndex = 12;
            labelCPU.Text = "CPU";
            // 
            // buttonPSU
            // 
            buttonPSU.Location = new Point(245, 181);
            buttonPSU.Name = "buttonPSU";
            buttonPSU.Size = new Size(94, 29);
            buttonPSU.TabIndex = 11;
            buttonPSU.Text = "Add";
            buttonPSU.UseVisualStyleBackColor = true;
            // 
            // comboBoxPSU
            // 
            comboBoxPSU.FormattingEnabled = true;
            comboBoxPSU.Items.AddRange(new object[] { "Chieftech Proton 1000", "DeepCool PF 700" });
            comboBoxPSU.Location = new Point(218, 147);
            comboBoxPSU.Name = "comboBoxPSU";
            comboBoxPSU.Size = new Size(151, 28);
            comboBoxPSU.TabIndex = 6;
            comboBoxPSU.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // comboBoxRAM
            // 
            comboBoxRAM.FormattingEnabled = true;
            comboBoxRAM.Items.AddRange(new object[] { "Samsung 16Gb 3.4GHz", "AMD 8Gb 3.2GHz" });
            comboBoxRAM.Location = new Point(61, 147);
            comboBoxRAM.Name = "comboBoxRAM";
            comboBoxRAM.Size = new Size(151, 28);
            comboBoxRAM.TabIndex = 5;
            // 
            // buttonRAM
            // 
            buttonRAM.Location = new Point(86, 181);
            buttonRAM.Name = "buttonRAM";
            buttonRAM.Size = new Size(94, 29);
            buttonRAM.TabIndex = 8;
            buttonRAM.Text = "Add";
            buttonRAM.UseVisualStyleBackColor = true;
            // 
            // buttonROM
            // 
            buttonROM.Location = new Point(559, 80);
            buttonROM.Name = "buttonROM";
            buttonROM.Size = new Size(94, 29);
            buttonROM.TabIndex = 7;
            buttonROM.Text = "Add";
            buttonROM.UseVisualStyleBackColor = true;
            // 
            // comboBoxROM
            // 
            comboBoxROM.FormattingEnabled = true;
            comboBoxROM.Items.AddRange(new object[] { "WD Blue 1Tb", "Samsung Evo 870 2Tb" });
            comboBoxROM.Location = new Point(532, 46);
            comboBoxROM.Name = "comboBoxROM";
            comboBoxROM.Size = new Size(151, 28);
            comboBoxROM.TabIndex = 4;
            // 
            // buttonMotherboard
            // 
            buttonMotherboard.Location = new Point(408, 80);
            buttonMotherboard.Name = "buttonMotherboard";
            buttonMotherboard.Size = new Size(94, 29);
            buttonMotherboard.TabIndex = 5;
            buttonMotherboard.Text = "Add";
            buttonMotherboard.UseVisualStyleBackColor = true;
            // 
            // buttonGPU
            // 
            buttonGPU.Location = new Point(245, 80);
            buttonGPU.Name = "buttonGPU";
            buttonGPU.Size = new Size(94, 29);
            buttonGPU.TabIndex = 4;
            buttonGPU.Text = "Add";
            buttonGPU.UseVisualStyleBackColor = true;
            // 
            // comboBoxMotherboard
            // 
            comboBoxMotherboard.FormattingEnabled = true;
            comboBoxMotherboard.Items.AddRange(new object[] { "ASRock B550M", "MSI A440" });
            comboBoxMotherboard.Location = new Point(375, 46);
            comboBoxMotherboard.Name = "comboBoxMotherboard";
            comboBoxMotherboard.Size = new Size(151, 28);
            comboBoxMotherboard.TabIndex = 3;
            // 
            // comboBoxGPU
            // 
            comboBoxGPU.FormattingEnabled = true;
            comboBoxGPU.Items.AddRange(new object[] { "NVIDIA RTX 4080 ", "AMD RX 6600XT" });
            comboBoxGPU.Location = new Point(218, 46);
            comboBoxGPU.Name = "comboBoxGPU";
            comboBoxGPU.Size = new Size(151, 28);
            comboBoxGPU.TabIndex = 2;
            // 
            // comboBoxCPU
            // 
            comboBoxCPU.FormattingEnabled = true;
            comboBoxCPU.Items.AddRange(new object[] { "AMD Ryzen 5 5600X", "Intel Core i9-13900KF", "Intel Core i7-14800K" });
            comboBoxCPU.Location = new Point(61, 46);
            comboBoxCPU.Name = "comboBoxCPU";
            comboBoxCPU.Size = new Size(151, 28);
            comboBoxCPU.TabIndex = 1;
            // 
            // buttonCPU
            // 
            buttonCPU.Location = new Point(86, 80);
            buttonCPU.Name = "buttonCPU";
            buttonCPU.Size = new Size(94, 29);
            buttonCPU.TabIndex = 0;
            buttonCPU.Text = "Add";
            buttonCPU.UseVisualStyleBackColor = true;
            // 
            // buttonCart
            // 
            buttonCart.Location = new Point(536, 163);
            buttonCart.Name = "buttonCart";
            buttonCart.Size = new Size(117, 47);
            buttonCart.TabIndex = 18;
            buttonCart.Text = "Go to cart";
            buttonCart.UseVisualStyleBackColor = true;
            // 
            // Constructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Constructor";
            Text = "Constructor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxRAM;
        private Button buttonRAM;
        private Button buttonROM;
        private ComboBox comboBoxROM;
        private Button buttonMotherboard;
        private Button buttonGPU;
        private ComboBox comboBoxMotherboard;
        private ComboBox comboBoxGPU;
        private ComboBox comboBoxCPU;
        private Button buttonCPU;
        private Button buttonPSU;
        private ComboBox comboBoxPSU;
        private Label labelPSU;
        private Label labelRAM;
        private Label labelROM;
        private Label labelMotherboard;
        private Label labelGPU;
        private Label labelCPU;
        private Button buttonCart;
    }
}