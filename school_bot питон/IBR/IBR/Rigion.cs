
namespace IBR
{
    public class Rigion//класс регион
    {
        private int id;//поле id региона
        private string rigion;//поле имя региона

        public string Rig//геттер получения имени региона
        {
            get { return rigion; }
        }

        public int Id//геттер получения id региона
        {
            get { return id; }
        }

        public Rigion(int id, string rig)//конструктор класса
        {
            this.id = id;//присваиваем данные текущему экземпляру
            this.rigion = rig;
        }
    }
}
