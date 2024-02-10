namespace Csuygulamalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaçarlı saymak istediğinizi girin: ");
            int artıs = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kaçtan başlamak istediğinizi girin: ");
            int baslangıc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kaça kadar saymak istediğinizi girin: ");
            int bitis = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor= ConsoleColor.Green;
            while (baslangıc<=bitis) 
            {
                Console.WriteLine(baslangıc);
                baslangıc = baslangıc + artıs;
                Thread.Sleep(100);
                
            }
            Console.ForegroundColor= ConsoleColor.White;
        }

    }
}