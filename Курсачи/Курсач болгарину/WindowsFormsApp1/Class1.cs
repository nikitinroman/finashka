using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class Users /*Класс, нужный для регистрации на 3 форме*/
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }

        public static List<Users> accounts_list = new List<Users>();
        public Users(string _Login, string _password, string _status)
        {
            Login = _Login;
            Password = _password;
            Status = _status;
        }
        public Users() { }
        /*Прочтение тхт-файла с пользователями и внесение их в список пользователей*/
        public static void From_txt_to_accounts_list()
        {
            int marker = 0;
            string[] arStr = File.ReadAllLines("accounts.txt", Encoding.UTF8);
            for (int i = 0; i < arStr.Length; i++)
            {
                string Login = arStr[i].Split(' ')[0];
                string Password = arStr[i].Split(' ')[1];
                string Status = arStr[i].Split(' ')[2];
                for (int j = 0; j < accounts_list.Count; j++)
                {
                    if (accounts_list[j].Login == Login & accounts_list[j].Password == Password & accounts_list[j].Status == Status)
                    {
                        marker += 1;
                    }
                }
                if (marker == 0)
                {
                    Users human = new Users(Login, Password, Status);
                    accounts_list.Add(human);
                }
            }
        }
        /*Запись всех пользователей в файл*/
        public static void Write_User_list_to_txt()
        {
            StreamWriter writer = new StreamWriter("accounts.txt", false, Encoding.UTF8);
            for (int k = 0; k < accounts_list.Count; k++)
            {
                if (k > 0)
                    writer.Write('\n' + accounts_list[k].Login + ' ' + accounts_list[k].Password + ' ' + accounts_list[k].Status);
                else
                    writer.Write(accounts_list[k].Login + ' ' + accounts_list[k].Password + ' ' + accounts_list[k].Status);
            }
            writer.Close();
        }
        /*Функция, реализующая вход в аккаунт*/
        public static string Enter(string Login, string password, string status)
        {
            int marker = 0;
            for (int i = 0; i < accounts_list.Count; i++)
            {
                if (accounts_list[i].Login == Login & accounts_list[i].Password == password)
                {
                    marker += 1;
                }
            }
            if (marker != 0)
            {
                if (status == "user")
                    return "user";
                else return "admin";
            }
            else return "нет в списке";
        }
        /*Функция для регистрации нового пользователя*/
        public static string Register(string Login, string password, string status = "user")
        {
            From_txt_to_accounts_list();
            int marker = 0;
            for (int i = 0; i < accounts_list.Count; i++)
            {
                if (accounts_list[i].Login == Login & accounts_list[i].Login == password)
                {
                    marker += 1;
                }
            }
            if (marker == 0)
            {
                Users human = new Users(Login, password, status);
                accounts_list.Add(human);
                Write_User_list_to_txt();
                return "добавлено в список";
            }
            else return "уже есть в списке";
                
        }
        /*Функция, участвующая в проверках для входа в аккаунт*/
        public static string Log_in(string Login, string password)
        {
            From_txt_to_accounts_list();
            int marker = 0;
            string status = "";
            for (int i = 0; i < accounts_list.Count; i++)
            {
                if (accounts_list[i].Login == Login & accounts_list[i].Password == password)
                {
                    status = accounts_list[i].Status;
                    marker += 1;
                }
            }
            if (marker != 0)
                return Enter(Login, password, status);
            else
                return "нет в списке";
        }
    }
        /*Класс информации о товарах в магазине*/
        class Tech_information
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Info { get; set; }

        public static List<Tech_information> Tech_information_list = new List<Tech_information>();
        public Tech_information(string _Brand, string _model, string _info)
        {
            Brand = _Brand;
            Model = _model;
            Info = _info;
        }
        public Tech_information() { }
        /*Функция для измененеия информации о товаре*/
        public static string Change_information(string brand, string model, string info)
        {
            for (int i = 0; i < Tech_information_list.Count; i++)
            {
                if (Tech_information_list[i].Brand == brand & Tech_information_list[i].Model == model)
                {
                    Tech_information_list[i].Info = info;
                    Write_information_to_txt();
                    return "Успешно!";
                }
            }
            return "Не успешно!";
        }
        /*Функция для прочтения информации из файла и записи в список товаров*/
        public static void Read_info_from_file()
        {
            string[] arStr = File.ReadAllLines("Tech_information.txt", Encoding.UTF8);
            for (int i = 0; i < arStr.Length; i++)
            {
                string Brand = arStr[i].Split(' ')[0];
                string Model = arStr[i].Split(' ')[1];
                string Info = arStr[i].Split(' ')[2];
                Tech_information Tech_information = new Tech_information(Brand, Model, Info);
                Tech_information_list.Add(Tech_information);
            }
        }
        /*Функция для записи информации в файл*/
        public static void Write_information_to_txt()
        {
            StreamWriter writer = new StreamWriter("Tech_information.txt", false, Encoding.UTF8);
            for (int k = 0; k < Tech_information_list.Count; k++)
            {
                if (k>0)
                    writer.Write('\n' + Tech_information_list[k].Brand + ' ' + Tech_information_list[k].Model + ' ' + Tech_information_list[k].Info);
                else
                    writer.Write(Tech_information_list[k].Brand + ' ' + Tech_information_list[k].Model + ' ' + Tech_information_list[k].Info);
            }
            writer.Close();
        }
        /*Функция для добавления информации о товаре*/
        public static void Add_info(string Brand, string Model, string Info)
        {
            int marker = 0;
            for (int i = 0; i < Tech_information_list.Count; i++)
            {
                if (Tech_information_list[i].Brand == Brand & Tech_information_list[i].Model == Model)
                    marker += 1;
            }
            if (marker == 0)
            {
                Tech_information Tech_information = new Tech_information(Brand, Model, Info);
                Tech_information_list.Add(Tech_information);
                Write_information_to_txt();
            }
        }
    }
       /*Класс техники в магазине*/
    class Technique
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public double Rate { get; set; }
        public int Kol_vo { get; set; }

        public static List<Technique> Technics_list = new List<Technique>();
        public Technique(string _Brand, string _model, string _type = "", double _price = 0, double _rate = 0, int _kol_vo = 0)
        {
            Brand = _Brand;
            Model = _model;
            Type = _type;
            Price = _price;
            Rate = _rate;
            Kol_vo = _kol_vo;
        }

       /*функция удаления пользователя*/
        public static void Delete_user(string Login, string password, string status)
        {
            Users.From_txt_to_accounts_list();
            for (int i = 0; i < Users.accounts_list.Count; i++)
            {
                if (Users.accounts_list[i].Login == Login & Users.accounts_list[i].Password == password & Users.accounts_list[i].Status == status)
                    Users.accounts_list.Remove(Users.accounts_list[i]);                
            }
            Users.Write_User_list_to_txt();
        }
        /*функция добавления пользователя*/
        public static string Add_user(string Login, string password, string status)
        {
            Users.From_txt_to_accounts_list();
            int marker = 0;
            for (int i = 0; i<Users.accounts_list.Count; i++)
            {
                if (Users.accounts_list[i].Login == Login & Users.accounts_list[i].Password == password)
                {
                    marker += 1;
                }
            }
            if (marker == 0)
            {
                string answer = Users.Register(Login, password, status);
                if (answer == "добавлено в список")
                    return "добавлено в список";
                else return "уже есть в списке";
            }
            else return "уже есть в списке";
        }
        /*функция отката всех данных в программе и в БД*/
        public static void reboot()
        {
            Technics_list.Clear();
            Read_file_with_Techniques("reboot.txt");
            StreamWriter writer = new StreamWriter("tovar_list.txt", false, Encoding.UTF8);
            for (int k = 0; k < Technics_list.Count; k++)
            {
                writer.Write(Technics_list[k].Brand + ' ' + Technics_list[k].Model + ' ' + Technics_list[k].Type + ' ' + Technics_list[k].Price + ' ' + Technics_list[k].Rate + ' ' + Technics_list[k].Kol_vo + '\n');
            }
            writer.Close();
            StreamWriter writer1 = new StreamWriter("need_to_buy.txt", false, Encoding.UTF8);
            writer1.Write("");
            writer1.Close();
            StreamWriter writer2 = new StreamWriter("stat_kol_vo.txt", false, Encoding.UTF8);
            writer2.Write("");
            writer2.Close();
            StreamWriter writer3 = new StreamWriter("stat_price.txt", false, Encoding.UTF8);
            writer3.Write("");
            writer3.Close();
        }
        /*Функция для прочтения файла с техникой и записи ее в список*/
        public static void Read_file_with_Techniques(string filename)
        {
            int marker = 0;
            string[] arStr = File.ReadAllLines(filename);
            for (int i = 0; i<arStr.Length; i++)
            {
                string Brand = arStr[i].Split(' ')[0];
                string Model = arStr[i].Split(' ')[1];
                string Type = arStr[i].Split(' ')[2];
                double Price = double.Parse(arStr[i].Split(' ')[3]);
                double Rate = double.Parse(arStr[i].Split(' ')[4]);
                int Kol_vo = int.Parse(arStr[i].Split(' ')[5]);
                for (int j = 0; j < Technics_list.Count; j++)
                {
                    if (Technics_list[j].Brand == Brand & Technics_list[j].Model == Model)
                    {
                        marker += 1;   
                    }
                }
                if (marker == 0)
                {
                    Technique technique = new Technique(Brand, Model, Type, Price, Rate, Kol_vo);
                    Technics_list.Add(technique);
                }
            }
        }
           /*Функция добавления товара в список*/
        public static void Add_Technique(string Brand, string Model, string Type, double Price, double Rate, int Kol_vo)
        {

            int marker = 0;
            for (int i = 0; i < Technics_list.Count; i++)
            {
                if (Technics_list[i].Brand == Brand & Technics_list[i].Model == Model)
                {
                    Technics_list[i].Kol_vo += Kol_vo;
                    marker += 1;
                    StreamWriter writer = new StreamWriter("tovar_list.txt", false, Encoding.UTF8);
                    for (int k = 0; k < Technics_list.Count; k++)
                    {
                        writer.Write(Technics_list[k].Brand + ' ' + Technics_list[k].Model + ' ' + Technics_list[k].Type + ' ' + Technics_list[k].Price + ' ' + Technics_list[k].Rate + ' ' + Technics_list[k].Kol_vo + '\n');
                    }
                    writer.Close();
                }
            }

            if (marker == 0 & Type != " " & Price != 0 & Rate != 0)
            {
                Technique Technique = new Technique(Brand, Model, Type, Price, Rate, Kol_vo);
                Technics_list.Add(Technique);
                StreamWriter writer_lite = new StreamWriter("tovar_list.txt", true, Encoding.UTF8);
                writer_lite.Write(Brand + ' ' + Model + ' ' + Type + ' ' + Price + ' ' + Rate + ' ' + Kol_vo + '\n');
                writer_lite.Close();
            }
        }
        /*Функция для прочтения файла*/
        public static string Read_from_File(string filename)
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
        /*Функция для добавления в список недостающих товаров*/
        public static void need_to_buy(string Brand, string Model, int Kol_vo, double Price)
        {
            StreamWriter writer = new StreamWriter("need_to_buy.txt", true, Encoding.UTF8);
            writer.WriteLine("{0} {1} {2} {3}", Brand, Model, Kol_vo, Price);
            writer.Close();
        }
        /*функция для продажи техники*/
        public static string Sell_Technique(string Brand, string Model, int Kol_vo, string Type = "", double Price = 0, double Rate = 0)
        {
            double total = 0;
            for (int i = 0; i < Technics_list.Count; i++)
            {
                if (Technics_list[i].Brand == Brand & Technics_list[i].Model == Model)
                {
                    if (Technics_list[i].Kol_vo >= Kol_vo)
                    {
                        total += Kol_vo * Technics_list[i].Price;
                        Technics_list[i].Kol_vo -= Kol_vo;
                        StreamWriter writer = new StreamWriter("tovar_list.txt", false, Encoding.UTF8);
                        for (int j = 0; j < Technics_list.Count; j++)
                        {
                            writer.Write(Technics_list[j].Brand + ' ' + Technics_list[j].Model + ' ' + Technics_list[j].Type + ' ' + Technics_list[j].Price + ' ' + Technics_list[j].Rate + ' ' + Technics_list[j].Kol_vo + '\n');
                        }
                        writer.Close();
                        return string.Format("Продан/ы устройство/а модели {0} на сумму {1}!", Brand, total);
                    }
                    else
                    {
                        total += Technics_list[i].Kol_vo * Technics_list[i].Price;
                        double total_money_needs = (Kol_vo - Technics_list[i].Kol_vo) * Technics_list[i].Price;
                        string deficit = string.Format("Не хватает устройств {0}, модели {3}, магазину нужно докупить ещё как минимум {1} на сумму {2}!", Brand, Kol_vo - Technics_list[i].Kol_vo, total_money_needs, Technics_list[i].Model);
                        string sold = string.Format("В итоге устройств фирмы: {1} , модели: {2} продано на сумму: {0}", total, Brand, Technics_list[i].Model);
                        need_to_buy(Brand, Technics_list[i].Model, Kol_vo - Technics_list[i].Kol_vo, total_money_needs);
                        Technics_list[i].Kol_vo = 0;
                        StreamWriter writer = new StreamWriter("tovar_list.txt", false, Encoding.UTF8);
                        for (int j = 0; j < Technics_list.Count; j++)
                        {
                            writer.Write(Technics_list[j].Brand + ' ' + Technics_list[j].Model + ' ' + Technics_list[j].Type + ' ' + Technics_list[j].Price + ' ' + Technics_list[j].Rate + ' ' + Technics_list[j].Kol_vo + '\n');
                        }
                        writer.Close();
                        return (deficit + '\n' + sold);
                    }
                }
            }
            
         return string.Format("Нет устройств фирмы {0} модели {1}!", Brand, Model);
        }
        /*Функция закупки недостающего*/
        public static void zakupka()
        {
            StreamReader reader = new StreamReader("need_to_buy.txt", Encoding.UTF8);
            string[] arStr1 = File.ReadAllLines("need_to_buy.txt", Encoding.UTF8);
            reader.Close();
            for (int i = 0; i < arStr1.Length; i++)
            {
                string Brand = arStr1[i].Split(' ')[0];
                string Model = arStr1[i].Split(' ')[1];
                int Kol_vo = int.Parse(arStr1[i].Split(' ')[2]);
                Add_Technique(Brand, Model, " ", 0, 0, Kol_vo);
            }
            StreamWriter writer = new StreamWriter("need_to_buy.txt", false, Encoding.UTF8);
            writer.Write("");
            writer.Close();
        }
        /*Функция для записи статистики*/
        public static void stats()
        {
            StreamWriter writer = new StreamWriter("stat_price.txt", false, Encoding.UTF8);
            for (int i = 0; i < Technics_list.Count; i++)
            {
                writer.Write(Technics_list[i].Price + " " + Technics_list[i].Model + " ");
            }
            writer.Close();
            StreamWriter writer1 = new StreamWriter("stat_kol_vo.txt", false, Encoding.UTF8);
            for (int i = 0; i < Technics_list.Count; i++)
            {
                writer1.Write(Technics_list[i].Kol_vo + " " + Technics_list[i].Model + " ");
            }
            writer1.Close();
        }
        /*Функция отображения статистики*/
        public static string check_stats()
        {
            int max_kol_vo = 0;
            double max_price = 0;
            int k_p = 0;
            double tot_price = 0;
            int tot_kol_vo = 0;
            double mean = 0;
            for (int i = 0; i < Technics_list.Count; i++)
            {
                k_p += 1;
                tot_price += Technics_list[i].Price;
                tot_kol_vo += Technics_list[i].Kol_vo;
                if (max_price < Technics_list[i].Price)
                    max_price = Technics_list[i].Price;
                if (max_kol_vo < Technics_list[i].Kol_vo)
                    max_kol_vo = Technics_list[i].Kol_vo;
            }
            mean = tot_price / k_p;
            return ("Средняя цена за устройство: " + mean.ToString() + "\n" + "На складе устройств на сумму: " + tot_price.ToString()+"\n" + "Всего устройств на складе:" + tot_kol_vo.ToString() + "\n" + "Всего различных моделей устройств: " + k_p.ToString() + "\n" +
                "Самый дорогое устройство стоит: " + max_price.ToString() + "\n" + "Наибольшее количество устройств одной модели: " + max_kol_vo.ToString()); 
        }
    }
}

