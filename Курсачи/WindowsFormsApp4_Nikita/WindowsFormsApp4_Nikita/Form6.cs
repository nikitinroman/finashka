using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_Nikita
{
    public partial class Form6 : Form
    {
        //Форма, отвечающая за построение и отрисовку графика.
        public Form6()
        {
            InitializeComponent();
        }
        public static List<string> list_of_manuf = new List<string>();
        public static List<int> list_of_capital = new List<int>();

        public static void pieplot()
        {
            for (int i = 0; i < Kvadro_manuf.Kvadro_man_list.Count; i++)
            {
                list_of_manuf.Add(Kvadro_manuf.Kvadro_man_list[i].Manufacturer);
                list_of_capital.Add(Kvadro_manuf.Kvadro_man_list[i].Capitalisation);
            }
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            Kvadro_manuf.Load_info();
            pieplot();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series[0].Points.DataBindXY(list_of_manuf, list_of_capital);
            list_of_manuf.Clear();
            list_of_capital.Clear();
        }
    }
}
