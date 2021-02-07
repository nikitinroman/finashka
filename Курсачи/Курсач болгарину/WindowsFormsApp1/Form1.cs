using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Technique.Read_file_with_Techniques("tovar_list.txt");
            techniqueBindingSource.DataSource = Technique.Technics_list;
        }
        int marker = 0;
        /*Функция для очистки всех полей*/
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
            textBox4.Text = "Введите фирму товара";
            textBox5.Text = "Введите модель товара";
            textBox6.Text = "Введите тип товара";
            textBox7.Text = "Введите цену товара";
            textBox8.Text = "Введите рейтинг товара";
            textBox9.Text = "Введите количество товаров";
            marker = 1;
        }
        /*кнопка, работающая в зависимости от flag, который обозначается в других блоках кода*/
        private void button2_Click(object sender, EventArgs e)
        {
            if (marker == 0)
                MessageBox.Show("Сначала выберите действие из меню!");
            else if (marker == 1)
            {
                if (textBox4.Text != "Введите фирму товара" & textBox5.Text != "Введите модель товара" & textBox6.Text != "Введите тип товара" & textBox7.Text != "Введите цену товара" & textBox8.Text != "Введите рейтинг товара" & textBox9.Text != "Введите количество товаров" &
                    textBox4.Text.Length <= 20 & textBox5.Text.Length <= 20 & textBox6.Text.Length <= 20 & textBox4.Text.Split().Length == 1 & textBox5.Text.Split().Length == 1 &
                    textBox6.Text.Split().Length == 1)
                {
                    try
                    {
                        if (int.Parse(textBox9.Text) >= 0 & double.Parse(textBox8.Text) >= 0 & double.Parse(textBox7.Text) >= 0)
                        {
                            Technique.Add_Technique(textBox4.Text, textBox5.Text, textBox6.Text, double.Parse(textBox7.Text), double.Parse(textBox8.Text), int.Parse(textBox9.Text));
                            clear();
                            marker = 0;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Вы неправильно ввели данные!");
                    }
                }
                else MessageBox.Show("Вы неправильно ввели данные!");
            }
            else if (marker == 2)
            {
                if (textBox4.Text != "Введите фирму товара" & textBox5.Text != "Введите модель товара" & textBox9.Text != "Введите количество товаров")
                {
                    try
                    {
                        if (int.Parse(textBox9.Text) >= 0)
                        {
                            MessageBox.Show(Technique.Sell_Technique(textBox4.Text, textBox5.Text, int.Parse(textBox9.Text)));
                            clear();
                            marker = 0;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Вы неправильно ввели данные!");
                    }
                }         
            }

            else if (marker == 3)
            {
                if (textBox4.Text != "Введите фирму товара")
                {
                    try
                    {
                        MessageBox.Show(Technique.Read_from_File(textBox4.Text));
                        clear();
                        marker = 0;
                    }
                    catch
                    {
                        MessageBox.Show("Вы неправильно ввели данные!");
                    }
                }
            }
            techniqueBindingSource.ResetBindings(false);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            clear();
            Form2 form2 = new Form2();
            form2.Show();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            marker = 2;
            clear();
            textBox4.Text = "Введите фирму товара";
            textBox5.Text = "Введите модель товара";
            textBox9.Text = "Введите количество товаров";
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Technique.zakupka();
            MessageBox.Show("Закупка прошла успешно!");
            clear();
            techniqueBindingSource.ResetBindings(false);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Technique.Read_from_File("need_to_buy.txt"));
            clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Technique.stats();
            MessageBox.Show("Статистика по ценам товаров записана в файлы stat_price.txt и stat_kol_vo.txt");
            clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Technique.check_stats());
            MessageBox.Show(Technique.check_stats());
            Form5 form5 = new Form5();
            form5.Show();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (marker == 1 | marker == 2)
            {
                textBox4.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox5.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox6.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox7.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox8.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Пояснение к функционалу.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            techniqueBindingSource.DataSource = Technique.Technics_list = Technique.Technics_list.OrderBy(x => x.Price).ToList<Technique>();
            techniqueBindingSource.ResetBindings(false);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            techniqueBindingSource.DataSource = Technique.Technics_list = Technique.Technics_list.OrderByDescending(x => x.Price).ToList<Technique>();
            techniqueBindingSource.ResetBindings(false);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            techniqueBindingSource.DataSource = Technique.Technics_list = Technique.Technics_list.OrderBy(x => x.Brand).ToList<Technique>();
            techniqueBindingSource.ResetBindings(false);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            techniqueBindingSource.DataSource = Technique.Technics_list = Technique.Technics_list.OrderBy(x => x.Type).ToList<Technique>();
            techniqueBindingSource.ResetBindings(false);
        }

        private void создательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кирил Златински ПИ18-1, Научный руководитель - ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            techniqueBindingSource.DataSource = Technique.Technics_list = Technique.Technics_list.OrderBy(x => x.Kol_vo).ToList<Technique>();
            techniqueBindingSource.ResetBindings(false);
        }
    }
}
