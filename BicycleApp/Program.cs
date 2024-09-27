using BicycleLibrary;
using System;

namespace BicycleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть кількість велосипедів: ");
            int numberOfBicycles = int.Parse(Console.ReadLine());

            Bicycle[] bicycles = new Bicycle[numberOfBicycles];

            for (int i = 0; i < numberOfBicycles; i++)
            {
                Console.WriteLine($"\n----- Введіть дані для велосипеда #{i + 1} -----");

                bicycles[i] = new Bicycle();

                Console.Write("Марка: ");
                bicycles[i].Brand = Console.ReadLine();

                Console.Write("Модель: ");
                bicycles[i].Model = Console.ReadLine();

                Console.Write("Рік випуску: ");
                bicycles[i].Year = int.Parse(Console.ReadLine());

                Console.Write("Тип велосипеда (гірський, міський тощо): ");
                bicycles[i].Type = Console.ReadLine();

                Console.Write("Вага (кг): ");
                bicycles[i].Weight = double.Parse(Console.ReadLine());

                Console.Write("Матеріал рами: ");
                bicycles[i].FrameMaterial = Console.ReadLine();

                Console.Write("Кількість швидкостей: ");
                bicycles[i].GearCount = int.Parse(Console.ReadLine());

                Console.Write("Пробіг (км): ");
                bicycles[i].Mileage = double.Parse(Console.ReadLine());

                Console.Write("Введіть пройдену відстань (км): ");
                double distance = double.Parse(Console.ReadLine());

                Console.Write("Введіть час (у годинах): ");
                double time = double.Parse(Console.ReadLine());

                double averageSpeed = bicycles[i].GetAverageSpeed(distance, time);
                Console.WriteLine($"Середня швидкість: {averageSpeed} км/год");

                Console.WriteLine("-----");
            }

            Console.WriteLine("\n----- Інформація про всі велосипеди -----");
            foreach (var bike in bicycles)
            {
                bike.DisplayInfo();
                Console.WriteLine("-----");
            }

            Console.ReadLine();
        }
    }
}
