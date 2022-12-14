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
                Steel[] steelList = new Steel[15];
                for (int i = 0; i < steelList.Length; i++)
                {
                    

                    switch (i)
                    {
                        case < 5:
                            steelList[i] = new(random.Next(7600, 8500),
                                   random.Next(1, 11),
                                   random.NextDouble() * 9500 + 500);
                            break;
                        case < 12:
                            steelList[i] = new RectangleList(random.Next(7600, 8500),
                                             random.Next(1, 11),
                                             random.NextDouble() * 9500 + 500,
                                             random.NextDouble() * 9500 + 500);
                            break ;
                        case < 16:
                            steelList[i] = new TriangleList(random.Next(7600, 8500),
                                               random.Next(1, 11),
                                               random.NextDouble() * 9500 + 500,
                                               random.NextDouble() * 9500 + 500);
                            break;
                    }
                }
                double fullArea = 0;
                double fullWeidth = 0;
                for (int i = 0; i < steelList.Length; i++)
                {
                    
                    ConsoleColor color = i % 2 == 0 ? ConsoleColor.White : ConsoleColor.DarkCyan;
                    Console.ForegroundColor = color;
                    Console.WriteLine(steelList[i].Info());
                    fullArea += steelList[i].GetArea();
                    fullWeidth += steelList[i].GetWeight();
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Суммарный вес: {fullWeidth:F1} кг, общая площадь: {fullArea:F2} м2");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Нажмите любую кнопку для генерации новых значений");
                Console.ReadKey();
                Console.Clear();
                Console.ResetColor();
            } while (true);
        }
    }
}