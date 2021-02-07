using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    class Registration /*Класс для регистрации нового пользователя*/
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }

        public static List<Registration> Registration_list = new List<Registration>(); /*Список со всеми пользователями*/
        public Registration(string _name, string _password, string _status)
        {
            Name = _name;
            Password = _password;
            Status = _status;
        }
        public Registration() { }
        public static void Read_users_from_file() /*Функция читает файл с пользователями и добавляет их в список*/
        {
            int flag = 0;
            string[] arStr = File.ReadAllLines("users.txt", Encoding.UTF8);
            for (int i = 0; i < arStr.Length; i++)
            {
                string Name = arStr[i].Split(' ')[0];
                string Password = arStr[i].Split(' ')[1];
                string Status = arStr[i].Split(' ')[2];
                for (int j = 0; j < Registration_list.Count; j++)
                {
                    if (Registration_list[j].Name == Name & Registration_list[j].Password == Password & Registration_list[j].Status == Status)
                    {
                        flag += 1;
                    }
                }
                if (flag == 0)
                {
                    Registration person = new Registration(Name, Password, Status);
                    Registration_list.Add(person);
                }
            }
        }
        public static void Write_user_to_file() /*Записывает пользователя в файл со всеми пользователями*/
        {
            StreamWriter writer = new StreamWriter("users.txt", false, Encoding.UTF8);
            for (int k = 0; k < Registration_list.Count; k++)
            {
                if (k > 0)
                    writer.Write('\n' + Registration_list[k].Name + ' ' + Registration_list[k].Password + ' ' + Registration_list[k].Status);
                else
                    writer.Write(Registration_list[k].Name + ' ' + Registration_list[k].Password + ' ' + Registration_list[k].Status);
            }
            writer.Close();
        }

        public static string Enter(string name, string password, string status) /*Функиця для входа в систему, проверяет логин, пароль, статус 
                                                                                  аккаунта и пропускает в систему*/
        {
            int flag = 0;
            for (int i = 0; i < Registration_list.Count; i++)
            {
                if (Registration_list[i].Name == name & Registration_list[i].Password == password)
                {
                    flag += 1;
                }
            }
            if (flag != 0)
            {
                if (status == "user")
                    return "user";
                else return "admin";
            }
            else return "not_in_list";
        }
        public static string Register(string name, string password, string status = "user") /*Функция для регистрации нового пользователя из 
                                                                                              меню с регистрацией, по умолчанию статус - user*/
        {
            Read_users_from_file();
            int flag = 0;
            for (int i = 0; i < Registration_list.Count; i++)
            {
                if (Registration_list[i].Name == name & Registration_list[i].Name == password)
                {
                    flag += 1;
                }
            }
            if (flag == 0)
            {
                Registration person = new Registration(name, password, status);
                Registration_list.Add(person);
                Write_user_to_file();
                return "added_to_list";
            }
            else return "already_in_list";
                
        }
        public static string Login(string name, string password) /*Вход в систему, если введенные вами данные уже есть в списке*/
        {
            Read_users_from_file();
            int flag = 0;
            string status = "";
            for (int i = 0; i < Registration_list.Count; i++)
            {
                if (Registration_list[i].Name == name & Registration_list[i].Password == password)
                {
                    status = Registration_list[i].Status;
                    flag += 1;
                }
            }
            if (flag != 0)
                return Enter(name, password, status);
            else
                return "not_in_list";
        }
    }
        class Printer_info /*Класс информации о принтерах. Ранее, на зачете был родительским.*/
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Info { get; set; }

        public static List<Printer_info> Printer_info_list = new List<Printer_info>(); /*Список принтеров и информации о них*/
        public Printer_info(string _name, string _model, string _info)
        {
            Name = _name;
            Model = _model;
            Info = _info;
        }
        public Printer_info() { }
        /*Изменение информации о принтере в списке и в файле и их перезапись*/
        public static string Change_info_about_printer(string name, string model, string info)
        {
            for (int i = 0; i < Printer_info_list.Count; i++)
            {
                if (Printer_info_list[i].Name == name & Printer_info_list[i].Model == model)
                {
                    Printer_info_list[i].Info = info;
                    Write_info_to_file();
                    return "Успешно!";
                }
            }
            return ":(";
        }
        /*Прочтение информации о принтерах из файла и заполнение ею списка*/
        public static void Read_info_from_file(string filename) /*Считывает информацию о принтерах и добавляет в список для последующей работы*/
        {
            string[] arStr = File.ReadAllLines(filename);
            for (int i = 0; i < arStr.Length; i++)
            {
                string Name = arStr[i].Split(' ')[0];
                string Model = arStr[i].Split(' ')[1];
                string Info = arStr[i].Split(' ')[2];
                Printer_info printer_info = new Printer_info(Name, Model, Info);
                Printer_info_list.Add(printer_info);
            }
        }
        public static void Write_info_to_file() /*Записывает в файл информацию о принтерах*/
        {
            StreamWriter writer = new StreamWriter("printer_info.txt", false, Encoding.UTF8);
            for (int k = 0; k < Printer_info_list.Count; k++)
            {
                if (k>0)
                    writer.Write('\n' + Printer_info_list[k].Name + ' ' + Printer_info_list[k].Model + ' ' + Printer_info_list[k].Info);
                else
                    writer.Write(Printer_info_list[k].Name + ' ' + Printer_info_list[k].Model + ' ' + Printer_info_list[k].Info);
            }
            writer.Close();
        }
        public static void Add_info(string Name, string Model, string Info) /*Функция добавления информации о принтере*/
        {
            int flag = 0;
            for (int i = 0; i < Printer_info_list.Count; i++)
            {
                if (Printer_info_list[i].Name == Name & Printer_info_list[i].Model == Model)
                    flag += 1;
            }
            if (flag == 0)
            {
                Printer_info printer_info = new Printer_info(Name, Model, Info);
                Printer_info_list.Add(printer_info);
                Write_info_to_file();
            }
        }
    }
    class Printer /*Класс, по факту, самый главный в программе. Принтеры и практически вся работа с ними*/
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public double Rate { get; set; }
        public int Kol_vo { get; set; }

        public static List<Printer> Printer_list = new List<Printer>(); /*Список всех принтеров и их характеристик*/
        public Printer(string _name, string _model, string _type = "", double _price = 0, double _rate = 0, int _kol_vo = 0)
        {
            Name = _name;
            Model = _model;
            Type = _type;
            Price = _price;
            Rate = _rate;
            Kol_vo = _kol_vo;
        }
        /*Функция изменения статуса пользователя. Не знаю, почему здесь, по факту- должна быть в регистрации.*/
        public static string Change_status_of_user(string name, string password, string status, string new_status) 
        {
            Registration.Read_users_from_file();
            for (int i = 0; i < Registration.Registration_list.Count; i++)
            {
                if (Registration.Registration_list[i].Name == name & Registration.Registration_list[i].Password == password & Registration.Registration_list[i].Status == status)
                {
                    Registration.Registration_list[i].Status = new_status;
                    Printer.Write_log(Form3.name_for_log, "удалил пользователя", name, password, status);
                    Registration.Write_user_to_file();
                    return "Успешно";
                }
            }
            return "Неуспешно!";
        }
        /*Функция изменения данных в списке товаров*/
        public static string Change_price_list_items(string name, string model, string type = "", double price = 0, double rate = 0, int kol_vo = 0)
        {
            for (int i = 0; i < Printer_list.Count; i++)
            {
                if (Printer_list[i].Name == name & Printer_list[i].Model == model)
                {
                    int flag = 0;
                    if (type != "" & type.Split().Length == 1)
                    {
                        Printer_list[i].Type = type;
                        flag += 1;
                    }
                        
                    if (price != 0 & price >= 0 & price <= 10000000)
                    {
                        Printer_list[i].Price = price;
                        flag += 1;
                    }
                    if (rate != 0 & rate >= 0 & rate <= 10)
                    {
                        flag += 1;
                        Printer_list[i].Rate = rate;
                    }
                    if (kol_vo != 0 & kol_vo >= 0)
                    {
                        flag += 1;
                        Printer_list[i].Kol_vo = kol_vo;
                    }
                    if (flag != 0)
                    {
                        StreamWriter writer = new StreamWriter("price_list.txt", false, Encoding.UTF8);
                        for (int k = 0; k < Printer_list.Count; k++)
                        {
                            writer.Write(Printer_list[k].Name + ' ' + Printer_list[k].Model + ' ' + Printer_list[k].Type + ' ' + Printer_list[k].Price + ' ' + Printer_list[k].Rate + ' ' + Printer_list[k].Kol_vo + '\n');
                        }
                        writer.Close();
                        Write_log(Form3.name_for_log, "изменил информацию о принтере", name, model);
                        return "Успешно!";
                    }
                    else return "Нечего изменять!";
                }
            }
            return "Неуспешно!";
        }
        /*Функция для удаления принтера из списка товаров, если он есть в списке*/
        public static string Delete_printer_from_price_list(string name, string model)
        {
            for (int i = 0; i < Printer_list.Count; i++)
            {
                if (Printer_list[i].Name == name & Printer_list[i].Model == model)
                {
                    Printer_list.Remove(Printer_list[i]);
                    StreamWriter writer = new StreamWriter("price_list.txt", false, Encoding.UTF8);
                    for (int k = 0; k < Printer_list.Count; k++)
                    {
                        writer.Write(Printer_list[k].Name + ' ' + Printer_list[k].Model + ' ' + Printer_list[k].Type + ' ' + Printer_list[k].Price + ' ' + Printer_list[k].Rate + ' ' + Printer_list[k].Kol_vo + '\n');
                    }
                    writer.Close();
                    Write_log(Form3.name_for_log, "удалил принтер", name, model);
                    return "Успешно!";
                }
            }
            return "Неуспешно!";
        }
        /*Функция удаления пользователя, если он есть в списке*/
        public static string Delete_user(string name, string password, string status)
        {
            Registration.Read_users_from_file();
            for (int i = 0; i < Registration.Registration_list.Count; i++)
            {
                if (Registration.Registration_list[i].Name == name & Registration.Registration_list[i].Password == password & Registration.Registration_list[i].Status == status)
                {
                    Registration.Registration_list.Remove(Registration.Registration_list[i]);
                    Printer.Write_log(Form3.name_for_log, "удалил пользователя", name, password, status);
                    Registration.Write_user_to_file();
                    return "Успешно";
                }              
            }
            return "Неуспешно!";
        }
        /*Функция добавления нового пользателя, если его нет в списке*/
        public static string Add_user(string name, string password, string status)
        {
            Registration.Read_users_from_file();
            int flag = 0;
            for (int i = 0; i<Registration.Registration_list.Count; i++)
            {
                if (Registration.Registration_list[i].Name == name)
                {
                    flag += 1;
                }
            }
            if (flag == 0)
            {
                string answer = Registration.Register(name, password, status);
                if (answer == "added_to_list")
                {
                    Printer.Write_log(Form3.name_for_log, "добавил нового пользователя", name, password, status);
                    return "added_to_list";
                }
                else return "already_in_list";
            }
            else return "already_in_list";
        }
        /*Функция для отката всех данных из файла, который никак и никогда не задействуется в других функциях*/
        public static void Reload()
        {
            Printer.Write_log(Form3.name_for_log, "Откатил все данные программы");
            Printer_list.Clear();
            Printer_info.Printer_info_list.Clear();
            Read_file_with_printers("reload.txt");
            StreamWriter writer = new StreamWriter("price_list.txt", false, Encoding.UTF8);
            for (int k = 0; k < Printer_list.Count; k++)
            {
                writer.Write(Printer_list[k].Name + ' ' + Printer_list[k].Model + ' ' + Printer_list[k].Type + ' ' + Printer_list[k].Price + ' ' + Printer_list[k].Rate + ' ' + Printer_list[k].Kol_vo + '\n');
            }
            writer.Close();
            StreamWriter writer1 = new StreamWriter("check_list.txt", false, Encoding.UTF8);
            writer1.Write("");
            writer1.Close();
            StreamWriter writer2 = new StreamWriter("stat_kol_vo.txt", false, Encoding.UTF8);
            writer2.Write("");
            writer2.Close();
            StreamWriter writer3 = new StreamWriter("stat_price.txt", false, Encoding.UTF8);
            writer3.Write("");
            writer3.Close();
            Printer_list.Clear();
            Printer_info.Read_info_from_file("reload_info.txt");
            StreamWriter writer4 = new StreamWriter("printer_info.txt", false, Encoding.UTF8);
            for (int k = 0; k < Printer_info.Printer_info_list.Count; k++)
            {
                writer4.Write(Printer_info.Printer_info_list[k].Name + ' ' + Printer_info.Printer_info_list[k].Model + ' ' + Printer_info.Printer_info_list[k].Info + '\n');
            }
            writer4.Close();
        }
        /*Функция для прочтения файла с информацией о принтерах и заполнения ей списка*/
        public static void Read_file_with_printers(string filename)
        {
            int flag = 0;
            string[] arStr = File.ReadAllLines(filename);
            for (int i = 0; i<arStr.Length; i++)
            {
                string Name = arStr[i].Split(' ')[0];
                string Model = arStr[i].Split(' ')[1];
                string Type = arStr[i].Split(' ')[2];
                double Price = double.Parse(arStr[i].Split(' ')[3]);
                double Rate = double.Parse(arStr[i].Split(' ')[4]);
                int Kol_vo = int.Parse(arStr[i].Split(' ')[5]);
                for (int j = 0; j < Printer_list.Count; j++)
                {
                    if (Printer_list[j].Name == Name & Printer_list[j].Model == Model)
                    {
                        flag += 1;   
                    }
                }
                if (flag == 0)
                {
                    Printer printer = new Printer(Name, Model, Type, Price, Rate, Kol_vo);
                    Printer_list.Add(printer);
                }
            }
        }

        /*Функция для добавления в список принтера, если его нет либо для добавления количества принтеров, если уже есть в списке*/
        public static void Add_Printer(string Name, string Model, string Type, double Price, double Rate, int Kol_vo)
        {

            int flag = 0;
             /*Добавление количества, когда принтер уже есть в списке*/
            for (int i = 0; i < Printer_list.Count; i++)
            {
                if (Printer_list[i].Name == Name & Printer_list[i].Model == Model)
                {
                    Printer_list[i].Kol_vo += Kol_vo;
                    Write_log(Form3.name_for_log, "добавил принтеры на склад", Name, Model, Kol_vo.ToString());
                    flag += 1;
                    StreamWriter writer = new StreamWriter("price_list.txt", false, Encoding.UTF8);
                    for (int k = 0; k < Printer_list.Count; k++)
                    {
                        writer.Write(Printer_list[k].Name + ' ' + Printer_list[k].Model + ' ' + Printer_list[k].Type + ' ' + Printer_list[k].Price + ' ' + Printer_list[k].Rate + ' ' + Printer_list[k].Kol_vo + '\n');
                    }
                    writer.Close();
                }
            }
            /*Добавление нового принтера*/
            if (flag == 0 & Type != " " & Price != 0 & Rate != 0)
            {
                Printer printer = new Printer(Name, Model, Type, Price, Rate, Kol_vo);
                Printer_list.Add(printer);
                Write_log(Form3.name_for_log, "добавил принтеры на склад", Name, Model, Kol_vo.ToString());
                StreamWriter writer_lite = new StreamWriter("price_list.txt", true, Encoding.UTF8);
                writer_lite.Write(Name + ' ' + Model + ' ' + Type + ' ' + Price + ' ' + Rate + ' ' + Kol_vo + '\n');
                writer_lite.Close();
            }
        }
        /*Запись логов для каждого пользователя в отдельности общего для всех*/
        public static void Write_log(string username, string phrase, string name = "", string model = "", string kol_vo = "")
        {
            if (name != "" & model != "" & kol_vo != "")
            {
                StreamWriter writer = new StreamWriter(username + "_log.txt", true, Encoding.UTF8);
                writer.WriteLine("{0} {1} {2} {3} {4} {5}", DateTime.Now, username, phrase, name, model, kol_vo);
                writer.Close();
                StreamWriter writer1 = new StreamWriter("big_log.txt", true, Encoding.UTF8);
                writer1.WriteLine("{0} {1} {2} {3} {4} {5}", DateTime.Now, username, phrase, name, model, kol_vo);
                writer1.Close();
            }
            else
            {
                StreamWriter writer = new StreamWriter(username + "_log.txt", true, Encoding.UTF8);
                writer.WriteLine("{0} {1} {2}", DateTime.Now, username, phrase);
                writer.Close();
                StreamWriter writer1 = new StreamWriter("big_log.txt", true, Encoding.UTF8);
                writer1.WriteLine("{0} {1} {2}", DateTime.Now, username, phrase);
                writer1.Close();
            }
        }
        /*Чтение данных из файла и возвращение их из функции*/
        public static string Read_from_File(string filename)
        {
            if (filename != "users.txt")
            {
                string text = "";
                StreamReader reader = new StreamReader(filename);
                string[] arStr = File.ReadAllLines(filename);
                for (int i = 0; i < arStr.Length; i++)
                {
                    text = text + arStr[i] + "\n";
                }
                reader.Close();
                return text;
            }
            else return "Не получится, шалунишка!";
        }
        /*Функция записи недостающих товаров в специальный файл для их хранения*/
        public static void Check_list(string Name, string Model, int Kol_vo, double Price)
        {
            StreamWriter writer = new StreamWriter("check_list.txt", true, Encoding.UTF8);
            writer.WriteLine("{0} {1} {2} {3}", Name, Model, Kol_vo, Price);
            writer.Close();
        }
        /*Функция продажи товара(принтера), если такой есть в списке. Реализованы все проверки, чтобы не крашился.*/
        public static string Sell_Printer(string Name, string Model, int Kol_vo, string Type = "", double Price = 0, double Rate = 0)
        {
            double total = 0;
            for (int i = 0; i < Printer_list.Count; i++)
            {
                if (Printer_list[i].Name == Name & Printer_list[i].Model == Model)
                {
                    if (Printer_list[i].Kol_vo >= Kol_vo)
                    {
                        total += Kol_vo * Printer_list[i].Price;
                        Printer_list[i].Kol_vo -= Kol_vo;
                        StreamWriter writer = new StreamWriter("price_list.txt", false, Encoding.UTF8);
                        for (int j = 0; j < Printer_list.Count; j++)
                        {
                            writer.Write(Printer_list[j].Name + ' ' + Printer_list[j].Model + ' ' + Printer_list[j].Type + ' ' + Printer_list[j].Price + ' ' + Printer_list[j].Rate + ' ' + Printer_list[j].Kol_vo + '\n');
                        }
                        writer.Close();
                        Write_log(Form3.name_for_log, "продал принтеров", Name, Model, total.ToString());
                        return string.Format("Продан/ы принтер/ы модели {0} на сумму {1}!", Name, total);
                    }
                    else
                    {
                        total += Printer_list[i].Kol_vo * Printer_list[i].Price;
                        double total_money_needs = (Kol_vo - Printer_list[i].Kol_vo) * Printer_list[i].Price;
                        Write_log(Form3.name_for_log, "продал принтеров", Name, Model, (Printer_list[i].Kol_vo).ToString());
                        string deficit = string.Format("Не хватает принтеров {0}, модели {3}, магазину нужно докупить ещё как минимум {1} на сумму {2}!", Name, Kol_vo - Printer_list[i].Kol_vo, total_money_needs, Printer_list[i].Model);
                        string sold = string.Format("В итоге принтеров фирмы: {1} , модели: {2} продано на сумму: {0}", total, Name, Printer_list[i].Model);
                        Check_list(Name, Printer_list[i].Model, Kol_vo - Printer_list[i].Kol_vo, total_money_needs);
                        Printer_list[i].Kol_vo = 0;
                        StreamWriter writer = new StreamWriter("price_list.txt", false, Encoding.UTF8);
                        for (int j = 0; j < Printer_list.Count; j++)
                        {
                            writer.Write(Printer_list[j].Name + ' ' + Printer_list[j].Model + ' ' + Printer_list[j].Type + ' ' + Printer_list[j].Price + ' ' + Printer_list[j].Rate + ' ' + Printer_list[j].Kol_vo + '\n');
                        }
                        writer.Close();
                        return (deficit + '\n' + sold);
                    }
                }
            }
            
         return string.Format("Нет принтера фирмы {0} модели {1}!", Name, Model);
        }
        /*Функция закупки всех недостающих принтеров из списка.*/
        public static void purchase()
        {
            StreamReader reader = new StreamReader("check_list.txt", Encoding.UTF8);
            string[] arStr1 = File.ReadAllLines("check_list.txt", Encoding.UTF8);
            reader.Close();
            for (int i = 0; i < arStr1.Length; i++)
            {
                string Name = arStr1[i].Split(' ')[0];
                string Model = arStr1[i].Split(' ')[1];
                int Kol_vo = int.Parse(arStr1[i].Split(' ')[2]);
                Add_Printer(Name, Model, " ", 0, 0, Kol_vo);
            }
            StreamWriter writer = new StreamWriter("check_list.txt", false, Encoding.UTF8);
            writer.Write("");
            writer.Close();
        }
        /*Функция для записи статистики по данным*/
        public static void statistics()
        {
            int max_kol_vo = 0;
            double max_price = 0;
            int k_p = 0;
            double tot_price = 0;
            int tot_kol_vo = 0;
            double mean = 0;
            for (int i = 0; i < Printer_list.Count; i++)
            {
                k_p += 1;
                tot_price += Printer_list[i].Price;
                tot_kol_vo += Printer_list[i].Kol_vo;
                if (max_price < Printer_list[i].Price)
                    max_price = Printer_list[i].Price;
                if (max_kol_vo < Printer_list[i].Kol_vo)
                    max_kol_vo = Printer_list[i].Kol_vo;
            }
            mean = tot_price / k_p;
            StreamWriter writer = new StreamWriter("stat_price.txt", true, Encoding.UTF8);
            writer.Write("Средняя цена за принтер: " + mean.ToString() + "\n" + "Всего принтеров на складе:" + tot_kol_vo.ToString() + "\n" +
                "На складе принтеров на сумму: " + tot_price.ToString() + "\n" + "Всего различных моделей принтеров: " + k_p.ToString() + "\n" +
                "Самый дорогой принтер стоит: " + max_price.ToString() + "\n" + "Наибольшее количество принтеров одной модели: " + max_kol_vo.ToString());
            for (int i = 0; i < Printer_list.Count; i++)
            {
                writer.Write("Цена принтера на момент времени " + " " + DateTime.Now + " " + Printer_list[i].Name + " " + Printer_list[i].Model + " " + Printer_list[i].Price + "\n");
            }
            writer.Close();
            StreamWriter writer1 = new StreamWriter("stat_kol_vo.txt", true, Encoding.UTF8);
            for (int i = 0; i < Printer_list.Count; i++)
            {
                writer1.Write("Количество принтеров на момент времени " + " " + DateTime.Now + " " + Printer_list[i].Name + " " + Printer_list[i].Model + " " + Printer_list[i].Kol_vo + "\n");
            }
            writer1.Close();
        }
        /*Функция для вывода статистики на экран*/
        public static string check_statistics()
        {
            int max_kol_vo = 0;
            double max_price = 0;
            int k_p = 0;
            double tot_price = 0;
            int tot_kol_vo = 0;
            double mean = 0;
            for (int i = 0; i < Printer_list.Count; i++)
            {
                k_p += 1;
                tot_price += Printer_list[i].Price;
                tot_kol_vo += Printer_list[i].Kol_vo;
                if (max_price < Printer_list[i].Price)
                    max_price = Printer_list[i].Price;
                if (max_kol_vo < Printer_list[i].Kol_vo)
                    max_kol_vo = Printer_list[i].Kol_vo;
            }
            mean = tot_price / k_p;
            return ("Средняя цена за принтер: " + mean.ToString() + "\n" + "Всего принтеров на складе:" + tot_kol_vo.ToString() + "\n" +
                "На складе принтеров на сумму: " + tot_price.ToString() + "\n" + "Всего различных моделей принтеров: " + k_p.ToString() + "\n" +
                "Самый дорогой принтер стоит: " + max_price.ToString() + "\n" + "Наибольшее количество принтеров одной модели: " + max_kol_vo.ToString()); 
        }
    }
}

