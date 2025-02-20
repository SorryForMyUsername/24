using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avto avto1 = new Avto();
            avto1.Brand = "Брэнд";
            avto1.Color = "Синий";
            avto1.Skor = 80;
            Console.WriteLine(avto1);

            Avto avto2 = new Avto("БМВ", "Зелёный", 150);
            Console.WriteLine(avto2);

            Console.Write("Бренд автомобиля: ");
            string brand = Console.ReadLine();
            Console.Write("Цвет автомобиля: ");
            string color = Console.ReadLine();
            Console.Write("Скорость автомобиля: ");
            int skor = int.Parse(Console.ReadLine());
            Avto avto3 = new Avto(brand, color, skor);
            Console.WriteLine(avto3);

            Console.ReadKey(true);
        }
    }
}
