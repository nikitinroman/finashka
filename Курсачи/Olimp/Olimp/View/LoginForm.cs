using Olimp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Olimp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" && textBox2.Text == "1")
            {
                User.Level = 0;
                Form1 form = new Form1(this);
                form.Show();
                this.Hide();
            }
            else
                if(textBox1.Text == "2" && textBox2.Text == "2")
                {
                    User.Level = 1;
                    Form1 form = new Form1(this);
                    form.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Не верный логин или пароль");
        }
    }
}
