﻿namespace _12_1_5
{
    internal class Program
    {
        // диаграмма находится в image.png
        class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; }
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
        static void IsPrem(List<User> uses)
        {
            foreach (User u in uses)
            {
                if (!u.IsPremium)
                    ShowAds();
                Console.WriteLine($"{u.Name}");
            }
           
            
            
        }
    }
}
