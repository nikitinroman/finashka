using System;
using System.IO;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap("40.png");
            Printer.Read_file_with_printers("price_list.txt");
            printerBindingSource.DataSource = Printer.Printer_list;
        }
        int flag = 0;
        private void clear()
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        /*За заполнение textboxов отвечают кнопки, на которых описаны возможности функций, для выполнения же используется отдельная кнопка "Выполнить"*/
        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Введите фирму принтера";
            textBox5.Text = "Введите модель принтера";
            textBox6.Text = "Введите тип принтера";
            textBox7.Text = "Введите цену принтера";
            textBox8.Text = "Введите рейтинг принтера";
            textBox9.Text = "Введите количество принтеров";
            flag = 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == 0)
                MessageBox.Show("Сначала выберите действие из меню!");
            else if (flag == 1)
            {
                if (textBox4.Text != "Введите фирму принтера" & textBox5.Text != "Введите модель принтера" & textBox6.Text != "Введите тип принтера" &
                    textBox7.Text != "Введите цену принтера" & textBox8.Text != "Введите рейтинг принтера" & textBox9.Text != "Введите количество принтеров" &
                    textBox4.Text.Split().Length == 1 & textBox5.Text.Split().Length == 1 & textBox6.Text.Split().Length == 1 & textBox7.Text.Split().Length == 1 &
                    textBox8.Text.Split().Length == 1 & textBox9.Text.Split().Length == 1)
                {
                    try
                    {
                        if (int.Parse(textBox9.Text) >= 0 & double.Parse(textBox8.Text) >= 0 & double.Parse(textBox7.Text) >= 0 & double.Parse(textBox7.Text) <= 1000000 & double.Parse(textBox8.Text) <= 10 & int.Parse(textBox9.Text) <= 1000 &
                            textBox4.Text.Length <= 20 & textBox5.Text.Length <= 20 & textBox5.Text.Length <= 20)
                        {
                            Printer.Add_Printer(textBox4.Text, textBox5.Text, textBox6.Text, double.Parse(textBox7.Text), double.Parse(textBox8.Text), int.Parse(textBox9.Text));
                            clear();
                            flag = 0;
                        }
                        else MessageBox.Show("Вы вводите данные не правильно! Возможно, вам стоит поменять знаки пробела на нижнее подчеркивание '_', вводить наименования длиной менее 20 символов или заполнить все предложенные поля! Так же не забывайте о том, что рейтинг может быть лишь в 10 бальной шкале, цена до 1000000!");
                    }
                    catch
                    {
                        MessageBox.Show("Вы вводите данные не правильно! Возможно, вам стоит поменять знаки пробела на нижнее подчеркивание '_', вводить наименования длиной менее 20 символов или заполнить все предложенные поля! Так же не забывайте о том, что рейтинг может быть лишь в 10 бальной шкале, цена до 1000000!");
                    }
                }
                else MessageBox.Show("Вы вводите данные не правильно! Возможно, вам стоит поменять знаки пробела на нижнее подчеркивание '_', вводить наименования длиной менее 20 символов или заполнить все предложенные поля! Так же не забывайте о том, что рейтинг может быть лишь в 10 бальной шкале, цена до 1000000!");
            }
            else if (flag == 2)
            {
                if (textBox4.Text != "Введите фирму принтера" & textBox5.Text != "Введите модель принтера" & textBox9.Text != "Введите количество принтеров")
                {
                    try
                    {
                        if (int.Parse(textBox9.Text) > 0)
                        {
                            MessageBox.Show(Printer.Sell_Printer(textBox4.Text, textBox5.Text, int.Parse(textBox9.Text)));
                            clear();
                            flag = 0;
                        }
                        else MessageBox.Show("Вы не можете продать меньше, чем 1 принтер!");
                    }
                    catch
                    {
                        MessageBox.Show("Вы неправильно ввели данные!");
                    }
                }

            }

            else if (flag == 3)
            {
                if (textBox4.Text != "Введите фирму принтера")
                {
                    try
                    {
                        MessageBox.Show(Printer.Read_from_File(textBox4.Text));
                        clear();
                        flag = 0;
                    }
                    catch
                    {
                        MessageBox.Show("Вы неправильно ввели данные!");
                    }
                }
            }
            else if (flag == 4)
            {
                if (textBox4.Text != "Введите логин" & textBox5.Text != "Введите пароль" & textBox6.Text != "Введите тип аккаунта (user/admin)"
                    & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "" & (textBox6.Text == "user" | textBox6.Text == "admin") &
                    textBox4.Text.Split().Length == 1 & textBox5.Text.Split().Length == 1 & textBox6.Text.Split().Length == 1 &
                    textBox4.Text != "users" & textBox4.Text != "info" & textBox4.Text != "check_list" &
                    textBox4.Text != "price_list" & textBox4.Text != "printer_info" & textBox4.Text != "reload" & textBox4.Text != "stat_kol_vo" &
                    textBox4.Text != "stat_price")
                {
                    try
                    {
                        string answer = Printer.Add_user(textBox4.Text, textBox5.Text, textBox6.Text);
                        if (answer == "added_to_list")
                        {
                            MessageBox.Show("Новый пользователь успешно добавлен!");
                            flag = 0;
                            clear();
                        }
                        else MessageBox.Show("Такой пользователь уже есть!");
                        clear();
                    }
                    catch
                    {
                        MessageBox.Show("Вы неправильно ввели данные!");
                    }
                }
                else MessageBox.Show("Правильно вводите данные! Вместо пробелов следует использовать '_', если необходимо.");
            }
            else if (flag == 5)
            {
                if (textBox4.Text != "Введите логин" & textBox5.Text != "Введите пароль" & textBox6.Text != "Введите тип аккаунта (user/admin)"
                    & textBox4.Text != "" & textBox5.Text != "" & textBox6.Text != "" & (textBox6.Text == "user" | textBox6.Text == "admin"))
                {
                    try
                    {
                        string answer = Printer.Delete_user(textBox4.Text, textBox5.Text, textBox6.Text);
                        if (answer == "Успешно")
                        {
                            MessageBox.Show("Пользователь успешно удален!");
                            clear();
                            flag = 0;
                        }
                        else MessageBox.Show("Ошибка! Похоже, такого пользователя нет!");
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка! Похоже, такого пользователя нет!");
                    }
                }
                else MessageBox.Show("В 3 графе должен быть тип аккаунта! Либо user либо admin.");
            }
            else if (flag == 6)
            {
                if (textBox4.Text != "" & textBox5.Text != "" & textBox6.Text!= "" & textBox7.Text != "" & textBox4.Text != "Введите логин" & textBox5.Text != "Введите тип аккаунта (user/admin)" & 
                    textBox6.Text != "Введите тип аккаунта (user/admin)" & textBox7.Text != "Введите желаемый тип аккаунта (user/admin)" &
                    (textBox6.Text == "user" | textBox7.Text == "admin" | textBox6.Text == "admin" | textBox7.Text == "user"))
                    try
                    {
                        string answer = Printer.Change_status_of_user(textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                        if (answer == "Успешно")
                        {
                            MessageBox.Show("Статус аккаунта успешно изменен!");
                            clear();
                            flag = 0;
                        }
                        else MessageBox.Show("Выбранного вами аккаунта нет, либо вы неверно заполнили данные!");
                    }
                    catch
                    {
                        MessageBox.Show("Выбранного вами аккаунта нет, либо вы неверно заполнили данные!");
                    }
                else MessageBox.Show("Выбранного вами аккаунта нет, либо вы неверно заполнили данные!");
            }
            else if (flag == 7)
            {
                double price = double.TryParse(textBox7.Text, out _) ? double.Parse(textBox7.Text) : 0;
                double rate = double.TryParse(textBox8.Text, out _) ? double.Parse(textBox8.Text) : 0;
                int kol_vo = int.TryParse(textBox9.Text, out _) ? int.Parse(textBox9.Text) : 0;
                try
                {
                    string answer = Printer.Change_price_list_items(textBox4.Text, textBox5.Text, textBox6.Text, price, rate, kol_vo);
                    if (answer == "Успешно!")
                    {
                        clear();
                        MessageBox.Show("Вы успешно изменили данные о принтере");
                    }
                    else if (answer == "Нечего изменять!")
                        MessageBox.Show("Вы не ввели данные для замены значений полей или ввели их неправильно!");
                    else MessageBox.Show("Такого принтера нет или вы ввели неверные данные.");
                }
                catch
                {
                    MessageBox.Show("Такого принтера нет или вы ввели неверные данные.");
                }
             }
            else if (flag == 8)
            {
                if (textBox4.Text.Split().Length == 1 & textBox5.Text.Split().Length == 1)
                {
                    string answer = Printer.Delete_printer_from_price_list(textBox4.Text, textBox5.Text);
                    if (answer == "Успешно!")
                    {
                        clear();
                        MessageBox.Show("Принтер успешно удален из прайс-листа!");
                    }
                    else MessageBox.Show("Данного принтера нет в прайс-листе, либо вы неверно ввели данные!");
                }
                else MessageBox.Show("Данного принтера нет в прайс - листе, либо вы неверно ввели данные!");
            }
            printerBindingSource.ResetBindings(false);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            clear();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = 3;
            clear();
            textBox4.Text = "Введите название файла для прочтения";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flag = 2;
            clear();
            textBox4.Text = "Введите фирму принтера";
            textBox5.Text = "Введите модель принтера";
            textBox9.Text = "Введите количество принтеров";
        }


        private void button7_Click(object sender, EventArgs e)
        {
            string text = Printer.Read_from_File("check_list.txt");
            if (text == "")
            {
                MessageBox.Show("Пока ещё нечего закупать!");
            }
            else
            {
                Printer.purchase();
                MessageBox.Show("Закупка прошла успешно!");
                Printer.Write_log(Form3.name_for_log, "произвел закупку недостающих принтеров");
                printerBindingSource.ResetBindings(false);
                clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            clear();
            string text = Printer.Read_from_File("check_list.txt");
            if (text == "")
            {
                MessageBox.Show("Тут пока что пусто!");
            }
            else MessageBox.Show(text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clear();
            Printer.statistics();
            MessageBox.Show("Статистика по ценам принтеров записана в файлы stat_price.txt и stat_kol_vo.txt");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            clear();
            MessageBox.Show(Printer.check_statistics());
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clear();
            Printer.Reload();
            Printer.Read_file_with_printers("price_list.txt");
            printerBindingSource.ResetBindings(false);
            MessageBox.Show("Данные успешно откачены до начальных!");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            clear();
            flag = 4;
            textBox4.Text = "Введите логин";
            textBox5.Text = "Введите пароль";
            textBox6.Text = "Введите тип аккаунта (user/admin)";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            clear();
            flag = 5;
            textBox4.Text = "Введите логин";
            textBox5.Text = "Введите пароль";
            textBox6.Text = "Введите тип аккаунта (user/admin)";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flag == 1 | flag == 2)
            {
                textBox4.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox5.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox6.Text = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox7.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox8.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            else if (flag == 7)
            {
                textBox4.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox5.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            }
            else if (flag == 8)
            {
                textBox4.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
                textBox5.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = new Bitmap("C_Sharp_logo.png");
        }
        /*При выборе textbox автоматически выделяю весь текст в нем для удобства*/

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.SelectionStart = 0;
            textBox4.SelectionLength = textBox4.Text.Length;
            textBox4.Focus();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.SelectionStart = 0;
            textBox5.SelectionLength = textBox5.Text.Length;
            textBox5.Focus();
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.SelectionStart = 0;
            textBox6.SelectionLength = textBox6.Text.Length;
            textBox6.Focus();
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.SelectionStart = 0;
            textBox7.SelectionLength = textBox7.Text.Length;
            textBox7.Focus();
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.SelectionStart = 0;
            textBox8.SelectionLength = textBox8.Text.Length;
            textBox8.Focus();
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.SelectionStart = 0;
            textBox9.SelectionLength = textBox9.Text.Length;
            textBox9.Focus();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Owner = this;
            form6.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Owner = this;
            form7.ShowDialog();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process.Start("users.txt");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            flag = 6;
            textBox4.Text = "Введите логин";
            textBox5.Text = "Введите пароль";
            textBox6.Text = "Введите тип аккаунта (user/admin)";
            textBox7.Text = "Введите желаемый тип аккаунта (user/admin)";
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Введите фирму принтера, который вы хотите изменить";
            textBox5.Text = "Введите модель принтера, который вы хотите изменить";
            textBox6.Text = "Введите новый тип принтера, если хотите изменить";
            textBox7.Text = "Введите новую цену принтера, если хотите изменить";
            textBox8.Text = "Введите новый рейтинг принтера, если хотите изменить";
            textBox9.Text = "Введите новое количество принтеров, если хотите изменить";
            flag = 7;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            flag = 8;
            textBox4.Text = "Введите фирму принтера, который вы хотите удалить";
            textBox5.Text = "Введите модель принтера, который вы хотите удалить";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Process.Start("Пояснение к функционалу.txt");
        }

        /*Каждая сортировка меняет страктуру порядок элементов в списке, а так же в файле*/
        private void сортировкаПоВозрастаниюЦеныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderBy(x => x.Price).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Пояснение к функционалу.txt");
        }


        private void сортироватьПоНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderBy(x => x.Name).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоТипуМоделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderBy(x => x.Type).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоВозрастаниюКоличестваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderBy(x => x.Kol_vo).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоУбываниюКоличестваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderByDescending(x => x.Kol_vo).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоВозрастаниюРейтингаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderBy(x => x.Rate).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоУбываниюРейтингаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderByDescending(x => x.Rate).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортироватьПоМоделиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderBy(x => x.Model).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }

        private void сортировкаПоУбываниюЦеныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printerBindingSource.DataSource = Printer.Printer_list = Printer.Printer_list.OrderByDescending(x => x.Price).ToList<Printer>();
            printerBindingSource.ResetBindings(false);
        }
    }
}
