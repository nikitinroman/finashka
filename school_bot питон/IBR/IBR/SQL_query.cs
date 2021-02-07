using System;
using System.Data;
using System.Data.OleDb;

namespace IBR
{
    public static class SQL_query//класс запросов к базе данных
    {
        private static string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=" + Environment.CurrentDirectory + "\\БД.mdb";//строка подключения
        public static bool update;//флаг изменения
        public static bool add;//флаг добавления

        public static DataTable SendQuery(string qr, string table)//функция обрабатывающая запрос к базе данных и возвращает таблицу соответственно выполненому запросу
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(qr, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, table);
            return ds.Tables[table];
        }

        public static void QueryOfCng(string qr)//функция для управления элементами в базе данных (добавление, изменение, удаление)
        {
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            OleDbCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = qr;
            myCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}
