namespace IBR
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пыльцынаАнастасияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.даннаяПрограммаРазработаннаСтудентомГруппыПИ181ПыльцынойАнастасиейВ2020ГодуВРамкахКурсовойРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьГрафикПоТекущемуРегионуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.графикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.влажностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.давлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.силаВетраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.осадкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(697, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 108);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(697, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регионы:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(697, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить показатель";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(697, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Изменить показатель";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить показатель";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(697, 317);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "Добавить регион";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(664, 310);
            this.dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Список климитеческих показаний региона по годам";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обАвтореToolStripMenuItem,
            this.построитьГрафикПоТекущемуРегионуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.информацияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.обАвтореToolStripMenuItem.Text = "Информация";
            // 
            // информацияToolStripMenuItem
            // 
            this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пыльцынаАнастасияToolStripMenuItem});
            this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
            this.информацияToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.информацияToolStripMenuItem.Text = "Об авторе";
            this.информацияToolStripMenuItem.Click += new System.EventHandler(this.информацияToolStripMenuItem_Click);
            // 
            // пыльцынаАнастасияToolStripMenuItem
            // 
            this.пыльцынаАнастасияToolStripMenuItem.Name = "пыльцынаАнастасияToolStripMenuItem";
            this.пыльцынаАнастасияToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.пыльцынаАнастасияToolStripMenuItem.Text = "Пыльцына Анастасия";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.даннаяПрограммаРазработаннаСтудентомГруппыПИ181ПыльцынойАнастасиейВ2020ГодуВРамкахКурсовойРаботыToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // даннаяПрограммаРазработаннаСтудентомГруппыПИ181ПыльцынойАнастасиейВ2020ГодуВРамкахКурсовойРаботыToolStripMenuItem
            // 
            this.даннаяПрограммаРазработаннаСтудентомГруппыПИ181ПыльцынойАнастасиейВ2020ГодуВРамкахКурсовойРаботыToolStripMenuItem.Name = "даннаяПрограммаРазработаннаСтудентомГруппыПИ181ПыльцынойАнастасиейВ2020ГодуВРамка" +
                "хКурсовойРаботыToolStripMenuItem";
            this.даннаяПрограммаРазработаннаСтудентомГруппыПИ181ПыльцынойАнастасиейВ2020ГодуВРамкахКурсовойРаботыToolStripMenuItem.Size = new System.Drawing.Size(764, 22);
            this.даннаяПрограммаРазработаннаСтудентомГруппыПИ181ПыльцынойАнастасиейВ2020ГодуВРамкахКурсовойРаботыToolStripMenuItem.Text = "Данная программа разработанна студентом группы ПИ18-1 Пыльцыной Анастасией  в 202" +
                "0 году в рамках курсовой работы.";
            // 
            // построитьГрафикПоТекущемуРегионуToolStripMenuItem
            // 
            this.построитьГрафикПоТекущемуРегионуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.графикToolStripMenuItem,
            this.влажностьToolStripMenuItem,
            this.давлениеToolStripMenuItem,
            this.силаВетраToolStripMenuItem,
            this.осадкиToolStripMenuItem});
            this.построитьГрафикПоТекущемуРегионуToolStripMenuItem.Name = "построитьГрафикПоТекущемуРегионуToolStripMenuItem";
            this.построитьГрафикПоТекущемуРегионуToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.построитьГрафикПоТекущемуРегионуToolStripMenuItem.Text = "Построить график по текущему региону";
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Location = new System.Drawing.Point(12, 390);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(664, 246);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(736, 584);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 40);
            this.button5.TabIndex = 11;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(697, 426);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Минимум:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Максимум:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(697, 480);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(136, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Среднее:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(697, 538);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(136, 20);
            this.textBox3.TabIndex = 16;
            // 
            // графикToolStripMenuItem
            // 
            this.графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            this.графикToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.графикToolStripMenuItem.Text = "Температура";
            this.графикToolStripMenuItem.Click += new System.EventHandler(this.графикToolStripMenuItem_Click);
            // 
            // влажностьToolStripMenuItem
            // 
            this.влажностьToolStripMenuItem.Name = "влажностьToolStripMenuItem";
            this.влажностьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.влажностьToolStripMenuItem.Text = "Влажность";
            this.влажностьToolStripMenuItem.Click += new System.EventHandler(this.влажностьToolStripMenuItem_Click);
            // 
            // давлениеToolStripMenuItem
            // 
            this.давлениеToolStripMenuItem.Name = "давлениеToolStripMenuItem";
            this.давлениеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.давлениеToolStripMenuItem.Text = "Давление";
            this.давлениеToolStripMenuItem.Click += new System.EventHandler(this.давлениеToolStripMenuItem_Click);
            // 
            // силаВетраToolStripMenuItem
            // 
            this.силаВетраToolStripMenuItem.Name = "силаВетраToolStripMenuItem";
            this.силаВетраToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.силаВетраToolStripMenuItem.Text = "Сила ветра";
            this.силаВетраToolStripMenuItem.Click += new System.EventHandler(this.силаВетраToolStripMenuItem_Click);
            // 
            // осадкиToolStripMenuItem
            // 
            this.осадкиToolStripMenuItem.Name = "осадкиToolStripMenuItem";
            this.осадкиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.осадкиToolStripMenuItem.Text = "Осадки";
            this.осадкиToolStripMenuItem.Click += new System.EventHandler(this.осадкиToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 648);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Показатели регионов по годам";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьГрафикПоТекущемуРегионуToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пыльцынаАнастасияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem даннаяПрограммаРазработаннаСтудентомГруппыПИ181ПыльцынойАнастасиейВ2020ГодуВРамкахКурсовойРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem графикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem влажностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem давлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem силаВетраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem осадкиToolStripMenuItem;
    }
}

