using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsApp4Maria
{
    // Класс, Объекты которого - участники олимпиад по различным предметам.
    class Member
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Subject { get; set; }
        public int The_сlass { get; set; }
        public int Score { get; set; }

        // Создание списка, в котором будут находиться объекты класса Member
        public static List<Member> Members_lst = new List<Member>();
        // Подклчение к нашей базе данных для последующего использования в качестве источника и хранилища данных программы.
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=olimp.mdb;";
        public Member(string first_name, string last_name, string subject, int the_class, int score)
        {
            First_name = first_name;
            Last_name = last_name;
            Subject = subject;
            The_сlass = the_class;
            Score = score;
        }
        // Функция, применяя которую мы можем добавить в нашу вышуепомянутую базу данных новый объекст (запись,строку)
        public static string Add_member_into_db(string first_name, string last_name, string subject, int the_class, int score)
        {
            int counter = 0;
            for (int i = 0; i < Members_lst.Count; i++)
            {
                if (Members_lst[i].First_name ==  first_name & Members_lst[i].Last_name == last_name & Members_lst[i].Subject == subject)
                    counter = counter + 1;
            }
            if (counter == 0 & first_name != "" & last_name != "" & the_class > 0 & the_class < 12 & score >= 0 & score <= 100)
            {
                Member mem = new Member(first_name, last_name, subject, the_class, score);
                Members_lst.Add(mem);
                OleDbConnection conn = new OleDbConnection(connectString);
                conn.Open();
                OleDbTransaction zapis = conn.BeginTransaction();
                // Для обращения к базе данных использую язык SQL, который мы прошли на курсе по СУБД. Далее к этому возвращаться не будем.
                string sql_number1 = $"SELECT MAX(id) FROM members";
                OleDbCommand command_number_1 = new OleDbCommand(sql_number1, conn, zapis);
                string str = command_number_1.ExecuteScalar().ToString();
                int integer = int.Parse(str) + 1;
                string sql_number2 = $"INSERT INTO members VALUES ({integer}, '{ first_name}', '{last_name}', '{subject}', '{the_class}', '{score}')";
                OleDbCommand command_number_2 = new OleDbCommand(sql_number2, conn, zapis);
                command_number_2.ExecuteNonQuery();
                zapis.Commit();
                conn.Close();
                return "выполнил";
            }
            return "не выполнил";
        }
        // Функция, изпользуя которую мы можем загрузить в нашу программу все данные из вышеупомянутой базы данных.
        public static void Download_info_about_members_into_list()
        {
            Members_lst.Clear();
            string zapros = "SELECT * FROM members";
            OleDbConnection conn = new OleDbConnection(connectString);
            conn.Open();
            OleDbCommand command = new OleDbCommand(zapros, conn);
            OleDbDataReader output = command.ExecuteReader();
            while (output.Read())
            {
                Member mem = new Member(output[1].ToString(), output[2].ToString(), output[3].ToString(), int.Parse(output[4].ToString()), int.Parse(output[5].ToString()));
                Members_lst.Add(mem);
            }
            output.Close();
            conn.Close();
        }
        // Функция, необходимая для обновления записей (строк) в нашей базе данных, а так же в datagridview
        public static string Change_zapis_about_member(string first_name, string last_name, string subject, int the_class, int score)
        {
            int counter = 0;
            OleDbConnection conn = new OleDbConnection(connectString);
            conn.Open();
            for (int i = 0; i < Members_lst.Count; i++)
            {
                if (Members_lst[i].First_name == first_name & Members_lst[i].Last_name == last_name)
                {
                    if (Members_lst[i].Subject != subject & subject != "")
                    {
                        counter += 1;
                        OleDbTransaction zapis = conn.BeginTransaction();
                        string sql_number1 = $"UPDATE members SET subject = '{subject}' where first_name = '{first_name}' and last_name = '{last_name}'";
                        OleDbCommand command1 = new OleDbCommand(sql_number1, conn, zapis);
                        command1.ExecuteScalar();
                        zapis.Commit();
                    }
                    if (Members_lst[i].The_сlass != the_class & the_class > 0 & the_class < 12)
                    {
                        counter += 1;
                        OleDbTransaction zapis = conn.BeginTransaction();
                        string sql_number1 = $"UPDATE members SET class = '{the_class}' where first_name = '{first_name}' and last_name = '{last_name}'";
                        OleDbCommand command1 = new OleDbCommand(sql_number1, conn, zapis);
                        command1.ExecuteScalar();
                        zapis.Commit();
                    }
                    if (score >= 0 & score <= 100 & Members_lst[i].Score != score)
                    {
                        counter += 1;
                        OleDbTransaction zapis = conn.BeginTransaction();
                        string sql_number1 = $"UPDATE members SET score = '{score}' where first_name = '{first_name}' and last_name = '{last_name}'";
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
        // И последняя функция в данном классе- удаление данных из нашей базы данных, а так же и таблицы datagridview.
        public static string Delete_member_from_db(string first_name, string last_name, string subject)
        {
            int counter = 0;
            OleDbConnection conn = new OleDbConnection(connectString);
            conn.Open();
            for (int i = 0; i < Members_lst.Count; i++)
            {
                if (Members_lst[i].First_name == first_name & Members_lst[i].Last_name == last_name)
                {
                    counter = counter + 1;
                    OleDbTransaction zapis = conn.BeginTransaction();
                    string sql_number1 = $"DELETE FROM members WHERE first_name = '{first_name}' and last_name = '{last_name}' and subject = '{subject}'";
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

