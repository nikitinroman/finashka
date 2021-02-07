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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        /*Просто меняю цвет кнопок родительско для диалоговой формы*/
        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.Blue;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.Lime;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.AliceBlue;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.DarkOrchid;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.OldLace;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.Goldenrod;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.Turquoise;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.Indigo;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.Moccasin;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.DeepPink;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.DarkOrchid;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.Chartreuse;
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = SystemColors.Control;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Owner.Controls.Count; i++)
            {
                if (Owner.Controls[i].GetType().ToString() == "System.Windows.Forms.Button")
                    Owner.Controls[i].BackColor = Color.DodgerBlue;
            }
        }
        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Пояснение к функционалу.txt");
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
