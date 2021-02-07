using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_Nikita
{
    public partial class Form2 : Form
    {
        // Функция для записи логов всех действий администратора.
        public static void Log(string motion, string param = "")
        {
            StreamWriter writer = new StreamWriter("log.txt", true, Encoding.UTF8);
            writer.WriteLine("{0} {1} {2}", DateTime.Now, motion, param);
            writer.Close();
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Kvadro_manuf.Load_info();
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list;
        }
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = Kvadro_manuf.Delete_info(textBox1.Text);
            Kvadro_manuf.Load_info();
            kvadromanufBindingSource.ResetBindings(false);
            if (a == "успешно")
            {
                MessageBox.Show("Успешно удалено!");
                Log("Удалил компанию", textBox1.Text);
                textBox_clearing();
            }
            MessageBox.Show("Вы ввели компанию, которой нет!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
        //Функция для очистки всех полей, применяется в конце каждого законченного корректно действия, служит "для красоты"
        private void textBox_clearing()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Заполнение полей textbox при клике на таблицу с данными
            textBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox3.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox4.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox5.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox3.Text) <= 1000000000 & int.Parse(textBox4.Text) < 2021)
                {
                    string a = Kvadro_manuf.Add_info(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text), textBox5.Text);
                    Kvadro_manuf.Load_info();
                    kvadromanufBindingSource.ResetBindings(false);
                    if (a == "успешно")
                    {
                        Log("Добавил компанию", textBox1.Text + " " + textBox2.Text + " " + int.Parse(textBox3.Text) + " " + int.Parse(textBox4.Text) + " " + textBox5.Text);
                        textBox_clearing();
                        MessageBox.Show("Успешно добавлено!");
                    }
                    else MessageBox.Show("Вы ввели некорректные данные!");
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели некорректные данные!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string a = Kvadro_manuf.Change_info(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text), textBox5.Text);
                Kvadro_manuf.Load_info();
                kvadromanufBindingSource.ResetBindings(false);
                if (a == "успешно")
                {
                    Log("Изменил информацию о компании", textBox1.Text + " " + textBox2.Text);
                    textBox_clearing();
                    MessageBox.Show("Успешно изменено!");
                }
                else MessageBox.Show("Вы ввели некорректные данные!");
            }
            catch
            {
                MessageBox.Show("Вы ввели некорректные данные!");
            }
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель - Михайлов Никита Юрьевич ПИ18-1, Научный Руководитель - Завгородний Виктор Иванович");
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Помощь.txt");
        }

        private void сортировкаПоУбываниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void производителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list = Kvadro_manuf.Kvadro_man_list.OrderByDescending(x => x.Manufacturer).ToList<Kvadro_manuf>();
            kvadromanufBindingSource.ResetBindings(false);
        }

        private void хозяинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list = Kvadro_manuf.Kvadro_man_list.OrderByDescending(x => x.Owner).ToList<Kvadro_manuf>();
            kvadromanufBindingSource.ResetBindings(false);
        }

        private void стоимостиКомпанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list = Kvadro_manuf.Kvadro_man_list.OrderByDescending(x => x.Capitalisation).ToList<Kvadro_manuf>();
            kvadromanufBindingSource.ResetBindings(false);
        }

        private void годаОснованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list = Kvadro_manuf.Kvadro_man_list.OrderByDescending(x => x.Year_of_start).ToList<Kvadro_manuf>();
            kvadromanufBindingSource.ResetBindings(false);
        }

        private void страныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list = Kvadro_manuf.Kvadro_man_list.OrderByDescending(x => x.Country).ToList<Kvadro_manuf>();
            kvadromanufBindingSource.ResetBindings(false);
        }

        private void производителяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list = Kvadro_manuf.Kvadro_man_list.OrderBy(x => x.Manufacturer).ToList<Kvadro_manuf>();
            kvadromanufBindingSource.ResetBindings(false);
        }

        private void хозяинаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list = Kvadro_manuf.Kvadro_man_list.OrderBy(x => x.Owner).ToList<Kvadro_manuf>();
            kvadromanufBindingSource.ResetBindings(false);
        }

        private void стоимостиКомпанииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list = Kvadro_manuf.Kvadro_man_list.OrderBy(x => x.Capitalisation).ToList<Kvadro_manuf>();
            kvadromanufBindingSource.ResetBindings(false);
        }

        private void годаОснованияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list = Kvadro_manuf.Kvadro_man_list.OrderBy(x => x.Year_of_start).ToList<Kvadro_manuf>();
            kvadromanufBindingSource.ResetBindings(false);
        }

        private void страныToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list = Kvadro_manuf.Kvadro_man_list.OrderBy(x => x.Country).ToList<Kvadro_manuf>();
            kvadromanufBindingSource.ResetBindings(false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Импорт datagridview в эксель.
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = Excel.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    Excel.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            Excel.Visible = true;
            Excel.UserControl = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Запись статистики в файл со статистикой.
            string comp1 = "";
            string comp2 = "";
            string comp3 = "";
            string comp4 = "";
            int max_price = 0;
            int min_price = 1000000000;
            int min_old = 0;
            int max_old = 1000;
            for (int i = 0; i < Kvadro_manuf.Kvadro_man_list.Count; i++)
            {
                if (max_price < Kvadro_manuf.Kvadro_man_list[i].Capitalisation)
                {
                    max_price = Kvadro_manuf.Kvadro_man_list[i].Capitalisation;
                    comp1 = Kvadro_manuf.Kvadro_man_list[i].Manufacturer;
                }
                if (min_price > Kvadro_manuf.Kvadro_man_list[i].Capitalisation)
                {
                    min_price = Kvadro_manuf.Kvadro_man_list[i].Capitalisation;
                    comp2 = Kvadro_manuf.Kvadro_man_list[i].Manufacturer;
                }
                if (min_old > Kvadro_manuf.Kvadro_man_list[i].Year_of_start)
                {
                    min_old = Kvadro_manuf.Kvadro_man_list[i].Year_of_start;
                    comp3 = Kvadro_manuf.Kvadro_man_list[i].Manufacturer;
                }
                if (max_old < Kvadro_manuf.Kvadro_man_list[i].Year_of_start)
                {
                    max_old = Kvadro_manuf.Kvadro_man_list[i].Year_of_start;
                    comp4 = Kvadro_manuf.Kvadro_man_list[i].Manufacturer;
                }
            }
            Form6 form6 = new Form6();
            form6.Show();
            StreamWriter writer = new StreamWriter("stat_of_comp.txt", true, Encoding.UTF8);
            writer.WriteLine($"Самая дорогая компания: '{comp1}', цена: '{max_price}' \n" +
                $"Самая дешевая компания: '{comp2}', цена: '{min_price}' \n" +
                $"Самая старая компания: '{comp4}', дата основания: '{max_old}' \n" +
                $"Самая новая компания: '{comp3}', дата основания: '{min_old}' \n");
            writer.Close();
            MessageBox.Show("Статистика (дополнительная) записана в файл stat_of_comp.txt");
        }
    }
}
