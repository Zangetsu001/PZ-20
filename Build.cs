using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    /// <summary>
    /// класс проекта строения 
    /// </summary>
    internal class Build
    {
        /// <summary>
        /// название строения 
        /// </summary>
        public string name;
        /// <summary>
        /// площадь строения 
        /// </summary>
        public double area;
        /// <summary>
        /// количество жильцов
        /// </summary>
        public int kvo;
        /// <summary>
        /// количество этажей
        /// </summary>
        public int floor;

        /// <summary>
        /// конструктор по умолчанию или без параметров
        /// </summary>
        /// <param name = "name">name</param>

        public Build() { }

        public Build(string name)
        {
            this.name = name;
        }
        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="area"></param>
        public Build(string name, double area) : this(name)
        {
            this.area = area;
        }
        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="name"></param>
        /// <param name="area"></param>
        /// <param name="kvo"></param>
        public Build(string name, double area, int kvo) : this(name, area)
        {
            this.kvo = kvo;
        }
        /// <summary>
        /// Конструктор с четырьмя параметрами  
        /// </summary>
        /// <param name="name">название</param>
        /// <param name="area">площадь</param>
        /// <param name="kvo">количество жителей</param>
        /// <param name="floor">количество этажей</param>
        public Build(string name, double area, int kvo, int floor) : this(name, area, kvo)
        {
            this.floor = floor;
        }

        /// <summary>
        /// Методом в ShowInfo, который выводит информацию о строении
        /// и вычисляет площадь на 1 жильца
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"В доме {name} площадью {area} кв. метров живет {kvo} человек, " +
                $"на человекека - {area / kvo:f2} кв. метров ");
        }
        public override string ToString()
        {
            return $"В доме {name} площадью {area} кв. метров живет {kvo} человек, " +
                $"на человекека - {area / kvo:f2} кв. метров ";
        }

    }
}