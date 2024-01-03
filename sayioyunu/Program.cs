namespace sayioyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Oyuna Hoş Geldiniz!");

            while (true)
            {
                Console.WriteLine("Kolay, Orta, Zor seviyeyi seç:");
                Console.WriteLine("Kolay seviye için 1, Orta seviye için 2, Zor seviye için 3 gir:");

                int maxTries = 0;
                int level = int.Parse(Console.ReadLine());

                if (level == 1)
                {
                    maxTries = 8;
                }
                else if (level == 2)
                {
                    maxTries = 9;
                }
                else if (level == 3)
                {
                    maxTries = 2;
                }
                else
                {
                    Console.WriteLine("Geçersiz seviye seçtiniz.");
                    return;
                }

                Random random = new Random();
                int randomNumber = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı seçin

                Console.WriteLine($"Tahmin etmek için 1 ile 100 arasında bir sayı gir. {maxTries} hakkınız var:");

                for (int i = 0; i < maxTries; i++)
                {
                    int guess = int.Parse(Console.ReadLine());

                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Daha yüksek bir sayı gir.");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Daha düşük bir sayı gir.");
                    }
                    else
                    {
                        Console.WriteLine("Tebrikler, doğru sayıyı buldun");

                        if (level == 1)
                        {
                            Console.WriteLine("Orta seviyeye geçmek istiyor musun? (Evet/Hayır)");
                            string response = Console.ReadLine().ToLower();
                            if (response == "evet")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Oyunumuza vakit ayırdığınız için teşekkürler.");
                                return;
                            }
                        }
                        else if (level == 2)
                        {
                            Console.WriteLine("Zor seviyeye geçmek istiyor musun? (Evet/Hayır)");
                            string response = Console.ReadLine().ToLower();
                            if (response == "evet")
                            {
                                maxTries = 3;
                                level = 3;
                                randomNumber = random.Next(1, 101);
                                Console.WriteLine($"Tahmin etmek için 1 ile 100 arasında bir sayı gir. {maxTries} hakkınız var:");
                            }
                            else
                            {
                                Console.WriteLine("Oyunumuza vakit ayırdığın için teşekkürler.");
                                return;
                            }
                        }
                        else if (level == 3)
                        {
                            Console.WriteLine("Tekrar oynamak istiyor musun? (Evet/Hayır)");
                            string response = Console.ReadLine().ToLower();
                            if (response == "evet")
                            {
                                maxTries = 3;
                                i = -1;
                                randomNumber = random.Next(1, 101);
                                Console.WriteLine($"Tahmin etmek için 1 ile 100 arasında bir sayı gir. {maxTries} hakkınız var:");
                            }
                            else
                            {
                                Console.WriteLine("Oyunumuza vakit ayırdığın için teşekkürler.");
                                return;
                            }
                        }
                    }
                }

                Console.WriteLine($"Tahmin hakkınız bitmiştir. Doğru sayı: {randomNumber}. Oyunu tekrar oynamak istiyor musun? (Evet/Hayır)");
                string again = Console.ReadLine().ToLower();
                if (again != "evet")
                {
                    Console.WriteLine("Oyunumuza vakit ayırdığın için teşekkürler.");
                    break;
                }
            }
        }
    }
}