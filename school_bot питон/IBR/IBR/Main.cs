using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace IBR
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        static List<Rigion> listRig = new List<Rigion>();//список регионов

        private void Main_Load(object sender, EventArgs e)//событие загрузки формы
        {
            listRig.Clear();//очистка списка регионов
            listBox1.Items.Clear();//очистка списка в форме
            DataTable dt = SQL_query.SendQuery("SELECT * FROM [Регионы]", "[Регионы]");//выполняем запрос и сохраняем данные в виде таблицы
            for (int i = 0; i < dt.Rows.Count; i++)//бегаем циклом по количеству строк в таблице
            {
                Rigion rig = new Rigion((int)dt.Rows[i][0], (string)dt.Rows[i][1]);//создаем объект класса регион в кноструктор передаем параметры id и имя
                listRig.Add(rig);//добавляем регион к списку регионов
                listBox1.Items.Insert(i, dt.Rows[i][1]);//добавляем регион в список в форме
            }
            listBox1.SelectedIndex = 0;//выбираем первый элемент из списка в форме
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)//событие выбора элемента из списка в форме
        {
            int index = listBox1.SelectedIndex;//получаем текущий отпуск
            if (index < 0) return;//если не выбрано индекса то не выполняем дальше код
            for (int i = 0; i < listRig.Count; i++)//бегаем по списку регионов
            {
                if ((string)listBox1.Items[index] == listRig[i].Rig)//если выбранный регион равен региону из списка
                {
                    dataGridView1.DataSource = SQL_query.SendQuery("SELECT * FROM [Показатели по годам] WHERE [Показатели по годам].[Регион] = '" + listRig[i].Id + "'", "[Показатели по годам]");//выполнчем запрос и получаем данные для дгв из БД
                }
            }
            dataGridView1.Columns[0].Visible = false;//скрываем колонку с id
            dataGridView1.Columns[7].Visible = false;//скрываем колонку с принадлежащем показателю региону
        }

        private void button3_Click(object sender, EventArgs e)//кнопка удалить
        {
            try
            {
                string id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();//получаем id выбранного показателя
                SQL_query.QueryOfCng("DELETE FROM [Показатели по годам] WHERE [Показатели по годам].[Код] = " + id);//удаляем выбранный показатель из БД
                listBox1_SelectedIndexChanged(null, null);//вызываем срабатывания события выбора элемента из списка
            }
            catch (Exception)
            {

            }
        }

        public int GetId()//функция получения текущего id показателя
        {
            int index = -1;
            for (int i = 0; i < listRig.Count; i++)//бегаем по списку регионов
            {
                if ((string)listBox1.Items[listBox1.SelectedIndex] == listRig[i].Rig)//если выбранный регион из списка совпал с требуемым регионом
                {
                    index = listRig[i].Id;//запоминаем индекс региона
                }
            }
            return index;//возвращаем значение из функции
        }

        private void GetData()//функция получения данных
        {
            CurrentIndicator.RigId = GetId();//записываем в переменную класса текущего показателся корректный id
            try//блок ловит ошибку
            {
                CurrentIndicator.Year = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();//записываем в переменную класса корректный год
                CurrentIndicator.Avr = dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString();//записываем в переменную класса корректную среднюю температуру года
                CurrentIndicator.Vlajnost = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();//записываем в переменную класса корректную среднюю влажность года
                CurrentIndicator.Davlenie = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();//записываем в переменную класса корректную среднее давление года
                CurrentIndicator.Veter = dataGridView1[5, dataGridView1.CurrentRow.Index].Value.ToString();//записываем в переменную класса корректную среднюю силу ветра года
                CurrentIndicator.Osadki = dataGridView1[6, dataGridView1.CurrentRow.Index].Value.ToString();//записываем в переменную класса корректную среднюю количества осадков года
            }
            catch (Exception)//если ошибка поймана то она обрабатываеся в этом блоке
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)//кнопка изменения региона
        {
            try//блок ловит ошибку
            {
                Change.changeInd = true;//флаг изменения показателя
                SQL_query.update = true;//флаг для запроса на обновление показателя
                GetData();//получаем данные выбранного показателя
                Change cng = new Change();//создаем форму для добавления показателя
                cng.ShowDialog();//открываем форму
            }
            catch (Exception)//если ошибка поймана то она обрабатываеся в этом блоке
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)//кнопка добавить регион
        {
            try
            {
                Change.changeInd = true;//флаг изменения показателя
                SQL_query.add = true;//флаг для запроса на добавление показателя
                GetData();//получаем данные выбранного показателя
                Change cng = new Change();//создаем форму для добавления показателя
                cng.ShowDialog();//открываем форму
            }
            catch (Exception)
            {


            }
        }

        private void Main_Activated(object sender, EventArgs e)//событие активации формы
        {
            if (!Change.changeInd)//проверка флага
            {
                Main_Load(null, null);//вызов события загрузки формы
            }
            listBox1_SelectedIndexChanged(null, null);//вызов события выбора элемента из списка
        }

        private void button4_Click(object sender, EventArgs e)//кнопка добавить регион
        {
            Change.changeInd = false;//флаг изменения региона
            Change cng = new Change();//создаем форму для добавления показателя
            cng.ShowDialog();//открываем форму
        }

        private void PrintGraph(int index)
        {
            chart1.Series[0].Points.Clear();//очищаем график
            double max = -1000;//переменная хранения максимального значения
            double min = 1000;//переменная хранения минимального значения
            double avr = 0;//переменная хранения среднего значения
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)//бегаем по элементам строк в таблице
            {
                double ind = Convert.ToDouble(dataGridView1.Rows[i].Cells[index].Value);//получем текущую температуру
                avr += ind;//прибавляем к общей для вычисления среднего значений между годами
                if (ind > max) { max = ind; }//сохраняем максимальное значение
                if (ind < min) { min = ind; }//сохраняем минимальное значение
                double x = Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);//год
                double y = ind;//температура
                chart1.Series[0].Points.AddXY(x, y);//строим график
            }
            avr /= dataGridView1.RowCount - 1;//вычисляем среднее значение
            textBox1.Text = min.ToString();//вывод в текст бокс минимума
            textBox2.Text = max.ToString();//вывод в текст бокс максимума
            textBox3.Text = Math.Round(avr, 2).ToString(); //вывод в текст бокс среднего
        }

        private void button5_Click(object sender, EventArgs e)//кнопка <<
        {
            this.Width = 480;//устанавливаем ширину экрана
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)//кнопка об авторе
        {
            MessageBox.Show("Приложение разработано студентом факультета ПМиИТ Группы ПИ18-1 Пыльцыной Анастасией в 2020 году в рамках курсовой работы.");//вызываем меседж бокс с сообщением
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)//кнопка справка о программе
        {
            Process.Start("Help.txt");//запуск сторонней программы
        }

        private void графикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintGraph(2);//строим график по показателю температура
        }

        private void влажностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintGraph(3);//строим график по показателю влажность
        }

        private void давлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintGraph(4);//строим график по показателю давление
        }

        private void силаВетраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintGraph(5);//строим график по показателю сила ветра
        }

        private void осадкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintGraph(6);//строим график по показателю осадки
        }
    }
}
