using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworklesson1109
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание2.1");
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");

            Console.WriteLine("Задание2.2");
            int g = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            if (h == 0)
            {
                Console.WriteLine("Не делится");
            }
            else Console.WriteLine(g / h);

            Console.WriteLine("Задание2.1");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'z') Console.WriteLine("a");
            else if (letter == 'я') Console.WriteLine("а");
            else Console.WriteLine(++letter);

            Console.WriteLine("Задание2.2");
            Console.WriteLine("Решение квадратного уравнения");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double x1, x2, discriminant;
            discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет корней");
            }
            else
            {
                if (discriminant == 0)
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }
            Console.ReadKey();
        }
    }
}
