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

namespace WindowsFormsApp4_Нелли_Грушенцева
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Kredit.Load_info();
            Client.Load_info();
            clientBindingSource.DataSource = Client.Clients;
            kreditBindingSource.DataSource = Kredit.Kredits;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox5.Text.Split('.').Count() == 3)
                {
                    string answ = Client.Add_info(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox4.Text), textBox5.Text, int.Parse(textBox6.Text),
                    comboBox1.Text, int.Parse(textBox7.Text));
                    if (answ == "неуспешно")
                    {
                        MessageBox.Show("Неправильно введены данные!");
                        label9.Show();
                        label10.Show();
                        label11.Show();
                        label12.Show();
                        label13.Show();
                        label14.Show();
                        label15.Show();
                    }
                    else
                    {
                        clientBindingSource.ResetBindings(false);
                        label9.Hide();
                        label10.Hide();
                        label11.Hide();
                        label12.Hide();
                        label13.Hide();
                        label14.Hide();
                        label15.Hide();
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                        textBox6.Clear();
                        textBox7.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Неправильно введена дата оформления кредита или другие поля.");
                }
            }
            catch
            {
                MessageBox.Show("Неправильно введены данные!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Show();
            label10.Show();
            label11.Show();
            label12.Show();
            label13.Show();
            label14.Show();
            label15.Show();
        }

        private void суммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = Client.Clients = Client.Clients.OrderByDescending(x => x.Money).ToList<Client>();
            clientBindingSource.ResetBindings(false);
        }

        private void срокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = Client.Clients = Client.Clients.OrderByDescending(x => x.Months).ToList<Client>();
            clientBindingSource.ResetBindings(false);
        }

        private void суммыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = Client.Clients = Client.Clients.OrderBy(x => x.Money).ToList<Client>();
            clientBindingSource.ResetBindings(false);
        }

        private void срокаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clientBindingSource.DataSource = Client.Clients = Client.Clients.OrderBy(x => x.Months).ToList<Client>();
            clientBindingSource.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string answ = Client.Delete_info(textBox1.Text, textBox2.Text);
            if (answ != "успешно")
            {
                MessageBox.Show("Неверно введены данные! (Такого пользователя нет)");
            }
            else
            {
                clientBindingSource.ResetBindings(false);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < dataGridView1.Rows.Count - 1; i++)
                dataGridView1.Rows[i].Visible = dataGridView1[6, i].Value.ToString() == comboBox1.Text;
        }
    }
}
