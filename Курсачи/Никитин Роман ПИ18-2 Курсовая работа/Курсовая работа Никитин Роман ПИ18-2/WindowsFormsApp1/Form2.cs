using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("20.png");
            Printer_info.Read_info_from_file("printer_info.txt");
            printerBindingSource.DataSource = Printer.Printer_list;
            printerinfoBindingSource.DataSource = Printer_info.Printer_info_list;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель- Никитин Роман Андреевич, Научный руководитель- Горелов Сергей Витальевич.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string info = "";
            for (int i = 0; i < Printer_info.Printer_info_list.Count; i++)
            {
                if (Printer_info.Printer_info_list[i].Name == comboBox1.Text & Printer_info.Printer_info_list[i].Model == comboBox2.Text)
                {
                    flag = flag + 1;
                    info += Printer_info.Printer_info_list[i].Info;
                }
            }
            if (flag == 0)
            {
                Clipboard.SetDataObject("https://clck.ru/");
                MessageBox.Show("Ссылки на информацию об этом принтере пока нет, пожалуйста, добавьте её! Желательно воспользуйтесь сервисом для сокращения ссылок. Ссылка на сервис уже в вашем буфере обмена!");
                textBox1.Text = "Введите информацию о принтере!";
            }
            else
            {
                Clipboard.SetDataObject(info);
                MessageBox.Show("Ссылка на сайт с информацией в вашем буфере обмена, просто вставьте ее в строку поиска методом Ctrl+V!");
                flag = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox1.Text != "Введите информацию о принтере!")
            {
                Printer_info.Add_info(comboBox1.Text, comboBox2.Text, textBox1.Text);
            }
            Printer.Write_log(Form3.name_for_log, " Добавил информацию о принтере ", comboBox1.Text, comboBox2.Text, textBox1.Text);
            textBox1.Clear();
            printerinfoBindingSource.ResetBindings(false);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            Clipboard.SetDataObject(dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString());
            MessageBox.Show("Ссылка на сайт с информацией в вашем буфере обмена, просто вставьте ее в строку поиска методом Ctrl+V!");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;
            textBox1.Focus();
        }
        /*Открываю формы в режиме диалога, потому что могу себе позволить*/
        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Owner = this;
            form6.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Owner = this;
            form7.ShowDialog();
        }

        private void помощьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("Пояснение к функционалу.txt");
        }
        /*Каждая сортировка меняет страктуру порядок элементов в списке, а так же в файле*/
        private void сортироватьПоФирмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerinfoBindingSource.DataSource = Printer_info.Printer_info_list = Printer_info.Printer_info_list.OrderBy(x => x.Name).ToList<Printer_info>();
            printerinfoBindingSource.ResetBindings(false);
        }

        private void сортироватьПоФирмеЯаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerinfoBindingSource.DataSource = Printer_info.Printer_info_list = Printer_info.Printer_info_list.OrderByDescending(x => x.Name).ToList<Printer_info>();
            printerinfoBindingSource.ResetBindings(false);
        }

        private void сортироватьПоМоделиАяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerinfoBindingSource.DataSource = Printer_info.Printer_info_list = Printer_info.Printer_info_list.OrderBy(x => x.Model).ToList<Printer_info>();
            printerinfoBindingSource.ResetBindings(false);
        }

        private void сортироватьПоМоделиЯаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerinfoBindingSource.DataSource = Printer_info.Printer_info_list = Printer_info.Printer_info_list.OrderByDescending(x => x.Model).ToList<Printer_info>();
            printerinfoBindingSource.ResetBindings(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Изменить инормацию о принтере" & textBox1.Text != "" & textBox1.Text.Split().Length <= 1 & textBox1.Text.Length <= 25)
            {
                string answer = Printer_info.Change_info_about_printer(comboBox1.Text, comboBox2.Text, textBox1.Text);
                if (answer == "Успешно!")
                {
                    printerinfoBindingSource.ResetBindings(false);
                    textBox1.Text = "Изменить инормацию о принтере";
                    MessageBox.Show("Информация о принтере успешно изменена!");
                }
            }
            else MessageBox.Show("Вы неправильно ввели данные, либо информации о таком принтере пока нет, а значит и менять нечего!");
        }
    }
}
