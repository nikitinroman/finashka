namespace WindowsFormsApp4Maria
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.memberinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оСоздателеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регионаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.школыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.балловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имениToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фамилииToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.регионаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.школыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.классаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.балловToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.местаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theсlassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberinfoBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn,
            this.theсlassDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memberinfoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // memberinfoBindingSource
            // 
            this.memberinfoBindingSource.DataSource = typeof(WindowsFormsApp4Maria.Member_info);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.оСоздателеToolStripMenuItem,
            this.сортироватьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1224, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оСоздателеToolStripMenuItem
            // 
            this.оСоздателеToolStripMenuItem.Name = "оСоздателеToolStripMenuItem";
            this.оСоздателеToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.оСоздателеToolStripMenuItem.Text = "О создателе";
            this.оСоздателеToolStripMenuItem.Click += new System.EventHandler(this.оСоздателеToolStripMenuItem_Click);
            // 
            // сортироватьToolStripMenuItem
            // 
            this.сортироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьToolStripMenuItem});
            this.сортироватьToolStripMenuItem.Name = "сортироватьToolStripMenuItem";
            this.сортироватьToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.сортироватьToolStripMenuItem.Text = "Сортировать";
            // 
            // выбратьToolStripMenuItem
            // 
            this.выбратьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВозрастаниюToolStripMenuItem,
            this.поУбываниюToolStripMenuItem});
            this.выбратьToolStripMenuItem.Name = "выбратьToolStripMenuItem";
            this.выбратьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выбратьToolStripMenuItem.Text = "Выбрать";
            // 
            // поВозрастаниюToolStripMenuItem
            // 
            this.поВозрастаниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имениToolStripMenuItem,
            this.фамилииToolStripMenuItem,
            this.регионаToolStripMenuItem,
            this.школыToolStripMenuItem,
            this.классаToolStripMenuItem,
            this.балловToolStripMenuItem,
            this.местаToolStripMenuItem});
            this.поВозрастаниюToolStripMenuItem.Name = "поВозрастаниюToolStripMenuItem";
            this.поВозрастаниюToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.поВозрастаниюToolStripMenuItem.Text = "По возрастанию";
            // 
            // имениToolStripMenuItem
            // 
            this.имениToolStripMenuItem.Name = "имениToolStripMenuItem";
            this.имениToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.имениToolStripMenuItem.Text = "Имени";
            this.имениToolStripMenuItem.Click += new System.EventHandler(this.имениToolStripMenuItem_Click);
            // 
            // фамилииToolStripMenuItem
            // 
            this.фамилииToolStripMenuItem.Name = "фамилииToolStripMenuItem";
            this.фамилииToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.фамилииToolStripMenuItem.Text = "Фамилии";
            this.фамилииToolStripMenuItem.Click += new System.EventHandler(this.фамилииToolStripMenuItem_Click);
            // 
            // регионаToolStripMenuItem
            // 
            this.регионаToolStripMenuItem.Name = "регионаToolStripMenuItem";
            this.регионаToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.регионаToolStripMenuItem.Text = "Региона";
            this.регионаToolStripMenuItem.Click += new System.EventHandler(this.регионаToolStripMenuItem_Click);
            // 
            // школыToolStripMenuItem
            // 
            this.школыToolStripMenuItem.Name = "школыToolStripMenuItem";
            this.школыToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.школыToolStripMenuItem.Text = "Школы";
            this.школыToolStripMenuItem.Click += new System.EventHandler(this.школыToolStripMenuItem_Click);
            // 
            // классаToolStripMenuItem
            // 
            this.классаToolStripMenuItem.Name = "классаToolStripMenuItem";
            this.классаToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.классаToolStripMenuItem.Text = "Номера класса";
            this.классаToolStripMenuItem.Click += new System.EventHandler(this.классаToolStripMenuItem_Click);
            // 
            // балловToolStripMenuItem
            // 
            this.балловToolStripMenuItem.Name = "балловToolStripMenuItem";
            this.балловToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.балловToolStripMenuItem.Text = "Номера паспорта";
            this.балловToolStripMenuItem.Click += new System.EventHandler(this.балловToolStripMenuItem_Click);
            // 
            // местаToolStripMenuItem
            // 
            this.местаToolStripMenuItem.Name = "местаToolStripMenuItem";
            this.местаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.местаToolStripMenuItem.Text = "Номера телефона";
            this.местаToolStripMenuItem.Click += new System.EventHandler(this.местаToolStripMenuItem_Click);
            // 
            // поУбываниюToolStripMenuItem
            // 
            this.поУбываниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имениToolStripMenuItem1,
            this.фамилииToolStripMenuItem1,
            this.регионаToolStripMenuItem1,
            this.школыToolStripMenuItem1,
            this.классаToolStripMenuItem1,
            this.балловToolStripMenuItem1,
            this.местаToolStripMenuItem1});
            this.поУбываниюToolStripMenuItem.Name = "поУбываниюToolStripMenuItem";
            this.поУбываниюToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.поУбываниюToolStripMenuItem.Text = "По убыванию";
            // 
            // имениToolStripMenuItem1
            // 
            this.имениToolStripMenuItem1.Name = "имениToolStripMenuItem1";
            this.имениToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.имениToolStripMenuItem1.Text = "Имени";
            this.имениToolStripMenuItem1.Click += new System.EventHandler(this.имениToolStripMenuItem1_Click);
            // 
            // фамилииToolStripMenuItem1
            // 
            this.фамилииToolStripMenuItem1.Name = "фамилииToolStripMenuItem1";
            this.фамилииToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.фамилииToolStripMenuItem1.Text = "Фамилии";
            this.фамилииToolStripMenuItem1.Click += new System.EventHandler(this.фамилииToolStripMenuItem1_Click);
            // 
            // регионаToolStripMenuItem1
            // 
            this.регионаToolStripMenuItem1.Name = "регионаToolStripMenuItem1";
            this.регионаToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.регионаToolStripMenuItem1.Text = "Региона";
            this.регионаToolStripMenuItem1.Click += new System.EventHandler(this.регионаToolStripMenuItem1_Click);
            // 
            // школыToolStripMenuItem1
            // 
            this.школыToolStripMenuItem1.Name = "школыToolStripMenuItem1";
            this.школыToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.школыToolStripMenuItem1.Text = "Школы";
            this.школыToolStripMenuItem1.Click += new System.EventHandler(this.школыToolStripMenuItem1_Click);
            // 
            // классаToolStripMenuItem1
            // 
            this.классаToolStripMenuItem1.Name = "классаToolStripMenuItem1";
            this.классаToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.классаToolStripMenuItem1.Text = "Номера класса";
            this.классаToolStripMenuItem1.Click += new System.EventHandler(this.классаToolStripMenuItem1_Click);
            // 
            // балловToolStripMenuItem1
            // 
            this.балловToolStripMenuItem1.Name = "балловToolStripMenuItem1";
            this.балловToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.балловToolStripMenuItem1.Text = "Номера паспорта";
            this.балловToolStripMenuItem1.Click += new System.EventHandler(this.балловToolStripMenuItem1_Click);
            // 
            // местаToolStripMenuItem1
            // 
            this.местаToolStripMenuItem1.Name = "местаToolStripMenuItem1";
            this.местаToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.местаToolStripMenuItem1.Text = "Номера телефона";
            this.местаToolStripMenuItem1.Click += new System.EventHandler(this.местаToolStripMenuItem1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(901, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(901, 268);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(311, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(901, 297);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(311, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(901, 325);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(311, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(901, 353);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(311, 22);
            this.textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(901, 382);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(311, 22);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(901, 411);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(311, 22);
            this.textBox7.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(717, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 52);
            this.button3.TabIndex = 11;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 53);
            this.button4.TabIndex = 12;
            this.button4.Text = "Экспорт таблицы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(45, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 51);
            this.button5.TabIndex = 13;
            this.button5.Text = "Сбор статистики";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "First_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Регион";
            this.regionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            this.regionDataGridViewTextBoxColumn.ReadOnly = true;
            this.regionDataGridViewTextBoxColumn.Width = 125;
            // 
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "School";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "Школа";
            this.schoolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.ReadOnly = true;
            this.schoolDataGridViewTextBoxColumn.Width = 125;
            // 
            // theсlassDataGridViewTextBoxColumn
            // 
            this.theсlassDataGridViewTextBoxColumn.DataPropertyName = "The_сlass";
            this.theсlassDataGridViewTextBoxColumn.HeaderText = "Класс";
            this.theсlassDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.theсlassDataGridViewTextBoxColumn.Name = "theсlassDataGridViewTextBoxColumn";
            this.theсlassDataGridViewTextBoxColumn.ReadOnly = true;
            this.theсlassDataGridViewTextBoxColumn.Width = 125;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Пасспорт (без серии)";
            this.passportDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.ReadOnly = true;
            this.passportDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон +7495...";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Информация об участниках";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberinfoBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource memberinfoBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оСоздателеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регионаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem школыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem балловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem местаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имениToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фамилииToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem регионаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem школыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem классаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem балловToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem местаToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theсlassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
    }
}