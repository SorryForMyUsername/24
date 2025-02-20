using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_3
{
    internal class Kadry
    {
        /// <summary>
        /// Поле Фамилия
        /// </summary>
        string fam;
        /// <summary>
        /// Поле Возраст
        /// </summary>
        int age;
        /// <summary>
        /// Поле Должность
        /// </summary>
        string dol;
        /// <summary>
        /// Поле Стаж
        /// </summary>
        int staj;

        /// <summary>
        /// Свойство Фамилия
        /// </summary>
        public string Fam {
            get { return fam; }
            set { fam = value; }
        }
        /// <summary>
        /// Свойство Возраст
        /// </summary>
        public int Age {
            get { return age; }
            set
            {
                age = value < 16 
                    ? 16 
                    : value > 60 ? 60 : value;
            }
        }
        /// <summary>
        /// Свойство Должность
        /// </summary>
        public string Dol {
            get { return  dol; }
            set { dol = value; }
        }
        /// <summary>
        /// Свойство Стаж
        /// </summary>
        public int Staj {
            get { return staj; }
            set
            {
                staj = value < 0
                    ? 0
                    : value > 45 ? 45 : value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Kadry() { }

        /// <summary>
        /// Конструктор с четырьмя параметрами
        /// </summary>
        /// <param name="fam">Фамилия</param>
        /// <param name="age">Возраст</param>
        /// <param name="dol">Должность</param>
        /// <param name="staj">Стаж</param>
        public Kadry(string fam, int age, string dol, int staj)
        {
            Fam = fam;
            Age = age;
            Dol = dol;
            Staj = staj;
        }

        public override string ToString()
        {
            return $"Фамилия: {Fam}\tВозраст: {Age}\tДолжность: {Dol}\tСтаж: {Staj}";
        }
    }
}
