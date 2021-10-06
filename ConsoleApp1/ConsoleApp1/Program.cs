using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Programz
    {
        static void Main(string[] args)
        {
         
            Console.Write("Введите а=> _\b");
            string str = Console.ReadLine();
            double a= Convert.ToDouble(str);
            Console.Write("Введите b=> _\b");
            str = Console.ReadLine();
            double b = Convert.ToDouble(str);
            Console.Write("Введите c=> _\b");
            str = Console.ReadLine();
            double c = Convert.ToDouble(str);
            Console.WriteLine("--------------------");
            double dis = b * b - 4 * a * c;
            if (dis < 0)
            {
                Console.WriteLine("Нет действительных корней");

            }
            else
            {
                double x = (-b - Math.Sqrt(dis)) / (2 * a);
                double x1 = (-b + Math.Sqrt(dis)) / (2 * a);
                if (x == x1)
                {
                    Console.WriteLine("x={0}", x);
                }
                else
                {
                    Console.WriteLine("x={0}", x);
                    Console.WriteLine("x={0}", x1);
                }
            }
         
            

            while (Console.ReadKey().Key != ConsoleKey.Escape) ;
        }
    }
}
