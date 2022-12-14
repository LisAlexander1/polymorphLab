using System;

namespace polymorphLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();

            do
            {
                Steel square = new(random.Next(7600, 8500),
                                   random.Next(1, 11),
                                   random.NextDouble()*9500+500);

                Steel tri = new TriangleList(random.Next(7600, 8500),
                                             random.Next(1, 11),
                                             random.NextDouble() * 9500 + 500,
                                             random.NextDouble() * 9500 + 500);

                Steel rect = new RectangleList(random.Next(7600, 8500),
                                               random.Next(1, 11),
                                               random.NextDouble() * 9500 + 500,
                                               random.NextDouble() * 9500 + 500);

                Console.WriteLine(square.Info());
                Console.WriteLine(tri.Info());
                Console.WriteLine(rect.Info());
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Нажмите любую кнопку для генерафции новых значений");
                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
            } while (true);
        }
    }
}