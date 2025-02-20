using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    internal class Avto
    {
        /// <summary>
        /// Поле Марка автомобиля
        /// </summary>
        string brand;
        /// <summary>
        /// Поле Цвет
        /// </summary>
        string color;
        /// <summary>
        /// Поле Скорость
        /// </summary>
        int skor;

        /// <summary>
        /// Свойство Марка автомобиля
        /// </summary>
        public string Brand {
            get { return brand; }
            set { brand = value; }
        }
        /// <summary>
        /// Свойство Цвет
        /// </summary>
        public string Color {
            get { return color; }
            set { color = value; }
        }
        /// <summary>
        /// Свойство Скорость
        /// </summary>
        public int Skor {
            get { return skor; }
            set
            {
                if(value < 20)
                {
                    skor = 20;
                }
                else if(value > 120)
                {
                    skor = 120;
                }
                else
                {
                    skor = value;
                }
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Avto() { }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="brand">Марка автомобиля</param>
        public Avto(string brand)
        {
            Brand = brand;
        }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="brand">Марка автомобиля</param>
        /// <param name="color">Цвет</param>
        public Avto(string brand, string color) : this(brand)
        {
            Color = color;
        }

        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="brand">Марка автомобиля</param>
        /// <param name="color">Цвет</param>
        /// <param name="skor">Скорость</param>
        public Avto(string brand, string color, int skor) : this(brand, color)
        {
            Skor = skor;
        }

        /// <summary>
        /// Метод для вывода значений об объекте
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Марка автомобиля: {Brand}\tЦвет: {Color}\tСкорость: {Skor}";
        }
    }
}
