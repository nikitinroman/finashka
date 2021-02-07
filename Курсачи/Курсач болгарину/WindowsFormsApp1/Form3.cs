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
        private void Form3_Load_1(object sender, EventArgs e)
        {

            usersBindingSource.DataSource = Users.accounts_list;
            Users.From_txt_to_accounts_list();
        }
        /*Кнопка для регистрации*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "Введите пароль." & textBox2.Text != "" & textBox1.Text != "Введите логин." & textBox1.Text != "")
            {
                try
                {
                    string answer = Users.Register(textBox1.Text, textBox2.Text);
                    if (answer == "добавлено в список")
                    {
                        MessageBox.Show("Отлично, вы зарегистрированы, можете логиниться!");
                        usersBindingSource.ResetBindings(false);
                    }
                    else MessageBox.Show("Такой пользователь уже существует, можете логиниться!");
                }
                catch
                {
                    MessageBox.Show("Вы ввели неверные данные!");
                }
            }
            else MessageBox.Show("Введите ваш логин и пароль!");
            
        }
        /*Функция для входа*/
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "Введите пароль." & textBox2.Text != "")
            {
                try
                {
                    string username = textBox1.Text;
                    string log = Users.Log_in(textBox1.Text, textBox2.Text);
                    if (log == "user")
                    {
                        Form1 form1 = new Form1();
                        usersBindingSource.ResetBindings(false);
                        MessageBox.Show("Добро пожаловать!");
                        form1.Show();
                    }
                    else if (log == "admin")
                    {
                        Form4 form4 = new Form4();
                        MessageBox.Show("Добро пожаловать!");
                        form4.Show();
                    }
                    else
                    {
                        try
                        {
                            string log1 = Users.Log_in(comboBox1.Text, textBox2.Text);
                            if (log1 == "user")
                            {
                                Form1 form1 = new Form1();
                                usersBindingSource.ResetBindings(false);
                                MessageBox.Show("Добро пожаловать!");
                                form1.Show();
                            }
                            else if (log1 == "admin")
                            {
                                Form4 form4 = new Form4();
                                MessageBox.Show("Добро пожаловать!");
                                form4.Show();
                            }
                            else MessageBox.Show("Сначала залогиньтесь!");
                        }
                        catch
                        {
                            MessageBox.Show("Вы ввели неверные данные!");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Вы ввели неверные данные!");
                }
            }
            else MessageBox.Show("Введите ваш логин и пароль!");
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DataSource = Users.accounts_list;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Пояснение к функционалу.txt");
        }

        private void создательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кирил Златински ПИ18-1, Научный руководитель - ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Если вы выбрали нужный аккаунт в этом окне, вам осталось ввести лишь пароль! Если же не нашли- зарегистрируйте новый аккаунт или попробуйте ввести ео данные ниже!");
        }
    }
}
