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
        /// Поле Модель автомобиля
        /// </summary>
        string model;

        /// <summary>
        /// Поле Цвет
        /// </summary>
        string color;

        /// <summary>
        /// Поле Скорость
        /// </summary>
        int skor;

        /// <summary>
        /// Свойство Модель автомобиля
        /// </summary>
        public string Model {
            get 
            {
                if(model == null || model == "")
                {
                    return "Неизвестный";
                }
                return model;
            }
            set { model = value; }
        }

        /// <summary>
        /// Свойство Цвет
        /// </summary>
        public string Color {
            get
            {
                if(color == null || color == "")
                {
                    return "Неизвестный";
                }
                return color;
            }
            set { color = value; }
        }

        /// <summary>
        /// Свойство Скорость
        /// </summary>
        public int Skor {
            get { return skor; }
            set
            {
                if(value < 60)
                {
                    skor = 60;
                }
                else if(value > 150)
                {
                    skor = 150;
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
        /// <param name="brand">Модель автомобиля</param>
        public Avto(string brand)
        {
            Model = brand;
        }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="brand">Модель автомобиля</param>
        /// <param name="color">Цвет</param>
        public Avto(string brand, string color) : this(brand)
        {
            Color = color;
        }

        /// <summary>
        /// Конструктор с тремя параметрами
        /// </summary>
        /// <param name="brand">Модель автомобиля</param>
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
            return $"Марка автомобиля: {Model}\tЦвет: {Color}\tСкорость: {Skor}";
        }
    }
}
