using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Персональный компьютер
    /// </summary>
    internal class Personal_Computer
    {
        /// <summary>
        /// название модели
        /// </summary>
        public string Model;
        /// <summary>
        /// тактовая частота процессора
        /// </summary>
        public double ProcessorFrequency;
        /// <summary>
        /// обьем оперативной памяти
        /// </summary>
        public int RAM;
        /// <summary>
        /// обьем жесткого диска
        /// </summary>
        public int HDD;
        
        /// <summary>
        /// Основной метод
        /// </summary>
        public Personal_Computer() { }
        /// <summary>
        /// Конструктор с 1 параметром
        /// </summary>
        /// <param name="model"></param>
        public Personal_Computer(string model)
        {
            this.Model = model;
        }
        /// <summary>
        /// Конструктор с 2 параметрами
        /// </summary>
        /// <param name="model"></param>
        /// <param name="ProcessorFrequency"></param>
        public Personal_Computer(string model, double processor_frequency) : this(model)
        {
            this.ProcessorFrequency = processor_frequency;
        }
        /// <summary>
        /// Конструктор с 3 параметрами
        /// </summary>
        /// <param name="model"></param>
        /// <param name="processor_frequency"></param>
        /// <param name="ram"></param>
        public Personal_Computer(string model, double processor_frequency, int ram) : this(model, processor_frequency)
        {
            RAM = ram;
        }
        /// <summary>
        /// Конструктор с 4 параметрами
        /// </summary>
        /// <param name="model"></param>
        /// <param name="processor_frequency"></param>
        /// <param name="ram"></param>
        /// <param name="hdd"></param>
        public Personal_Computer(string model, double processor_frequency, int ram, int hdd) : this(model, processor_frequency, ram)
        {
            HDD = hdd;
        }

        /// <summary>
        /// Вывод информации
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Название модели: {Model}, тактовая частота  процессора (ГГц): {ProcessorFrequency}," +
                $" обьем оперативной памяти(ГБ): {RAM}, обьем жесткого диска(ГБ): {HDD}");
        }

        /// <summary>
        /// Вывод информации через метод ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Название модели: {Model}, тактовая частота  процессора (ГГц): {ProcessorFrequency}," +
                $" обьем оперативной памяти(ГБ): {RAM}, обьем жесткого диска(ГБ): {HDD}";
        }
    }
}
