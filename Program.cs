using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ввод через программу 
            Personal_Computer pc1 = new Personal_Computer();
            pc1.Info();
            pc1.Model = "ASUS";
            pc1.ProcessorFrequency = 6.5;
            pc1.RAM = 32;
            pc1.HDD = 1024;
            
            //Ввод через консоль
            Console.WriteLine("Введите модель ПК:");
            string model = Console.ReadLine();

            Console.WriteLine("Введите тактовую частоту процессора (ГГц):");
            double processorFrequency = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите объем оперативной памяти (ГБ):");
            int ram = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите объем жесткого диска (ГБ):");
            int hdd = int.Parse(Console.ReadLine());

            Personal_Computer pc2 = new Personal_Computer(model, processorFrequency, ram, hdd);
            Console.WriteLine($"{pc2.ToString()}");

            Console.Read();
        }
    }
}
