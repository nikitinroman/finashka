using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4Maria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string status = "";
        public void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "reductor")
            {
                status = "reduct";
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                status = "view";
                this.Hide();
                Form2 f2 = new Form2();                
                f2.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
