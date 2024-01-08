using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значение угла в °:");
                int gradus = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение угла в ':");
                int min = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение угла в '':");
                int sec = Convert.ToInt32(Console.ReadLine());
                Degrees degrees = new Degrees(gradus, min, sec);
                double radians = degrees.ToRadians();
                Console.WriteLine("Угол в радианах: {0}", radians);
                Console.ReadKey();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

        }
    }
}
