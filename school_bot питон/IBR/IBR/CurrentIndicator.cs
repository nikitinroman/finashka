
namespace IBR
{
    public static class CurrentIndicator//класс текущего показателя
    {
        private static int regionId;//id региона
        private static string year;//год
        private static string avr;//значение
        private static string vlajnost;
        private static string davlenie;
        private static string veter;
        private static string osadki;

        public static int RigId//геттер сеттер получения id региона
        {
            set { regionId = value; }
            get { return regionId; }
        }

        public static string Year//геттер сеттер получения года
        {
            set { year = value; }
            get { return year; }
        }

        public static string Avr//геттер сеттер получения показателя
        {
            set { avr = value; }
            get { return avr; }
        }

        public static string Vlajnost//геттер сеттер получения показателя
        {
            set { vlajnost = value; }
            get { return vlajnost; }
        }

        public static string Davlenie//геттер сеттер получения показателя
        {
            set { davlenie = value; }
            get { return davlenie; }
        }

        public static string Veter//геттер сеттер получения показателя
        {
            set { veter = value; }
            get { return veter; }
        }

        public static string Osadki//геттер сеттер получения показателя
        {
            set { osadki = value; }
            get { return osadki; }
        }
    }
}
