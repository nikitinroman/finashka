namespace WindowsFormsApp4_Nikita
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортировкаПоУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.годаПроизводстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количестваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мощностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоВозрастниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.годаПроизводстваToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.количестваToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.мощностиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ценыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvadroinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvadroinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаПоУбываниюToolStripMenuItem,
            this.сортировкаПоВозрастниюToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1040, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сортировкаПоУбываниюToolStripMenuItem
            // 
            this.сортировкаПоУбываниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.производителяToolStripMenuItem,
            this.моделиToolStripMenuItem,
            this.годаПроизводстваToolStripMenuItem,
            this.количестваToolStripMenuItem,
            this.мощностиToolStripMenuItem,
            this.ценыToolStripMenuItem});
            this.сортировкаПоУбываниюToolStripMenuItem.Name = "сортировкаПоУбываниюToolStripMenuItem";
            this.сортировкаПоУбываниюToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.сортировкаПоУбываниюToolStripMenuItem.Text = "Сортировка по убыванию";
            this.сортировкаПоУбываниюToolStripMenuItem.Click += new System.EventHandler(this.сортировкаПоУбываниюToolStripMenuItem_Click);
            // 
            // производителяToolStripMenuItem
            // 
            this.производителяToolStripMenuItem.Name = "производителяToolStripMenuItem";
            this.производителяToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.производителяToolStripMenuItem.Text = "Производителя";
            this.производителяToolStripMenuItem.Click += new System.EventHandler(this.производителяToolStripMenuItem_Click);
            // 
            // моделиToolStripMenuItem
            // 
            this.моделиToolStripMenuItem.Name = "моделиToolStripMenuItem";
            this.моделиToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.моделиToolStripMenuItem.Text = "Модели";
            this.моделиToolStripMenuItem.Click += new System.EventHandler(this.моделиToolStripMenuItem_Click);
            // 
            // годаПроизводстваToolStripMenuItem
            // 
            this.годаПроизводстваToolStripMenuItem.Name = "годаПроизводстваToolStripMenuItem";
            this.годаПроизводстваToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.годаПроизводстваToolStripMenuItem.Text = "Года производства";
            this.годаПроизводстваToolStripMenuItem.Click += new System.EventHandler(this.годаПроизводстваToolStripMenuItem_Click);
            // 
            // количестваToolStripMenuItem
            // 
            this.количестваToolStripMenuItem.Name = "количестваToolStripMenuItem";
            this.количестваToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.количестваToolStripMenuItem.Text = "Количества";
            this.количестваToolStripMenuItem.Click += new System.EventHandler(this.количестваToolStripMenuItem_Click);
            // 
            // мощностиToolStripMenuItem
            // 
            this.мощностиToolStripMenuItem.Name = "мощностиToolStripMenuItem";
            this.мощностиToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.мощностиToolStripMenuItem.Text = "Мощности";
            this.мощностиToolStripMenuItem.Click += new System.EventHandler(this.мощностиToolStripMenuItem_Click);
            // 
            // ценыToolStripMenuItem
            // 
            this.ценыToolStripMenuItem.Name = "ценыToolStripMenuItem";
            this.ценыToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.ценыToolStripMenuItem.Text = "Цены";
            this.ценыToolStripMenuItem.Click += new System.EventHandler(this.ценыToolStripMenuItem_Click);
            // 
            // сортировкаПоВозрастниюToolStripMenuItem
            // 
            this.сортировкаПоВозрастниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.производителяToolStripMenuItem1,
            this.моделиToolStripMenuItem1,
            this.годаПроизводстваToolStripMenuItem1,
            this.количестваToolStripMenuItem1,
            this.мощностиToolStripMenuItem1,
            this.ценыToolStripMenuItem1});
            this.сортировкаПоВозрастниюToolStripMenuItem.Name = "сортировкаПоВозрастниюToolStripMenuItem";
            this.сортировкаПоВозрастниюToolStripMenuItem.Size = new System.Drawing.Size(216, 24);
            this.сортировкаПоВозрастниюToolStripMenuItem.Text = "Сортировка по возрастнию";
            // 
            // производителяToolStripMenuItem1
            // 
            this.производителяToolStripMenuItem1.Name = "производителяToolStripMenuItem1";
            this.производителяToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.производителяToolStripMenuItem1.Text = "Производителя";
            this.производителяToolStripMenuItem1.Click += new System.EventHandler(this.производителяToolStripMenuItem1_Click);
            // 
            // моделиToolStripMenuItem1
            // 
            this.моделиToolStripMenuItem1.Name = "моделиToolStripMenuItem1";
            this.моделиToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.моделиToolStripMenuItem1.Text = "Модели";
            this.моделиToolStripMenuItem1.Click += new System.EventHandler(this.моделиToolStripMenuItem1_Click);
            // 
            // годаПроизводстваToolStripMenuItem1
            // 
            this.годаПроизводстваToolStripMenuItem1.Name = "годаПроизводстваToolStripMenuItem1";
            this.годаПроизводстваToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.годаПроизводстваToolStripMenuItem1.Text = "Года производства";
            this.годаПроизводстваToolStripMenuItem1.Click += new System.EventHandler(this.годаПроизводстваToolStripMenuItem1_Click);
            // 
            // количестваToolStripMenuItem1
            // 
            this.количестваToolStripMenuItem1.Name = "количестваToolStripMenuItem1";
            this.количестваToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.количестваToolStripMenuItem1.Text = "Количества";
            this.количестваToolStripMenuItem1.Click += new System.EventHandler(this.количестваToolStripMenuItem1_Click);
            // 
            // мощностиToolStripMenuItem1
            // 
            this.мощностиToolStripMenuItem1.Name = "мощностиToolStripMenuItem1";
            this.мощностиToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.мощностиToolStripMenuItem1.Text = "Мощности";
            this.мощностиToolStripMenuItem1.Click += new System.EventHandler(this.мощностиToolStripMenuItem1_Click);
            // 
            // ценыToolStripMenuItem1
            // 
            this.ценыToolStripMenuItem1.Name = "ценыToolStripMenuItem1";
            this.ценыToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.ценыToolStripMenuItem1.Text = "Цены";
            this.ценыToolStripMenuItem1.Click += new System.EventHandler(this.ценыToolStripMenuItem1_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.yearofprodDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kvadroinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1016, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearofprodDataGridViewTextBoxColumn
            // 
            this.yearofprodDataGridViewTextBoxColumn.DataPropertyName = "Year_of_prod";
            this.yearofprodDataGridViewTextBoxColumn.HeaderText = "Year_of_prod";
            this.yearofprodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearofprodDataGridViewTextBoxColumn.Name = "yearofprodDataGridViewTextBoxColumn";
            this.yearofprodDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolvoDataGridViewTextBoxColumn
            // 
            this.kolvoDataGridViewTextBoxColumn.DataPropertyName = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn.HeaderText = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolvoDataGridViewTextBoxColumn.Name = "kolvoDataGridViewTextBoxColumn";
            this.kolvoDataGridViewTextBoxColumn.Width = 125;
            // 
            // powerDataGridViewTextBoxColumn
            // 
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "Power";
            this.powerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            this.powerDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // kvadroinfoBindingSource
            // 
            this.kvadroinfoBindingSource.DataSource = typeof(WindowsFormsApp4_Nikita.Kvadro_info);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(434, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(434, 251);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(389, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(434, 293);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(389, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(434, 335);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(389, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(434, 376);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(389, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(434, 416);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(389, 22);
            this.textBox6.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(211, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 42);
            this.button4.TabIndex = 12;
            this.button4.Text = "Отчёт в эксель";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(210, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 40);
            this.button5.TabIndex = 13;
            this.button5.Text = "Статистика";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Квадроциклы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvadroinfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоВозрастниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearofprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kvadroinfoBindingSource;
        private System.Windows.Forms.ToolStripMenuItem производителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem годаПроизводстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количестваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мощностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производителяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem моделиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem годаПроизводстваToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem количестваToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem мощностиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ценыToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}