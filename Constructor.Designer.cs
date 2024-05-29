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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Constructor));
            customersBindingSource = new BindingSource(components);
            customersBindingSource1 = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            saveButton = new ToolStripButton();
            deleteButton = new ToolStripButton();
            cancelButton = new ToolStripButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)customersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customersBindingSource1).BeginInit();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // customersBindingSource
            // 
            customersBindingSource.DataSource = typeof(ORM.Customers);
            // 
            // customersBindingSource1
            // 
            customersBindingSource1.DataSource = typeof(ORM.Customers);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { saveButton, deleteButton, cancelButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(863, 27);
            toolStrip1.TabIndex = 20;
            toolStrip1.Text = "toolStrip1";
            // 
            // saveButton
            // 
            saveButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            saveButton.Image = (Image)resources.GetObject("saveButton.Image");
            saveButton.ImageTransparentColor = Color.Magenta;
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(87, 24);
            saveButton.Text = "Сохранить";
            saveButton.Click += saveButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            deleteButton.Image = (Image)resources.GetObject("deleteButton.Image");
            deleteButton.ImageTransparentColor = Color.Magenta;
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(69, 24);
            deleteButton.Text = "Удалить";
            deleteButton.Click += deleteButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            cancelButton.Image = (Image)resources.GetObject("cancelButton.Image");
            cancelButton.ImageTransparentColor = Color.Magenta;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(66, 24);
            cancelButton.Text = "Отмена";
            cancelButton.Click += cancelButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(863, 459);
            dataGridView1.TabIndex = 21;
            // 
            // Constructor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 486);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Name = "Constructor";
            Text = "Constructor";
            Load += Constructor_Load;
            ((System.ComponentModel.ISupportInitialize)customersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customersBindingSource1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource customersBindingSource;
        private BindingSource customersBindingSource1;
        private ToolStrip toolStrip1;
        private ToolStripButton saveButton;
        private DataGridView dataGridView1;
        private ToolStripButton deleteButton;
        private ToolStripButton cancelButton;
    }
}