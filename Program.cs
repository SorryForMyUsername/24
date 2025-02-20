using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kadry kadr1 = new Kadry();
            kadr1.Fam = "Фамилия";
            kadr1.Age = 30;
            kadr1.Dol = "Должность";
            kadr1.Staj = 7;
            Console.WriteLine(kadr1);
            Console.WriteLine();

            Kadry kadr2 = new Kadry("Фам", 62, "Дол", 46);
            Console.WriteLine(kadr2);
            Console.WriteLine();

            Console.Write("Фамилия: ");
            string fam = Console.ReadLine();
            Console.Write("Возраст: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Должность: ");
            string dol = Console.ReadLine();
            Console.Write("Стаж: ");
            int staj = int.Parse(Console.ReadLine());
            Kadry kadr3 = new Kadry(fam, age, dol, staj);
            Console.WriteLine(kadr3);
            Console.WriteLine();

            Console.ReadKey(true);
        }
    }
}
