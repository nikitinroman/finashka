using Excel = Microsoft.Office.Interop.Excel;
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

namespace WindowsFormsApp4Maria
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // Функция для очистки полей от уже ненужных записей.
        public void Dismantling()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string answ = Member.Add_member_into_db(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
                if (answ == "выполнил")
                {
                    Dismantling();
                    memberBindingSource.ResetBindings(false);
                    MessageBox.Show("Добавлено!");
                }
                else MessageBox.Show("Данные введены неправильно!");
            }
            catch
            {
                MessageBox.Show("Данные введены неправильно!");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.status == "view")
            {
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                textBox5.Hide();
                button1.Hide();
                button2.Hide();
                button3.Hide();
            }
            Member.Download_info_about_members_into_list();
            memberBindingSource.DataSource = Member.Members_lst;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string answ = Member.Change_zapis_about_member(textBox1.Text, textBox2.Text, textBox3.Text, int.Parse(textBox4.Text), int.Parse(textBox5.Text));
                if (answ == "выполнил")
                {
                    Dismantling();
                    Member.Download_info_about_members_into_list();
                    memberBindingSource.ResetBindings(false);
                    MessageBox.Show("Изменено!");
                }
                else MessageBox.Show("Данные введены неправильно!");
            }
            catch
            {
                MessageBox.Show("Данные введены неправильно!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox3.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox4.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox5.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string answ = Member.Delete_member_from_db(textBox1.Text, textBox2.Text, textBox3.Text);
                if (answ == "выполнил")
                {
                    Dismantling();
                    Member.Download_info_about_members_into_list();
                    memberBindingSource.ResetBindings(false);
                    MessageBox.Show("Удалено!");
                }
                else MessageBox.Show("Данные введены неправильно!");
            }
            catch
            {
                MessageBox.Show("Данные введены неправильно!");
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        // Вывожу отчет в эксель для возможности дальнейшей аналитики полученных в результате работы программы данных
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

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            int max_score = 0;
            string mem_1 = "";
            int min_score = 101;
            string mem_2 = "";
            int max_class = 0;
            string mem_3 = "";
            int min_class = 12;
            string mem_4 = "";
            for (int i = 0; i<Member.Members_lst.Count; i++)
            {
                if(Member.Members_lst[i].Score > max_score)
                {
                    max_score = Member.Members_lst[i].Score;
                    mem_1 = Member.Members_lst[i].First_name + " " + Member.Members_lst[i].Last_name;
                }
                if (Member.Members_lst[i].Score < min_score)
                {
                    min_score = Member.Members_lst[i].Score;
                    mem_2 = Member.Members_lst[i].First_name + " " + Member.Members_lst[i].Last_name;
                }
                if (Member.Members_lst[i].The_сlass > max_class)
                {
                    max_class = Member.Members_lst[i].The_сlass;
                    mem_3 = Member.Members_lst[i].First_name + " " + Member.Members_lst[i].Last_name;
                }
                if (Member.Members_lst[i].The_сlass < min_class)
                {
                    min_class = Member.Members_lst[i].The_сlass;
                    mem_4 = Member.Members_lst[i].First_name + " " + Member.Members_lst[i].Last_name;
                }
            }
            StreamWriter file = new StreamWriter("stat_mem.txt", true, Encoding.UTF8);
            file.WriteLine($"Самый высокий балл у: '{mem_1}', его баллы: '{max_score}' \n" +
                $"Самый низкий балл у: '{mem_2}', его баллы: '{min_score}' \n" +
                $"Самый младший участник: '{mem_3}', учится в: '{min_class}' классе \n" +
                $"Самый старший участник: '{mem_4}', учится в: '{max_class}' классе \n");
            file.Close();
            MessageBox.Show("Записал статистику в файл stat_mem.txt");
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Помощь.txt");
        }

        private void оСоздателеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор- Когут Мария, ПИ18-1 , Научный руководитель- Дадян Э.Г.");
        }

        private void имениToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memberBindingSource.DataSource = Member.Members_lst = Member.Members_lst.OrderBy(param => param.First_name).ToList<Member>();
            memberBindingSource.ResetBindings(false);
        }

        private void фамилииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberBindingSource.DataSource = Member.Members_lst = Member.Members_lst.OrderBy(param => param.Last_name).ToList<Member>();
            memberBindingSource.ResetBindings(false);
        }

        private void названияПредметаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberBindingSource.DataSource = Member.Members_lst = Member.Members_lst.OrderBy(param => param.Subject).ToList<Member>();
            memberBindingSource.ResetBindings(false);
        }

        private void номеруКлассаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberBindingSource.DataSource = Member.Members_lst = Member.Members_lst.OrderBy(param => param.The_сlass).ToList<Member>();
            memberBindingSource.ResetBindings(false);
        }

        private void количествуБалловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberBindingSource.DataSource = Member.Members_lst = Member.Members_lst.OrderBy(param => param.Score).ToList<Member>();
            memberBindingSource.ResetBindings(false);
        }

        private void имениToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            memberBindingSource.DataSource = Member.Members_lst = Member.Members_lst.OrderByDescending(param => param.First_name).ToList<Member>();
            memberBindingSource.ResetBindings(false);
        }

        private void фамилииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memberBindingSource.DataSource = Member.Members_lst = Member.Members_lst.OrderByDescending(param => param.Last_name).ToList<Member>();
            memberBindingSource.ResetBindings(false);
        }

        private void названиюПредметаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberBindingSource.DataSource = Member.Members_lst = Member.Members_lst.OrderByDescending(param => param.Subject).ToList<Member>();
            memberBindingSource.ResetBindings(false);
        }

        private void номеруКлассаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memberBindingSource.DataSource = Member.Members_lst = Member.Members_lst.OrderByDescending(param => param.The_сlass).ToList<Member>();
            memberBindingSource.ResetBindings(false);
        }

        private void количествуБалловToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            memberBindingSource.DataSource = Member.Members_lst = Member.Members_lst.OrderByDescending(param => param.Score).ToList<Member>();
            memberBindingSource.ResetBindings(false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
