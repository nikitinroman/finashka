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
    public partial class Form7 : Form
    {
        //Форма, отвечающая за построение и отрисовку графика.
        public Form7()
        {
            InitializeComponent();
        }
        public static List<string> list_of_models = new List<string>();
        public static List<int> list_of_power = new List<int>();

        public static void pieplot()
        {
            for (int i = 0; i < Kvadro_info.Kvadro_info_list.Count; i++)
            {
                list_of_models.Add(Kvadro_info.Kvadro_info_list[i].Model);
                list_of_power.Add(Kvadro_info.Kvadro_info_list[i].Power);
            }
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            Kvadro_info.Load_info();
            pieplot();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series[0].Points.DataBindXY(list_of_models, list_of_power);
            list_of_models.Clear();
            list_of_power.Clear();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
