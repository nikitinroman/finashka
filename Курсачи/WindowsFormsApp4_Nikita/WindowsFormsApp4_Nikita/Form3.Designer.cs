﻿namespace WindowsFormsApp4_Nikita
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalisationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofstartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvadromanufBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортировкаПоУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хозяинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стоимостиКомпанииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.годаОснованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.странеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоВозрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.хозяинаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.стоимостиКомпанииToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.годаОснованияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.страныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvadromanufBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturerDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.capitalisationDataGridViewTextBoxColumn,
            this.yearofstartDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kvadromanufBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(918, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.Width = 125;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Owner";
            this.ownerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.Width = 125;
            // 
            // capitalisationDataGridViewTextBoxColumn
            // 
            this.capitalisationDataGridViewTextBoxColumn.DataPropertyName = "Capitalisation";
            this.capitalisationDataGridViewTextBoxColumn.HeaderText = "Capitalisation";
            this.capitalisationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capitalisationDataGridViewTextBoxColumn.Name = "capitalisationDataGridViewTextBoxColumn";
            this.capitalisationDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearofstartDataGridViewTextBoxColumn
            // 
            this.yearofstartDataGridViewTextBoxColumn.DataPropertyName = "Year_of_start";
            this.yearofstartDataGridViewTextBoxColumn.HeaderText = "Year_of_start";
            this.yearofstartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearofstartDataGridViewTextBoxColumn.Name = "yearofstartDataGridViewTextBoxColumn";
            this.yearofstartDataGridViewTextBoxColumn.Width = 125;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 125;
            // 
            // kvadromanufBindingSource
            // 
            this.kvadromanufBindingSource.DataSource = typeof(WindowsFormsApp4_Nikita.Kvadro_manuf);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаПоУбываниюToolStripMenuItem,
            this.сортировкаПоВозрастаниюToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сортировкаПоУбываниюToolStripMenuItem
            // 
            this.сортировкаПоУбываниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.производителяToolStripMenuItem,
            this.хозяинаToolStripMenuItem,
            this.стоимостиКомпанииToolStripMenuItem,
            this.годаОснованияToolStripMenuItem,
            this.странеToolStripMenuItem});
            this.сортировкаПоУбываниюToolStripMenuItem.Name = "сортировкаПоУбываниюToolStripMenuItem";
            this.сортировкаПоУбываниюToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.сортировкаПоУбываниюToolStripMenuItem.Text = "Сортировка по убыванию";
            this.сортировкаПоУбываниюToolStripMenuItem.Click += new System.EventHandler(this.сортировкаПоУбываниюToolStripMenuItem_Click);
            // 
            // производителяToolStripMenuItem
            // 
            this.производителяToolStripMenuItem.Name = "производителяToolStripMenuItem";
            this.производителяToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.производителяToolStripMenuItem.Text = "Производителя";
            this.производителяToolStripMenuItem.Click += new System.EventHandler(this.производителяToolStripMenuItem_Click);
            // 
            // хозяинаToolStripMenuItem
            // 
            this.хозяинаToolStripMenuItem.Name = "хозяинаToolStripMenuItem";
            this.хозяинаToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.хозяинаToolStripMenuItem.Text = "Хозяина";
            this.хозяинаToolStripMenuItem.Click += new System.EventHandler(this.хозяинаToolStripMenuItem_Click);
            // 
            // стоимостиКомпанииToolStripMenuItem
            // 
            this.стоимостиКомпанииToolStripMenuItem.Name = "стоимостиКомпанииToolStripMenuItem";
            this.стоимостиКомпанииToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.стоимостиКомпанииToolStripMenuItem.Text = "Стоимости компании";
            this.стоимостиКомпанииToolStripMenuItem.Click += new System.EventHandler(this.стоимостиКомпанииToolStripMenuItem_Click);
            // 
            // годаОснованияToolStripMenuItem
            // 
            this.годаОснованияToolStripMenuItem.Name = "годаОснованияToolStripMenuItem";
            this.годаОснованияToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.годаОснованияToolStripMenuItem.Text = "Года основания";
            this.годаОснованияToolStripMenuItem.Click += new System.EventHandler(this.годаОснованияToolStripMenuItem_Click);
            // 
            // странеToolStripMenuItem
            // 
            this.странеToolStripMenuItem.Name = "странеToolStripMenuItem";
            this.странеToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.странеToolStripMenuItem.Text = "Страны";
            this.странеToolStripMenuItem.Click += new System.EventHandler(this.странеToolStripMenuItem_Click);
            // 
            // сортировкаПоВозрастаниюToolStripMenuItem
            // 
            this.сортировкаПоВозрастаниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.производителяToolStripMenuItem1,
            this.хозяинаToolStripMenuItem1,
            this.стоимостиКомпанииToolStripMenuItem1,
            this.годаОснованияToolStripMenuItem1,
            this.страныToolStripMenuItem});
            this.сортировкаПоВозрастаниюToolStripMenuItem.Name = "сортировкаПоВозрастаниюToolStripMenuItem";
            this.сортировкаПоВозрастаниюToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.сортировкаПоВозрастаниюToolStripMenuItem.Text = "Сортировка по возрастанию";
            // 
            // производителяToolStripMenuItem1
            // 
            this.производителяToolStripMenuItem1.Name = "производителяToolStripMenuItem1";
            this.производителяToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.производителяToolStripMenuItem1.Text = "Производителя";
            this.производителяToolStripMenuItem1.Click += new System.EventHandler(this.производителяToolStripMenuItem1_Click);
            // 
            // хозяинаToolStripMenuItem1
            // 
            this.хозяинаToolStripMenuItem1.Name = "хозяинаToolStripMenuItem1";
            this.хозяинаToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.хозяинаToolStripMenuItem1.Text = "Хозяина";
            this.хозяинаToolStripMenuItem1.Click += new System.EventHandler(this.хозяинаToolStripMenuItem1_Click);
            // 
            // стоимостиКомпанииToolStripMenuItem1
            // 
            this.стоимостиКомпанииToolStripMenuItem1.Name = "стоимостиКомпанииToolStripMenuItem1";
            this.стоимостиКомпанииToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.стоимостиКомпанииToolStripMenuItem1.Text = "Стоимости компании";
            this.стоимостиКомпанииToolStripMenuItem1.Click += new System.EventHandler(this.стоимостиКомпанииToolStripMenuItem1_Click);
            // 
            // годаОснованияToolStripMenuItem1
            // 
            this.годаОснованияToolStripMenuItem1.Name = "годаОснованияToolStripMenuItem1";
            this.годаОснованияToolStripMenuItem1.Size = new System.Drawing.Size(242, 26);
            this.годаОснованияToolStripMenuItem1.Text = "Года основания";
            this.годаОснованияToolStripMenuItem1.Click += new System.EventHandler(this.годаОснованияToolStripMenuItem1_Click);
            // 
            // страныToolStripMenuItem
            // 
            this.страныToolStripMenuItem.Name = "страныToolStripMenuItem";
            this.страныToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.страныToolStripMenuItem.Text = "Страны";
            this.страныToolStripMenuItem.Click += new System.EventHandler(this.страныToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отчёт в эксель";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Статистика";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "Информация о квадроциклах";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(536, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 504);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Компании";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed_1);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvadromanufBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоВозрастаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalisationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearofstartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kvadromanufBindingSource;
        private System.Windows.Forms.ToolStripMenuItem производителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хозяинаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стоимостиКомпанииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem годаОснованияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem странеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производителяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem хозяинаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem стоимостиКомпанииToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem годаОснованияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem страныToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}