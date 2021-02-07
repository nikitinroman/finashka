using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4Maria
{
    public partial class Form4 : Form
    {
        // Функция для очистки полей от уже ненужных записей.
        public void Dismantling()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (Form1.status == "view")
            {
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                textBox5.Hide();
                textBox6.Hide();
                textBox7.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
            }
            Member_info.Download_info_about_members_info_into_list();
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Excel.Application Excel = new Excel.Application();
            Excel.Workbook ExcelWorkBook;
            Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = Excel.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

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

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Помощь.txt");
        }

        private void оСоздателеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор- Когут Мария, ПИ18-1 , Научный руководитель- Дадян Э.Г.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string answ = Member_info.Add_member_info_into_db(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, int.Parse(textBox5.Text), int.Parse(textBox6.Text), int.Parse(textBox7.Text));
                if (answ == "выполнил")
                {
                    Dismantling();
                    memberinfoBindingSource.ResetBindings(false);
                    MessageBox.Show("Добавлено!");
                }
                else MessageBox.Show("Данные введены неправильно!");
            }
            catch
            {
                MessageBox.Show("Данные введены неправильно!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string answ = Member_info.Change_zapis_about_member(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, int.Parse(textBox5.Text), int.Parse(textBox6.Text), int.Parse(textBox7.Text));
                if (answ == "выполнил")
                {
                    Dismantling();
                    Member_info.Download_info_about_members_info_into_list();
                    memberinfoBindingSource.ResetBindings(false);
                    MessageBox.Show("Изменено!");
                }
                else MessageBox.Show("Данные введены неправильно! Возможно, такого пользователя нет, либо вы пытаетесь изменить паспорт или фамилию с именем, что делать запрещено.");
            }
            catch
            {
                MessageBox.Show("Данные введены неправильно!");
            }
}

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string answ = Member_info.Delete_member_from_db(textBox1.Text, textBox2.Text, int.Parse(textBox6.Text));
                if (answ == "выполнил")
                {
                    Dismantling();
                    Member_info.Download_info_about_members_info_into_list();
                    memberinfoBindingSource.ResetBindings(false);
                    MessageBox.Show("Удалено!");
                }
                else MessageBox.Show("Данные введены неправильно!");
            }
            catch
            {
                MessageBox.Show("Данные введены неправильно!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            /*int max_Passport = 0;
            string mem_1 = "";
            int Phone_1 = 0;
            int min_Passport = 101;
            string mem_2 = "";
            int Phone_2 = 0;
            int max_class = 0;
            string mem_3 = "";
            int Phone_3 = 0;
            int min_class = 12;
            string mem_4 = "";
            int Phone_4 = 0;
            for (int i = 0; i < Member_info.Members_info_lst.Count; i++)
            {
                if (Member_info.Members_info_lst[i].Passport > max_Passport)
                {
                    max_Passport = Member_info.Members_info_lst[i].Passport;
                    mem_1 = Member_info.Members_info_lst[i].First_name + " " + Member_info.Members_info_lst[i].Last_name;
                    Phone_1 = Member_info.Members_info_lst[i].Phone;
                }
                if (Member_info.Members_info_lst[i].Passport < min_Passport)
                {
                    min_Passport = Member_info.Members_info_lst[i].Passport;
                    mem_2 = Member_info.Members_info_lst[i].First_name + " " + Member_info.Members_info_lst[i].Last_name;
                    Phone_2 = Member_info.Members_info_lst[i].Phone;
                }
                if (Member_info.Members_info_lst[i].The_сlass > max_class)
                {
                    max_class = Member_info.Members_info_lst[i].The_сlass;
                    mem_3 = Member_info.Members_info_lst[i].First_name + " " + Member_info.Members_info_lst[i].Last_name;
                    Phone_3 = Member_info.Members_info_lst[i].Phone;
                }
                if (Member_info.Members_info_lst[i].The_сlass < min_class)
                {
                    min_class = Member_info.Members_info_lst[i].The_сlass;
                    mem_4 = Member_info.Members_info_lst[i].First_name + " " + Member_info.Members_info_lst[i].Last_name;
                    Phone_4 = Member_info.Members_info_lst[i].Phone;
                }
            }
            System.IO.StreamWriter file = new System.IO.StreamWriter("stat_mem_info.txt", true);
            file.WriteLine($"Самый высокий балл у: '{mem_1}', его баллы: '{max_Passport}', занял '{Phone_1}' место. \n" +
                $"Самый низкий балл у: '{mem_2}', его баллы: '{min_Passport}', занял '{Phone_2}' место. \n" +
                $"Самый младший участник: '{mem_3}', учится в: '{min_class}' классе, занял '{Phone_3}' место. \n" +
                $"Самый старший участник: '{mem_4}', учится в: '{max_class}' классе, занял '{Phone_4}' место. \n");
            file.Close();
            MessageBox.Show("Записал статистику в файл stat_mem_info.txt");*/
        }

        private void имениToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderBy(param => param.First_name).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void фамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderBy(param => param.Last_name).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void регионаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderBy(param => param.Region).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void школыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderBy(param => param.School).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void классаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderBy(param => param.The_сlass).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void балловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderBy(param => param.Passport).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void местаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderBy(param => param.Phone).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void имениToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderByDescending(param => param.First_name).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void фамилииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderByDescending(param => param.Last_name).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void регионаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderByDescending(param => param.Region).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void школыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderByDescending(param => param.School).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void классаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderByDescending(param => param.The_сlass).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void балловToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderByDescending(param => param.Passport).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void местаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memberinfoBindingSource.DataSource = Member_info.Members_info_lst = Member_info.Members_info_lst.OrderByDescending(param => param.Phone).ToList<Member_info>();
            memberinfoBindingSource.ResetBindings(false);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox3.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox4.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox5.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox6.Text = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox7.Text = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();
        }
    }
}
