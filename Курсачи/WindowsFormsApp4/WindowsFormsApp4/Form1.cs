using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=users.mdb;";
        private OleDbConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
        }
        Registration reg = new Registration("", "", "");

        private void Form1_Load(object sender, EventArgs e)
        {
            reg.Read_users_from_file();
            registrationBindingSource.DataSource = Registration.Registration_list;
            /*registrationBindingSource.ResetBindings(false);*/
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopDataSet.users". При необходимости она может быть перемещена или удалена.
            /*this.usersTableAdapter.Fill(this.shopDataSet.users);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reg.Add(textBox1.Text, textBox2.Text);
            registrationBindingSource.ResetBindings(false);
        }
    }
}
