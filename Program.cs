namespace ödev_oyun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hak = 0, sehir;
            Random rasgele = new Random();
            sehir = rasgele.Next(1, 5);
            do 
            {
                if (sehir == 1)
                {
                    Console.WriteLine("Çiğ köftesiyle meşhur şehir");
                    string cevap1 = Console.ReadLine();
                    if (cevap1 == "Şanlıurfa")
                    {
                        hak += 10;
                        Console.WriteLine("Tebrikler");
                        Console.WriteLine($"Skorunuz: {hak}");
                        Random rasgele2= new Random();
                        sehir = rasgele2.Next(2, 5);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış cevap :( Biraz daha düşün al sana bir ipucu\n ...lıyım ezelden");
                    }
                }
                if (sehir == 2)
                {
                    Console.WriteLine("Bu şehir hamsiyi çok sever");
                    string cevap2 = Console.ReadLine();
                    if (cevap2 == "Trabzon")
                    {
                        hak += 10;
                        Console.WriteLine("Tebrikler");
                        Console.WriteLine($"Skorunuz: {hak}");
                        Random rasgele3 = new Random();
                        sehir = rasgele3.Next(3, 5);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış cevap :( Biraz daha düşün al sana bir ipucu\n 4 büyüklerde takımı var");
                    }
                }
                if (sehir == 3)
                {
                    Console.WriteLine("Bu şehir çok kalabalık?");
                    string cevap3 = Console.ReadLine();
                    if (cevap3 == "İstanbul")
                    {
                        hak += 10;
                        Console.WriteLine("Tebrikler");
                        Console.WriteLine($"Skorunuz: {hak}");
                        Random rasgele4 = new Random();
                        sehir = rasgele4.Next(4, 5);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış cevap :( Biraz daha düşün al sana bir ipucu\n Trafik çok yoğun");
                    }
                }
                if (sehir == 4)
                {
                    Console.WriteLine("Bu şehir kayısısı ile meşhur");
                    string cevap4 = Console.ReadLine();
                    if (cevap4 == "Malatya")
                    {
                        hak += 10;
                        Console.WriteLine("Tebrikler");
                        Console.WriteLine($"Skorunuz: {hak}");
                        Random rasgele5 = new Random();
                        sehir = rasgele5.Next(5, 5);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış cevap :( Biraz daha düşün al sana bir ipucu\n ...ya ...ya eşin");
                    }
                }
                if (sehir == 5)
                {
                    Console.WriteLine("Bu şehir Türkiye'nin merkezinde?");
                    string cevap5 = Console.ReadLine();
                    if (cevap5 == "Ankara")
                    {
                        hak += 10;
                        Console.WriteLine("Tebrikler");
                        Console.WriteLine($"Skorunuz: {hak}");
                    }
                    else
                    {
                        Console.WriteLine("Yanlış cevap :( Biraz daha düşün al sana bir ipucu\n Bu şehir bi başka Başkent");
                    }
                }
            }
            while (hak!=50);

        }
    }
}
