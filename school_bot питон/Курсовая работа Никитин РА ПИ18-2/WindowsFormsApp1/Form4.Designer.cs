namespace WindowsFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоВозрастаниюЦеныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаПоУбываниюЦеныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоТипуМоделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоВозрастаниюКоличестваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоУбываниюКоличестваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоВозрастаниюРейтингаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоУбываниюРейтингаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоМоделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 49);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить товар в Price_list";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.16F);
            this.button2.Location = new System.Drawing.Point(799, 376);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(195, 170);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 51);
            this.button3.TabIndex = 5;
            this.button3.Text = "Вывести текст из файла.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(195, 239);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 44);
            this.button4.TabIndex = 6;
            this.button4.Text = "Информация о принтерах";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(26, 108);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 45);
            this.button6.TabIndex = 9;
            this.button6.Text = "Продать принтер";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(429, 119);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(629, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(429, 156);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(629, 22);
            this.textBox5.TabIndex = 11;
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(429, 239);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(629, 22);
            this.textBox7.TabIndex = 13;
            this.textBox7.Click += new System.EventHandler(this.textBox7_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(429, 283);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(629, 22);
            this.textBox8.TabIndex = 14;
            this.textBox8.Click += new System.EventHandler(this.textBox8_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(429, 322);
            this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(629, 22);
            this.textBox9.TabIndex = 15;
            this.textBox9.Click += new System.EventHandler(this.textBox9_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(429, 199);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(629, 22);
            this.textBox6.TabIndex = 12;
            this.textBox6.Click += new System.EventHandler(this.textBox6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(26, 239);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 44);
            this.button7.TabIndex = 17;
            this.button7.Text = "Закупка недостающего";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(26, 173);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 48);
            this.button8.TabIndex = 18;
            this.button8.Text = "Вывести список необходимого";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(417, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Меню администратора";
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
            this.typeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.printerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 494);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1095, 199);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            this.rateDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolvoDataGridViewTextBoxColumn
            // 
            this.kolvoDataGridViewTextBoxColumn.DataPropertyName = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn.HeaderText = "Kol_vo";
            this.kolvoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolvoDataGridViewTextBoxColumn.Name = "kolvoDataGridViewTextBoxColumn";
            this.kolvoDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolvoDataGridViewTextBoxColumn.Width = 125;
            // 
            // printerBindingSource
            // 
            this.printerBindingSource.DataSource = typeof(WindowsFormsApp1.Printer);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(195, 108);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(143, 45);
            this.button9.TabIndex = 21;
            this.button9.Text = "Записать статистику";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(195, 49);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(143, 43);
            this.button10.TabIndex = 22;
            this.button10.Text = "Посмотреть статистику";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(26, 426);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(143, 49);
            this.button11.TabIndex = 23;
            this.button11.Text = "Откатить все данные";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(195, 298);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(143, 50);
            this.button12.TabIndex = 24;
            this.button12.Text = "Добавить нового пользователя";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(26, 359);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(143, 50);
            this.button13.TabIndex = 25;
            this.button13.Text = "Удалить пользователя";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(344, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(559, 359);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 119);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(780, 49);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(117, 49);
            this.button14.TabIndex = 28;
            this.button14.Text = "Изменение цвета окна";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(924, 49);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(117, 49);
            this.button15.TabIndex = 29;
            this.button15.Text = "Изменение цвета кнопок";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(26, 298);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(143, 50);
            this.button16.TabIndex = 30;
            this.button16.Text = "Список пользователей";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(195, 359);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(143, 50);
            this.button17.TabIndex = 31;
            this.button17.Text = "Сменить статус аккаунта";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(360, 381);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(143, 63);
            this.button18.TabIndex = 32;
            this.button18.Text = "Изменить инормацию о принтере";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(195, 426);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(143, 50);
            this.button19.TabIndex = 33;
            this.button19.Text = "Удалить принтер";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1121, 28);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортировкаПоВозрастаниюЦеныToolStripMenuItem,
            this.сортировкаПоУбываниюЦеныToolStripMenuItem,
            this.сортироватьПоНазваниюToolStripMenuItem,
            this.сортироватьПоТипуМоделиToolStripMenuItem,
            this.сортироватьПоВозрастаниюКоличестваToolStripMenuItem,
            this.сортироватьПоУбываниюКоличестваToolStripMenuItem,
            this.сортироватьПоВозрастаниюРейтингаToolStripMenuItem,
            this.сортироватьПоУбываниюРейтингаToolStripMenuItem,
            this.сортироватьПоМоделиToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // сортировкаПоВозрастаниюЦеныToolStripMenuItem
            // 
            this.сортировкаПоВозрастаниюЦеныToolStripMenuItem.Name = "сортировкаПоВозрастаниюЦеныToolStripMenuItem";
            this.сортировкаПоВозрастаниюЦеныToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.сортировкаПоВозрастаниюЦеныToolStripMenuItem.Text = "Сортировать по возрастанию цены";
            this.сортировкаПоВозрастаниюЦеныToolStripMenuItem.Click += new System.EventHandler(this.сортировкаПоВозрастаниюЦеныToolStripMenuItem_Click);
            // 
            // сортировкаПоУбываниюЦеныToolStripMenuItem
            // 
            this.сортировкаПоУбываниюЦеныToolStripMenuItem.Name = "сортировкаПоУбываниюЦеныToolStripMenuItem";
            this.сортировкаПоУбываниюЦеныToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.сортировкаПоУбываниюЦеныToolStripMenuItem.Text = "Сортировать по убыванию цены";
            this.сортировкаПоУбываниюЦеныToolStripMenuItem.Click += new System.EventHandler(this.сортировкаПоУбываниюЦеныToolStripMenuItem_Click);
            // 
            // сортироватьПоНазваниюToolStripMenuItem
            // 
            this.сортироватьПоНазваниюToolStripMenuItem.Name = "сортироватьПоНазваниюToolStripMenuItem";
            this.сортироватьПоНазваниюToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.сортироватьПоНазваниюToolStripMenuItem.Text = "Сортировать по названию";
            this.сортироватьПоНазваниюToolStripMenuItem.Click += new System.EventHandler(this.сортироватьПоНазваниюToolStripMenuItem_Click);
            // 
            // сортироватьПоТипуМоделиToolStripMenuItem
            // 
            this.сортироватьПоТипуМоделиToolStripMenuItem.Name = "сортироватьПоТипуМоделиToolStripMenuItem";
            this.сортироватьПоТипуМоделиToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.сортироватьПоТипуМоделиToolStripMenuItem.Text = "Сортировать по типу модели";
            this.сортироватьПоТипуМоделиToolStripMenuItem.Click += new System.EventHandler(this.сортироватьПоТипуМоделиToolStripMenuItem_Click);
            // 
            // сортироватьПоВозрастаниюКоличестваToolStripMenuItem
            // 
            this.сортироватьПоВозрастаниюКоличестваToolStripMenuItem.Name = "сортироватьПоВозрастаниюКоличестваToolStripMenuItem";
            this.сортироватьПоВозрастаниюКоличестваToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.сортироватьПоВозрастаниюКоличестваToolStripMenuItem.Text = "Сортировать по возрастанию количества";
            this.сортироватьПоВозрастаниюКоличестваToolStripMenuItem.Click += new System.EventHandler(this.сортироватьПоВозрастаниюКоличестваToolStripMenuItem_Click);
            // 
            // сортироватьПоУбываниюКоличестваToolStripMenuItem
            // 
            this.сортироватьПоУбываниюКоличестваToolStripMenuItem.Name = "сортироватьПоУбываниюКоличестваToolStripMenuItem";
            this.сортироватьПоУбываниюКоличестваToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.сортироватьПоУбываниюКоличестваToolStripMenuItem.Text = "Сортировать по убыванию количества";
            this.сортироватьПоУбываниюКоличестваToolStripMenuItem.Click += new System.EventHandler(this.сортироватьПоУбываниюКоличестваToolStripMenuItem_Click);
            // 
            // сортироватьПоВозрастаниюРейтингаToolStripMenuItem
            // 
            this.сортироватьПоВозрастаниюРейтингаToolStripMenuItem.Name = "сортироватьПоВозрастаниюРейтингаToolStripMenuItem";
            this.сортироватьПоВозрастаниюРейтингаToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.сортироватьПоВозрастаниюРейтингаToolStripMenuItem.Text = "Сортировать по возрастанию рейтинга";
            this.сортироватьПоВозрастаниюРейтингаToolStripMenuItem.Click += new System.EventHandler(this.сортироватьПоВозрастаниюРейтингаToolStripMenuItem_Click);
            // 
            // сортироватьПоУбываниюРейтингаToolStripMenuItem
            // 
            this.сортироватьПоУбываниюРейтингаToolStripMenuItem.Name = "сортироватьПоУбываниюРейтингаToolStripMenuItem";
            this.сортироватьПоУбываниюРейтингаToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.сортироватьПоУбываниюРейтингаToolStripMenuItem.Text = "Сортировать по убыванию рейтинга";
            this.сортироватьПоУбываниюРейтингаToolStripMenuItem.Click += new System.EventHandler(this.сортироватьПоУбываниюРейтингаToolStripMenuItem_Click);
            // 
            // сортироватьПоМоделиToolStripMenuItem
            // 
            this.сортироватьПоМоделиToolStripMenuItem.Name = "сортироватьПоМоделиToolStripMenuItem";
            this.сортироватьПоМоделиToolStripMenuItem.Size = new System.Drawing.Size(382, 26);
            this.сортироватьПоМоделиToolStripMenuItem.Text = "Сортировать по модели";
            this.сортироватьПоМоделиToolStripMenuItem.Click += new System.EventHandler(this.сортироватьПоМоделиToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 708);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.ShowIcon = false;
            this.Text = "Магазин Принтеров";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.printerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource printerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоВозрастаниюЦеныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаПоУбываниюЦеныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоНазваниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоТипуМоделиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоВозрастаниюКоличестваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоУбываниюКоличестваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоВозрастаниюРейтингаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоУбываниюРейтингаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортироватьПоМоделиToolStripMenuItem;
    }
}

