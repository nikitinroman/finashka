using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Введите логин.";
            pictureBox1.Image = new Bitmap("30.png");
        }
        /*Регистрация пользователя, проверки на данные, введенные в textboxы или в combobox*/
        public static string name_for_log = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "Введите пароль." & textBox2.Text != "" & comboBox1.Text != "Введите логин." & comboBox1.Text!= "" & comboBox1.Text.Split().Length == 1 & 
                textBox2.Text.Split().Length == 1)
            {
                try
                {
                    string answer = Registration.Register(comboBox1.Text, textBox2.Text);
                    if (answer == "added_to_list")
                    {
                        MessageBox.Show("Отлично, вы зарегистрированы, можете логиниться!");
                    }
                    else MessageBox.Show("Такой пользователь уже существует, можете логиниться!");
                }
                catch
                {
                    MessageBox.Show("Вы ввели неверные данные!");
                }
            }
            else MessageBox.Show("Введите ваш логин и пароль! В логине и пароле не должно быть пробелов! Если проблема не устраняется, попробуйте ввести другой логин/пароль");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "Введите пароль." & textBox2.Text != "")
            {
                try
                {
                    string log = Registration.Login(comboBox1.Text, textBox2.Text);
                    if (log == "user")
                    {
                        Form1 form1 = new Form1();
                        name_for_log = comboBox1.Text;
                        this.Hide();
                        MessageBox.Show("Добро пожаловать! Вы вошли с правами работника!");
                        form1.Show();
                    }
                    else if (log == "admin")
                    {
                        Form4 form4 = new Form4();
                        name_for_log = comboBox1.Text;
                        this.Hide();
                        MessageBox.Show("Добро пожаловать! Не забывайте, что вы вошли с правами администратора!");
                        form4.Show();
                    }
                    else
                        MessageBox.Show("Сначала залогиньтесь!");
                }   
                catch
                {
                    MessageBox.Show("Вы ввели неверные данные!");
                }
            }
            else MessageBox.Show("Введите ваш логин и пароль!");
        }


        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectionStart = 0;
            textBox2.SelectionLength = textBox2.Text.Length;
            textBox2.Focus();
        }


        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Пояснение к функционалу.txt");
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {

            Registration.Read_users_from_file();
            registrationBindingSource.DataSource = Registration.Registration_list;
            comboBox1.DataSource = Registration.Registration_list;
        }
    }
}
