using Olimp.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Olimp.View
{
    public partial class AddStudentForm : Form
    {
        Model1 db = new Model1();
        Form1 form;// для хранения главной формы
        string selectedState = string.Empty;
        public AddStudentForm(Form1 form1)
        {
            form = form1;
            InitializeComponent();
            // добавляем выпадающий список, по хорошему стоило бы иметь словарь предметов в бд
            comboBox1.Items.AddRange(new string[] { "math", "russian" });
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            if(textBox1.Text != "" && textBox2.Text != "")
            {
                student.FIO = textBox1.Text;
                student.Score = Convert.ToInt32(textBox2.Text);
                student.Subject = selectedState;

                var tmp = db.Student.ToList();
                student.Id = tmp.Count + 1;//маленький костыль, так как автоинкримент, почемуто через заполнение entity не захотел работать.
            }

            db.Student.Add(student);

            db.SaveChanges();
            MessageBox.Show("Данные сохранены");
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = comboBox1.SelectedItem.ToString();//берем название предмета
        }

        private void AddStudentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Show();//открываем главную форму
        }
    }
}
