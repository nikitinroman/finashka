using Microsoft.Office.Interop.Excel;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Kvadro_manuf.Load_info();
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list;
        }

        private void Form3_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list = Kvadro_manuf.Kvadro_man_list.OrderBy(x => x.Country).ToList<Kvadro_manuf>();
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

        private void странеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadromanufBindingSource.DataSource = Kvadro_manuf.Kvadro_man_list = Kvadro_manuf.Kvadro_man_list.OrderByDescending(x => x.Country).ToList<Kvadro_manuf>();
            kvadromanufBindingSource.ResetBindings(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Вывод отчёта в эксель.
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = Excel.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Cбор статистики по компаниям
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
