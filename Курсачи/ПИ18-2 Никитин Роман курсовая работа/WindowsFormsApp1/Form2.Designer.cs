namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.printerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоФирмеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоФирмеЯаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоМоделиАяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоМоделиЯаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.printerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создатель и научный руководитель.";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.printerBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(96, 142);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Name";
            // 
            // printerBindingSource
            // 
            this.printerBindingSource.DataSource = typeof(WindowsFormsApp1.Printer);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.printerinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(107, 311);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(572, 195);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
            this.infoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            this.infoDataGridViewTextBoxColumn.ReadOnly = true;
            this.infoDataGridViewTextBoxColumn.Width = 125;
            // 
            // printerinfoBindingSource
            // 
            this.printerinfoBindingSource.DataSource = typeof(WindowsFormsApp1.Printer_info);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.printerBindingSource;
            this.comboBox2.DisplayMember = "Model";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(513, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(155, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "Model";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "Посмотреть информацию о принтере.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(477, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 59);
            this.button3.TabIndex = 6;
            this.button3.Text = "Добавить информацию о принтере.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(306, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(600, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 62);
            this.button4.TabIndex = 8;
            this.button4.Text = "Изменение цвета кнопок";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(425, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 62);
            this.button5.TabIndex = 9;
            this.button5.Text = "Изменение цвета окна";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.помощьToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортироватьПоФирмеToolStripMenuItem,
            this.сортироватьПоФирмеЯаToolStripMenuItem,
            this.сортироватьПоМоделиАяToolStripMenuItem,
            this.сортироватьПоМоделиЯаToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.помощьToolStripMenuItem.Text = "Сортировка";
            // 
            // сортироватьПоФирмеToolStripMenuItem
            // 
            this.сортироватьПоФирмеToolStripMenuItem.Name = "сортироватьПоФирмеToolStripMenuItem";
            this.сортироватьПоФирмеToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.сортироватьПоФирмеToolStripMenuItem.Text = "Сортировать по фирме а-я";
            this.сортироватьПоФирмеToolStripMenuItem.Click += new System.EventHandler(this.сортироватьПоФирмеToolStripMenuItem_Click);
            // 
            // сортироватьПоФирмеЯаToolStripMenuItem
            // 
            this.сортироватьПоФирмеЯаToolStripMenuItem.Name = "сортироватьПоФирмеЯаToolStripMenuItem";
            this.сортироватьПоФирмеЯаToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.сортироватьПоФирмеЯаToolStripMenuItem.Text = "Сортировать по фирме я-а";
            this.сортироватьПоФирмеЯаToolStripMenuItem.Click += new System.EventHandler(this.сортироватьПоФирмеЯаToolStripMenuItem_Click);
            // 
            // сортироватьПоМоделиАяToolStripMenuItem
            // 
            this.сортироватьПоМоделиАяToolStripMenuItem.Name = "сортироватьПоМоделиАяToolStripMenuItem";
            this.сортироватьПоМоделиАяToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.сортироватьПоМоделиАяToolStripMenuItem.Text = "Сортировать по модели а-я";
            this.сортироватьПоМоделиАяToolStripMenuItem.Click += new System.EventHandler(this.сортироватьПоМоделиАяToolStripMenuItem_Click);
            // 
            // сортироватьПоМоделиЯаToolStripMenuItem
            // 
            this.сортироватьПоМоделиЯаToolStripMenuItem.Name = "сортироватьПоМоделиЯаToolStripMenuItem";
            this.сортироватьПоМоделиЯаToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.сортироватьПоМоделиЯаToolStripMenuItem.Text = "Сортировать по модели я-а";
            this.сортироватьПоМоделиЯаToolStripMenuItem.Click += new System.EventHandler(this.сортироватьПоМоделиЯаToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem1
            // 
            this.помощьToolStripMenuItem1.Name = "помощьToolStripMenuItem1";
            this.помощьToolStripMenuItem1.Size = new System.Drawing.Size(83, 24);
            this.помощьToolStripMenuItem1.Text = "Помощь";
            this.помощьToolStripMenuItem1.Click += new System.EventHandler(this.помощьToolStripMenuItem1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(615, 182);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 59);
            this.button6.TabIndex = 12;
            this.button6.Text = "Изменить информацию о принтере";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 537);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Информация";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.printerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource printerinfoBindingSource;
        private System.Windows.Forms.BindingSource printerBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоФирмеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоФирмеЯаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоМоделиАяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоМоделиЯаToolStripMenuItem;
        private System.Windows.Forms.Button button6;
    }
}