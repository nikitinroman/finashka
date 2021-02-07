using System;
using System.Data;
using System.Windows.Forms;

namespace IBR
{
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }

        public static bool changeInd = true;

        void ChangeParam()//функция меняющая форму в зависимости от выставленного флага
        {
            if (changeInd)//проверка если установлен флаг "изменение показателя" то настраиваемформы под показатель
            {
                label1.Visible = true;
                textBox1.Visible = true;
                label2.Text = "Температура";
                label3.Visible = true;
                textBox3.Visible = true;
                label4.Visible = true;
                textBox4.Visible = true;
                label5.Visible = true;
                textBox5.Visible = true;
                label6.Visible = true;
                textBox6.Visible = true;
            }
            else//иначе настрыиваем форму под регион
            {
                label1.Visible = false;
                textBox1.Visible = false;
                label3.Visible = false;
                textBox3.Visible = false;
                label4.Visible = false;
                textBox4.Visible = false;
                label5.Visible = false;
                textBox5.Visible = false;
                label6.Visible = false;
                textBox6.Visible = false;
                label2.Text = "Регион";
            }

        }

        private void Change_Load(object sender, EventArgs e)//загрузка формы
        {
            try
            {

                ChangeParam();
                if (SQL_query.update)//если запрос на изменение то заполним текстбоксы текущими значениями
                {
                    DataTable dt = SQL_query.SendQuery("SELECT * FROM [Показатели по годам] WHERE [Показатели по годам].[Год] = " + CurrentIndicator.Year + " AND [Показатели по годам].[Температура] = '" + CurrentIndicator.Avr + "' AND [Показатели по годам].[Регион] = '" + CurrentIndicator.RigId + "'", "[Показатели по годам]");
                    //DataTable dt = SQL_query.SendQuery("SELECT * FROM [Показатели по годам] WHERE [Температура] = '" + CurrentIndicator.Avr + "'", "[Показатели по годам]");
                    textBox1.Text = Convert.ToString(dt.Rows[0][1]);
                    textBox2.Text = Convert.ToString(dt.Rows[0][2]);
                    textBox3.Text = Convert.ToString(dt.Rows[0][3]);
                    textBox4.Text = Convert.ToString(dt.Rows[0][4]);
                    textBox5.Text = Convert.ToString(dt.Rows[0][5]);
                    textBox6.Text = Convert.ToString(dt.Rows[0][6]);
                }
                else if (SQL_query.add)
                {

                }

            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)//кнопка сохранить
        {
            try
            {
                if (changeInd)//если меняем показатель
                {
                    if (SQL_query.update)//если запрос на изменение
                    {
                        SQL_query.QueryOfCng("UPDATE [Показатели по годам] SET " +
                            "[Показатели по годам].[Год] = " + textBox1.Text +
                            ", [Показатели по годам].[Температура] = " + textBox2.Text +
                            ", [Показатели по годам].[Влажность] = " + textBox3.Text +
                            ", [Показатели по годам].[Давление] = " + textBox4.Text +
                            ", [Показатели по годам].[Сила ветра] = " + textBox5.Text +
                            ", [Показатели по годам].[Осадки] = " + textBox6.Text +
                            " WHERE [Показатели по годам].[Год] = " + CurrentIndicator.Year +
                            " AND [Показатели по годам].[Температура] = '" + CurrentIndicator.Avr +
                            "' AND [Показатели по годам].[Регион] = '" + CurrentIndicator.RigId + "'");
                        SQL_query.update = false;
                    }
                    else if (SQL_query.add)//если запрос на добавление нового показателя
                    {
                        SQL_query.QueryOfCng("INSERT INTO [Показатели по годам] ([Год], [Температура], [Влажность], [Давление], [Сила ветра], [Осадки], [Регион]) VALUES ('" +
                            textBox1.Text + "', '" +
                            textBox2.Text + "', '" +
                            textBox3.Text + "', '" +
                            textBox4.Text + "', '" +
                            textBox5.Text + "', '" +
                            textBox6.Text + "', '" +
                            CurrentIndicator.RigId + "')");
                        SQL_query.add = false;
                    }
                }
                else//иначе добавляем регион
                {
                    SQL_query.QueryOfCng("INSERT INTO Регионы (Регион) VALUES ('" + textBox2.Text + "')");
                }

            }
            catch (Exception)
            {

            }

            Close();//закрываем форму
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//событие ввода символа
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))//ввод только цифр
            {
                e.Handled = true;
            }
        }

        private void Change_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQL_query.update = false;
            SQL_query.add = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)//событие ввода символа
        {
            //if (changeInd)
            //{
            //    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))//ввод только цифр
            //    {
            //        e.Handled = true;
            //    }
            //}
        }
    }
}
