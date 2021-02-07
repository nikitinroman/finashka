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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Вывод отчета в эксель файл.
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

        private void Form5_Load(object sender, EventArgs e)
        {
            Kvadro_info.Load_info();
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель - Михайлов Никита Юрьевич ПИ18-1, Научный Руководитель - Завгородний Виктор Иванович");
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Помощь.txt");
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void количествуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list = Kvadro_info.Kvadro_info_list.OrderByDescending(x => x.Kol_vo).ToList<Kvadro_info>();
            kvadroinfoBindingSource.ResetBindings(false);
        }

        private void производителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list = Kvadro_info.Kvadro_info_list.OrderByDescending(x => x.Manufacturer).ToList<Kvadro_info>();
            kvadroinfoBindingSource.ResetBindings(false);
        }

        private void моделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list = Kvadro_info.Kvadro_info_list.OrderByDescending(x => x.Model).ToList<Kvadro_info>();
            kvadroinfoBindingSource.ResetBindings(false);
        }

        private void годаПроизводстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list = Kvadro_info.Kvadro_info_list.OrderByDescending(x => x.Year_of_prod).ToList<Kvadro_info>();
            kvadroinfoBindingSource.ResetBindings(false);
        }

        private void мощностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list = Kvadro_info.Kvadro_info_list.OrderByDescending(x => x.Power).ToList<Kvadro_info>();
            kvadroinfoBindingSource.ResetBindings(false);
        }

        private void ценеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list = Kvadro_info.Kvadro_info_list.OrderByDescending(x => x.Price).ToList<Kvadro_info>();
            kvadroinfoBindingSource.ResetBindings(false);
        }

        private void производителяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list = Kvadro_info.Kvadro_info_list.OrderBy(x => x.Manufacturer).ToList<Kvadro_info>();
            kvadroinfoBindingSource.ResetBindings(false);
        }

        private void моделиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list = Kvadro_info.Kvadro_info_list.OrderBy(x => x.Model).ToList<Kvadro_info>();
            kvadroinfoBindingSource.ResetBindings(false);
        }

        private void годаПроизводстваToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list = Kvadro_info.Kvadro_info_list.OrderBy(x => x.Year_of_prod).ToList<Kvadro_info>();
            kvadroinfoBindingSource.ResetBindings(false);
        }

        private void количестваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list = Kvadro_info.Kvadro_info_list.OrderBy(x => x.Year_of_prod).ToList<Kvadro_info>();
            kvadroinfoBindingSource.ResetBindings(false);
        }

        private void мощностиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list = Kvadro_info.Kvadro_info_list.OrderBy(x => x.Power).ToList<Kvadro_info>();
            kvadroinfoBindingSource.ResetBindings(false);
        }

        private void ценыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kvadroinfoBindingSource.DataSource = Kvadro_info.Kvadro_info_list = Kvadro_info.Kvadro_info_list.OrderBy(x => x.Price).ToList<Kvadro_info>();
            kvadroinfoBindingSource.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Сбор статистики по квадрокоптерам и вывод ее в тхт файл.
            string comp1 = "";
            string comp2 = "";
            string comp3 = "";
            string comp4 = "";
            string comp5 = "";
            string comp6 = "";
            string comp7 = "";
            string comp8 = "";
            string model1 = "";
            string model2 = "";
            string model3 = "";
            string model4 = "";
            string model5 = "";
            string model6 = "";
            string model7 = "";
            string model8 = "";
            int max_price = 0;
            int min_price = 1000000000;
            int min_old = 0;
            int max_old = 1000;
            int max_kol_vo = 0;
            int min_kol_vo = 1000000000;
            int min_power = 0;
            int max_power = 1000;
            for (int i = 0; i < Kvadro_info.Kvadro_info_list.Count; i++)
            {
                if (max_price < Kvadro_info.Kvadro_info_list[i].Price)
                {
                    max_price = Kvadro_info.Kvadro_info_list[i].Price;
                    comp1 = Kvadro_info.Kvadro_info_list[i].Manufacturer;
                    model1 = Kvadro_info.Kvadro_info_list[i].Model;
                }
                if (min_price > Kvadro_info.Kvadro_info_list[i].Price)
                {
                    min_price = Kvadro_info.Kvadro_info_list[i].Price;
                    comp2 = Kvadro_info.Kvadro_info_list[i].Manufacturer;
                    model2 = Kvadro_info.Kvadro_info_list[i].Model;
                }
                if (min_old > Kvadro_info.Kvadro_info_list[i].Year_of_prod)
                {
                    min_old = Kvadro_info.Kvadro_info_list[i].Year_of_prod;
                    comp3 = Kvadro_info.Kvadro_info_list[i].Manufacturer;
                    model3 = Kvadro_info.Kvadro_info_list[i].Model;
                }
                if (max_old < Kvadro_info.Kvadro_info_list[i].Year_of_prod)
                {
                    max_old = Kvadro_info.Kvadro_info_list[i].Year_of_prod;
                    comp4 = Kvadro_info.Kvadro_info_list[i].Manufacturer;
                    model4 = Kvadro_info.Kvadro_info_list[i].Model;
                }
                if (max_kol_vo < Kvadro_info.Kvadro_info_list[i].Kol_vo)
                {
                    max_kol_vo = Kvadro_info.Kvadro_info_list[i].Kol_vo;
                    comp5 = Kvadro_info.Kvadro_info_list[i].Manufacturer;
                    model5 = Kvadro_info.Kvadro_info_list[i].Model;
                }
                if (min_kol_vo > Kvadro_info.Kvadro_info_list[i].Kol_vo)
                {
                    min_kol_vo = Kvadro_info.Kvadro_info_list[i].Kol_vo;
                    comp6 = Kvadro_info.Kvadro_info_list[i].Manufacturer;
                    model6 = Kvadro_info.Kvadro_info_list[i].Model;
                }
                if (min_power > Kvadro_info.Kvadro_info_list[i].Power)
                {
                    min_power = Kvadro_info.Kvadro_info_list[i].Power;
                    comp7 = Kvadro_info.Kvadro_info_list[i].Manufacturer;
                    model7 = Kvadro_info.Kvadro_info_list[i].Model;
                }
                if (max_power < Kvadro_info.Kvadro_info_list[i].Power)
                {
                    max_power = Kvadro_info.Kvadro_info_list[i].Power;
                    comp8 = Kvadro_info.Kvadro_info_list[i].Manufacturer;
                    model8 = Kvadro_info.Kvadro_info_list[i].Model;
                }
            }
            Form7 form7 = new Form7();
            form7.Show();
            StreamWriter writer = new StreamWriter("stat_of_kvadr.txt", true, Encoding.UTF8);
            writer.WriteLine($"Самый дорогой квадроцикл: '{comp1}' '{model1}', цена: '{max_price}' \n" +
                $"Самый дешевый квадроцикл: '{comp2}' '{model2}' , цена: '{min_price}' \n" +
                $"Самый старый квадроцикл: '{comp4}' '{model4}', дата основания: '{max_old}' \n" +
                $"Самый новый квадроцикл: '{comp3}' '{model3}', дата основания: '{min_old}' \n" +
                $"Самый серийный квадроцикл: '{comp5}' '{model5}', цена: '{max_price}' \n" +
                $"Самый лимитированный квадроцикл: '{comp6}' '{model6}' , цена: '{min_price}' \n" +
                $"Самый мощный квадроцикл: '{comp7}' '{model7}', дата основания: '{max_old}' \n" +
                $"Самый слабый квадроцикл: '{comp8}' '{model8}', дата основания: '{min_old}' \n");
            writer.Close();
            MessageBox.Show("Статистика (дополнительная) записана в файл stat_of_kvadr.txt");
        }
    }
}
