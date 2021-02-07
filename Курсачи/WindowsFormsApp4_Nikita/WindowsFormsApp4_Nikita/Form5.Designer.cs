namespace WindowsFormsApp4_Nikita
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofprodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kvadroinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортироватьПоУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.годаПроизводстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мощностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоВозрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителяToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.моделиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.годаПроизводстваToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.количестваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.мощностиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ценыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvadroinfoBindingSource)).BeginInit();
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
            this.modelDataGridViewTextBoxColumn,
            this.yearofprodDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kvadroinfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(993, 187);
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
            this.button1.Location = new System.Drawing.Point(40, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 75);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отчёт в эксель";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортироватьПоУбываниюToolStripMenuItem,
            this.сортировкаПоВозрастаниюToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // сортироватьПоУбываниюToolStripMenuItem
            // 
            this.сортироватьПоУбываниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.производителяToolStripMenuItem,
            this.моделиToolStripMenuItem,
            this.годаПроизводстваToolStripMenuItem,
            this.количествуToolStripMenuItem,
            this.мощностиToolStripMenuItem,
            this.ценеToolStripMenuItem});
            this.сортироватьПоУбываниюToolStripMenuItem.Name = "сортироватьПоУбываниюToolStripMenuItem";
            this.сортироватьПоУбываниюToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.сортироватьПоУбываниюToolStripMenuItem.Text = "Сортировка по убыванию";
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
            // количествуToolStripMenuItem
            // 
            this.количествуToolStripMenuItem.Name = "количествуToolStripMenuItem";
            this.количествуToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.количествуToolStripMenuItem.Text = "Количества";
            this.количествуToolStripMenuItem.Click += new System.EventHandler(this.количествуToolStripMenuItem_Click);
            // 
            // мощностиToolStripMenuItem
            // 
            this.мощностиToolStripMenuItem.Name = "мощностиToolStripMenuItem";
            this.мощностиToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.мощностиToolStripMenuItem.Text = "Мощности";
            this.мощностиToolStripMenuItem.Click += new System.EventHandler(this.мощностиToolStripMenuItem_Click);
            // 
            // ценеToolStripMenuItem
            // 
            this.ценеToolStripMenuItem.Name = "ценеToolStripMenuItem";
            this.ценеToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.ценеToolStripMenuItem.Text = "Цены";
            this.ценеToolStripMenuItem.Click += new System.EventHandler(this.ценеToolStripMenuItem_Click);
            // 
            // сортировкаПоВозрастаниюToolStripMenuItem
            // 
            this.сортировкаПоВозрастаниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.производителяToolStripMenuItem1,
            this.моделиToolStripMenuItem1,
            this.годаПроизводстваToolStripMenuItem1,
            this.количестваToolStripMenuItem,
            this.мощностиToolStripMenuItem1,
            this.ценыToolStripMenuItem});
            this.сортировкаПоВозрастаниюToolStripMenuItem.Name = "сортировкаПоВозрастаниюToolStripMenuItem";
            this.сортировкаПоВозрастаниюToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.сортировкаПоВозрастаниюToolStripMenuItem.Text = "Сортировка по возрастанию";
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
            // количестваToolStripMenuItem
            // 
            this.количестваToolStripMenuItem.Name = "количестваToolStripMenuItem";
            this.количестваToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.количестваToolStripMenuItem.Text = "Количества";
            this.количестваToolStripMenuItem.Click += new System.EventHandler(this.количестваToolStripMenuItem_Click);
            // 
            // мощностиToolStripMenuItem1
            // 
            this.мощностиToolStripMenuItem1.Name = "мощностиToolStripMenuItem1";
            this.мощностиToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.мощностиToolStripMenuItem1.Text = "Мощности";
            this.мощностиToolStripMenuItem1.Click += new System.EventHandler(this.мощностиToolStripMenuItem1_Click);
            // 
            // ценыToolStripMenuItem
            // 
            this.ценыToolStripMenuItem.Name = "ценыToolStripMenuItem";
            this.ценыToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.ценыToolStripMenuItem.Text = "Цены";
            this.ценыToolStripMenuItem.Click += new System.EventHandler(this.ценыToolStripMenuItem_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(40, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 75);
            this.button2.TabIndex = 3;
            this.button2.Text = "Статистика";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(417, 231);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Квадроциклы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kvadroinfoBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearofprodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource kvadroinfoBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоВозрастаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem годаПроизводстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мощностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem производителяToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem моделиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem годаПроизводстваToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem количестваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem мощностиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ценыToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}