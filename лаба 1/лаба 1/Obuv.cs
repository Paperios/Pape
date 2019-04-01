using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_1
{
    class Obuv
    {
        public string Name { get; set; } // Имя 
        public float Razmer { get; set; } //Размер 
        public double Cena { get; set; } //Цена 
        public Obuv()
        {
            Name = null;
            Razmer= 0;
            Cena = 0;
        }
        public void GetInfo()
        {
            Console.WriteLine("Имя: {0} Размер: {1} Цена: {2}", Name, Razmer, Cena);
        }
        public void SetInfo()
        {
            Console.WriteLine("Введите имя: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите цена: ");
            Razmer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите размер: ");
            Cena = Double.Parse(Console.ReadLine());
        }
    }



}
