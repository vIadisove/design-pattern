using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace LR
{
    class Program
    {
        static void Main(string[] args)
        {
            RedheadDuck duck1 = new RedheadDuck();
            Mallart duck2 = new Mallart();

            Duck[] mas = new Duck[] { duck1, duck2 };

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i].Swim());
                Console.WriteLine(mas[i].Display());
                Console.WriteLine(mas[i].Quack());
            }

            Console.ReadKey();
        }
    }
}
