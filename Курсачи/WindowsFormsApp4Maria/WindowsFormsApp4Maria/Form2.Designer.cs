namespace WindowsFormsApp4Maria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theсlassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оСоздателеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имениToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поВозрастаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имениToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.названияПредметаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номеруКлассаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествуБалловToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУбываниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.имениToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.фамилииToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.названиюПредметаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номеруКлассаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.количествуБалловToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.menuStrip2.SuspendLayout();
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
            this.subjectDataGridViewTextBoxColumn,
            this.theсlassDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memberBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(13, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1198, 208);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.subjectDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectDataGridViewTextBoxColumn.Width = 125;
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
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Баллы";
            this.scoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.scoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(WindowsFormsApp4Maria.Member);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1223, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(791, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(791, 277);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(420, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(791, 307);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(420, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(791, 335);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(420, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(791, 365);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(420, 22);
            this.textBox5.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(819, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 45);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(955, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1082, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 45);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(58, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 53);
            this.button4.TabIndex = 10;
            this.button4.Text = "Экспорт таблицы";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(58, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 55);
            this.button5.TabIndex = 11;
            this.button5.Text = "Сбор статистики";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(58, 379);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 59);
            this.button6.TabIndex = 12;
            this.button6.Text = "Информация об олимпиадниках";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.оСоздателеToolStripMenuItem,
            this.сортироватьПоУбываниюToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1223, 30);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оСоздателеToolStripMenuItem
            // 
            this.оСоздателеToolStripMenuItem.Name = "оСоздателеToolStripMenuItem";
            this.оСоздателеToolStripMenuItem.Size = new System.Drawing.Size(107, 26);
            this.оСоздателеToolStripMenuItem.Text = "О создателе";
            this.оСоздателеToolStripMenuItem.Click += new System.EventHandler(this.оСоздателеToolStripMenuItem_Click);
            // 
            // сортироватьПоУбываниюToolStripMenuItem
            // 
            this.сортироватьПоУбываниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имениToolStripMenuItem});
            this.сортироватьПоУбываниюToolStripMenuItem.Name = "сортироватьПоУбываниюToolStripMenuItem";
            this.сортироватьПоУбываниюToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.сортироватьПоУбываниюToolStripMenuItem.Text = "Сортировать";
            // 
            // имениToolStripMenuItem
            // 
            this.имениToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поВозрастаниюToolStripMenuItem,
            this.поУбываниюToolStripMenuItem});
            this.имениToolStripMenuItem.Name = "имениToolStripMenuItem";
            this.имениToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.имениToolStripMenuItem.Text = "Выбрать";
            // 
            // поВозрастаниюToolStripMenuItem
            // 
            this.поВозрастаниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имениToolStripMenuItem1,
            this.фамилииToolStripMenuItem,
            this.названияПредметаToolStripMenuItem,
            this.номеруКлассаToolStripMenuItem,
            this.количествуБалловToolStripMenuItem});
            this.поВозрастаниюToolStripMenuItem.Name = "поВозрастаниюToolStripMenuItem";
            this.поВозрастаниюToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.поВозрастаниюToolStripMenuItem.Text = "По возрастанию";
            // 
            // имениToolStripMenuItem1
            // 
            this.имениToolStripMenuItem1.Name = "имениToolStripMenuItem1";
            this.имениToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.имениToolStripMenuItem1.Text = "Имени";
            this.имениToolStripMenuItem1.Click += new System.EventHandler(this.имениToolStripMenuItem1_Click);
            // 
            // фамилииToolStripMenuItem
            // 
            this.фамилииToolStripMenuItem.Name = "фамилииToolStripMenuItem";
            this.фамилииToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.фамилииToolStripMenuItem.Text = "Фамилии";
            this.фамилииToolStripMenuItem.Click += new System.EventHandler(this.фамилииToolStripMenuItem_Click);
            // 
            // названияПредметаToolStripMenuItem
            // 
            this.названияПредметаToolStripMenuItem.Name = "названияПредметаToolStripMenuItem";
            this.названияПредметаToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.названияПредметаToolStripMenuItem.Text = "Названию предмета";
            this.названияПредметаToolStripMenuItem.Click += new System.EventHandler(this.названияПредметаToolStripMenuItem_Click);
            // 
            // номеруКлассаToolStripMenuItem
            // 
            this.номеруКлассаToolStripMenuItem.Name = "номеруКлассаToolStripMenuItem";
            this.номеруКлассаToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.номеруКлассаToolStripMenuItem.Text = "Номера класса";
            this.номеруКлассаToolStripMenuItem.Click += new System.EventHandler(this.номеруКлассаToolStripMenuItem_Click);
            // 
            // количествуБалловToolStripMenuItem
            // 
            this.количествуБалловToolStripMenuItem.Name = "количествуБалловToolStripMenuItem";
            this.количествуБалловToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.количествуБалловToolStripMenuItem.Text = "Количества баллов";
            this.количествуБалловToolStripMenuItem.Click += new System.EventHandler(this.количествуБалловToolStripMenuItem_Click);
            // 
            // поУбываниюToolStripMenuItem
            // 
            this.поУбываниюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.имениToolStripMenuItem2,
            this.фамилииToolStripMenuItem1,
            this.названиюПредметаToolStripMenuItem,
            this.номеруКлассаToolStripMenuItem1,
            this.количествуБалловToolStripMenuItem1});
            this.поУбываниюToolStripMenuItem.Name = "поУбываниюToolStripMenuItem";
            this.поУбываниюToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.поУбываниюToolStripMenuItem.Text = "По убыванию";
            // 
            // имениToolStripMenuItem2
            // 
            this.имениToolStripMenuItem2.Name = "имениToolStripMenuItem2";
            this.имениToolStripMenuItem2.Size = new System.Drawing.Size(235, 26);
            this.имениToolStripMenuItem2.Text = "Имени";
            this.имениToolStripMenuItem2.Click += new System.EventHandler(this.имениToolStripMenuItem2_Click);
            // 
            // фамилииToolStripMenuItem1
            // 
            this.фамилииToolStripMenuItem1.Name = "фамилииToolStripMenuItem1";
            this.фамилииToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.фамилииToolStripMenuItem1.Text = "Фамилии";
            this.фамилииToolStripMenuItem1.Click += new System.EventHandler(this.фамилииToolStripMenuItem1_Click);
            // 
            // названиюПредметаToolStripMenuItem
            // 
            this.названиюПредметаToolStripMenuItem.Name = "названиюПредметаToolStripMenuItem";
            this.названиюПредметаToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.названиюПредметаToolStripMenuItem.Text = "Названию предмета";
            this.названиюПредметаToolStripMenuItem.Click += new System.EventHandler(this.названиюПредметаToolStripMenuItem_Click);
            // 
            // номеруКлассаToolStripMenuItem1
            // 
            this.номеруКлассаToolStripMenuItem1.Name = "номеруКлассаToolStripMenuItem1";
            this.номеруКлассаToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.номеруКлассаToolStripMenuItem1.Text = "Номера класса";
            this.номеруКлассаToolStripMenuItem1.Click += new System.EventHandler(this.номеруКлассаToolStripMenuItem1_Click);
            // 
            // количествуБалловToolStripMenuItem1
            // 
            this.количествуБалловToolStripMenuItem1.Name = "количествуБалловToolStripMenuItem1";
            this.количествуБалловToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.количествуБалловToolStripMenuItem1.Text = "Количества баллов";
            this.количествуБалловToolStripMenuItem1.Click += new System.EventHandler(this.количествуБалловToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(363, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Информация об олимпиадах";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оСоздателеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имениToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поВозрастаниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имениToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem названияПредметаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номеруКлассаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествуБалловToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поУбываниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem имениToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem фамилииToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem названиюПредметаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номеруКлассаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem количествуБалловToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theсlassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
    }
}