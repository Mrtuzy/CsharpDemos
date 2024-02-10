using System.Reflection.Metadata;

namespace Sayıbulmaoyunu
{
    internal class Program
    {
        static int hak;
        static int sınır;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("SAYI TAHMİN OYUNUNA HOŞ GELDİNİZ");
            Console.BackgroundColor = ConsoleColor.Black;
            Zorluk zorluk = new Zorluk();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Zorluk seçin \nKolay  : 0\nZor    : 1\nOrta   : 2\nCustom : 3");
            Console.Write("seçiminiz: ");
            Console.ForegroundColor = ConsoleColor.White;
            Mode zorlukSecimi = (Mode) Convert.ToInt32(Console.ReadLine());
                switch (zorlukSecimi)
                {
                    case Mode.Kolay:
                        zorluk.Kolay();
                        break;
                    case Mode.Orta:
                        zorluk.Orta();
                        break;
                    case Mode.Zor:
                        zorluk.Zor();
                        break;
                    case Mode.Custom:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Hak sayınız kaç olsun: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        int hakSecimi = Convert.ToInt32(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Oluşturulacak sayı için bir üst limit belirleyin: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        int sınırSecimi = Convert.ToInt32(Console.ReadLine());
                        zorluk.Custom(hakSecimi, sınırSecimi);
                        break;
                }
            Random randomSayı = new Random();
            int arananSayı = randomSayı.Next(1,sınır);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"0 ile {sınır} arası bir sayı arıyorsunuz");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                try
                { 
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Kalan hakkınız: {hak}");
                Console.Write("tahmininiz: ");
                Console.ForegroundColor = ConsoleColor.White;
                int tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin == arananSayı)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bildiniz");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                else if (tahmin > arananSayı)
                {
                    Console.WriteLine("Tahmininizden küçük bir sayı");
                    hak--;
                }
                else if (tahmin < arananSayı)
                {
                    Console.WriteLine("Tahmininizden büyük bir sayı");
                    hak--;
                }
                if (hak == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Kaybettiniz doğru cevap: {0}", arananSayı);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
          

        }
        enum Mode : int
        {
            Kolay,
            Orta,
            Zor,
            Custom
        }

        class Zorluk
        {
            public void Kolay()
            {
                hak = 5;
                sınır = 10;
            }
            public void Orta()
            {
                hak = 5;
                sınır = 20;
            }
            public void Zor()
            {
                hak = 3;
                sınır = 20;
            }
            public void Custom(int _hak,int _sınır)
            {
                hak = _hak;
                sınır = _sınır;
            }
        }
      
       
    }
}