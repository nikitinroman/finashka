namespace Olimp.Models
{
    static class User
    {
        static public int Id { get; set; }//подготовлено для использование в таблице бд
        static public int Level { get; set; }//уровень доступа 0, просто просматривать данные, 1 возможность изменять данные
        static  public int Name { get; set; }//вдруг захотим вывести в лайбле главной формы имя пользователя
    }
}
