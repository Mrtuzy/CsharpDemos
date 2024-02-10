using System.Drawing;
using System.Globalization;

namespace RockPaperScissor
{
    internal class Program
    {
        static string tas = """
                _______
            ---'   ____)
                  (_____)
                  (_____)
                  (____)
            ---.__(___)
            """;
        static string kagıt = """
                 _______
            ---'    ____)____
                       ______)
                      _______)
                     _______)
            ---.__________)
            """;
       static string makas = """
                _______
            ---'   ____)____
                      ______)
                   __________)
                  (____)
            ---.__(___)
            """;
      static  Player pc = new Player { playerBildirgeci = "Bilgisayar" };
        static Player oyuncu = new Player { playerBildirgeci = "sen" };
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            //MAİN
            while (true)
            {
                Random random = new Random();
                pc.elSekli = random.Next(1, 4);
                Console.WriteLine("Taş için (1) -- Kağıt için (2) -- Makas için (3)");
                Console.Write("Hamlenizi seçin: ");
                oyuncu.elSekli = Convert.ToInt32(Console.ReadLine());
                Animasyon();
                HamleGostergesiKararı(oyuncu.elSekli, oyuncu.playerBildirgeci);
                HamleGostergesiKararı(pc.elSekli, pc.playerBildirgeci);
                Kontrol(oyuncu.elSekli, pc.elSekli); 
                Console.ReadLine();
                Console.Clear();
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
            }
            
        }
        static void Animasyon()
        {
            
            int sure = 0;
            int animasyonHızı = 100;
            while (sure < 5)
            {
                
                Console.WriteLine(tas); 
                Console.Clear();

                Console.WriteLine(kagıt);
                Thread.Sleep(animasyonHızı);
                Console.Clear();

                Console.WriteLine(makas);
                Thread.Sleep(animasyonHızı);
                Console.Clear();
                sure++;
            }
        }
        static void HamleGostergesi(string şeklinResmi ,string kiminHamlesi)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("{0}'in hamlesi", kiminHamlesi);
            Console.WriteLine(şeklinResmi);
        }
        static void HamleGostergesiKararı(int şekil, string kiminHamlesi)
        {
            
            if ( şekil == 1)
            {
                HamleGostergesi(tas,kiminHamlesi);
            }
            else if (şekil == 2)
            {
                HamleGostergesi(kagıt, kiminHamlesi);
            }
            else if (şekil == 3)
            {
                HamleGostergesi(makas, kiminHamlesi);
            }
            

        }
        static void Kontrol(int hamlen,int pcHamlesi)
        {
            Console.CursorTop = 7;
            Console.CursorLeft = 70;
            if (hamlen==pcHamlesi)
            {
                Console.WriteLine("BERABERE");
            }
            else
            {
                if (hamlen > 1)
                {
                    if (hamlen - 1 == pcHamlesi)
                    {
                        Console.WriteLine("KAZANDIN");
                    }
                    else
                    {
                        Console.WriteLine("KAYBETTİN");
                    }
                }
                else
                {
                    if (hamlen + 2 == pcHamlesi)
                    {
                        Console.WriteLine("KAZANDIN");
                    }
                    else
                    {
                        Console.WriteLine("KAYBETTİN");
                    }
                }
            
            }
            Console.CursorTop = 8;
            Console.CursorLeft = 70;
            Console.Write("Bir daha oynamak için enter'a basın");  
        }
    }
}