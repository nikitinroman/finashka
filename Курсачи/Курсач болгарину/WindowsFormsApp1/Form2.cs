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
            pictureBox1.Image = new Bitmap("info.png");
            Tech_information.Read_info_from_file();
            techniqueBindingSource.DataSource = Technique.Technics_list;
            techinformationBindingSource.DataSource = Tech_information.Tech_information_list;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int marker = 0;
            string info = "";
            for (int i = 0; i < Tech_information.Tech_information_list.Count; i++)
            {
                if (Tech_information.Tech_information_list[i].Brand == comboBox1.Text & Tech_information.Tech_information_list[i].Model == comboBox2.Text)
                {
                    marker = marker + 1;
                    info += Tech_information.Tech_information_list[i].Info;
                }
            }
            if (marker == 0)
            {
                Clipboard.SetDataObject("https://clck.ru/");
                MessageBox.Show("Ссылки на информацию об этом устройстве пока нет, пожалуйста, добавьте её! Желательно воспользуйтесь сервисом для сокращения ссылок. Ссылка на сервис уже в вашем буфере обмена!");
                textBox1.Text = "Введите информацию!";
            }
            else
            {
                MessageBox.Show(info);
                marker = 0;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & textBox1.Text != "Введите информацию!")
            {
                Tech_information.Add_info(comboBox1.Text, comboBox2.Text, textBox1.Text);
            }
            textBox1.Clear();
            techinformationBindingSource.ResetBindings(false);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox2.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            Clipboard.SetDataObject(dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString());
            MessageBox.Show("Ссылка на сайт с информацией в вашем буфере обмена, просто вставьте ее в строку поиска методом Ctrl+V!");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Пояснение к функционалу.txt");
        }

        private void создательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кирил Златински ПИ18-1, Научный руководитель - ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Информация" & textBox1.Text != "" & textBox1.Text.Length <= 10 & textBox1.Text.Split().Length <= 1)
            {
                string answer = Tech_information.Change_information(comboBox1.Text, comboBox2.Text, textBox1.Text);
                if (answer == "Успешно!")
                {
                    techinformationBindingSource.ResetBindings(false);
                    MessageBox.Show("Информация успешно изменена!");
                }
                else MessageBox.Show("Некорректный запрос на изменение данных. Возможно, вам стоит воспользоваться сервисом для предоставления коротких ссылок");
            }
            else MessageBox.Show("Вы не верно ввели данные.");
        }
    }
}
