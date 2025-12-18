using System;
using System.Globalization;

namespace BmiCalculator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Вычисления индекса массы тела (ИМТ)\n");

            
            double heightM;
            while (true)
            {
                Console.Write("Введите рост (в сантиметрах): ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double heightCm) && heightCm > 0)
                {
                    heightM = heightCm / 100.0; 
                    break;
                }
                Console.WriteLine("❌ Некорректный ввод. Рост должен быть положительным числом.");
            }

            
            double weightKg;
            while (true)
            {
                Console.Write("Введите вес (в килограммах): ");
                if (double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out weightKg) && weightKg > 0)
                {
                    break;
                }
                Console.WriteLine("❌ Некорректный ввод. Вес должен быть положительным числом.");
            }

            
            double bmi = weightKg / (heightM * heightM);

            
            string description;
            if (bmi < 18.5)
                description = "ниже нормального";
            else if (bmi <= 24.9)
                description = "нормальный";
            else
                description = "выше нормального";

            
            Console.WriteLine($"\nИМТ = {bmi:F1} — {description}");

        }
    }
}