using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace WindowsFormsApp4_Nikita
{
    //Класс с производителями квадроциклов. В режиме администратора мы можем добавить, изменить или удалить строку с записью о той или иной компании.
    class Kvadro_manuf
    {
        public string Manufacturer { get; set; }
        public string Owner { get; set; }
        public int Capitalisation { get; set; }
        public int Year_of_start { get; set; }
        public string Country { get; set; }
        //Список, содержащий все объекты данного класса

        public static List<Kvadro_manuf> Kvadro_man_list = new List<Kvadro_manuf>();
        //Подключение к базе данных, из которой программа берет данные для первоначальной загрузки.
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Kvadrobase.mdb;";
        public Kvadro_manuf(string manufacturer, string owner, int capitalisation, int year_of_start, string country)
        {
            Manufacturer = manufacturer;
            Owner = owner;
            Capitalisation = capitalisation;
            Year_of_start = year_of_start;
            Country = country;
        }
        public Kvadro_manuf() { }
        // Функция для загрузки всех данных из базы данных в программу (в список).
        public static void Load_info()
        {
            // Воизбежание излишних трудностей и ошибок- полностью очищаю список и заново его перезаписываю, так как затраты по времени незначительные.
            Kvadro_man_list.Clear();
            string query = "SELECT * FROM kvadro_man";
            OleDbConnection myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader take_info = command.ExecuteReader();
            while (take_info.Read())
            {
                Kvadro_manuf manuf = new Kvadro_manuf(take_info[1].ToString(), take_info[2].ToString(), int.Parse(take_info[3].ToString()), int.Parse(take_info[4].ToString()), take_info[5].ToString());
                Kvadro_man_list.Add(manuf);
            }
            take_info.Close();
            myConnection.Close();
        }
        //Функция для добавления информации в базу данных. Все изменения в базе данных автоматически сохраняются.
        //Вместо xml- сериализации использую access mdb.
        public static string Add_info(string manufacturer, string owner, int capitalisation, int year_of_start, string country)
        {
            int flag = 0;
            for (int i = 0; i < Kvadro_man_list.Count; i++)
            {
                if (Kvadro_man_list[i].Manufacturer == manufacturer)
                    flag += 1;
            }
            if (flag == 0 & capitalisation > 0 & year_of_start > 1900 & year_of_start < 2021)
            {
                Kvadro_manuf manuf = new Kvadro_manuf(manufacturer, owner, capitalisation, year_of_start, country);
                Kvadro_man_list.Add(manuf);
                OleDbConnection myConnection = new OleDbConnection(connectString);
                myConnection.Open();
                OleDbTransaction trans = myConnection.BeginTransaction();
                string sql1 = $"SELECT MAX(id) FROM kvadro_man";
                OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
                string x = cmd1.ExecuteScalar().ToString();
                int y = int.Parse(x) + 1;
                string sql2 = $"INSERT INTO kvadro_man VALUES ({y}, '{manufacturer}', '{owner}', '{capitalisation}', '{year_of_start}', '{country}')";
                OleDbCommand cmd2 = new OleDbCommand(sql2, myConnection, trans);
                cmd2.ExecuteNonQuery();
                trans.Commit();
                myConnection.Close();
                return "успешно";
            }
            return "неуспешно";
        }
        //Функция удаления информации/строки/записи из базы данных. Изменения так же автоматически сохраняются.
        public static string Delete_info(string manufacturer)
        {
            for (int i = 0; i < Kvadro_man_list.Count; i++)
            {
                if (Kvadro_man_list[i].Manufacturer == manufacturer)
                {
                    Kvadro_man_list.Remove(Kvadro_man_list[i]);
                    OleDbConnection myConnection = new OleDbConnection(connectString);
                    myConnection.Open();
                    OleDbTransaction trans = myConnection.BeginTransaction();
                    string sql2 = $"DELETE FROM kvadro_man WHERE manufacturer = '{manufacturer}'";
                    OleDbCommand cmd2 = new OleDbCommand(sql2, myConnection, trans);
                    cmd2.ExecuteNonQuery();
                    trans.Commit();
                    myConnection.Close();
                    return "успешно";
                }
            }
            return "неуспешно";
        }
        // Функция для изменения данных в таблице базы данных kvadro_man. Изменения сохраняются так же автоматически.
        public static string Change_info(string manufacturer, string owner, int capitalisation = 0, int year_of_start = 0, string country = "")
        {
            int flag = 0;
            if (capitalisation > 0)
            {
                flag += 1;
                OleDbConnection myConnection = new OleDbConnection(connectString);
                myConnection.Open();
                OleDbTransaction trans = myConnection.BeginTransaction();
                string sql1 = $"UPDATE kvadro_man SET capitalisation = '{capitalisation}' where manufacturer = '{manufacturer}' and owner = '{owner}'";
                OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
                cmd1.ExecuteScalar();
                trans.Commit();
                myConnection.Close();
            }
            if (year_of_start > 1900 & year_of_start < 2021)
            {
                flag += 1;
                OleDbConnection myConnection = new OleDbConnection(connectString);
                myConnection.Open();
                OleDbTransaction trans = myConnection.BeginTransaction();
                string sql1 = $"UPDATE kvadro_man SET year_of_start = '{year_of_start}' where manufacturer = '{manufacturer}' and owner = '{owner}'";
                OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
                cmd1.ExecuteScalar();
                trans.Commit();
                myConnection.Close();
            }
            if (country != "")
            {
                flag += 1;
                OleDbConnection myConnection = new OleDbConnection(connectString);
                myConnection.Open();
                OleDbTransaction trans = myConnection.BeginTransaction();
                string sql1 = $"UPDATE kvadro_man SET country = '{country}' where manufacturer = '{manufacturer}' and owner = '{owner}'";
                OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
                cmd1.ExecuteScalar();
                trans.Commit();
                myConnection.Close();
            }
            if (flag > 0)
                return "успешно";
            else return "неуспешно";
        }

    }
    // Класс с информацией о всех квадрациклах, хранимых в базе данных MDB.
    class Kvadro_info
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year_of_prod { get; set; }
        public int Kol_vo { get; set; }
        public int Power { get; set; }
        public int Price { get; set; }
        // Список, хранящий объекты класса.

        public static List<Kvadro_info> Kvadro_info_list = new List<Kvadro_info>();
        // База данных, из которой программа берет информацию при загрузке.
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Kvadrobase.mdb;";
        public Kvadro_info(string manufacturer, string model, int year_of_prod, int kol_vo, int power, int price)
        {
            Manufacturer = manufacturer;
            Model = model;
            Year_of_prod = year_of_prod;
            Kol_vo = kol_vo;
            Power = power;
            Price = price;
        }
        // Функция для загрузки всех данных из базы данных для последующей работы с ними. Все изменения сохраняются автоматически.
        public static void Load_info()
        {
            // Воизбежание излишних трудностей и ошибок- полностью очищаю список и заново его перезаписываю, так как затраты по времени незначительные.
            Kvadro_info_list.Clear();
            string query = "SELECT * FROM kvadro_info";
            OleDbConnection myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader take_info = command.ExecuteReader();
            while (take_info.Read())
            {
                Kvadro_info info = new Kvadro_info(take_info[1].ToString(), take_info[2].ToString(), int.Parse(take_info[3].ToString()), int.Parse(take_info[4].ToString()), int.Parse(take_info[5].ToString()), int.Parse(take_info[6].ToString()));
                Kvadro_info_list.Add(info);
            }
            take_info.Close();
            myConnection.Close();
        }
        // Функция для добавления информации о квадрокоптере.

        public static string Add_info(string manufacturer, string model, int year_of_prod, int kol_vo, int power, int price)
        {
            int flag = 0;
            for (int i = 0; i < Kvadro_info_list.Count; i++)
            {
                if (Kvadro_info_list[i].Manufacturer == manufacturer & Kvadro_info_list[i].Model == model & Kvadro_info_list[i].Year_of_prod == year_of_prod)
                    flag += 1;
            }
            if (flag == 0 & year_of_prod > 1900 & price > 0 & power > 0 & year_of_prod < 2021)
            {
                Kvadro_info info = new Kvadro_info(manufacturer, model, year_of_prod, kol_vo, power, price);
                Kvadro_info_list.Add(info);
                OleDbConnection myConnection = new OleDbConnection(connectString);
                myConnection.Open();
                OleDbTransaction trans = myConnection.BeginTransaction();
                string sql1 = $"SELECT MAX(id) FROM kvadro_info";
                OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
                string x = cmd1.ExecuteScalar().ToString();
                int y = int.Parse(x) + 1;
                string sql2 = $"INSERT INTO kvadro_info VALUES ({y}, '{manufacturer}', '{model}', '{year_of_prod}', '{kol_vo}', '{power}', '{price}')";
                OleDbCommand cmd2 = new OleDbCommand(sql2, myConnection, trans);
                cmd2.ExecuteNonQuery();
                trans.Commit();
                myConnection.Close();
                return "успешно";
            }
            return "неуспешно";
        }
        //функция для удаления информации из базы данных квадрокоптеров.
        public static string Delete_info(string manufacturer, string model, int year_of_prod)
        {
            for (int i = 0; i < Kvadro_info_list.Count; i++)
            {
                if (Kvadro_info_list[i].Manufacturer == manufacturer & Kvadro_info_list[i].Model == model & Kvadro_info_list[i].Year_of_prod == year_of_prod)
                {
                    Kvadro_info_list.Remove(Kvadro_info_list[i]);
                    OleDbConnection myConnection = new OleDbConnection(connectString);
                    myConnection.Open();
                    OleDbTransaction trans = myConnection.BeginTransaction();
                    string sql2 = $"DELETE FROM kvadro_info WHERE manufacturer = '{manufacturer}' and model = '{model}' and year_of_prod = '{year_of_prod}'";
                    OleDbCommand cmd2 = new OleDbCommand(sql2, myConnection, trans);
                    cmd2.ExecuteNonQuery();
                    trans.Commit();
                    myConnection.Close();
                    return "успешно";
                }
            }
            return "неуспешно";
        }
        //Функция для изменения строки/записи в базе данных квадрокоптеров.
        public static string Change_info(string manufacturer, string model, int year_of_prod = 0, int kol_vo = 0, int power = 0, int price = 0)
        {
            int flag = 0;
            if (year_of_prod > 1900 & year_of_prod < 2021 & kol_vo > 0 & power > 0 & price > 0 )
            {
                flag += 1;
                OleDbConnection myConnection = new OleDbConnection(connectString);
                myConnection.Open();
                OleDbTransaction trans = myConnection.BeginTransaction();
                string sql1 = $"UPDATE kvadro_info SET year_of_prod = '{year_of_prod}' where manufacturer = '{manufacturer}' and model = '{model}'";
                OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
                cmd1.ExecuteScalar();
                trans.Commit();
                myConnection.Close();
            }
            if (year_of_prod > 1900 & year_of_prod < 2021 & kol_vo >= 0)
            {
                flag += 1;
                OleDbConnection myConnection = new OleDbConnection(connectString);
                myConnection.Open();
                OleDbTransaction trans = myConnection.BeginTransaction();
                string sql1 = $"UPDATE kvadro_info SET kol_vo = '{kol_vo}' where manufacturer = '{manufacturer}' and model = '{model}'";
                OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
                cmd1.ExecuteScalar();
                trans.Commit();
                myConnection.Close();
            }
            if (year_of_prod > 1900 & year_of_prod < 2021 & power > 0)
            {
                flag += 1;
                OleDbConnection myConnection = new OleDbConnection(connectString);
                myConnection.Open();
                OleDbTransaction trans = myConnection.BeginTransaction();
                string sql1 = $"UPDATE kvadro_info SET power = '{power}' where manufacturer = '{manufacturer}' and model = '{model}'";
                OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
                cmd1.ExecuteScalar();
                trans.Commit();
                myConnection.Close();
            }
            if (year_of_prod > 1900 & year_of_prod < 2021 & price > 0)
            {
                flag += 1;
                OleDbConnection myConnection = new OleDbConnection(connectString);
                myConnection.Open();
                OleDbTransaction trans = myConnection.BeginTransaction();
                string sql1 = $"UPDATE kvadro_info SET price = '{price}' where manufacturer = '{manufacturer}' and model = '{model}'";
                OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
                cmd1.ExecuteScalar();
                trans.Commit();
                myConnection.Close();
            }
            if (flag > 0)
                return "успешно";
            else return "неуспешно";
        }
    }
}