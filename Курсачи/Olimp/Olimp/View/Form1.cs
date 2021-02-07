using Olimp.Models;
using Olimp.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Olimp
{
    public partial class Form1 : Form
    {
        //связь с бд
        private Model1 db = new Model1();
        //формы
        private static LoginForm loginForm;
        private static AddStudentForm addStudentForm;
        //контейнер для связи с таблицей и бд
        private static List<Student> students;
        public Form1( LoginForm form1)
        {
            InitializeComponent();
            loginForm = form1;

            //инициализируем объекты формы
            ToolStripMenuItem aboutItem = new ToolStripMenuItem("О программе");
            aboutItem.Click += aboutItem_Click;

            menuStrip1.Items.Add(aboutItem);

            comboBox1.Items.AddRange(new string[] { "math", "russian", "все"});
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            if (User.Level == 1)//если нет доступа, просто скрываем кнопки
            {
                button1.Hide();
                addBtn.Hide();
            }
            //составляем простой запрос на получение всех олимпиадников.
            var query = from c in  db.Student select c;

            //так как напрямую связать datagridview с бд нельзя, то связываем со списком 
            students = query.ToList();
            dataGridView.DataSource = students;
        }

        void aboutItem_Click(object sender, EventArgs e)
        {
            //просто апускаем блокнот, с параметром, указывая путь к файлу, который надо открыть
            ProcessStartInfo stInfo =
               new ProcessStartInfo("Notepad.exe", @"О программе.txt")
               {
                   UseShellExecute = false,
                   CreateNoWindow = true
               };

            Process proc = new Process();
            proc.StartInfo = stInfo;
            proc.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm?.Close();//если не null, то уничтожаем обект формы
            addStudentForm?.Close();//если не null, то уничтожаем обект формы
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addStudentForm = new AddStudentForm(this);//создаем форму
            this.Hide();//прячем основную
            addStudentForm.Show();//показываем форму добавления олимпиадников
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            IQueryable<Student> query = null;

            switch (comboBox1.SelectedItem.ToString())
            {
                //c помощью запросов изменяем список, который привязан с dataGridView и соответственно выводим, что нам нужно
                case "math":
                    query = db.Student.Where(p => p.Subject == "math");
                    break;
                case "russian":
                    query = db.Student.Where(p => p.Subject == "russian");
                    break;
                case "все":
                    query = from c in db.Student select c;//обычный запрос
                    break;
            }

            students = query.ToList();
            dataGridView.DataSource = students;
            ResetBindings();//очень важно, заставляем перерисоваться форму, чтобы увидеть изменения
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.SaveChanges();//просто сохраняем изменения, который были сделаны с списком students
        }
    }
}
