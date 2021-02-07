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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Member.Download_info_about_members_into_list();
            Bubbleplot();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            chart1.Series[0].Points.DataBindXY(lst_of_scores, lst_of_classes);
            lst_of_scores.Clear();
            lst_of_classes.Clear();
        }
        public static List<int> lst_of_scores = new List<int>();
        public static List<int> lst_of_classes = new List<int>();

        public static void Bubbleplot()
        {
            for (int i = 0; i < Member.Members_lst.Count; i++)
            {
                lst_of_scores.Add(Member.Members_lst[i].Score);
                lst_of_classes.Add(Member.Members_lst[i].The_сlass);
            }
        }
    }
}
