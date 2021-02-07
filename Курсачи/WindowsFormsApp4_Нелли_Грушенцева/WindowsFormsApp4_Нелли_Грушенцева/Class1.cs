using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp4_Нелли_Грушенцева
{
/*Класс всех возможных кредитов, предоставляемых нашим банком.*/
    class Kredit
    {
        public string Name { get; set; }
        public int Max_money { get; set; }
        public int Percent { get; set; }
        public int Max_mounth { get; set; }
        //Список, содержащий все объекты данного класса
        public static List<Kredit> Kredits = new List<Kredit>();
        //Подключение к базе данных, из которой программа берет данные для первоначальной загрузки.
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Bank.mdb;";
        public static OleDbConnection myConnection = new OleDbConnection(connectString);
        public Kredit(string name, int max_money, int percent, int max_mounth)
        {
            Name = name;
            Max_money = max_money;
            Percent = percent;
            Max_mounth = max_mounth;
        }
        public Kredit() { }
        // Функция для загрузки всех данных из базы данных в программу (в список).
        public static void Load_info()
        {
            // Воизбежание излишних трудностей и ошибок- полностью очищаю список и заново его перезаписываю, так как затраты по времени незначительные.
            Kredits.Clear();
            string query = "SELECT * FROM Kredits";
            myConnection.Open();
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader take_info = command.ExecuteReader();
            while (take_info.Read())
            {
                Kredit kred = new Kredit(take_info[1].ToString(), int.Parse(take_info[2].ToString()), int.Parse(take_info[3].ToString()), int.Parse(take_info[4].ToString()));
                Kredits.Add(kred);
            }
            take_info.Close();
            myConnection.Close();
        }
        //Функция для добавления информации в базу данных. Все изменения в базе данных автоматически сохраняются.
        //Вместо xml- сериализации использую access mdb.
        public static string Add_info(string name, int max_money, int percent, int max_mounth)
        {
            int flag = 0;
            for (int i = 0; i < Kredits.Count; i++)
            {
                if (Kredits[i].Name == name)
                    flag += 1;
            }
            if (flag == 0 & max_money > 0 & percent > 0 & max_mounth > 0 & max_money <= 99999999 & percent <= 30 & max_mounth <= 360)
            {
                Kredit kred = new Kredit(name, max_money, percent, max_mounth);
                Kredits.Add(kred);
                myConnection.Open();
                OleDbTransaction trans = myConnection.BeginTransaction();
                string sql1 = $"SELECT MAX(ID) FROM Kredits";
                OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
                string x = cmd1.ExecuteScalar().ToString();
                int y = int.Parse(x) + 1;
                string sql2 = $"INSERT INTO Kredits VALUES ({y}, '{name}', '{max_money}', '{percent}', '{max_mounth}')";
                OleDbCommand cmd2 = new OleDbCommand(sql2, myConnection, trans);
                cmd2.ExecuteNonQuery();
                trans.Commit();
                myConnection.Close();
                return "успешно";
            }
            return "неуспешно";
        }
        //Функция удаления информации/строки/записи из базы данных. Изменения так же автоматически сохраняются.
        public static string Delete_info(string name)
        {
            for (int i = 0; i < Kredits.Count; i++)
            {
                if (Kredits[i].Name == name)
                {
                    Kredits.Remove(Kredits[i]);
                    myConnection.Open();
                    OleDbTransaction trans = myConnection.BeginTransaction();
                    string sql2 = $"DELETE FROM Kredits WHERE name = '{name}'";
                    OleDbCommand cmd2 = new OleDbCommand(sql2, myConnection, trans);
                    cmd2.ExecuteNonQuery();
                    trans.Commit();
                    myConnection.Close();
                    return "успешно";
                }
            }
            return "неуспешно";
        }
/*Функция для изменения информации об объектах базы данных.*/
        public static string Change_info(string name, int max_money, int percent, int max_mounth)
        {
            for (int i = 0; i < Kredits.Count; i++)
            {
                if (Kredits[i].Name == name & max_money <= 99999999 & percent <= 30 & max_mounth <= 360 & max_money >= 0 & percent >= 0 & max_mounth >= 0)
                {
                    myConnection.Open();
                    OleDbTransaction trans = myConnection.BeginTransaction();
                    string sql1 = $"UPDATE Kredits SET Max_money = {max_money}, Max_mounth = {max_mounth}, Percents = {percent} where name = '{name}'";
                    OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
                    cmd1.ExecuteScalar();
                    trans.Commit();
                    myConnection.Close();
                    Load_info();
                    return "успешно";
                }
            }
            return "неуспешно";
        }
    }
/*Класс клиентов банка, хранящий в себе информацию о всех деталях оказанных услуг.*/
    class Client
    {
        public string F_name { get; set; }
        public string S_name { get; set; }
        public int Ser { get; set; }
        public int Num { get; set; }
        public string Data { get; set; }
        public int Money { get; set; }
        public string Type { get; set; }
        public int Months { get; set; }

        public static List<Client> Clients = new List<Client>();
        //Подключение к базе данных, из которой программа берет данные для первоначальной загрузки.
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Bank.mdb;";

        public static OleDbConnection myConnection = new OleDbConnection(connectString);
        
        public Client(string f_name, string s_name, int ser, int num, string data, int money, string type, int months)
        {
            F_name = f_name;
            S_name = s_name;
            Ser = ser;
            Num = num;
            Data = data;
            Money = money;
            Type = type;
            Months = months;
        }
        public Client() { }
        public static void Load_info()
        {
            // Воизбежание излишних трудностей и ошибок- полностью очищаю список и заново его перезаписываю, так как затраты по времени незначительные.
            Clients.Clear();
            string query = "SELECT * FROM Clients";
            myConnection.Open();
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader take_info = command.ExecuteReader();
            while (take_info.Read())
            {
                Client cl = new Client(take_info[1].ToString(), take_info[2].ToString(), int.Parse(take_info[3].ToString()), int.Parse(take_info[4].ToString()), take_info[5].ToString(), int.Parse(take_info[6].ToString()), take_info[7].ToString(), int.Parse(take_info[8].ToString()));
                Clients.Add(cl);
            }
            take_info.Close();
            myConnection.Close();
        }
        //Функция для добавления информации в базу данных. Все изменения в базе данных автоматически сохраняются.
        //Вместо xml- сериализации использую access mdb.
        public static string Add_info(string f_name, string s_name, int ser, int num, string data, int money, string type, int months)
        {
            int flag = 0;
            int flag_1 = 0;
            for (int i = 0; i < Clients.Count; i++)
            {
                if (Clients[i].S_name == s_name & Clients[i].F_name == f_name)
                    flag += 1;
            }
            for (int i = 0; i < Kredit.Kredits.Count(); i++)
            {
                if (Kredit.Kredits[i].Name == type)
                    flag_1 += 1;
            }

            if (flag == 0 & flag_1 != 0 & f_name != "" & s_name != "" & ser > 0 & ser <= 9999 & num <= 999999 & money > 0 & money < 99999999 & type != "" & months > 0 & months <= 360)
            {
                Client client = new Client(f_name, s_name, ser, num, data, money, type, months);
                Clients.Add(client);
                myConnection.Open();
                OleDbTransaction trans = myConnection.BeginTransaction();
                string sql1 = $"SELECT MAX(ID) FROM Clients";
                OleDbCommand cmd1 = new OleDbCommand(sql1, myConnection, trans);
                string x = cmd1.ExecuteScalar().ToString();
                int y = int.Parse(x) + 1;
                string sql2 = $"INSERT INTO Clients VALUES ({y}, '{f_name}', '{s_name}', '{ser}', '{num}', '{data}', '{money}', '{type}', '{months}')";
                OleDbCommand cmd2 = new OleDbCommand(sql2, myConnection, trans);
                cmd2.ExecuteNonQuery();
                trans.Commit();
                myConnection.Close();
                return "успешно";
            }
            return "неуспешно";
        }
        public static string Delete_info(string f_name, string s_name)
        {
            for (int i = 0; i < Clients.Count; i++)
            {
                if (Clients[i].F_name == f_name & Clients[i].S_name == s_name)
                {
                    Clients.Remove(Clients[i]);
                    myConnection.Open();
                    OleDbTransaction trans = myConnection.BeginTransaction();
                    string sql2 = $"DELETE FROM Clients WHERE F_name = '{f_name}' and S_name = '{s_name}' ";
                    OleDbCommand cmd2 = new OleDbCommand(sql2, myConnection, trans);
                    cmd2.ExecuteNonQuery();
                    trans.Commit();
                    myConnection.Close();
                    return "успешно";
                }
            }
            return "неуспешно";
        }
    }
}
