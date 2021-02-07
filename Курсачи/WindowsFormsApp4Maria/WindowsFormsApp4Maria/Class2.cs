using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsApp4Maria
{
    // Класс, объекты которого- участники олимпиад, нужен для дополнения информации об участниках олимпиад.
    class Member_info
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Region { get; set; }
        public string School { get; set; }
        public int The_сlass { get; set; }
        public int Passport { get; set; }
        public int Phone { get; set; }

        // Список, который хранит в себе объекты класса.
        public static List<Member_info> Members_info_lst = new List<Member_info>();
        // Подключение к нашей базе данных, с которой работаем и динамически изменяем в программе.
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=olimp.mdb;";
        public Member_info(string first_name, string last_name, string region, string school, int the_class, int passport, int phone)
        {
            First_name = first_name;
            Last_name = last_name;
            Region = region;
            School = school;
            The_сlass = the_class;
            Passport = passport;
            Phone = phone;
        }
        // Функция для добавления нового участника олимпиады и информации о нем в нашу базу данных и таблицу Datagtridview.
        public static string Add_member_info_into_db(string first_name, string last_name, string region, string school, int the_class, int passport, int phone)
        {
            int counter = 0;
            for (int i = 0; i < Members_info_lst.Count; i++)
            {
                if ((Members_info_lst[i].First_name == first_name & Members_info_lst[i].Last_name == last_name & Members_info_lst[i].The_сlass == the_class & Members_info_lst[i].School == school) || Members_info_lst[i].Passport == passport)
                    counter = counter + 1;
            }
            if (counter == 0 & first_name != "" & last_name != "" & region != "" & school != "" & the_class > 0 & the_class < 12 & phone >= 0)
            {
                Member_info mem = new Member_info(first_name, last_name, region, school, the_class, passport, phone);
                Members_info_lst.Add(mem);
                OleDbConnection conn = new OleDbConnection(connectString);
                conn.Open();
                OleDbTransaction zapis = conn.BeginTransaction();
                string sql_number1 = $"SELECT MAX(id) FROM mem_info";
                OleDbCommand command_number_1 = new OleDbCommand(sql_number1, conn, zapis);
                string str = command_number_1.ExecuteScalar().ToString();
                int integer = int.Parse(str) + 1;
                string sql_number2 = $"INSERT INTO mem_info VALUES ({integer}, '{ first_name}', '{last_name}', '{region}', '{school}', {the_class}, '{passport}', '{phone}')";
                OleDbCommand command_number_2 = new OleDbCommand(sql_number2, conn, zapis);
                command_number_2.ExecuteNonQuery();
                zapis.Commit();
                conn.Close();
                return "выполнил";
            }
            return "не выполнил";
        }
        // Функция, которая считывает всю информацию из базы данных для последующего отображения в программе и работы с этими данными.
        public static void Download_info_about_members_info_into_list()
        {
            Members_info_lst.Clear();
            string zapros = "SELECT * FROM mem_info";
            OleDbConnection conn = new OleDbConnection(connectString);
            conn.Open();
            OleDbCommand command = new OleDbCommand(zapros, conn);
            OleDbDataReader output = command.ExecuteReader();
            while (output.Read())
            {
                Member_info mem = new Member_info(output[1].ToString(), output[2].ToString(), output[3].ToString(), output[4].ToString(), int.Parse(output[5].ToString()), int.Parse(output[6].ToString()), int.Parse(output[7].ToString()));
                Members_info_lst.Add(mem);
            }
            output.Close();
            conn.Close();
        }
        // Функция для изменения записи в таблице базы данных, а так же в таблице datagridview программы.
        public static string Change_zapis_about_member(string first_name, string last_name, string region, string school, int the_class, int passport, int phone)
        {
            int counter = 0;
            OleDbConnection conn = new OleDbConnection(connectString);
            conn.Open();
            for (int i = 0; i < Members_info_lst.Count; i++)
            {
                if (Members_info_lst[i].First_name == first_name & Members_info_lst[i].Last_name == last_name & Members_info_lst[i].Passport == passport)
                {

                    if (Members_info_lst[i].Phone != phone & phone >= 0)
                    {
                        counter += 1;
                        OleDbTransaction zapis = conn.BeginTransaction();
                        // Для обращения к базе данных использую язык SQL, который мы прошли на курсе по СУБД. Далее к этому возвращаться не будем.
                        string sql_number1 = $"UPDATE mem_info SET phone = '{phone}' WHERE first_name = '{first_name}' and last_name = '{last_name}' and passport = {passport}";
                        OleDbCommand command1 = new OleDbCommand(sql_number1, conn, zapis);
                        command1.ExecuteScalar();
                        zapis.Commit();
                    }
                    if (Members_info_lst[i].Region != region & region != "")
                    {
                        counter += 1;
                        OleDbTransaction zapis = conn.BeginTransaction();
                        string sql_number1 = $"UPDATE mem_info SET region = '{region}' WHERE first_name = '{first_name}' and last_name = '{last_name}' and passport = {passport}";
                        OleDbCommand command1 = new OleDbCommand(sql_number1, conn, zapis);
                        command1.ExecuteScalar();
                        zapis.Commit();
                    }
                    if (Members_info_lst[i].School != school & school != "")
                    {
                        counter += 1;
                        OleDbTransaction zapis = conn.BeginTransaction();
                        string sql_number1 = $"UPDATE mem_info SET school = '{school}' WHERE first_name = '{first_name}' and last_name = '{last_name}' and passport = {passport}";
                        OleDbCommand command1 = new OleDbCommand(sql_number1, conn, zapis);
                        command1.ExecuteScalar();
                        zapis.Commit();
                    }
                    if (Members_info_lst[i].The_сlass != the_class & the_class > 0 & the_class < 12)
                    {
                        counter += 1;
                        OleDbTransaction zapis = conn.BeginTransaction();
                        string sql_number1 = $"UPDATE mem_info SET class = {the_class} WHERE first_name = '{first_name}' and last_name = '{last_name}' and passport = {passport}";
                        OleDbCommand command1 = new OleDbCommand(sql_number1, conn, zapis);
                        command1.ExecuteScalar();
                        zapis.Commit();
                    }
                }
            }
            if (counter > 0)
            {
                conn.Close();
                return "выполнил";
            }
            else
            {
                conn.Close();
                return "не выполнил";
            }
        }
        // Данная функция нужна для удаления уже существующего участника олимпиад из базы данных.
        public static string Delete_member_from_db(string first_name, string last_name, int passport)
        {
            int counter = 0;
            OleDbConnection conn = new OleDbConnection(connectString);
            conn.Open();
            for (int i = 0; i < Members_info_lst.Count; i++)
            {
                if (Members_info_lst[i].First_name == first_name & Members_info_lst[i].Last_name == last_name & Members_info_lst[i].Passport == passport)
                {
                    counter += 1;
                    OleDbTransaction zapis = conn.BeginTransaction();
                    string sql_number1 = $"DELETE FROM mem_info WHERE first_name = '{first_name}' and last_name = '{last_name}' and passport = {passport}";
                    OleDbCommand command1 = new OleDbCommand(sql_number1, conn, zapis);
                    command1.ExecuteScalar();
                    zapis.Commit();
                }
            }
            conn.Close();
            if (counter > 0)
                return "выполнил";
            else return "не выполнил";
        }
    }
}
