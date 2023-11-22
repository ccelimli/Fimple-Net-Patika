namespace ClassInstance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Çalışan 1******");
            Calisan calisan1 = new Calisan("Çağatay", "Çelimli", 698548, "Java Backend Developer");
            calisan1.CalisanBilgileri();

            Console.WriteLine("*****Çalışan 2******");
            Calisan calisan2 = new Calisan();
            calisan1.Ad = "İkinci";
            calisan1.Soyad = "Çalışan";
            calisan1.No = 584588;
            calisan1.Departman = ".Net Backend Developer";
            calisan1.CalisanBilgileri();

            Console.WriteLine("*****Çalışan 3******");
            Calisan calisan3 = new Calisan("Üçüncü", "Çalışan");
            calisan3.CalisanBilgileri();
        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public Calisan(string Ad, string Soyad, int No, string Departman)
            {
                this.Ad = Ad;
                this.Soyad = Soyad;
                this.No = No;
                this.Departman = Departman;
            }
            public Calisan() { }

            public Calisan(string Ad, string Soyad)
            {
                this.Ad= Ad;
                this.Soyad= Soyad;
            }
            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışanın Adı: {0}", Ad);
                Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
                Console.WriteLine("Çalışanın Numarası: {0}", No);
                Console.WriteLine("Çalışanın Departmanı: {0}", Departman);
            }
        }
    }
}