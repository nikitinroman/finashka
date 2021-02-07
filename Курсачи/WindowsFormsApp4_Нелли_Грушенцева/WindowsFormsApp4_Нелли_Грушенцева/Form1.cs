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

namespace WindowsFormsApp4_Нелли_Грушенцева
{
    public partial class Form1 : Form
    {
        public int flag;
        public Form1()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            flag = 1;
            button5.Show();
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            button5.Hide();
            Kredit.Load_info();
            kreditBindingSource.DataSource = Kredit.Kredits;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == 1)
                {
                    string answ = Kredit.Add_info(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                    kreditBindingSource.ResetBindings(false);
                    if (answ == "неуспешно")
                    {
                        MessageBox.Show("Неверно введены данные!");
                    }
                }
                else if (flag == 2)
                {
                    string answ = Kredit.Change_info(textBox1.Text, int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                    kreditBindingSource.ResetBindings(false);
                    if (answ == "неуспешно")
                    {
                        MessageBox.Show("Неверно введены данные!");
                    }
                }
                else if (flag == 3)
                {
                    string answ = Kredit.Delete_info(textBox1.Text);
                    kreditBindingSource.ResetBindings(false);
                    if (answ == "неуспешно")
                    {
                        MessageBox.Show("Неверно введены данные!");
                    }
                }
                button5.Hide();
                textBox1.Hide();
                textBox2.Hide();
                textBox3.Hide();
                textBox4.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();
                flag = 0;
            }
            catch
            {
                MessageBox.Show("Неверно введены данные!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = 2;
            button5.Show();
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox3.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox4.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = 3;
            button5.Show();
            textBox1.Show();
            textBox2.Show();
            textBox3.Show();
            textBox4.Show();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Об_авторе.txt");
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Помощь.txt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
