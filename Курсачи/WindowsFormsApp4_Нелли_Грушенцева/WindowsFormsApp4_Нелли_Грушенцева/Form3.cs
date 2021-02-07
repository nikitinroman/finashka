using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_Нелли_Грушенцева
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static List<string> list_of_types = new List<string>();
        public static List<int> list_of_money = new List<int>();

        public static void pieplot()
        {
            for (int i = 0; i < Client.Clients.Count; i++)
            {
                list_of_types.Add(Client.Clients[i].Type);
                list_of_money.Add(Client.Clients[i].Money);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pieplot();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Series[0].Points.DataBindXY(list_of_types, list_of_money);
            list_of_types.Clear();
            list_of_money.Clear();
        }
    }
}
