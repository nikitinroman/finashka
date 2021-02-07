using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;

namespace WindowsFormsApp4
{
    class Registration
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }

        public static List<Registration> Registration_list = new List<Registration>(); /*Список со всеми пользователями*/
        private OleDbConnection myConnection;

        public Registration(string _name, string _password, string _status)
        {
            Name = _name;
            Password = _password;
            Status = _status;
        }
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=shop.mdb;";
        public void Read_users_from_file()
        {
            string query = "SELECT * FROM users";
            myConnection = new OleDbConnection(connectString);
            // открываем соединение с БД
            myConnection.Open();
            // создаем объект OleDbCommand для выполнения запроса к БД MS Access
            OleDbCommand command = new OleDbCommand(query, myConnection);

            // получаем объект OleDbDataReader для чтения табличного результата запроса SELECT
            OleDbDataReader reader = command.ExecuteReader();

            // очищаем listBox1
            Registration_list.Clear();

            // в цикле построчно читаем ответ от БД
            while (reader.Read())
            {
                Registration user = new Registration(reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                Registration_list.Add(user);
            }
            // закрываем OleDbDataReader
            reader.Close();
            myConnection.Close();
        }
        public void Add(string user, string password, string status = "2")
        {
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            OleDbTransaction trans = myConnection.BeginTransaction();
            string sql1 = $"SELECT COUNT(*) FROM users";
            OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
            string x = cmd1.ExecuteScalar().ToString();
            int y = int.Parse(x) + 1;
            string sql2 = $"INSERT INTO users VALUES({y}, {user}, {password} ,{status})";
            OleDbCommand cmd2 = new OleDbCommand(sql2, myConnection, trans);
            cmd2.ExecuteNonQuery(); //отсюда можно возвращать номер последнего, как вариант место последовательности.
            trans.Commit();
            /*OleDbTransaction transaction = null;
            transaction = myConnection.BeginTransaction();
            OleDbCommand command = new OleDbCommand();
            command.Connection = myConnection;
            command.Transaction = transaction;

            // Execute the commands.
            command.CommandText = $"INSERT INTO users VALUES(4, {user}, { password} ,{ status})";
            command.ExecuteNonQuery();

            // Commit the transaction.
            transaction.Commit();*/
            myConnection.Close();
            Read_users_from_file();
        }
    }
}

