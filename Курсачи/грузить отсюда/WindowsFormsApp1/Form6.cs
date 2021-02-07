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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        /*Просто меняю цвет родительской формы для диалоговой.*/
        private void button3_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.Green;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.BackColor = SystemColors.Control;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.Yellow;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.Cyan;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.Aquamarine;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.Ivory;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.Maroon;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.OliveDrab;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.PaleVioletRed;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.PeachPuff;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.SlateGray;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.Tan;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.Sienna;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.PowderBlue;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Owner.BackColor = System.Drawing.Color.Tomato;
        }

        private void button17_Click(object sender, EventArgs e)
        {
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Пояснение к функционалу.txt");
        }
    }
}
