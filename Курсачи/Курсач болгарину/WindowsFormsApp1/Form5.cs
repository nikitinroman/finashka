using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public static List<string> list_of_models = new List<string>();
        public static List<int> list_of_numbers = new List<int>();
        
        public static void pieplot()
        {
            for (int i = 0; i < Technique.Technics_list.Count; i++)
            {
                list_of_models.Add(Technique.Technics_list[i].Model);
                list_of_numbers.Add(Technique.Technics_list[i].Kol_vo);
            }
        }

        private void Form5_Load_1(object sender, EventArgs e)
        {
            pieplot();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series[0].Points.DataBindXY(list_of_models, list_of_numbers);
            list_of_models.Clear();
            list_of_numbers.Clear();
        }
    }
}


