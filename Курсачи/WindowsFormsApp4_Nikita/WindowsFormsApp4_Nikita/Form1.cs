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

namespace WindowsFormsApp4_Nikita
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Мы можем войти в программу как и анонимно, так и с правами администратора.
            // В случае анонимного входа все, что мы можем делать- смотреть информацию в программе, но никак не менять ее.
            // Администратор в свою очередь всегда модет изменить информацию в файле.
            if (textBox1.Text != "" & textBox1.Text != "admin")
            {
                MessageBox.Show("Вы ввели неверный идентификатор доступа!");
            }
            if (textBox1.Text == "admin")
            {
                this.Hide();
                Form2 form2 = new Form2();
                MessageBox.Show("Режим администратора.");
                form2.Show();
            }
            else
            {
                this.Hide();
                Form3 form3 = new Form3();
                MessageBox.Show("Режим просмотра.");
                form3.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Помощь.txt");
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель - Михайлов Никита Юрьевич ПИ18-1, Научный Руководитель - Завгородний Виктор Иванович");
        }
    }
}
