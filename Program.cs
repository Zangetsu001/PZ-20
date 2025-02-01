using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        /// <summary>
        /// Основной метод кода 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Build dom1 = new Build();
            dom1.ShowInfo();
            Console.WriteLine();
            dom1.name = "Дача";
            dom1.area = 600.5;
            dom1.kvo = 3;
            dom1.ShowInfo();
            Console.WriteLine();
            //Build dom2 = new Build("Отель");
            //Build dom2 = new Build("Отель", 6000);
            Build dom2 = new Build("Отель", 6000, 1500);
            Console.WriteLine($"{dom2.ToString()}");
            Console.WriteLine();
            Console.Write("Название строения: ");
            string name = Console.ReadLine();
            Console.Write("Площадь строения: ");
            double area = double.Parse(Console.ReadLine());
            Console.Write("Количество жильцов: ");
            int kvo = int.Parse(Console.ReadLine());
            Console.Write("Количество этажей: ");
            int floor = int.Parse(Console.ReadLine());
            Build dom3 = new Build(name, area, kvo, floor);
            Console.WriteLine($"{dom3.ToString()}");
            Console.Read();
        }
    }
}
