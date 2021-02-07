using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("10.png");
            Printer.Load_printers_from_mdb();
            printerBindingSource.DataSource = Printer.Printer_list;
        }
        int flag = 0;

        private void clear()
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            textBox4.Text = "Введите фирму принтера";
            textBox5.Text = "Введите модель принтера";
            textBox6.Text = "Введите тип принтера";
            textBox7.Text = "Введите цену принтера";
            textBox8.Text = "Введите рейтинг принтера";
            textBox9.Text = "Введите количество принтеров";
            flag = 1;
        }
        /*За заполнение textboxов отвечают кнопки, на которых описаны возможности функций, для выполнения же используется отдельная кнопка "Выполнить"*/
        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 0)
                MessageBox.Show("Сначала выберите действие из меню!");
            else if (flag == 1)
            {
                if (textBox4.Text != "Введите фирму принтера" & textBox5.Text != "Введите модель принтера" & textBox6.Text != "Введите тип принтера" &
                    textBox7.Text != "Введите цену принтера" & textBox8.Text != "Введите рейтинг принтера" & textBox9.Text != "Введите количество принтеров" &
                    textBox4.Text.Split().Length == 1 & textBox5.Text.Split().Length == 1 & textBox6.Text.Split().Length == 1 & textBox7.Text.Split().Length == 1 &
                    textBox8.Text.Split().Length == 1 & textBox9.Text.Split().Length == 1)
                {
                    try
                    {   
                        if (int.Parse(textBox9.Text) >= 0 & double.Parse(textBox8.Text) >= 0 & double.Parse(textBox7.Text) >= 0 & double.Parse(textBox7.Text) <= 1000000 & double.Parse(textBox8.Text) <= 10 & int.Parse(textBox9.Text) <= 1000 &
                            textBox4.Text.Length <= 20 & textBox5.Text.Length <= 20 & textBox5.Text.Length <= 20)
                        {
                            Printer.Add_Printer(textBox4.Text, textBox5.Text, textBox6.Text, double.Parse(textBox7.Text), double.Parse(textBox8.Text), int.Parse(textBox9.Text));
                            clear();
                            flag = 0;
                        }
                        else MessageBox.Show("Вы вводите данные не правильно! Возможно, вам стоит поменять знаки пробела на нижнее подчеркивание '_', вводить наименования длиной менее 20 символов или заполнить все предложенные поля!");
                    }
                    catch
                    {
                        MessageBox.Show("Вы вводите данные не правильно! Возможно, вам стоит поменять знаки пробела на нижнее подчеркивание '_', вводить наименования длиной менее 20 символов или заполнить все предложенные поля!");
                    }
                }
                else MessageBox.Show("Вы вводите данные не правильно! Возможно, вам стоит поменять знаки пробела на нижнее подчеркивание '_', вводить наименования длиной менее 20 символов или заполнить все предложенные поля!");
            }
            else if (flag == 2)
            {
                if (textBox4.Text != "Введите фирму принтера" & textBox5.Text != "Введите модель принтера" & textBox9.Text != "Введите количество принтеров")
                {
                    try
                    {
                        if (int.Parse(textBox9.Text) > 0)
                        {
                            MessageBox.Show(Printer.Sell_Printer(textBox4.Text, textBox5.Text, int.Parse(textBox9.Text)));
                            clear();
                            flag = 0;
                        }
                        else MessageBox.Show("Вы не можете продать меньше, чем 1 принтер!");
                    }
                    catch
                    {
                        MessageBox.Show("Вы неправильно ввели данные!");
                    }
                }
            }

            else if (flag == 3)
            {
                if (textBox4.Text != "Введите фирму принтера")
                {
                    try
                    {
                        MessageBox.Show(Printer.Read_from_File(textBox4.Text));
                        clear();
                        flag = 0;
                    }
                    catch
                    {
                        MessageBox.Show("Вы неправильно ввели данные!");
                    }
                }
            }
            printerBindingSource.ResetBindings(false);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            clear();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = 3;
            clear();
            textBox4.Text = "Введите название файла для прочтения";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flag = 2;
            clear();
            textBox4.Text = "Введите фирму принтера";
            textBox5.Text = "Введите модель принтера";
            textBox9.Text = "Введите количество принтеров";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string text = Printer.Read_from_File("check_list.txt");
            if (text == "")
            {
                MessageBox.Show("Пока ещё нечего закупать!");
            }
            else
            {
                Printer.purchase();
                MessageBox.Show("Закупка прошла успешно!");
                Printer.Write_log(Form3.name_for_log, "произвел закупку недостающих принтеров");
                printerBindingSource.ResetBindings(false);
                clear();
            }            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clear();
            string text = Printer.Read_from_File("check_list.txt");
            if (text == "")
            {
                MessageBox.Show("Тут пока что пусто!");
            }
            else MessageBox.Show(text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Printer.statistics();
            MessageBox.Show("Статистика по ценам принтеров записана в файлы stat_price.txt и stat_kol_vo.txt");
            clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Printer.check_statistics());
            Form5 form5 = new Form5();
            form5.Show();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == 1 | flag == 2)
            {
                textBox4.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox5.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox6.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox7.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox8.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }

         /*При выборе textbox автоматически выделяю весь текст в нем для удобства*/
        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.SelectionStart = 0;
            textBox4.SelectionLength = textBox4.Text.Length;
            textBox4.Focus();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.SelectionStart = 0;
            textBox5.SelectionLength = textBox5.Text.Length;
            textBox5.Focus();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.SelectionStart = 0;
            textBox6.SelectionLength = textBox6.Text.Length;
            textBox6.Focus();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.SelectionStart = 0;
            textBox7.SelectionLength = textBox7.Text.Length;
            textBox7.Focus();
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.SelectionStart = 0;
            textBox8.SelectionLength = textBox8.Text.Length;
            textBox8.Focus();
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.SelectionStart = 0;
            textBox9.SelectionLength = textBox9.Text.Length;
            textBox9.Focus();
        }
        /*Открываю формы в режиме диалога, потому что умею*/
        private void button11_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Owner = this;
            form6.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Owner = this;
            form7.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /*Каждая сортировка так же и меняет структура данных в файле, что как я посчитал- не особо важно, ведь лучше отсортированные
         данные, чем рандомно разбросанные*/
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderBy(x => x.Price).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Пояснение к функционалу.txt");
        }

        private void сортироватьПоУбываниюЦеныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderByDescending(x => x.Price).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderBy(x => x.Name).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоТипуМоделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderBy(x => x.Type).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоВозрастаниюКоличестваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderBy(x => x.Kol_vo).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоУбываниюКоличестваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderByDescending(x => x.Kol_vo).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоВозрастаниюРейтингаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderBy(x => x.Rate).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоУбываниюРейтингаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderByDescending(x => x.Rate).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоМоделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderBy(x => x.Model).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

    }
}
